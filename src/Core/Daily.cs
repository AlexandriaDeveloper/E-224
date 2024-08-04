using System.ComponentModel.DataAnnotations;

namespace E_224.Core;

public class Daily
{
    public int Id { get; set; }
    [MaxLength(300)]
    public string DailyName { get; set; } = string.Empty;
    public DateTimeOffset DailyDate { get; set; }

    public virtual ICollection<Form>? Forms { get; set; }
}
