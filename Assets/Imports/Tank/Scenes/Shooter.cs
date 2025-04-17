using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform muzzlePoinst;

    [Range(10,30)]
    [SerializeField] float bulletSpeed;

    public void Fire()
    {
        GameObject instance = Instantiate(bulletPrefab, muzzlePoinst.position, muzzlePoinst.rotation);
        Rigidbody bulletRigidbody = instance.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = muzzlePoinst.forward * bulletSpeed;

        Destroy(instance, 5);
    }
}
