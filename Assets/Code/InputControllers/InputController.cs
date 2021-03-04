using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputControllers
{
    class InputController : IExecutable
    {
        private readonly IInputProvider _horizontalInputController;
        private readonly IInputProvider _verticalInputProvider;

        public InputController((IInputProvider vertical, IInputProvider horizontal) input)
        {
            _horizontalInputController = input.horizontal;
            _verticalInputProvider = input.vertical;
        }

        public void Execute(float deltaTime)
        {
            _horizontalInputController.GetAxis();
            _verticalInputProvider.GetAxis();
        }
    }
}
