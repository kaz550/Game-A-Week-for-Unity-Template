using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ゲーム全体で使用する状態（ステート）一覧
/// </summary>
public enum State
{
    Init,   // 初期化状態
    Title,  // タイトル画面
    Game,   // ゲーム画面
    Result  // リザルト画面
}

/// <summary>
/// ゲーム全体の状態遷移を管理するクラス
/// </summary>
public class GameManager : MonoBehaviour
{
    /// <summary>
    /// シングルトン用インスタンス
    /// どのシーンからでもアクセスできる
    /// </summary>
    public static GameManager instance;

    /// <summary>
    /// 現在のゲーム状態
    /// </summary>
    public State currentState = State.Init;

    /// <summary>
    /// 現在の状態を終了するフラグ
    /// trueになると次のステートへ遷移する
    /// </summary>
    public bool stateEnd = false;

    /// <summary>
    /// ゲーム開始時に呼ばれる
    /// シングルトン化を行う
    /// </summary>
    private void Awake()
    {
        // まだインスタンスが存在しない場合
        if (instance == null)
        {
            instance = this;

            // シーン切り替え時に破棄しない
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 既に存在する場合は重複生成を防ぐため削除
            Destroy(gameObject);
            return;
        }
    }

    /// <summary>
    /// 毎フレーム実行される
    /// ステート管理を行う
    /// </summary>
    private void Update()
    {
        switch (currentState)
        {
            // 初期化ステート
            case State.Init:

                // 初期化終了時
                if (stateEnd)
                {
                    // タイトルへ遷移
                    currentState = State.Title;

                    // タイトルシーンを読み込む
                    SceneManager.LoadScene("Title");

                    // フラグを戻す
                    stateEnd = false;
                }
                break;

            // タイトルステート
            case State.Title:

                // スタートボタン押下時
                if (stateEnd)
                {
                    // ゲームへ遷移
                    currentState = State.Game;

                    // ゲームシーンを読み込む
                    SceneManager.LoadScene("Game");

                    // フラグを戻す
                    stateEnd = false;
                }
                break;

            // ゲームステート
            case State.Game:

                // ゲーム終了時
                if (stateEnd)
                {
                    // リザルトへ遷移
                    currentState = State.Result;

                    // リザルトシーンを読み込む
                    SceneManager.LoadScene("Result");

                    // フラグを戻す
                    stateEnd = false;
                }
                break;

            // リザルトステート
            case State.Result:

                // タイトルへ戻る時
                if (stateEnd)
                {
                    // タイトルへ遷移
                    currentState = State.Title;

                    // タイトルシーンを読み込む
                    SceneManager.LoadScene("Title");

                    // フラグを戻す
                    stateEnd = false;
                }
                break;

            default:
                break;
        }
    }
}