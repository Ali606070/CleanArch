using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Application.ViewModels
{
    public class CoursViewModel
    {
        public IEnumerable<Course> courses { get; set; }
    }
}
