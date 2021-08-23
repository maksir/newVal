namespace NewControls.Values
{
    // общий контракт для всех типов значений, чтобы можно было делать List<IVal> (пока не знаю зачем)
    public interface IVal
    {
        object GetVal(IValProvider vp);
    }
}