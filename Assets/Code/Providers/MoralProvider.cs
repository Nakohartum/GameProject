using Interfaces;
using Moral;
using Player;
using System;
using UnityEngine;

namespace Providers
{
    public class MoralProvider : IMoralProvider, IExecutable
    {
        private MoralStatus _moralStatus;
        private float _damageToDeal;
        private MoralModel _moralModel;

        public event Action<float> onPlayerHPChange;

        public event Func<float> GetDamage;

        public MoralProvider()
        {
        }

        private void SetDamage()
        {
            _damageToDeal = GetDamage.Invoke();
        }

        

        public void GetPlayerHPChange()
        {
            SetDamage();
            onPlayerHPChange.Invoke(_damageToDeal);
        }

        

        public void Execute(float deltaTime)
        {
            
            GetPlayerHPChange();
            Debug.Log(_moralStatus);
        }
    }
}
