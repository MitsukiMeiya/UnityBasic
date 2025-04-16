using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    [SerializeField] float rotateSpeed;

    private void Update()
    {
        Turret();
    }
    private void Turret()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down, rotateSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }
}
