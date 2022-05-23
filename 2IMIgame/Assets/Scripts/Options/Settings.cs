using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{

    public static bool retroFX = true;

    public Dropdown resDropdown;

    Resolution[] resolutions;

    // Resolution
    void Start()
    {

        resolutions = Screen.resolutions;

        // Clear out resolution dropdown options
        resDropdown.ClearOptions();

        // List of resolution options
        List<string> options = new List<string>();

        int currentResIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option); // Displays resolutions and adds them to the list

            // Compares width & height of resolutions, and if the matchup is correct, the resolution is stored in the dropdown
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResIndex = i;
            }
        }

        resDropdown.AddOptions(options); // Resolustions are added to the dropdown
        resDropdown.value = currentResIndex;
        resDropdown.RefreshShownValue();

    }

    public void SetResolution(int resIndex)
    {

        Resolution resolution = resolutions[resIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");

    }

    // Volume
    public void SetVolume (bool audioOn)
    {

        if (audioOn != true)
        {
            AudioListener.volume = 0;
        } else
        {
            AudioListener.volume = 1;
        }

        FindObjectOfType<AudioManager>().Play("LevelSelectClick");

    }

    // Graphics
    public void SetQuality(int qualityIndex)
    {

        QualitySettings.SetQualityLevel(qualityIndex);
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");

    }

    // Style
    public void SetStyle(int styleIndex)
    {
        
        if (styleIndex == 0)
        {
            retroFX = true;
        }

        if (styleIndex == 1)
        {
            retroFX = false;
        }

        FindObjectOfType<AudioManager>().Play("LevelSelectClick");

    }

    // FullScreen
    public void SetFullScreen(bool isFullScreen)
    {

        Screen.fullScreen = isFullScreen;
        FindObjectOfType<AudioManager>().Play("LevelSelectClick");

    }

    // Return
    public void Return()
    {
        SceneManager.LoadScene("Options");
        FindObjectOfType<AudioManager>().Play("ButtonClick");
    }

}
