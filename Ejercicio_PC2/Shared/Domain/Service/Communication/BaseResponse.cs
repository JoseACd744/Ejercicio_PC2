namespace Ejercicio_PC2.Shared.Domain.Service.Communication;

public abstract class BaseResponse<T>
{
    protected BaseResponse(string message)
    {
        Success = false;
        Message = message;
        Resource = default;
    }
    protected BaseResponse(T resource)
    {
        Success = true;
        Message = string.Empty;
        Resource = resource;
    }

    
    public bool Success { get; protected set; }
    public string Message { get; protected set; }
    public T Resource { get; protected set; }
}