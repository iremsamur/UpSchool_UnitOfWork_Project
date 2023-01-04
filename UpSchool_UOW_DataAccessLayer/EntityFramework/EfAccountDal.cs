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
    public class EfAccountDal : GenericRepository<Account>,IAccountDal
    {
        //Generic Repository içinde context alan constructor olduğundan 
        //o constructor burada da tanımlanır
        public EfAccountDal(Context context) : base(context)
        {
            //constructor burada base class alıyor


        }
    }
}
