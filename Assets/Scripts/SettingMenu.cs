using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class SettingMenu : MonoBehaviour
{
    public GameObject StartMenu;
    public AudioMixer BGMixer;
    Resolution[] resolutions;
    public Dropdown resolutionDropdown;
    private void Start()
    {
        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> optionsList = new List<string>();

        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            optionsList.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }
        resolutionDropdown.AddOptions(optionsList);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void ReturnBack()
    {
        gameObject.SetActive(false);
        StartMenu.SetActive(true);
    }

    public void SetBGM(float BackGroundVolume)
    {
        Debug.Log(BackGroundVolume);
        BGMixer.SetFloat("BGMVolume", BackGroundVolume);
    }

    public void Efforts(int EffortsIndex)
    {
        QualitySettings.SetQualityLevel(EffortsIndex + 3);
    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
