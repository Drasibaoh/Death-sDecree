using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EndingDialogue : MonoBehaviour
{
    public List<string> dialoguesP1;
    public List<bool> isPlayer;
    public Text player;
    public Text other;
    public int current;
    public int transition;
    public GameObject outro;
    public LevelChanger fade;
    void Update()
    {

    }
    void Start()
    {
        player = this.GetComponent<Text>();
        other.text = dialoguesP1[current];
    }

    public void NextLine()
    {
        if (GameManager._instance.end)
        {
            current++;
            if (current > dialoguesP1.Count - 1)
            {
                outro.SetActive(false);
                Application.Quit();
            }
            else
            {
                if (transition == current)
                {
                    Debug.Log("e");
                    fade.FadeToLevel();
                }
                if (isPlayer[current])
                {
                    player.text = dialoguesP1[current];
                }
                else
                {
                    other.text = dialoguesP1[current];
                }
            }
        }
    }
}
