using System;
using Volo.Abp.Application.Dtos;

public class NewsDto : EntityDto<Guid>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishedDate { get; set; }
}
