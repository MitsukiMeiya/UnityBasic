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
        // 1. �� �����ֱ� : ���ӽ�Ű��
        // rigid.AddForce(Vector3.right * xInput * power, ForceMode.Force);

        // 2. �ӵ��� �����ϱ� : �ӵ��� ���ϴ´�� ����
        // rigid.velocity = Vector3.right * power * xInput;

        // 3. ȸ���� �����ֱ�
        // rigid.AddTorque(Vector3.up * xInput * power);

        // 4. ȸ���ӵ� �����ϱ�
        // rigid.angularVelocity= Vector3.up * power * xInput;
    }
}
