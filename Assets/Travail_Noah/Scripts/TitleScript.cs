using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TitleScript : MonoBehaviour
{
    public GameObject optionCanvas;
    public GameObject normalCanvas;
    public GameObject comandeCanvas;

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
        if (normalCanvas != null)
            normalCanvas.SetActive(false);
    }
    public void ExitOption()
    {
        optionCanvas.SetActive(false);
        if (normalCanvas!=null)
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
    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void Credit()
    {
        SceneManager.LoadScene(2);
    }
}
