using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerIdleState : State
{
  
    public PlayerIdleState(GameObject playerObj,System.Action<State> changeState)
            :base(playerObj,changeState) {

    }

    public override void Do() {        
    }
   
    public override void Do_Fix() {      
    }  
    public override void Entry() {        
    }  
    public override void Exit() {        
    }
}
