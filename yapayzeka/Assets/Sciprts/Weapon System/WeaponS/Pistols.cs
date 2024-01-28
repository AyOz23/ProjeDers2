using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

public class Pistols : WeaponSystemMain
{
    // ammo 14 
    private int ammoCapacityGet;
    private int weaponDamageGet;
    [SerializeField] private bool BoostThirtShoot = false;
    protected override int ammoCapacity
    {
        get => base.ammoCapacity;
        set => base.ammoCapacity = 14;
    }
    // damage 10 for now later we can do 30 etc.
    protected override float weaponDamage
    {
        get => base.weaponDamage;
        set => base.weaponDamage = 10;
    }
    // fire rate 1 
    protected override float firingrate
    {
        get => base.firingrate;
        set => base.firingrate = 1;
    }
    // bullet speed on pistol ???????
    protected override float bulletSpeed
    {
        get => base.bulletSpeed;
        set => base.bulletSpeed = value;
    }
    
    protected override int magCapacity
    { get => base.magCapacity; 
      set => base.magCapacity = 3; }

    protected override void Shot()
    {
        if (ammoCapacity > 0 && currentAmmo > 0)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            currentAmmo--;
        }
    }
    protected void BoostedThirtShoot()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (BoostThirtShoot == true)
            {
                BoostThirtShoot = false;
            }
            else
            {
                BoostThirtShoot = true;
            }
        }
    }
    protected override void Update()
    {
        base.Update();
        Reload();
        

    }
    protected override void Reload()
    {
        base.Reload();
    }
}
    
