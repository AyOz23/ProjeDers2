using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NormalEnemy : Kontrol
{
    public Player player;
    public NavMeshAgent navMeshAgent;
    public void Start()
    {
        SetAgentSpeed(10);
        deger();
    }
    public override void Hasar()
    {
        base.Hasar();

        float dis = Vector3.Distance(transform.position, player.transform.position);

        if (dis <= 2f)
        {
            player.Healt -= Damage;
        }

    }
    public override void deger()
    {
        base.deger();
        Healt = 100f;
        Speed = 12f;
        Name = "NormalEnemy";
        Damage = 4f;
    }
    void SetAgentSpeed(float speed)
    {
        navMeshAgent.speed = speed;
    }
}
