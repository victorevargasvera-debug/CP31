using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x02000386 RID: 902
	[global::System.Serializable]
	public class TopFunctionProgrammableButton : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060084E6 RID: 34022 RVA: 0x007B52D0 File Offset: 0x007B34D0
		public TopFunctionProgrammableButton(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060084E7 RID: 34023 RVA: 0x007B5310 File Offset: 0x007B3510
		protected TopFunctionProgrammableButton(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060084E8 RID: 34024 RVA: 0x007B5328 File Offset: 0x007B3528
		public override void Init()
		{
			int a_ = 3;
			short num = (short)1771996898;
			short num2 = num;
			num = (short)831227618;
			switch (num2 == num)
			{
			}
			num = (short)1102774272;
			short num3 = num;
			num = (short)198639616;
			if (num != 0)
			{
			}
			num = (short)215547905;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("郃꧅룇請믍뻏뇑ꃓ뿕럗듙ﳛ軝鋟跡菣铥觧蟩臫迭鋯黱釳훵뫷迹裻諽濿氁", a_);
			base.Id = 10616;
			base.UIName = global::CommonResources.AcgResources.ID_TOPFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060084E9 RID: 34025 RVA: 0x007B540C File Offset: 0x007B360C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)1945809253;
			short num2 = num;
			num = (short)2140975461;
			switch (num2 == num)
			{
			}
			num = (short)1046347776;
			short num3 = num;
			num = (short)1442054145;
			if (num != 0)
			{
			}
			num = (short)1977352192;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雁ꯃ뛅賉맋ꃍ돏ꛑ뷓맕뛗龎賛곝迟藡難蟥藧蟩跫賭鳯韱퓳듵跷軹裻釽滿", a_);
			base.Id = 10616;
			base.UIName = global::CommonResources.AcgResources.ID_TOPFUNCTIONPROGRAMMABLEBUTTON;
			base.DataTransferOrder = 2;
		}

		// Token: 0x060084EA RID: 34026 RVA: 0x007B54F0 File Offset: 0x007B36F0
		public override void PopulateReferences()
		{
			short num = (short)715471237;
			short num2 = num;
			num = (short)2121546117;
			switch (num2 == num)
			{
			}
			num = (short)17825792;
			short num3 = num;
			num = (short)970260480;
			if (num != 0)
			{
			}
			num = (short)821362689;
			if (num != 0)
			{
			}
		}

		// Token: 0x060084EB RID: 34027 RVA: 0x007B559C File Offset: 0x007B379C
		public override void DropReferences()
		{
			short num = (short)1880096769;
			if (num != 0)
			{
			}
			num = (short)150386795;
			short num2 = num;
			num = (short)85244011;
			switch (num2 == num)
			{
			default:
			{
				num = (short)138739712;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)166264832;
			if (num != 0)
			{
			}
		}

		// Token: 0x060084EC RID: 34028 RVA: 0x007B5644 File Offset: 0x007B3844
		public override void SetConstraints()
		{
			short num = (short)855490919;
			short num2 = num;
			num = (short)2124530023;
			switch (num2 == num)
			{
			}
			num = (short)1095368704;
			short num3 = num;
			num = (short)982646785;
			if (num != 0)
			{
			}
			num = (short)658571264;
			if (num != 0)
			{
			}
		}

		// Token: 0x060084ED RID: 34029 RVA: 0x007B56F0 File Offset: 0x007B38F0
		public override void SetupDependencies()
		{
			short num = (short)1103343264;
			short num2 = num;
			num = (short)309243552;
			switch (num2 == num)
			{
			}
			num = (short)1001390080;
			short num3 = num;
			num = (short)1963261953;
			if (num != 0)
			{
			}
			num = (short)704839680;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700439E RID: 17310
		// (get) Token: 0x060084EE RID: 34030 RVA: 0x007B5798 File Offset: 0x007B3998
		public bool HasDiffs
		{
			get
			{
				short num = (short)905804525;
				short num2 = num;
				num = (short)99187437;
				switch (num2 == num)
				{
				}
				num = (short)660471808;
				short num3 = num;
				num = (short)1396178944;
				if (num != 0)
				{
				}
				num = (short)225050625;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060084EF RID: 34031 RVA: 0x007B5848 File Offset: 0x007B3A48
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)549933152;
			short num2 = num;
			num = (short)1984909408;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_70:
				num = (short)1774059520;
				short num3 = num;
				num = (short)1393295363;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)938278912;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				break;
			}
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				switch (num4)
				{
				case 0:
					return result;
				case 1:
					num = (short)2100297729;
					if (num != 0)
					{
					}
					num = (short)1203830786;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)528613380;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
					if (base.ParentRecset != null)
					{
						num = (short)281542657;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)589824;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_6E;
			}
			return result;
			IL_6E:
			result = null;
			goto IL_70;
		}

		// Token: 0x04003E7D RID: 15997
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset innerRecset;
	}
}
