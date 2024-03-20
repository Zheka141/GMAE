using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOTart : MonoBehaviour
{
    public float Speed;
    public float OurTime;
    public AnimationCurve AnimCurve;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Speed = AnimCurve.Evaluate(OurTime);
        Vector2 move = new Vector2(Speed, 0);
        transform.Translate(move * Time.deltaTime);
        OurTime += Time.deltaTime;
        if (OurTime > 2)
        {
            OurTime = 0;

        }
    }
}
