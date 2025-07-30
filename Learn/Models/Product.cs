using System.IO;

public class Product
{
    public class People
    {
        public string Name { get; set; }
        public string UserName { get; set; }
    }


    static void Main()
    {
        var person = new People
        {
            Name = "John Doe",
            UserName = "johndoe"
        };

        using (FileStream fs = new FileStream("./person.dat", FileMode.Create))
        {
            var writer = new BinaryWriter(fs);
            writer.Write(person.Name);
            writer.Write(person.UserName);
        }
    }
}