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
    public GameObject file;
    public int current=0;
    // Start is called before the first frame update
    void Start()
    {
        showPlayer = this.GetComponent<Text>();
        showPlayer.text = dialogues[current];
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

            this.GetComponentInParent<Image>().enabled = false;
            this.gameObject.SetActive(false);
        }
        else if (current != 2 && isPlayer[current])
        {
            file.SetActive(false);
            showPlayer.text = dialogues[current];
        }
        else if (current != 2 && !isPlayer[current])
        {
            file.SetActive(false);
            showOther.text = dialogues[current];
        }
        else
            file.SetActive(true);
    }

}
