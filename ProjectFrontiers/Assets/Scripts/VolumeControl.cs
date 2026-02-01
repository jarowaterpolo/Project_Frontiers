using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioMixer MasterVolume;
    public TMP_Text PercentText;
    public string AudioParameter;

    private void Start()
    {
        volumeSlider.value = 1;
        PercentText.text = Mathf.Round(volumeSlider.value * 100) + "";
    }
    public void SetVolume(float SliderValue)
    {
        if (SliderValue == 0)
        {
            MasterVolume.SetFloat(AudioParameter, 0);
        }
        else
        {
            MasterVolume.SetFloat(AudioParameter, Mathf.Log10(SliderValue) * 20);
        }
        PercentText.text = Mathf.Round(SliderValue * 100) + "";
    }
}
