using System;
using Volo.Abp.Domain.Entities.Auditing;

public class News : AuditedEntity<Guid>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public DateTime PublishedDate { get; set; }
}