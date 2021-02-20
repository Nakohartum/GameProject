using Moral;
using UnityEngine;

namespace Player
{
    public class PlayerView : MonoBehaviour
    {
        private MoralProvider _moralProvider;

        private void Start()
        {
            
        }


        public void GetMoralProvider(MoralProvider moralProvider)
        {
            _moralProvider = moralProvider;
        }
    }
}