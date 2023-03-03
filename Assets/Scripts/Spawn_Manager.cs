using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hypercasual_Rukajuu
{
    public class Spawn_Manager : Platform_Mover
    {
        #region Psudeucode
        //i need a reference to the platforms prefab. this will be a list
        //i need a new position variable
        //atstart call the first platform
        //at update spawn another platform in a new pos
        #endregion
        private Platform_Mover isStacked;
        //types of platforms
        [SerializeField] private Transform[] spawnLocations;
        [SerializeField] private GameObject platform1;
        [SerializeField] private GameObject[] platforms;

        private void Start()
        {
            Instantiate(platform1);
        }
    }
}
        