using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NormalEnemy : EnemyKontrol
{
    public NavMeshAgent navMeshAgent;
   
    void SetAgentSpeed(float speed)
    {
        navMeshAgent.speed = speed;
    }
}
