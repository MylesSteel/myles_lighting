using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.XR.Interaction.Toolkit;

public class VignetteApplierScript : MonoBehaviour
{
    public float intensity = 0.75f;
    public float duration = 0.5f;
    public Volume volume = null;

    //refrence providers 
    private LocomotionProvider locomotionProvider = null;
    private Vignette vignette = null;


    private void Awake()
    {
        locomotionProvider = GetComponent<LocomotionProvider>();

        if (volume.profile.TryGet(out Vignette vignette))
            this.vignette = vignette;
    }

    private void OnEnable()
    {
        locomotionProvider.beginLocomotion += FadeIn;
        locomotionProvider.endLocomotion += FadeOut;
    }
    private void OnDisable()
    {
        locomotionProvider.beginLocomotion -= FadeIn;
        locomotionProvider.endLocomotion -= FadeOut;
    }
    public void FadeIn(LocomotionSystem locomotionSystem)
    {
        StartCoroutine(Fade(0, intensity));
    }
    public void FadeOut(LocomotionSystem locomotionSystem)
    {
        StartCoroutine(Fade(intensity, 0));
    }
    private IEnumerator Fade(float startValue, float endValue)
    {
        float elapsedTime = 0.0f;

        while (elapsedTime <= duration)
        {

            float blend = elapsedTime / duration;
            elapsedTime += Time.deltaTime;

            float intesnity = Mathf.Lerp(startValue, endValue, blend);
            ApplyValue(intensity);

            yield return null;
        }
    }
    private void ApplyValue(float value)
    {
        vignette.intensity.Override(value);
    }
    

}
