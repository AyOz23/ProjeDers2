using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Kontrol : MonoBehaviour
{
    private float healt;
    public float Damage { get; set; }
    public float Speed { get; set; }
    public string Name { get; set; }


    public float Healt
    {
        get { return healt; }
        set
        {
            healt = value;
            if (healt <= 40)
            {
                Damage = Damage * 0.4f;
            }
        }
    }
    public virtual void Hasar()
    {
        Healt -= Damage;
    }
    public virtual void deger()
    {
        Healt = 0;
        Speed = 0;
        Name = "    ";
        Damage = 0;
    }


}
