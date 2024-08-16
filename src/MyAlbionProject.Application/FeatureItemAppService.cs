using AutoMapper.Internal.Mappers;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

public class FeatureItemAppService : ApplicationService, IFeatureItemAppService
{
    private readonly IFeatureItemRepository _featureItemRepository;

    public FeatureItemAppService(IFeatureItemRepository featureItemRepository)
    {
        _featureItemRepository = featureItemRepository;
    }

    public async Task<List<FeatureItemDto>> GetTopFeatureItemsAsync(int count)
    {
        var featureItems = await _featureItemRepository.GetTopFeatureItemsAsync(count);
        return ObjectMapper.Map<List<FeatureItem>, List<FeatureItemDto>>(featureItems);
    }
}