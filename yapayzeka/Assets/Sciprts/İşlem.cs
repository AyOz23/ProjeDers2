using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İşlem : MonoBehaviour, IDamageAble
{
    public BasicEnemy basicanamy;
    public Pistols wpsys;
    private void Awake()
    {
        basicanamy=GameObject.FindObjectOfType<BasicEnemy>();
        wpsys=GameObject.FindObjectOfType<Pistols>();
    }
    public void Update()
    {
        
        
    }
    public void TakeDamage(float DamageAmount)
    {
        basicanamy.Healt -= DamageAmount;
    }
    public void OnCollisionEnter(Collision collision)
    {
        TakeDamage(wpsys.weaponDamgePublic);
    }
}
