namespace blog_api;

public class PostRepository : GenericRepository<Post>, IPostRepository
{
    public PostRepository(IDataContext dataContext) : base(dataContext)
    {
    }
}
