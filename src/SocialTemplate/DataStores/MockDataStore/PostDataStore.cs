using SocialTemplate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class PostDataStore : BaseDataStore<Post>, IPostDataStore
    {
        protected override IList<Post> items { get; }

        public PostDataStore()
        {
            items = new List<Post>()
            {
                new Post {
                  Id = "001",
                  AuthorId = "001",
                  DateUtc = new DateTime(2022, 1, 11, 08, 46, 0),
                  Text = "Praesent quis ex diam. Suspendisse volutpat, metus eu lobortis volutpat, magna mi porta enim, vel sagittis sem leo sit amet purus.",
                  Images = new string[] { "cover001", "cover002" },
                  ViewCount = 152,
                },
                new Post {
                  Id = "002",
                  AuthorId = "003",
                  DateUtc = new DateTime(2022, 1, 28, 11, 32, 0),
                  Text = "Donec vehicula nulla vitae elit ultrices, id posuere augue dapibus.",
                  Images = new string[] { "cover003", "cover004", "cover005" },
                  ViewCount = 74,
                },
                new Post {
                  Id = "003",
                  AuthorId = "015",
                  DateUtc = new DateTime(2022, 2, 8, 3, 51, 0),
                  Text = "Nulla blandit dapibus elementum. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Phasellus viverra commodo velit.",
                  Images = new string[] { "cover006", "cover007" },
                  ViewCount = 364,
                },
                new Post {
                  Id = "004",
                  AuthorId = "009",
                  DateUtc = new DateTime(2022, 2, 15, 16, 24, 0),
                  Text = "Fusce vitae eleifend elit. Sed vel eros facilisis, faucibus neque a, blandit odio. Ut quis nisi vitae neque euismod posuere.",
                  Images = new string[] { "cover008", "cover009", "cover010" },
                  ViewCount = 625,
                },
                new Post {
                  Id = "005",
                  AuthorId = "014",
                  DateUtc = new DateTime(2022, 3, 8, 23, 11, 0),
                  Text = "ivamus vitae sapien pulvinar, faucibus arcu sit amet, auctor neque. Nulla facilisis, nibh id iaculis convallis, lorem erat vestibulum lorem, fermentum malesuada arcu nulla id ante.",
                  Images = new string[] { "cover011", "cover012" },
                  ViewCount = 341,
                },
                new Post {
                  Id = "006",
                  AuthorId = "007",
                  DateUtc = new DateTime(2022, 3, 28, 9, 20, 0),
                  Text =
                      "Mauris faucibus dignissim dapibus. Nam eu dui vulputate, porta sem non, tempor lectus. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                  Images = new string[] {"cover013", "cover014", "cover015" },
                  ViewCount = 142,
                },
                new Post {
                  Id = "007",
                  AuthorId = "011",
                  DateUtc = new DateTime(2022, 4, 1, 14, 58, 0),
                  Text =
                      "Sed iaculis consequat pellentesque. Fusce ac fermentum lacus, nec tristique nibh.",
                  Images = new string[] { "cover016", "cover017", "cover018" },
                  ViewCount = 135,
                },
                new Post {
                  Id = "008",
                  AuthorId = "005",
                  DateUtc = new DateTime(2022, 4, 25, 17, 20, 0),
                  Text = "Nunc eu urna nec nunc rutrum luctus. Nulla suscipit lacus eget posuere molestie. Aenean tincidunt odio et interdum posuere. Nulla elit tellus, dapibus iaculis sapien sed, vestibulum vulputate sem. Phasellus diam nisl, vestibulum at quam a, semper aliquam metus.",
                  Images = new string[] { "cover019", "cover020" },
                  ViewCount = 63,
                },
                new Post {
                  Id = "009",
                  AuthorId = "012",
                  DateUtc = new DateTime(2022, 5, 13, 16, 7, 0),
                  Text = "Nullam id tempus nulla. Etiam sit amet tellus quam. Pellentesque eget tellus ultricies, eleifend risus ac, pretium elit. Mauris sed ipsum eros. In quis tincidunt justo. Fusce ut pulvinar est, in sollicitudin ex.",
                  Images = new string[] { "cover021", "cover022", "cover023" },
                  ViewCount = 91,
                },
                new Post {
                  Id = "010",
                  AuthorId = "002",
                  DateUtc = new DateTime(2022, 5, 24, 10, 29, 0),
                  Text = "Donec faucibus, massa vel condimentum viverra, turpis nisl rhoncus augue, at ultricies nisl urna nec nunc.",
                  Images = new string[] { "cover024", "cover025", "cover026" },
                  ViewCount = 32,
                },
                new Post {
                  Id = "011",
                  AuthorId = "001",
                  DateUtc = new DateTime(2022, 6, 17, 11, 30, 0),
                  Text =
                      "Suspendisse in dapibus velit. Suspendisse vulputate lacinia sodales. Nullam blandit consequat elementum. Ut non lorem maximus ante egestas pharetra. Donec justo leo, iaculis sed interdum sed, ultrices sed lectus.",
                  Images = new string[] { "cover027", "cover028" },
                  ViewCount = 467,
                },
                new Post {
                  Id = "012",
                  AuthorId = "008",
                  DateUtc = new DateTime(2022, 6, 30, 12, 53, 0),
                  Text = "Ut molestie orci eros, vel posuere enim porttitor quis. Donec eget finibus lorem, eget dictum ligula. Nunc et ex a metus vestibulum posuere. Phasellus placerat eleifend felis.",
                  Images = new string[] { "cover029", "cover030", "cover031" },
                  ViewCount = 723,
                },
                new Post {
                  Id = "013",
                  AuthorId = "013",
                  DateUtc = new DateTime(2022, 7, 19, 11, 47, 0),
                  Text =
                      "Praesent euismod congue ipsum, id suscipit augue imperdiet vel. Pellentesque iaculis, nisl at congue sodales, odio erat finibus libero, sed porttitor purus dolor eu ex.",
                  Images = new string[] { "cover032", "cover033" },
                  ViewCount = 615,
                },
                new Post {
                  Id = "014",
                  AuthorId = "010",
                  DateUtc = new DateTime(2022, 7, 29, 22, 12, 0),
                  Text = "Fusce sit amet vestibulum nisl. Vestibulum eget eros ipsum.",
                  Images = new string[] { "cover034", "cover035" },
                  ViewCount = 23,
                },
                new Post {
                  Id = "015",
                  AuthorId = "006",
                  DateUtc = new DateTime(2022, 8, 10, 1, 22, 0),
                  Text =
                      "Ut eleifend, urna at malesuada rhoncus, diam enim tincidunt odio, non efficitur urna neque ac libero. Donec gravida feugiat nisi nec suscipit. Nullam eget laoreet dui. Phasellus gravida quam sit amet turpis porta, in iaculis tellus volutpat.",
                  Images = new string[] { "cover036", "cover037", "cover038" },
                  ViewCount = 873,
                },
                new Post {
                  Id = "016",
                  AuthorId = "002",
                  DateUtc = new DateTime(2022, 8, 31, 7, 34, 0),
                  Text = "In pellentesque sapien urna, at pellentesque metus sodales nec. Aenean gravida molestie efficitur. Donec ornare tellus nec ligula tristique, non rhoncus massa dapibus.",
                  Images = new string[] { "cover039", "cover040" },
                  ViewCount = 86,
                },
                new Post {
                    Id = "017",
                    AuthorId = "009",
                    DateUtc = new DateTime(2022, 9, 4, 18, 3, 0),
                    Text = "Nam scelerisque tellus id sapien condimentum, nec tincidunt enim consectetur. Cras lectus ex, finibus nec ultricies id, vulputate sit amet eros. Pellentesque sodales id nulla nec aliquam. Nulla et nibh ullamcorper, tristique lacus ullamcorper, rutrum mauris.",
                    Images = new string[] { "cover041", "cover042" },
                    ViewCount = 701,
                },
                new Post {
                  Id = "018",
                  AuthorId = "016",
                  DateUtc = new DateTime(2022, 9, 16, 23, 56, 0),
                  Text = "Vestibulum sed lorem enim. Phasellus blandit sapien diam, nec luctus augue consectetur volutpat.",
                  Images = new string[] { "cover043", "cover044", "cover045" },
                  ViewCount = 411,
                },
                new Post {
                  Id = "019",
                  AuthorId = "003",
                  DateUtc = new DateTime(2022, 10, 6, 4, 9, 0),
                  Text = "Nunc faucibus ut nisi pellentesque malesuada. Nullam sodales sollicitudin convallis. Donec tincidunt hendrerit lectus, vel gravida felis elementum et.",
                  Images = new string[] {"cover046", "cover047" },
                  ViewCount = 205,
                },
                new Post {
                  Id = "020",
                  AuthorId = "005",
                  DateUtc = new DateTime(2022, 10, 27, 14, 32, 0),
                  Text = "Praesent at massa congue, mollis velit quis, eleifend nisi. Etiam varius rhoncus aliquam. Pellentesque vulputate dignissim magna volutpat porta. Morbi malesuada pulvinar ultricies. Pellentesque sed congue turpis.",
                  Images = new string[] { "cover048", "cover049", "cover050" },
                  ViewCount = 345,
                },
                new Post {
                  Id = "021",
                  AuthorId = "008",
                  DateUtc = new DateTime(2022, 11, 15, 17, 12, 0),
                  Text = "Aenean lobortis purus quis sem luctus, eget elementum tortor rutrum. Ut iaculis ullamcorper lacinia.",
                  Images = new string[] {"cover051", "cover052" },
                  ViewCount = 430,
                },
                new Post {
                  Id = "022",
                  AuthorId = "011",
                  DateUtc = new DateTime(2022, 11, 28, 15, 49, 0),
                  Text = "Nunc dictum nisi odio, quis vestibulum purus congue eu. Quisque mattis, mi posuere auctor pretium, nisl dui varius justo, nec blandit augue leo ac ex.",
                  Images = new string[] { "cover053", "cover054", "cover055" },
                  ViewCount = 38,
                },
                new Post {
                  Id = "023",
                  AuthorId = "006",
                  DateUtc = new DateTime(2022, 12, 7, 10, 32, 0),
                  Text = "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Etiam consequat tempor lacus ac interdum.",
                  Images = new string[] { "cover056", "cover057" },
                  ViewCount = 546,
                },
                new Post {
                  Id = "024",
                  AuthorId = "010",
                  DateUtc = new DateTime(2022, 12, 25, 15, 38, 0),
                  Text =
                      "Morbi gravida tellus mi, eget semper dui placerat sed. Vivamus porta vitae magna ut consequat. Suspendisse semper, nulla condimentum rutrum finibus, orci ipsum condimentum ipsum, vel porta turpis nibh congue odio. Curabitur sit amet urna condimentum, tincidunt tellus sed, suscipit est.",
                  Images = new string[] { "cover058", "cover059", "cover060" },
                  ViewCount = 79,
                },
            };
        }
    }
}
