namespace OOPFirst
{

    //Создать класс игрока, с полями, содержащими информацию
    //об игроке и методом, который выводит информацию на экран.
    //В классе обязательно должен быть конструктор.

    class Character
    {
        private float HealthCharacter { get; set; }
        private float ArmorBar { get; set; }
        private float DamageCharacter { get; set; }
        private float SpeedMove { get; set; }
        private string NamePerson { get; set; }

        public Character(float healthCharacter, float armorBar, float damageCharacter, float speedMove, string namePerson)
        {
            HealthCharacter = healthCharacter;
            ArmorBar = armorBar;
            DamageCharacter = damageCharacter;
            SpeedMove = speedMove;
            NamePerson = namePerson;
        }

        public void showInfo()
        {
            Console.WriteLine($"Здоровье - {HealthCharacter}");
            Console.WriteLine($"Броня - {ArmorBar}");
            Console.WriteLine($"Урон - {DamageCharacter}");
            Console.WriteLine($"Скорость - {SpeedMove}");
            Console.WriteLine($"Имя - {NamePerson}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var character = new Character(100, 200, 20, 10, "Alex");
            character.showInfo();
        }
    }
}