using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeed : MonoBehaviour
{

    public static AnimationSpeed  ins;

    // Use this for initialization
    void Start()
    {

    }

    private void Awake()
    {
        ins = this;
    }


    public float speed = 1f;
    //void Update()
    //{
        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    Vector3 position = this.transform.position;
        //    position.x--;
        //    this.transform.position = position * speed;
        //}
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    Vector3 position = this.transform.position;
        //    position.x++;
        //    this.transform.position = position * speed;
        //}
    //}

}
