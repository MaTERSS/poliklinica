/*
Вы заходите в поликлинику и видите огромную очередь из пациентов, вам нужно рассчитать время ожидания в очереди.  

Формально: 
Пользователь вводит кол-во людей в очереди.  
Фиксированное время приема одного человека всегда равно 10 минутам.  
Пример ввода: Введите кол-во пациентов: 14
Пример вывода: "Вы должны отстоять в очереди 2 часа и 20 минут."

Примечание:
- при расчетах надо использовать только переменные. Если число не присваивается переменной, то в большинстве случаев это число магическое (исключение 0 и 1, но не во всех ситуациях).
- повторные расчеты так же стоит выносить в переменные
*/

using System;
using System.Text;

namespace CSLight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во людей в очереди:");
            int people = Convert.ToInt32(Console.ReadLine());                   
            int minutesToReceivePatients = 10;
            int time = people * minutesToReceivePatients;
            int minutesInHour = 60;
            int secondsInMinutes = 60;
            int hoursOfWaiting = time / minutesInHour;
            int minutesOfWaiting = time % secondsInMinutes;
            Console.WriteLine("Вы должны стоять в очереди:" + hoursOfWaiting + " час(а/ов) и " + minutesOfWaiting + " минут");
        }
    }
}
