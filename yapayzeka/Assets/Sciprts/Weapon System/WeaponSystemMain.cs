using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;
using Input = UnityEngine.Input;

public class WeaponSystemMain : MonoBehaviour
{
    
    
    [Header("Silah Alakalý")]
    [SerializeField] protected GameObject bulletPrefab;
    [SerializeField] protected Transform firePoint;
    [SerializeField] protected virtual float weaponDamage 
    { get; set; } 
    [SerializeField] protected int currentAmmo;
    [SerializeField] protected virtual float bulletSpeed
    { get; set; }
    [SerializeField] protected virtual int ammoCapacity
    {
        get; set;
    }
    [SerializeField] protected virtual int magCapacity
    {
        get;
        set;
    }
    [SerializeField] protected virtual float firingrate
    {
        get; set;
    }
    [SerializeField] protected virtual float nextTimeFire
    {
        get; set;
    }

    [Header("Slider Ýçin Gerekli")]
    [SerializeField] protected Slider slider;
    [SerializeField] protected Image FillArea;
    [SerializeField] protected virtual void Start()
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
    protected void SliderAmmoController()
    {
      
        slider.maxValue = ammoCapacity;
        slider.minValue = 0;
        slider.value = currentAmmo;
        Color lerpedColor = Color.Lerp(Color.red,Color.green,slider.value);
        FillArea.color=lerpedColor;
        

       
    }
    protected virtual int Reload()
    {
        if(Input.GetKeyDown(KeyCode.R) && magCapacity<0)
        {
            return currentAmmo=ammoCapacity;
            magCapacity--;
        }
        
        return currentAmmo;
    }
    
    #region AreOfEffect for shotgun thing
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
    #endregion
}
