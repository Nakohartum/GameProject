using Interfaces;
using System;
using UnityEngine;

namespace Providers
{
    public class QuestAndTextProvider : IQuestAndTextProvider, IExecutable
    {
        public event Func<GameObject> OnGameObjectGet;
        public event Func<bool> OnBooleanValueGet;
        private bool isInTrigger;
        private GameObject textObject;

        public QuestAndTextProvider()
        {

        }
        
        private void GetGameObject()
        {
            textObject = OnGameObjectGet?.Invoke();
        }

        private void GetBooleanValue()
        {
            isInTrigger = OnBooleanValueGet.Invoke();
        }

        public void Execute(float deltaTime)
        {
            GetGameObject();
            GetBooleanValue();
            if (isInTrigger)
            {
                textObject.SetActive(true);
            }
            else
            {
                textObject.SetActive(false);
            }
        }
    }
}
