using UnityEngine;
using UnityEngine.AI;

public class NormalEnemy : Kontrol, IDamageAble
{
    public Player player;
    
    public NavMeshAgent navMeshAgent;
    private float healtCenker;
    public Pistols pistol;

    public void Awake()
    {
        player = GameObject.FindObjectOfType<Player>();
        pistol = GameObject.FindObjectOfType<Pistols>();
    }
  
    public void Start()
    {
        SetAgentSpeed(10);
        deger();



    }
    public void Update()
    {
        InvokeRepeating("Hasar", 0f, 1000f);
        if (Healt < 0)
        {
            Destroy(gameObject);
        }
    }
    public void Hasar()
    {

        float dis = Vector3.Distance(transform.position, player.transform.position);

        if (dis <= 1f)
        {
            player.Healt -= Damage;
            
        }

    }
    public void deger()
    {

        Healt = 100f;
        Speed = 12f;
        Name = "NormalEnemy";
        Damage = 0.01f;
    }
    void SetAgentSpeed(float speed)
    {
        navMeshAgent.speed = speed;
    }

    public void TakeDamage(float DamageAmount)
    {
        throw new System.NotImplementedException();
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
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        // Çarpýþan nesnenin etiketini kontrol et
        if (hit.gameObject.tag == "Mermi")
        {
            Healt -= 10;
            Debug.Log("ÇArpýþtý Mermi");
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        // Çarpýþan nesnenin etiketini kontrol et
        if (other.gameObject.tag == "Mermi")
        {
            Healt -= 10;
            Debug.Log("Düþmana Verilen Hasar" + pistol.weaponDamgePublic);
        }
    }
}
