using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnotherDeleter.GameScene {

    /// <summary>
    /// プレイヤー用待機ステート
    /// </summary>
    [System.Serializable]
    public class PlayerIdleState : State {

        public override void Init(GameObject target, IStateMachine parent) {
            base.Init(target, parent);
        }

        public override void Do() {
        }

        public override void FixedDo() {
        }
        public override void Entry() {
        }
        public override void Exit() {
        }
    }
}


