using System;
using Volo.Abp.Application.Dtos;

public class FeatureItemDto : EntityDto<Guid>
{
    public string Name { get; set; }
    public int TrackCount { get; set; }
}