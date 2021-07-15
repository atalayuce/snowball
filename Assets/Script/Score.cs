using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;
    public Transform bar;
    float x = 0.93f;



     void Start()
    {
 
    }

    public float damage;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="snow")
        {
            score++;
            scoreText.SetText(score.ToString());
        }
    }
}
