using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damegeable : MonoBehaviour
{
    public int maxHealth = 100;
    
   [SerializeField] protected int currentHealt;
    protected virtual void Start()
    {
        currentHealt = maxHealth;
    }
    // for taking damage 
    public virtual void TakeDamage(int damageAmount)
    {
        
        currentHealt -= damageAmount;
        if(currentHealt <= 0)
        {
            Die();
        }
    }
    
    protected void Die()
    {
        Debug.Log("Karakter Öldü");
        // future there will be animation
   
    }
   

}
