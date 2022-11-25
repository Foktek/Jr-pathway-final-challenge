using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedUnit : Unit     //INHERITANCE
{
    
    // Start is called before the first frame update
    void Start()
    {
        timerLimit = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }
}
