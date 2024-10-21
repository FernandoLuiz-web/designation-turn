using Designator.Domain.Entities;

namespace Designator.Domain.Repository;

public interface IPersonRepository
{
    Task<Person> GetByIdAsync(string id);

    Task InsertAsync(Person person);

    Task UpdateAsync(Person person);

    Task DeleteAsynce(string id);
}
