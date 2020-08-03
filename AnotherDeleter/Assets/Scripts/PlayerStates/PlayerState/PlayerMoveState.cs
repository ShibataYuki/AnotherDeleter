using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerMoveState : State
{
   
    [SerializeField]
    float runSpeed = 5;
    Rigidbody playerRigidbody = default;
    
    public PlayerMoveState(GameObject playerObj, System.Action<State> changeState)
            : base(playerObj, changeState) { 
        playerRigidbody = target.GetComponent<Rigidbody>();
    }

    public override void Entry() {
    } 
    public override void Do(){        
    }   
    public override void Do_Fix(){
        Move();
    }
    public override void Exit(){      
    }

    //キー入力を受けて移動
    void Move()
    {       
        // 左スティックに入力があるか
        bool isLeftStickInputed = Input.GetAxis("Horizontal") != 0
                                  || Input.GetAxis("Vertical") != 0;
        // 左スティックに入力があるなら
        if (isLeftStickInputed)
        {
            float zPower = Input.GetAxis("Vertical") * runSpeed * Time.fixedDeltaTime;
            float xPower = Input.GetAxis("Horizontal") * runSpeed * Time.fixedDeltaTime;
            playerRigidbody.AddForce(xPower, 0, zPower);
            Debug.Log(playerRigidbody);
        }

    }
}