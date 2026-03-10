using System.ComponentModel.DataAnnotations;

namespace CommonLibraryP.MachinePKG.EFModel
{
    public class WorkorderStopReason
    {
        [Key]
        public string 停工原因代碼 { get; set; } = string.Empty;

        public string 停工原因名稱 { get; set; } = string.Empty;

        public string 停工分類 { get; set; } = string.Empty;

        public string? 備註 { get; set; }
    }
}

