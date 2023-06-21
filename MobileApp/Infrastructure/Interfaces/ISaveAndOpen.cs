namespace Punjab_Ornaments.Infrastructure.Interface
{
    public interface ISaveAndOpen
    {
        Task<bool> SaveAndView(string filename, string contentType, MemoryStream stream);
    }
}
