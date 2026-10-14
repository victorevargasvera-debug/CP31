using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001E2 RID: 482
	[global::System.Serializable]
	public sealed class UclPhoneCallHotListHotListSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001742 RID: 5954 RVA: 0x00003AF7 File Offset: 0x00001CF7
		internal UclPhoneCallHotListHotListSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.phoneCallHotListRecset = new global::SpecialFeatures.Ucl.HotList.PhoneCallHotListRecset();
			base.EmbeddedRecset = this.phoneCallHotListRecset;
			this.phoneCallHotListRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x17000711 RID: 1809
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x001FC164 File Offset: 0x001FA364
		internal global::SpecialFeatures.Ucl.HotList.PhoneCallHotListRecset PhoneCallHotListRecset
		{
			get
			{
				short num = (short)984025576;
				short num2 = num;
				num = (short)2043021800;
				switch (num2 == num)
				{
				}
				num = (short)1157890048;
				short num3 = num;
				num = (short)200998913;
				if (num != 0)
				{
				}
				num = (short)1669464064;
				if (num != 0)
				{
				}
				return this.phoneCallHotListRecset;
			}
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x001FC214 File Offset: 0x001FA414
		public override void PopulateReferences()
		{
			short num = (short)620288772;
			short num2 = num;
			num = (short)453565188;
			switch (num2 == num)
			{
			}
			num = (short)677052416;
			short num3 = num;
			num = (short)726663169;
			if (num != 0)
			{
			}
			num = (short)2126184448;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x001FC2C0 File Offset: 0x001FA4C0
		public override void DropReferences()
		{
			short num = (short)243793921;
			if (num != 0)
			{
			}
			num = (short)1579064630;
			short num2 = num;
			num = (short)792698166;
			switch (num2 == num)
			{
			default:
			{
				num = (short)647954432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1761411072;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x001FC368 File Offset: 0x001FA568
		public override void SetupDependencies()
		{
			short num = (short)1493352058;
			short num2 = num;
			num = (short)1011138170;
			switch (num2 == num)
			{
			}
			num = (short)1691811840;
			short num3 = num;
			num = (short)165871617;
			if (num != 0)
			{
			}
			num = (short)367394816;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x001FC414 File Offset: 0x001FA614
		public override void SetConstraints()
		{
			short num = (short)736766594;
			short num2 = num;
			num = (short)2069179010;
			switch (num2 == num)
			{
			}
			num = (short)1799880704;
			short num3 = num;
			num = (short)1652686849;
			if (num != 0)
			{
			}
			num = (short)1662713856;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x001FC4BC File Offset: 0x001FA6BC
		public override void Init()
		{
			int a_ = 11;
			short num = (short)63508625;
			short num2 = num;
			num = (short)1053364369;
			switch (num2 == num)
			{
			}
			num = (short)1363476480;
			short num3 = num;
			num = (short)896729089;
			if (num != 0)
			{
			}
			num = (short)1748828160;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8d﶑望뢗튙肟춣향\udca7", a_);
			base.UIName = global::CommonResources.AppResources.Phone_Hot_List;
			base.Id = 10427;
			base.DataTransferOrder = 13;
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x001FC5A0 File Offset: 0x001FA7A0
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1713741734;
			short num2 = num;
			num = (short)2119606182;
			switch (num2 == num)
			{
			}
			num = (short)1529348096;
			short num3 = num;
			num = (short)865861633;
			if (num != 0)
			{
			}
			num = (short)1732640768;
			if (num != 0)
			{
			}
			base.GetObjectData(info, context);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x001FC650 File Offset: 0x001FA850
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)1833041920;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3B;
					}
					continue;
				case 1:
				{
					IL_56:
					num = (short)864747520;
					short num3 = num;
					num = (short)1450967042;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_99;
				}
				IL_3B:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1796079617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_99:
				num = (short)200605697;
				if (num != 0)
				{
				}
				num = (short)2002894112;
				short num4 = num;
				num = (short)1890303264;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_56;
				default:
					goto IL_F7;
				}
			}
			IL_F7:
			num = (short)1038417920;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda89ﺏ뒓\ude95벛튝즟톡킣", a_);
			base.UIName = global::CommonResources.AppResources.Phone_Hot_List;
			base.Id = 10427;
			base.DataTransferOrder = 13;
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x0000265F File Offset: 0x0000085F
		internal UclPhoneCallHotListHotListSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x17000712 RID: 1810
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x001FC79C File Offset: 0x001FA99C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1204149339;
				short num2 = num;
				num = (short)1460788315;
				switch (num2 == num)
				{
				}
				num = (short)298188800;
				short num3 = num;
				num = (short)728629249;
				if (num != 0)
				{
				}
				num = (short)2107768832;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x04000BFD RID: 3069
		private global::SpecialFeatures.Ucl.HotList.PhoneCallHotListRecset phoneCallHotListRecset;
	}
}
