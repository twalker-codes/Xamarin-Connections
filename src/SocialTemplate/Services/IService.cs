using SocialTemplate.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SocialTemplate.Services
{
    public interface IService
    {
        Task<IEnumerable<Comment>> GetComments(string postId);

        Task<Comment> AddComment(string text, string postId);

        Task<Post> GetPost(string id);

        Task<IEnumerable<Post>> GetPosts(string keyword = null, string authorId = null, bool onlyFavorite = false);

        Task<IEnumerable<Favorite>> GetAllFavorites();

        Task<Favorite> AddFavorite(string postId);

        Task<bool> RemoveFavorite(string postId);

        Task<bool> RemoveAllFavorite();

        Task<IEnumerable<Message>> GetMessages(string personId);

        Task<Message> AddMessage(string receiverId, string text);

        Task<IEnumerable<Notify>> GetNotifies();

        Task<Person> GetPerson(string id);

        Task<IEnumerable<Person>> GetPersons(string name = null, bool onlyFollower = false, 
            bool onlyFollowing = false, SortBy sortBy = SortBy.Unsorted);

        Task<bool> UpdatePerson(Person person);

        Task<bool> UpdateLoggedPerson(string cover, string photo, string fullName, 
            string username, string email, string phone);

        Task<IEnumerable<SearchItem>> GetAllPostSearchItems();

        Task<SearchItem> AddPostSearchItem(string keyword);

        Task<bool> DeleteAllPostSearchItems();

        Task<bool> DeletePostSearchItem(string id);

        Task<SearchItem> FindPostSearchItem(string keyword);
    }
}
