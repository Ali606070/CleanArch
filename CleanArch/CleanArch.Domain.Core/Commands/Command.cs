using CleanArch.Domain.Core.Event;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Domain.Core.Commands
{
    public abstract class Command :Message
    {
        public DateTime DateTime { get;protected set; }
        protected Command()
        {
            DateTime = DateTime.Now;
        }
    }
}
