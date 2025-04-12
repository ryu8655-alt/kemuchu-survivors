using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

/// <summary>
/// メニューボタン処理スクリプト
/// インスペクター上で入力されたシーン名を取得し、
/// ボタンが押させた時にBuildeSettings内に対象のシーンあるか確認し、
/// シーンの遷移を実施する
/// </summary>

public class MenuButton : MonoBehaviour
{
    [SerializeField,Header("クリック時に遷移するシーン名")]
    private string _sceneName = string.Empty;


    private Button _button;


    private void Awake()
    {
        //Buttonコンポーネントを取得
        _button = GetComponent<Button>();

        //ボタンが押された時の処理を登録
        _button.onClick.AddListener(TryLoadScene);

    }

    private void TryLoadScene()
    {
        if (string.IsNullOrEmpty(_sceneName))
        {
            //シーン名が設定されていない場合が、エラーログを出力する
            Debug.LogWarning($"[{gameObject.name}]シーン名が設定されていません");
            return;
        }

        //シーン名がBuildSettingsに登録されているか確認
        if (!IsSceneInBuildSettings(_sceneName))
        {
            //登録されていない場合は、エラーログを出力する
            Debug.LogWarning($"[{gameObject.name}]シーン名「{_sceneName}」はBuildSettingsに登録されていません");
            return;
        }
        //シーンの遷移を実施
        SceneManager.LoadScene(_sceneName);
    }



    /// <summary>
    /// 遷移先に指定したシーンがBuildSettingsに登録されているか確認する
    /// </summary>
    /// <param 第一引数="sceneName">確認対象のシーン名</param>
    /// <returns></returns>
    private bool IsSceneInBuildSettings(string targetsceneName)
    {
        //BuildSettingsに登録されているシーンのパスを取得
        int sceneCount = SceneManager.sceneCountInBuildSettings;

        for (int i = 0; i < sceneCount; ++i)
        {
            //シーンのパスを取得
            string scenePath = SceneUtility.GetScenePathByBuildIndex(i);
            //シーン名を取得
            string sceneName = System.IO.Path.GetFileNameWithoutExtension(scenePath);

            //指定したシーン名と一致するか確認
            if (sceneName == targetsceneName)
            {
                //一致した場合はtrueを返す
                return true;
            }

        }

        return false;
    }

}
