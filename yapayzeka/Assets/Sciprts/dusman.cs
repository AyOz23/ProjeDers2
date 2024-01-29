using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusman : MonoBehaviour
{
    public GameObject[] askerler;
    public GameObject[] cikislar;
    public GameObject[] hedefler;

    public int maksAskerSayisi =10; // Durdurulacak asker sayýsý
    void Start()
    {
        StartCoroutine(DusmanBase());
    }
    IEnumerator DusmanBase()
    {
        for (int olusturulanAskerSayisi = 0; olusturulanAskerSayisi < maksAskerSayisi; olusturulanAskerSayisi++)
        {
            {
                yield return new WaitForSeconds(2f);
                int asker = Random.Range(0, 3);
                int cikis = Random.Range(0, 2);
                int hedef = Random.Range(0, 2);

                GameObject obje = Instantiate(askerler[asker], cikislar[cikis].transform.position, Quaternion.identity);
                obje.GetComponent<KarakterTakip>().hedefbelirle(hedefler[hedef]);
            }
        }        
    }    
}
