using System;
using UnityEngine;

// ステートマシンの定義を表したインターフェイスです。
public interface IStateMachine
{
    // ステートを登録します。
    void AddState<T>(T state, GameObject target) where T : State;
    // ステートを切り替える処理
    void ChangeState(Type stateType);
    // 現在のステートでフレーム更新処理を実行します。
    void Update();
    // 現在のステートで固定フレームレート更新処理を実行します。
    void FixedUpdate();
}
