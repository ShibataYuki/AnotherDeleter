using System;
using UnityEngine;

namespace AnotherDeleter {

    /// <summary>
    /// ステートマシンのインターフェース
    /// </summary>
    public interface IStateMachine {

        /// <summary>
        /// MonovihaberのStartで呼んでほしい初期化処理
        /// </summary>
        /// <param name="target">ステートの対象オブジェクト</param>
        void Start(GameObject target);

        /// <summary>
        /// ステートの登録処理
        /// </summary>
        /// <typeparam name="T">IStateインターフェースを継承したクラス</typeparam>
        /// <param name="state">登録したいステート</param>
        /// <param name="target">ステートの対象オブジェクト</param>
        void AddState<T>(T state, GameObject target) where T : IState;

        /// <summary>
        /// ステートの切り替え処理
        /// </summary>
        /// <param name="newStateType"></param>        
        void ChangeState(Type newStateType);

        /// <summary>
        /// 現在のステートでのフレーム更新処理
        /// </summary>
        void Update();

        /// <summary>
        /// 現在のステートでの固定フレームレート更新処理
        /// </summary>
        void FixedUpdate();
    }
}


