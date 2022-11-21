using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BabyJumpScript : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce = 3.5f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // jump
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
            GetComponent<AudioSource>().Play();
        }
    }
    // game over
    private void OnCollisionEnter2D(Collision2D other) {
        if(Score.score > Score.bestScore){
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
