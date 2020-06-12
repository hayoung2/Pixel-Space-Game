using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Volume : MonoBehaviour
{
    public Slider backImage;
    public AudioSource audioSource;
    private float volume = 1f;

    void Start()
    {
        volume = PlayerPrefs.GetFloat("volume", 1f);
        backImage.value = volume;
        audioSource.volume = backImage.value;
    }


    void Update()
    {
        SlideVolume();    
    }

    public void SlideVolume()
    {
        audioSource.volume = backImage.value;
        volume = backImage.value;
        PlayerPrefs.SetFloat("volume", volume);
    }
}
