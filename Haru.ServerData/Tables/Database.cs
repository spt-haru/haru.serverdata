namespace Haru.ServerData.Tables
{
    public class Database
    {
        public readonly JsonTable GameStart;
        public readonly JsonTable MenuLocaleEn;
        public readonly JsonTable GameVersionValidate;
        public readonly JsonTable Languages;
        public readonly JsonTable GameConfig;
        public readonly JsonTable Items;
        public readonly JsonTable Customization;
        public readonly JsonTable Globals;
        public readonly JsonTable TraderSettings;
        public readonly JsonTable Settings;
        public readonly JsonTable GameProfileList;
        public readonly JsonTable GameProfileSelect;
        public readonly JsonTable ProfileStatus;
        public readonly JsonTable Weather;
        public readonly JsonTable LocaleEn;
        public readonly JsonTable Locations;
        public readonly JsonTable HandbookTemplates;
        public readonly JsonTable HideoutAreas;
        public readonly JsonTable HideoutQteList;
        public readonly JsonTable HideoutSettings;
        public readonly JsonTable HideoutProductionRecipes;
        public readonly JsonTable HideoutScavcaseRecipes;
        public readonly JsonTable HandbookBuildsMyList;
        public readonly JsonTable NotifierChannelCreate;
        public readonly JsonTable FriendList;
        public readonly JsonTable MailDialogList;
        public readonly JsonTable FriendRequestListInbox;
        public readonly JsonTable FriendRequestListOutbox;
        public readonly JsonTable CustomizationStorage;
        public readonly JsonTable ServerList;
        public readonly JsonTable MatchGroupCurrent;
        public readonly JsonTable QuestList;
        public readonly JsonTable RepeatableQuests;

        private static Database _instance;
        public static Database Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Database();
                }

                return _instance;
            }
        }

        public Database()
        {
            GameStart                   = new JsonTable();
            MenuLocaleEn                = new JsonTable();
            GameVersionValidate         = new JsonTable();
            Languages                   = new JsonTable();
            GameConfig                  = new JsonTable();
            Items                       = new JsonTable();
            Customization               = new JsonTable();
            Globals                     = new JsonTable();
            TraderSettings              = new JsonTable();
            Settings                    = new JsonTable();
            GameProfileList             = new JsonTable();
            GameProfileSelect           = new JsonTable();
            ProfileStatus               = new JsonTable();
            Weather                     = new JsonTable();
            LocaleEn                    = new JsonTable();
            Locations                   = new JsonTable();
            HandbookTemplates           = new JsonTable();
            HideoutAreas                = new JsonTable();
            HideoutQteList              = new JsonTable();
            HideoutSettings             = new JsonTable();
            HideoutProductionRecipes    = new JsonTable();
            HideoutScavcaseRecipes      = new JsonTable();
            HandbookBuildsMyList        = new JsonTable();
            NotifierChannelCreate       = new JsonTable();
            FriendList                  = new JsonTable();
            MailDialogList              = new JsonTable();
            FriendRequestListInbox      = new JsonTable();
            FriendRequestListOutbox     = new JsonTable();
            CustomizationStorage        = new JsonTable();
            ServerList                  = new JsonTable();
            MatchGroupCurrent           = new JsonTable();
            QuestList                   = new JsonTable();
            RepeatableQuests            = new JsonTable();
        }

        public void LoadAll()
        {
            GameStart.Load("database.resp.client.game.start.json");
            MenuLocaleEn.Load("database.resp.client.menu.locale-en.json");
            GameVersionValidate.Load("database.resp.client.game.version.validate.json");
            Languages.Load("database.resp.client.languages.json");
            GameConfig.Load("database.resp.client.game.config.json");
            Items.Load("database.resp.client.items.json");
            Customization.Load("database.resp.client.customization.json");
            Globals.Load("database.resp.client.globals.json");
            TraderSettings.Load("database.resp.client.trading.api.traderSettings.json");
            Settings.Load("database.resp.client.settings.json");
            GameProfileList.Load("database.resp.client.game.profile.list.json");
            GameProfileSelect.Load("database.resp.client.game.profile.select.json");
            ProfileStatus.Load("database.resp.client.profile.status.json");
            Weather.Load("database.resp.client.weather.json");
            LocaleEn.Load("database.resp.client.locale-en.json");
            Locations.Load("database.resp.client.locations.json");
            HandbookTemplates.Load("database.resp.client.handbook.templates.json");
            HideoutAreas.Load("database.resp.client.hideout.areas.json");
            HideoutQteList.Load("database.resp.client.hideout.qte.list.json");
            HideoutSettings.Load("database.resp.client.hideout.settings.json");
            HideoutProductionRecipes.Load("database.resp.client.hideout.production.recipes.json");
            HideoutScavcaseRecipes.Load("database.resp.client.hideout.production.scavcase.recipes.json");
            HandbookBuildsMyList.Load("database.resp.client.handbook.builds.my.list.json");
            NotifierChannelCreate.Load("database.resp.client.notifier.channel.create.json");
            FriendList.Load("database.resp.client.friend.list.json");
            MailDialogList.Load("database.resp.client.mail.dialog.list.json");
            FriendRequestListInbox.Load("database.resp.client.friend.request.list.inbox.json");
            FriendRequestListOutbox.Load("database.resp.client.friend.request.list.outbox.json");
            CustomizationStorage.Load("database.resp.client.trading.customization.storage.json");
            ServerList.Load("database.resp.client.server.list.json");
            MatchGroupCurrent.Load("database.resp.client.match.group.current.json");
            QuestList.Load("database.resp.client.quest.list.json");
            RepeatableQuests.Load("database.resp.client.repeatalbeQuests.activityPeriods.json");
        }
    }
}