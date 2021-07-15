using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zemin : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb;
    public GameObject zemin1;
    public AudioSource kar;

    void Start()
    {
        kar = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter2D(Collision2D zemin1)
    {

        if (zemin1.gameObject.tag == "zemin")
        {
            kar.Play();
            Destroy(rb.gameObject);
        }
    }
}
