namespace dizilerarraymethod;
class Program
{
    static void Main(string[] args)
    {
        //Sort
        int[] sayidizizi = {23,12,86,72,3,11,14,17};
        Console.WriteLine("**** Sirasiz Dizim ****");

        foreach (var sayi in sayidizizi)
        {
            Console.WriteLine(sayi);
        }
        Console.WriteLine("**** Sirali Dizim ****");
        Array.Sort(sayidizizi);
        foreach (var sayi in sayidizizi)
        {
            Console.WriteLine(sayi);
        }

        //Clear
        //Console.WriteLine("**** Array Clear ****");
            
        //Array.Clear(sayidizizi,2,2);
        //foreach (var sayi in sayidizizi)
       // {
        //    Console.WriteLine(sayi);
        //}    
        //Reverse

        Console.WriteLine("**** Array Reverse ****");

        Array.Reverse(sayidizizi);
        foreach (var sayi in sayidizizi)
        {
            Console.WriteLine(sayi);
        }

        //IndexOf

        Console.WriteLine("**** Array IndexOf");
        
        Console.WriteLine(Array.IndexOf(sayidizizi,86));
        Console.WriteLine(Array.IndexOf(sayidizizi,72));
        Console.WriteLine(Array.IndexOf(sayidizizi,23));
        Console.WriteLine(Array.IndexOf(sayidizizi,17));
        Console.WriteLine(Array.IndexOf(sayidizizi,14));
        Console.WriteLine(Array.IndexOf(sayidizizi,12));
        Console.WriteLine(Array.IndexOf(sayidizizi,11));
        Console.WriteLine(Array.IndexOf(sayidizizi,3));

        //Resize
        Console.WriteLine("**** Array Risize");


        Array.Resize<int>(ref sayidizizi,9);
        sayidizizi[8] = 77;

        foreach (var sayi in sayidizizi)
        {
            Console.WriteLine(sayi);
        }

        int[] dizi = new int[15];

    }
}
