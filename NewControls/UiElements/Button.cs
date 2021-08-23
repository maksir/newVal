namespace NewControls.UiElements
{
    using Values;

    public class Button : ControlBase
    {
        public Val<string> Label { get; set; }
        
        public Val<int> Value { get; set; }
        
        public Val<string> Styles { get; set; }
        
        public Val<string> Color { get; set; }
    }
}