using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SecureWide
{
	// Token: 0x020000EC RID: 236
	[global::System.Serializable]
	public class SecureWideRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060022F2 RID: 8946 RVA: 0x00224258 File Offset: 0x00222458
		public SecureWideRecset()
		{
			int a_ = 14;
			base..ctor(global::AllFeatures.CodeplugGuid.b("鳎듐냒ꃔꗖ볘ﯚ諜뛞藠蛢", a_));
			this.SetValues();
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00224288 File Offset: 0x00222488
		public SecureWideRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x002242B4 File Offset: 0x002224B4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)339738625;
			if (num != 0)
			{
			}
			num = (short)1303379968;
			short num2 = num;
			num = (short)947623080;
			short num3 = num;
			num = (short)1831769256;
			switch (num3 == num)
			{
			}
			num = (short)1128857600;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide(this);
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00224360 File Offset: 0x00222560
		internal void SetValues()
		{
			int a_ = 15;
			short num = (short)152266929;
			short num2 = num;
			num = (short)959080625;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1796341760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1862795265;
			if (num != 0)
			{
			}
			num = (short)560332800;
			if (num != 0)
			{
			}
			base.Id = 2021;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹꿻鯽揿省瘃挅⠇䤉挋怍瘏笑猓挕樗笙栛眝伟䰡砣甥䴧䤩夫尭唯ሱ挳張尷弹总洽┿⅁ㅃ㑅ⵇᵉ╋⩍㕏籑ⱓ㝕㕗㙙", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SECUREWIDE;
			base.DataTransferOrder = 4;
			this.b();
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00224450 File Offset: 0x00222650
		private void b()
		{
			short num = (short)923242717;
			short num2 = num;
			num = (short)961253597;
			switch (num2 == num)
			{
			default:
			{
				num = (short)493813760;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1493368832;
			if (num != 0)
			{
			}
			num = (short)1883308033;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x002244FC File Offset: 0x002226FC
		private void a()
		{
			short num = (short)353173504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				global::AcpBusinessLayer.AcpField<int> secWideGeneralOTAROperation_;
				bool value;
				bool value2;
				bool value3;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						num = (short)353067042;
						short num3 = num;
						num = (short)793272354;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_217;
						default:
							goto IL_11D;
						}
						break;
					}
					case 1:
						num = (short)1070399489;
						if (num != 0)
						{
						}
						num = (short)804061187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						secWideGeneralOTAROperation_.Value = 0;
						num = (short)1515388932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (secWideGeneralOTAROperation_ != null)
						{
							num = (short)1953103881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FC;
					case 4:
						goto IL_197;
					case 5:
						if (value && value2)
						{
							num = (short)893386759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2085093386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (secWideGeneralOTAROperation_ != null)
						{
							goto IL_217;
						}
						goto IL_278;
					case 7:
						goto IL_172;
					case 8:
						if (value3)
						{
							num = (short)1404174337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FC;
					case 9:
						num = (short)1711865861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (value)
						{
							num = (short)1991835648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E0;
					}
					goto IL_5A;
					IL_1FC:
					num = (short)1626865670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_217:
					num = (short)852164610;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E0:
				secWideGeneralOTAROperation_.Value = 1;
				return;
				IL_11D:
				num = (short)876806144;
				if (num != 0)
				{
				}
				secWideGeneralOTAROperation_.Value = 2;
				return;
				IL_172:
				secWideGeneralOTAROperation_.Value = 3;
				return;
				IL_197:
				IL_278:
				num = (short)2008743936;
				short num4 = num;
				return;
				IL_5A:
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = base[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
				value = secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value;
				value2 = secureWide.MDCOTAR.SecWideMDCOTARMDCOTAREnable_A8488.Value;
				value3 = secureWide.General.SecWideGeneralOTAREnable_A7966.Value;
				secWideGeneralOTAROperation_ = secureWide.General.SecWideGeneralOTAROperation_43700;
				num = (short)1371078664;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
