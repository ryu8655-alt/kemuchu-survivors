using UnityEngine;

/// <summary>
// カメラが常にPlayerを画面の中心にとらえるように
// 追従をするスクリプト
//
/// </summary>

public class CameraController : MonoBehaviour
{
    [SerializeField, Header("Playerオブジェクト")]
    private GameObject _player;





    // Start is called before the first frame update
    void Start()
    {
        transform.position = _player.transform.position;
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(_player.transform.position.x, _player.transform.position.y, -10);
    }
}
