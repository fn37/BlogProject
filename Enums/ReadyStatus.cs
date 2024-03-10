using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CodeWithFilza.Enums
{
    public enum ReadyStatus
    {
        Incomplete,
        [Display(Name ="Production Ready")]
        ProductionReady,
        [Display(Name = "Preview Ready")]
        PreviewReady
    }
}
