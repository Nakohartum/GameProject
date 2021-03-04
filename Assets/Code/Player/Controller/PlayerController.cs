using Interfaces;
using UnityEngine;
using Extensions;


namespace Player
{
    class PlayerController : IExecutable, ICleanable, IInitializable
    {
        private PlayerModel playerModel;
        private PlayerView playerView;
        private float _horizontalValue;
        private float _verticalValue;
        private IInputProvider _horizontalInputProider;
        private IInputProvider _verticalInputProvider;
        private Rigidbody _rigidbody;

        public PlayerController(PlayerModel playerModel, PlayerView playerView, (IInputProvider horizontal, IInputProvider vertical) input)
        {
            this.playerModel = playerModel;
            this.playerView = playerView;
            _horizontalInputProider = input.horizontal;
            _verticalInputProvider = input.vertical;
            _horizontalInputProider.OnAxisChange += OnHorizontalAxisChange;
            _verticalInputProvider.OnAxisChange += OnVerticalAxisChange;
            _rigidbody = this.playerView.gameObject.GetOrAddComponent<Rigidbody>();
        }

        private void OnVerticalAxisChange(float value)
        {
            _verticalValue = value;
        }

        private void OnHorizontalAxisChange(float value)
        {
            _horizontalValue = value;
        }

        public void Clean()
        {
            
        }

        public void Execute(float deltaTime)
        {
            _rigidbody.velocity = new Vector3(_horizontalValue, 0, _verticalValue) * playerModel.PlayerStruct.Speed;
            
        }

        public void Initialize()
        {
            
        }
    }
}
