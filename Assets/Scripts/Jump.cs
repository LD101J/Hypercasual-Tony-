using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hypercasual_Rukajuu
{
    public class Jump : MonoBehaviour
    {
        #region Psudoecode
        //when player taps on screen during play
        //check if were grounded
        //if were grounded addforce in the up direction
        //otherwise 0
        #endregion
        #region Variables   
        public bool is_Grounded;
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private float jump_Force = 1f;
        [SerializeField] private Ground_Check ground_Check;
        [SerializeField] private bool can_Jump;
        #endregion
        private void OnEnable()
        {
            ground_Check.OnGround_Check += HandleGroundCheck;
            rb = GetComponent<Rigidbody2D>();
        }


        private void HandleGroundCheck(bool obj)
        {
            is_Grounded = obj;
        }
        private void Update()
        {
            //when mouse button pressed check if player is grounded
            //if so, jump if not, do nothing(don't jump)
            if (Input.GetMouseButtonDown(0) && is_Grounded)
            {
                rb.AddForce(Vector2.up * jump_Force, ForceMode2D.Impulse);
                Debug.Log(jump_Force);
            }

        }
    }
}

