using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static int score = 0;

    public GameObject[] jellyPieces;

    public GameObject winText;

    public GameObject replayButton;

    public int winNumber = 2;

    // Start is called before the first frame update
    void Start()
    {
        jellyPieces = GameObject.FindGameObjectsWithTag("JellyPieces");
    }

    // Update is called once per frame
    void Update()
    {
        AddScore();

    }

    public void AddScore()
    {
        
        if (score >= winNumber)
        {
            Win();
            Debug.Log("Score: ")
        }
    }

    public void Win()
    {
        winText.SetActive(true);
        replayButton.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene("GameScene");
    }
}
