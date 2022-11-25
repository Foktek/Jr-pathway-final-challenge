using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenUnit : Unit
{
    // Start is called before the first frame update
    void Start()
    {
        timerLimit = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();    
    }

    public override void Jump() //POLYMORPHISM
    {
        timer += Time.deltaTime;
        if (timer > timerLimit)
        {
            unitRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            unitRb.transform.Rotate(Vector3.back);
            timer = 0.0f;
        }
        
    }
}
