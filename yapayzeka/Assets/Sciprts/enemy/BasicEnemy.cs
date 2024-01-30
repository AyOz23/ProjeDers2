using UnityEngine;
using UnityEngine.AI;

public class BasicEnemy : Kontrol
{
    public Player player1;
    public NavMeshAgent navMeshAgent;
    public Pistols pistol2;
    public void Awake()
    {
        player1 = GameObject.FindObjectOfType<Player>();
        pistol2 = GameObject.FindObjectOfType<Pistols>();
    }
    public void Start()
    {
        SetAgentSpeed(10);
        deger();
        
    }
    public void Update()
    {
        InvokeRepeating("Hasar1", 0f, 1000f);
        if (Healt < 0)
        {
            Destroy(gameObject);
        }
    }
    public void Hasar1()
    {
        float dis = Vector3.Distance(transform.position, player1.transform.position);

        if (dis <= 2f)
        {
            player1.Healt -= Damage;

        }

    }
    public void deger()
    {
        Healt = 100f;
        Speed = 12f;
        Name = "BasicEnemy";
        Damage = 0.01f;
    }
    void SetAgentSpeed(float speed)
    {
        navMeshAgent.speed = speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        // Çarpýþan nesnenin etiketini kontrol et
        if (collision.gameObject.tag == "Mermi")
        {
            Healt -= pistol2.weaponDamgePublic;
            Debug.Log("ÇArpýþtý Mermi");
        }
    }
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {  
        // Çarpýþan nesnenin etiketini kontrol et
        if (hit.gameObject.tag == "Mermi")
        {
            Healt -= pistol2.weaponDamgePublic;
            Debug.Log("ÇArpýþtý Mermi");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        // Çarpýþan nesnenin etiketini kontrol et
        if (other.gameObject.tag == "Mermi")
        {
            Healt -= pistol2.weaponDamgePublic;
            Debug.Log("Düþmana Verilen Hasar" + pistol2.weaponDamgePublic);
        }
    }
    

}
    
