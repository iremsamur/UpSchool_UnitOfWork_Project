using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool_UOW_DataAccessLayer.Abstract;
using UpSchool_UOW_DataAccessLayer.Concrete;
using UpSchool_UOW_DataAccessLayer.Repository;
using UpSchool_UOW_EntityLayer;

namespace UpSchool_UOW_DataAccessLayer.EntityFramework
{
    public class EfProcessDetailDal : GenericRepository<ProcessDetail>,IProcessDetailDal
    {
        //her bir entity için efdal sınıfında bu işlem yapılır
        private IServiceProvider _serviceProvider;



        public EfProcessDetailDal(Context context, IServiceProvider serviceProvider) : base(context)
        {
            _serviceProvider = serviceProvider;
        }

      

        
    }
}
