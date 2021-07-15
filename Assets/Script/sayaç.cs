using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class sayaç : MonoBehaviour
{
    public TMP_Text sayaçText;
    public GameObject win;
    
    float timeLeft = 60.0f;
    void Update()
    {
        timeLeft -= Time.deltaTime;
        sayaçText.text = "" + Mathf.Round(timeLeft);
        if (sayaçText.text == "0" )
        {
            win.gameObject.SetActive(true);
            timeLeft = 0f;
            
                
        }
    }
    
       
    
}
