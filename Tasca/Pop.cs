public  class Pop : Animal
{
    public static Random rPeix = new();

    public (int x, int y) Posicio {get; private set;}

    public (int dx, int dy) Direccio {get; private set;}

    public bool EsViu {get; private set;}

    public Pop((int x, int y) posicioInicial) : base(posicioInicial)
    {
      Posicio = posicioInicial;
      EsViu = true;
      Direccio = CanviarDireccioPop();

      
      
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