using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class snowball : MonoBehaviour
{
    Rigidbody2D rb;
    public int score = 0;
    GameObject Score;
    Score scoreKontrol;

    public TMP_Text scoreText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Score = GameObject.FindGameObjectWithTag("enemy1");
        scoreKontrol = Score.GetComponent<Score>();


      
    }

    // Update is called once per frame
    void Update()
    {
        float angles = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angles, Vector3.forward);
       
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }


    }

}
