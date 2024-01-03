using Haru.Shared;
using Haru.ServerData.Http;
using Haru.ServerData.Tables;

namespace Haru.ServerData.Services
{
    public class NotifierChannelCreate : Behaviour
    {
        public override void Run(Context context)
        {
            var response = Database.Instance.NotifierChannelCreate.Data
                .Replace("wsn-01.escapefromtarkov.com", SharedConsts.Address);

            SendText(context, response);
        }
    }
}