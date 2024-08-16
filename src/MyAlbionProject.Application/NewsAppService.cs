using AutoMapper.Internal.Mappers;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

public class NewsAppService : ApplicationService, INewsAppService
{
    private readonly INewsRepository _newsRepository;

    public NewsAppService(INewsRepository newsRepository)
    {
        _newsRepository = newsRepository;
    }

    public async Task<List<NewsDto>> GetRecentNewsAsync()
    {
        var news = await _newsRepository.GetRecentNewsAsync();
        return ObjectMapper.Map<List<News>, List<NewsDto>>(news);
    }
}