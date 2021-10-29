using System;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Minion> lst = new List<Minion>();
            
            Console.Write("Name of 1st minion: ");
            string name = Console.ReadLine();
            Console.Write("Age of 1st minion: ");
            int age = Int32.Parse(Console.ReadLine() ?? string.Empty);

            Minion firstMinion = new Minion(name, age);
            lst.Add(firstMinion);
            
            Console.Write("\nName of 2nd minion: ");
            name = Console.ReadLine();
            Console.Write("Age of 2nd minion: ");
            age = Int32.Parse(Console.ReadLine() ?? string.Empty);

            Minion secondMinion = new Minion(name, age);
            lst.Add(secondMinion);
            
            Console.Write("\nName of 3rd minion: ");
            name = Console.ReadLine();
            Console.Write("Age of 3rd minion: ");
            age = Int32.Parse(Console.ReadLine() ?? string.Empty);

            Minion thirdMinion = new Minion(name, age);
            lst.Add(thirdMinion);

            int i = 1;
            foreach (var minion in lst)
            {
                Console.Write($"\n{i++}. {minion.Name} - age: {minion.Age}" );
            }
            
            // == СМЕНА ИМЕНИ == //  
            Console.Write("\n\nChange name of minion by index = ");
            int index = int.Parse(Console.ReadLine() ?? string.Empty) - 1;
            Console.Write("New name: ");
            lst.Get(index).Name = Console.ReadLine();
            
            i = 1;
            Console.WriteLine();
            foreach (var minion in lst)
            {
                Console.WriteLine($"{i++}. {minion.Name} - age: {minion.Age}" );
            }
            
            // == УДАЛЕНИЕ == //  
            Console.Write("\n\nDelete some minion by id = ");
            index = int.Parse(Console.ReadLine() ?? string.Empty) - 1;
            lst.RemoveAt(index);
            
            i = 1;
            Console.WriteLine();
            foreach (var minion in lst)
            {
                Console.WriteLine($"{i++}. {minion.Name} - age: {minion.Age}" );
            }
        }
    }
}