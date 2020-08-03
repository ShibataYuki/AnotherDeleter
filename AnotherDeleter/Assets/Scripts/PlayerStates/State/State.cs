using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

/// <summary>
/// ステートの基底クラス
/// </summary>
public abstract class State
{
    // ステートの所持主であるオブジェクト
    protected GameObject target = default;
    // ステートを切り替えるイベント
    protected event Action<State> ChangeState = default;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="targetObj">ステートの所持主であるオブジェクト</param>
    /// <param name="changeState">ステートを切り替えるイベント</param>
    public State(GameObject targetObj, Action<State> changeState) {
        target = targetObj;
        ChangeState += changeState;
    }
    // 開始処理
    abstract public void Entry();
    // 毎フレーム呼ばれる処理
    abstract public void Do();
    // 物理挙動用処理
    abstract public void Do_Fix();
    // 終了処理
    abstract public void Exit();

}