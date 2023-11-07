using PlatePass.Core.Data.EfCore;
using PlatePass.DataAcess.Abstract;
using PlatePass.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlatePass.DataAcess.Concrete
{
    public class PlateDal : EfRepositoryBase<PlatePassContext, Plate>, IPlateDal
    {
    }
}
