using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    protected Rigidbody unitRb;
    public float jumpForce;
    public float timer = 0.0f;
    public int timerLimit { get; set; } //ENCAPSULATION
    private void Awake()
    {
        unitRb = GetComponent<Rigidbody>();
    }
    public virtual void Jump()  //ABSTRACTION
    {
        timer += Time.deltaTime;
        if (timer > timerLimit)
        {
            unitRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            timer = 0.0f;
        }
    }

}
