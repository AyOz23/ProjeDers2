using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageAl : MonoBehaviour
{
    public int maxHealth = 100;

    [SerializeField] protected int currentHealt;
    protected virtual void Start()
    {
        currentHealt = maxHealth;

    }
    // for taking damage 
    public void TakeDamage(int damageAmount)
    {

        currentHealt -= damageAmount;
        if (currentHealt <= 0)
        {
            Die();
        }
    }

    protected void Die()
    {
        Debug.Log("Karakter Öldü");
        Destroy(gameObject);

    }
}
