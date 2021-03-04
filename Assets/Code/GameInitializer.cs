using Player;
using InputControllers;
using WorldData;
using CameraSpace;


namespace MainGamePart
{
    class GameInitializer
    {
        public GameInitializer(Controllers controllers, Data data)
        {
            var playerFactory = new PlayerFactory(data.PlayerData);
            var inputInitializer = new InputControllerInitializer();
            var playerInitializer = new PlayerInitializer(playerFactory, inputInitializer.GetInput());
            var inputController = new InputController(inputInitializer.GetInput());
            var playerController = playerInitializer.GetController();
            var cameraFactory = new CameraFactory(data.CameraData, playerInitializer.GetPlayerView());
            var cameraInitializer = new CameraInitializer(cameraFactory);
            var cameraController = cameraInitializer.GetController();
            controllers.AddController(inputInitializer);
            controllers.AddController(inputController);
            controllers.AddController(cameraController);
            controllers.AddController(playerFactory);
            controllers.AddController(playerController);
            controllers.AddController(playerInitializer);
        }
    }
}
