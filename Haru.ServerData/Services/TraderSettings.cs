using Haru.ServerData.Http;
using Haru.ServerData.Tables;

namespace Haru.ServerData.Services
{
    public class TraderSettings : Behaviour
    {
        public override void Run(Context context)
        {
            var table = Database.Instance.TraderSettings;

            if (context.GetCrc() == table.Hash)
            {
                SendCached(context);
            }
            else
            {
                SendText(context, table.Data);
            }
        }
    }
}