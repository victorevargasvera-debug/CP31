using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles
{
	// Token: 0x020004A1 RID: 1185
	[global::System.Serializable]
	public class EmergencyToneList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009AFB RID: 39675 RVA: 0x00913A34 File Offset: 0x00911C34
		public EmergencyToneList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06009AFC RID: 39676 RVA: 0x00913A74 File Offset: 0x00911C74
		protected EmergencyToneList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009AFD RID: 39677 RVA: 0x00913A8C File Offset: 0x00911C8C
		public override void Init()
		{
			int a_ = 18;
			short num = (short)1662375169;
			short num2 = num;
			num = (short)381998337;
			switch (num2 == num)
			{
			}
			num = (short)1317011456;
			if (num != 0)
			{
			}
			num = (short)619708417;
			if (num != 0)
			{
			}
			num = (short)1143144448;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雒룔닖ꯘ볚룜뇞苠髢엤돦蛨藪裬쿮뷰髲蛴菶", a_);
			base.Id = 10771;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYTONELIST;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06009AFE RID: 39678 RVA: 0x00913B74 File Offset: 0x00911D74
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)1276695273;
			short num2 = num;
			num = (short)1697174249;
			switch (num2 == num)
			{
			}
			num = (short)541917185;
			if (num != 0)
			{
			}
			num = (short)1735262208;
			if (num != 0)
			{
			}
			num = (short)2102198272;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟁꧃ꏅ뫇귉꧋ꃍ돏ꯑ苕럗듙맛ﻝ곟诡韣鋥", a_);
			base.Id = 10771;
			base.UIName = global::CommonResources.AcgResources.ID_EMERGENCYTONELIST;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06009AFF RID: 39679 RVA: 0x00913C58 File Offset: 0x00911E58
		public override void PopulateReferences()
		{
			short num = (short)759611514;
			short num2 = num;
			num = (short)1276493946;
			switch (num2 == num)
			{
			}
			num = (short)1402732545;
			if (num != 0)
			{
			}
			num = (short)1393557504;
			if (num != 0)
			{
			}
			num = (short)2109276160;
			short num3 = num;
		}

		// Token: 0x06009B00 RID: 39680 RVA: 0x00913D00 File Offset: 0x00911F00
		public override void DropReferences()
		{
			short num = (short)476839937;
			if (num != 0)
			{
			}
			num = (short)1829996142;
			short num2 = num;
			num = (short)1945667182;
			switch (num2 == num)
			{
			}
			num = (short)1133510656;
			if (num != 0)
			{
			}
			num = (short)1813315584;
			short num3 = num;
		}

		// Token: 0x06009B01 RID: 39681 RVA: 0x00913DAC File Offset: 0x00911FAC
		public override void SetConstraints()
		{
			short num = (short)906976267;
			short num2 = num;
			num = (short)1414421515;
			switch (num2 == num)
			{
			}
			num = (short)1923678209;
			if (num != 0)
			{
			}
			num = (short)2044461056;
			if (num != 0)
			{
			}
			num = (short)1735852032;
			short num3 = num;
		}

		// Token: 0x06009B02 RID: 39682 RVA: 0x00913E54 File Offset: 0x00912054
		public override void SetupDependencies()
		{
			short num = (short)593353175;
			short num2 = num;
			num = (short)343923159;
			switch (num2 == num)
			{
			}
			num = (short)231866368;
			if (num != 0)
			{
			}
			num = (short)2032336897;
			if (num != 0)
			{
			}
			num = (short)1510080512;
			short num3 = num;
		}

		// Token: 0x17004DC4 RID: 19908
		// (get) Token: 0x06009B03 RID: 39683 RVA: 0x00913F00 File Offset: 0x00912100
		public bool HasDiffs
		{
			get
			{
				short num = (short)1207942425;
				short num2 = num;
				num = (short)394968345;
				switch (num2 == num)
				{
				}
				num = (short)429916160;
				if (num != 0)
				{
				}
				num = (short)1888747521;
				if (num != 0)
				{
				}
				num = (short)1277624320;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x06009B04 RID: 39684 RVA: 0x00913FB0 File Offset: 0x009121B0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)297861121;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
				{
					num2 = (short)602099597;
					short num3 = num2;
					num2 = (short)67522445;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					case 1:
						break;
					default:
					{
						num2 = (short)256049152;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)310968320;
					if (num2 != 0)
					{
					}
					num2 = (short)1096417284;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)178454530;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					num2 = (short)92995585;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)148373504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)594804739;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04004CF2 RID: 19698
		private global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.EmergencyToneTableInnerRecset innerRecset;
	}
}
