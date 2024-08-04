using System.ComponentModel.DataAnnotations;

namespace E_224.Core;

public class Collage
{
    public int Id { get; set; }
    [StringLength(30)]
    public string BoxName { get; set; } = string.Empty;

    public virtual ICollection<Collage>? Collages { get; set; }
}
