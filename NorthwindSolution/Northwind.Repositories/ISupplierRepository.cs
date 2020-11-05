using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Repositories
{
    public interface ISupplierRepository : IRepository<Suppliers>
    {
        IEnumerable<Suppliers> SupplierPagedList(int page, int rows);
    }
}
