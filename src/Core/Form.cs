using System.ComponentModel.DataAnnotations;

namespace E_224.Core;

public class Form
{
    public int Id { get; set; }
    public int CollageId { get; set; }
    public int? BoxId { get; set; }
    public int DailyId { get; set; }
    [StringLength(10)]
    public string Num55 { get; set; } = string.Empty;
    [StringLength(10)]
    public string Num224 { get; set; } = string.Empty;
    //بند الصرف  موانه- صناديق- دائن
    public Expenditure Expenditure { get; set; }
    public int AccountId { get; set; }
    public decimal AccountValue { get; set; }
    public Account? Account { get; set; }
    public Box? Box { get; set; }
    public Daily? Daily { get; set; }

    //بالطبع! “بند الصرف” بالإنجليزية يُترجم إلى “expenditure/expense item” 1. هل هناك شيء آخر يمكنني مساعدتك فيه؟ 
}
