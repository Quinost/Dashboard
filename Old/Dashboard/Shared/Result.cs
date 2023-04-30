using System.Globalization;

namespace Dashboard.Shared;
public class Result<T> : ResultBase
{
    public T RetVal { get; set; }

    public static Result<T> Success(T retVal) 
        => new Result<T> { Succeeded = true, RetVal = retVal };

    public static Result<T> Failed(params string[] errors)
    {
        var result = new Result<T> { Succeeded = false };
        if (errors != null)
        {
            result._errors.AddRange(errors);
        }
        return result;
    }
}
public class Result : ResultBase
{
    public static Result Success 
        => new Result() { Succeeded = true };

    public static Result Failed(params string[] errors)
    {
        var result = new Result { Succeeded = false };
        if (errors != null)
        {
            result._errors.AddRange(errors);
        }
        return result;
    }
}

public class ResultBase
{

    internal List<string> _errors = new();
    public bool Succeeded { get; protected set; }

    public IEnumerable<string> Errors => _errors;

    public string ErrorToString() 
        => ToString();

    public override string ToString() 
        => Succeeded ? "Succeeded" : string.Format(CultureInfo.InvariantCulture, "{0} : {1}", "Failed", string.Join(",", Errors.ToList()));
}