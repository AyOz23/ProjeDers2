using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.AI;

public class BasicEnemy :  EnemyKontrol 
{
    public NavMeshAgent navMeshAgent;
    float kritik = 0.3f;
    public override void HasarAl(float damage)
    {
        Speed =50;
        base.HasarAl(damage*kritik);
        isim = "BasicZ";
        hp = 80;
        SetAgentSpeed(Speed);
    }
    void SetAgentSpeed(float speed)
    {
        navMeshAgent.speed = speed;
    }
}
