using Haru.ServerData.Http;
using Haru.ServerData.Tables;

namespace Haru.ServerData.Services
{
    public class HideoutQteList : Behaviour
    {
        public override void Run(Context context)
        {
            SendText(context, Database.Instance.HideoutQteList.Data);
        }
    }
}