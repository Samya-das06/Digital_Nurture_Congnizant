namespace ConsoleWebApiApp;

public class SoapSupport
{
    public Task<string> GetFakeSoapDataAsync()
    {
        // Simulate SOAP XML-based logic
        return Task.FromResult("<soap>Response from SOAP service</soap>");
    }
}

