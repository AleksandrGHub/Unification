namespace Unification
{
     class Soldier
    {
        public Soldier(string surname, string name)
        {
            Surname = surname;
            Name = name;
        }

        public string Surname { get; private set; }
        public string Name { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Surname} {Name}");
        }
    }
}