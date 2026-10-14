using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile
{
	// Token: 0x02000261 RID: 609
	[global::System.Serializable]
	public class ExternalMicNoiseReductionProfileRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06006C1B RID: 27675 RVA: 0x006091C8 File Offset: 0x006073C8
		public ExternalMicNoiseReductionProfileRecset() : base(global::CommonResources.AcgResources.ID_ACCESSORYNOISEREDUCTIONPROFILE, global::CommonResources.AcgResources.ID_ACCNR)
		{
			this.SetValues();
		}

		// Token: 0x06006C1C RID: 27676 RVA: 0x006091EC File Offset: 0x006073EC
		public ExternalMicNoiseReductionProfileRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x06006C1D RID: 27677 RVA: 0x00609218 File Offset: 0x00607418
		public override int MaxPool
		{
			get
			{
				short num = (short)1254574765;
				short num2 = num;
				num = (short)2103528109;
				switch (num2 == num)
				{
				}
				num = (short)1820196865;
				if (num != 0)
				{
				}
				num = (short)274268160;
				if (num != 0)
				{
				}
				num = (short)1400373248;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileRecset._MaxPool;
			}
		}

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x06006C1E RID: 27678 RVA: 0x006092C8 File Offset: 0x006074C8
		// (set) Token: 0x06006C1F RID: 27679 RVA: 0x00609388 File Offset: 0x00607588
		public override int Max
		{
			get
			{
				if (this._DynMax != -1)
				{
					short num = (short)48009768;
					short num2 = num;
					num = (short)2109575720;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_0B;
					case 1:
						break;
					default:
					{
						num = (short)1842544640;
						short num3 = num;
						break;
					}
					}
					num = (short)474480641;
					if (num != 0)
					{
					}
					num = (short)807731200;
					if (num != 0)
					{
					}
					return this._DynMax;
				}
				IL_0B:
				return global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileRecset._Max;
			}
			set
			{
				short num = (short)1619718856;
				short num2 = num;
				num = (short)902820552;
				switch (num2 == num)
				{
				}
				num = (short)1534394369;
				if (num != 0)
				{
				}
				num = (short)921239552;
				if (num != 0)
				{
				}
				num = (short)782368768;
				short num3 = num;
				this._DynMax = value;
			}
		}

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x06006C20 RID: 27680 RVA: 0x0060943C File Offset: 0x0060763C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1975408798;
				short num2 = num;
				num = (short)668293278;
				switch (num2 == num)
				{
				}
				num = (short)724369409;
				if (num != 0)
				{
				}
				num = (short)259325952;
				if (num != 0)
				{
				}
				num = (short)1714487296;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x06006C21 RID: 27681 RVA: 0x006094EC File Offset: 0x006076EC
		// (set) Token: 0x06006C22 RID: 27682 RVA: 0x0060959C File Offset: 0x0060779C
		public override int Min
		{
			get
			{
				short num = (short)1380211737;
				short num2 = num;
				num = (short)1161255961;
				switch (num2 == num)
				{
				}
				num = (short)633077761;
				if (num != 0)
				{
				}
				num = (short)1227030528;
				if (num != 0)
				{
				}
				num = (short)1632108544;
				short num3 = num;
				return global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileRecset._Min;
			}
			set
			{
				short num = (short)922166906;
				short num2 = num;
				num = (short)1780098682;
				switch (num2 == num)
				{
				}
				num = (short)991952896;
				short num3 = num;
				num = (short)1804730368;
				if (num != 0)
				{
				}
				num = (short)1457061889;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileRecset._Min = value;
			}
		}

		// Token: 0x06006C23 RID: 27683 RVA: 0x0060964C File Offset: 0x0060784C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)816557642;
			short num2 = num;
			num = (short)257797706;
			switch (num2 == num)
			{
			}
			num = (short)1483997184;
			short num3 = num;
			num = (short)745013249;
			if (num != 0)
			{
			}
			num = (short)660209664;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfile(this);
		}

		// Token: 0x06006C24 RID: 27684 RVA: 0x006096FC File Offset: 0x006078FC
		internal void SetValues()
		{
			int a_ = 14;
			short num = (short)1347747841;
			if (num != 0)
			{
			}
			num = (short)1912870379;
			short num2 = num;
			num = (short)831395307;
			switch (num2 == num)
			{
			default:
			{
				num = (short)315686912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1742864384;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.Id = 2087;
			base.SingleInstance = false;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("軎뷐뿒鏔닖룘꿚꣜귞蓠郢\udee4ꓦ蛨蛪鷬胮鿰雲鯴菶ꗸꧺ鳼鯾栀氂┄䈆笈氊戌愎縐縒簔琖樘㬚帜瀞传䔢䰤䀦尨太䰬嬮堰尲嬴欶眸吺吼䰾⑀捂ᝄ≆ⵈ㹊⹌㭎㡐㱒㭔睖ᩘ㑚㍜㥞ࡠѢၤᕦࡨὪѬnὰ⽲ぴྲྀ൸Ṻོᅾꖄ쪆권솎ﺐ朗릘즚ﮞ풠삢톤캦욨얪趬ﾮ쎰\udcb2펴\udeb6햸\udeba諭맀럂ꃄ뗆ꟈ꫊ꇌ苎룐냒鯔룖냘꣚룜跞蓠蟢郤蓦鷨苪苬臮ꇰ臲髴釶郸韺飼꯾挀漂⬄缆栈昊愌", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ACCESSORYNOISEREDUCTIONPROFILE;
			base.KeySeed = global::CommonResources.AcgResources.ID_ACCNR;
			base.DataTransferOrder = 20;
		}

		// Token: 0x06006C25 RID: 27685 RVA: 0x006097FC File Offset: 0x006079FC
		// Note: this type is marked as 'beforefieldinit'.
		static ExternalMicNoiseReductionProfileRecset()
		{
			short num = (short)923105081;
			short num2 = num;
			num = (short)30635833;
			switch (num2 == num)
			{
			}
			num = (short)92536832;
			short num3 = num;
			num = (short)1949302785;
			if (num != 0)
			{
			}
			num = (short)406585344;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.ExternalMicNoiseReductionProfile.ExternalMicNoiseReductionProfileRecset._Min = 1;
		}

		// Token: 0x04002AC8 RID: 10952
		public static int _MaxPool;

		// Token: 0x04002AC9 RID: 10953
		public static int _Max;

		// Token: 0x04002ACA RID: 10954
		public int _DynMax;

		// Token: 0x04002ACB RID: 10955
		public static int _Min;
	}
}
