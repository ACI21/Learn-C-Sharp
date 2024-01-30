class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException() : base()
    {
    }

    public SaldoInsuficienteException(string message) : base(message)
    {
    }
}
