using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Trigger : MonoBehaviour
{
    public GameObject Panel;
    //public GameObject Panel1;
    public GameObject Canvas;
    public GameObject Panel2;
    
    
    int count;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        

        Panel.gameObject.SetActive(false);
        //Panel1.gameObject.SetActive(true);
        Canvas.gameObject.SetActive(false);

        Panel2.gameObject.SetActive(true);
        



    }
    //private void OnTriggerExit2D(Collider2D other)
    //{
        
        //Panel.gameObject.SetActive(true);
        //Panel1.gameObject.SetActive(false);
        //Canvas.gameObject.SetActive(false);

        //Panel2.gameObject.SetActive(true);
        


    //}


    // Start is called before the first frame update
    void Start()
    {
        Panel.gameObject.SetActive(true);
        //Panel1.gameObject.SetActive(false);
        Canvas.gameObject.SetActive(true);

        Panel2.gameObject.SetActive(false);
        


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
