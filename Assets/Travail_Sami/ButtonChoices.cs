using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChoices : MonoBehaviour
{
    public Sprite Normal; 
    public Sprite Happy; 
    public Sprite Sad;

    public Image m_Image;

    void Start()
    {
        m_Image.sprite = Normal;
    }

    public void HeavenChoice()
    {
        m_Image.sprite = Happy;
    }

    public void HellChoice()
    {
        m_Image.sprite = Sad;
    }
}
