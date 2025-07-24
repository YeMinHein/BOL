using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.PROMO
{
   public class bol_PROMO_Offer_Setup
    {		
		public int ID { get; set; }

		public string SearchText { get; set; }
		public int ActionParam { get; set; }
		public int Promo_Plan_ID { get; set; }
		public int PromotionGroupID { get; set; }
		public string PromotionGroup { get; set; }
		public string PromotionTitle { get; set; }
		public string Brief_Description { get; set; }		
		public string Description { get; set; }
		public string Photo { get; set; }
		public string Banner_Photo { get; set; }		
		public bool IsShown { get; set; }	
		public bool IsActive { get; set; }	
		public bool IsButtonShown { get; set; }
		public string ButtonLabel { get; set; }
		public string RedirectURL { get; set; }
		public string CreatedBy { get; set; }
		public DateTime CreatedDate { get; set; }
		public string UpdatedBy { get; set; }
		public DateTime UpdatedDate { get; set; }
		public int SortOrder { get; set; }

		public bool IsDelete { get; set; }
		public bool IsPublish { get; set; }
		public string PromoName_Eng { get; set; }
		public string photoName { get; set; }
		public string Banner_Photo_Name { get; set; }
		public string PlanName { get; set; }
		public bool IsOverride { get; set; }

		public string Publish { get; set; }
		public DateTime PublishDate { get; set; }
		public string PublishDateStr { get; set; }
		public int? PageTakeRows { get; set; }
		public int? PageSkipRows { get; set; }
		public string FieldName { get; set; }
		public string Sort { get; set; }
	}
}
