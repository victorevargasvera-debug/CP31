using System;
using System.Runtime.Serialization;
using System.Text;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ScanList
{
	// Token: 0x0200011C RID: 284
	[global::System.Serializable]
	public class ScanListInner : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x17001509 RID: 5385
		// (get) Token: 0x060029FD RID: 10749 RVA: 0x0028F32C File Offset: 0x0028D52C
		public global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection ScanListInnerSection
		{
			get
			{
				short num = (short)817045834;
				short num2 = num;
				num = (short)387522890;
				switch (num2 == num)
				{
				}
				num = (short)969342976;
				if (num != 0)
				{
				}
				num = (short)2121138177;
				if (num != 0)
				{
				}
				num = (short)1179779072;
				short num3 = num;
				return (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection)base[10133];
			}
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x0028F3E8 File Offset: 0x0028D5E8
		public ScanListInner(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 18;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("胒뛔뛖럘ﯚ郜뫞賠臢胤闦짨꟪蓬鳮藰", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SCANMEMBERLIST;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection section = new global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerSection(this);
			base.AddFeatureSection(section);
		}

		// Token: 0x060029FF RID: 10751 RVA: 0x0028F434 File Offset: 0x0028D634
		protected ScanListInner(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 11;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鿋귍뇏병鯕뷗럙뻛믝鋟싡꣣迥鯧黩", a_);
		}

		// Token: 0x1700150A RID: 5386
		// (get) Token: 0x06002A00 RID: 10752 RVA: 0x0028F468 File Offset: 0x0028D668
		public override string ReferenceKey
		{
			get
			{
				int a_ = 8;
				short num = (short)1044381696;
				switch (num)
				{
				default:
				{
					num = (short)265224206;
					int num2 = (int)((global::System.IntPtr)num);
					global::System.Text.StringBuilder stringBuilder;
					for (;;)
					{
						global::AcpBusinessLayer.FeatureNode referencedNode2;
						switch (num2)
						{
						case 0:
							stringBuilder.Append(global::AllFeatures.CodeplugGuid.b("", a_) + global::CommonResources.AcgResources.ID_UNASSIGNED + global::AllFeatures.CodeplugGuid.b("", a_));
							num = (short)739770373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_20F;
						case 2:
							goto IL_105;
						case 3:
						{
							global::AcpBusinessLayer.FeatureNode referencedNode;
							stringBuilder.Append(referencedNode.ReferenceKey);
							num = (short)1085997071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::AcpBusinessLayer.FeatureNode referencedNode;
							if (referencedNode != null)
							{
								num = (short)1030094851;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							stringBuilder.Append(this.ScanListInnerSection.ScanLstScanListChannel_A7620.InvalidText);
							num = (short)1440874507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_20F;
						case 6:
							if (this.ScanListInnerSection.ScanLstScanListChannel_A7620 == null)
							{
								num = (short)2146369549;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							stringBuilder = new global::System.Text.StringBuilder(((global::AcpBusinessLayer.FeatureNode)this.ScanListInnerSection.Parent).Position.ToString());
							stringBuilder.Append(global::AllFeatures.CodeplugGuid.b("", a_));
							num = (short)283574284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							stringBuilder.Append(referencedNode2.ReferenceKey);
							num = (short)1041432585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							if (this.ScanListInnerSection.ScanLstScanListChannel_A7620Value == 0)
							{
								num = (short)1447297034;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.FeatureNode referencedNode = this.ScanListInnerSection.ScanLstScanListChannel_A7620.ReferencedNode;
							num = (short)1447297025;
							if (num != 0)
							{
							}
							num = (short)382468100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							num = (short)368050176;
							short num3 = num;
							goto IL_20F;
						}
						case 10:
						{
							num = (short)900182437;
							short num4 = num;
							num = (short)1787408805;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_18E;
							default:
								num = (short)90832896;
								if (num != 0)
								{
								}
								stringBuilder.Append(global::AllFeatures.CodeplugGuid.b("", a_) + global::CommonResources.AcgResources.ID_UNASSIGNED + global::AllFeatures.CodeplugGuid.b("", a_));
								num = (short)1432944642;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
							goto IL_2E4;
						case 12:
							goto IL_18E;
						case 13:
							goto IL_378;
						case 14:
							switch (0)
							{
							case 0:
								goto IL_95;
							}
							continue;
						case 15:
							goto IL_1E1;
						case 16:
							num = (short)1975058438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (referencedNode2 != null)
							{
								num = (short)1455357959;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							stringBuilder.Append(this.ScanListInnerSection.ScanLstScanListZone_A9718.InvalidText);
							num = (short)707657729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_95:
						if (this.ScanListInnerSection.ScanLstScanListZone_A9718 != null)
						{
							num = (short)114032656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E6;
						IL_18E:
						if (this.ScanListInnerSection.ScanLstScanListZone_A9718Value == 0)
						{
							num = (short)892731392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						referencedNode2 = this.ScanListInnerSection.ScanLstScanListZone_A9718.ReferencedNode;
						num = (short)1013579793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_20F:
						stringBuilder.Append(global::AllFeatures.CodeplugGuid.b("", a_));
						num = (short)196149256;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_105:
					IL_1E1:
					goto IL_48D;
					IL_1E6:
					return ((global::AcpBusinessLayer.FeatureNode)this.ScanListInnerSection.Parent).Position.ToString() + base.FeatureName;
					IL_2E4:
					goto IL_48D;
					IL_378:
					goto IL_1E6;
					IL_48D:
					stringBuilder.Append(')');
					return stringBuilder.ToString();
				}
				}
			}
		}
	}
}
