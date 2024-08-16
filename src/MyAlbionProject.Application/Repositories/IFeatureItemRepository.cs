using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using Volo.Abp.Domain.Repositories;

public interface IFeatureItemRepository : IRepository<FeatureItem, Guid>
{
    Task<List<FeatureItem>> GetTopFeatureItemsAsync(int count);
}