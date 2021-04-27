using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // �������� ������� ���������� ��������� ���� �� ������ �� Input
        Vector3 mousePos2D = Input.mousePosition;

        // ���������� z ������ ����������, ��� ������ � ���������� ������������ ��������� ��������� ����
        mousePos2D.z = -Camera.main.transform.position.z;

        // ������������� ����� �� ��������� ��������� ������ � ���������� ���������� ����
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        // ����������� ������� ����� ��� X � ���������� X ��������� ����
        Vector3 pos = transform.position;
        pos.x = mousePos3D.x;
        transform.position = pos;
    }
}
