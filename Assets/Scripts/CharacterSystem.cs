using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AHA
{
    public class CharacterSystem : MonoBehaviour
    {
        public float jump, liveLeft;
        public Text liveText;

        public bool ground;
        public LayerMask groundcheck;

        private Rigidbody2D myrigid2D;
        private Collider2D mycol2D;

        void Start()
        {
            myrigid2D = GetComponent<Rigidbody2D>();
            mycol2D = GetComponent<Collider2D>();
        }


        void Update()
        {
            ground = Physics2D.IsTouchingLayers(mycol2D, groundcheck);
            if (ground)
            {
                if (Input.GetKey(KeyCode.Space))
                {
                    myrigid2D.velocity = new Vector2(myrigid2D.velocity.x, jump);
                }
            }

            LiveCheck();
        }
        void LiveCheck()
        {
            liveText.text = "Live: " + liveLeft;
            if (liveLeft < 1)
            {
                SceneManager.LoadScene("GameOverScene");
            }
        }

        public void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag == "Object")
            {
                liveLeft -= 1;
            }
            if (other.gameObject.tag == "Object2")
            {
                liveLeft -= 2;
            }
        }
        public float ReturnLive()
        {
            return liveLeft;
        }
    }
}