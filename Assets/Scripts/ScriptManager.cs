using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptManager : MonoBehaviour
{

   public void ScriptController()
    {
        GameObject.Find("GameManager").GetComponent<GameManager>().enabled = false;
        GameObject.Find("GameManager").GetComponent<GameManager>().enabled = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
