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
    [SerializeField] Transform source;
    [Range(0f, 1f)]
    [SerializeField] float rate;
    [SerializeField] Vector3 targetPos;
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
   
    private void Update()
    {
        #region Position
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

        /* 3. �������� �̵���Ű��
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        */

        /* 4. �����ؼ� �̵���Ű��
        transform.position = Vector3.Lerp(source.position, target.position, rate);
        */
        #endregion


        // 1. ȸ�� ���� ���� : Euler �� �̿��Ͽ� Quaternion���� ��ȯ�Ͽ� ��� ����
        //transform.rotation = Quaternion.Euler(0, 60, 0);

        // 1-1. ���Ϸ��� ���ʹϾ����� ��ȯ
        //Quaternion a = Quaternion.Euler(0, 60, 0);
        // 1-2. ���ʹϾ��� ���Ϸ��� ��ȯ
        //Vector3 b = transform.rotation.eulerAngles;
        // 1-3. ������ ���ʹϾ����� ��ȯ
        //Quaternion c = Quaternion.LookRotation(Vector3.right);


        // 2. ���� �������� ȸ��
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);

        // 3. ������ �������� ȸ��
        //transform.RotateAround(target.position, Vector3.up, rotateSpeed * Time.deltaTime);

        // 4. ������ �ٶ󺸵��� ȸ��
        //transform.LookAt(target.position);
    }
}
