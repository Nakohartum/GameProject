using Interfaces;
using System;


namespace Player
{
    [Serializable]
    public struct PlayerStruct : IPlayer
    {
        #region Fields

        public float HP;
        public float Speed;

        #endregion

        #region Properties

        float IPlayer.HP { get => HP; set => HP = value; }
        float IPlayer.Speed { get => Speed; set => Speed = value; }

        #endregion
    }
}
