namespace PostLand.Domain.Entites
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Post> Blogs{ get; set; }

    }
}
