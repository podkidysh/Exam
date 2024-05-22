using Exam;
using Exam.Classes;
using Exam.Interfaces;

ISayIFU sayIFU = new SayInfoForUser(); // Создание экземпляра класса для вывода информации

for (int i = 0; i <= 200; i++) // цикл нужен для того, чтобы каждый раз при вводе данных следующего пользователя не перезапускать программу
{
    sayIFU.SayInfo();
}
