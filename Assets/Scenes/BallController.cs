using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float point;
    // Start is called before the first frame update
    void Start()
    {
        point = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        float distance;
        distance=transform.position.z-point;

        if (Input.GetKeyDown(KeyCode.W))//��
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * 50);
        }

        if (Input.GetKeyDown(KeyCode.S))//��
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * 50);
        }

        if (Input.GetKeyDown(KeyCode.A))//��
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * 50);
        }

        if (Input.GetKeyDown(KeyCode.D))//��
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * 50);
        }
    }
}
