using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Player
{
    class HorizontalInputProvider : IInputProvider
    {
        public event Action<float> onAxisChange;

        public void GetAxis()
        {
            onAxisChange.Invoke(Input.GetAxis(AxisManager.HORIZONTAL));
        }
    }
}
