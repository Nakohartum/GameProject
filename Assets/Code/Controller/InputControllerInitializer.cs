using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class InputControllerInitializer : IInitializable
    {
        private IInputProvider _PCVerticaInput;
        private IInputProvider _PCHorizontalInput;
        private IInputProvider _jump;

        public InputControllerInitializer()
        {
            _PCHorizontalInput = new HorizontalInputProvider();
            _PCVerticaInput = new VerticalInputProvider();
            _jump = new JumpController();
        }

        public (IInputProvider vertical, IInputProvider horizontal, IInputProvider jump) GetInput()
        {
            (IInputProvider vertical, IInputProvider horizontal, IInputProvider jump) result = (_PCVerticaInput, _PCHorizontalInput, _jump);
            return result;
        }

        public void Initialize()
        {
            
        }
    }
}
