public class Tortuga : Animal
{
    public ESexe Sexe {get; private set;}

    
    public Tortuga((int x, int y) posicioInicial) : base(posicioInicial)
    {
      
      EscullSexe();
    }

    //No metodes
}