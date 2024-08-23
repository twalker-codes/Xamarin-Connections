using SocialTemplate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class NotifyDataStore : BaseDataStore<Notify>, INotifyDataStore
    {
        protected override IList<Notify> items { get; }

        public NotifyDataStore()
        {
            items = new List<Notify>()
            {
                Notify.OnlyText(
                  id: "001",
                  personId: "001",
                  text: "Aliquam ac nulla pulvinar, tincidunt neque vitae, maximus odio.",
                  dateUtc: new DateTime(2022, 3, 1)
                ),
                Notify.WithIcon(
                  id: "002",
                  personId: "005",
                  text: "Proin congue ex ac purus eleifend, eget tincidunt urna efficitur.",
                  dateUtc: new DateTime(2022, 3, 14),
                  notifyIcon: NotifyIcon.Favorite
                ),
                Notify.Question(
                  id: "003",
                  personId: "012",
                  text: "In pharetra turpis vitae magna ullamcorper suscipit et nec purus.",
                  dateUtc: new DateTime(2022, 3, 20)
                ),
                Notify.WithIcon(
                  id: "003",
                  personId: "016",
                  text: "Maecenas orci nisi, hendrerit et feugiat non, egestas ac dolor.",
                  dateUtc: new DateTime(2022, 3, 25),
                  notifyIcon: NotifyIcon.Message
                ),
                Notify.OnlyText(
                  id: "004",
                  personId: "007",
                  text: "Aenean in ullamcorper velit.",
                  dateUtc: new DateTime(2022, 4, 19)
                ),
                Notify.Question(
                  id: "005",
                  personId: "015",
                  text: "Donec semper porta massa eu dictum.",
                  dateUtc: new DateTime(2022, 4, 26)
                ),
                Notify.WithIcon(
                  id: "005",
                  personId: "002",
                  text:
                      "Sed non arcu lectus. Sed eleifend volutpat nulla, at vulputate nunc.",
                  dateUtc: new DateTime(2022, 4, 30),
                  notifyIcon: NotifyIcon.Cake
                ),
            };
        }
    }
}
