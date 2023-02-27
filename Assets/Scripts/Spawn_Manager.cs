using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hypercasual_Rukajuu
{
    public class Spawn_Manager : MonoBehaviour
    {
        //i need a reference to the platforms prefab. this will be a list
        // i need the movespeed variables
        
        [SerializeField] private ArrayList[] platforms;
        [SerializeField] private float moveSpeed;

        private void Start()
        {
            
        }
    }
}

