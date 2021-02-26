using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonChoices : MonoBehaviour
{

    public Texture Happy;
    public Texture Sad;
    public Texture Waiting;

    RawImage m_RawImage;

    void Start()
    {
        m_RawImage = GetComponent<RawImage>();
        m_RawImage.texture = Waiting;
    }

    public void HeavenChoice()
    {
        m_RawImage.texture = Happy;
    }

    public void HellChoice()
    {
        m_RawImage.texture = Sad;
    }
}
