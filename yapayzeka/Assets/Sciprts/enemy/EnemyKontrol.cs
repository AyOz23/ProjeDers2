using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyKontrol : MonoBehaviour,IDamageAble
{
    public float hp;
    public float Speed;
    public  string isim;
    

    // Start is called before the first frame update
    public void Start()
    {
        HasarAl(10);

    }

    public virtual void HasarAl(float damage) 
    {
        hp -= damage; 
    }

    public void TakeDamage(float DamageAmount)
    {
        hp -=DamageAmount;
        if(hp <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}

