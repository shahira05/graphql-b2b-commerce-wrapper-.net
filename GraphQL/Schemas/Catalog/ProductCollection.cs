using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL.Schemas.Catalog
{
    public class ProductCollection 
    {
        public virtual Uri uri { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public bool ExactMatch { get; set; }


        public bool NotAllProductsFound { get; set; }


        public bool NotAllProductsAllowed { get; set; }
        public string OriginalQuery { get; set; }
        public string CorrectedQuery { get; set; }
        public virtual string SearchTermRedirectUrl { get; set; }
        public virtual Dictionary<string, string> properties { get; set; }

    }
}
