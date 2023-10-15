using LPNR.Core.Data.EntityFramework;
using LPNR.Data.Abstract;
using LPNR.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPNR.Data.Concrete
{
    public class PlateDal : EfRepositoryBase<PlatePassContext, Plate>, IPlateDal
    {


    }
}
