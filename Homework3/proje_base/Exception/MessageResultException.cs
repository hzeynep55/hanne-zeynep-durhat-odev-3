using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_base.Exception
{
    public class MessageResultException : SystemException
    {
        public MessageResultException()
        {
        }

        public MessageResultException(string message, System.Exception ex) : base(message)
        {
        }

        public MessageResultException(string message, SystemException inner) : base(message, inner)
        {
        }
    }
}
