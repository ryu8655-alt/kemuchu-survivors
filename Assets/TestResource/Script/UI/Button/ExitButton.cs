using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Exitボタンが押された時の処理
/// アプリケーションの終了・エディタのPlayモードを終了する

public class ExitButton : MonoBehaviour
{
    private Button _button;

    private void Awake()
    {
        //Buttonコンポーネントを取得
        _button = GetComponent<Button>();

        //ボタンにクリックイベントを追加
        _button.onClick.AddListener(ExitGame);
    }

    /// <summary>
    /// ゲームの終了処理
    ///</summary>
    private void ExitGame()
    {
        //エディタ使用時はPlayモードの終了
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
            //ビルド版はアプリケーションを終了
            Application.Quit();
        #endif
    }

}
