using System;
using System.Collections.Generic;

public class TelephoneStation
{
    private static TelephoneStation _instance;
    private HashSet<string> _numbers;

    // Приватный конструктор, чтобы предотвратить создание экземпляров извне
    private TelephoneStation()
    {
        _numbers = new HashSet<string>(); // Массив номеров
    }

    // Метод для получения экземпляра класса TelephoneStation
    public static TelephoneStation GetInstance()
    {
        if (_instance == null)
        {
            _instance = new TelephoneStation();
        }
        return _instance;
    }

    // Метод для добавления номеров на станцию
    public void AddNumber(string number)
    {
        _numbers.Add(number);
    }

    // Метод для проверки существования номера на станции
    public bool CheckNumber(string number)
    {
        return _numbers.Contains(number);
    }
}

class Program
{
    static void Main(string[] args)
    {
        TelephoneStation station = TelephoneStation.GetInstance();

        // Добавляем номера на станцию
        station.AddNumber("123456789");
        station.AddNumber("987654321");

        // Пытаемся установить связь с номером
        string numberToCall = "123456789";
        if (station.CheckNumber(numberToCall))
        {
            Console.WriteLine($"Связь с номером {numberToCall} установлена.");
        }
        else
        {
            Console.WriteLine($"Номер {numberToCall} не найден.");
        }
    }
}