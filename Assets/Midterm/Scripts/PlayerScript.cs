using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    //These are the player's Variables, the raw info that defines them
    
    //The Rigidbody2D is a component that gives the player physics, and is what we use to move
    public Rigidbody2D RB;

    //TextMeshPro is a component that draws text on the screen.
    //We use this one to show our score.
    public TextMeshPro ScoreText;
    public TextMeshPro HPText;
    public TextMeshPro ADText;
    //This will control how fast the player moves
    public float Speed = 5;
    
    //This is how many points we currently have
    public int Score = 0;
    public int player_currentHealth = 3;
    public int Damage = 1;
    public int getDamage()
    {
        return Damage;
    }

    //Start automatically gets triggered once when the objects turns on/the game starts
    void Start()
    {
        //During setup we call UpdateScore to make sure our score text looks correct
        UpdateScore();
        UpdateHP();
        UpdateAD();
    }

    //Update is a lot like Start, but it automatically gets triggered once per frame
    //Most of an object's code will be called from Update--it controls things that happen in real time
    void Update()
    {
        //The code below controls the character's movement
        //First we make a variable that we'll use to record how we want to move
        Vector2 vel = new Vector2(0,0);

        //Then we use if statement to figure out what that variable should look like
        
        //If I hold the right arrow key, the player should move right. . .

        if (Input.GetKey(KeyCode.RightArrow)) { 
            vel.x = Speed;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vel.x = -Speed;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            vel.y = Speed;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            vel.y = -Speed;
        }

        if (transform.position.x < -8.65f)
        {
            transform.position = new Vector2(-8.65f, transform.position.y);
        }
        if (transform.position.x > 8.65f)
        {
            transform.position = new Vector2(8.65f, transform.position.y);
        }
        if (transform.position.y < -4.65f)
        {
            transform.position = new Vector2(transform.position.x, -4.7f);
        }
        if (transform.position.y > 4.65f)
        {
            transform.position = new Vector2(transform.position.x, 4.7f);
        }
        //Finally, I take that variable and I feed it to the component in charge of movement
        RB.linearVelocity = vel;
        
    }
    

    //This gets called whenever you bump into another object, like a wall or coin.
    private void OnCollisionEnter2D(Collision2D other)
    {
        //This checks to see if the thing you bumped into had the Hazard tag
        //If it does...
        if (other.gameObject.CompareTag("Enemy"))
        {
            player_currentHealth -= 1;
            UpdateHP();
            if (player_currentHealth < 1)
            {
                Die();
            }

        }
        
        //This checks to see if the thing you bumped into has the CoinScript script on it
        CoinScript coin = other.gameObject.GetComponent<CoinScript>();
        //If it does, run the code block belows
        if (coin != null)
        {
            //Tell the coin that you bumped into them so they can self destruct or whatever
            coin.GetBumped();
            Score += 1;
            UpdateScore();
        }

        HealthCoin coin_addHealth = other.gameObject.GetComponent<HealthCoin>();
        if(coin_addHealth != null)
        {
            //Tell the coin that you bumped into them so they can self destruct or whatever
            coin_addHealth.GetBumped();
            player_currentHealth += 1;
            UpdateHP();
        }
        PlayerDamageCoin coin_addAD = other.gameObject.GetComponent<PlayerDamageCoin>();
        if(coin_addAD != null)
        {
            coin_addAD.GetBumped();
            Damage += 1;
            UpdateAD();
        }
    }

    //This function updates the game's score text to show how many points you have
    //Even if your 'score' variable goes up, if you don't update the text the player doesn't know
    public void UpdateScore()
    {
        ScoreText.text = "Score: " + Score;
    }
    public void UpdateHP()
    {
        HPText.text = "HP: " + player_currentHealth;
    }
    public void UpdateAD()
    {
        ADText.text = "AD: " + Damage;
    }

    //If this function is called, the player character dies. The player character is destroyed.
    public void Die()
    {
        Destroy(gameObject);
    }
}