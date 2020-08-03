using System;
using System.Collections.Generic;
using UnityEngine;

// 単独のステートマシンを表します。
public class StateMachine : IStateMachine
{
    // 現在のステート   
    State currentState = null;

    // このステートマシンで管理しているすべてのステート
    Dictionary<Type, State> states = new Dictionary<Type, State>();

    // ステートを登録します。
    public void AddState<T>(T state, GameObject target) where T : State
    {
        state.Init(target, this);
        states.Add(typeof(T), state);
    }

    // ステートを切り替える処理
    public void ChangeState(Type stateType)
    {
        // 現在のステートの終了時処理を行う
        if (currentState != null) {
            currentState.Exit();
        }
        // ステートを新しいステートに変更する
        currentState = states[stateType];
        // 新しいステートの開始処理を行う
        currentState.Entry();
    }

    public void Update()
    {
        currentState.Do();
    }

    public void FixedUpdate()
    {
        currentState.Do_Fix();
    }
}
