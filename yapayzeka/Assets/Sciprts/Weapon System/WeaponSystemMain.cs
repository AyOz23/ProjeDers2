using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class WeaponSystemMain : MonoBehaviour
{
    [SerializeField] protected virtual int ammoCapacity
    {
        get; set; 
    }
    
    protected virtual float firingrate
    {
        get; set;
    }
    protected virtual float nextTimeFire
    {
        get; set;
    }
   
    [SerializeField] protected GameObject bulletPrefab;
    [SerializeField] protected Transform firePoint;
    [SerializeField] protected virtual float weaponDamage { get; set; } 
    [SerializeField] protected int currentAmmo;
    [SerializeField] protected virtual float bulletSpeed { get; set; }
    protected virtual void Start()
    {
        ammoCapacity=currentAmmo;
    }
    protected virtual void Update()
    {
        FireRateF(firingrate);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shot();

       
        }
    }
   protected virtual void Shot()
    {     
        // buraya bool ile fire rate gelicek
        if (ammoCapacity > 0 && currentAmmo > 0)
        {           
                // Ammo Not Moving probly;
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            currentAmmo--;
            
          
        }  
    }
    protected virtual void FireRateF(float firingratee)
    {
        nextTimeFire = Time.time + 1f / firingratee;
    }
    //protected void AreaOfEffect(float effectAreaDistance, LayerMask effectedArea)
    //{
    //    RaycastHit[] shootedObject = Physics.SphereCastAll(transform.position,effectAreaDistance,transform.forward, effectAreaDistance,effectedArea);
    //    foreach(RaycastHit raycastHit in shootedObject)
    //    {
    //        Debug.Log("Vurduðun Nesne"+ raycastHit.collider.gameObject.name);
    //    }
    //}
    //protected void ChangeAmmo(int ammoCapacityy)
    //{
    //    currentAmmo = ammoCapacityy;
    //    // maybe later we can add animation tooo
    //}
}
