using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Assertions.Comparers;

public class Pistols : WeaponSystemMain
{
   // ammo 14 
    protected override int ammoCapacity
    { get => base.ammoCapacity;
      set => base.ammoCapacity = 14; }
   // damage 10 for now later we can do 30 etc.
    protected override float weaponDamage 
    { get => base.weaponDamage; 
      set => base.weaponDamage = 10; }
    // fire rate 1 
    protected override float firingrate 
    { get => base.firingrate; 
      set => base.firingrate = 1; }
    // bullet speed on pistol ???????
    protected override float bulletSpeed 
    { get => base.bulletSpeed; 
      set => base.bulletSpeed = value; }
    protected override void Update()
    {
        base.Update();
    }
}
