using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StarSubsSheet5.Models
{

    public enum SubName
    {
        TheBrahms,
        TheTchaikovsky,
        TheMahler,
        TheStrauss,
        TheRachmaninoff
    }
    public enum Size
    {
        OneHitWonder,
        BList,
        AList,
        SuperStar
    }
    public enum Meal
    {
        None,
        DrinkChips,
        DrinkCookies
    }


    public class Sub
    {

        public string MealNumber { get; set; }
        public SubName SubName { get; set; }
        public Size Size { get; set; }
        public Meal Meal { get; set; }
    }
}