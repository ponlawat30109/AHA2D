using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AHA
{
    public class MoveLeftCycle : MonoBehaviour
    {
        //[SerializeField]
        protected float moveSpeed;
        //[SerializeField]
        protected float leftWayPointX = -12f, rightWayPointX = 12f;

        void Start()
        {
            Init();
        }
        void Update()
        {
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime,transform.position.y);

            if (transform.position.x < leftWayPointX)
            {
                transform.position = new Vector2(rightWayPointX, transform.position.y);
            }
        }

        protected virtual void Init()
        {
            moveSpeed = -5f;
        }
    }
}