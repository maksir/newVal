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
                Name = "ButtonAction",
                ScopeName = null,
                Label = "Закрыть",
                Value = 44
            };
            
            // Кнопка, где лейбл и значение берутся из модели
            var bModel = new Button()
            {
                Name = "ButtonAction",
                ScopeName = null,
                Label = ModelVal<string>.Create("ActionLabel"),
                Value = ModelVal<int>.Create("ActionValue")
            };
        }
    }
}