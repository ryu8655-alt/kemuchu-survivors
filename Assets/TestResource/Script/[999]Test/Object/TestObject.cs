using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// �|�[�Y���j���[���쐬����ɂ�����
/// �|�[�Y���j���[���@�\���Ă��邩�ǂ������m�F����ׂ�
/// �w�肳�ꂽ2�_�Ԃ𒼐��ړ����邾����Object�X�N���v�g
/// </summary>

public class TestObject : MonoBehaviour
{
    [SerializeField, Header("�ړ����x"),Range(0.1f,1.0f)]
    private float _speed = 1.0f;

    [SerializeField, Header("�ړ��J�n�n�_")]
    private Vector3 _startPosition;

    [SerializeField, Header("�ړ��I���n�_")]
    private Vector3 _endPosition;



    // Start is called before the first frame update
    void Start()
    {
        //�����ʒu�̐ݒ���s��
        this.transform.position = _startPosition;
    }


    private void FixedUpdate()
    {
        Move();
    }


    private void Move()
    {
        //�w�肳�ꂽ2�_�Ԃ𒼐��ړ�����
        this.transform.position = Vector3.Lerp(_startPosition, _endPosition, Mathf.PingPong(Time.time * _speed, 1));

        //�����A�I���n�_�ɓ��B������A�J�n�n�_��ڎw���Ĉړ�����
        if (this.transform.position == _endPosition)
        {
            this.transform.position = Vector3.Lerp(_endPosition, _startPosition, Mathf.PingPong(Time.time * _speed, 1));
        }
    
    }
}
