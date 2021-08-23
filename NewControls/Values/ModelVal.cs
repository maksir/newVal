namespace NewControls.Values
{
    public class ModelVal<T> : Val<T>
    {
        private string _name;

        public ModelVal(string name)
        {
            _name = name;
        }

        public override T GetVal(IValProvider vp) => vp.GetModelVal<T>(_name);

        public static ModelVal<T> Create(string name) => new ModelVal<T>(name);
    }
}