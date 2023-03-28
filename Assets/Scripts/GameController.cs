using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameController : MonoBehaviour
{

    //public static Rigidbody2D rigidBody;
    //public static bool levelStart;

    //private static float rigidbodyGravityScale;

    //public static void GameStart(BirdController birdController)
    //{
    //    rigidBody = birdController.gameObject.GetComponent<Rigidbody2D>();
    //    rigidbodyGravityScale = rigidBody.gravityScale;// luu lai gia tri nhap 
    //    if (rigidBody != null)
    //    {
    //        Debug.Log("da tim thay thay rigidbody");
    //    }
    //    else
    //    {
    //        Debug.Log("khong tim thay rigidbody");
    //    }
    //    levelStart = false;

    //    rigidBody.gravityScale = 0;
    //    birdController.score = 0;
    //    birdController.message.GetComponent<SpriteRenderer>().enabled = true;

    //}

    public static void GameOver()
    {
        Debug.Log("GameOver");
        ReloadScene();
    }

    private static void ReloadScene()
    {
        AudioController.instance.PlayThisSounds("die");
        SceneManager.LoadScene("SampleScene");
    }
}
