using System.Collections;
using UnityEngine;
using WorldData;


namespace MainGamePart
{
    public class MainController : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Data _data;
        private Controllers _controllers;

        #endregion

        #region UnityMethods

        private void Start()
        {
            
            _controllers = new Controllers();
            new GameInitializer(_controllers, _data);
        }

        private void Update()
        {
            
            var deltaTime = Time.deltaTime;
            _controllers.Execute(deltaTime);
        }

        public IEnumerator Work(float time)
        {

            while (time > 0)
            {
                yield return new WaitForSeconds(1.0f);
                Debug.LogError(time);
                time -= 1;
            }
        }

        #endregion
    }
}
