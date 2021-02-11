using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public interface IInputProvider : IController
    {
        event Action<float> onAxisChange;
        void GetAxis();
    }
}
