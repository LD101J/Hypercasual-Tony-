using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Hypercasual_Rukajuu
{
    /// <summary>
    /// this class checks if player is grounded and returns isgrounded
    /// </summary>
    public class Ground_Check : MonoBehaviour
    {
        #region Variables
        public bool isGrounded;
        [SerializeField] private LayerMask grassMask;
        [SerializeField] private Transform ground_Check;
        public event Action<bool> OnGround_Check;
        #endregion
        private void Update()
        {
            #region Checking the collider we collided with
            Collider2D col = Physics2D.OverlapPoint(ground_Check.position, grassMask); //checks if there is a collider it is overlaping
            
            if(col != null)
            {
                OnGround_Check.Invoke(true);
            }
         
            else 
            {
                 
                OnGround_Check.Invoke(false);
            }

            #endregion
        }
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.magenta;
            Gizmos.DrawWireSphere(ground_Check.position, .3f);
        }
    }


}
