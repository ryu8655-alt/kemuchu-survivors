using UnityEngine;

/// <summary>
// �J���������Player����ʂ̒��S�ɂƂ炦��悤��
// �Ǐ]������X�N���v�g
//
/// </summary>

public class CameraController : MonoBehaviour
{
    [SerializeField, Header("Player�I�u�W�F�N�g")]
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
