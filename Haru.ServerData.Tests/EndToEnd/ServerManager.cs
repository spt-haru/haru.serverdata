using Microsoft.VisualStudio.TestTools.UnitTesting;
using Haru.Shared;
using Haru.ServerData.Http;
using Haru.ServerData.Servers;

namespace Haru.ServerData.Tests.EndToEnd
{
    [TestClass]
    public class ServerManagerTest
    {
        private static Client _client;
        private static ServerManager _serverManager;

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            // start the server
            _serverManager = new ServerManager();
            _serverManager.Start();

            // setup client
            _client = new Client(SharedConsts.HttpAddress, SharedConsts.AccountId, SharedConsts.GameVersion);
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            if (_client != null)
            {
                _client.Dispose();
            }
        }

        [TestMethod]
        public void TestCustomization()
        {
            var result = _client.GetText("/client/customization");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCustomizationStorage()
        {
            var result = _client.GetText("/client/trading/customization/storage");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestFriendList()
        {
            var result = _client.GetText("/client/friend/list");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestFriendRequestListInput()
        {
            var result = _client.GetText("/client/friend/request/list/inbox");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestFriendRequestListOutput()
        {
            var result = _client.GetText("/client/friend/request/list/outbox");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestGameConfig()
        {
            var result = _client.GetText("/client/game/config");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestGameProfileList()
        {
            var result = _client.GetText("/client/game/profile/list");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestGameProfileSelect()
        {
            var result = _client.GetText("/client/game/profile/select");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestGameStart()
        {
            var result = _client.GetText("/client/game/start");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestGameVersionValidate()
        {
            var result = _client.GetText("/client/game/version/validate");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestGlobals()
        {
            var result = _client.GetText("/client/globals");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestHandbookBuildsMyList()
        {
            var result = _client.GetText("/client/handbook/builds/my/list");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestHandbookTemplates()
        {
            var result = _client.GetText("/client/handbook/templates");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestHideoutAreas()
        {
            var result = _client.GetText("/client/hideout/areas");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestHideoutProductionRecipes()
        {
            var result = _client.GetText("/client/hideout/production/recipes");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestHideoutScavcaseRecipes()
        {
            var result = _client.GetText("/client/hideout/production/scavcase/recipes");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestHideoutQteList()
        {
            var result = _client.GetText("/client/hideout/qte/list");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestHideoutSettings()
        {
            var result = _client.GetText("/client/hideout/settings");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestItems()
        {
            var result = _client.GetText("/client/items");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestLanguages()
        {
            var result = _client.GetText("/client/languages");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestLocaleEn()
        {
            var result = _client.GetText("/client/locale/en");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestLocations()
        {
            var result = _client.GetText("/client/locations");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMailDialogList()
        {
            var result = _client.GetText("/client/mail/dialog/list");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMatchGroupCurrent()
        {
            var result = _client.GetText("/client/match/group/current");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestMenuLocaleEn()
        {
            var result = _client.GetText("/client/menu/locale/en");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestNotifierChannelCreate()
        {
            var result = _client.GetText("/client/notifier/channel/create");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestProfileStatus()
        {
            var result = _client.GetText("/client/profile/status");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestQuestList()
        {
            var result = _client.GetText("/client/quest/list");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestRepeatableQuestActivityPeriods()
        {
            var result = _client.GetText("/client/repeatalbeQuests/activityPeriods");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestServerList()
        {
            var result = _client.GetText("/client/server/list");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestSettings()
        {
            var result = _client.GetText("/client/settings");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestTraderSettings()
        {
            var result = _client.GetText("/client/trading/api/traderSettings");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestWeather()
        {
            var result = _client.GetText("/client/weather");

            if (string.IsNullOrEmpty(result))
            {
                Assert.Fail();
            }
        }
    }
}