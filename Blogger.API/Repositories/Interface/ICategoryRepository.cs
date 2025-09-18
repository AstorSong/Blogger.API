using Blogger.API.Models.Domain;

namespace Blogger.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
