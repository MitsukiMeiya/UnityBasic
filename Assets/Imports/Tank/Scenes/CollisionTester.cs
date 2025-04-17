using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTester : MonoBehaviour
{
    /* 충돌
     * 충돌체 : 게임 보으젝트의 물리적 충돌을 목적으로 모양을 정의
     * 게임오브젝트 간의 충돌체로 부딪힘과 반발력을 처리
     * 충돌체는 충돌상황에 있을 경우 유니티 충돌 메시지를 받아 상황을 확인
     */

    // 유니티 충돌 메시지
    private void OnCollisionEnter(Collision collision)
    {
        // 충돌 진입시 호출
        Debug.Log($"{collision.gameObject.name}랑 충돌을 시작함");
    }

    private void OnCollisionStay(Collision collision)
    {
        // 충돌중 호출
        Debug.Log($"{collision.gameObject.name}랑 충돌 중");
    }

    private void OnCollisionExit(Collision collision)
    {
        // 충돌 해제시 호출
        Debug.Log($"{collision.gameObject.name}랑 충돌 끝남");
    }

    /* 트리거
     * 하나의 충돌체가 충돌을 일으키지 않고 다른 충돌체의 공간에 들어가는 것을 감지
     * 트리거는 겹침상황에 있을 경우 유니티 트리거 메시지를 받아 상황을 확인
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
