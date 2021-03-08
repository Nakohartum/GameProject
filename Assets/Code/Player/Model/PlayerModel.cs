using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class PlayerModel
    {
        public IPlayer PlayerStruct;
        public PlayerModel(IPlayer playerStruct)
        {
            PlayerStruct = playerStruct;
        }

        
    }
}
