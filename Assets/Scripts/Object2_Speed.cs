using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object2_Speed : AHA.MoveLeftCycle
{
    //[SerializeField] float moveSpeed;
    protected override void Init()
    {
        moveSpeed = -6.2f;
        leftWayPointX = Random.Range(-12f, -30f);
        rightWayPointX = Random.Range(12f, 30f);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Object")
        {
            leftWayPointX = Random.Range(-12f, -30f);
            rightWayPointX = Random.Range(12f, 30f);
        }
    }
}
