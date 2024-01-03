using Haru.Shared;
using Haru.ServerData.Http;
using Haru.ServerData.Services;

namespace Haru.ServerData.Servers
{
    public class MainServer
    {
        public Server Server { get; private set; }

        public void Load(string certpath, string certpass)
        {
            // server is lazy loaded, certificate must exist before loading
            Server = new Server("main", SharedConsts.HttpAddress, certpath, certpass);

            // add services to server
            Server.AddHttpService<Customization>("/client/customization");
            Server.AddHttpService<CustomizationStorage>("/client/trading/customization/storage");
            Server.AddHttpService<FriendList>("/client/friend/list");
            Server.AddHttpService<FriendRequestListInbox>("/client/friend/request/list/inbox");
            Server.AddHttpService<FriendRequestListOutbox>("/client/friend/request/list/outbox");
            Server.AddHttpService<GameConfig>("/client/game/config");
            Server.AddHttpService<GameProfileList>("/client/game/profile/list");
            Server.AddHttpService<GameProfileSelect>("/client/game/profile/select");
            Server.AddHttpService<GameStart>("/client/game/start");
            Server.AddHttpService<GameVersionvalidate>("/client/game/version/validate");
            Server.AddHttpService<Globals>("/client/globals");
            Server.AddHttpService<HandbookBuildsMyList>("/client/handbook/builds/my/list");
            Server.AddHttpService<HandbookTemplates>("/client/handbook/templates");
            Server.AddHttpService<HideoutAreas>("/client/hideout/areas");
            Server.AddHttpService<HideoutProductionRecipes>("/client/hideout/production/recipes");
            Server.AddHttpService<HideoutProductionScavcaseRecipes>("/client/hideout/production/scavcase/recipes");
            Server.AddHttpService<HideoutQteList>("/client/hideout/qte/list");
            Server.AddHttpService<HideoutSettings>("/client/hideout/settings");
            Server.AddHttpService<Items>("/client/items");
            Server.AddHttpService<Languages>("/client/languages");
            Server.AddHttpService<LocaleEn>("/client/locale/en");
            Server.AddHttpService<Locations>("/client/locations");
            Server.AddHttpService<MailDialogList>("/client/mail/dialog/list");
            Server.AddHttpService<MatchGroupCurrent>("/client/match/group/current");
            Server.AddHttpService<MenuLocaleEn>("/client/menu/locale/en");
            Server.AddHttpService<NotifierChannelCreate>("/client/notifier/channel/create");
            Server.AddHttpService<ProfileStatus>("/client/profile/status");
            Server.AddHttpService<QuestList>("/client/quest/list");
            Server.AddHttpService<RepeatableQuestActivityPeriods>("/client/repeatalbeQuests/activityPeriods");
            Server.AddHttpService<ServerList>("/client/server/list");
            Server.AddHttpService<Settings>("/client/settings");
            Server.AddHttpService<TraderSettings>("/client/trading/api/traderSettings");
            Server.AddHttpService<Weather>("/client/weather");
        }

        public void Start()
        {
            Server.Start();
        }
    }
}