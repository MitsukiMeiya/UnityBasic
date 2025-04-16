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
         * 특정한 장치를 기준으로 입력감지
         * 특정한 장치의 입력을 감지하기 때문에 여러 플랫폼에 대응이 어려움
         */
        if (Input.GetKey(KeyCode.Space))        // sn르고 있는 동안 true
        {
            Debug.Log("Get Key!");
        }
        if (Input.GetKeyDown(KeyCode.Space))    // 눌렀을 때 한번만 true
        {
            Debug.Log("Get Key Down!");
        }
        if (Input.GetKeyUp(KeyCode.Space))      // 눌렀다 땠을 때 한번만 true
        {
            Debug.Log("Get Key Up!");
        }

        // 마우스 입력 감지
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
         * 여러 장치의 입력을 입력매니저에 이름과 입력을 정의
         * 입력매니저의 이름으로 정희한 입력의 변경사항을 확인
         * 유니티 에디터의 Edit -> Project Settings -> Input Manager 에서 관리
         * 단, 유니티 초창기의 방식이기 때문에 키보드, 마우스, 조이스틱에 대한 장치만을 고려함
         */

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Fire1 버튼 눌림");
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
