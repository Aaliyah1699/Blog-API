namespace BlogApi.Models.DTO
{
    public class UpdateBlogPostReqDto
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }
        public string FeaturedImgUrl { get; set; }
        public string UrlHandle { get; set; }
        public DateTime DatePublished { get; set; }
        public string Author { get; set; }
        public bool IsVisible { get; set; }
        public List<Guid> Categories { get; set; } = new List<Guid>();
    }
}