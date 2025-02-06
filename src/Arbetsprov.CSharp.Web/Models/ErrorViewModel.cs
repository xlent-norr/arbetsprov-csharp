namespace Arbetsprov.CSharp.Web.Models;

public class ErrorViewModel
{
    public required string RequestId { get; init; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}