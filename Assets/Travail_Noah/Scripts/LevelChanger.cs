using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LevelChanger : MonoBehaviour
{
    

    public Animator animator;
    public GameObject background;
    public Sprite endBackground;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void FadeToLevel()
    {
        Debug.Log("ee");
        animator.SetTrigger("FadeOut");
    }
    public void OnFadeCompleted()
    {
        background.GetComponent<Image>().sprite = endBackground;
    }
}
