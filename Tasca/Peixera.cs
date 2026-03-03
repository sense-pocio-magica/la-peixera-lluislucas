public class Peixera
{
    public (int X, int Y) MidaPeixera {get; private set;}

    public List<Animal> Aquari = new();

    public  Peixera()
    {
       MidaPeixera = (20,20);
        
    }

    public virtual (int x, int y) escollirPosicioInicialAnimal (Random r1 )
    {
        int x = r1.Next(0,MidaPeixera.X);

        int y = r1.Next(0,MidaPeixera.Y);

        return (x,y);
        
    }
}