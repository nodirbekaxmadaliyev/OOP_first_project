internal class Program
{
    private static void Main(string[] args)
    {
        Talaba talaba = new Talaba();
        Console.Write("Talabaning Id sini kiriting : ");
        talaba.Id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Talabaning ismini sini kiriting : ");
        talaba.Name = Console.ReadLine();

        Console.WriteLine($"\nTalabaning Idsi : {talaba.Id} va ismi : {talaba.Name}");

    }
}
public class Talaba
{
    public int Id { get; set; }
    public string Name { get; set; }
}