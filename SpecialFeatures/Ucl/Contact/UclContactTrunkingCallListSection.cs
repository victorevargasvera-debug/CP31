using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x0200021D RID: 541
	[global::System.Serializable]
	public sealed class UclContactTrunkingCallListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001BA5 RID: 7077 RVA: 0x00003E80 File Offset: 0x00002080
		internal UclContactTrunkingCallListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
			base.EmbeddedRecset = this.trunkingCallListRecset;
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x06001BA6 RID: 7078 RVA: 0x0023AF90 File Offset: 0x00239190
		internal global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset TrunkingCallListRecset
		{
			get
			{
				short num = (short)732364801;
				if (num != 0)
				{
				}
				num = (short)1927507641;
				short num2 = num;
				num = (short)1002729145;
				switch (num2 == num)
				{
				}
				num = (short)1278214144;
				short num3 = num;
				num = (short)1462108160;
				if (num != 0)
				{
				}
				return this.trunkingCallListRecset;
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0023B040 File Offset: 0x00239240
		public override void PopulateReferences()
		{
			short num = (short)629895367;
			short num2 = num;
			num = (short)1144680647;
			switch (num2 == num)
			{
			}
			num = (short)1892286465;
			if (num != 0)
			{
			}
			num = (short)1393164288;
			short num3 = num;
			num = (short)1627062272;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0023B0E8 File Offset: 0x002392E8
		public override void DropReferences()
		{
			short num = (short)1009160036;
			short num2 = num;
			num = (short)499945316;
			switch (num2 == num)
			{
			}
			num = (short)514719745;
			if (num != 0)
			{
			}
			num = (short)600965120;
			short num3 = num;
			num = (short)89980928;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0023B190 File Offset: 0x00239390
		public override void SetupDependencies()
		{
			short num = (short)868056516;
			short num2 = num;
			num = (short)110525892;
			switch (num2 == num)
			{
			}
			num = (short)1853882369;
			if (num != 0)
			{
			}
			num = (short)2003697664;
			short num3 = num;
			num = (short)646184960;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0023B238 File Offset: 0x00239438
		public override void SetConstraints()
		{
			short num = (short)275698941;
			short num2 = num;
			num = (short)263640317;
			switch (num2 == num)
			{
			}
			num = (short)1178271745;
			if (num != 0)
			{
			}
			num = (short)1490550784;
			short num3 = num;
			num = (short)1376845824;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x0023B2E0 File Offset: 0x002394E0
		public override void Init()
		{
			int a_ = 8;
			short num = (short)1678497666;
			short num2 = num;
			num = (short)737138562;
			switch (num2 == num)
			{
			}
			num = (short)1523318784;
			if (num != 0)
			{
			}
			num = (short)1318584320;
			short num3 = num;
			num = (short)128909313;
			if (num != 0)
			{
			}
			this.trunkingCallListRecset = new global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset();
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪊\ude8c\udb8e쎐\udc92떔ꖖ겘뮚즜풠춢캤캦잨첪趬", a_);
			base.UIName = global::CommonResources.AppResources.Astro_25_Trunking_ID;
			base.Id = 10401;
			base.DataTransferOrder = 14;
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x0023B3CC File Offset: 0x002395CC
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)428450301;
			short num2 = num;
			num = (short)2095161853;
			switch (num2 == num)
			{
			}
			num = (short)1800011777;
			if (num != 0)
			{
			}
			num = (short)536870912;
			short num3 = num;
			num = (short)358678528;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x0023B47C File Offset: 0x0023967C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)824049665;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_111;
				case 1:
					goto IL_1D;
				case 2:
				{
					num = (short)805994834;
					short num3 = num;
					num = (short)1674150226;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
					{
						num = (short)1073414144;
						short num4 = num;
						num = (short)1616576513;
						if (num != 0)
						{
						}
						num = (short)1478098944;
						if (num != 0)
						{
						}
						num = (short)621084672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				goto IL_39;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_39:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_113;
					}
					num = (short)1305280514;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_111:
			IL_113:
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풔쒖춘즚튜뾞鎠隢薤\udba8\udeaa쎬쒮\ud8b0\uddb2튴鞶ﾺ", a_);
			base.UIName = global::CommonResources.AppResources.Astro_25_Trunking_ID;
			base.Id = 10401;
			base.DataTransferOrder = 14;
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclContactTrunkingCallListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06001BAF RID: 7087 RVA: 0x0023B5D0 File Offset: 0x002397D0
		public bool HasDiffs
		{
			get
			{
				short num = (short)880299678;
				short num2 = num;
				num = (short)639848094;
				switch (num2 == num)
				{
				}
				num = (short)2079457280;
				if (num != 0)
				{
				}
				num = (short)733216768;
				short num3 = num;
				num = (short)144900097;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04000DAA RID: 3498
		private global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset;
	}
}
