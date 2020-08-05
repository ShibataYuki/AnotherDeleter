using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace AnotherDeleter.GameScene {

    /// <summary>
    /// プレイヤー用ステートマシン
    /// </summary>
    [Serializable]
    public class PlayerStateMachine : StateMachine {
        // 各ステートのインスタンス    
        [SerializeField]
        readonly PlayerIdleState idleState = new PlayerIdleState();
        [SerializeField]
        readonly PlayerMoveState moveState = new PlayerMoveState();

        /// <summary>
        /// MonovihaberのStartで呼んでほしい初期化処理
        /// </summary>
        /// <param name="target">ステートの対象オブジェクト</param>
        public override void Start(GameObject target){
            // ステートの登録
            AddState<PlayerIdleState>(idleState, target);
            AddState<PlayerMoveState>(moveState, target);
            // 初期ステートをセット
            ChangeState(typeof(PlayerIdleState));
        }

    }
}

