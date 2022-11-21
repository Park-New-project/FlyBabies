using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //current
        GetComponent<Text>().text = "Score : "+Score.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
