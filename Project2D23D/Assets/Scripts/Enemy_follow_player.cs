using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Enemy_follow_player : MonoBehaviour
{
    public NavMeshAgent enemies;
    public Transform Player;
    void Update()
    {
        enemies.SetDestination(Player.position);
    }
}
