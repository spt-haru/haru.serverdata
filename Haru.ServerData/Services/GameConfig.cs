using Haru.Shared;
using Haru.ServerData.Http;
using Haru.ServerData.Tables;

namespace Haru.ServerData.Services
{
    public class GameConfig : Behaviour
    {
        public GameConfig()
        {
            var data = Database.Instance.GameConfig.Data
                .Replace("https://prod.escapefromtarkov.com", SharedConsts.HttpAddress)
                .Replace("https://prod-03.escapefromtarkov.com", SharedConsts.HttpAddress)
                .Replace("https://trading.escapefromtarkov.com", SharedConsts.HttpAddress)
                .Replace("https://ragfair.escapefromtarkov.com", SharedConsts.HttpAddress)
                .Replace("https://prod.escapefromtarkov.com", SharedConsts.HttpAddress)
                .Replace("wss://prod.escapefromtarkov.com", SharedConsts.WsAddress)
                .Replace("409154", SharedConsts.AccountId);

            Database.Instance.GameConfig.Set(data);
        }

        public override void Run(Context context)
        {
            var table = Database.Instance.GameConfig;

            if (context.GetCrc() == table.Hash)
            {
                SendCached(context);
                return;
            }

            var response = table.Data;
            SendText(context, response);
        }
    }
}