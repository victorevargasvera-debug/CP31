using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001CC RID: 460
	[global::System.Serializable]
	public class TrunkingCallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06001630 RID: 5680 RVA: 0x000039AF File Offset: 0x00001BAF
		public TrunkingCallHotListRecset() : base(global::CommonResources.AppResources.ASTRO_25_Trunking_Hot_List)
		{
			base.Id = 2209;
			base.UIName = global::CommonResources.AppResources.ASTRO_25_Trunking_Hot_List;
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x001ED874 File Offset: 0x001EBA74
		protected TrunkingCallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 18;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲔ練ﾘ", a_));
			}
			base.UIName = global::CommonResources.AppResources.ASTRO_25_Trunking_Hot_List;
		}

		// Token: 0x06001632 RID: 5682 RVA: 0x001ED8B8 File Offset: 0x001EBAB8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1864939996;
			short num2 = num;
			num = (short)545372636;
			switch (num2 == num)
			{
			}
			num = (short)673447937;
			if (num != 0)
			{
			}
			num = (short)228982784;
			if (num != 0)
			{
			}
			num = (short)518193152;
			short num3 = num;
			return new global::SpecialFeatures.Ucl.HotList.TrunkingCallHotList(this);
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001633 RID: 5683 RVA: 0x001ED968 File Offset: 0x001EBB68
		public override int MaxPool
		{
			get
			{
				short num = (short)764939463;
				short num2 = num;
				num = (short)1932004551;
				switch (num2 == num)
				{
				}
				num = (short)520683520;
				if (num != 0)
				{
				}
				num = (short)409600001;
				if (num != 0)
				{
				}
				num = (short)1719533568;
				short num3 = num;
				return global::SpecialFeatures.Ucl.HotList.TrunkingCallHotListRecset._MaxPool;
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001634 RID: 5684 RVA: 0x001EDA14 File Offset: 0x001EBC14
		public override int Max
		{
			get
			{
				short num = (short)1318549701;
				short num2 = num;
				num = (short)1317697733;
				switch (num2 == num)
				{
				}
				num = (short)265289729;
				if (num != 0)
				{
				}
				num = (short)375652352;
				if (num != 0)
				{
				}
				num = (short)330891264;
				short num3 = num;
				return global::SpecialFeatures.Ucl.HotList.TrunkingCallHotListRecset._Max;
			}
		}

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001635 RID: 5685 RVA: 0x001EDAC4 File Offset: 0x001EBCC4
		public bool HasDiffs
		{
			get
			{
				short num = (short)1788670509;
				short num2 = num;
				num = (short)1875898925;
				switch (num2 == num)
				{
				}
				num = (short)1396899841;
				if (num != 0)
				{
				}
				num = (short)1799487488;
				if (num != 0)
				{
				}
				num = (short)1597308928;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x001EDB74 File Offset: 0x001EBD74
		// Note: this type is marked as 'beforefieldinit'.
		static TrunkingCallHotListRecset()
		{
			short num = (short)786971070;
			short num2 = num;
			num = (short)1646606782;
			switch (num2 == num)
			{
			}
			num = (short)205979649;
			if (num != 0)
			{
			}
			num = (short)301596672;
			if (num != 0)
			{
			}
			num = (short)447283200;
			short num3 = num;
			global::SpecialFeatures.Ucl.HotList.TrunkingCallHotListRecset._MaxPool = int.MaxValue;
			global::SpecialFeatures.Ucl.HotList.TrunkingCallHotListRecset._Max = int.MaxValue;
		}

		// Token: 0x04000B8F RID: 2959
		public static int _MaxPool;

		// Token: 0x04000B90 RID: 2960
		public static int _Max;
	}
}
