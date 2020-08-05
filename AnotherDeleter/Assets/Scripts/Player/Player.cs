using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace AnotherDeleter.GameScene {

    public class Player : MonoBehaviour {
        // ステートを管理するステートマシン
        [SerializeField]
        PlayerStateMachine stateMachine = new PlayerStateMachine();
        private void Awake() {

        }

        private void Start() {
            // ステートマシンの初期設定
            stateMachine.Start(gameObject);
        }
        private void Update() {
            // ステートマシンのフレーム更新処理
            stateMachine.Update();
        }

        private void FixedUpdate() {
            // ステートマシンの固定フレームレート更新処理
            stateMachine.FixedUpdate();
        }
    }

}
