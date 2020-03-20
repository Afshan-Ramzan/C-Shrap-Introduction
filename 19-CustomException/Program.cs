using System;
using System.IO;
using System.Runtime.Serialization;
namespace _19_CustomException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadylogedinException("User Already Logged in, no Duplicate session allowed");
            }
            catch (UserAlreadylogedinException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

[Serializable]
public class UserAlreadylogedinException:Exception
{
    public UserAlreadylogedinException() : base()
    {

    }
    public UserAlreadylogedinException(string message):base(message)
    {
        
    }
    public UserAlreadylogedinException(string message,Exception innerException) : base(message,innerException)
    {

    }
    public UserAlreadylogedinException(SerializationInfo info,StreamingContext context):base(info,context)
    {

    }

}