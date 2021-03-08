using Interfaces;
using UnityEngine;
using Extensions;


namespace Player
{
    class PlayerController : IExecutable, ICleanable, IInitializable
    {
        #region Fields

        private PlayerModel playerModel;
        private PlayerView playerView;
        private float _horizontalValue;
        private float _verticalValue;
        private IInputProvider _horizontalInputProider;
        private IInputProvider _verticalInputProvider;
        private Rigidbody _rigidbody;
        private IMoralProvider moralProvider;

        #endregion

        #region Constructor

        public PlayerController(PlayerModel playerModel, PlayerView playerView, (IInputProvider horizontal, IInputProvider vertical) input, IMoralProvider moralProvider)
        {
            this.playerModel = playerModel;
            this.playerView = playerView;
            this.moralProvider = moralProvider;
            this.moralProvider.onPlayerHPChange += ChangePlayerHp;
            _horizontalInputProider = input.horizontal;
            _verticalInputProvider = input.vertical;
            _horizontalInputProider.OnAxisChange += OnHorizontalAxisChange;
            _verticalInputProvider.OnAxisChange += OnVerticalAxisChange;
            _rigidbody = this.playerView.gameObject.GetOrAddComponent<Rigidbody>();
        }

        #endregion

        #region Methods

        private void ChangePlayerHp(float damage)
        {
            playerModel.PlayerStruct.HP -= damage;
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
            Vector3 desiredVector = Vector3.RotateTowards(playerView.transform.forward, _rigidbody.velocity, 5.0f * deltaTime, 0f);

            _rigidbody.velocity = new Vector3(_horizontalValue, 0, _verticalValue) * playerModel.PlayerStruct.Speed;
            playerView.gameObject.transform.rotation = Quaternion.LookRotation(desiredVector);

        }

        private void CheckHealth()
        {
            if (playerModel.PlayerStruct.HP < 0)
            {
                Die();
            }
        }

        private void Die() 
        {
            playerView.gameObject.SetActive(false);
        }

        public void Initialize()
        {
            
        }

        #endregion
    }
}
