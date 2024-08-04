using System.Collections;

namespace E_224.Core;

public class Box
{
    public Box(Collage collage)
    {
        Collage = collage;

    }
    public int Id { get; set; }
    public int CollageId { get; set; }
    public Collage Collage { get; set; }
    public virtual ICollection<Form>? Forms { get; set; }
}
