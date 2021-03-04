using Interfaces;
using System;
using Managers;
using UnityEngine;

namespace InputControllers
{
    public class HorizontalInputController : IInputProvider
    {
        public event Action<float> OnAxisChange;

        public void GetAxis()
        {
            OnAxisChange.Invoke(Input.GetAxis(AxisManager.HORIZONTAL));
        }
    }
}
