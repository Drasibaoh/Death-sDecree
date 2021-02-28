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
    public Image boss;
    public Sprite holo;
    public Image us;
    public Sprite playerS;
    void Update()
    {

    }
    void Start()
    {
        boss.gameObject.SetActive(true);
        boss.sprite = holo;
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
                SceneManager.LoadScene(2);
            }
            else
            {
                if (transition == current)
                {
                    boss.enabled = false;
                    Debug.Log("e");
                    fade.FadeToLevel();
                    us.sprite = playerS;
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
