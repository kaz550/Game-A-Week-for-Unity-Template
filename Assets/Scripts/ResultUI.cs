using UnityEngine;

/// <summary>
/// リザルト画面のUI管理クラス
/// </summary>
public class ResultUI : MonoBehaviour
{
    /// <summary>
    /// シーン開始時に呼ばれる
    /// 現在のステートをResultに設定する
    /// </summary>
    private void Start()
    {
        if (GameManager.instance.currentState != State.Result)
        {
            GameManager.instance.currentState = State.Result;
        }
    }

    /// <summary>
    /// タイトルへ戻るボタン
    /// </summary>
    public void OnToTitleButton()
    {
        // ステート終了フラグをON
        GameManager.instance.stateEnd = true;
    }
}