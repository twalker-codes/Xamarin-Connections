using SocialTemplate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class FavoriteDataStore : BaseDataStore<Favorite>, IFavoriteDataStore
    {
        protected override IList<Favorite> items { get; }

        public FavoriteDataStore()
        {
            items = new List<Favorite>()
            {
                // 001
                new Favorite{Id = "001", PostId = "008", PersonId = "001"},
                new Favorite{Id = "002", PostId = "012", PersonId = "001"},
                new Favorite{Id = "003", PostId = "018", PersonId = "001"},
                new Favorite{Id = "004", PostId = "024", PersonId = "001"},
                // 002
                new Favorite{Id = "005", PostId = "001", PersonId = "002"},
                new Favorite{Id = "006", PostId = "003", PersonId = "002"},
                new Favorite{Id = "007", PostId = "010", PersonId = "002"},
                new Favorite{Id = "008", PostId = "014", PersonId = "002"},
                // 003
                new Favorite{Id = "009", PostId = "002", PersonId = "003"},
                new Favorite{Id = "010", PostId = "011", PersonId = "003"},
                new Favorite{Id = "011", PostId = "020", PersonId = "003"},
                new Favorite{Id = "012", PostId = "022", PersonId = "003"},
                // 004
                new Favorite{Id = "013", PostId = "007", PersonId = "004"},
                new Favorite{Id = "014", PostId = "008", PersonId = "004"},
                new Favorite{Id = "015", PostId = "013", PersonId = "004"},
                new Favorite{Id = "016", PostId = "017", PersonId = "004"},
                // 005
                new Favorite{Id = "017", PostId = "004", PersonId = "005"},
                new Favorite{Id = "018", PostId = "009", PersonId = "005"},
                new Favorite{Id = "019", PostId = "011", PersonId = "005"},
                new Favorite{Id = "020", PostId = "023", PersonId = "005"},
                // 006
                new Favorite{Id = "021", PostId = "009", PersonId = "006"},
                new Favorite{Id = "022", PostId = "012", PersonId = "006"},
                new Favorite{Id = "023", PostId = "019", PersonId = "006"},
                new Favorite{Id = "024", PostId = "021", PersonId = "006"},
                // 007
                new Favorite{Id = "025", PostId = "010", PersonId = "007"},
                new Favorite{Id = "026", PostId = "019", PersonId = "007"},
                new Favorite{Id = "027", PostId = "022", PersonId = "007"},
                new Favorite{Id = "028", PostId = "023", PersonId = "007"},
                // 008
                new Favorite{Id = "029", PostId = "006", PersonId = "008"},
                new Favorite{Id = "030", PostId = "009", PersonId = "008"},
                new Favorite{Id = "031", PostId = "012", PersonId = "008"},
                new Favorite{Id = "032", PostId = "013", PersonId = "008"},
                // 009
                new Favorite{Id = "033", PostId = "007", PersonId = "009"},
                new Favorite{Id = "034", PostId = "015", PersonId = "009"},
                new Favorite{Id = "035", PostId = "021", PersonId = "009"},
                new Favorite{Id = "036", PostId = "022", PersonId = "009"},
                // 010
                new Favorite{Id = "037", PostId = "006", PersonId = "010"},
                new Favorite{Id = "038", PostId = "009", PersonId = "010"},
                new Favorite{Id = "039", PostId = "019", PersonId = "010"},
                new Favorite{Id = "040", PostId = "020", PersonId = "010"},
                // 011
                new Favorite{Id = "041", PostId = "005", PersonId = "011"},
                new Favorite{Id = "042", PostId = "014", PersonId = "011"},
                new Favorite{Id = "043", PostId = "019", PersonId = "011"},
                new Favorite{Id = "044", PostId = "022", PersonId = "011"},
                // 012
                new Favorite{Id = "045", PostId = "002", PersonId = "012"},
                new Favorite{Id = "046", PostId = "008", PersonId = "012"},
                new Favorite{Id = "047", PostId = "013", PersonId = "012"},
                new Favorite{Id = "048", PostId = "018", PersonId = "012"},
                // 013
                new Favorite{Id = "049", PostId = "001", PersonId = "013"},
                new Favorite{Id = "050", PostId = "008", PersonId = "013"},
                new Favorite{Id = "051", PostId = "011", PersonId = "013"},
                new Favorite{Id = "052", PostId = "020", PersonId = "013"},
                // 014
                new Favorite{Id = "053", PostId = "009", PersonId = "014"},
                new Favorite{Id = "054", PostId = "014", PersonId = "014"},
                new Favorite{Id = "055", PostId = "015", PersonId = "014"},
                new Favorite{Id = "056", PostId = "022", PersonId = "014"},
                // 015
                new Favorite{Id = "057", PostId = "016", PersonId = "015"},
                new Favorite{Id = "058", PostId = "017", PersonId = "015"},
                new Favorite{Id = "059", PostId = "020", PersonId = "015"},
                new Favorite{Id = "060", PostId = "023", PersonId = "015"},
                // 016
                new Favorite{Id = "061", PostId = "007", PersonId = "016"},
                new Favorite{Id = "062", PostId = "013", PersonId = "016"},
                new Favorite{Id = "063", PostId = "019", PersonId = "016"},
                new Favorite{Id = "064", PostId = "024", PersonId = "016"},
            };
        }
    }
}
