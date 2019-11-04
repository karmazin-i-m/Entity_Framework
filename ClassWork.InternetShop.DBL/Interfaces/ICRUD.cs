using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork.InternetShop.DBL.Interfaces
{
    interface ICRUD<T> : IDisposable
    {
        void Edit(T t);
        void UpDate(Int32 id);
        T Read(Int32 id);
        void Delete(Int32 id);
        ICollection<T> ReadAll();

    }
}
