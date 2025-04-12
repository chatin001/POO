namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song(album:"Recordando",title:"Salsa 80", description:"Salsa para conocedores", genre:"Salsa");

            Console.WriteLine(song1.PublicAlbum);
            Console.WriteLine(song1.PublicTitle);
            Console.WriteLine(song1.PublicDescription);
            Console.WriteLine(song1.PublicGenre);

        }
    }
}
