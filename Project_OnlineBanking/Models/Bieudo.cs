namespace Project_OnlineBanking.Models;

public class Bieudo
{
    public int month { get; set; }


    public int AmountUp { get; set; }

    public int AmountDown { get; set;}

    public Bieudo(int month, int AmountUp, int AmountDown)
    {
        this.month = month;
        this.AmountUp = AmountUp;
        this.AmountDown = AmountDown;
    }

}
