using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_Script : MonoBehaviour
{
    protected float moveSpeed = -2f;
    Vector2 position;

    float velocity_x = 0.3f, velocity_y = 0;
    Material mat;


    private void Awake()
    {
        mat = GetComponent<Renderer>().material;
    }
    void Start()
    {
        position = new Vector2(velocity_x, velocity_y);
    }

    void Update()
    {
        mat.mainTextureOffset += position * Time.deltaTime;
    }


}
