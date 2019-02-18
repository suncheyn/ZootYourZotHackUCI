using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Balloons : MonoBehaviour{

    // Change x to a random value 1 - 4
    void SetTransformX(float n){
        transform.position = new Vector3(n, transform.position.y, transform.position.z);
    }

    void loseGame(){
        // this is where we call the endGame scene ********************
        //SceneManager.LoadScene(loseGame);

    }

    void winGame()
    {
        // this is where we call winGame scene **********
        //SceneManager.LoadScene(winGame);
    }

    // Start is called before the first frame update
    void Start()
    {
        // in start portion set variable random range 1 - 4

    }

    // React to clicked balloon
    void checkClick(){
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // The object identified by hit.transform was clicked
            if (Physics.Raycast(ray, out hit))
            {
                // ANIMATE BALLOON HERE *********************
                Destroy(this.gameObject);

                // Increment count
                ++GameManager.ins.count;
            }
        }
    }

    //// Clicking balloon
    //void OnMouseDown()
    //{
    //    // this object was clicked - do something
    //}


    // Update is called once per frame
    void Update(){

        // Call balloon load to insert balloons
        balloonLoader(GameManager.ins.balloonNum);

        // Check if a balloon got to top of screen
        if (this.transform.position.y > Screen.height){
            Destroy(this.gameObject);
            ++GameManager.ins.lossCount;
        }

        if (this.transform.position.x > Screen.width)
        {
            Destroy(this.gameObject);
            ++GameManager.ins.lossCount;
        }

        // Check if game ended bc max balloons missed
        checkEndGame();

        // Check if balloon was clicked
        checkClick();

        // Based on count, increase min speed by 5 per 5 balloon
        // Run if after half is over
        //if (GameManager.ins.count > 20){
        //    if (GameManager.ins.count % 5 == 0)
        //    {
        //        AnimationSpeed.ins.speed += 3 * Time.deltaTime;
        //       // transform.Translate(0, 0, -3 * Time.deltaTime);
        //    }
        //}

        //// Runs in first half of game
        //else if (GameManager.ins.count % 5 == 0)
        //{
        //    AnimationSpeed.ins.speed += 2;
        //}
    }

    // Check if game is over
    void checkEndGame(){
        // If 37 - 40 balloons have been popped the game is over and has been won
        if (GameManager.ins.count >= 37)
        {
            winGame();
        }

        // If missedBalloons > 5 we end the game
        if (GameManager.ins.lossCount >= 5)
        {
            loseGame();
        }

    }

    // This is where we load balloons at random
    void balloonLoader(int balloonNum)
    {
        switch (balloonNum){
            case 0:
                SetTransformX(-5);
                transform.position += transform.up * Time.deltaTime;
                transform.position += Vector3.right * Time.deltaTime * AnimationSpeed.ins.speed;
                break;
            case 1:
                SetTransformX(6);
                transform.position += transform.up * Time.deltaTime;
                transform.position += Vector3.left * Time.deltaTime * AnimationSpeed.ins.speed;
                break;
            case 2:
                SetTransformX(8);
                transform.position += transform.up * Time.deltaTime;
                transform.position += Vector3.right * Time.deltaTime * AnimationSpeed.ins.speed;
                break;
            case 3:
                SetTransformX(9);
                transform.position += transform.up * Time.deltaTime;
                transform.position += Vector3.right * Time.deltaTime * AnimationSpeed.ins.speed;
                break;

        }

    }
}