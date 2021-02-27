using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class TitleScript : MonoBehaviour
{
    public GameObject optionCanvas;
    public GameObject normalCanvas;
    public GameObject comandeCanvas;
    //public AudioMixer mixer;

    void Start()
    {
        
    }


    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void EnterOption()
    {
        optionCanvas.SetActive(true);
        normalCanvas.SetActive(false);
    }
    public void ExitOption()
    {
        optionCanvas.SetActive(false);
        normalCanvas.SetActive(true);
    }
    public void EnterComande()
    {
        comandeCanvas.SetActive(true);
        optionCanvas.SetActive(false);
    }
    public void ExitComande()
    {
        comandeCanvas.SetActive(false);
        optionCanvas.SetActive(true);
    }
   /* public void SetVolume(float sliderValue)
    {
        mixer.SetFloat("MusicVolume",Mathf.Log10( sliderValue)*20);
    }*/
}
