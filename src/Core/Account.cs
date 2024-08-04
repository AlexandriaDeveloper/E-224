using System.ComponentModel.DataAnnotations;

namespace E_224.Core;

public class Account
{
    public int Id { get; set; }
    [StringLength(30)]
    public string AccountName { get; set; } = string.Empty;
    [StringLength(15)]
    public string AccountNumber { get; set; } = string.Empty;
    public int AccountCreditParentId { get; set; }
    public bool Default { get; set; } = false;
    //credit or debit
    public char AccountType { get; set; }

    public virtual ICollection<AccountBabMowazani>? AccountBabMowazanis { get; set; }
}
