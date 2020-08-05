using System.Collections.Generic;
using UnityEngine;
using System;

namespace AnotherDeleter {

    /// <summary>
    /// ステート制御用の基底クラス
    /// </summary>
    public class StateMachine : IStateMachine {
        // 現在のステート   
        IState currentState = null;
        // ステートマシンで管理しているすべてのステート
        Dictionary<Type, IState> states = new Dictionary<Type, IState>();

        /// <summary>
        /// MonovihaberのStartで呼んでほしい初期化処理
        /// </summary>
        /// <param name="target">ステートの対象オブジェクト</param>
        public virtual void Start(GameObject target){           
        }

        /// <summary>
        /// ステートを登録する処理
        /// </summary>
        /// <typeparam name="T">IStateインターフェースを継承したクラス</typeparam>
        /// <param name="state"></param>
        /// <param name="target"></param>
        public void AddState<T>(T state, GameObject target) where T : IState {
            state.Init(target, this);
            states.Add(typeof(T), state);
        }

        /// <summary>
        /// ステートを切り替える処理
        /// </summary>
        /// <param name="newStateType">変更後のステート</param>
        public void ChangeState(Type newStateType) {
            // 現在のステートの終了時処理を行う
            if (currentState != null)
            {
                currentState.Exit();
            }
            // ステートを新しいステートに変更する
            currentState = states[newStateType];
            // 新しいステートの開始処理を行う
            currentState.Entry();
        }

        /// <summary>
        /// 現在のステートのUpdate用処理を呼ぶ
        /// </summary>
        public void Update() {
            currentState.Do();
        }

        /// <summary>
        /// 現在のステートのFixUpdate用の処理を呼ぶ
        /// </summary>
        public void FixedUpdate() {
            currentState.FixedDo();
        }
    }
}

