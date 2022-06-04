
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class Movement : MonoBehaviour
{
  
    public TextMeshProUGUI Score;
    int score = 0;

    public float moveSpeed;


    public KeyCode hiiri;
    public KeyCode space;
    public AudioSource coin‰‰ni;
    private Rigidbody2D theRB;
    bool raja = false;
    bool vasen = false;
    bool oikea = false;
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();

    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        if (collisionInfo.collider.tag == "raja")
        {
            
            raja = true;
        }

       if (collisionInfo.collider.name == "vasenraja")
        {
            
            vasen = true;
        }

        if (collisionInfo.collider.name == "oikearaja")
        {
           
            oikea = true;
        }
    }

    void OnCollisionExit2D(Collision2D collisionInfo)
    {
        
        raja = false;
        vasen = false;
        oikea = false;
    }
    void Update()
    {





        if (Input.GetKey(hiiri) | Input.GetKey(space) && raja == true && oikea == true)
        {

            theRB.velocity = new Vector2(-moveSpeed, theRB.velocity.y);

        }



        else if (Input.GetKey(hiiri) | Input.GetKey(space) && raja == true && vasen == true)
        {

            theRB.velocity = new Vector2(moveSpeed, theRB.velocity.y);

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("coin"))
        {
            coin‰‰ni.Play();
            Debug.Log("1 piste");
            score++;
            Score.text = score.ToString();

        }
    }





}