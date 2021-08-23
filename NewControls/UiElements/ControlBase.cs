namespace NewControls.UiElements
{
    using Values;

    public abstract class ControlBase
    {
        public Val<string> Name { get; set; }
        
        public Val<string> ScopeName { get; set; }
    }
}