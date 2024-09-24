using Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domains.Interfaces
{
    public interface IManager
    {
        void Add();
        List<Student> List();
    }
}
