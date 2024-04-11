namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            names.Add("BatMan");
            names.Add("SuperMan");
            names.Add("SpiderMan");
            names.Add("Hulk");
            names.Add("Fantastic 4");
            names.Add("Black Panther");
            names.Add("Thor");
            names.Add("Aqua Man");
            names.Add("Iron Man");
            names.Add("HawkEye");
            names.Add("Captain America");
            names.Add("Wolverine");
            names.Add("Venom");
            names.Add("Flash");
            names.Add("Green Lantern");

            var inOrderOfLength = names.OrderBy(X => X.Length);

            foreach(var name in inOrderOfLength)
            {
                Console.WriteLine(name);
            }
        }
    }
}
