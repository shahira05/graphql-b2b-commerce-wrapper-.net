// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Insite Software">
//   Copyright © 2019. Insite Software. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace GraphQL.Schemas.Catalog
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Linq.Expressions;

    public class Product
    {
        public virtual DateTimeOffset ActivateOn { get; set; } 

        public virtual bool AllowAnyGiftCardAmount { get; set; }


        public virtual decimal BasicListPrice { get; set; }

        public virtual DateTimeOffset? BasicSaleEndDate { get; set; }

        public virtual decimal BasicSalePrice { get; set; }

        public virtual DateTimeOffset? BasicSaleStartDate { get; set; }

        /// <summary>Gets or sets the category products.</summary>
        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
      ///  public virtual ICollection<Category> Categories { get; set; } = new HashSet<Category>();
    /// <summary>Gets or sets the configuration id.</summary>
        public virtual Guid? ConfigurationObjectId { get; set; }

        /// <summary>Gets or sets the configuration object/entity.</summary>


        public virtual Guid? ContentManagerId { get; set; }

        /// <summary>Gets or sets custom availability message.</summary>
        public virtual string CustomAvailabilityMessage { get; set; } = string.Empty;

        public virtual DateTimeOffset? DeactivateOn { get; set; }

        public virtual bool DisplayPricePerPiece { get; set; }


        [Required(AllowEmptyStrings = true)]
        [StringLength(2048)]
        public virtual string ErpDescription { get; set; } = string.Empty;

        public virtual bool ErpManaged { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public virtual string ErpNumber { get; set; } = string.Empty;

        public virtual decimal? HandlingAmountOverride { get; set; }

        public virtual bool HasMsds { get; set; }

        /// <summary>This field indicates the search index status for this Product (valid values are <see cref="IndexStatusType"/> enum). </summary>
        public virtual int IndexStatus { get; set; } = (int)IndexStatusType.Indexed;

        public virtual bool IsConfigured { get; set; }

        public virtual bool IsDiscontinued { get; set; }

        public virtual bool IsFixedConfiguration { get; set; }

        public virtual bool IsGiftCard { get; set; }

        public virtual bool IsHazardousGood { get; set; }

        public virtual bool IsSpecialOrder { get; set; }

        /// <summary>Gets or sets a value indicating whether is sponsored (featured in product list).</summary>
        public virtual bool IsSponsored { get; set; }

        public virtual bool IsSubscription { get; set; }

        public virtual decimal LowStockLevel { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]
        public virtual string ManufacturerItem { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        public virtual string MetaDescription { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
     
        public virtual string MetaKeywords { get; set; } = string.Empty;

        public virtual int MinimumOrderQty { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public virtual string ModelNumber { get; set; } = string.Empty;

        public virtual int MultipleSaleQty { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public virtual string Name { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public virtual string PackDescription { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(1024)]
        public virtual string PageTitle { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public virtual string PriceBasis { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public virtual string PriceCode { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public virtual string ProductCode { get; set; } = string.Empty;



        public virtual int QtyPerShippingPackage { get; set; }

        /// <summary>Gets or sets the quote option.</summary>
        public virtual bool IsQuoteRequired { get; set; }

        /// <summary>Gets or sets the product 2.</summary>
        public virtual Product ReplacementProduct { get; set; }

        public virtual Guid? ReplacementProductId { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public virtual string RoundingRule { get; set; } = string.Empty;

        [StringLength(255)]
        public virtual string SalePriceLabel { get; set; } = string.Empty;

        public virtual bool ShipSeparately { get; set; }

        public virtual decimal? ShippingAmountOverride { get; set; }

        public virtual decimal ShippingHeight { get; set; }

        public virtual decimal ShippingLength { get; set; }

        public virtual decimal ShippingWeight { get; set; }

        public virtual decimal ShippingWidth { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(2048)]
       
        public virtual string ShortDescription { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]
        public virtual string Sku { get; set; } = string.Empty;

        public virtual int SortOrder { get; set; }

        /// <summary>Gets or sets the index time search boost value greater than or equal to zero</summary>
        public virtual decimal SearchBoost { get; set; } = 1;

        public virtual Guid? StyleClassId { get; set; }

        public virtual Product StyleParent { get; set; }

        public virtual Guid? StyleParentId { get; set; }

        public virtual bool SubscriptionAddToInitialOrder { get; set; }

        public virtual bool SubscriptionAllMonths { get; set; }

        public virtual bool SubscriptionApril { get; set; } = true;

        public virtual bool SubscriptionAugust { get; set; } = true;

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public virtual string SubscriptionCyclePeriod { get; set; } = string.Empty;

        public virtual bool SubscriptionDecember { get; set; } = true;

        public virtual bool SubscriptionFebruary { get; set; } = true;

        public virtual bool SubscriptionFixedPrice { get; set; }

        public virtual bool SubscriptionJanuary { get; set; } = true;

        public virtual bool SubscriptionJuly { get; set; } = true;

        public virtual bool SubscriptionJune { get; set; } = true;

        public virtual bool SubscriptionMarch { get; set; } = true;

        public virtual bool SubscriptionMay { get; set; } = true;

        public virtual bool SubscriptionNovember { get; set; } = true;

        public virtual bool SubscriptionOctober { get; set; } = true;

        public virtual int SubscriptionPeriodsPerCycle { get; set; }

        public virtual bool SubscriptionSeptember { get; set; } = true;

        public virtual Guid? SubscriptionShipViaId { get; set; }

        public virtual int SubscriptionTotalCycles { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public virtual string TaxCategory { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public virtual string TaxCode1 { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public virtual string TaxCode2 { get; set; } = string.Empty;


        public virtual bool TrackInventory { get; set; }

        public virtual decimal UnitCost { get; set; }

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public virtual string UnitOfMeasure { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]
        public virtual string UnitOfMeasureDescription { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(100)]
        public virtual string Unspsc { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(50)]
        public virtual string UpcCode { get; set; } = string.Empty;

        [Required(AllowEmptyStrings = true)]
        [StringLength(255)]
        public virtual string UrlSegment { get; set; } = string.Empty;

        public virtual Guid? VatCodeId { get; set; }

        [StringLength(2048)]
        public virtual string OpenGraphTitle { get; set; } = string.Empty;

        [StringLength(2048)]
        public virtual string OpenGraphUrl { get; set; } = string.Empty;

        [StringLength(1024)]
        public virtual string OpenGraphImage { get; set; } = string.Empty;

        public virtual bool ExcludeFromRecommendations { get; set; }

        public virtual bool IsSeasonal { get; set; }

        public virtual bool SeasonalJanuary { get; set; }

        public virtual bool SeasonalFebruary { get; set; }

        public virtual bool SeasonalMarch { get; set; }

        public virtual bool SeasonalApril { get; set; }

        public virtual bool SeasonalMay { get; set; }

        public virtual bool SeasonalJune { get; set; }

        public virtual bool SeasonalJuly { get; set; }

        public virtual bool SeasonalAugust { get; set; }

        public virtual bool SeasonalSeptember { get; set; }

        public virtual bool SeasonalOctober { get; set; }

        public virtual bool SeasonalNovember { get; set; }

        public virtual bool SeasonalDecember { get; set; }

        public virtual bool ExcludeWhenOutOfSeason { get; set; }

        public virtual bool CantBuy { get; set; }

        public virtual Dictionary<string, string> properties { get; set; }
        public void Restore()
        {
            this.DeactivateOn = null;
        }

        /// <summary>enum used for the <see cref="Product"/> IndexStatus field</summary>
        public enum IndexStatusType
        {
            Indexed = 0,
            NeedsIndexing = 1,
            NeverIndex = 2
        }

        public enum ProductDefaultVisibility
        {
            Show,
            Hide
        }
    }
}