using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContoIIer : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody rb;
    private Transform pIayer;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        pIayer = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(pIayer.position , transform.position)>5.0f)
        {
            Vector3 direction = (pIayer.position - transform.position).normalized;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }
    }
}
