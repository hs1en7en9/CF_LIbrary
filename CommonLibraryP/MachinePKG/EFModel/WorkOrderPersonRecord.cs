using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommonLibraryP.MachinePKG.EFModel
{
    public class WorkOrderPersonRecord
    {
        [Key, Column(Order = 0)]
        public string 姓名 { get; set; }

        [Key, Column(Order = 1)]
        public string 工單 { get; set; }

        [Key, Column(Order = 2)]
        public DateTime 時間 { get; set; }

        [Required]
        public string 狀態 { get; set; }

        /// <summary>人員ID，與 Personnal 勾稽，供生產績效統計查詢。</summary>
        public string? 人員ID { get; set; }

        /// <summary>生產組別，與工單生產組別勾稽，供生產績效統計查詢。</summary>
        public string? 生產組別 { get; set; }
    }
}
