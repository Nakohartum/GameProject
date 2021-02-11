namespace Player
{
    public interface IPlayerFactory : IController
    {
        IController Create((IInputProvider vertical, IInputProvider horizontal, IInputProvider jump) input);
    }
}