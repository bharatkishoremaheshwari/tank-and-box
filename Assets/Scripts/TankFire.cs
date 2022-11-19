using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFire : MonoBehaviour
{
    [SerializeField]
    private GameObject shell;
    [SerializeField]
    private Transform shellParentGO;
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private float fireRate = 1f;
    [SerializeField]
    private float fireForce = 1000f;
    private float nextFire = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            GameObject shellInit = Instantiate(shell, firePoint.position, Quaternion.identity, shellParentGO);
            shellInit.GetComponent<Rigidbody>().AddForce(firePoint.forward * fireForce);
        }
    }
}
