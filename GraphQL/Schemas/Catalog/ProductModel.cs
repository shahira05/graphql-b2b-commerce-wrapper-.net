using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Schemas.Catalog
{
    public class ProductModel
    {
        public virtual Uri uri { get; set; }

        public virtual Product product { get; set; }


    }
}
