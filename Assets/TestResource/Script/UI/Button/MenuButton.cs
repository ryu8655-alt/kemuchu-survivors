using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

/// <summary>
/// ���j���[�{�^�������X�N���v�g
/// �C���X�y�N�^�[��œ��͂��ꂽ�V�[�������擾���A
/// �{�^����������������BuildeSettings���ɑΏۂ̃V�[�����邩�m�F���A
/// �V�[���̑J�ڂ����{����
/// </summary>

public class MenuButton : MonoBehaviour
{
    [SerializeField,Header("�N���b�N���ɑJ�ڂ���V�[����")]
    private string _sceneName = string.Empty;


    private Button _button;


    private void Awake()
    {
        //Button�R���|�[�l���g���擾
        _button = GetComponent<Button>();

        //�{�^���������ꂽ���̏�����o�^
        _button.onClick.AddListener(TryLoadScene);

    }

    private void TryLoadScene()
    {
        if (string.IsNullOrEmpty(_sceneName))
        {
            //�V�[�������ݒ肳��Ă��Ȃ��ꍇ���A�G���[���O���o�͂���
            Debug.LogWarning($"[{gameObject.name}]�V�[�������ݒ肳��Ă��܂���");
            return;
        }

        //�V�[������BuildSettings�ɓo�^����Ă��邩�m�F
        if (!IsSceneInBuildSettings(_sceneName))
        {
            //�o�^����Ă��Ȃ��ꍇ�́A�G���[���O���o�͂���
            Debug.LogWarning($"[{gameObject.name}]�V�[�����u{_sceneName}�v��BuildSettings�ɓo�^����Ă��܂���");
            return;
        }
        //�V�[���̑J�ڂ����{
        SceneManager.LoadScene(_sceneName);
    }



    /// <summary>
    /// �J�ڐ�Ɏw�肵���V�[����BuildSettings�ɓo�^����Ă��邩�m�F����
    /// </summary>
    /// <param ������="sceneName">�m�F�Ώۂ̃V�[����</param>
    /// <returns></returns>
    private bool IsSceneInBuildSettings(string targetsceneName)
    {
        //BuildSettings�ɓo�^����Ă���V�[���̃p�X���擾
        int sceneCount = SceneManager.sceneCountInBuildSettings;

        for (int i = 0; i < sceneCount; ++i)
        {
            //�V�[���̃p�X���擾
            string scenePath = SceneUtility.GetScenePathByBuildIndex(i);
            //�V�[�������擾
            string sceneName = System.IO.Path.GetFileNameWithoutExtension(scenePath);

            //�w�肵���V�[�����ƈ�v���邩�m�F
            if (sceneName == targetsceneName)
            {
                //��v�����ꍇ��true��Ԃ�
                return true;
            }

        }

        return false;
    }

}
