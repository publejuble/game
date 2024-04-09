using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Animator animator; // �ִϸ����͸� �����Ѵ�.
    [SerializeField] float horizontalInput;
    bool IsRun;
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        if (horizontalInput > 0) // ���������� �̵��� ��
        {
            transform.localScale = new Vector3(1, 1, 1);
            animator.SetBool("Run", true);
        }
        else if (horizontalInput < 0) // �������� �̵��� ��
        {
            transform.localScale = new Vector3(-1, 1, 1);
            animator.SetBool("Run", true);
        }

        else
        {
            animator.SetBool("Run", false);
        }

    }
}
