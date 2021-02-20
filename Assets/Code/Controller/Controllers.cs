using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class Controllers : IController, IExecutable, ICleanable, IInitializable, ILateExecutable
    {

        private List<IExecutable> _executables = new List<IExecutable>();
        private List<ICleanable> _cleanables = new List<ICleanable>();
        private List<IInitializable> _initializables = new List<IInitializable>();
        private List<ILateExecutable> _lateExecutables = new List<ILateExecutable>();

        public Controllers Add(IController controller)
        {
            if (controller is IExecutable executable)
            {
                _executables.Add(executable);
            }
            if (controller is ICleanable cleanable)
            {
                _cleanables.Add(cleanable);
            }
            if (controller is IInitializable initializable)
            {
                _initializables.Add(initializable);
            }
            if (controller is ILateExecutable lateExecutable)
            {
                _lateExecutables.Add(lateExecutable);
            }
            return this;
        }
        public void Clean()
        {
            for (int i = 0; i < _cleanables.Count; ++i)
            {
                _cleanables[i].Clean();
            }
        }

        public void Execute(float deltaTime)
        {
            for (int i = 0; i < _executables.Count; ++i)
            {
                _executables[i].Execute(deltaTime);
            }
        }

        public void Initialize()
        {
            for (int i = 0; i < _initializables.Count; ++i)
            {
                _initializables[i].Initialize();
            }
        }

        public void LateExecute()
        {
            for (int i = 0; i < _lateExecutables.Count; ++i)
            {
                _lateExecutables[i].LateExecute();
            }
        }
    }
}
