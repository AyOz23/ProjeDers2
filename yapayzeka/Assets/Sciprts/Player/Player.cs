using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : Kontrol
{
    public void deger()
    {
        Healt = 100f;
        Speed = 12f;
        Name = "HardEnemy";
        Damage = 4f;
    }
    public float donmeHizi = 200f;
    public void Start()
    {
        deger();
        
        
    }

    void Update()
    {
        HareketVeDonmeKontrolu();
        die();
        Debug.Log(Healt);
    }
    void HareketVeDonmeKontrolu()
    {
        float yatayDonme = Input.GetAxis("Horizontal");
        float ileriHareket = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up, yatayDonme * donmeHizi * Time.deltaTime);
        transform.Translate(Vector3.forward * ileriHareket * Speed * Time.deltaTime);
    }
    public void die()
    {
        if (Healt < 0) { Debug.Log("ödlün"); }
    }

}