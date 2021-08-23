namespace NewControls.Values
{
    public abstract class Val<T> : IVal
    {
        public abstract T GetVal(IValProvider vp);

        object IVal.GetVal(IValProvider vp) => GetVal(vp);

        public static implicit operator Val<T>(T val) => new FixVal<T>(val);
    }
}