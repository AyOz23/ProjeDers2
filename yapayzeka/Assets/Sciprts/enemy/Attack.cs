using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Attack : MonoBehaviour, IBossEnemy
{
    public GameObject tasPrefab;
    public int tasSayisi = 10;
    public float yagisHizi = 5f;
    public Transform hedefObjesi;
    public bool AtackYapabilirMi { get; set; }
    void TasYagdir()
    {
        Vector3 hedefPozisyon = hedefObjesi.position;

        for (int i = 0; i < tasSayisi; i++)
        {
            float xPozisyonu = Random.Range(hedefPozisyon.x - 5f, hedefPozisyon.x + 5f);
            float yPozisyonu = Random.Range(hedefPozisyon.y + 8f, hedefPozisyon.y + 12f);
            float zPozisyonu = Random.Range(hedefPozisyon.z - 5f, hedefPozisyon.z + 5f);

            Vector3 baslangicPozisyonu = new Vector3(xPozisyonu, yPozisyonu, zPozisyonu);

            GameObject tas = Instantiate(tasPrefab, baslangicPozisyonu, Quaternion.identity);
            Rigidbody tasRigidbody = tas.GetComponent<Rigidbody>();
            tasRigidbody.velocity = Vector3.down * yagisHizi;

            Destroy(tas, 3f);
        }
    }
    public void Atack()
    {
        if (AtackYapabilirMi)
        {
            InvokeRepeating("TasYagdir", 1f, 5f);

        }
    }
}
