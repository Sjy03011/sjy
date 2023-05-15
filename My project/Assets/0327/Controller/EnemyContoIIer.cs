using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyContoIIer : MonoBehaviour
{
    public float speed = 5.0f;

    public float rotationSpeed = 1f;
    public GameObject bulletPrefab;
    public GameObject EnemyPivot;
    public Transform firePoint;
    public float fireRate = 1f;
    public float nextFireTime;

    public Rigidbody rb;
    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        player = GameObject.FindGameObjectWithTag("Player").transform;

    }   

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(player.position , transform.position)>5.0f)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }

        Vector3 targetDiection = (player.position - EnemyPivot.transform.position).normalized;
        Quaternion targetRotation = Quaternion.LookRotation(targetDiection);
        EnemyPivot.transform.rotation =
             Quaternion.Lerp(EnemyPivot.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);



        if(Time.time >nextFireTime)
        {
            nextFireTime = Time.time + 1f / fireRate;
            GameObject temp = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            temp.GetComponent<ProjectileMove>().launchDirection = firePoint.localRotation * Vector3.forward;
            temp.GetComponent<ProjectileMove>().projectileType = ProjectileMove.PROJECTILETYPE.ENENY;
        }

    }
}
