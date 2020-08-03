using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ステートの基底クラス
/// </summary>
public abstract class State
{
    protected IStateMachine parent;
    protected GameObject target;

    virtual public void Init(GameObject target, IStateMachine parent)
    {
        this.parent = parent;
        this.target = target;
    }

    // 開始処理
    virtual public void Entry()
    {

    }

    // 毎フレーム呼ばれる処理
    virtual public void Do()
    {

    }

    // 物理挙動用処理
    virtual public void Do_Fix()
    {

    }

    // 終了処理
    virtual public void Exit()
    {

    }
}