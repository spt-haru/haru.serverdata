using Haru.ServerData.Http;
using Haru.ServerData.Tables;

namespace Haru.ServerData.Services
{
    public class CustomizationStorage : Behaviour
    {
        public override void Run(Context context)
        {
            SendText(context, Database.Instance.CustomizationStorage.Data);
        }
    }
}