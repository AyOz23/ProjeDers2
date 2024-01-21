using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NormalEnemy : EnemyKontrol
{
    public NavMeshAgent navMeshAgent;
    public override void HasarAl(float damage)
    {  
        base.HasarAl(damage);
        Speed = 8;
        isim = "NormalZ";
        hp = 150;
        SetAgentSpeed(Speed);

        if (navMeshAgent == null)
        {
            enabled = false;
            return;
        }
    }
    void SetAgentSpeed(float speed)
    {
        navMeshAgent.speed = speed;
    }
}
