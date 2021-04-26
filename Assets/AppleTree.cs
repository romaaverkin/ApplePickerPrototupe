using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Unspector")]
    // ������ ��� �������� �����
    public GameObject applePrefab;

    // �������� �������� ������
    public float speed = 1f;

    // ����������, �� ������� ������ ���������� ����������� �������� ������
    public float ledtAndRightEdge = 10f;

    // ����������� ���������� ��������� ����������� ��������
    public float chanceToChangeDirections = 0.1f;

    // ������� �������� ����������� �����
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // ���������� ������ ��� � �������        
    }

    // Update is called once per frame
    void Update()
    {
        // ������� �����������
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // ��������� �����������
        if (pos.x < -ledtAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > ledtAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }
}
