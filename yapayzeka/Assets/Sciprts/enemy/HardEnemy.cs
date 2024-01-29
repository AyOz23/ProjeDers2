using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.Experimental.GraphView.GraphView;

public class HardEnemy : Kontrol
{
    public Player player2;
    public NavMeshAgent navMeshAgent;
    public void Awake()
    {
        player2 = GameObject.FindObjectOfType<Player>();
    }
    public void Start()
    {
        SetAgentSpeed(10);
        deger();
        
    }
    public void Update()
    {
        InvokeRepeating("Hasar2", 0f, 1000f);
    }
    public void Hasar2()
    {

        float dis = Vector3.Distance(transform.position, player2.transform.position);

        if (dis <= 1f)
        {
            player2.Healt -= Damage;
    
        }

    }
    public void deger()
    {
        Healt = 100f;
        Speed = 100f;
        Name = "HardEnemy";
        Damage = 0.01f;
    }
    void SetAgentSpeed(float speed)
    {
        navMeshAgent.speed = speed;
    }

}
