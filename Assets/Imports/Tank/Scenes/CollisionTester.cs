using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTester : MonoBehaviour
{
    /* �浹
     * �浹ü : ���� ������Ʈ�� ������ �浹�� �������� ����� ����
     * ���ӿ�����Ʈ ���� �浹ü�� �ε����� �ݹ߷��� ó��
     * �浹ü�� �浹��Ȳ�� ���� ��� ����Ƽ �浹 �޽����� �޾� ��Ȳ�� Ȯ��
     */

    // ����Ƽ �浹 �޽���
    private void OnCollisionEnter(Collision collision)
    {
        // �浹 ���Խ� ȣ��
        Debug.Log($"{collision.gameObject.name}�� �浹�� ������");
    }

    private void OnCollisionStay(Collision collision)
    {
        // �浹�� ȣ��
        Debug.Log($"{collision.gameObject.name}�� �浹 ��");
    }

    private void OnCollisionExit(Collision collision)
    {
        // �浹 ������ ȣ��
        Debug.Log($"{collision.gameObject.name}�� �浹 ����");
    }

    /* Ʈ����
     * �ϳ��� �浹ü�� �浹�� ����Ű�� �ʰ� �ٸ� �浹ü�� ������ ���� ���� ����
     * Ʈ���Ŵ� ��ħ��Ȳ�� ���� ��� ����Ƽ Ʈ���� �޽����� �޾� ��Ȳ�� Ȯ��
     */

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger Enter!");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("trigger Stay!");
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("trigger Exit!");
    }
}
