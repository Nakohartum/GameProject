using UnityEngine;

namespace Player
{
    public class PlayerController : IExecutable, ICleanable
    {
        private PlayerModel _model;
        private PlayerView _view;
        private IInputProvider _horizontalInput;
        private IInputProvider _verticalInput;
        private IInputProvider _jumpInput;
        private float _horizontal;
        private float _vertical;
        private float _jump;
        private Rigidbody _rigidbody;

        public PlayerController(PlayerModel model, PlayerView view, (IInputProvider vertical, IInputProvider horizontal, IInputProvider jump) input)
        {
            this._model = model;
            this._view = view;
            _horizontalInput = input.horizontal;
            _verticalInput = input.vertical;
            _jumpInput = input.jump;
            _jumpInput.onAxisChange += OnJumpAxisChange;
            _horizontalInput.onAxisChange += OnHorizontalAxisChange;
            _verticalInput.onAxisChange += OnVerticalAxisChange;
            _rigidbody = _view.gameObject.GetComponent<Rigidbody>();
        }

        private void OnVerticalAxisChange(float value)
        {
            _vertical = value;
        }

        private void OnJumpAxisChange(float value)
        {
            _jump = value * 0.3f;
        }

        private void OnHorizontalAxisChange(float value)
        {
            _horizontal = value;
        }

        public void Clean()
        {
            _horizontalInput.onAxisChange -= OnHorizontalAxisChange;
            _jumpInput.onAxisChange -= OnJumpAxisChange;
            _verticalInput.onAxisChange -= OnVerticalAxisChange;
        }

        public void Execute(float deltaTime)
        {

            _rigidbody.AddForce(new Vector3(0, _jump, 0), ForceMode.Impulse);
            _rigidbody.velocity = new Vector3(_horizontal * _model.PlayerStruct.Speed, _rigidbody.velocity.y, _vertical * _model.PlayerStruct.Speed);
            Debug.Log(_model.MoralStruct.MoralAmount);
        }
    }
}