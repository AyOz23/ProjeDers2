using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.AI;

public class BasicEnemy :  EnemyKontrol 
{
    public NavMeshAgent navMeshAgent;
    float kritik = 0.3f;
   
    void SetAgentSpeed(float speed)
    {
        navMeshAgent.speed = speed;
    }
}
