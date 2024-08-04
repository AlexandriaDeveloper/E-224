namespace E_224.Core;

public class AccountBabMowazani
{
    public AccountBabMowazani(BabMowazani babMowazani, Account account)
    {
        BabMowazani = babMowazani;
        Account = account;
    }
    public int BabMowazaniId { get; set; }
    public int AccountId { get; set; }
    public BabMowazani BabMowazani { get; set; }
    public Account Account { get; set; }
}
