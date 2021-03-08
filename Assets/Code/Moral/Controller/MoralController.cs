using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Moral
{
    public class MoralController : IExecutable, ICleanable, IInitializable
    {
        private MoralModel moralModel;
        private MoralView moralView;
        private IMoralProvider moralProvider;
        public MoralController(MoralModel moralModel, MoralView moralView, IMoralProvider moralProvider)
        {
            this.moralModel = moralModel;
            this.moralView = moralView;
            this.moralProvider = moralProvider;
            this.moralProvider.GetDamage += GetDamage;
        }

        private float GetDamage()
        {
            float damage = 0;
            if (moralModel.MoralStruct.MoralStatus == MoralStatus.High)
            {
                damage = 0;
            }
            else if (moralModel.MoralStruct.MoralStatus == MoralStatus.Medium)
            {
                damage = 0;
            }
            else if (moralModel.MoralStruct.MoralStatus == MoralStatus.Low)
            {
                damage = moralModel.MoralStruct.Damage;
            }
            return damage;
        }

        private MoralStatus onMoralStatusChange()
        {
            return moralModel.MoralStruct.MoralStatus;
        }

        public void Clean()
        {
            
        }

        public void Execute(float deltaTime)
        {
            moralModel.MoralStruct.MoralAmount -= 20;
            MoralStatusCheck();
            GetDamage();
        }

        public void MoralStatusCheck()
        {
            
            if (moralModel.MoralStruct.MoralAmount > 20)
            {
                moralModel.MoralStruct.MoralStatus = MoralStatus.High;
                
            }
            else if (moralModel.MoralStruct.MoralAmount < 20 && moralModel.MoralStruct.MoralAmount > 10)
            {
                moralModel.MoralStruct.MoralStatus = MoralStatus.Medium;
            }
            else if (moralModel.MoralStruct.MoralAmount < 10)
            {
                moralModel.MoralStruct.MoralStatus = MoralStatus.Low;
                
            }
            
        }

        

        public void Initialize()
        {
            
        }
    }
}
