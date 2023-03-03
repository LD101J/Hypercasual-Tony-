using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hypercasual_Rukajuu
{
    public class Platform_Mover : MonoBehaviour
    {
        #region Psudoecode for moving platform
        //i need the rigidbody variable to controll the platform movement instead of gameobject
        //in start we need the to get the rigidbody
        //i need variables for the start point and endpoint
        //i also need a movespeed variable
        //on start i need to assign the start location
        //on update i need to figure out how to move the platform left or right
        //i need to figure out how to stop the platform when it gets to a certain position
        //this platform need to move every frame so update
        #endregion
        #region Psuedocode for moving the platform between two points
        //i need variables for the 2 points the two points. this are both tranforms
        //in update i need to tell the rigidbody to move only upto the opposite boundary
        #endregion
        #region Variables
        //responsible for moving
         private Rigidbody2D rb;
        [SerializeField] protected float moveSpeed;
        //move between these two points
          Transform leftMostPosition;
          Transform rightMostPosition;
        //start couroutine
        [SerializeField] protected float waitTime;
        //[SerializeField] private GameObject platform;
        private float moveSpeedStore;
        //check to see if platform is stacked
        [SerializeField] private bool isStacked;
        
        #endregion
        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();

        }
        private void Update()
        {
            MoveGameObject();
            
        }
        
         protected void MoveGameObject()
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }


        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Drake"))
            {
                //landing drake on the platform
                IsStacked();
            }
           
            if (collision.gameObject.CompareTag("Boundary"))
            {
                BoundaryReached();
            }
        }
        IEnumerator WaitBeforePingPong()
        {
            moveSpeedStore = moveSpeed;
            moveSpeed = 0f;
            yield return new WaitForSeconds(waitTime);
            moveSpeed = -moveSpeedStore;
            
            Debug.Log("Go Back");

        }
        void BoundaryReached()
        {
            StartCoroutine(WaitBeforePingPong());
        }
        public void IsStacked()
        {
            moveSpeed = 0f;
            Debug.Log(moveSpeed);
            rb.isKinematic = false;
            rb.gravityScale = 1f;
            isStacked = true;
        }
    }
}