namespace pruebas;

public class Enemy
{
    public bool flag = false;
}

public class Enemy1 : Enemy
{
    public bool getFlag()
    {
        return base.flag;
    }
}

public class Enemy2 : Enemy
{
    public Enemy2()
    {
        base.flag = true;
    }
    public bool getFlag()
    {
        return base.flag;
    }
}
public class Inheritance
{
    static void Main(string[] args)
    {
        //Console.WriteLine(Enemy2.getFlag());
        //Console.WriteLine(Enemy1.getFlag());
        
        setArrayInt(new []{0,1,4,1,3,5,3});
    }

    public static int[] setArrayInt(int[] array)
    {
        /*
        bool bandera = true;
        int cont=0;
        int[] newArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j >= 0; j++)
            {
                if (j >= 0)
                {
                    if (array[i] == array[j])
                    {
                        bandera = false;
                    }
                }
            }

            if (bandera)
            {
                newArray[cont] = array[i];
                Console.WriteLine(array[i]);
                cont++;
            }
            
            bandera = true;
        }
        return newArray;*/

        bool bandera = true;
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i; j >= 0; j--)
            {
                if (j > 0 && array[i] == array[j-1])
                {
                    bandera = false;
                }
            }

            if (bandera)
            {
                Console.WriteLine(array[i]+"--");
            }
            bandera = true;
        }

        return null;
    }
}