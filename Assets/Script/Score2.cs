using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score2 : MonoBehaviour
{
    public TMP_Text scoreText;
    int score;
    public Transform bar;
    float x = 0.93f;

    public float damage;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "snow2")
        {
            score++;
            scoreText.SetText(score.ToString());
       

        }
    }
}
