using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] Rigidbody rigid;

    [Header("Propertis")]
    [SerializeField] GameObject explosionEffectPrefab;
    private void Update()
    {
        if (rigid.velocity.magnitude > 2)
        {
            transform.forward = rigid.velocity;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(explosionEffectPrefab, transform.position, transform.rotation);
    }
}
