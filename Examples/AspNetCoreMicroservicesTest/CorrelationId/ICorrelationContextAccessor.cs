namespace AspNetCoreMicroservicesTest.CorrelationId
{
    public interface ICorrelationContextAccessor
    {
        CorrelationContext CorrelationContext { get; set; }
    }
}
