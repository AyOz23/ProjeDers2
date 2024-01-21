using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : Damegeable
{
    public int criticalDamage = 2;
    public int damageamount = 10;
    
    private void OnCollisionEnter(Collision collision)
    {
        
        Debug.Log("collision içine girdi");
        // its search inside for Damageable class if there is its go to Take Damage;
        Damegeable damageable = collision.gameObject.GetComponent<Damegeable>();
        WeaponSystemMain weaponsysMain = collision.gameObject.GetComponentInParent<WeaponSystemMain>();
        if (damageable != null)
        {
            //            (damageAmount * weapondamagePub) if its works  
            TakeDamage(damageamount);
        }
    }
    private void OnTriggerEnter(Collider col)
    {
        Debug.Log("trigger içine girdi");
        // its search inside for Damageable class if there is its go to Take Damage;
        Damegeable damageable = col.gameObject.GetComponent<Damegeable>();
        WeaponSystemMain weaponsysMain = col.gameObject.GetComponentInParent<WeaponSystemMain>();
        if (damageable != null)
        {
            //            (damageAmount * weapondamagePub) if its works  
            TakeDamage(damageamount);
        }
    }
}

