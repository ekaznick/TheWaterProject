namespace WebApplication1.Models
{
    public interface IWaterRepository
    {
        public IQueryable<Project> Projects { get; }
    }
}
