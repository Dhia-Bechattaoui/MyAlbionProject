using System;
using Volo.Abp.Domain.Entities.Auditing;

public class FeatureItem : AuditedEntity<Guid>
{
    public string Name { get; set; }
    public int TrackCount { get; set; }
}