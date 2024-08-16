using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Domain.Repositories;

public interface INewsRepository : IRepository<News, Guid>
{
    Task<List<News>> GetRecentNewsAsync();
}