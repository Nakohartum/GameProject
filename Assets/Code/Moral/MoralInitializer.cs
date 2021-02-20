using Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extesnsions;

namespace Moral
{
    class MoralInitializer : IInitializable
    {
        private MoralData _moralData;
        private MoralProvider _moralProvider;
        private MoralController _moralController;

        public MoralInitializer(MoralData moralData)
        {
            _moralData = moralData;
            _moralProvider = new MoralProvider();
            
        }

        public MoralProvider GetMoralProvider()
        {
            return _moralProvider;
        }

        public void Initialize()
        {
            
        }
    }
}
