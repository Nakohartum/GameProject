using Player;
using InputControllers;
using WorldData;
using CameraSpace;
using Moral;
using Providers;
using Builder;
using Managers;
using SceneWorker;


namespace MainGamePart
{
    class GameInitializer
    {
        #region Constructor

        public GameInitializer(Controllers controllers, Data data)
        {
            var roomProvider = new RoomProvider();
            var cameraProvider = new CameraProvider();
            var moralProvider = new MoralProvider();
            SceneWorkerInitializer sceneWorkerInitializer = new SceneWorkerInitializer(roomProvider);
            RoomManager.GetRoomsPosition();
            var playerFactory = new PlayerFactory(data.PlayerData, moralProvider, roomProvider);
            var inputInitializer = new InputControllerInitializer();
            var playerInitializer = new PlayerInitializer(playerFactory, inputInitializer.GetInput(), moralProvider);
            var inputController = new InputController(inputInitializer.GetInput());
            var playerController = playerInitializer.GetController();
            var cameraFactory = new CameraFactory(data.CameraData, playerInitializer.GetPlayerView());
            var cameraInitializer = new CameraInitializer(cameraFactory, cameraProvider);
            var cameraController = cameraInitializer.GetController();
            var moralFactory = new MoralFactory(data.MoralData, moralProvider);
            var moralInitializer = new MoralInitializer(moralFactory, playerInitializer.GetPlayerView(), moralProvider);
            var moralController = moralInitializer.GetController();
            controllers.AddController(roomProvider);
            controllers.AddController(sceneWorkerInitializer);
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
