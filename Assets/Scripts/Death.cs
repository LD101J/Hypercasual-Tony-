using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hypercasual_Rukajuu
{
    public class Death : MonoBehaviour
    {
        [SerializeField] private GameObject player;
        [SerializeField] private Transform respawnPoint;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Drake"))
            {
                player.transform.position = respawnPoint.position;
            }
        }


    }
}

