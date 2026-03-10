public class Peixera
{

/*
        -mida
        -llista Aquari
        -posicions
        -potser mètodes tipus afegir/eliminar animal
        -comprovar límits*/

    protected static Random random = new();

    public (int X, int Y) MidaPeixera {get; private set;}

    public List<Animal> Aquari {get; private set;}

    public  Peixera()
    {
       MidaPeixera = (20,20);
       Aquari = new List<Animal>();
        
    }

    //arreglar

    public  virtual (int x, int y) EscollirPosicioInicialAnimal (Animal altre, Random r1 )
    {
        if (altre == Pop )
        {
        int[] lateral ={0,19};

        (int x,int y)[] Posicions = {(r1.Next(20),lateral[r1.Next(1)]),(lateral[r1.Next(1)],r1.Next(20))}; 

        while(comprovarPosicio( (int x,int y) Posicions[] ) == false)
        {
             x = r1.Next(0,MidaPeixera.X);

             y = r1.Next(0,MidaPeixera.Y);
        }
        
        return Posicions[r1.Next(2)];
            
        }
        else
        {
       
        int x = r1.Next(0,MidaPeixera.X);

        int y = r1.Next(0,MidaPeixera.Y);
       
        while(comprovarPosicio((x,y)) == false)
        {
             x = r1.Next(0,MidaPeixera.X);

             y = r1.Next(0,MidaPeixera.Y);
        }

        return (x,y);
        }
        
    }

    /*public  override (int x, int y) PosicioInicialPop(Random random)//arregla 
    {
        int[] lateral ={0,19};

        (int x,int y)[] Posicions = {(random.Next(20),lateral[random.Next(1)]),(lateral[random.Next(1)],random.Next(20))}; 
        
        return Posicions[random.Next(2)];

    }*/

    public virtual bool comprovarPosicio((int x, int y) valor)
    {
        foreach (Animal a in Aquari)
        {
            if( a.Posicio == valor)
            {
                return false;
            }
        }

        return true;
    }


    public void EliminarAnimal(Animal animal)
    {
            animal.Morir();
            Aquari.Remove(animal);
    }

}