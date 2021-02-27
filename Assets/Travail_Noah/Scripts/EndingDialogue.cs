using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EndingDialogue : MonoBehaviour
{
    public List<string> dialogues;
    public List<bool> isPlayer;
    public Text player;
    public Text other;
    public int current;
    public GameObject outro;
    void Update()
    {

    }
    void Start()
    {
        player = this.GetComponent<Text>();
        other.text = dialogues[current];
    }

    public void NextLine()
    {
        if (GameManager._instance.end)
        {
            current++;
            if (current > dialogues.Count - 1)
            {
                outro.SetActive(false);
                SceneManager.LoadScene(1);
            }
            else
            {
                if (isPlayer[current])
                {
                    player.text = dialogues[current];
                }
                else
                {
                    other.text = dialogues[current];
                }
            }
        }
    }
}
