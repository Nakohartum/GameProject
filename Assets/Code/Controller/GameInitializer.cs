using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    class GameInitializer
    {
        public GameInitializer(Data data, Controllers controllers)
        {
            var inputInitializer = new InputControllerInitializer();
            var playerFactory = new PlayerFactory(data.PlayerData);
            var playerInitializer = new PlayerInitializer(playerFactory, inputInitializer.GetInput());
            controllers.Add(inputInitializer);
            controllers.Add(playerFactory);
            controllers.Add(playerInitializer);
            controllers.Add(new InputController(inputInitializer.GetInput()));
            controllers.Add(playerInitializer.GetController());
        }
    }
}
