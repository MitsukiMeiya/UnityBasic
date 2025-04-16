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
    [SerializeField] Transform source;
    [Range(0f, 1f)]
    [SerializeField] float rate;
    [SerializeField] Vector3 targetPos;
    [SerializeField] float moveSpeed;
    [SerializeField] float rotateSpeed;
   
    private void Update()
    {
        #region Position
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

        /* 3. 목적지로 이동시키기
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        */

        /* 4. 보간해서 이동시키기
        transform.position = Vector3.Lerp(source.position, target.position, rate);
        */
        #endregion


        // 1. 회전 직접 지정 : Euler 를 이용하여 Quaternion으로 변환하여 사용 권장
        //transform.rotation = Quaternion.Euler(0, 60, 0);

        // 1-1. 오일러를 쿼터니언으로 변환
        //Quaternion a = Quaternion.Euler(0, 60, 0);
        // 1-2. 쿼터니언을 오일러로 변환
        //Vector3 b = transform.rotation.eulerAngles;
        // 1-3. 방향을 쿼터니언으로 변환
        //Quaternion c = Quaternion.LookRotation(Vector3.right);


        // 2. 축을 기준으로 회전
        //transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);

        // 3. 지점을 기준으로 회전
        //transform.RotateAround(target.position, Vector3.up, rotateSpeed * Time.deltaTime);

        // 4. 지점을 바라보도록 회전
        //transform.LookAt(target.position);
    }
}
