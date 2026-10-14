using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability
{
	// Token: 0x0200024C RID: 588
	[global::System.Serializable]
	public class PersonnelAccountabilityRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060068A7 RID: 26791 RVA: 0x005DADD8 File Offset: 0x005D8FD8
		public PersonnelAccountabilityRecset() : base(global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITY, global::CommonResources.AcgResources.ID_PERACCLIST)
		{
			this.SetValues();
		}

		// Token: 0x060068A8 RID: 26792 RVA: 0x005DADFC File Offset: 0x005D8FFC
		public PersonnelAccountabilityRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x060068A9 RID: 26793 RVA: 0x005DAE28 File Offset: 0x005D9028
		public override int MaxPool
		{
			get
			{
				short num = (short)946784036;
				short num2 = num;
				num = (short)42452772;
				switch (num2 == num)
				{
				default:
				{
					num = (short)85983232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1809252353;
				if (num != 0)
				{
				}
				num = (short)365363200;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountabilityRecset._MaxPool;
			}
		}

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x060068AA RID: 26794 RVA: 0x005DAED8 File Offset: 0x005D90D8
		// (set) Token: 0x060068AB RID: 26795 RVA: 0x005DAF98 File Offset: 0x005D9198
		public override int Max
		{
			get
			{
				short num = (short)1153027690;
				short num2 = num;
				num = (short)1084280426;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1109983233;
					if (num != 0)
					{
					}
					num = (short)929366016;
					if (num != 0)
					{
					}
					if (this._DynMax == -1)
					{
						num = (short)585957376;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountabilityRecset._Max;
					}
					break;
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)203433852;
				short num2 = num;
				num = (short)1961043836;
				switch (num2 == num)
				{
				default:
				{
					num = (short)36044800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)515506176;
				if (num != 0)
				{
				}
				num = (short)166002689;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x060068AC RID: 26796 RVA: 0x005DB048 File Offset: 0x005D9248
		public bool HasDiffs
		{
			get
			{
				short num = (short)1089994753;
				if (num != 0)
				{
				}
				num = (short)1096286208;
				short num2 = num;
				num = (short)964689537;
				short num3 = num;
				num = (short)32571009;
				switch (num3 == num)
				{
				}
				num = (short)61145088;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x060068AD RID: 26797 RVA: 0x005DB0F8 File Offset: 0x005D92F8
		// (set) Token: 0x060068AE RID: 26798 RVA: 0x005DB1A8 File Offset: 0x005D93A8
		public override int Min
		{
			get
			{
				short num = (short)1504116737;
				if (num != 0)
				{
				}
				num = (short)1345191936;
				short num2 = num;
				num = (short)824472638;
				short num3 = num;
				num = (short)1401189438;
				switch (num3 == num)
				{
				}
				num = (short)660668416;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountabilityRecset._Min;
			}
			set
			{
				short num = (short)544708444;
				short num2 = num;
				num = (short)846108508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1304100864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1007550465;
				if (num != 0)
				{
				}
				num = (short)1369309184;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountabilityRecset._Min = value;
			}
		}

		// Token: 0x060068AF RID: 26799 RVA: 0x005DB258 File Offset: 0x005D9458
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1885927931;
			short num2 = num;
			num = (short)889846267;
			switch (num2 == num)
			{
			default:
			{
				num = (short)314179584;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1036517377;
			if (num != 0)
			{
			}
			num = (short)55902208;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountability(this);
		}

		// Token: 0x060068B0 RID: 26800 RVA: 0x005DB308 File Offset: 0x005D9508
		internal void SetValues()
		{
			int a_ = 2;
			short num = (short)1427636225;
			if (num != 0)
			{
			}
			num = (short)1191510016;
			short num2 = num;
			num = (short)207435740;
			short num3 = num;
			num = (short)1964193756;
			switch (num3 == num)
			{
			}
			num = (short)1139802112;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 4176;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("苂꧄ꯆ迈껊곌믎ꓐꇒ냔ꓖ飚닜닞釠賢诤苦蟨鿪뇬뷮郰韲鳴飶\ud9f8뻺迼飾渀洂樄樆怈栊縌⼎刐簒笔焖瀘簚栜洞䀠圢䰤䠦䜨眪紬䨮䌰䀲娴夶圸帺儼Ἶ@⁂♄⡆㱈╊㥌⹎㍐㩒㥔㹖ⵘ≚ŜཞѠᅢᙤࡦݨժ࡬ͮばၲᙴᡶ౸ᕺॼṾﶈ\ud98c﶐붒", a_);
			base.UIName = global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITY;
			base.KeySeed = global::CommonResources.AcgResources.ID_PERACCLIST;
			base.DataTransferOrder = 77;
		}

		// Token: 0x060068B1 RID: 26801 RVA: 0x005DB408 File Offset: 0x005D9608
		// Note: this type is marked as 'beforefieldinit'.
		static PersonnelAccountabilityRecset()
		{
			short num = (short)1476863678;
			short num2 = num;
			num = (short)607463102;
			switch (num2 == num)
			{
			default:
			{
				num = (short)419495936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1049624576;
			if (num != 0)
			{
			}
			num = (short)113311745;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountabilityRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountabilityRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.PersonnelAccountability.PersonnelAccountabilityRecset._Min = 1;
		}

		// Token: 0x04002933 RID: 10547
		public static int _MaxPool;

		// Token: 0x04002934 RID: 10548
		public static int _Max;

		// Token: 0x04002935 RID: 10549
		public int _DynMax;

		// Token: 0x04002936 RID: 10550
		public static int _Min;
	}
}
