using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JellyBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Destroy(this.gameObject);
        TMP_Text Score = GameObject.Find("Score").GetComponent<TMP_Text>();
        GameManager.score += 1;
        Score.text = "Score: "+GameManager.score;
        Debug.Log(GameManager.score);
    }
}
