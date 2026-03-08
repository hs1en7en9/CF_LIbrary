using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommonLibraryP.MachinePKG.EFModel
{

    public enum ReportWorkOrderStatus
    {
        undo = 0,
        ongoing = 1,
        pause = 2,
        finish = 3
    }
    public class ReportWorkOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string 工單 { get; set; } = "";

        [Required]
        public string 狀態 { get; set; } = "";

        [Required]
        public DateTime 報工時間 { get; set; } = DateTime.Now;

        [Required]
        public string 報工人員 { get; set; } = "";

        // 新增欄位
        [Required]
        public string 品名 { get; set; } = "";

        [Required]
        public DateTime 排產日 { get; set; }

        public decimal 補料{ get; set; }
        public decimal 餘料 { get; set; }
        public decimal 廢料 { get; set; }
        public decimal 已完成料 { get; set; }
        /// <summary>物料得率% = 100 - (廢料/工單發料量)*100，小數1位，寫入資料庫供後續分析。</summary>
        public decimal 物料得率 { get; set; }
    }
}
