using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyTester : MonoBehaviour
{
    [SerializeField] Rigidbody rigid;
    [SerializeField] float power;

    private float xInput;

    private void Update()
    {
        xInput = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.right * power, ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        // 1. 힘 가해주기 : 가속시키기
        // rigid.AddForce(Vector3.right * xInput * power, ForceMode.Force);

        // 2. 속도를 설정하기 : 속도를 원하는대로 설정
        // rigid.velocity = Vector3.right * power * xInput;

        // 3. 회전력 가해주기
        // rigid.AddTorque(Vector3.up * xInput * power);

        // 4. 회전속도 설정하기
        // rigid.angularVelocity= Vector3.up * power * xInput;
    }
}
