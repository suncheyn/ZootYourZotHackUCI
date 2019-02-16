using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    // rigidbody.velocity = transform.forward;
    // Vector2 pos = Vector2.zero;
    // input = "balloon";
    // float speed;
    // float height;
    // public Balloon balloon;
    // // Start is called before the first frame update
    // void Start()
    // {
    //     height = transform.localScale.y;
    //     speed = 5f;
    // }

    // //transform.name = input;
    //// transform.position =  pos;
    //transform.name = input
    //// Update is called once per frame
    //void Update()
    //{
    //    float move = Input.GetAxis(input) * Time.deltaTime;
    //}
    public static int movespeed = 10;
    public Vector3 userDirection = Vector3.up;
    //public static Start()
    //{
    //}
    public void Update()
    {
        transform.position += Vector3.up * Time.deltaTime;

        transform.position += Vector3.right * Time.deltaTime;

        transform.position += Vector3.left * Time.deltaTime;

    }
}
