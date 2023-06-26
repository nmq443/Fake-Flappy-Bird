using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float Force;
    private Rigidbody2D rb;
    private Animator anim;

    public static int Points = 0;
    public static int HighestPoints = 0;
    public Text ScoreText;
    public Text HighestScoreText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        ScoreText.text = "Your score: " + Points.ToString();
        HighestScoreText.text = "Highest score: " + HighestPoints.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            ClickedOnMouse();   
        } else
        {
            anim.SetBool("isClicked", false);
            anim.SetBool("isHit", false);
        }
    }
    
    void ClickedOnMouse()
    {
        rb.velocity = Vector2.up * Force;
        anim.SetBool("isClicked", true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        anim.SetBool("isHit", true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "PipeScore")
        {
            Points++;
            HighestPoints = Math.Max(HighestPoints, Points);
            ScoreText.text = "Your score: " + Points.ToString();
            HighestScoreText.text = "Highest score: " + HighestPoints.ToString();
        }
    }
}
