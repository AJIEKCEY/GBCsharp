using System;
using System.Globalization;


namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string strCurentDate = (DateTime.Now).ToString("dddd, dd MMMM yyyy", CultureInfo.CreateSpecificCulture("ru-RU"));
            string strLocalTime = (DateTime.Now).ToLocalTime().ToString("hh:mm");


            TimeZoneInfo cstZone = TimeZoneInfo.FindSystemTimeZoneById("UTC-08");
            TimeSpan offset = new TimeSpan(-08, 00, 00);
            TimeZoneInfo SF = TimeZoneInfo.CreateCustomTimeZone(cstZone.Id, offset, cstZone.DisplayName, cstZone.StandardName);
            DateTime cstTime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.Local, SF);


            //Получение из реестра всех таймзон

            //foreach (TimeZoneInfo z in TimeZoneInfo.GetSystemTimeZones())
            //    Console.WriteLine(z.Id);

            //TODO Понять как создать экземпляр даты с определенным часовым поясом чтобы "z" выводил заданный часовой пояс а не локальный.

            //string strSFTime = cstTime.ToString("HH:mm z");
            
            string strSFTime = cstTime.ToString("HH:mm");



            Console.WriteLine("Как тебя зовут?");
            name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}. Сегодня {strCurentDate} - прекрасный день чтобы начать действовать!");
            Console.WriteLine($"Кстати, уже {strLocalTime}, самое время покодить)");
            Console.WriteLine($"А в Сан-Франциско, {strSFTime} -8");
        }
    }
}
