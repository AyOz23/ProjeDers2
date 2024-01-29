using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using System.Xml.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class BasicEnemy : Kontrol
{
    public Player player1;
    public NavMeshAgent navMeshAgent;
    public void Awake()
    {
        player1 = GameObject.FindObjectOfType<Player>();
    }
    public void Start()
    {
        SetAgentSpeed(10);
        deger();
        
    }
    public void Update()
    {
        InvokeRepeating("Hasar1", 0f, 1000f);
    }
    public void Hasar1()
    {
        float dis = Vector3.Distance(transform.position, player1.transform.position);

        if (dis <= 2f)
        {
            player1.Healt -= Damage;

        }

    }
    public void deger()
    {
        Healt = 100f;
        Speed = 12f;
        Name = "BasicEnemy";
        Damage = 0.01f;
    }
    void SetAgentSpeed(float speed)
    {
        navMeshAgent.speed = speed;
    }
   
}
    
