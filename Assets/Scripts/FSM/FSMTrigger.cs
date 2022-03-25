using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ns
{
	///<summmary>
	///条件类
	///<summary>
	public abstract class FSMTrigger 
	{
    
		//编号
        public FSMTriggerID TriggerID { get; set; }

        public FSMTrigger() {
            Init();
        }
        //用于获取条件编号
        public abstract void Init();
        //逻辑处理
        public abstract bool HandTrigger(); 
	}
}

