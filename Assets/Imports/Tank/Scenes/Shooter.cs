using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform muzzlePoint;
    //[SerializeField] ObjectPool bulletPool;

    [Range(10,30)]
    [SerializeField] float bulletSpeed;

    public void Fire()
    {
        gameObject instance = Instantiate(bulletPrefab.);
        //PooledObject instance = bulletPool.GetPool(muzzlePoint.position, muzzlePoint.rotation);
        Rigidbody bulletRigidbody = instance.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = muzzlePoint.forward * bulletSpeed;
    }
}
