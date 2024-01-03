using Haru.ServerData.Http;
using Haru.ServerData.Tables;

namespace Haru.ServerData.Services
{
    public class ProfileStatus : Behaviour
    {
        public override void Run(Context context)
        {
            SendText(context, Database.Instance.ProfileStatus.Data);
        }
    }
}