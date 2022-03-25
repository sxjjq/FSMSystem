using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ns
{
	///<summmary>
	///状态编号
	///<summary>
	public enum FSMStateID 
	{
        None,

        Default,

        Idle,

        Dead,

        Attack,
        //追逐
        Pursuit,
        //巡逻
        Patrol
		
	}
}

