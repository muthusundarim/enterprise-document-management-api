using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Document : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string FileName { get; set; } = string.Empty;

        public string BlobUrl { get; set; } = string.Empty;

        public string Department { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;

        public string Tags { get; set; } = string.Empty;

        public long FileSize { get; set; }

        public string ContentType { get; set; } = string.Empty;

        public DocumentStatus Status { get; set; }
    }
}
