using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public List<GameObject> canvas;
    public GameObject actualCanvas;
    public static GameManager _instance;
    public bool firsTime=true;
    public bool end = false;
    public GameObject choice;
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
     //   actualCanvas = canvas[0];
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NextJudgementHeaven()
    {
        Debug.Log("Heaven");
        choice.SetActive(false);
        if (canvas.Count-1>0 && firsTime)
        {
          //  canvas.RemoveAt(0);
          //  actualCanvas.SetActive(false);
            int rand = Random.Range(0, canvas.Count - 1);
            Debug.Log(rand);
            canvas[rand].SetActive(true);
            actualCanvas = canvas[rand];
            canvas.RemoveAt(rand);
            firsTime = false;
        }
        else if (canvas.Count-1 > 0 && !firsTime)
        {
            actualCanvas.SetActive(false);
            int rand = Random.Range(0, canvas.Count-1);
            Debug.Log(rand);
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
    public void NextJudgementHell()
    {
        Debug.Log("Hell");
        choice.SetActive(false);
        if (canvas.Count - 1 > 0 && firsTime)
        {
            //actualCanvas.SetActive(false);
            int rand = Random.Range(0, canvas.Count - 1);
            Debug.Log(rand);
            canvas[rand].SetActive(true);
            actualCanvas = canvas[rand];
            canvas.RemoveAt(rand);
            firsTime = false;
        }
        else if (canvas.Count - 1 > 0 && !firsTime)
        {
            actualCanvas.SetActive(false);
            int rand = Random.Range(0, canvas.Count - 1);
            Debug.Log(rand);
            canvas[rand].SetActive(true);
            actualCanvas = canvas[rand];
            canvas.RemoveAt(rand);

        }
        else
        {
            end = true;
            Debug.Log(end);
        }


    }

    public void FirstJudgement()
    {
        if (canvas.Count - 1 > 0 && firsTime)
        {
            int rand = Random.Range(0, canvas.Count - 1);
            Debug.Log(rand);
            canvas[rand].SetActive(true);
            actualCanvas = canvas[rand];
            canvas.RemoveAt(rand);
            firsTime = false;
        }
    }
    
}
