using Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moral
{
    public class MoralController 
    {
        private MoralView moralView;
        private MoralModel moralModel;

        public MoralController(MoralView moralView, MoralModel moralModel)
        {
            this.moralView = moralView;
            this.moralModel = moralModel;
           
        }

        public void MinusMoral(float change)
        {
            moralModel.MoralStruct.MoralAmount -= change;
            MoralStatusChange();
        }

        public void PlusMoral(float change)
        {
            moralModel.MoralStruct.MoralAmount += change;
            MoralStatusChange();
        }

        public void MoralStatusChange()
        {
            if (moralModel.MoralStruct.MoralAmount > moralModel.MoralStruct.MoralAmount / 2)
            {
                moralModel.MoralStruct.MoralStatus = MoralStatus.High;
            }
            else if (moralModel.MoralStruct.MoralAmount < moralModel.MoralStruct.MoralAmount / 2)
            {
                moralModel.MoralStruct.MoralStatus = MoralStatus.Medium;
            }
            else if (moralModel.MoralStruct.MoralAmount < moralModel.MoralStruct.MoralAmount / 3)
            {
                moralModel.MoralStruct.MoralStatus = MoralStatus.Low;
            }
        }

        
    }
}
