using System.Collections.Generic;

namespace ManagerFile.Repository
{
    public interface ISelectRepository<TModel>
    {
        TModel SelectOne(string id);

        IEnumerable<TModel> SelectMany(string id);
    }
}
