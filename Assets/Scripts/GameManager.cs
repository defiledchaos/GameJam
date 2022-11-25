using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    private int score = 0;

    public GameObject[] jellyPieces;

    public GameObject winText;

    public GameObject replayButton;

    // Start is called before the first frame update
    void Start()
    {
        jellyPieces = GameObject.FindGameObjectsWithTag("JellyPieces");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddScore()
    {
        score++;
        if (score >= jellyPieces.Length)
        {
            Win();
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
