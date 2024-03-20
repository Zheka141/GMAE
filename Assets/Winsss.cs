using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winsss : MonoBehaviour
{
    public GameObject Win;


    //int count;

    private void OnTriggerEnter2D(Collider2D other)
    {


        Win.gameObject.SetActive(true);



    }
    private void OnTriggerExit2D(Collider2D other)
    {


        Win.gameObject.SetActive(false);

    }


    // Start is called before the first frame update
    void Start()
    {
        Win.gameObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

    }


}