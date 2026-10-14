using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x0200009E RID: 158
	[global::System.Serializable]
	public class OneTouchInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060011F3 RID: 4595 RVA: 0x00112B6C File Offset: 0x00110D6C
		public OneTouchInnerRecset() : base(global::CommonResources.AcgResources.ID_TRUNKINGONETOUCH)
		{
			this.SetValues();
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x00112B8C File Offset: 0x00110D8C
		public OneTouchInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x00112BB8 File Offset: 0x00110DB8
		public override int MaxPool
		{
			get
			{
				short num = (short)1610285056;
				short num2 = num;
				num = (short)2138006329;
				short num3 = num;
				num = (short)505963321;
				switch (num3 == num)
				{
				}
				num = (short)997785600;
				if (num != 0)
				{
				}
				num = (short)555876353;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset._MaxPool;
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x00112C64 File Offset: 0x00110E64
		// (set) Token: 0x060011F7 RID: 4599 RVA: 0x00112D24 File Offset: 0x00110F24
		public override int Max
		{
			get
			{
				if (this._DynMax != -1)
				{
					short num = (short)1744962601;
					short num2 = num;
					num = (short)233309225;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)337838081;
						if (num != 0)
						{
						}
						num = (short)2123038720;
						if (num != 0)
						{
						}
						num = (short)1443889152;
						short num3 = num;
						return this._DynMax;
					}
					}
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset._Max;
			}
			set
			{
				short num = (short)851312640;
				short num2 = num;
				num = (short)454111719;
				short num3 = num;
				num = (short)307835367;
				switch (num3 == num)
				{
				}
				num = (short)1444937728;
				if (num != 0)
				{
				}
				num = (short)617938945;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x00112DD8 File Offset: 0x00110FD8
		public override int Min
		{
			get
			{
				short num = (short)898301952;
				short num2 = num;
				num = (short)1864626663;
				short num3 = num;
				num = (short)1422520807;
				switch (num3 == num)
				{
				}
				num = (short)764411905;
				if (num != 0)
				{
				}
				num = (short)2082013184;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset._Min;
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00112E84 File Offset: 0x00111084
		// (set) Token: 0x060011FA RID: 4602 RVA: 0x00112F30 File Offset: 0x00111130
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)2110455808;
				short num2 = num;
				num = (short)1981979023;
				short num3 = num;
				num = (short)474192271;
				switch (num3 == num)
				{
				}
				num = (short)442499072;
				if (num != 0)
				{
				}
				num = (short)1677000705;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)1617297408;
				short num2 = num;
				num = (short)1736711948;
				short num3 = num;
				num = (short)1254760204;
				switch (num3 == num)
				{
				}
				num = (short)1865416705;
				if (num != 0)
				{
				}
				num = (short)1064894464;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x00112FE0 File Offset: 0x001111E0
		public bool HasDiffs
		{
			get
			{
				short num = (short)145227776;
				short num2 = num;
				num = (short)1470783457;
				short num3 = num;
				num = (short)1298685921;
				switch (num3 == num)
				{
				}
				num = (short)1579220992;
				if (num != 0)
				{
				}
				num = (short)1992753153;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00113090 File Offset: 0x00111290
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)259457024;
			short num2 = num;
			num = (short)892862465;
			if (num != 0)
			{
			}
			num = (short)237199877;
			short num3 = num;
			num = (short)759652869;
			switch (num3 == num)
			{
			}
			num = (short)1877999616;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInner(this);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00113140 File Offset: 0x00111340
		internal void SetValues()
		{
			short num = (short)1777532928;
			short num2 = num;
			num = (short)409781483;
			short num3 = num;
			num = (short)1293141227;
			switch (num3 == num)
			{
			}
			num = (short)243990529;
			if (num != 0)
			{
			}
			num = (short)1630601216;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGONETOUCH;
			base.DataTransferOrder = 43;
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0011320C File Offset: 0x0011140C
		// Note: this type is marked as 'beforefieldinit'.
		static OneTouchInnerRecset()
		{
			short num = (short)1481703424;
			short num2 = num;
			num = (short)2075480104;
			short num3 = num;
			num = (short)469127208;
			switch (num3 == num)
			{
			}
			num = (short)1349255168;
			if (num != 0)
			{
			}
			num = (short)1450180609;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerRecset._Min = 1;
		}

		// Token: 0x0400044B RID: 1099
		public static int _MaxPool;

		// Token: 0x0400044C RID: 1100
		public static int _Max;

		// Token: 0x0400044D RID: 1101
		public int _DynMax;

		// Token: 0x0400044E RID: 1102
		public static int _Min;

		// Token: 0x0400044F RID: 1103
		public static int _DefaultRecordCount;
	}
}
