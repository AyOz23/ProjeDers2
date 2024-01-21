using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
   [SerializeField] private GameObject bulletPrefabb;
   [SerializeField] private int bulletSpeed;
    
    private void Start()
    {
        Rigidbody bulletRb = bulletPrefabb.GetComponent<Rigidbody>();
    }
    private void Update()
    {
        transform.Translate(Vector3.forward * bulletSpeed* Time.deltaTime);
    }
}
