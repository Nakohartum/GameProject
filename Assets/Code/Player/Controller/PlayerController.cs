using Interfaces;
using UnityEngine;
using Extensions;


namespace Player
{
    class PlayerController : IExecutable, ICleanable, IInitializable
    {
        #region Fields

        private PlayerModel _playerModel;
        private PlayerView _playerView;
        private float _horizontalValue;
        private float _verticalValue;
        private IInputProvider _horizontalInputProider;
        private IInputProvider _verticalInputProvider;
        private Rigidbody _rigidbody;
        private IMoralProvider moralProvider;
        private Vector3 _moveDirection;

        #endregion

        #region Constructor

        public PlayerController(PlayerModel playerModel, PlayerView playerView, (IInputProvider horizontal, IInputProvider vertical) input, IMoralProvider moralProvider)
        {
            this._playerModel = playerModel;
            this._playerView = playerView;
            this.moralProvider = moralProvider;
            this.moralProvider.onPlayerHPChange += ChangePlayerHp;
            _horizontalInputProider = input.horizontal;
            _verticalInputProvider = input.vertical;
            _horizontalInputProider.OnAxisChange += OnHorizontalAxisChange;
            _verticalInputProvider.OnAxisChange += OnVerticalAxisChange;
            _rigidbody = this._playerView.gameObject.GetOrAddComponent<Rigidbody>();
            _rigidbody.freezeRotation = true;
            
        }

        #endregion

        #region Methods

        private void ChangePlayerHp(float damage)
        {
            _playerModel.PlayerStruct.HP -= damage;
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
            _horizontalInputProider.OnAxisChange -= OnHorizontalAxisChange;
            _verticalInputProvider.OnAxisChange -= OnVerticalAxisChange;
            this.moralProvider.onPlayerHPChange -= ChangePlayerHp;
        }

        public void Execute(float deltaTime)
        {
            Move(deltaTime);
            CheckHealth();
        }

        private void Move(float deltaTime)
        {
            _moveDirection = new Vector3(_horizontalValue, 0, _verticalValue).normalized * _playerModel.PlayerStruct.Speed;
            _rigidbody.velocity = new Vector3(_moveDirection.x, _rigidbody.velocity.y, _moveDirection.z);
            _playerView.transform.Rotate(Vector3.up, Extensions.Extensions.Angle360(_playerView.transform.forward, _moveDirection, _playerView.transform.right));
        }

        private float MoverCheck()
        {
            if (_moveDirection.x != 0 || _moveDirection.z != 0)
                return 1f;
            else
                return 0f;
        }

        private void CheckHealth()
        {
            if (_playerModel.PlayerStruct.HP < 0)
            {
                Die();
            }
        }

        private void Die() 
        {
            _playerView.gameObject.SetActive(false);
        }

        public void Initialize()
        {
            
        }

        #endregion
    }
}
