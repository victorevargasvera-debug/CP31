using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Keypad
{
	// Token: 0x02000300 RID: 768
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007AB7 RID: 31415 RVA: 0x006FDBF4 File Offset: 0x006FBDF4
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06007AB8 RID: 31416 RVA: 0x006FDC34 File Offset: 0x006FBE34
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007AB9 RID: 31417 RVA: 0x006FDC4C File Offset: 0x006FBE4C
		public override void Init()
		{
			int a_ = 14;
			short num = (short)2031412772;
			short num2 = num;
			num = (short)332326436;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1666973696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1304952832;
			if (num != 0)
			{
			}
			num = (short)328138753;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裎듐뷒냔ꗖ룘럚", a_);
			base.Id = 10710;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 92;
		}

		// Token: 0x06007ABA RID: 31418 RVA: 0x006FDD30 File Offset: 0x006FBF30
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)699100898;
			short num2 = num;
			num = (short)1136750306;
			switch (num2 == num)
			{
			default:
			{
				num = (short)463863808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1078263809;
			if (num != 0)
			{
			}
			num = (short)256049152;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("軈껊ꏌ꫎ꏐ닒맔", a_);
			base.Id = 10710;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 92;
		}

		// Token: 0x06007ABB RID: 31419 RVA: 0x006FDE18 File Offset: 0x006FC018
		public override void PopulateReferences()
		{
			short num = (short)1155917282;
			short num2 = num;
			num = (short)1603397090;
			switch (num2 == num)
			{
			default:
			{
				num = (short)57868288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)262537217;
			if (num != 0)
			{
			}
			num = (short)2015297536;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x006FDEC0 File Offset: 0x006FC0C0
		public override void DropReferences()
		{
			short num = (short)75280646;
			short num2 = num;
			num = (short)245739782;
			switch (num2 == num)
			{
			default:
			{
				num = (short)613089280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)708968449;
			if (num != 0)
			{
			}
			num = (short)1132265472;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007ABD RID: 31421 RVA: 0x006FDF6C File Offset: 0x006FC16C
		public override void SetConstraints()
		{
			short num = (short)205043037;
			short num2 = num;
			num = (short)1371780445;
			switch (num2 == num)
			{
			default:
			{
				num = (short)69533696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1192361985;
			if (num != 0)
			{
			}
			num = (short)2078605312;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007ABE RID: 31422 RVA: 0x006FE014 File Offset: 0x006FC214
		public override void SetupDependencies()
		{
			short num = (short)46995541;
			short num2 = num;
			num = (short)607983701;
			switch (num2 == num)
			{
			default:
			{
				num = (short)899416064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1608056832;
			if (num != 0)
			{
			}
			num = (short)1205207041;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003F03 RID: 16131
		// (get) Token: 0x06007ABF RID: 31423 RVA: 0x006FE0C0 File Offset: 0x006FC2C0
		public bool HasDiffs
		{
			get
			{
				short num = (short)2001578107;
				short num2 = num;
				num = (short)344500347;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1701511168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1246756864;
				if (num != 0)
				{
				}
				num = (short)783745025;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007AC0 RID: 31424 RVA: 0x006FE16C File Offset: 0x006FC36C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1938227204;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
				{
					num2 = (short)1068105729;
					if (num2 != 0)
					{
					}
					num2 = (short)639238144;
					short num3 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)386138113;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1654915072;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
				{
					num2 = (short)19385824;
					short num4 = num2;
					num2 = (short)1612893664;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)824967168;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)1769275394;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)944832515;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040035B3 RID: 13747
		private global::Motorola.MackinawCPS.CoreFeatures.Keypad.KeypadButtonInnerRecset innerRecset;
	}
}
