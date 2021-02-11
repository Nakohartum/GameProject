using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class InputController : IExecutable
    {
        private readonly IInputProvider _horizontalInputProvider;
        private readonly IInputProvider _verticalInputProvider;
        private readonly IInputProvider _jump;

        public InputController((IInputProvider vertical, IInputProvider horizontal, IInputProvider jump) input)
        {
            _horizontalInputProvider = input.horizontal;
            _verticalInputProvider = input.vertical;
            _jump = input.jump;
        }

        public void Execute(float deltaTime)
        {
            _verticalInputProvider.GetAxis();
            _horizontalInputProvider.GetAxis();
            _jump.GetAxis();
        }
    }
}
