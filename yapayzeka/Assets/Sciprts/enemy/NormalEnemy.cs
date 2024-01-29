using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class NormalEnemy : Kontrol
{
    public Player player;
    public NavMeshAgent navMeshAgent;
    public void Awake()
    {
        player = GameObject.FindObjectOfType<Player>();
    }
    public void Start()
    {
        SetAgentSpeed(10);
        deger();
        
    }
    public void Update()
    {
        InvokeRepeating("Hasar", 0f, 1000f);
    }
    public void Hasar()
    {

        float dis = Vector3.Distance(transform.position, player.transform.position);

        if (dis <= 1f)
        {
            player.Healt -= Damage;
            
        }

    }
    public void deger()
    {

        Healt = 100f;
        Speed = 12f;
        Name = "NormalEnemy";
        Damage = 0.01f;
    }
    void SetAgentSpeed(float speed)
    {
        navMeshAgent.speed = speed;
    }
}
