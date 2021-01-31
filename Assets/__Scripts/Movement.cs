using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    //Variables
    private int score;
    private Boolean isPaused;
    public Text scoreText;
    public Text completeText;
    private Rigidbody rb;
    
    //Setting the ball speed multiplier
    float ballspeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        //Score gets set to 0 first.
        score = 0;
        scoreText.text = "Score: " + score.ToString();
        //boolean isPaused is updated to false and only enabled once the correct points are collected.
        isPaused = false;
        //Rigidbody of the object is aquired with GetComponent
        rb = GetComponent<Rigidbody>();
        

    }

    

    // Update is called once per frame. Using FixedUpdate to run physics code.
    void FixedUpdate()
    {
        //Only allow player movement if the game isn't paused
        if (isPaused != true)
        {
            //Use two floats and the .GetAxis command
            float xSpeed = Input.GetAxis("Horizontal");
            float ySpeed = Input.GetAxis("Vertical");

            //Add force onto the objects rigidbody only on the x and z axis to not move up and down, also multiply vector by ball speed.
            rb.AddForce(new Vector3(xSpeed, 0, ySpeed) * ballspeed);
        }

        //Score code check to end game once reached 28 max points
        if (score >= 28)
        {
            //Activate game complete text
            completeText.gameObject.SetActive(true);
            //sets isPaused to true disabling player movement
            isPaused = true;
            //invokes the endGame script after 2 seconds meeting requirements outlined.
            Invoke("EndGame", 2f);

        }
    }

 
    //Item pickup code
    void OnTriggerEnter(Collider test)
    {
        //Uses collision with specific trigger marked on each of the prefabs to identify.
        if(test.gameObject.CompareTag("three"))
        {
            //Deactivates the object, increases the score to the appropriate ammount, call method UpdateScore() which just updates the gametext.
            test.gameObject.SetActive(false);
            score += 3;
            UpdateScore();
        }
        else if(test.gameObject.CompareTag("two"))
        {
            //Deactivates the object, increases the score to the appropriate ammount, call method UpdateScore() which just updates the gametext.
            test.gameObject.SetActive(false);
            score += 2;
            UpdateScore();
        }
        else if (test.gameObject.CompareTag("one"))
        {
            //Deactivates the object, increases the score to the appropriate ammount, call method UpdateScore() which just updates the gametext.
            test.gameObject.SetActive(false);
            score += 1;
            UpdateScore();

        }
       

        
    }

    //Updates ingame UI text with new score.
    void UpdateScore()
    {
        scoreText.text = "Score: " + score.ToString();

    }

    //Endgame method that restarts the scene.
    private void EndGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}
