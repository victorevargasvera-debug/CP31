using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles
{
	// Token: 0x02000495 RID: 1173
	[global::System.Serializable]
	public class ConventionalEmergencyProfilesRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06009AB4 RID: 39604 RVA: 0x0090FCFC File Offset: 0x0090DEFC
		public ConventionalEmergencyProfilesRecset() : base(global::CommonResources.AcgResources.ID_CONVENTIONALEMERGENCYPROFILES, global::CommonResources.AcgResources.ID_PROFILE)
		{
			this.SetValues();
		}

		// Token: 0x06009AB5 RID: 39605 RVA: 0x0090FD20 File Offset: 0x0090DF20
		public ConventionalEmergencyProfilesRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004DA9 RID: 19881
		// (get) Token: 0x06009AB6 RID: 39606 RVA: 0x0090FD4C File Offset: 0x0090DF4C
		public override int MaxPool
		{
			get
			{
				short num = (short)968601278;
				short num2 = num;
				num = (short)642821822;
				switch (num2 == num)
				{
				}
				num = (short)1669791745;
				if (num != 0)
				{
				}
				num = (short)214368256;
				short num3 = num;
				num = (short)1035599872;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset._MaxPool;
			}
		}

		// Token: 0x17004DAA RID: 19882
		// (get) Token: 0x06009AB7 RID: 39607 RVA: 0x0090FDF8 File Offset: 0x0090DFF8
		// (set) Token: 0x06009AB8 RID: 39608 RVA: 0x0090FEBC File Offset: 0x0090E0BC
		public override int Max
		{
			get
			{
				short num = (short)805699585;
				if (num != 0)
				{
				}
				if (this._DynMax != -1)
				{
					num = (short)1863480808;
					short num2 = num;
					num = (short)1152415208;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)304152576;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
				}
				num = (short)753008640;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset._Max;
			}
			set
			{
				short num = (short)1966987792;
				short num2 = num;
				num = (short)1950079504;
				switch (num2 == num)
				{
				}
				num = (short)1981808641;
				if (num != 0)
				{
				}
				num = (short)751828992;
				short num3 = num;
				num = (short)15073280;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17004DAB RID: 19883
		// (get) Token: 0x06009AB9 RID: 39609 RVA: 0x0090FF6C File Offset: 0x0090E16C
		public bool HasDiffs
		{
			get
			{
				short num = (short)778391946;
				short num2 = num;
				num = (short)1803112842;
				switch (num2 == num)
				{
				}
				num = (short)584646657;
				if (num != 0)
				{
				}
				num = (short)2061434880;
				short num3 = num;
				num = (short)367853568;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004DAC RID: 19884
		// (get) Token: 0x06009ABA RID: 39610 RVA: 0x00910020 File Offset: 0x0090E220
		// (set) Token: 0x06009ABB RID: 39611 RVA: 0x009100CC File Offset: 0x0090E2CC
		public override int Min
		{
			get
			{
				short num = (short)2119600187;
				short num2 = num;
				num = (short)309430331;
				switch (num2 == num)
				{
				}
				num = (short)1608450049;
				if (num != 0)
				{
				}
				num = (short)1817051136;
				short num3 = num;
				num = (short)1377173504;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset._Min;
			}
			set
			{
				short num = (short)339269448;
				short num2 = num;
				num = (short)1910888264;
				switch (num2 == num)
				{
				}
				num = (short)2085552129;
				if (num != 0)
				{
				}
				num = (short)297598976;
				short num3 = num;
				num = (short)1748828160;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset._Min = value;
			}
		}

		// Token: 0x06009ABC RID: 39612 RVA: 0x0091017C File Offset: 0x0090E37C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)214809819;
			short num2 = num;
			num = (short)2044574939;
			switch (num2 == num)
			{
			}
			num = (short)2057699329;
			if (num != 0)
			{
			}
			num = (short)583008256;
			short num3 = num;
			num = (short)491388928;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfiles(this);
		}

		// Token: 0x06009ABD RID: 39613 RVA: 0x0091022C File Offset: 0x0090E42C
		internal void SetValues()
		{
			int a_ = 8;
			short num = (short)25100289;
			if (num != 0)
			{
			}
			num = (short)1072025604;
			short num2 = num;
			num = (short)1742131204;
			switch (num2 == num)
			{
			}
			num = (short)618135552;
			short num3 = num;
			num = (short)37748736;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 2075;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜ꋠ賢裤韦蛨藪裬臮藰꿲냴髶鳸觺髼髾漀怂簄✆䨈搊挌椎砐琒怔攖砘漚琜瀞传缢昤䠦䜨崪䠬䄮䔰娲娴夶堸场ᴼ稾ⱀ♂㝄⁆ⱈ╊⹌㙎煐͒❔㡖㽘㉚ㅜ㩞በ㽢♤ࡦݨᵪ࡬Ůհᩲᩴ᥶ᡸ᝺㡼ቾ\udf8eﲒﺖﺚ쮞쎠쾢认\udfa6좨욪솬", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALEMERGENCYPROFILES;
			base.KeySeed = global::CommonResources.AcgResources.ID_PROFILE;
			base.DataTransferOrder = 29;
		}

		// Token: 0x06009ABE RID: 39614 RVA: 0x00910328 File Offset: 0x0090E528
		// Note: this type is marked as 'beforefieldinit'.
		static ConventionalEmergencyProfilesRecset()
		{
			short num = (short)570541223;
			short num2 = num;
			num = (short)801162407;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1718550528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)910098432;
			if (num != 0)
			{
			}
			num = (short)1509359617;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ConventionalEmergencyProfiles.ConventionalEmergencyProfilesRecset._Min = 1;
		}

		// Token: 0x04004CC1 RID: 19649
		public static int _MaxPool;

		// Token: 0x04004CC2 RID: 19650
		public static int _Max;

		// Token: 0x04004CC3 RID: 19651
		public int _DynMax;

		// Token: 0x04004CC4 RID: 19652
		public static int _Min;
	}
}
