using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hunger;
using Moral;

namespace Player
{
    public class PlayerModel
    {
        public PlayerStruct PlayerStruct;
        public MoralStruct MoralStruct;
        
        public PlayerModel(PlayerStruct playerStruct, MoralStruct moralStruct)
        {
            PlayerStruct = playerStruct;
            MoralStruct = moralStruct;
        }
    }
}
