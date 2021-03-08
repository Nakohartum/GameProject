using Moral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IMoralProvider
    {
        
        event Action<float> onPlayerHPChange;
        
        event Func<float> GetDamage;

        void GetPlayerHPChange();
        
    }
}
