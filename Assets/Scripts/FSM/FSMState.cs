using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ns
{
	///<summmary>
	///状态类
	///<summary>
	public abstract class FSMState
	{
        //映射表
        private Dictionary<FSMTriggerID, FSMStateID> map;
        public FSMStateID StateID { get; set; }
        //条件列表
        private List<FSMTrigger> triggers;

        /// <summary>
        /// 状态机中调用，检测条件
        /// </summary>
        /// <param name="fs"></param>
        public void JianChe(FSMStateMachine fs)
        {
            foreach (FSMTrigger item in triggers)
            {
                if (item.HandTrigger())//条件
                {
                    FSMStateID fSMStateID = map[item.TriggerID];//对应关系
                   fs.ChangeState(fSMStateID);//状态机的切换状态
                }
            }
        }

        public FSMState() {

            map = new Dictionary<FSMTriggerID, FSMStateID>();
            triggers = new List<FSMTrigger>();
            Init();
        }
        //初始化状态id
        public abstract void Init();

        //有状态机调用
        public void AddMap(FSMTriggerID triggerID,FSMStateID stateID)
        {
            map.Add(triggerID, stateID);
            CreateTrigger(triggerID);//创建条件类

        }

        private void CreateTrigger(FSMTriggerID triggerID)
        {
            Type t = Type.GetType("ns" + triggerID + "Trigger");
            FSMTrigger fSMTrigger = Activator.CreateInstance(t) as FSMTrigger;
            triggers.Add(fSMTrigger);
        }
        public virtual void EnterState() { }
        public virtual void StayState() { }
        public virtual void ExitState() { }

    }
}

