using UnityEngine;

/// <summary>
/// �|�[�Y���j���[�̕\����InGame���̈ꎞ��~���s���@�\
/// </summary>


public class PauseButton : MonoBehaviour
{

    //�N���b�N�������Ɉꎞ��~���s��
    public void PauseGame()
    {

       //�Q�[���̈ꎞ��~���s��
        Time.timeScale = 0.0f;
    }

    //�N���b�N�������ɍĊJ���s��
    public void ResumeGame()
    {
        if(Time.timeScale == 0.0f)
        {
            //�Q�[���̍ĊJ���s��
            //�Q�[���̍ĊJ���s��
        Time.timeScale = 1.0f;
        }
        
    }



}
