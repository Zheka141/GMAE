using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class art : MonoBehaviour
{
    [Range(1,10)]
    //[HideInInspector]
    public float speed = 5;
    [Space(30)]
    [Header("ћассив хранит в себе информацию обо всех \n"+"диалогах, которые есть на уровне")]
    [Space(30)]
    [SerializeField]
    private float jumpForse = 5;
    Rigidbody2D rb;


    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0 , 0) * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.05)
            rb.AddForce(new Vector2(0, jumpForse), ForceMode2D.Impulse);


        
    }
}
