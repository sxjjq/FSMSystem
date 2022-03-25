using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ns
{
	///<summmary>
	///
	///<summary>
	public class IdleState : FSMState
	{
        public override void Init()
        {
            StateID = FSMStateID.Idle;
        }
        public override void EnterState()
        {
            base.EnterState();
            //播放动画
            //具体需求具体实现

        }
        public override void StayState()
        {
            base.StayState();
        }
        public override void ExitState()
        {
            base.ExitState();
        }
    }
}

