using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace AnotherDeleter {

    /// <summary>
    /// ステートの基底クラス
    /// </summary>
    public abstract class State : IState{
        // ステートの対象であるオブジェクト
        GameObject target = default;
        // ステートを管理するステートマシン
        IStateMachine parent = default;

        /// <summary>
        /// newされた際に1度だけ呼んでもらう処理
        /// </summary>
        /// <param name="target">ステートの対象オブジェクト</param>
        /// <param name="parent">ステートを管理するステートマシン</param>
        virtual public void Init(GameObject target, IStateMachine parent) {
            this.target = target;
            this.parent = parent;
        }

        /// <summary>
        /// 現在のステートの開始処理
        /// </summary>
        virtual public void Entry() {

        }

        /// <summary>
        /// 現在のステートの毎フレーム呼ばれる処理
        /// </summary>
        virtual public void Do() {

        }

        /// <summary>
        /// 現在のステートの固定フレームで呼ばれる処理
        /// </summary>
        virtual public void FixedDo() {

        }

        /// <summary>
        /// 現在のステートの終了処理
        /// </summary>
        virtual public void Exit() {

        }

    }
}

