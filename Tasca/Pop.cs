public class Pop
{
    public static Random rPeix = new();

    public (int x, int y) Posicio {get; private set;}

    public (int dx, int dy) Direccio {get; private set;}

    public bool EsViu {get; private set;}

    public Pop() 
    {
      Posicio = PosicioInicialPop(rPeix);
      EsViu = true;
      Direccio = CanviarDireccioPop();
      
      
    }

    public  (int x, int y)    PosicioInicialPop(Random random)//arregla 
    {
        int[] lateral ={0,19};

        (int x,int y)[] Posicions = {(random.Next(20),lateral[random.Next(1)]),(lateral[random.Next(1)],random.Next(20))}; 
        
        return Posicions[random.Next(2)];

    }

    public   (int dx, int dy)  CanviarDireccioPop()
    {

        if (Posicio == (0,0))
        {
            return (0,1);
        }
        else if (Posicio == (19,0))
        {
            return (1,0);
        }
        else if (Posicio == (19,19))
        {
            return (0,-1);
        }
       else
            return (-1,0);    
    }


    public virtual void MourePop()
    {
        
        Posicio = (Posicio.x + Direccio.dx, Posicio.y + Direccio.dy);
        
    }

    public void DinarGallec()
    {
        EsViu = false;
    }


}