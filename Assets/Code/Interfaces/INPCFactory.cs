using NPC;
using Player;


namespace Interfaces
{
    public interface INPCFactory
    {
        IController Create(PlayerView playerView);
        NPCView GetNPCView();
    }
}
