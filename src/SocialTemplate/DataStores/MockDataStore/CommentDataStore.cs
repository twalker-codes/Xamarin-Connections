using SocialTemplate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class CommentDataStore : BaseDataStore<Comment>, ICommentDataStore
    {
        protected override IList<Comment> items { get; }

        public CommentDataStore()
        {
            items = new List<Comment>()
            {
                new Comment {
                  Id = "001",
                  DateUtc = new DateTime(2022, 1, 11),
                  Text = "Donec et purus orci. Aenean vel augue eu ligula laoreet euismod sed vel nulla.",
                  PostId = "001",
                  AuthorId = "010",
                },
                new Comment {
                  Id = "002",
                  DateUtc = new DateTime(2022, 1, 12),
                  Text = "Nam quam nunc, auctor lobortis odio et, pharetra imperdiet quam.",
                  PostId = "001",
                  AuthorId = "004",
                },
                new Comment {
                  Id = "003",
                  DateUtc = new DateTime(2022, 1, 24),
                  Text = "Maecenas tincidunt tellus enim, vel faucibus erat volutpat et. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                  PostId = "001",
                  AuthorId = "012",
                },
                new Comment {
                  Id = "004",
                  DateUtc = new DateTime(2022, 2, 9),
                  Text = "Nam arcu lorem, pulvinar ac egestas quis, tincidunt eget urna.",
                  PostId = "003",
                  AuthorId = "016",
                },
                new Comment {
                  Id = "005",
                  DateUtc = new DateTime(2022, 2, 21),
                  Text =
                      "Vivamus a ante id neque sodales volutpat et eget sapien. Pellentesque sed pulvinar lorem. Ut non semper mi.",
                  PostId = "004",
                  AuthorId = "001",
                },
                new Comment {
                  Id = "006",
                  DateUtc = new DateTime(2022, 2, 21),
                  Text = "Maecenas commodo nec nisi quis tristique.",
                  PostId = "004",
                  AuthorId = "009",
                },
                new Comment {
                  Id = "007",
                  DateUtc = new DateTime(2022, 3, 10),
                  Text = "Nam dictum lacus ornare felis viverra facilisis. Aliquam rhoncus augue id nibh vulputate eleifend. Nam at rutrum libero.",
                  PostId = "005",
                  AuthorId = "002",
                },
                new Comment{
                  Id = "008",
                  DateUtc = new DateTime(2022, 3, 12),
                  Text = "Donec interdum, neque ut fringilla consectetur, dui ligula lacinia lacus, non porttitor felis neque in dolor.",
                  PostId = "005",
                  AuthorId = "016",
                },
                new Comment { 
                  Id = "009",
                  DateUtc = new DateTime (2022, 3, 18),
                  Text = "Morbi consectetur augue sit amet aliquet dictum.",
                  PostId = "005",
                  AuthorId = "008",
                },
                new Comment {
                  Id = "010",
                  DateUtc = new DateTime(2022, 4, 4),
                  Text =
                      "Aliquam mattis mi nunc, ut porta dolor vehicula vel. Integer sagittis, est vel tristique finibus, libero leo convallis risus, lacinia posuere orci nulla ut massa.",
                  PostId = "007",
                  AuthorId = "006",
                },
                new Comment {
                  Id = "011",
                  DateUtc = new DateTime(2022, 4, 28),
                  Text = "Mauris sit amet tellus arcu.",
                  PostId = "008",
                  AuthorId = "005",
                },
                new Comment {
                  Id = "012",
                  DateUtc = new DateTime(2022, 4, 29),
                  Text = "Morbi faucibus aliquam nulla, non congue velit ullamcorper vitae.",
                  PostId = "008",
                  AuthorId = "009",
                },
                new Comment {
                  Id = "013",
                  DateUtc = new DateTime(2022, 5, 14),
                  Text = "Sed cursus risus at consectetur imperdiet. Morbi sit amet ullamcorper augue.",
                  PostId = "009",
                  AuthorId = "008",
                },
                new Comment {
                  Id = "014",
                  DateUtc = new DateTime(2022, 5, 14),
                  Text = "Integer porta tincidunt ante, eu aliquam nisi auctor et. Etiam porttitor consequat mauris, ac hendrerit lectus pretium in.",
                  PostId = "009",
                  AuthorId = "014",
                },
                new Comment {
                  Id = "015",
                  DateUtc = new DateTime(2022, 5, 26),
                  Text = "Duis eleifend erat ut est egestas volutpat. Aenean nec nunc et nunc dignissim mollis.",
                  PostId = "010",
                  AuthorId = "006",
                },
                new Comment {
                  Id = "016",
                  DateUtc = new DateTime(2022, 6, 17),
                  Text = "Cras a dui risus.",
                  PostId = "011",
                  AuthorId = "007",
                },
                new Comment {
                  Id = "017",
                  DateUtc = new DateTime(2022, 7, 2),
                  Text = "Sed sed augue at ante euismod condimentum. In congue ipsum et tempus efficitur. Nunc vel accumsan nulla.",
                  PostId = "012",
                  AuthorId = "015",
                },
                new Comment{
                  Id = "018",
                  DateUtc = new DateTime(2022, 7, 3),
                  Text =
                      "Nam sit amet diam placerat, vulputate neque vitae, eleifend leo. Sed laoreet vel metus vitae egestas. Curabitur vel diam placerat, tristique purus aliquam, pellentesque arcu. Cras aliquet lorem leo, vel tincidunt leo finibus in. Aliquam vel sagittis leo, et maximus purus.",
                  PostId = "012",
                  AuthorId = "004",
                },
                new Comment {
                  Id = "019",
                  DateUtc = new DateTime(2022, 7, 3),
                  Text = "Morbi in nunc at mi posuere semper.",
                  PostId = "012",
                  AuthorId = "005",
                },
                new Comment {
                  Id = "020",
                  DateUtc = new DateTime(2022, 7, 5),
                  Text = "Integer condimentum fringilla lectus nec porttitor.",
                  PostId = "012",
                  AuthorId = "012",
                },
                new Comment {
                  Id = "021",
                  DateUtc = new DateTime(2022, 7, 12),
                  Text = "Mauris molestie volutpat tristique. Aliquam sollicitudin laoreet quam.",
                  PostId = "013",
                  AuthorId = "009",
                },
                new Comment {
                  Id = "022",
                  DateUtc = new DateTime(2022, 7, 29),
                  Text = "Phasellus nec commodo risus. Mauris condimentum, est gravida scelerisque condimentum, lorem ante malesuada eros, viverra mattis sapien ante a eros.",
                  PostId = "014",
                  AuthorId = "014",
                },
                new Comment {
                  Id = "023",
                  DateUtc = new DateTime(2022, 8, 10),
                  Text = "Nunc at luctus ipsum, sit amet maximus quam. Suspendisse in justo dignissim, fringilla enim sit amet, lacinia nisi. Mauris quis vehicula velit, nec auctor odio. Donec tempus libero sit amet arcu rhoncus, sit amet posuere enim egestas.",
                  PostId = "015",
                  AuthorId = "003",
                },
                new Comment {
                  Id = "024",
                  DateUtc = new DateTime(2022, 8, 11),
                  Text = "Donec id dignissim ipsum.",
                  PostId = "015",
                  AuthorId = "011",
                },
                new Comment {
                  Id = "025",
                  DateUtc = new DateTime(2022, 9, 18),
                  Text = "Vivamus eget felis cursus, dignissim velit mollis, porttitor enim.",
                  PostId = "018",
                  AuthorId = "016",
                },
                new Comment {
                  Id = "026",
                  DateUtc = new DateTime(2022, 10, 6),
                  Text = "Integer in nunc consequat lacus tincidunt convallis. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer rutrum sed augue a elementum.",
                  PostId = "019",
                  AuthorId = "001",
                },
                new Comment {
                  Id = "027",
                  DateUtc = new DateTime(2022, 10, 8),
                  Text = "In id nunc ac ligula blandit laoreet.",
                  PostId = "019",
                  AuthorId = "005",
                },
                new Comment {
                  Id = "028",
                  DateUtc = new DateTime(2022, 11, 17),
                  Text = "Fusce commodo consequat est imperdiet luctus. Donec nec purus ac neque congue finibus.",
                  PostId = "021",
                  AuthorId = "008",
                },
                new Comment {
                  Id = "029",
                  DateUtc = new DateTime(2022, 11, 30),
                  Text =
                      "Sed interdum mattis lacinia. Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                  PostId = "022",
                  AuthorId = "010",
                },
                new Comment {
                  Id = "030",
                  DateUtc = new DateTime(2022, 12, 8),
                  Text = "Aenean pharetra velit augue, at maximus nibh condimentum pharetra.",
                  PostId = "023",
                  AuthorId = "013",
                },
                new Comment {
                  Id = "031",
                  DateUtc = new DateTime(2022, 12, 11),
                  Text = "Pellentesque sit amet blandit lacus, sit amet aliquet lorem. Proin vel sollicitudin elit, et mattis ante.",
                  PostId = "023",
                  AuthorId = "001",
                },
                new Comment {
                  Id = "032",
                  DateUtc = new DateTime(2022, 12, 26),
                  Text = "Maecenas laoreet euismod neque quis cursus.",
                  PostId = "024",
                  AuthorId = "004",
                },
                new Comment {
                  Id = "033",
                  DateUtc = new DateTime(2022, 12, 28),
                  Text = "Vivamus efficitur tellus sit amet gravida sodales.",
                  PostId = "024",
                  AuthorId = "009",
                },
                new Comment {
                  Id = "034",
                  DateUtc = new DateTime(2022, 12, 28),
                  Text = "Praesent vitae efficitur urna, vitae porta lectus. Vestibulum nec sem eu mi luctus pulvinar in non nisl.",
                  PostId = "024",
                  AuthorId = "015",
                }
            };
        }
    }
}
