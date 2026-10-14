using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000218 RID: 536
	[global::System.Serializable]
	public sealed class UclContactMDCCallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001B6D RID: 7021 RVA: 0x00003E2F File Offset: 0x0000202F
		internal UclContactMDCCallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
			base.EmbeddedRecset = this.mdcCallListRecset;
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06001B6E RID: 7022 RVA: 0x00235668 File Offset: 0x00233868
		internal global::SpecialFeatures.Ucl.Contact.MDCCallListRecset MDCCallListRecset
		{
			get
			{
				short num = (short)1790246912;
				short num2 = num;
				num = (short)863122740;
				short num3 = num;
				num = (short)1544566068;
				switch (num3 == num)
				{
				}
				num = (short)34865153;
				if (num != 0)
				{
				}
				num = (short)1688862720;
				if (num != 0)
				{
				}
				return this.mdcCallListRecset;
			}
		}

		// Token: 0x06001B6F RID: 7023 RVA: 0x00235714 File Offset: 0x00233914
		public override void PopulateReferences()
		{
			short num = (short)149159936;
			short num2 = num;
			num = (short)1216806913;
			if (num != 0)
			{
			}
			num = (short)870241464;
			short num3 = num;
			num = (short)1045812408;
			switch (num3 == num)
			{
			}
			num = (short)1704984576;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B70 RID: 7024 RVA: 0x002357BC File Offset: 0x002339BC
		public override void DropReferences()
		{
			short num = (short)1307770880;
			short num2 = num;
			num = (short)51059498;
			short num3 = num;
			num = (short)1662130986;
			switch (num3 == num)
			{
			}
			num = (short)1605042177;
			if (num != 0)
			{
			}
			num = (short)1029898240;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x0023586C File Offset: 0x00233A6C
		public override void SetupDependencies()
		{
			short num = (short)795410432;
			short num2 = num;
			num = (short)1707878561;
			short num3 = num;
			num = (short)453388449;
			switch (num3 == num)
			{
			}
			num = (short)923009025;
			if (num != 0)
			{
			}
			num = (short)311361536;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x00235914 File Offset: 0x00233B14
		public override void SetConstraints()
		{
			short num = (short)1332936704;
			short num2 = num;
			num = (short)1475833206;
			short num3 = num;
			num = (short)724200822;
			switch (num3 == num)
			{
			}
			num = (short)1406795777;
			if (num != 0)
			{
			}
			num = (short)158793728;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x002359BC File Offset: 0x00233BBC
		public override void Init()
		{
			int a_ = 19;
			short num = (short)2051407872;
			short num2 = num;
			num = (short)486320062;
			short num3 = num;
			num = (short)952608702;
			switch (num3 == num)
			{
			}
			num = (short)1205075968;
			if (num != 0)
			{
			}
			num = (short)2112094209;
			if (num != 0)
			{
			}
			this.mdcCallListRecset = new global::SpecialFeatures.Ucl.Contact.MDCCallListRecset();
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb95\udc97\ud999벛\udd9d쾟첡튣쎥욧\udea9얫솭\udeaf펱\ud8b3隵ﺹ", a_);
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_ID;
			base.Id = 10405;
			base.DataTransferOrder = 11;
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x00235AAC File Offset: 0x00233CAC
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1261371392;
			short num2 = num;
			num = (short)415825921;
			if (num != 0)
			{
			}
			num = (short)501146246;
			short num3 = num;
			num = (short)286253702;
			switch (num3 == num)
			{
			}
			num = (short)1982988288;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x00235B5C File Offset: 0x00233D5C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)434110465;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1401028608;
					short num3 = num;
					num = (short)284688386;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)1601110017;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 2:
					goto IL_10A;
				}
				IL_60:
				num = (short)349718044;
				short num4 = num;
				num = (short)630146588;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_10C;
				default:
					num = (short)806027264;
					if (num != 0)
					{
					}
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_10C;
					}
					num = (short)1127612416;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_10A:
			IL_10C:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삌쮎튐뎒횔햠쪢쪤즦좨잪趬", a_);
			base.UIName = global::CommonResources.AppResources.MDC_Conventional_ID;
			base.Id = 10405;
			base.DataTransferOrder = 11;
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclContactMDCCallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x00235CA8 File Offset: 0x00233EA8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1583284224;
				short num2 = num;
				num = (short)1198013516;
				short num3 = num;
				num = (short)1427913804;
				switch (num3 == num)
				{
				}
				num = (short)254672896;
				if (num != 0)
				{
				}
				num = (short)311623681;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04000CCF RID: 3279
		private global::SpecialFeatures.Ucl.Contact.MDCCallListRecset mdcCallListRecset;
	}
}
