using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifles : WeaponSystemMain
{
    protected override int ammoCapacity
    { get => base.ammoCapacity;
      set => base.ammoCapacity = 24; }
    protected override float bulletSpeed
    { get => base.bulletSpeed;
      set => base.bulletSpeed = 50; }
    protected override float weaponDamage 
    { get => base.weaponDamage; 
      set => base.weaponDamage = 30; }
    protected override float firingrate 
    { get => base.firingrate; 
      set => base.firingrate = 0.5f; }
    
}
