using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentRiskScore.Exceptions
{
    public class IdDoesNotExistException:Exception
    {
        public IdDoesNotExistException():base(){}  
        public IdDoesNotExistException(string message):base(message){}
        public IdDoesNotExistException(string message, Exception innerException):base(message, innerException){}
    }

}
