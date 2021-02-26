using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> canvas;
    private GameObject actualCanvas;
    public static GameManager _instance;
    public bool firsTime=true;
    public bool end = false;
    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NextJudgement()
    {
        if (canvas.Count-1>0 && firsTime)
        {
            int rand = Random.Range(0, canvas.Count - 1);
            canvas[rand].SetActive(true);
            actualCanvas = canvas[rand];
            canvas.RemoveAt(rand);
            firsTime = false;
        }
        else if (canvas.Count-1 > 0 && !firsTime)
        {
            actualCanvas.SetActive(false);
            int rand = Random.Range(0, canvas.Count-1);
            canvas[rand].SetActive(true);
            actualCanvas= canvas[rand];
            canvas.RemoveAt(rand);
            
        }
        else 
        {
            end = true;
            Debug.Log(end);
        }


    }

    
}
