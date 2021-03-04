using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputControllers
{
    class InputControllerInitializer : IInitializable
    {
        private IInputProvider _verticalInput;
        private IInputProvider _horizontalInput;

        public InputControllerInitializer()
        {
            _verticalInput = new VerticalInputController();
            _horizontalInput = new HorizontalInputController();
        }

        public (IInputProvider horizontal, IInputProvider vertical) GetInput()
        {
            (IInputProvider horizontal, IInputProvider vertical) result = (_horizontalInput, _verticalInput);
            return result;
        }

        public void Initialize()
        {
            
        }
    }
}
