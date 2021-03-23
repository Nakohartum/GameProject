using Interfaces;
using UnityEngine;
using Extensions;
using Managers;
using Providers;


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
        private IMoralProvider _moralProvider;
        private Vector3 _moveDirection;
        private Animator _animator;
        private AudioSource _audioSource;

        #endregion

        #region Constructor

        public PlayerController(PlayerModel playerModel, PlayerView playerView, (IInputProvider horizontal, IInputProvider vertical) input, IMoralProvider moralProvider)
        {
            this._playerModel = playerModel;
            this._playerView = playerView;
            this._moralProvider = moralProvider;
            this._moralProvider.onPlayerHPChange += ChangePlayerHp;
            _horizontalInputProider = input.horizontal;
            _verticalInputProvider = input.vertical;
            _horizontalInputProider.OnAxisChange += OnHorizontalAxisChange;
            _verticalInputProvider.OnAxisChange += OnVerticalAxisChange;
            _rigidbody = this._playerView.gameObject.GetOrAddComponent<Rigidbody>();
            _rigidbody.freezeRotation = true;
            _playerView.OnRoomEnter += RoomEnter;
            _animator = _playerView.gameObject.GetComponent<Animator>();
            _audioSource = _playerView.GetComponent<AudioSource>();
        }


        private void RoomEnter(string nameRoom)
        {
            return;
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
            this._moralProvider.onPlayerHPChange -= ChangePlayerHp;
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
            if (_moveDirection.sqrMagnitude > 0)
            {
                _animator.SetBool("isWalking", true);
            }
            else
            {
                _animator.SetBool("isWalking", false);
            }
            if (_moveDirection.sqrMagnitude > 0)
            {
                Quaternion newRotation = Quaternion.LookRotation(_moveDirection);
                _playerView.transform.rotation = Quaternion.Slerp(_playerView.transform.rotation, newRotation, Time.deltaTime * _playerModel.PlayerStruct.TurningSpeed);
            }
            

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
