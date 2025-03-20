using System;

class Sad
{
    public class Champion
    {
        public string name = "Yumi";
        public int age = 178;
        public double hp = 350;
        public byte level = 1;
        public double attack_range = 200;
        public double damage_physical = 78;
        public double damage_magic = 134;
        public double tenacity = 2;
        public double armor = 30;
        public double magic_resist = 37;
        public double vampire = 0;
        public double speed = 400;
        public int money = 450;
        public double health_regen = 1.7;
        public double mana_regen = 2.3;

        public void Print()
        {
            Console.WriteLine($"Ім'я: {name}");
            Console.WriteLine($"Вік: {age}");
            Console.WriteLine($"Здоров'я: {hp}");
            Console.WriteLine($"Рівень: {level}");
            Console.WriteLine($"Дальність атаки: {attack_range}");
            Console.WriteLine($"Фізична атака: {damage_physical}");
            Console.WriteLine($"Магічна атака: {damage_magic}");
            Console.WriteLine($"Стійкість: {tenacity}");
            Console.WriteLine($"Броня: {armor}");
            Console.WriteLine($"Магічний захист: {magic_resist}");
            Console.WriteLine($"Швидкість: {speed}");
            Console.WriteLine($"Золото: {money}");
            Console.WriteLine($"Регенерація здоров'я: {health_regen}");
            Console.WriteLine($"Регенерація мани: {mana_regen}");
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Гра - League of Legends");

        Champion champ = new Champion();


        champ.Print();
    }
}
