namespace PaymentGateway.Api.DTO.Response;

[Serializable]
public class ResponseBase
{
    public bool IsSuccess { get; set; }
    public object Data { get; set; }
    public string ErrorMessage { get; set; }
    public string DetailErrorMessage { get; set; }

    private ResponseBase()
    {
    }

    public static ResponseBase Success()
    {
        return new ResponseBase
        {
            IsSuccess = true
        };
    }

    public static ResponseBase Success(object data)
    {
        return new ResponseBase
        {
            IsSuccess = true,
            Data = data
        };
    }

    public static ResponseBase Error(string msg, string detailMsg = "")
    {
        return new ResponseBase
        {
            IsSuccess = false,
            ErrorMessage = msg,
            DetailErrorMessage = detailMsg,
        };
    }
}

