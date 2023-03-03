using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hypercasual_Rukajuu
{
    public class BG_Scrolling : MonoBehaviour
    {
        private BoxCollider2D boxCollider;
        private Rigidbody2D rb;
        private float height;
        [SerializeField] private float bgSpeed;
        private void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            boxCollider = GetComponent<BoxCollider2D>();

            height = boxCollider.size.y;
            rb.velocity = new Vector2(bgSpeed, 0);
        }
        private void Update()
        {
            if(transform.position.y <-height)
            {
                RepositionBG();
            }
            void RepositionBG()
            {
                Vector2 vector = new Vector2(height * 2f, 0);
                transform.position = (Vector2)transform.position + vector;
            }
        }
    }
}

