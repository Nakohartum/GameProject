using Player;
using InputControllers;
using WorldData;
using CameraSpace;
using Moral;
using Providers;


namespace MainGamePart
{
    class GameInitializer
    {
        #region Constructor

        public GameInitializer(Controllers controllers, Data data)
        {
            var moralProvider = new MoralProvider();
            var playerFactory = new PlayerFactory(data.PlayerData, moralProvider);
            var inputInitializer = new InputControllerInitializer();
            var playerInitializer = new PlayerInitializer(playerFactory, inputInitializer.GetInput(), moralProvider);
            var inputController = new InputController(inputInitializer.GetInput());
            var playerController = playerInitializer.GetController();
            var cameraFactory = new CameraFactory(data.CameraData, playerInitializer.GetPlayerView());
            var cameraInitializer = new CameraInitializer(cameraFactory);
            var cameraController = cameraInitializer.GetController();
            var moralFactory = new MoralFactory(data.MoralData, moralProvider);
            var moralInitializer = new MoralInitializer(moralFactory, playerInitializer.GetPlayerView(), moralProvider);
            var moralController = moralInitializer.GetController();
            controllers.AddController(moralProvider);
            controllers.AddController(moralFactory);
            controllers.AddController(moralInitializer);
            controllers.AddController(moralController);
            controllers.AddController(inputInitializer);
            controllers.AddController(inputController);
            controllers.AddController(cameraController);
            controllers.AddController(playerFactory);
            controllers.AddController(playerController);
            controllers.AddController(playerInitializer);
        }

        #endregion
    }
}
