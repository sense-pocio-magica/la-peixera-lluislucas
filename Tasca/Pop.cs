public class Pop
{
    public static Random rPeix = new();

    public (int x, int y) Posicio {get; private set;}

    public (int dx, int dy) Direccio {get; private set;}

    public bool EsViu {get; private set;}

    public Pop((int x, int y) posicioInicial) 
    {
      EsViu = true;
      Direccio = direccioPop();
      
    }

    public void override (int x, int y)  PosicioInicial(Random random)//arregla 
    {
        int[] lateral ={0,19};
        
        //Posicio1: 
        Posicio.X = Posicio.X(random.Next(20)); /*= 0 - 19/*/ 
        Posicio.Y = Posicio.Y(lateral[random.Next(1)]); //= 0 o 19
        //Posicio2: 
        Posicio.X = Posicio.X(lateral[random.Next(1)]); /*= 0 o 19 */ 
        Posicio.Y = Posicio.Y(random.Next(20)); //= 0 - 19
        
    }

    public  (int x, int y)  DireccioPop()
    {

        (((((())))))
        Posicio( 0,0 )  => Direccio(0,1)
        Posicio(19 , 0)    => Direccio(1,0)
        Posicio(19 ,19 )    => Direccio(0,-1)
        Posicio( 0,19 )    => Direccio(-1,0)
        
        
        
    }

    public  (int dx, int dy) direccioPop ()
    {
        int dx = rPeix.Next(-1, 2);
        int dy = rPeix.Next(-1, 2);

        while (dx == 0 && dy == 0)
        {
            dx = rPeix.Next(-1, 2);
            dy = rPeix.Next(-1, 2);
        }

        return (dx, dy);
        
    }

    public void DinarGallec()
    {
        EsViu = false;
    }


}