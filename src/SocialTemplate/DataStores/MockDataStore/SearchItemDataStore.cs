using SocialTemplate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialTemplate.DataStores.MockDataStore
{
    /// <summary>
    /// Mock data store with fake entities to test.
    /// </summary>
    public class SearchItemDataStore : BaseDataStore<SearchItem>, ISearchItemDataStore
    {
        protected override IList<SearchItem> items { get; }

        public SearchItemDataStore()
        {
            items = new List<SearchItem>()
            {
                new SearchItem { Id = "001", Keyword = "arc" },
                new SearchItem { Id = "002", Keyword = "donec" },
                new SearchItem { Id = "003", Keyword = "eget" },
                new SearchItem { Id = "004", Keyword = "tor" },
            };
        }
    }
}
