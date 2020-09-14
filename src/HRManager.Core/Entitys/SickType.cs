using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace HRManager.Entitys
{
    public class SickType:Entity<Guid>,IHasCreationTime
    {
        public SickType()
        {
            this.Id = Guid.NewGuid();
            this.SickName = string.Empty;
        }
        //病假类型Id
        [StringLength(50)]
        public new Guid Id { get; set; }
        public string SickName { get; set; }
        public DateTime CreationTime { get ; set; }
    }
}
