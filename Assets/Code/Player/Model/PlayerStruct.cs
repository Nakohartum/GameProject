using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Player
{
    [Serializable]
    public struct PlayerStruct : IPlayer
    {
        public float HP;
        public float Speed;

        float IPlayer.HP { get => HP; set => HP = value; }
        float IPlayer.Speed { get => Speed; set => Speed = value; }
    }
}
