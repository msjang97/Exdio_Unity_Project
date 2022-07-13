using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // PlayerController��ũ��Ʈ���� ������ ������Ʈ�� ���� �������� ����
    private Rigidbody playerRigidbody;    // �̵��� ����� ������ٵ� ������Ʈ
    public float speed = 8f;         // �̵� �ӷ�

    void Start()
    {
        // ���� ������Ʈ���� Rigidbody ������Ʈ�� ã�� playerRigidbody�� �Ҵ�
        playerRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // ����� ���� �� �Է� ���� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        // ���� �̵� �ӵ��� �Է� ���� �̵� �ӷ��� ���� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        // Vector3 �ӵ��� (xSpeed, 0, zSpeed)���� ����
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        // ������ٵ��� �ӵ��� newVelocity�� �Ҵ�
        playerRigidbody.velocity = newVelocity;
    }

    public void Die()
    {
        // �ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}


//public float moveSpeed = 10.0f;
//public float rotationSpeed = 5.0f;
//Rigidbody body;

//void Start()
//{
//    body = GetComponent<Rigidbody>();
//    // �߷�����
//    body.useGravity = false;
//}

//void Update()
//{
//    float h = Input.GetAxis("Horizontal");
//    float v = Input.GetAxis("Vertical");

//    Vector3 direction = new Vector3(h, 0, v);

//    if (direction != Vector3.zero)
//    {
//        float angle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;

//        if (90.0f > angle && angle > -90.0f)
//        {
//            angle = angle * rotationSpeed * Time.deltaTime;
//            transform.Rotate(Vector3.up, angle);
//        }
//    }

//    transform.Translate(direction * moveSpeed * Time.deltaTime);
//}