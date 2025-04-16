using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTester : MonoBehaviour
{
    /* 트랜스폼
     * 게임오브젝트의 위치, 회전, 크기를 저장하는 컴포넌트
     * 게임오브젝트의 부모-자식 상태를 저장하는 컴포넌트
     * 게임오브젝트는 반드시 하나의 트랜스폼 컴포넌트를 가지고 있으며 추가 & 제거할 수 없음
     */
    [SerializeField] Transform target;
    [SerializeField] Vector3 targetPos;
    [SerializeField] float moveSpeed;
   
    private void Update()
    {
        /* 1. 백터를 이용한 위치 설정
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(1, 2, 3);
        }
        */

        /* 2. 방향으로 이동시키기
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector3.forward);
        }
        */

        // 3. 목적지로 이동하디
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
    }
}
