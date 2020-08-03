using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerStateMachine : StateMachine {


    // 各ステートのインスタンス    
    [SerializeField]
    PlayerIdleState idleState  = default;
    [SerializeField]
    PlayerMoveState moveState  = default;
  
    public void Init(){
       
        // ステートのセット
        idleState = new PlayerIdleState(gameObject,ChangeState);
        moveState = new PlayerMoveState(gameObject,ChangeState);
        // 初期のステートをセット
        ChangeState(moveState);
    }
    

}
