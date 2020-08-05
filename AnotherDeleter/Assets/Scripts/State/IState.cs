using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AnotherDeleter {   
    public interface IState {

        /// <summary>
        /// newされた際に1度だけ呼んでもらう処理
        /// </summary>
        /// <param name="target">ステートの対象オブジェクト</param>
        /// <param name="parent">ステートを管理するステートマシン</param>
        void Init(GameObject target, IStateMachine parent);

        /// <summary>
        /// 現在のステートの開始処理
        /// </summary>
        void Entry();

        /// <summary>
        /// 現在のステートの毎フレーム呼ばれる処理
        /// </summary>        
        void Do();

        /// <summary>
        /// 現在のステートの固定フレームで呼ばれる処理
        /// </summary>
        void FixedDo();

        /// <summary>
        /// 現在のステートの終了処理
        /// </summary>
        void Exit();
    }
}

 
