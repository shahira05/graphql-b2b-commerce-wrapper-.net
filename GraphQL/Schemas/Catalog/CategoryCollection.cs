using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Schemas.Catalog
{
    public class CategoryCollection
    {
        public virtual Uri uri { get; set; }

        public virtual ICollection<Category> Categories { get; set; }

    }
}
