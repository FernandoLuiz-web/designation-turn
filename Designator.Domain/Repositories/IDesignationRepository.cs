using Designator.Domain.Entities;

namespace Designator.Domain.Repository;

public interface IDesignationRepository
{
    Task GetByIdAsync(string id);

    Task InsertAsync(Designation person);

    Task UpdateAsync(Person person);

    Task DeleteAsynce(string id);
}
