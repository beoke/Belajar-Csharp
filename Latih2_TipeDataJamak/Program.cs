namespace Latih2_TipeDataJamak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> angkalist = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine("Elemen pertama: " + angkalist[0]);
            Console.WriteLine("Element terakhir: " + angkalist[angkalist.Count -1]);

            angkalist.Add(6);
            Console.WriteLine("Element baru ditambahkan: " + angkalist[5]);

            angkalist.RemoveAt(2);
            Console.WriteLine("List setelah elemen ketiga dihapus: " + string.Join(", ", angkalist));
        }
    }
}
