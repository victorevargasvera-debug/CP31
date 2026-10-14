using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000466 RID: 1126
	[global::System.Serializable]
	public class TxSSIClockRateList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600954D RID: 38221 RVA: 0x008C6464 File Offset: 0x008C4664
		public TxSSIClockRateList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600954E RID: 38222 RVA: 0x008C64A4 File Offset: 0x008C46A4
		protected TxSSIClockRateList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600954F RID: 38223 RVA: 0x008C64BC File Offset: 0x008C46BC
		public override void Init()
		{
			int a_ = 11;
			short num = (short)2054488064;
			short num2 = num;
			num = (short)1443981965;
			short num3 = num;
			num = (short)1280797325;
			switch (num3 == num)
			{
			}
			num = (short)574619649;
			if (num != 0)
			{
			}
			num = (short)1647116288;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("飋뛍臑蟓鿕駙냛뇝菟觡쓣듥觧黩觫컭볯鯱蟳苵", a_);
			base.Id = 10612;
			base.UIName = global::CommonResources.AcgResources.ID_TXSSICLOCKRATELIST;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06009550 RID: 38224 RVA: 0x008C65A0 File Offset: 0x008C47A0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 12;
			short num = (short)1127088128;
			short num2 = num;
			num = (short)1812301955;
			short num3 = num;
			num = (short)1154779267;
			switch (num3 == num)
			{
			}
			num = (short)1878982657;
			if (num != 0)
			{
			}
			num = (short)555876352;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駌럎胒蛔黖律飚뇜냞苠裢엤뗦裨鿪裬쿮뷰髲蛴菶", a_);
			base.Id = 10612;
			base.UIName = global::CommonResources.AcgResources.ID_TXSSICLOCKRATELIST;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06009551 RID: 38225 RVA: 0x008C6680 File Offset: 0x008C4880
		public override void PopulateReferences()
		{
			short num = (short)1679097856;
			short num2 = num;
			num = (short)961276060;
			short num3 = num;
			num = (short)233302172;
			switch (num3 == num)
			{
			}
			num = (short)22675456;
			if (num != 0)
			{
			}
			num = (short)1954611201;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009552 RID: 38226 RVA: 0x008C672C File Offset: 0x008C492C
		public override void DropReferences()
		{
			short num = (short)1746337792;
			short num2 = num;
			num = (short)605046704;
			short num3 = num;
			num = (short)1963280304;
			switch (num3 == num)
			{
			}
			num = (short)1409351681;
			if (num != 0)
			{
			}
			num = (short)1615462400;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009553 RID: 38227 RVA: 0x008C67D4 File Offset: 0x008C49D4
		public override void SetConstraints()
		{
			short num = (short)84410368;
			short num2 = num;
			num = (short)432716330;
			short num3 = num;
			num = (short)404077098;
			switch (num3 == num)
			{
			}
			num = (short)1728249857;
			if (num != 0)
			{
			}
			num = (short)541261824;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009554 RID: 38228 RVA: 0x008C6880 File Offset: 0x008C4A80
		public override void SetupDependencies()
		{
			short num = (short)1512505344;
			short num2 = num;
			num = (short)537905303;
			short num3 = num;
			num = (short)1620756631;
			switch (num3 == num)
			{
			}
			num = (short)853803009;
			if (num != 0)
			{
			}
			num = (short)1398931456;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004B0E RID: 19214
		// (get) Token: 0x06009555 RID: 38229 RVA: 0x008C692C File Offset: 0x008C4B2C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1329332224;
				short num2 = num;
				num = (short)1905728722;
				short num3 = num;
				num = (short)1212161234;
				switch (num3 == num)
				{
				}
				num = (short)397082625;
				if (num != 0)
				{
				}
				num = (short)517013504;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06009556 RID: 38230 RVA: 0x008C69DC File Offset: 0x008C4BDC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_D9;
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1622278147;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)295174145;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_126;
				case 4:
					num2 = (short)1838022658;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			IL_126:
			return result;
			IL_24:
			result = null;
			num2 = (short)1117858447;
			short num3 = num2;
			num2 = (short)1110125199;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D9:
				if (base.ParentRecset != null)
				{
					num2 = (short)448266244;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)1360658432;
				short num4 = num2;
				num2 = (short)1325006848;
				if (num2 != 0)
				{
				}
				num2 = (short)290193409;
				if (num2 != 0)
				{
				}
				num2 = (short)1200750592;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}

		// Token: 0x04004A03 RID: 18947
		private global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInnerRecset innerRecset;
	}
}
