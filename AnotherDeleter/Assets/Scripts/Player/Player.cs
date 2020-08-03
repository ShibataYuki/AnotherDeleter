using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnotherDeleter
{
    // プレイヤーの更新処理を実行します。
    public class Player : MonoBehaviour
    {
        // 各ステートのインスタンス    
        [SerializeField]
        PlayerIdleState idleState = default;
        [SerializeField]
        PlayerMoveState moveState = default;

        StateMachine stateMachine = new StateMachine();

        private void Awake()
        {
            // ステートマシンへステートを登録
            stateMachine.AddState(idleState, gameObject);
            stateMachine.AddState(moveState, gameObject);
            stateMachine.ChangeState(typeof(PlayerIdleState));
        }

        private void Start()
        {

        }

        private void Update()
        {
            stateMachine.Update();
        }

        private void FixedUpdate()
        {
            stateMachine.FixedUpdate();
        }
    }
}
