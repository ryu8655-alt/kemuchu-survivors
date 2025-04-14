using UnityEngine;

/// <summary>
/// ポーズメニューの表示とInGame内の一時停止を行う機能
/// </summary>


public class PauseButton : MonoBehaviour
{

    //クリックした時に一時停止を行う
    public void PauseGame()
    {

       //ゲームの一時停止を行う
        Time.timeScale = 0.0f;
    }

    //クリックした時に再開を行う
    public void ResumeGame()
    {
        if(Time.timeScale == 0.0f)
        {
            //ゲームの再開を行う
            //ゲームの再開を行う
        Time.timeScale = 1.0f;
        }
        
    }



}
