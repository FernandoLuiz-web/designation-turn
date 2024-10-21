using Designator.Domain.Entities;

namespace Designator.Domain.Repository;

public interface IRoleRepository
{
    Task<Role> GetByIdAsync(string id);

    Task InsertAsync(Role person);

    Task UpdateAsync(Role person);

    Task DeleteAsynce(string id);
}
