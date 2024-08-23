using SocialTemplate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class MessageDataStore : BaseDataStore<Message>, IMessageDataStore
    {
        protected override IList<Message> items { get; }

        public MessageDataStore()
        {
            items = new List<Message>()
            {
                new Message {
                  Id = "001",
                  SenderId = "008",
                  ReceiverId = "001",
                  Text = "Sed vel vehicula nibh, eget iaculis sapien.",
                  DateUtc = new DateTime(2022, 1, 8, 09, 35, 0),
                },
                new Message {
                  Id = "002",
                  SenderId = "001",
                  ReceiverId = "008",
                  Text = "Integer mollis nunc sed porta sollicitudin.",
                  DateUtc = new DateTime(2022, 1, 8, 09, 39, 0),
                },
                new Message {
                  Id = "003",
                  SenderId = "008",
                  ReceiverId = "001",
                  Text =
                      "Integer tortor quam, fringilla eget faucibus ac, semper et lorem. Nunc sit amet diam venenatis, sagittis felis non, facilisis enim.",
                  DateUtc = new DateTime(2022, 1, 8, 11, 0, 0),
                },
                new Message {
                  Id = "004",
                  SenderId = "001",
                  ReceiverId = "008",
                  Text = "Mauris nisl nulla, posuere vel ante vel, porttitor tincidunt eros.",
                  DateUtc = new DateTime(2022, 1, 9, 11, 0, 0),
                },
                new Message {
                  Id = "005",
                  SenderId = "001",
                  ReceiverId = "008",
                  Text =
                      "Sed mauris ligula, molestie sed dignissim a, convallis et libero. Vestibulum leo ligula, feugiat id enim a, aliquam luctus massa.",
                  DateUtc = new DateTime(2022, 1, 9, 11, 1, 0),
                },
                new Message {
                  Id = "006",
                  SenderId = "001",
                  ReceiverId = "004",
                  Text = "Vivamus pharetra urna tellus, in dignissim ex ultricies sit amet.",
                  DateUtc = new DateTime(2022, 1, 29, 18, 4, 0),
                },
                new Message {
                  Id = "007",
                  SenderId = "004",
                  ReceiverId = "001",
                  Text =
                      "Phasellus efficitur nisi vitae purus fermentum, eget sollicitudin sapien dignissim.",
                  DateUtc = new DateTime(2022, 1, 29, 18, 5, 0),
                },
                new Message {
                  Id = "008",
                  SenderId = "007",
                  ReceiverId = "001",
                  Text =
                      "Ut tincidunt faucibus finibus. Ut id vehicula nunc, sed efficitur justo.",
                  DateUtc = new DateTime(2022, 2, 6, 18, 8, 0),
                },
                new Message {
                  Id = "009",
                  SenderId = "001",
                  ReceiverId = "007",
                  Text =
                      "Duis molestie luctus purus, id tempus risus mollis non. Maecenas nec lacus elementum, finibus mauris id, efficitur ipsum.",
                  DateUtc = new DateTime(2022, 2, 6, 18, 9, 0),
                },
                new Message {
                  Id = "010",
                  SenderId = "007",
                  ReceiverId = "001",
                  Text = "Curabitur vitae aliquam augue.",
                  DateUtc = new DateTime(2022, 2, 6, 18, 9, 0),
                },
                new Message {
                  Id = "011",
                  SenderId = "001",
                  ReceiverId = "007",
                  Text = "Aliquam a nisl sed nisl ultrices consequat ut a urna.",
                  DateUtc = new DateTime(2022, 2, 6, 18, 11, 0),
                },
                new Message {
                  Id = "012",
                  SenderId = "007",
                  ReceiverId = "001",
                  Text = "Praesent placerat leo vitae bibendum ultricies.",
                  DateUtc = new DateTime(2022, 2, 7, 12, 47, 0),
                },
                new Message {
                  Id = "013",
                  SenderId = "007",
                  ReceiverId = "001",
                  Text =
                      "Vivamus aliquam ex sem, et consectetur dui consequat in. Morbi a risus euismod, sodales enim id, laoreet felis.",
                  DateUtc = new DateTime(2022, 2, 7, 12, 49, 0),
                },
                new Message {
                  Id = "014",
                  SenderId = "001",
                  ReceiverId = "012",
                  Text = "Nam at aliquet leo.",
                  DateUtc = new DateTime(2022, 2, 24, 14, 39, 0),
                },
                new Message {
                  Id = "015",
                  SenderId = "001",
                  ReceiverId = "012",
                  Text = "Cras laoreet purus nec elit rutrum, ut lacinia urna gravida.",
                  DateUtc = new DateTime(2022, 2, 24, 14, 39, 0),
                },
                new Message {
                  Id = "016",
                  SenderId = "012",
                  ReceiverId = "001",
                  Text =
                      "Aliquam semper eleifend augue, luctus euismod diam volutpat nec. Aliquam et mi efficitur, commodo odio a, dapibus leo.",
                  DateUtc = new DateTime(2022, 2, 24, 14, 41, 0),
                },
                new Message {
                  Id = "017",
                  SenderId = "001",
                  ReceiverId = "012",
                  Text =
                      "Cras facilisis libero a lorem vulputate, eget mollis nulla sagittis.",
                  DateUtc = new DateTime(2022, 2, 24, 14, 43, 0),
                },
                new Message {
                  Id = "018",
                  SenderId = "010",
                  ReceiverId = "001",
                  Text =
                      "Integer semper elit vitae ultricies laoreet. Mauris at ultricies massa.",
                  DateUtc = new DateTime(2022, 3, 5, 21, 36, 0),
                },
                new Message {
                  Id = "019",
                  SenderId = "001",
                  ReceiverId = "010",
                  Text =
                      "Sed at eros ante. Pellentesque rhoncus arcu sit amet justo tincidunt semper. Curabitur a mollis ante, eu dignissim ex",
                  DateUtc = new DateTime(2022, 3, 5, 21, 37, 0),
                },
                new Message {
                  Id = "020",
                  SenderId = "010",
                  ReceiverId = "001",
                  Text = "Cras nulla nulla, finibus in sollicitudin eget, gravida in lorem.",
                  DateUtc = new DateTime(2022, 3, 5, 21, 37, 0),
                },
                new Message {
                  Id = "021",
                  SenderId = "001",
                  ReceiverId = "010",
                  Text =
                      "Sed convallis dapibus lectus, eu sollicitudin leo euismod nec. Sed sodales et diam eget pharetra.",
                  DateUtc = new DateTime(2022, 3, 5, 21, 39, 0),
                },
                new Message {
                  Id = "022",
                  SenderId = "010",
                  ReceiverId = "001",
                  Text =
                      "Etiam bibendum orci non felis vehicula lacinia. Sed eget nisl et libero imperdiet faucibus sit amet quis urna. Etiam at tortor odio. Donec id lacus non velit convallis efficitur.",
                  DateUtc = new DateTime(2022, 3, 5, 21, 40, 0),
                },
                new Message {
                  Id = "023",
                  SenderId = "016",
                  ReceiverId = "001",
                  Text =
                      "Phasellus maximus lacus eget nunc suscipit posuere. Praesent elementum magna in posuere interdum.",
                  DateUtc = new DateTime(2022, 3, 30, 15, 11, 0),
                },
                new Message {
                  Id = "024",
                  SenderId = "016",
                  ReceiverId = "001",
                  Text = "Etiam venenatis suscipit pulvinar.",
                  DateUtc = new DateTime(2022, 3, 30, 15, 12, 0),
                },
                new Message {
                  Id = "025",
                  SenderId = "001",
                  ReceiverId = "016",
                  Text =
                      "Fusce ultricies lorem in libero facilisis accumsan. Suspendisse molestie diam et magna ornare ultricies. Nunc auctor ipsum placerat, eleifend nibh in, tincidunt metus.",
                  DateUtc = new DateTime(2022, 3, 30, 15, 12, 0),
                },
                new Message {
                  Id = "026",
                  SenderId = "016",
                  ReceiverId = "001",
                  Text =
                      "Nullam condimentum, libero vitae molestie mattis, nulla neque malesuada urna, non sagittis enim dui ac nunc.",
                  DateUtc = new DateTime(2022, 3, 30, 15, 13, 0),
                },
                new Message {
                  Id = "027",
                  SenderId = "001",
                  ReceiverId = "016",
                  Text = "Curabitur euismod metus at nunc tristique volutpat.",
                  DateUtc = new DateTime(2022, 3, 30, 15, 14, 0),
                },
                new Message {
                  Id = "028",
                  SenderId = "016",
                  ReceiverId = "001",
                  Text = "Proin porta lacus eget dui egestas euismod iaculis ac urna.",
                  DateUtc = new DateTime(2022, 3, 31, 10, 28, 0),
                },
                new Message {
                  Id = "029",
                  SenderId = "001",
                  ReceiverId = "002",
                  Text =
                      "Nunc cursus efficitur lectus. Nullam sit amet pretium mauris. Vivamus eleifend aliquet nunc, eget consequat sapien posuere nec.",
                  DateUtc = new DateTime(2022, 4, 17, 13, 28, 0),
                },
                new Message {
                  Id = "030",
                  SenderId = "002",
                  ReceiverId = "001",
                  Text =
                      "In neque ligula, viverra ac sem eget, blandit suscipit urna. In ac pretium felis.",
                  DateUtc = new DateTime(2022, 4, 17, 13, 30, 0),
                },
                new Message {
                  Id = "031",
                  SenderId = "001",
                  ReceiverId = "005",
                  Text =
                      "Suspendisse non mauris convallis, tempor sapien sit amet, scelerisque quam.",
                  DateUtc = new DateTime(2022, 4, 29, 10, 54, 0),
                },
                new Message {
                  Id = "032",
                  SenderId = "005",
                  ReceiverId = "001",
                  Text =
                      "Donec tempor est non leo dictum, auctor dignissim eros egestas. In pellentesque velit eget nunc suscipit, eu ullamcorper elit molestie.",
                  DateUtc = new DateTime(2022, 4, 29, 10, 56, 0),
                },
                new Message {
                  Id = "033",
                  SenderId = "001",
                  ReceiverId = "005",
                  Text = "Mauris scelerisque.",
                  DateUtc = new DateTime(2022, 4, 29, 10, 58, 0),
                },
            };
        }
    }
}
