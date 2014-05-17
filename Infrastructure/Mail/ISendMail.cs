using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Mail
{
    public interface ISendMail
    {
        bool Send(string[] addresses, string subject, string body);
    }
}
