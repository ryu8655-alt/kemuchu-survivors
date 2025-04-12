using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Exit�{�^���������ꂽ���̏���
/// �A�v���P�[�V�����̏I���E�G�f�B�^��Play���[�h���I������

public class ExitButton : MonoBehaviour
{
    private Button _button;

    private void Awake()
    {
        //Button�R���|�[�l���g���擾
        _button = GetComponent<Button>();

        //�{�^���ɃN���b�N�C�x���g��ǉ�
        _button.onClick.AddListener(ExitGame);
    }

    /// <summary>
    /// �Q�[���̏I������
    ///</summary>
    private void ExitGame()
    {
        //�G�f�B�^�g�p����Play���[�h�̏I��
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
            //�r���h�ł̓A�v���P�[�V�������I��
            Application.Quit();
        #endif
    }

}
