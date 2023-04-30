using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_health : MonoBehaviour
{
    Enemy_detection enemy_Detection;
    float max_health=5;
    float current_health;
    bool damage=false;
    bool damage_taken=false;
    void Start()
    {
        current_health=max_health;
    }
    void Update()
    {
        Debug.Log("Current health"+current_health);
        damagetaken(damage);
    }
    void damagetaken(bool damage)
    {
        damage=gameObject.GetComponent<Enemy_detection>().health_reduce;
        if(damage==true && !damage_taken)
        {
            current_health-=1;
            damage_taken=true;
        }
        else if(!damage)
        {
            damage_taken=false;
        }
         if(current_health==0)
        {
            Debug.Log("DEAD");
        }
    }
}
