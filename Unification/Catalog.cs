namespace Unification
{
    class Catalog
    {
        private Random _random = new Random();
        private List<Soldier> _firstListSoldiers = new List<Soldier>();
        private List<Soldier> _secondListSoldiers = new List<Soldier>();

        public Catalog()
        {
            AddSoldiers(_firstListSoldiers);
            AddSoldiers(_secondListSoldiers);
        }

        public void RelocateSoldiers()
        {
            var soldiers = _firstListSoldiers.Where(soldier => soldier.Surname.ToUpper().StartsWith("Б")).ToList();

            _firstListSoldiers = _firstListSoldiers.Except(soldiers).ToList();

            _secondListSoldiers = _secondListSoldiers.Concat(soldiers).ToList();
        }

        public void ShowFirstListSoldiers()
        {
            ShowInfo(_firstListSoldiers);
        }

        public void ShowSecondListSoldiers()
        {
            ShowInfo(_secondListSoldiers);
        }

        private void ShowInfo(List<Soldier> soldiers)
        {
            foreach (var soldier in soldiers)
            {
                soldier.ShowInfo();
            }

            Console.WriteLine();
        }

        private void AddSoldiers(List<Soldier> soldiers)
        {
            int numberSoldiers = 10;

            List<string> surnames = new List<string>() { "Иванов", "Смирнов", "Кузнецов", "Попов", "Васильев", "Петров", "Соколов", "Михайлов", "Новиков",
                "Федоров","Барышников","Богушевский","Барских","Барыкин","Беляев","Бердяев","Березкин","Бирюков" };
            List<string> names = new List<string>() { "Сергей", "Дмитрий", "Андрей", "Алексей", "Максим", "Иван", "Роман", "Евгений", "Михаил", "Артем" };

            for (int i = 0; i < numberSoldiers; i++)
            {
                soldiers.Add(new Soldier(surnames[_random.Next(surnames.Count)], names[_random.Next(names.Count)]));
            }
        }
    }
}