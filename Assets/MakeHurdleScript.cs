using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeHurdleScript : MonoBehaviour
{
    public GameObject hurdle;
    public float timeDf;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeDf)
        {
            GameObject newhurdle =  Instantiate(hurdle);
            newhurdle.transform.position = new Vector3(4,Random.Range(-1.7f,5.7f),0);
            timer = 0.0f;
            Destroy(newhurdle, 10.0f);
        }
    }
}
