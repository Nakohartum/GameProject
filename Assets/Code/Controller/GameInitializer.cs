using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moral;
namespace Player
{
    class GameInitializer
    {
        public GameInitializer(Data data, Controllers controllers)
        {
            
            var MoralInitializer = new MoralInitializer(data.MoralData);
            
            var inputInitializer = new InputControllerInitializer();
            var playerFactory = new PlayerFactory(data.PlayerData);
            var playerInitializer = new PlayerInitializer(playerFactory, inputInitializer.GetInput(), MoralInitializer.GetMoralProvider());
            controllers.Add(inputInitializer);
            controllers.Add(MoralInitializer);
            controllers.Add(playerFactory);
            controllers.Add(playerInitializer);
            controllers.Add(new InputController(inputInitializer.GetInput()));
            controllers.Add(playerInitializer.GetController());
        }
    }
}
