using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001CC RID: 460
	[global::System.Serializable]
	public class ConventionalShepherd : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600533F RID: 21311 RVA: 0x004B8F50 File Offset: 0x004B7150
		public ConventionalShepherd(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06005340 RID: 21312 RVA: 0x004B8F90 File Offset: 0x004B7190
		protected ConventionalShepherd(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06005341 RID: 21313 RVA: 0x004B8FA8 File Offset: 0x004B71A8
		public override void Init()
		{
			int a_ = 12;
			short num = (short)1662978861;
			short num2 = num;
			num = (short)1090784045;
			switch (num2 == num)
			{
			}
			num = (short)946143233;
			if (num != 0)
			{
			}
			num = (short)1584398336;
			if (num != 0)
			{
			}
			num = (short)1338179584;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軌ꃎ뿐ꗒ냔맖귘닚닜뇞胠迢엤듦臨軪鷬蟮铰臲釴", a_);
			base.Id = 10035;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSHEPHERD;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06005342 RID: 21314 RVA: 0x004B908C File Offset: 0x004B728C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)1100559342;
			short num2 = num;
			num = (short)1725903854;
			switch (num2 == num)
			{
			}
			num = (short)914096128;
			if (num != 0)
			{
			}
			num = (short)1622605825;
			if (num != 0)
			{
			}
			num = (short)1693319168;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郒뫔맖꿘뻚돜ꯞ裠賢诤蛦藨쯪뻬蟮铰菲鷴鋶诸鿺", a_);
			base.Id = 10035;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALSHEPHERD;
			base.DataTransferOrder = 2;
		}

		// Token: 0x06005343 RID: 21315 RVA: 0x004B916C File Offset: 0x004B736C
		public override void PopulateReferences()
		{
			short num = (short)1731657729;
			if (num != 0)
			{
			}
			num = (short)1684026557;
			short num2 = num;
			num = (short)1354249405;
			switch (num2 == num)
			{
			}
			num = (short)316538880;
			if (num != 0)
			{
			}
			num = (short)2100756480;
			short num3 = num;
		}

		// Token: 0x06005344 RID: 21316 RVA: 0x004B9218 File Offset: 0x004B7418
		public override void DropReferences()
		{
			short num = (short)1736492136;
			short num2 = num;
			num = (short)2115552360;
			switch (num2 == num)
			{
			}
			num = (short)1520893953;
			if (num != 0)
			{
			}
			num = (short)1910439936;
			if (num != 0)
			{
			}
			num = (short)1867120640;
			short num3 = num;
		}

		// Token: 0x06005345 RID: 21317 RVA: 0x004B92C0 File Offset: 0x004B74C0
		public override void SetConstraints()
		{
			short num = (short)1303620714;
			short num2 = num;
			num = (short)1785637994;
			switch (num2 == num)
			{
			}
			num = (short)698155008;
			if (num != 0)
			{
			}
			num = (short)2131623937;
			if (num != 0)
			{
			}
			num = (short)731250688;
			short num3 = num;
		}

		// Token: 0x06005346 RID: 21318 RVA: 0x004B9368 File Offset: 0x004B7568
		public override void SetupDependencies()
		{
			short num = (short)932724395;
			short num2 = num;
			num = (short)14040747;
			switch (num2 == num)
			{
			}
			num = (short)1434451968;
			if (num != 0)
			{
			}
			num = (short)1146093569;
			if (num != 0)
			{
			}
			num = (short)231866368;
			short num3 = num;
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x06005347 RID: 21319 RVA: 0x004B9410 File Offset: 0x004B7610
		public bool HasDiffs
		{
			get
			{
				short num = (short)660733953;
				if (num != 0)
				{
				}
				num = (short)2146833001;
				short num2 = num;
				num = (short)1005326953;
				switch (num2 == num)
				{
				}
				num = (short)1668546560;
				if (num != 0)
				{
				}
				num = (short)1440415744;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06005348 RID: 21320 RVA: 0x004B94C0 File Offset: 0x004B76C0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)324534272;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4F;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_35:
				switch (num3)
				{
				case 0:
					num = (short)2004484097;
					if (num != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1807876099;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)141950976;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
				{
					if (base.ParentRecset == null)
					{
						return result;
					}
					num = (short)955748994;
					short num4 = num;
					num = (short)1909887618;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num = (short)1411514368;
						if (num != 0)
						{
						}
						num = (short)1553137668;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					return result;
				case 4:
					num = (short)474087425;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4F;
			}
			return result;
			IL_4F:
			result = null;
			num = (short)214433794;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_35;
		}

		// Token: 0x04001FAE RID: 8110
		private global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ConventionalShepherdListInnerRecset innerRecset;
	}
}
