using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;

namespace GraphQL.Schemas.Catalog
{
    public class Category
    {
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

        public virtual DateTimeOffset? DeactivateOn { get; set; }


        [Required(AllowEmptyStrings = true)]
        public virtual string ErpProductValues { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(1024)]
       
        public virtual string ImageAltText { get; set; } = string.Empty;

        public virtual bool IsDynamic { get; set; }
        public virtual bool IsFeatured { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(1024)]
        public virtual string LargeImagePath { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
       
        public virtual string MetaDescription { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
       
        public virtual string MetaKeywords { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public virtual string Name { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(1024)]
       
        public virtual string PageTitle { get; set; } = string.Empty;

        public virtual Category Parent { get; set; }
        public virtual Guid? ParentId { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
       
        public virtual string ShortDescription { get; set; } = string.Empty;

        public virtual bool ShowDetail { get; set; } = true;

        [Required(AllowEmptyStrings = true)]
        [StringLength(1024)]
        public virtual string SmallImagePath { get; set; } = string.Empty;

        public virtual int SortOrder { get; set; }

        /// <summary>Gets or sets the index time search boost value for category searches greater than or equal to zero</summary>
        public virtual decimal SearchBoost { get; set; } = 1;

        /// <summary>Gets or sets the index time search boost value for products in thise category greater than or equal to zero</summary>
        public virtual decimal ProductSearchBoost { get; set; } = 1;


        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public virtual string UrlSegment { get; set; } = string.Empty;


       
        public virtual string OpenGraphTitle { get; set; } = string.Empty;

        [StringLength(2048)]
       
        public virtual string OpenGraphUrl { get; set; } = string.Empty;

        [StringLength(1024)]
        public virtual string OpenGraphImage { get; set; } = string.Empty;

        [StringLength(1024)]
        public virtual string MobileBannerImageUrl { get; set; } = string.Empty;

        [StringLength(1024)]
        public virtual string MobilePrimaryText { get; set; } = string.Empty;

        [StringLength(1024)]
        public virtual string MobileSecondaryText { get; set; } = string.Empty;

        [StringLength(32)]
        public virtual string MobileTextJustification { get; set; } = "Left";

        [StringLength(8)]
        public virtual string MobileTextColor { get; set; } = "333333";

        public virtual bool ExcludeFromRecommendations { get; set; }

        public virtual Guid? PimCategoryId { get; set; }



        public void Restore()
        {
            this.DeactivateOn = null;
        }

        public virtual ICollection<Category> SubCategories { get; set; } = new HashSet<Category>();
        public virtual Dictionary<string, string> properties { get; set; }
    }
}
