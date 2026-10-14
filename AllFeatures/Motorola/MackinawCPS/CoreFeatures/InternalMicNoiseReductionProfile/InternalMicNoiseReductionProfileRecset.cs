using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile
{
	// Token: 0x02000254 RID: 596
	[global::System.Serializable]
	public class InternalMicNoiseReductionProfileRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06006B06 RID: 27398 RVA: 0x005F93BC File Offset: 0x005F75BC
		public InternalMicNoiseReductionProfileRecset() : base(global::CommonResources.AcgResources.ID_RADIONOISEREDUCTIONPROFILE, global::CommonResources.AcgResources.ID_RADIONR)
		{
			this.SetValues();
		}

		// Token: 0x06006B07 RID: 27399 RVA: 0x005F93E0 File Offset: 0x005F75E0
		public InternalMicNoiseReductionProfileRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x06006B08 RID: 27400 RVA: 0x005F940C File Offset: 0x005F760C
		public override int MaxPool
		{
			get
			{
				short num = (short)1629995873;
				short num2 = num;
				num = (short)1660207969;
				switch (num2 == num)
				{
				}
				num = (short)316014593;
				if (num != 0)
				{
				}
				num = (short)1412366336;
				if (num != 0)
				{
				}
				num = (short)1044512768;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileRecset._MaxPool;
			}
		}

		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x06006B09 RID: 27401 RVA: 0x005F94BC File Offset: 0x005F76BC
		// (set) Token: 0x06006B0A RID: 27402 RVA: 0x005F957C File Offset: 0x005F777C
		public override int Max
		{
			get
			{
				short num;
				if (this._DynMax != -1)
				{
					num = (short)8295798;
					short num2 = num;
					num = (short)235967862;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1832058880;
						if (num != 0)
						{
						}
						num = (short)2073100288;
						short num3 = num;
						return this._DynMax;
					}
					}
				}
				num = (short)864354305;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileRecset._Max;
			}
			set
			{
				short num = (short)1418608382;
				short num2 = num;
				num = (short)1571110654;
				switch (num2 == num)
				{
				}
				num = (short)239075328;
				if (num != 0)
				{
				}
				num = (short)350552065;
				if (num != 0)
				{
				}
				num = (short)1544617984;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x06006B0B RID: 27403 RVA: 0x005F962C File Offset: 0x005F782C
		public bool HasDiffs
		{
			get
			{
				short num = (short)520290305;
				if (num != 0)
				{
				}
				num = (short)600774514;
				short num2 = num;
				num = (short)1183717234;
				switch (num2 == num)
				{
				}
				num = (short)810156032;
				if (num != 0)
				{
				}
				num = (short)1163984896;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x06006B0C RID: 27404 RVA: 0x005F96D8 File Offset: 0x005F78D8
		// (set) Token: 0x06006B0D RID: 27405 RVA: 0x005F9788 File Offset: 0x005F7988
		public override int Min
		{
			get
			{
				short num = (short)539683650;
				short num2 = num;
				num = (short)2038950722;
				switch (num2 == num)
				{
				}
				num = (short)1615265793;
				if (num != 0)
				{
				}
				num = (short)33226752;
				if (num != 0)
				{
				}
				num = (short)1552023552;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileRecset._Min;
			}
			set
			{
				short num = (short)1630581460;
				short num2 = num;
				num = (short)862434004;
				switch (num2 == num)
				{
				}
				num = (short)784400385;
				if (num != 0)
				{
				}
				num = (short)1398603776;
				if (num != 0)
				{
				}
				num = (short)907345920;
				short num3 = num;
				global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileRecset._Min = value;
			}
		}

		// Token: 0x06006B0E RID: 27406 RVA: 0x005F9838 File Offset: 0x005F7A38
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1884318573;
			short num2 = num;
			num = (short)1790012269;
			switch (num2 == num)
			{
			}
			num = (short)1612578816;
			if (num != 0)
			{
			}
			num = (short)607649793;
			if (num != 0)
			{
			}
			num = (short)2057633792;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfile(this);
		}

		// Token: 0x06006B0F RID: 27407 RVA: 0x005F98E8 File Offset: 0x005F7AE8
		internal void SetValues()
		{
			int a_ = 19;
			short num = (short)825425921;
			if (num != 0)
			{
			}
			num = (short)1196703218;
			short num2 = num;
			num = (short)149634546;
			switch (num2 == num)
			{
			}
			num = (short)1188036608;
			if (num != 0)
			{
			}
			num = (short)564330496;
			short num3 = num;
			this._DynMax = -1;
			base.Id = 2086;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("闓뫕듗鳙맛뿝铟韡難菥鯧퇩꿫臭鷯英鯳飵鷷铹裻ꋽ勿持怃漅朇⨉䤋簍眏紑稓礕甗猙缛洝\u001f愡䬣䠥丧䌩䬫嬭䈯匱䀳張圷吹总瀽⼿⭁㝃⍅桇ᡉ⥋⩍╏ㅑ⁓㽕㝗㑙籛ᵝཟౡɣཥཧὩṫ཭ѯ᭱᭳ᡵ⑷㍹ቻ੽ꪉ솋늑\uda93秊鍊뺝잡삣펥쮧\udea9얫솭\udeaf銱쒵ힷ\udcb9햻튽ꖿ黁跃ꣅ볇꿉뻋ꃍ뇏뻑駓뿕믗铙돛럝鏟蟡뛣菥賧鿩迫髭駯鷱髳꛵諷闹髻韽泿朁倃搅搇␉琋漍紏縑", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIONOISEREDUCTIONPROFILE;
			base.KeySeed = global::CommonResources.AcgResources.ID_RADIONR;
			base.DataTransferOrder = 19;
		}

		// Token: 0x06006B10 RID: 27408 RVA: 0x005F99E8 File Offset: 0x005F7BE8
		// Note: this type is marked as 'beforefieldinit'.
		static InternalMicNoiseReductionProfileRecset()
		{
			short num = (short)114120088;
			short num2 = num;
			num = (short)1247958424;
			switch (num2 == num)
			{
			}
			num = (short)1982005249;
			if (num != 0)
			{
			}
			num = (short)1170407424;
			if (num != 0)
			{
			}
			num = (short)425394176;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.InternalMicNoiseReductionProfile.InternalMicNoiseReductionProfileRecset._Min = 1;
		}

		// Token: 0x040029ED RID: 10733
		public static int _MaxPool;

		// Token: 0x040029EE RID: 10734
		public static int _Max;

		// Token: 0x040029EF RID: 10735
		public int _DynMax;

		// Token: 0x040029F0 RID: 10736
		public static int _Min;
	}
}
