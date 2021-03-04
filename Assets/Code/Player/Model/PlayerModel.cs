using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class PlayerModel
    {
        public PlayerStruct PlayerStruct;
        public PlayerModel(PlayerStruct playerStruct)
        {
            PlayerStruct = playerStruct;
        }
    }
}
