using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class MainController : MonoBehaviour
    {
        [SerializeField]private Data GameData;
        private Controllers _controllers;
        // Start is called before the first frame update
        void Start()
        {
            _controllers = new Controllers();
            new GameInitializer(GameData, _controllers);
        }

        // Update is called once per frame
        void Update()
        {
            float deltaTime = Time.deltaTime;
            _controllers.Execute(deltaTime);
        }
    }
}
