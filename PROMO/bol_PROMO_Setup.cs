using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.PROMO
{
	public class bol_PROMO_Setup
	{

		public int ActionParam { get; set; }
		public int ID { get; set; }
		public int PROMO_Type_ID { get; set; }
		public string PromoName_MM { get; set; }

		public string PromoName_Eng { get; set; }
		public string PromoTypeName { get; set; }

		public string Description_MM { get; set; }

		public string Description_Eng { get; set; }
		public string PromoLabel { get; set; }
		public string PromoLabelColour { get; set; }
		public int SortOrder { get; set; }
		public DateTime createdDate { get; set; }
		public string createdBy { get; set; }
		public bool IsActive { get; set; }
		public string SearchText { get; set; }
		public DateTime FromDate { get; set; }
		public DateTime ToDate { get; set; }
		public string[] ServiceBasePlanID { get; set; }
		public int FOC_Month { get; set; }
		public int FOC_Day { get; set; }
		public string FOC_Note { get; set; }
		public string ActionType { get; set; }
		public string PlanName { get; set; }
		public bool IsOTCCharge { get; set; }
		public bool IsDepositCharge { get; set; }
		public int InstallMonth { get; set; }
		public string Remarks { get; set; }
		public string[] City_ID { get; set; }
		public bool IsShown { get; set; }
		public int? PageSkipRows { get; set; }
		public int? PageTakeRows { get; set; }
		public string FieldName { get; set; }
		public string Sort { get; set; }
		public int PromotionGroupID { get; set; }
		public string PromotionGroup { get; set; }
	}
	public class bol_PROMO_Group
	{
		public int ActionParam { get; set; }
		public int ID { get; set; }
		public string PromotionGroup { get; set; }
		public string Title { get; set; }

		public string Description { get; set; }

		public bool IsActive { get; set; }

		public int SortOrder { get; set; }

	}
}
