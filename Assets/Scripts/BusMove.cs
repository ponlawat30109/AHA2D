using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusMove : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bus, bus_pos, player;
    float distance, speed = 0.5f, time_remain = 5f;

    void Update()
    {
        distance = Vector2.Distance(bus.transform.position, bus_pos.transform.position);
        for (int i = 0; i<10; i++)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            if (distance < 0.5f)
            {
                speed = 0;

                if (time_remain <= 0)
                {
                    bus.SetActive(false);
                } 
                if (time_remain <= 1)
                {
                    player.SetActive(true);
                }

                break;
            }
            
        }

        time_remain -= Time.deltaTime;
    }
}
