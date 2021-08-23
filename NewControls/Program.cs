using System;

namespace NewControls
{
    using UiElements;
    using Values;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            // Стандартная кнопка с фиксированными лейблом и значением
            var bNormal = new Button()
            {
                Name = "ButtonAction", // фиксированная привязка к свойству модели
                ScopeName = null, // без скоупа
                Label = "Закрыть", //фиксированный лейбл
                Value = 44, // фиксированное значение
                Color = "green" // фиксированный цвет кнопки
            };
            
            // Кнопка, где лейбл и значение берутся из модели, а цвет из темы оформления
            var bModel = new Button()
            {
                Name = "ButtonAction",
                ScopeName = null,
                Label = ModelVal<string>.Create("ActionLabel"),
                Value = ModelVal<int>.Create("ActionValue"), 
                Color = ThemeVal<string>.Create("btn.default")
            };
        }
    }
}