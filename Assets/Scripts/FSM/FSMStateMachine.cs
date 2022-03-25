using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ns
{
	///<summmary>
	///
	///<summary>
	public class FSMStateMachine : MonoBehaviour
	{
        private List<FSMState> states;//各种状态
       
        private FSMState currentState;//当前状态
        //
        [Tooltip("默认状态id,编辑器确定")]
        public FSMStateID defaultState;
		void Start()
		{
            ConfigState();
            InitCurrentState();//初始化当前状态
            
		}
        /// <summary>
        /// 配置状态
        /// </summary>
        private void ConfigState() {
            states = new List<FSMState>();
            //todo
        }

        private void InitCurrentState()
        {

           FSMState f= states.Find(s=>s.StateID==defaultState);
            currentState = f;
            currentState.EnterState();
           
        }

        void Update()
		{
            //检测条件
            currentState.JianChe(this);
            currentState.StayState();
		}
        /// <summary>
        /// 切换状态
        /// </summary>
        public void ChangeState(FSMStateID fSMStateID) {

            FSMState f = states.Find(s => s.StateID == fSMStateID);
            currentState.ExitState();
            currentState = f;
            currentState.EnterState();
        }
	}
}

