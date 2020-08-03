using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ステート制御用の基底クラス
/// </summary>
public abstract class StateMachine : MonoBehaviour{

    // 現在のステート   
    public  State currentState = null;    
    
    // ステートを切り替える処理
    public void ChangeState(State newState){
        // 現在のステートの終了時処理を行う
        if (currentState != null)
        {
            currentState.Exit();
        }
        // ステートを新しいステートに変更する
        currentState = newState;
        // 新しいステートの開始処理を行う
        currentState.Entry();
    }

    // 現在のステートのUpdate用処理を呼ぶ
    public void Do() {
        currentState.Do();       
    }
    // 現在のステートのFixUpdate用の処理を呼ぶ
    public void Do_Fix() {
        currentState.Do_Fix();
    }   
}
