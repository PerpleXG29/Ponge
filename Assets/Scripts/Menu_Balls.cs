using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Balls : MonoBehaviour
{
    public Rigidbody2D _rigidbody;
    public float speed = 300.0f;
   

    public void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        if (_rigidbody.velocity.magnitude == 0)
        {
            //Debug.Log("Ball is stopped");
            StartPush();
            Time.timeScale = 1f;

        }
        
    }

   
    public void StartPush()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);


        Vector2 direction = new Vector2(x, y);
        //Debug.Log("Start Speed : " + direction * this.speed);
        _rigidbody.AddForce(direction * this.speed);
    }

   



}
