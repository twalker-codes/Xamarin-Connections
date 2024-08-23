using SocialTemplate.DataStores;
using SocialTemplate.DataStores.MockDataStore;
using SocialTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SocialTemplate.Services
{
    public class MockService : IService
    {
        ICommentDataStore dataComment = DependencyService.Get<ICommentDataStore>();
        IFavoriteDataStore dataFavorite = DependencyService.Get<IFavoriteDataStore>();
        IMessageDataStore dataMessage = DependencyService.Get<IMessageDataStore>();
        INotifyDataStore dataNotify = DependencyService.Get<INotifyDataStore>();
        IPersonDataStore dataPerson = DependencyService.Get<IPersonDataStore>();
        IPostDataStore dataPost = DependencyService.Get<IPostDataStore>();
        ISearchItemDataStore dataSearchItem = DependencyService.Get<ISearchItemDataStore>();

        public async Task<IEnumerable<Comment>> GetComments(string postId)
        {
            return (await dataComment.GetByAsync(p => p.PostId == postId)).ToList()
                .Select(p =>
                {
                    var author = dataPerson.GetAsync(p.AuthorId).Result;
                    p.AuthorPhoto = author.Photo;
                    p.AuthorName = author.FullName;
                    p.AuthorUsername = author.Username;
                    p.AuthorTicked = author.Ticked;
                    return p;
                }).OrderBy(p => p.DateUtc);
        }

        public async Task<Comment> AddComment(string text, string postId)
        {
            var person = await dataPerson.GetAsync(Globals.LoggedPersonId);

            Comment comment = new Comment
            {
                Id = Guid.NewGuid().ToString(),
                DateUtc = DateTime.UtcNow,
                Text = text,
                PostId = postId,
                AuthorId = Globals.LoggedPersonId,
                AuthorPhoto = person.Photo,
                AuthorName = person.FullName,
                AuthorTicked = person.Ticked,
                AuthorUsername = person.Username,
            };

            return await dataComment.AddAsync(comment);
        }

        public async Task<Post> GetPost(string id)
        {
            Post post = await dataPost.GetAsync(id);

            post.CommentCount = (await dataComment.GetByAsync(p => p.PostId == id)).Count();

            post.FavoriteCount = (await dataFavorite.GetByAsync(p => p.PostId == id)).Count();

            Person author = await dataPerson.GetAsync(post.AuthorId);
            post.AuthorPhoto = author.Photo;
            post.AuthorName = author.FullName;
            post.AuthorUsername = author.Username;
            post.AuthorTicked = author.Ticked;

            return post;        
        }

        public async Task<IEnumerable<Post>> GetPosts(string keyword = null, string authorId = null,
            bool onlyFavorite = false)
        {
            return (await dataPost.GetByAsync(p =>
                (keyword == null || p.Text.ToLower().Contains(keyword.ToLower())) &&
                (authorId == null || p.AuthorId == authorId)))
                    .ToList()
                    .Select(p => {
                        var author = dataPerson.GetAsync(p.AuthorId).Result;
                        p.AuthorName = author.FullName;
                        p.AuthorPhoto = author.Photo;
                        p.AuthorUsername = author.Username;
                        p.AuthorTicked = author.Ticked;

                        p.FavoriteCount = dataFavorite.GetByAsync(f => f.PostId == p.Id).Result.Count();
                        p.CommentCount = dataComment.GetByAsync(c => c.PostId == p.Id).Result.Count();

                        p.IsFavorite = dataFavorite.IsExistAsync(r => r.PersonId == Globals.LoggedPersonId && r.PostId == p.Id).Result;
                        return p;
                    })
                    .Where(r => onlyFavorite == false || r.IsFavorite == true)
                    .OrderBy(r => r.DateUtc);
        }

        public async Task<IEnumerable<Favorite>> GetAllFavorites()
        {
            return await dataFavorite.GetAllAsync();
        }

        public async Task<Favorite> AddFavorite(string postId)
        {
            Favorite fav = new Favorite
            {
                Id = Guid.NewGuid().ToString(),
                PostId = postId,
                PersonId = Globals.LoggedPersonId,
            };

            return await dataFavorite.AddAsync(fav);
        }

        public async Task<bool> RemoveFavorite(string postId)
        {
            var items = await dataFavorite.GetByAsync(p =>
                    p.PostId == postId && p.PersonId == Globals.LoggedPersonId);

            if (items.Count() != 0)
                return await dataFavorite.DeleteAsync(items.First().Id);

            return false;
        }

        public async Task<bool> RemoveAllFavorite()
        {
            var items = await dataFavorite.GetByAsync(p => p.PersonId == Globals.LoggedPersonId);

            foreach (var item in items)
                await dataFavorite.DeleteAsync(item.Id);

            return true;
        }

        public async Task<IEnumerable<Message>> GetMessages(string personId)
        {
            return (await dataMessage.GetByAsync(p =>
                    (p.SenderId == personId || p.SenderId == Globals.LoggedPersonId) &&
                    (p.ReceiverId == personId || p.ReceiverId == Globals.LoggedPersonId)))
                    .ToList()
                    .OrderBy(p => p.DateUtc);
        }

        public async Task<Message> AddMessage(string receiverId, string text)
        {
            Message msg = new Message
            {
                Id = Guid.NewGuid().ToString(),
                SenderId = Globals.LoggedPersonId,
                ReceiverId = receiverId,
                Text = text,
                DateUtc = DateTime.UtcNow,
            };

            return await dataMessage.AddAsync(msg);
        }

        public async Task<IEnumerable<Notify>> GetNotifies()
        {
            return (await dataNotify.GetAllAsync())
                    .Select(p =>
                    {
                        var person = dataPerson.GetAsync(p.PersonId).Result;
                        p.PersonPhoto = person.Photo;
                        p.PersonName = person.FullName;
                        p.PersonTicked = person.Ticked;
                        return p;
                    })
                    .OrderByDescending(p => p.DateUtc);
        }

        public async Task<Person> GetPerson(string id)
        {
            return await dataPerson.GetAsync(id);
        }

        public async Task<IEnumerable<Person>> GetPersons(string name = null, bool onlyFollower = false,
            bool onlyFollowing = false, SortBy sortBy = SortBy.Unsorted)
        {
            var persons = (await dataPerson.GetByAsync(p =>
                    (name == null || p.FullName.ToLower().Contains(name.ToLower())) &&
                    (onlyFollower == false || p.Follower == true) &&
                    (onlyFollowing == false || p.Following == true)))
                    .ToList()
                    .Select(p =>
                    {
                        p.RecentContact = GetMessages(p.Id).Result.LastOrDefault()?.DateUtc;
                        return p;
                    });
                    
            switch(sortBy)
            {
                case SortBy.NameAZ:
                    return persons.OrderBy(p => p.FullName);
                case SortBy.NameZA:
                    return persons.OrderByDescending(p => p.FullName);
                case SortBy.RecentContact:
                    return persons.OrderByDescending(p => p.RecentContact);
                default:
                    return persons;
            }
        }

        public async Task<bool> UpdatePerson(Person person)
        {
            return await dataPerson.UpdateAsync(person);
        }

        public async Task<bool> UpdateLoggedPerson(string cover, string photo, string fullName,
            string username, string email, string phone)
        {
            Person person = new Person
            {
                Id = Globals.LoggedPersonId,
                Cover = cover,
                Photo = photo,
                FullName = fullName,
                Username = username,
                Email = email,
                Phone = phone,
                Ticked = true,
                Follower = false,
                Following = false,
                MemberDate = new DateTime(2000,1,1),
            };

            return await dataPerson.UpdateAsync(person);
        }

        public async Task<IEnumerable<SearchItem>> GetAllPostSearchItems()
        {
            return (await dataSearchItem.GetAllAsync())
                    .ToList()
                    .OrderByDescending(p => p.dateTimeUtc);
        }

        public async Task<SearchItem> AddPostSearchItem(string keyword)
        {
            SearchItem item = new SearchItem
            {
                Id = Guid.NewGuid().ToString(),
                Keyword = keyword,
            };

            return await dataSearchItem.AddAsync(item);
        }

        public async Task<bool> DeleteAllPostSearchItems()
        {
            return await dataSearchItem.DeleteAllAsync();
        }

        public async Task<bool> DeletePostSearchItem(string id)
        {
            return await dataSearchItem.DeleteAsync(id);
        }

        public async Task<SearchItem> FindPostSearchItem(string keyword)
        {
            return (await dataSearchItem.GetByAsync(p => p.Keyword == keyword))
                        .FirstOrDefault();
        }
    }
}
