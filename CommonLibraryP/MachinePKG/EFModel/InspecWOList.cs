using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CommonLibraryP.MachinePKG.EFModel
{
    public class InspecWOList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; } // 自動增加號碼

        [Required]
        public string 工單 { get; set; } = "";

        [Required]
        public string 點檢單號 { get; set; } = "";

        [Required]
        public InspectionFormStatus 狀態 { get; set; } = InspectionFormStatus.UndoCheck;

        public DateTime 報工時間 { get; set; }

        public DateTime 產生時間 { get; set; }

        /// <summary>品檢人員（原欄位名為報工人員，已改為品檢人員；儲存品檢表單時寫入登入者）</summary>
        public string 品檢人員 { get; set; } = "";

        /// <summary>品檢單完成時間（按下儲存時的日期時間）。畫面「點檢時間」欄顯示此值。因 點檢時間 為 int 無法存日期，故另加此欄。</summary>
        public DateTime? 完成時間 { get; set; }

        [Required]
        public string? Type { get; set; }

        // 新增改善時間
        public DateTime? 改善時間 { get; set; }

        /// <summary>點檢時間（資料庫型態為 int，非日期時間，無法用於顯示品檢完成時刻）</summary>
        public int 點檢時間 { get; set; }

        /// <summary>檢查結果：true 合格、false 不合格、null 未檢驗</summary>
        public bool? result { get; set; }

        public string? 錯誤代碼 { get; set; }   // 新增
        public string? 分類 { get; set; }       // 新增


        public string? 錯誤項目 { get; set; }

        public string? 備註 { get; set; }

        public string? 責任單位 { get; set; }
        public int? 檢查數量 { get; set; }
        public int? NG數量 { get; set; }
    }
}
