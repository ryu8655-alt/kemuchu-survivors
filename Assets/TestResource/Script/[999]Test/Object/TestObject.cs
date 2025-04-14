using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// ポーズメニューを作成するにあたり
/// ポーズメニューが機能しているかどうかを確認する為の
/// 指定された2点間を直線移動するだけのObjectスクリプト
/// </summary>

public class TestObject : MonoBehaviour
{
    [SerializeField, Header("移動速度"),Range(0.1f,1.0f)]
    private float _speed = 1.0f;

    [SerializeField, Header("移動開始地点")]
    private Vector3 _startPosition;

    [SerializeField, Header("移動終了地点")]
    private Vector3 _endPosition;



    // Start is called before the first frame update
    void Start()
    {
        //初期位置の設定を行う
        this.transform.position = _startPosition;
    }


    private void FixedUpdate()
    {
        Move();
    }


    private void Move()
    {
        //指定された2点間を直線移動する
        this.transform.position = Vector3.Lerp(_startPosition, _endPosition, Mathf.PingPong(Time.time * _speed, 1));

        //もし、終了地点に到達したら、開始地点を目指して移動する
        if (this.transform.position == _endPosition)
        {
            this.transform.position = Vector3.Lerp(_endPosition, _startPosition, Mathf.PingPong(Time.time * _speed, 1));
        }
    
    }
}
