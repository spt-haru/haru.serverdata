using Haru.ServerData.Http;
using Haru.ServerData.Tables;

namespace Haru.ServerData.Services
{
    public class Globals : Behaviour
    {
        public override void Run(Context context)
        {
            var table = Database.Instance.Globals;

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