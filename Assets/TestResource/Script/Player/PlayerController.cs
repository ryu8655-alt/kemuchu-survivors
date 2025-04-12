using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

    }


    private void FixedUpdate()
    {
        MovePlayer();
    }



    private void MovePlayer()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical);
        //_rigidbody2D.velocity = direction * 5f; //���̕��@�ňړ��̏������s���ƕ����G���W���̉e�����󂯂邽�߁A������������Ɋ����������邽�ߔp�~

        transform.position += new Vector3(horizontal, vertical, 0) * Time.deltaTime * 5f;

        if(horizontal < 0)//�������̓��͂��������ꍇ���Ɍ�����
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (horizontal > 0)//�E�����̓��͂��������ꍇ�E�Ɍ�����
        {
            transform.localScale = new Vector3(1, 1, 1);
        }


    }
}


