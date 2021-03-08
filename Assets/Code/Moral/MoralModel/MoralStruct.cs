using System;
using Interfaces;
using UnityEngine;


namespace Moral
{
    [Serializable]
    public struct MoralStruct : IMoral
    {
        public float MoralAmount;
        public MoralStatus MoralStatus;
        public float MoralDamage;

        float IMoral.Damage { get => MoralDamage;}
        float IMoral.MoralAmount { get => MoralAmount; set => MoralAmount = value; }
        MoralStatus IMoral.MoralStatus { get => MoralStatus; set => MoralStatus = value; }
    }
}
