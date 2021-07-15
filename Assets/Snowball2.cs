using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Snowball2 : MonoBehaviour
{
    Rigidbody2D rb;
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float angles = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angles, Vector3.forward);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
   
        if (collision.gameObject.tag == "enemy1")
        {
            Destroy(gameObject);
        }
    }
}
