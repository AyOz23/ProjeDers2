using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    NavMeshAgent ajan;
    public GameObject Hedef;

    // Start is called before the first frame update
    void Start()
    {
        ajan = GetComponent<NavMeshAgent>();
    }
    public void hedefbelirle(GameObject objem)
    {
        Hedef=objem;
    }
    // Update is called once per frame
    void Update()
    {
        ajan.SetDestination(Hedef.transform.position);
    }
}
