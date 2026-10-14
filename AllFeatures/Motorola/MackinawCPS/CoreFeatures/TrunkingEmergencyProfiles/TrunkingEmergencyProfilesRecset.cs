using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles
{
	// Token: 0x0200047D RID: 1149
	[global::System.Serializable]
	public class TrunkingEmergencyProfilesRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060097C7 RID: 38855 RVA: 0x008E8004 File Offset: 0x008E6204
		public TrunkingEmergencyProfilesRecset() : base(global::CommonResources.AcgResources.ID_TRUNKINGEMERGENCYPROFILES, global::CommonResources.AcgResources.ID_PROFILE)
		{
			this.SetValues();
		}

		// Token: 0x060097C8 RID: 38856 RVA: 0x008E8028 File Offset: 0x008E6228
		public TrunkingEmergencyProfilesRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17004C44 RID: 19524
		// (get) Token: 0x060097C9 RID: 38857 RVA: 0x008E8054 File Offset: 0x008E6254
		public override int MaxPool
		{
			get
			{
				short num = (short)197883525;
				short num2 = num;
				num = (short)1887729285;
				switch (num2 == num)
				{
				}
				num = (short)2101739521;
				if (num != 0)
				{
				}
				num = (short)1951531008;
				if (num != 0)
				{
				}
				num = (short)2138505216;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset._MaxPool;
			}
		}

		// Token: 0x17004C45 RID: 19525
		// (get) Token: 0x060097CA RID: 38858 RVA: 0x008E8104 File Offset: 0x008E6304
		// (set) Token: 0x060097CB RID: 38859 RVA: 0x008E81C0 File Offset: 0x008E63C0
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax != -1)
				{
					num = (short)218564348;
					short num2 = num;
					num = (short)1897137916;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)139526144;
						if (num != 0)
						{
						}
						num = (short)1350762497;
						if (num != 0)
						{
						}
						return this._DynMax;
					}
				}
				num = (short)735707136;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset._Max;
			}
			set
			{
				short num = (short)473959230;
				short num2 = num;
				num = (short)1324813118;
				switch (num2 == num)
				{
				}
				num = (short)1451819009;
				if (num != 0)
				{
				}
				num = (short)547618816;
				if (num != 0)
				{
				}
				num = (short)744816640;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x17004C46 RID: 19526
		// (get) Token: 0x060097CC RID: 38860 RVA: 0x008E8274 File Offset: 0x008E6474
		public bool HasDiffs
		{
			get
			{
				short num = (short)1960305872;
				short num2 = num;
				num = (short)1750918352;
				switch (num2 == num)
				{
				}
				num = (short)921829377;
				if (num != 0)
				{
				}
				num = (short)418643968;
				if (num != 0)
				{
				}
				num = (short)1945763840;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17004C47 RID: 19527
		// (get) Token: 0x060097CD RID: 38861 RVA: 0x008E8324 File Offset: 0x008E6524
		// (set) Token: 0x060097CE RID: 38862 RVA: 0x008E83D0 File Offset: 0x008E65D0
		public override int Min
		{
			get
			{
				short num = (short)2068611128;
				short num2 = num;
				num = (short)1188397112;
				switch (num2 == num)
				{
				}
				num = (short)1953038337;
				if (num != 0)
				{
				}
				num = (short)1301610496;
				if (num != 0)
				{
				}
				num = (short)1449984000;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset._Min;
			}
			set
			{
				short num = (short)787832196;
				short num2 = num;
				num = (short)258825604;
				switch (num2 == num)
				{
				}
				num = (short)1472462849;
				if (num != 0)
				{
				}
				num = (short)920125440;
				if (num != 0)
				{
				}
				num = (short)2093350912;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset._Min = value;
			}
		}

		// Token: 0x060097CF RID: 38863 RVA: 0x008E8480 File Offset: 0x008E6680
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)876703014;
			short num2 = num;
			num = (short)27028774;
			switch (num2 == num)
			{
			}
			num = (short)1621032960;
			if (num != 0)
			{
			}
			num = (short)1809186817;
			if (num != 0)
			{
			}
			num = (short)1692401664;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles(this);
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x008E8530 File Offset: 0x008E6730
		internal void SetValues()
		{
			int a_ = 16;
			short num = (short)182330243;
			short num2 = num;
			num = (short)1732322179;
			switch (num2 == num)
			{
			}
			num = (short)131203073;
			if (num != 0)
			{
			}
			num = (short)1648623616;
			if (num != 0)
			{
			}
			num = (short)1728118784;
			short num3 = num;
			this._DynMax = -1;
			base.Id = 2076;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6ꫨ蓪胬鿮黰鷲郴駶跸ꟺ룼鋾搀焂戄戆月栊琌⼎刐簒笔焖瀘簚栜洞䀠圢䰤䠦䜨眪礬崮䐰崲帴帶圸尺ᴼ稾ⱀ♂㝄⁆ⱈ╊⹌㙎煐͒❔㡖㽘㉚ㅜ㩞በ㽢ㅤᕦᱨժ٬ٮὰᑲぴ᩶ᱸॺ᩼᩾ﲄ힆ﮈ﶐쎖ﮘ뎜삠캢즤", a_);
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGEMERGENCYPROFILES;
			base.KeySeed = global::CommonResources.AcgResources.ID_PROFILE;
			base.DataTransferOrder = 30;
		}

		// Token: 0x060097D1 RID: 38865 RVA: 0x008E8630 File Offset: 0x008E6830
		// Note: this type is marked as 'beforefieldinit'.
		static TrunkingEmergencyProfilesRecset()
		{
			short num = (short)142799309;
			short num2 = num;
			num = (short)1240723917;
			switch (num2 == num)
			{
			}
			num = (short)1480065025;
			if (num != 0)
			{
			}
			num = (short)510197760;
			if (num != 0)
			{
			}
			num = (short)1460273152;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset._Min = 1;
		}

		// Token: 0x04004B05 RID: 19205
		public static int _MaxPool;

		// Token: 0x04004B06 RID: 19206
		public static int _Max;

		// Token: 0x04004B07 RID: 19207
		public int _DynMax;

		// Token: 0x04004B08 RID: 19208
		public static int _Min;
	}
}
