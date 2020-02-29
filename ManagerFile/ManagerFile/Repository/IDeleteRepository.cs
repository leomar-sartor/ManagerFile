namespace ManagerFile.Repository
{
    public interface IDeleteRepository<TModel>
    {
        bool Delete(string id);
    }
}
