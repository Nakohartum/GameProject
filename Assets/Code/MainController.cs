using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using WorldData;

namespace MainGamePart
{
    public class MainController : MonoBehaviour
    {
        [SerializeField] private Data _data;
        private Controllers _controllers;

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
    }
}
