
namespace AOBMockService.WebAPI.Web.Models
{
    /// <summary>
    /// Response statuses are based on the three statuses presented by the JSend specification:
    /// http://labs.omniti.com/labs/jsend
    /// </summary>
    public enum JSendResponseStatus
    {
        Success,
        Fail,
        Error
    }
}