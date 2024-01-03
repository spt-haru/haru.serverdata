using Haru.Shared;
using Haru.ServerData.Http;
using Haru.ServerData.Tables;

namespace Haru.ServerData.Services
{
    public class GameProfileList : Behaviour
    {
        public override void Run(Context context)
        {
            var response = Database.Instance.GameProfileList.Data
                .Replace("409154", SharedConsts.AccountId);

            SendText(context, response);
        }
    }
}