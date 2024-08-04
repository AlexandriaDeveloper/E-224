using System.ComponentModel.DataAnnotations;

namespace E_224.Core;

public class BabMowazani
{
    public int Id { get; set; }
    [MaxLength(200)]
    public string DailyName { get; set; } = string.Empty;
    public virtual ICollection<AccountBabMowazani>? AccountBabMowazanis { get; set; }

}
