using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageAble
{
    int IHealth { get; set; }
    void TakeDamage(float DamageAmount);
}
