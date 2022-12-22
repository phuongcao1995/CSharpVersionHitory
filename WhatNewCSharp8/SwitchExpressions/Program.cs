using System;

namespace SwitchExpressions
{
    public class Plan
    {
        public static string Breakfast(DayOfWeek daysOfWeek)
        {
            switch (daysOfWeek)
            {
                case DayOfWeek.Monday: return "An Com";
                case DayOfWeek.Tuesday: return "An Pho";
                case DayOfWeek.Wednesday: return "An Hu Tieu";
                case DayOfWeek.Thursday: return "An Bun";
                case DayOfWeek.Friday: return "An Chao";
                case DayOfWeek.Saturday: return "An Mi";
                case DayOfWeek.Sunday: return "An Hanh";
                default: throw new NotImplementedException();
            }
        }

        //public static string Breakfast(DayOfWeek daysOfWeek) => daysOfWeek switch
        //{
        //    DayOfWeek.Monday => "An Com",
        //    DayOfWeek.Tuesday => "An Pho",
        //    DayOfWeek.Wednesday => "An Hu Tieu",
        //    DayOfWeek.Thursday => "An Bun",
        //    DayOfWeek.Friday => "An Chao",
        //    DayOfWeek.Saturday => "An Mi",
        //    DayOfWeek.Sunday => "An Hanh",
        //    _ => throw new NotImplementedException(),
        //};

        public static string SetPlan(DayOfWeek daysOfWeek)
        {
            switch (daysOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday: return "Work";
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday: return "Relax";
                default: throw new NotImplementedException();
            }
        }

        //public static string SetPlan(DayOfWeek daysOfWeek) => daysOfWeek switch
        //{
        //    var x when
        //          x == DayOfWeek.Monday
        //       || x == DayOfWeek.Tuesday
        //       || x == DayOfWeek.Wednesday
        //       || x == DayOfWeek.Thursday
        //       || x == DayOfWeek.Friday
        //        => "Work",
        //    var x when
        //          x == DayOfWeek.Saturday
        //       || x == DayOfWeek.Sunday
        //       => "Relax",
        //    _ => throw new NotImplementedException(),
        //};

        class Program
        {
            static void Main(string[] args)
            {
                var food = Plan.Breakfast(DayOfWeek.Tuesday);
                Console.WriteLine(food);

                //var plan = Plan.SetPlan(DayOfWeek.Sunday);
                //Console.WriteLine(plan);

                Console.ReadLine();
            }
        }
     
    }
}
