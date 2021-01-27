﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryModels
{
    public interface IAuditedModel
    {
        public int? CreatedByUserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? LastModifiedUserId { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
