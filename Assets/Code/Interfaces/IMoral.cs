using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moral;


namespace Interfaces
{
    public interface IMoral
    {
        float Damage { get; }
        float MoralAmount { get; set; }
        MoralStatus MoralStatus { get; set; }
        
    }
}
