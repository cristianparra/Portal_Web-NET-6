using System.Runtime.Serialization;

namespace PortalWeb.Domain
{
    public class Response<T>
    {
        #region Constructors

        public Response()
        {
            Code = "200";
            Message = null;
            Result = default(T);
        }

        #endregion Constructors

        #region Properties

        [DataMember]
        public string Code
        {
            get; set;
        }

        [DataMember]
        public T? Result
        {
            get; set;
        }

        [DataMember]
        public string? Message
        {
            get; set;
        }

        #endregion Properties

        public static Response<T> OK()
        {
            return new Response<T>() { Code = "200", Message = "OK" };
        }

        public static Response<T> Error()
        {
            return new Response<T>() { Code = "400", Message = "Error 400, the class does not have the correct format" };
        }

        public static Response<T> Error(string? message)
        {
            message ??= "Error 400, the class does not have the correct format";
            return new Response<T>() { Code = "400", Message = message };
        }
    }
}