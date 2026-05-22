using UnityEngine;

/// <summary>
/// タイトル画面のUI管理クラス
/// </summary>
public class TitleUI : MonoBehaviour
{
    /// <summary>
    /// シーン開始時に呼ばれる
    /// 現在のステートをTitleに設定する
    /// </summary>
    private void Start()
    {
        // 現在のステートを確認
        if (GameManager.instance.currentState != State.Title)
        {
            GameManager.instance.currentState = State.Title;
        }
    }

    /// <summary>
    /// スタートボタンを押した時
    /// </summary>
    public void OnStartButton()
    {
        // ステート終了フラグをON
        GameManager.instance.stateEnd = true;
    }
}