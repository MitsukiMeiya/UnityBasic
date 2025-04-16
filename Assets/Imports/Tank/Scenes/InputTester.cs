using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputTester : MonoBehaviour
{
    public float result;
    public void Update()
    {
        #region Device
        /* Device
         * Ư���� ��ġ�� �������� �Է°���
         * Ư���� ��ġ�� �Է��� �����ϱ� ������ ���� �÷����� ������ �����
         */
        if (Input.GetKey(KeyCode.Space))        // sn���� �ִ� ���� true
        {
            Debug.Log("Get Key!");
        }
        if (Input.GetKeyDown(KeyCode.Space))    // ������ �� �ѹ��� true
        {
            Debug.Log("Get Key Down!");
        }
        if (Input.GetKeyUp(KeyCode.Space))      // ������ ���� �� �ѹ��� true
        {
            Debug.Log("Get Key Up!");
        }

        // ���콺 �Է� ����
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Mouse left butto is pressing!");
        }
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Get Mouse Down!");
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Get Key Up!");
        }
        #endregion

        /* InputManager
         * ���� ��ġ�� �Է��� �Է¸Ŵ����� �̸��� �Է��� ����
         * �Է¸Ŵ����� �̸����� ������ �Է��� ��������� Ȯ��
         * ����Ƽ �������� Edit -> Project Settings -> Input Manager ���� ����
         * ��, ����Ƽ ��â���� ����̱� ������ Ű����, ���콺, ���̽�ƽ�� ���� ��ġ���� �����
         */

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire1 ��ư ����");
        }

        result = Input.GetAxis("Horizontal");

        float axis = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            axis -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            axis += 1;
        }
    }







}
