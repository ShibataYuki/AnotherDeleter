using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace AnotherDeleter.GameScene {

    /// <summary>
    /// プレイヤー用移動ステート
    /// </summary>
    [Serializable]
    public class PlayerMoveState : State {

        // 走行時のスピード
        [SerializeField]
        float runSpeed = 5;
        // リジッドボディ
        Rigidbody rigidbody = default;

        /// <summary>
        /// 初期化処理
        /// </summary>
        /// <param name="target">ステートの対象オブジェクト</param>
        /// <param name="parent">ステートを管理するステートマシン</param>
        public override void Init(GameObject target, IStateMachine parent) {
            base.Init(target, parent);
            rigidbody = target.GetComponent<Rigidbody>();
        }

        /// <summary>
        /// 現在のステートの固定フレームで呼ばれる処理
        /// </summary>
        public override void FixedDo() {
            Move();
        }

        /// <summary>
        /// キー入力による移動処理
        /// </summary>
        void Move() {
            // 左スティックに入力があるか
            bool isLeftStickInputed = Input.GetAxis("Horizontal") != 0
                                      || Input.GetAxis("Vertical") != 0;
            // 左スティックに入力があるなら
            if (isLeftStickInputed)
            {
                float zPower = Input.GetAxis("Vertical") * runSpeed * Time.fixedDeltaTime;
                float xPower = Input.GetAxis("Horizontal") * runSpeed * Time.fixedDeltaTime;
                rigidbody.AddForce(xPower, 0, zPower);
                Debug.Log(rigidbody);
            }

        }
    }
}

