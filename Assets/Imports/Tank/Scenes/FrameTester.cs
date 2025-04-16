using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FrameTester : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] int frame;

    private void Start()
    {
        Application.targetFrameRate = 30;
    }

    
    void Update()
    {
        Debug.Log("프레임 갱신");

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Application.targetFrameRate = frame;
        }

    }
}
