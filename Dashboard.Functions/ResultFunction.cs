using System.Globalization;

namespace Dashboard.Functions;
public class ResultFunction<T>
{
    public T RetVal { get; set; }
    public bool Succeeded { get; protected set; }

    private List<string> _errors = new List<string>();

    public IEnumerable<string> Errors => _errors;

    public static ResultFunction<T> Success(T retVal)
    {
        return new ResultFunction<T> { Succeeded = true, RetVal = retVal };
    }

    public static ResultFunction<T> Failed(params string[] errors)
    {
        var result = new ResultFunction<T> { Succeeded = false };
        if (errors != null)
        {
            result._errors.AddRange(errors);
        }
        return result;
    }

    public string ErrorToString() => ToString();

    public override string ToString()
    {
        return Succeeded ?
               "Succeeded" :
               string.Format(CultureInfo.InvariantCulture, "{0} : {1}", "Failed", string.Join(",", Errors.ToList()));
    }
}
public class ResultFunction
{
    public bool Succeeded { get; protected set; }

    private List<string> _errors = new List<string>();

    public IEnumerable<string> Errors => _errors;

    public static ResultFunction Success => new ResultFunction() { Succeeded = true };

    public static ResultFunction Failed(params string[] errors)
    {
        var result = new ResultFunction { Succeeded = false };
        if (errors != null)
        {
            result._errors.AddRange(errors);
        }
        return result;
    }

    public string ErrorToString() => ToString();

    public override string ToString()
    {
        return Succeeded ?
               "Succeeded" :
               string.Format(CultureInfo.InvariantCulture, "{0} : {1}", "Failed", string.Join(",", Errors.ToList()));
    }
}
