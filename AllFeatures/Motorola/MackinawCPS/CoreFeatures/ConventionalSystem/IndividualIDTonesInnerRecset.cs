using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalSystem
{
	// Token: 0x02000573 RID: 1395
	[global::System.Serializable]
	public class IndividualIDTonesInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600BD9B RID: 48539 RVA: 0x00AF4DD4 File Offset: 0x00AF2FD4
		public IndividualIDTonesInnerRecset() : base(global::CommonResources.AcgResources.ID_INDIVIDUALIDTONES, global::CommonResources.AcgResources.ID_INDIDTONE)
		{
			this.SetValues();
		}

		// Token: 0x0600BD9C RID: 48540 RVA: 0x00AF4DF8 File Offset: 0x00AF2FF8
		public IndividualIDTonesInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17005F2B RID: 24363
		// (get) Token: 0x0600BD9D RID: 48541 RVA: 0x00AF4E24 File Offset: 0x00AF3024
		public override int MaxPool
		{
			get
			{
				short num = (short)533200897;
				if (num != 0)
				{
				}
				num = (short)543774468;
				short num2 = num;
				num = (short)1813927684;
				switch (num2 == num)
				{
				default:
				{
					num = (short)870383616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1051590656;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset._MaxPool;
			}
		}

		// Token: 0x17005F2C RID: 24364
		// (get) Token: 0x0600BD9E RID: 48542 RVA: 0x00AF4ED0 File Offset: 0x00AF30D0
		// (set) Token: 0x0600BD9F RID: 48543 RVA: 0x00AF4F94 File Offset: 0x00AF3194
		public override int Max
		{
			get
			{
				if (this._DynMax == -1)
				{
					short num;
					for (;;)
					{
						num = (short)452614399;
						short num2 = num;
						num = (short)1767069951;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_44;
						}
					}
					IL_44:
					num = (short)2139160577;
					if (num != 0)
					{
					}
					num = (short)1574699008;
					short num3 = num;
					num = (short)1342242816;
					if (num != 0)
					{
					}
					return global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset._Max;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1598677616;
				short num2 = num;
				num = (short)1983439472;
				switch (num2 == num)
				{
				}
				num = (short)1363083264;
				short num3 = num;
				num = (short)39583745;
				if (num != 0)
				{
				}
				num = (short)1342308352;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17005F2D RID: 24365
		// (get) Token: 0x0600BDA0 RID: 48544 RVA: 0x00AF5044 File Offset: 0x00AF3244
		public override int Min
		{
			get
			{
				short num = (short)213205004;
				short num2 = num;
				num = (short)1163739148;
				switch (num2 == num)
				{
				}
				num = (short)1023541248;
				short num3 = num;
				num = (short)1614479360;
				if (num != 0)
				{
				}
				num = (short)1864499201;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset._Min;
			}
		}

		// Token: 0x17005F2E RID: 24366
		// (get) Token: 0x0600BDA1 RID: 48545 RVA: 0x00AF50F0 File Offset: 0x00AF32F0
		// (set) Token: 0x0600BDA2 RID: 48546 RVA: 0x00AF519C File Offset: 0x00AF339C
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1549752196;
				short num2 = num;
				num = (short)576804740;
				switch (num2 == num)
				{
				}
				num = (short)256311296;
				short num3 = num;
				num = (short)868024321;
				if (num != 0)
				{
				}
				num = (short)1231290368;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)468634240;
				short num2 = num;
				num = (short)1720961664;
				switch (num2 == num)
				{
				}
				num = (short)230227968;
				short num3 = num;
				num = (short)815267841;
				if (num != 0)
				{
				}
				num = (short)316866560;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17005F2F RID: 24367
		// (get) Token: 0x0600BDA3 RID: 48547 RVA: 0x00AF524C File Offset: 0x00AF344C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1939182924;
				short num2 = num;
				num = (short)265131340;
				switch (num2 == num)
				{
				}
				num = (short)1169031168;
				short num3 = num;
				num = (short)1293221888;
				if (num != 0)
				{
				}
				num = (short)1359675393;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600BDA4 RID: 48548 RVA: 0x00AF52FC File Offset: 0x00AF34FC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1768942120;
			short num2 = num;
			num = (short)534571560;
			switch (num2 == num)
			{
			}
			num = (short)288686080;
			short num3 = num;
			num = (short)970326017;
			if (num != 0)
			{
			}
			num = (short)1278935040;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.FeatureNode featureNode = new global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner(this);
			this.b(featureNode);
			return featureNode;
		}

		// Token: 0x0600BDA5 RID: 48549 RVA: 0x00AF53B4 File Offset: 0x00AF35B4
		internal void SetValues()
		{
			short num = (short)418650280;
			short num2 = num;
			num = (short)1367546024;
			switch (num2 == num)
			{
			}
			num = (short)1366228992;
			short num3 = num;
			num = (short)1391853569;
			if (num != 0)
			{
			}
			num = (short)916389888;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_INDIVIDUALIDTONES;
			base.KeySeed = global::CommonResources.AcgResources.ID_INDIDTONE;
			base.DataTransferOrder = 42;
		}

		// Token: 0x0600BDA6 RID: 48550 RVA: 0x00AF5488 File Offset: 0x00AF3688
		private void b(global::AcpBusinessLayer.FeatureNode A_0)
		{
			short num = (short)1955397633;
			if (num != 0)
			{
			}
			num = (short)1286877340;
			short num2 = num;
			num = (short)1424502940;
			switch (num2 == num)
			{
			default:
			{
				num = (short)807534592;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1301872640;
			if (num != 0)
			{
			}
			this.a(A_0);
		}

		// Token: 0x0600BDA7 RID: 48551 RVA: 0x00AF5538 File Offset: 0x00AF3738
		private void a(global::AcpBusinessLayer.FeatureNode A_0)
		{
			short num = (short)1521942544;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerSection individualIDTonesInnerSection;
				switch (num2)
				{
				case 0:
					if (individualIDTonesInnerSection != null)
					{
						num = (short)696844299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					num = (short)1113587717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)2114453505;
					if (num != 0)
					{
					}
					if (base.Count == 0)
					{
						num = (short)34799634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D3;
				case 3:
					return;
				case 4:
					individualIDTonesInnerSection.CnvSysGeneralQc2Name_A42231.Value = global::CommonResources.AppResources.QC2_Tone_B;
					num = (short)144244746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)851705871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					goto IL_1F7;
				case 7:
					if (base.Count == 1)
					{
						num = (short)1184628740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_94;
				case 8:
					goto IL_150;
				case 9:
					individualIDTonesInnerSection.CnvSysGeneralQc2Name_A42231.Value = global::CommonResources.AppResources.QC2_Tone_C;
					num = (short)1668874248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_94;
				case 11:
					num = (short)1507328002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (base.Count == 3)
					{
						num = (short)1933180934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 13:
					num = (short)1209335825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_D3;
				case 15:
				{
					individualIDTonesInnerSection = (A_0 as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInner).IndividualIDTonesInnerSection;
					num = (short)429536968;
					short num3 = num;
					num = (short)1567700680;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F7;
					default:
						num = (short)2100428800;
						if (num != 0)
						{
						}
						num = (short)1268514816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 16:
					switch (0)
					{
					case 0:
						goto IL_75;
					}
					continue;
				case 17:
					if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
					{
						num = (short)1800863745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 18:
				{
					num = (short)1283522560;
					short num4 = num;
					individualIDTonesInnerSection.CnvSysGeneralQc2Name_A42231.Value = global::CommonResources.AppResources.QC2_Tone_A;
					num = (short)1541079054;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 19:
					if (base.Count == 2)
					{
						num = (short)29163529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_150;
				}
				IL_75:
				if (A_0 != null)
				{
					num = (short)1550909453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_94:
				num = (short)1066532883;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D3:
				num = (short)944308231;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_150:
				num = (short)518848524;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F7:
				individualIDTonesInnerSection.CnvSysGeneralQc2Name_A42231.Value = global::CommonResources.AppResources.QC2_Tone_D;
				num = (short)1766064131;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600BDA8 RID: 48552 RVA: 0x00AF58E0 File Offset: 0x00AF3AE0
		// Note: this type is marked as 'beforefieldinit'.
		static IndividualIDTonesInnerRecset()
		{
			short num = (short)2058615412;
			short num2 = num;
			num = (short)1211562612;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1792475136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1103101953;
			if (num != 0)
			{
			}
			num = (short)176226304;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.IndividualIDTonesInnerRecset._Min = 1;
		}

		// Token: 0x04005C26 RID: 23590
		public static int _MaxPool;

		// Token: 0x04005C27 RID: 23591
		public static int _Max;

		// Token: 0x04005C28 RID: 23592
		public int _DynMax;

		// Token: 0x04005C29 RID: 23593
		public static int _Min;

		// Token: 0x04005C2A RID: 23594
		public static int _DefaultRecordCount;
	}
}
