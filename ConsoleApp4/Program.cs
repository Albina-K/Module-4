using System;

class MainClass
{
    static void Main(string[] args)
    {
        (string Name, string Lastname, string Login, int LoginLength, bool HasPet, double Age, string[] favcolore) User;

        for (int k = 0; k < 3; k++)
        {
            Console.WriteLine("Введите имя");
            User.Name = Console.ReadLine();

            Console.WriteLine("Введите фамилию");
            User.Lastname = Console.ReadLine();

            Console.WriteLine("Введите логин");
            User.Login = Console.ReadLine();
            User.LoginLength = User.Login.Length;

            Console.WriteLine("Есть ли у вас животные? Да или Нет");
            var result = Console.ReadLine();
            if (result == "Да")
            {
                User.HasPet = true;
            }
            else
            {
                User.HasPet = false;
            }
            Console.WriteLine("Введите возраст пользователя");
            User.Age = double.Parse(Console.ReadLine());

            User.favcolore = new string[3];
            Console.WriteLine("Введите три любимых цвета");
            for (int i = 0; i < User.favcolore.Length; i++)
            {
                User.favcolore[i] = Console.ReadLine();
            }
        }
    }
}