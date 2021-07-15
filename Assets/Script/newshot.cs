using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newshot : MonoBehaviour
{
    public GameObject snowball;
    public float hiz;
    public Transform shotpoint;

    public GameObject point;
    GameObject[] points;
    public int numberpoint;
    public float spacebetweenpoint;
    Vector2 direction;
    float time = 0;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector2 snowposition = transform.position;
        Vector2 Mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = Mouseposition-snowposition;
        transform.right = direction;

        time += Time.deltaTime;
       

        shoot();
    }
    void shoot()
    {
        if (Input.GetMouseButtonDown(0) && time >=1.5)
        {

            GameObject newsnow = Instantiate(snowball, shotpoint.position, shotpoint.rotation);
            newsnow.GetComponent<Rigidbody2D>().velocity = transform.right * hiz;
            time = 0;
        }
        
      

    }
    
}
