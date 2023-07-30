namespace Hospital.DAL;

public interface IGenericRepo<T> where T : class
{
    IEnumerable<T> GetAll();
    T? GetById(Guid id);
    void Add(T doctor);
    void Update(T doctor);
    void Delete(T doctor);
}
