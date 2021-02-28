using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public List<string> dialogues;
    public List<bool> isPlayer;
    public Text showPlayer;
    public Text showOther;
    public GameObject choice;
    public GameObject file;
    public int current=0;
    // Start is called before the first frame update
    void Start()
    {
        choice = GameManager._instance.choice;
        showPlayer = this.GetComponent<Text>();
        showPlayer.text = dialogues[current];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && current != 4)
        {
            NextLine();
        }

    }

    public void NextLine()
    {
        if (current < dialogues.Count)
        {
            current++;
            Debug.Log(current);
            if (current != 4)
            {
                Debug.Log("e");
                choice.SetActive(false);
                if (current > dialogues.Count - 1)
                {
                    Debug.Log("eee");
                    choice.SetActive(true);
                    this.GetComponentInParent<Image>().enabled = false;
                    this.gameObject.SetActive(false);
                }
                else if (current != 2 && isPlayer[current])
                {
                    showPlayer.text = dialogues[current];
                }
                else if (current != 2 && !isPlayer[current])
                {
                    showOther.text = dialogues[current];
                }
                else if (current == 2)
                    file.SetActive(true);
            }

            else
            {
                Debug.Log("ee");
                choice.SetActive(true);

            }
        }
        
    }

}
