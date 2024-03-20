using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Losesss : MonoBehaviour
{
    public GameObject Lose;
    

    //int count;

    private void OnTriggerEnter2D(Collider2D other)
    {


        Lose.gameObject.SetActive(true);



    }
    private void OnTriggerExit2D(Collider2D other)
    {


        Lose.gameObject.SetActive(false);

    }


    // Start is called before the first frame update
    void Start()
    {
        Lose.gameObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {

    }


}