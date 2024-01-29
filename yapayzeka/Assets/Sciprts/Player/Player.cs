using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : Kontrol
{
    public float donmeHizi = 200f;
    public float hareketHizi = 5f;
    void Update()
    {
        HareketVeDonmeKontrolu();
    }
    void HareketVeDonmeKontrolu()
    {
        float yatayDonme = Input.GetAxis("Horizontal");
        float ileriHareket = Input.GetAxis("Vertical");
        // transform.Rotate(Vector3.up, yatayDonme * donmeHizi * Time.deltaTime);
       

        transform.Translate(Vector3.forward * ileriHareket * hareketHizi * Time.deltaTime);
    }
    //public CharacterController characterController;
    //[SerializeField] private int playerSpeed;
    //public GameObject player;

    //void Start()
    //{
    //    characterController = GetComponent<CharacterController>();

    //}
    //void Update()
    //{
    //    float MoveX = Input.GetAxis("Horizontal");
    //    float MoveZ = Input.GetAxis("Vertical");
    //    Walk(playerSpeed, MoveX, MoveZ);
    //}
    //void Walk(float playerspeed, float MoveeX, float MoveeZ)
    //{
    //    Vector3 moveDirection = new Vector3(MoveeX, 0, MoveeZ);
    //    moveDirection.Normalize();
    //    characterController.Move(moveDirection * playerspeed * Time.deltaTime);
    //    // without character controller moving code ->
    //    //transform.position = transform.position + new Vector3(MoveeX * playerspeed * Time.deltaTime, 0, MoveeZ * playerspeed * Time.deltaTime);
    //    // For Turning Karakter Models Left Right and Backward
    //}

}