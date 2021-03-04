using System;
using Managers;
using Interfaces;
using UnityEngine;

namespace InputControllers
{
    class VerticalInputController : IInputProvider
    {
        public event Action<float> OnAxisChange;

        public void GetAxis()
        {
            OnAxisChange.Invoke(Input.GetAxis(AxisManager.VERTICAL));
        }
    }
}
