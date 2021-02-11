namespace Player
{
    public interface IExecutable : IController
    {
        void Execute(float deltaTime);
    }
}