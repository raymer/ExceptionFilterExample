using ExceptionFilterExample.Core.Exceptions;

namespace ExceptionFilterAttribute.Business
{
    public class MyService
    {
        public void DoThing()
        {
            throw new BadRequestException("Something bad happened.");
        }
    }
}
