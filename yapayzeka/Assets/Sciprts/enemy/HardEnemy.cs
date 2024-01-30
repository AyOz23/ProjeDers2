using UnityEngine;
using UnityEngine.AI;

public class HardEnemy : Kontrol
{
    public Player player2;
    public NavMeshAgent navMeshAgent;
    public Pistols pistol;

    public void Awake()
    {
        player2 = GameObject.FindObjectOfType<Player>();
        pistol = GameObject.FindObjectOfType<Pistols>();
    }
    public void Start()
    {
        SetAgentSpeed(10);
        deger();
        
    }
    public void Update()
    {
        InvokeRepeating("Hasar2", 0f, 1000f);
        if (Healt < 0)
        {
            Destroy(gameObject);
        }
    }
    public void Hasar2()
    {

        float dis = Vector3.Distance(transform.position, player2.transform.position);

        if (dis <= 1f)
        {
            player2.Healt -= Damage;
    
        }

    }
    public void deger()
    {
        Healt = 100f;
        Speed = 100f;
        Name = "HardEnemy";
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
            Healt -= pistol.weaponDamgePublic;
            Debug.Log("ÇArpýþtý Mermi");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        // Çarpýþan nesnenin etiketini kontrol et
        if (other.gameObject.tag == "Mermi")
        {
            Healt -= pistol.weaponDamgePublic;
            Debug.Log("Düþmana Verilen Hasar" + pistol.weaponDamgePublic);
        }
    }
}
