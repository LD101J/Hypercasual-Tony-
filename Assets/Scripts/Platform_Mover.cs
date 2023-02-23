using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hypercasual_Rukajuu
{
    public class Platform_Mover : MonoBehaviour
    {
        #region Psudoecode
        //i need the rigidbody variable to controll the platform movement instead of gameobject
        //in start we need the to get the rigidbody
        //i need variables for the start point and endpoint
        //i also need a movespeed variable
        //on start i need to assign the start location
        //on update i need to figure out how to move the platform left or right
        //i need to figure out how to stop the platform when it gets to a certain position
        //this platform need to move every frame so update
        #endregion
        #region Variables
        //responsible for moving
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private float moveSpeed;
        public bool platformIsMoving;
        //move between these two points
        [SerializeField] Transform leftMostPosition;
        [SerializeField] Transform rightMostPosition;
        public bool boundaryReached;
        //responsible for stopping the platform
        [SerializeField] private bool platformStopped;
        //[SerializeField] private bool isStopped;
        #endregion
        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            
        }
        private void Update()
        {
            MoveGameObject();
           
        }
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.black;
            Gizmos.DrawWireSphere(leftMostPosition.position, .3f);
            Gizmos.DrawWireSphere(rightMostPosition.position, .3f);
        }
        void MoveGameObject()
        {
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            
            platformIsMoving = true;
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag("Drake"))
            {
                platformIsMoving = false;
                moveSpeed = 0f;
                rb.isKinematic = false;
                rb.gravityScale = 1f;
            }
        }
        void StopPlatform()
        {
            platformStopped = true;
            //Vector3.zero;
        }
    }
}
