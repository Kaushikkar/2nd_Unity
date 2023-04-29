using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_health : MonoBehaviour
{
    Enemy_detection enemy_Detection;
    float max_health=5.0f;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.GetComponent<Enemy_detection>().health_reduce);
        if(gameObject.GetComponent<Enemy_detection>().health_reduce)
        {
            Debug.Log("Done");
        }
    }
}
