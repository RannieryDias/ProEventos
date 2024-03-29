using ProEventos.Domain;

namespace ProEventos.Persistence.Contracts
{
    public interface IGeneralPersistence
    {
        #region General
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void DeleteRange<T>(T[] entityArray) where T : class;
        Task<bool> SaveChangesAsync();
        #endregion
    }
}