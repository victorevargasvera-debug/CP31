using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;

namespace AcpBusinessLayer
{
	// Token: 0x02000018 RID: 24
	public class AcpNumericKeyField : global::AcpBusinessLayer.AcpKeyField, global::AcpCommonLib.IAcpRangeField
	{
		// Token: 0x06000232 RID: 562 RVA: 0x0002A470 File Offset: 0x00028670
		public AcpNumericKeyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(parent, name, uiLabel)
		{
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0002A488 File Offset: 0x00028688
		public AcpNumericKeyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : base(parent, name, uiLabel, legacyUILabels)
		{
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0002A4A0 File Offset: 0x000286A0
		public AcpNumericKeyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step) : base(parent, name, uiLabel)
		{
			this.Min = min;
			this.Max = max;
			this.StepSize = step;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x0002A4D0 File Offset: 0x000286D0
		public AcpNumericKeyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, string[] legacyUILabels) : base(parent, name, uiLabel, legacyUILabels)
		{
			this.Min = min;
			this.Max = max;
			this.StepSize = step;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0002A500 File Offset: 0x00028700
		protected internal override void FirePropertyChangedEvent()
		{
			int a_ = 8;
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
					((global::AcpBusinessLayer.FeatureSection)base.Parent).FirePropertyChanged(base.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("藙铛믝食럡귣냥觧蛩駫语", a_));
					num2 = (short)1484390402;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (this.ShowHexValue)
					{
						goto IL_73;
					}
					goto IL_CB;
				case 2:
					goto IL_CB;
				}
				goto IL_25;
				IL_73:
				num2 = (short)164823040;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_CB:
				num2 = (short)1289968856;
				short num3 = num2;
				num2 = (short)233921752;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_73;
				default:
					goto IL_100;
				}
			}
			IL_100:
			num2 = (short)329580544;
			if (num2 != 0)
			{
			}
			num2 = (short)1586954241;
			if (num2 != 0)
			{
			}
			return;
			IL_25:
			num2 = (short)1919221760;
			short num4 = num2;
			base.FirePropertyChangedEvent();
			num2 = (short)1666711553;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0002A64C File Offset: 0x0002884C
		// (set) Token: 0x06000238 RID: 568 RVA: 0x0002A708 File Offset: 0x00028908
		public int NumericValue
		{
			get
			{
				int result;
				short num;
				if (int.TryParse(this.Value, out result))
				{
					num = (short)411503988;
					short num2 = num;
					num = (short)1831275892;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1405943808;
						if (num != 0)
						{
						}
						num = (short)480706560;
						short num3 = num;
						break;
					}
					}
					return result;
				}
				num = (short)1039532033;
				if (num != 0)
				{
				}
				return -1;
			}
			set
			{
				if (value >= this.Min)
				{
					short num = (short)909249125;
					short num2 = num;
					num = (short)932514405;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)117112833;
						if (num != 0)
						{
						}
						num = (short)1414660096;
						short num3 = num;
						num = (short)1875050496;
						if (num != 0)
						{
						}
						break;
					}
					}
					this.Value = value.ToString();
					return;
				}
				base.SetUITimer();
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0002A7D0 File Offset: 0x000289D0
		// (set) Token: 0x0600023A RID: 570 RVA: 0x0002A87C File Offset: 0x00028A7C
		public override string Value
		{
			get
			{
				short num = (short)898582123;
				short num2 = num;
				num = (short)999835243;
				switch (num2 == num)
				{
				}
				num = (short)629932032;
				short num3 = num;
				num = (short)1682046977;
				if (num != 0)
				{
				}
				num = (short)2121465856;
				if (num != 0)
				{
				}
				return base.Value;
			}
			set
			{
				short num = (short)1964244995;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1593043014;
					short num3 = num;
					num = (short)1142483014;
					int num4;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1786839040;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_CF;
						case 1:
							if (num4 >= this.Min)
							{
								num = (short)1093074945;
								if (num != 0)
								{
								}
								num = (short)942538756;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_137;
						case 2:
							num = (short)2072444929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_84;
							}
							continue;
						case 4:
							goto IL_AB;
						}
						IL_84:
						if (int.TryParse(value, out num4))
						{
							num = (short)2121531394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_137;
					}
					IL_AB:
					base.Value = num4.ToString();
					num = (short)557318144;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CF:
				IL_137:
				num = (short)1599864832;
				short num5 = num;
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0002A9EC File Offset: 0x00028BEC
		internal override int CompareToHelper(global::AcpBusinessLayer.AcpFieldBase otherField)
		{
			short num = (short)1083515697;
			short num2 = num;
			num = (short)1558520625;
			switch (num2 == num)
			{
			}
			num = (short)1197408256;
			short num3 = num;
			num = (short)2016018433;
			if (num != 0)
			{
			}
			num = (short)1049231360;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.AcpNumericKeyField acpNumericKeyField = (global::AcpBusinessLayer.AcpNumericKeyField)otherField;
			return this.NumericValue.CompareTo(acpNumericKeyField.NumericValue);
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0002AAB0 File Offset: 0x00028CB0
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0002AC68 File Offset: 0x00028E68
		public string HexUIValue
		{
			get
			{
				int a_ = 4;
				switch (0)
				{
				case 0:
					goto IL_2D;
				}
				short num2;
				string text;
				for (;;)
				{
					IL_13:
					int num;
					switch (num)
					{
					case 0:
						goto IL_111;
					case 1:
						goto IL_152;
					case 2:
					{
						int length = this.Max.ToString(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("軕", a_)).Trim().Length;
						num2 = (short)192937985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
						if (this.ShowLeadingZeros)
						{
							num2 = (short)1800929282;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_172;
					case 4:
					{
						int length;
						text += length.ToString();
						num2 = (short)913506305;
						if (num2 != 0)
						{
						}
						num2 = (short)548470784;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					goto IL_2D;
				}
				IL_111:
				goto IL_172;
				IL_2D:
				text = global::AcpBusinessLayer.UndoRedo.SetValueTask.b("軕", a_);
				num2 = (short)1645402744;
				short num3 = num2;
				num2 = (short)80009848;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_152:
					int length;
					if (length > 0)
					{
						num2 = (short)1258291204;
						int num = (int)((global::System.IntPtr)num2);
						goto IL_13;
					}
					break;
				}
				default:
				{
					num2 = (short)1069154304;
					if (num2 != 0)
					{
					}
					num2 = (short)1997733891;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				}
				IL_172:
				num2 = (short)1170014208;
				short num4 = num2;
				return this.NumericValue.ToString(text);
			}
			set
			{
				short num = (short)896073731;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)299403944;
					short num3 = num;
					num = (short)1908378280;
					int num4;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1151991808;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_F5;
						case 1:
							if (num4 >= this.Min)
							{
								num = (short)1781399556;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_130;
						case 2:
							num = (short)1062928385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_82;
							}
							continue;
						case 4:
							goto IL_D7;
						}
						IL_82:
						if (int.TryParse(value, global::System.Globalization.NumberStyles.HexNumber, null, out num4))
						{
							num = (short)1510277121;
							if (num != 0)
							{
							}
							num = (short)1262026754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_130;
					}
					IL_D7:
					this.NumericValue = num4;
					num = (short)1522466816;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_F5:
				IL_130:
				num = (short)1871577088;
				short num5 = num;
				base.SetUITimer();
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600023E RID: 574 RVA: 0x0002ADD4 File Offset: 0x00028FD4
		// (set) Token: 0x0600023F RID: 575 RVA: 0x0002AE90 File Offset: 0x00029090
		public bool ShowHexValue
		{
			get
			{
				short num = (short)1812180830;
				short num2 = num;
				num = (short)365080414;
				switch (num2 == num)
				{
				}
				num = (short)1317797888;
				short num3 = num;
				num = (short)514326529;
				if (num != 0)
				{
				}
				num = (short)2032861184;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ShowHexValue) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				if (value)
				{
					short num = (short)1901916416;
					short num2 = num;
					num = (short)1332343040;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1554186240;
						if (num != 0)
						{
						}
						num = (short)175964160;
						short num3 = num;
						break;
					}
					}
					num = (short)117506049;
					if (num != 0)
					{
					}
					this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ShowHexValue;
					return;
				}
				this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ShowHexValue;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000240 RID: 576 RVA: 0x0002AF64 File Offset: 0x00029164
		// (set) Token: 0x06000241 RID: 577 RVA: 0x0002B024 File Offset: 0x00029224
		public bool ShowLeadingZeros
		{
			get
			{
				short num = (short)565801468;
				short num2 = num;
				num = (short)1589277180;
				switch (num2 == num)
				{
				}
				num = (short)1686831104;
				short num3 = num;
				num = (short)1861353473;
				if (num != 0)
				{
				}
				num = (short)1719861248;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ShowLeadingZeros) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				if (value)
				{
					short num = (short)524598306;
					short num2 = num;
					num = (short)1385872418;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1830223873;
						if (num != 0)
						{
						}
						num = (short)514719744;
						short num3 = num;
						num = (short)639762432;
						if (num != 0)
						{
						}
						break;
					}
					}
					this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ShowLeadingZeros;
					return;
				}
				this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ShowLeadingZeros;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0002B0FC File Offset: 0x000292FC
		// (set) Token: 0x06000243 RID: 579 RVA: 0x0002B1A8 File Offset: 0x000293A8
		public int Min
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1324473598;
				short num2 = num;
				num = (short)197647614;
				switch (num2 == num)
				{
				}
				num = (short)1134690305;
				if (num != 0)
				{
				}
				num = (short)995164160;
				if (num != 0)
				{
				}
				num = (short)417333248;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1127373801;
				short num2 = num;
				num = (short)1965186025;
				switch (num2 == num)
				{
				}
				num = (short)337575937;
				if (num != 0)
				{
				}
				num = (short)1478754304;
				if (num != 0)
				{
				}
				num = (short)3932160;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0002B258 File Offset: 0x00029458
		// (set) Token: 0x06000245 RID: 581 RVA: 0x0002B308 File Offset: 0x00029508
		public int Max
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1306668741;
				short num2 = num;
				num = (short)2048339653;
				switch (num2 == num)
				{
				}
				num = (short)377815041;
				if (num != 0)
				{
				}
				num = (short)940244992;
				if (num != 0)
				{
				}
				num = (short)95027200;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)45964374;
				short num2 = num;
				num = (short)2051234902;
				switch (num2 == num)
				{
				}
				num = (short)568786944;
				if (num != 0)
				{
				}
				num = (short)1410138113;
				if (num != 0)
				{
				}
				num = (short)2086535168;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000246 RID: 582 RVA: 0x0002B3B8 File Offset: 0x000295B8
		// (set) Token: 0x06000247 RID: 583 RVA: 0x0002B468 File Offset: 0x00029668
		public int StepSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)514641699;
				short num2 = num;
				num = (short)624545571;
				switch (num2 == num)
				{
				}
				num = (short)1070465025;
				if (num != 0)
				{
				}
				num = (short)1738145792;
				if (num != 0)
				{
				}
				num = (short)1284046848;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)837872993;
				short num2 = num;
				num = (short)299101537;
				switch (num2 == num)
				{
				}
				num = (short)728104961;
				if (num != 0)
				{
				}
				num = (short)529596416;
				if (num != 0)
				{
				}
				num = (short)1083834368;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0002B518 File Offset: 0x00029718
		public void StepUp()
		{
			if (this.NumericValue >= this.Max)
			{
				short num = (short)846135296;
				short num2 = num;
				num = (short)1321491599;
				short num3 = num;
				num = (short)1197563023;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1275199489;
					if (num != 0)
					{
					}
					num = (short)2130903040;
					if (num != 0)
					{
					}
					this.NumericValue = this.Max;
					return;
				}
			}
			this.NumericValue += this.StepSize;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0002B5F4 File Offset: 0x000297F4
		public void StepDown()
		{
			if (this.NumericValue <= this.Min)
			{
				short num = (short)1248067584;
				short num2 = num;
				num = (short)1779618631;
				short num3 = num;
				num = (short)794940231;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1477443585;
					if (num != 0)
					{
					}
					num = (short)121831424;
					if (num != 0)
					{
					}
					this.NumericValue = this.Min;
					return;
				}
			}
			this.NumericValue -= this.StepSize;
		}

		// Token: 0x0400006F RID: 111
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int a;

		// Token: 0x04000070 RID: 112
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int b;

		// Token: 0x04000071 RID: 113
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int c;
	}
}
