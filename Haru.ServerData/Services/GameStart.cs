using Haru.ServerData.Http;
using Haru.ServerData.Tables;

namespace Haru.ServerData.Services
{
    public class GameStart : Behaviour
    {
        public override void Run(Context context)
        {
            SendText(context, Database.Instance.GameStart.Data);
        }
    }
}