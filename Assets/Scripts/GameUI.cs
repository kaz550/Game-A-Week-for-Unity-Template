using UnityEngine;

/// <summary>
/// ゲーム画面のUI管理クラス
/// </summary>
public class GameUI : MonoBehaviour
{
    /// <summary>
    /// シーン開始時に呼ばれる
    /// 現在のステートをGameに設定する
    /// </summary>
    private void Start()
    {
        if (GameManager.instance.currentState != State.Game)
        {
            GameManager.instance.currentState = State.Game;
        }
    }

    /// <summary>
    /// リザルト画面へ移動するボタン
    /// </summary>
    public void OnToResultButton()
    {
        // ステート終了フラグをON
        GameManager.instance.stateEnd = true;
    }
}