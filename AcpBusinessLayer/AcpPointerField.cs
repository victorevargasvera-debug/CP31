using System;
using System.Runtime.CompilerServices;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer
{
	// Token: 0x02000019 RID: 25
	public class AcpPointerField<TDBType> : global::AcpBusinessLayer.AcpFieldX<TDBType, string>, global::AcpCommonLib.IAcpPointerField where TDBType : global::System.IComparable
	{
		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600024A RID: 586 RVA: 0x0002B6D0 File Offset: 0x000298D0
		// (set) Token: 0x0600024B RID: 587 RVA: 0x0002B780 File Offset: 0x00029980
		public global::AcpCommonLib.IAcpField PointedField
		{
			get
			{
				short num = (short)480881123;
				short num2 = num;
				num = (short)311601635;
				switch (num2 == num)
				{
				}
				num = (short)1047134209;
				if (num != 0)
				{
				}
				num = (short)129564672;
				if (num != 0)
				{
				}
				num = (short)820707328;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)1666383875;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_178;
					case 1:
						this.a = (value as global::AcpBusinessLayer.AcpField<TDBType>);
						num = (short)608632834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						this.ShowHexValue = (this.a is global::AcpCommonLib.IAcpRangeField && ((global::AcpCommonLib.IAcpRangeField)this.a).ShowHexValue);
						num = (short)1269039104;
						short num3 = num;
						num = (short)180551684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					case 4:
						goto IL_E1;
					}
					IL_39:
					if (value != null)
					{
						num = (short)637534209;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.a = null;
						num = (short)1557790721;
						if (num != 0)
						{
						}
						num = (short)489768847;
						short num4 = num;
						num = (short)1516455823;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17A;
						default:
							num = (short)1583874048;
							if (num != 0)
							{
							}
							num = (short)1063059456;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
				}
				IL_E1:
				IL_178:
				IL_17A:
				this.FirePropertyChangedEvent();
			}
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0002B910 File Offset: 0x00029B10
		protected AcpPointerField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(parent, name, uiLabel)
		{
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0002B928 File Offset: 0x00029B28
		public AcpPointerField(TDBType defaultValue, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string defaultUIValue) : base(parent, name, uiLabel)
		{
			this.b = defaultValue;
			this.c = defaultUIValue;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0002B950 File Offset: 0x00029B50
		public AcpPointerField(TDBType defaultValue, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string defaultUIValue, string[] legacyUILabels) : base(parent, name, uiLabel, legacyUILabels)
		{
			this.b = defaultValue;
			this.c = defaultUIValue;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0002B978 File Offset: 0x00029B78
		internal override void DeepCopy(global::AcpCommonLib.IAcpField source)
		{
			short num = (short)283055834;
			short num2 = num;
			num = (short)680597210;
			switch (num2 == num)
			{
			}
			num = (short)180158464;
			if (num != 0)
			{
			}
			num = (short)2049048577;
			if (num != 0)
			{
			}
			num = (short)1724055552;
			short num3 = num;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0002BA20 File Offset: 0x00029C20
		public override global::AcpCommonLib.UndoRedo.UndoableTask CopyValueOf(global::AcpCommonLib.IAcpField source)
		{
			short num = (short)1352096429;
			short num2 = num;
			num = (short)451238573;
			switch (num2 == num)
			{
			}
			num = (short)1919483905;
			if (num != 0)
			{
			}
			num = (short)1100808192;
			if (num != 0)
			{
			}
			num = (short)1338638336;
			short num3 = num;
			return null;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0002BAC8 File Offset: 0x00029CC8
		public override void ResetToDefault()
		{
			short num = (short)582110288;
			short num2 = num;
			num = (short)978472016;
			switch (num2 == num)
			{
			}
			num = (short)1189675009;
			if (num != 0)
			{
			}
			num = (short)1828126720;
			if (num != 0)
			{
			}
			num = (short)1937571840;
			short num3 = num;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0002BB74 File Offset: 0x00029D74
		// (set) Token: 0x06000253 RID: 595 RVA: 0x0002BC3C File Offset: 0x00029E3C
		public override TDBType Value
		{
			get
			{
				while (this.a == null)
				{
					short num = (short)1942860439;
					short num2 = num;
					num = (short)1472901783;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2121465857;
						if (num != 0)
						{
						}
						num = (short)308805632;
						short num3 = num;
						num = (short)725417984;
						if (num != 0)
						{
						}
						return this.b;
					}
					}
				}
				return this.a.Value;
			}
			set
			{
				short num = (short)1794068376;
				short num2 = num;
				num = (short)1084444568;
				switch (num2 == num)
				{
				default:
				{
					num = (short)139657216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)443482113;
				if (num != 0)
				{
				}
				num = (short)143458304;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000254 RID: 596 RVA: 0x0002BCE8 File Offset: 0x00029EE8
		// (set) Token: 0x06000255 RID: 597 RVA: 0x0002BDB0 File Offset: 0x00029FB0
		public override string UIValue
		{
			get
			{
				while (this.a == null)
				{
					short num = (short)1524401762;
					short num2 = num;
					num = (short)52463202;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2013724673;
						if (num != 0)
						{
						}
						num = (short)1532690432;
						short num3 = num;
						num = (short)1562640384;
						if (num != 0)
						{
						}
						return this.c;
					}
					}
				}
				return this.a.ToString();
			}
			set
			{
				short num = (short)132156400;
				short num2 = num;
				num = (short)1795722224;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1541210112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)347340801;
				if (num != 0)
				{
				}
				num = (short)1825701888;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0002BE60 File Offset: 0x0002A060
		protected internal override void FirePropertyChangedEvent()
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (this.ShowHexValue)
					{
						num2 = (short)1726742529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)1395916800;
					short num3 = num2;
					((global::AcpBusinessLayer.FeatureSection)base.Parent).FirePropertyChanged(base.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뻠ꯢ胤鿦볨ꋪ믬軮鷰蛲郴", a_));
					num2 = (short)1184861270;
					short num4 = num2;
					num2 = (short)787385430;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_115;
					default:
						num2 = (short)1127481344;
						if (num2 != 0)
						{
						}
						num2 = (short)1028456450;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_115;
				}
				goto IL_25;
			}
			IL_115:
			num2 = (short)599654401;
			if (num2 != 0)
			{
			}
			return;
			IL_25:
			base.FirePropertyChangedEvent();
			num2 = (short)1444806656;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0002BFAC File Offset: 0x0002A1AC
		// (set) Token: 0x06000258 RID: 600 RVA: 0x0002C13C File Offset: 0x0002A33C
		public string HexUIValue
		{
			get
			{
				int a_ = 0;
				short num = (short)989134849;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)482718861;
						short num3 = num;
						num = (short)766620813;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_144;
						case 1:
							break;
						default:
						{
							num = (short)1418330112;
							short num4 = num;
							break;
						}
						}
						num = (short)778240001;
						if (num != 0)
						{
						}
						num = (short)220594176;
						if (num != 0)
						{
						}
						num = (short)337969154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 2:
						if (this.a == null)
						{
							num = (short)800784387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_146;
					case 3:
						goto IL_144;
					}
					IL_3D:
					if (!this.ShowHexValue)
					{
						goto IL_170;
					}
					num = (short)682491904;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_144:
				int num5;
				try
				{
					num5 = global::System.Convert.ToInt32(this.c);
					goto IL_5F;
				}
				catch (global::System.Exception)
				{
					num5 = 1;
					goto IL_5F;
				}
				goto IL_170;
				IL_5F:
				return num5.ToString(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("諑", a_));
				IL_146:
				return ((global::AcpCommonLib.IAcpRangeField)this.PointedField).HexUIValue;
				IL_170:
				return null;
			}
			set
			{
				short num = (short)1941944358;
				short num2 = num;
				num = (short)717535270;
				switch (num2 == num)
				{
				default:
				{
					num = (short)258670592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1906311169;
				if (num != 0)
				{
				}
				num = (short)165085184;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000259 RID: 601 RVA: 0x0002C1E8 File Offset: 0x0002A3E8
		// (set) Token: 0x0600025A RID: 602 RVA: 0x0002C294 File Offset: 0x0002A494
		public bool ShowHexValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1966843673;
				short num2 = num;
				num = (short)1194174233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)819265536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1184956417;
				if (num != 0)
				{
				}
				num = (short)487391232;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1542434607;
				short num2 = num;
				num = (short)570535727;
				switch (num2 == num)
				{
				default:
				{
					num = (short)278855680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2113404929;
				if (num != 0)
				{
				}
				num = (short)1630404608;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x04000072 RID: 114
		private global::AcpBusinessLayer.AcpField<TDBType> a;

		// Token: 0x04000073 RID: 115
		private TDBType b;

		// Token: 0x04000074 RID: 116
		private string c;

		// Token: 0x04000075 RID: 117
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool d;
	}
}
