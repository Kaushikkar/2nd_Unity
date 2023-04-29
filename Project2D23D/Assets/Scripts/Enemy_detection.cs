using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_detection : MonoBehaviour
{
    public bool health_reduce=false;
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag=="Enemy")
            health_reduce=true;
        else
            health_reduce=false;
        Debug.Log(health_reduce);
    }
}
