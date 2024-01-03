using Haru.ServerData.Http;
using Haru.ServerData.Tables;

namespace Haru.ServerData.Services
{
    public class HideoutAreas : Behaviour
    {
        public override void Run(Context context)
        {
            SendText(context, Database.Instance.HideoutAreas.Data);
        }
    }
}