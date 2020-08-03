using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerMoveState : State
{
    [SerializeField]
    float runSpeed = 5;

    Rigidbody rigidbody = default;

    public override void Init(GameObject target, IStateMachine parent)
    {
        rigidbody = target.GetComponent<Rigidbody>();
    }

    public override void Do_Fix()
    {
        Move();
    }

    //キー入力を受けて移動
    void Move()
    {
        // 左スティックに入力があるか
        bool isLeftStickInputed = Input.GetAxis("Horizontal") != 0
                                  || Input.GetAxis("Vertical") != 0;
        // 左スティックに入力があるなら
        if (isLeftStickInputed) {
            float zPower = Input.GetAxis("Vertical") * runSpeed * Time.fixedDeltaTime;
            float xPower = Input.GetAxis("Horizontal") * runSpeed * Time.fixedDeltaTime;
            rigidbody.AddForce(xPower, 0, zPower);
            Debug.Log(rigidbody);
        }

        if (target.transform.position.y < 0) {
            parent.ChangeState(typeof(PlayerIdleState));
        }
    }
}