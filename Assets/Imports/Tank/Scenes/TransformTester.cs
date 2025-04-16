using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTester : MonoBehaviour
{
    /* Ʈ������
     * ���ӿ�����Ʈ�� ��ġ, ȸ��, ũ�⸦ �����ϴ� ������Ʈ
     * ���ӿ�����Ʈ�� �θ�-�ڽ� ���¸� �����ϴ� ������Ʈ
     * ���ӿ�����Ʈ�� �ݵ�� �ϳ��� Ʈ������ ������Ʈ�� ������ ������ �߰� & ������ �� ����
     */
    [SerializeField] Transform target;
    [SerializeField] Vector3 targetPos;
    [SerializeField] float moveSpeed;
   
    private void Update()
    {
        /* 1. ���͸� �̿��� ��ġ ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(1, 2, 3);
        }
        */

        /* 2. �������� �̵���Ű��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.forward);
        }
        */

        // 3. �������� �̵��ϵ�
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }
}
