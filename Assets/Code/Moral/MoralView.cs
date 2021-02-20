using UnityEngine;

namespace Moral
{
    public class MoralView : MonoBehaviour
    {
        private MoralProvider _moralProvider;

        public void GetModalProvider(MoralProvider moralProvider)
        {
            _moralProvider = moralProvider;
        }
    }
}