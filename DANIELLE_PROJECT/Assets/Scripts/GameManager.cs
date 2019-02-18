using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private float timerMax = 0;
    private float timer = 0;

    private bool Waited(float seconds)
    {
        timerMax = seconds;

        timer += Time.deltaTime;

        if (timer >= timerMax)
        {
            return true; //max reached - waited x - seconds
        }

        return false;
    }

    public static GameManager ins;

    // Game vars
    public Balloons[] balloons;
    public int count = 0;

    public int lossCount = 0;

    public int balloonNum;

    // Height and width of the screen
    public Vector3 stageDimensions; 

    //******* set sc
    // CONSOLE LOG THE TIME HERE ****************

    //Debug.Log("hi");

    private void Awake(){
        ins = this;
    }

    // Start is called before the first frame update
    void Start(){


        stageDimensions = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        //while (count < 40)
        //{
        //    balloonNum = (Random.Range(0, 4));
        //    Balloons ballon = Instantiate(balloons[balloonNum], new Vector3(Random.Range(-5, 5), 0), Quaternion.identity);
        //    ballon.transform.parent = gameObject.transform.parent;
        //    while (!Waited(20000)){
        //    }
        //    count++;
        //}
    }

    // in start portion set variable random range 1 - 4
    //var in top of game manager- minimum speed, make balloons ref minimum speed set use random.range(x, y)
    // to stop lagging gameObject.destroy()
   // make function startGame
   // keep game variables in here
   // loop with x seconds inst balloon, set random x value 
}
