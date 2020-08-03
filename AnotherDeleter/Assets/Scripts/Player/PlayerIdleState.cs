using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class IdleStateMachine : StateMachine
{

}

[System.Serializable]
public class PlayerIdleState : State
{
    IdleStateMachine stateMachine;

    public override void Init(GameObject target, IStateMachine parent)
    {

    }

    public override void Do()
    {
    }
}
