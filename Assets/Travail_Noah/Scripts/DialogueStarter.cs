using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueStarter : MonoBehaviour
{

    public List<string> dialogues;
    public List<bool> isPlayer;
    public Text show;
    public Text showOther;
    public int current = 0;
    public GameObject intro;
    public Sprite holo;
    public Image boss;
    public Image character;
    // Start is called before the first frame update
    void Start()
    {
        show = this.GetComponent<Text>();
        showOther.text = dialogues[current];
        boss.sprite = holo;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextLine()
    {
        current++;
        if (current > dialogues.Count - 1)
        {
            intro.SetActive(false);
            boss.gameObject.SetActive(false);
            character.enabled = true;
            GameManager._instance.FirstJudgement();
        }
        else 
        {
            if (isPlayer[current])
            {
            show.text = dialogues[current];
            }
            else
            {
                showOther.text = dialogues[current];
            }
        }
        
            
    }

}
