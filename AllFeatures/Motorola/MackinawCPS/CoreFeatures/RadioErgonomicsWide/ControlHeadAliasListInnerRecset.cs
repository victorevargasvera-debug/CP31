using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide
{
	// Token: 0x02000220 RID: 544
	[global::System.Serializable]
	public class ControlHeadAliasListInnerRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06006531 RID: 25905 RVA: 0x005AB07C File Offset: 0x005A927C
		public ControlHeadAliasListInnerRecset() : base(global::CommonResources.AcgResources.ID_CONTROLHEADALIASLIST, global::CommonResources.AcgResources.ID_CONTROLHEAD)
		{
			this.SetValues();
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x005AB0A0 File Offset: 0x005A92A0
		public ControlHeadAliasListInnerRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x1700347F RID: 13439
		// (get) Token: 0x06006533 RID: 25907 RVA: 0x005AB0CC File Offset: 0x005A92CC
		public override int MaxPool
		{
			get
			{
				short num = (short)1615462400;
				short num2 = num;
				num = (short)165587344;
				short num3 = num;
				num = (short)1694804368;
				switch (num3 == num)
				{
				}
				num = (short)1726611457;
				if (num != 0)
				{
				}
				num = (short)1783824384;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerRecset._MaxPool;
			}
		}

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x06006534 RID: 25908 RVA: 0x005AB17C File Offset: 0x005A937C
		// (set) Token: 0x06006535 RID: 25909 RVA: 0x005AB23C File Offset: 0x005A943C
		public override int Max
		{
			get
			{
				short num;
				while (this._DynMax == -1)
				{
					num = (short)272305619;
					short num2 = num;
					num = (short)2065042899;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1710424064;
						if (num != 0)
						{
						}
						num = (short)1833893888;
						short num3 = num;
						return global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerRecset._Max;
					}
					}
				}
				num = (short)2075852801;
				if (num != 0)
				{
				}
				return this._DynMax;
			}
			set
			{
				short num = (short)1548877824;
				short num2 = num;
				num = (short)747471474;
				short num3 = num;
				num = (short)161317490;
				switch (num3 == num)
				{
				}
				num = (short)1613955072;
				if (num != 0)
				{
				}
				num = (short)1525940225;
				if (num != 0)
				{
				}
				this._DynMax = value;
			}
		}

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x06006536 RID: 25910 RVA: 0x005AB2EC File Offset: 0x005A94EC
		public override int Min
		{
			get
			{
				short num = (short)784269312;
				short num2 = num;
				num = (short)2029791939;
				short num3 = num;
				num = (short)1197157059;
				switch (num3 == num)
				{
				}
				num = (short)1176895488;
				if (num != 0)
				{
				}
				num = (short)904134657;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerRecset._Min;
			}
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x06006537 RID: 25911 RVA: 0x005AB398 File Offset: 0x005A9598
		// (set) Token: 0x06006538 RID: 25912 RVA: 0x005AB448 File Offset: 0x005A9648
		public override int DefaultRecordCount
		{
			get
			{
				short num = (short)1549664256;
				short num2 = num;
				num = (short)228810080;
				short num3 = num;
				num = (short)2128829792;
				switch (num3 == num)
				{
				}
				num = (short)1637089281;
				if (num != 0)
				{
				}
				num = (short)285474816;
				if (num != 0)
				{
				}
				return global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerRecset._DefaultRecordCount;
			}
			set
			{
				short num = (short)660865024;
				short num2 = num;
				num = (short)834338817;
				if (num != 0)
				{
				}
				num = (short)446984358;
				short num3 = num;
				num = (short)1065906342;
				switch (num3 == num)
				{
				}
				num = (short)1645084672;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerRecset._DefaultRecordCount = value;
			}
		}

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x06006539 RID: 25913 RVA: 0x005AB4F8 File Offset: 0x005A96F8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1263337472;
				short num2 = num;
				num = (short)38656659;
				short num3 = num;
				num = (short)1624103571;
				switch (num3 == num)
				{
				}
				num = (short)1071251456;
				if (num != 0)
				{
				}
				num = (short)1007878145;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600653A RID: 25914 RVA: 0x005AB5A8 File Offset: 0x005A97A8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)331218944;
			short num2 = num;
			num = (short)647648071;
			short num3 = num;
			num = (short)1095455559;
			switch (num3 == num)
			{
			}
			num = (short)2063400961;
			if (num != 0)
			{
			}
			num = (short)881917952;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInner(this);
		}

		// Token: 0x0600653B RID: 25915 RVA: 0x005AB658 File Offset: 0x005A9858
		internal void SetValues()
		{
			short num = (short)205389824;
			short num2 = num;
			num = (short)368040893;
			short num3 = num;
			num = (short)2133253053;
			switch (num3 == num)
			{
			}
			num = (short)528809985;
			if (num != 0)
			{
			}
			num = (short)1650327552;
			if (num != 0)
			{
			}
			this._DynMax = -1;
			base.SingleInstance = false;
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADALIASLIST;
			base.KeySeed = global::CommonResources.AcgResources.ID_CONTROLHEAD;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600653C RID: 25916 RVA: 0x005AB728 File Offset: 0x005A9928
		// Note: this type is marked as 'beforefieldinit'.
		static ControlHeadAliasListInnerRecset()
		{
			short num = (short)1787166720;
			short num2 = num;
			num = (short)394000057;
			short num3 = num;
			num = (short)1367996089;
			switch (num3 == num)
			{
			}
			num = (short)841089025;
			if (num != 0)
			{
			}
			num = (short)892469248;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerRecset._MaxPool = int.MaxValue;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerRecset._Max = 5000;
			global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.ControlHeadAliasListInnerRecset._Min = 1;
		}

		// Token: 0x04002641 RID: 9793
		public static int _MaxPool;

		// Token: 0x04002642 RID: 9794
		public static int _Max;

		// Token: 0x04002643 RID: 9795
		public int _DynMax;

		// Token: 0x04002644 RID: 9796
		public static int _Min;

		// Token: 0x04002645 RID: 9797
		public static int _DefaultRecordCount;
	}
}
