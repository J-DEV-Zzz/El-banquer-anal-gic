namespace El_banquer_analògic;

public class Guardiola
{
    private int dinersClients = 0;
    
    public void PosarDiners(int diners)
    {
        dinersClients += diners;
    }

    public void QuantsDinersTinc(int dinerstinc)
    {
        dinersClients = dinerstinc;
        Console.WriteLine($"S'han posat {dinersClients} diners a la guardiola.");
    }
}
