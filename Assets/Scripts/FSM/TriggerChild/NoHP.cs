using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ns
{
	///<summmary>
	///
	///<summary>
	public class NoHP : FSMTrigger
	{
        public override bool HandTrigger()
        {
            //条件:判断生命值是否小于等于0,并把布尔值返回
            return default;
        }

        public override void Init()
        {
            TriggerID = FSMTriggerID.NoHP;
        }

        
	}
}

