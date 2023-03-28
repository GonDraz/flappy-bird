using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{

    private Rigidbody2D rigidBody;
    private bool levelStart;
    private float rigidbodyGravityScale;
    private int score;

    public GameObject gameController;
    public GameObject message;
    public TextMeshProUGUI scoreText;
    public float jumpBoot;


    private void Awake()
    {
        rigidBody = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbodyGravityScale = rigidBody.gravityScale;// luu lai gia tri nhap 
        if (rigidBody != null)
        {
            Debug.Log("da tim thay thay rigidbody");
        }
        else
        {
            Debug.Log("khong tim thay rigidbody");
        }
        levelStart = false;

        rigidBody.gravityScale = 0;
        score = 0;
        message.GetComponent<SpriteRenderer>().enabled = true;

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetButtonDown("Fire1"))
        {
            //Debug.Log("Space");
            if (levelStart == false)
            {
                levelStart = true;
                rigidBody.gravityScale = rigidbodyGravityScale;
                gameController.GetComponent<PipeGenerator>().enableGeneratorPipe = true;
                message.GetComponent<SpriteRenderer>().enabled = false;
            }
            BirdMoveUp();
        }
    }


    private void BirdMoveUp()
    {
        AudioController.instance.PlayThisSounds("wing");
        rigidBody.velocity = Vector2.up * jumpBoot;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        AudioController.instance.PlayThisSounds("hit");
        GameController.GameOver();
        score = 0;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        AudioController.instance.PlayThisSounds("point");
        score += 1;
        Debug.Log("score: " + score);
        scoreText.text = score.ToString();
    }

}
