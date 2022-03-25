using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ns
{
	///<summmary>
	///条件编号
	///<summary>
	public enum FSMTriggerID 
	{
    
		//没有生命
        NoHP,
        //发现目标
        SeeTarget,
        //到达目标
        ReachTarget,
        //目标被击杀
        KillTarget,
        //超出攻击范围
        WithOutAttackRange,
        //丢失目标
        LoseTarget,
        //巡逻
        Patorling

	}
}

