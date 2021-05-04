using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Dashboard.Server.Models
{
    public class Result<T>
    {
        public T RetVal { get; set; }
        public bool Succeeded { get; protected set; }

        private List<string> _errors = new List<string>();

        public IEnumerable<string> Errors => _errors;

        public static Result<T> Success(T retVal)
        {
            return new Result<T> { Succeeded = true, RetVal = retVal };
        }

        public static Result<T> Failed(params string[] errors)
        {
            var result = new Result<T> { Succeeded = false };
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
    public class Result
    {
        public bool Succeeded { get; protected set; }

        private List<string> _errors = new List<string>();

        public IEnumerable<string> Errors => _errors;

        public static Result Success => new Result() { Succeeded = true };

        public static Result Failed(params string[] errors)
        {
            var result = new Result { Succeeded = false };
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
}
