using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    public float playerSpeed;
    public float jumpSpeed;
    bool ground;
    void Start()
    {
        playerRB = transform.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W) && ground==true )
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x, jumpSpeed);
            ground = false;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            playerRB.velocity = new Vector2(-playerSpeed, playerRB.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            playerRB.velocity = new Vector2(playerSpeed, playerRB.velocity.y);
        }
    }


        
        
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        ground = true;
    }


}
    
