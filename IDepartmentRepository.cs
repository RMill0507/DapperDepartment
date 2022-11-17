using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDemo
{
    public interface IDepartmentRepository
    {
       public IEnumerable<Department> GetAllDepartments();// IEnumerable only needs to load only a certain portion of the list
    }
}
