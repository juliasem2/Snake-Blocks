using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] private Transform Snake;
    [SerializeField] private float Speed;
    void Update()
    {
        //������ �������� ������
        Snake.position += Vector3.forward * Speed * Time.deltaTime;
        
        //����������� ������� ��� �������� ������
        if (Input.GetKey(KeyCode.A))
        {
            Snake.position += Vector3.left * Speed * Time.deltaTime;
        }


        //����������� ������� ��� �������� �������
        if (Input.GetKey(KeyCode.D))
        {
            Snake.position += Vector3.right * Speed * Time.deltaTime;
        }
    }
}
