namespace NewControls.Values
{
    public class FixVal<T> : Val<T>
    {
        private readonly T _val;

        public FixVal(T val)
        {
            _val = val;
        }

        public override T GetVal(IValProvider vp)
        {
            return _val;
        }
    }
}