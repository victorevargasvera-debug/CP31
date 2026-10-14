using System;
using System.Collections.Generic;
using System.Windows.Data;
using AcpBusinessLayer.ValueConverters;

namespace AcpBusinessLayer
{
	// Token: 0x02000006 RID: 6
	[global::System.Serializable]
	public class AcpCustomRangeField : global::AcpBusinessLayer.AcpRangeField<int, string>
	{
		// Token: 0x06000011 RID: 17 RVA: 0x00002FC0 File Offset: 0x000011C0
		public AcpCustomRangeField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string minLabel, string maxLabel) : base(value, converter, parent, name, uiLabel)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002FEC File Offset: 0x000011EC
		public AcpCustomRangeField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string minLabel, string maxLabel, string[] legacyUILabels) : base(value, converter, parent, name, uiLabel, legacyUILabels)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00003018 File Offset: 0x00001218
		public AcpCustomRangeField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string minLabel, string maxLabel) : base(new global::AcpBusinessLayer.ValueConverters.Int32ToStringConverter(), parent, name, uiLabel)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003044 File Offset: 0x00001244
		public AcpCustomRangeField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string minLabel, string maxLabel, string[] legacyUILabels) : base(new global::AcpBusinessLayer.ValueConverters.Int32ToStringConverter(), parent, name, uiLabel, legacyUILabels)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003074 File Offset: 0x00001274
		public AcpCustomRangeField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string minLabel, string maxLabel) : base(value, new global::AcpBusinessLayer.ValueConverters.Int32ToStringConverter(), parent, name, uiLabel)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000030A4 File Offset: 0x000012A4
		public AcpCustomRangeField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string minLabel, string maxLabel, string[] legacyUILabels) : base(value, new global::AcpBusinessLayer.ValueConverters.Int32ToStringConverter(), parent, name, uiLabel, legacyUILabels)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000030D4 File Offset: 0x000012D4
		public AcpCustomRangeField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string minLabel, string maxLabel) : base(converter, parent, name, uiLabel)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000030FC File Offset: 0x000012FC
		public AcpCustomRangeField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string minLabel, string maxLabel, string[] legacyUILabels) : base(converter, parent, name, uiLabel, legacyUILabels)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003126 File Offset: 0x00001326
		public AcpCustomRangeField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, string minLabel, string maxLabel) : base(new global::AcpBusinessLayer.ValueConverters.Int32ToStringConverter(), parent, name, uiLabel, min, max, step)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000314C File Offset: 0x0000134C
		public AcpCustomRangeField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, string minLabel, string maxLabel, string[] legacyUILabels) : base(new global::AcpBusinessLayer.ValueConverters.Int32ToStringConverter(), parent, name, uiLabel, min, max, step, legacyUILabels)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003180 File Offset: 0x00001380
		public AcpCustomRangeField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, string minLabel, string maxLabel) : base(value, converter, parent, name, uiLabel, min, max, step)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000031B0 File Offset: 0x000013B0
		public AcpCustomRangeField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, string minLabel, string maxLabel, string[] legacyUILabels) : base(value, converter, parent, name, uiLabel, min, max, step, legacyUILabels)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000031E4 File Offset: 0x000013E4
		public AcpCustomRangeField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, string minLabel, string maxLabel) : base(value, new global::AcpBusinessLayer.ValueConverters.Int32ToStringConverter(), parent, name, uiLabel, min, max, step)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003218 File Offset: 0x00001418
		public AcpCustomRangeField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, string minLabel, string maxLabel, string[] legacyUILabels) : base(value, new global::AcpBusinessLayer.ValueConverters.Int32ToStringConverter(), parent, name, uiLabel, min, max, step, legacyUILabels)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000324D File Offset: 0x0000144D
		public AcpCustomRangeField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, string minLabel, string maxLabel) : base(converter, parent, name, uiLabel, min, max, step)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003270 File Offset: 0x00001470
		public AcpCustomRangeField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, string minLabel, string maxLabel, string[] legacyUILabels) : base(converter, parent, name, uiLabel, min, max, step, legacyUILabels)
		{
			this.minLabel = minLabel;
			this.maxLabel = maxLabel;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000032A0 File Offset: 0x000014A0
		protected override bool CheckRange(int value)
		{
			short num = (short)678756352;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1517098940;
				short num3 = num;
				num = (short)167647164;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				case 1:
					break;
				default:
				{
					num = (short)1846607872;
					short num4 = num;
					break;
				}
				}
				num = (short)1890975744;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				case 1:
					num = (short)1420230657;
					if (num != 0)
					{
					}
					if (!this.customValues.ContainsKey(value))
					{
						num = (short)2117337091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					num = (short)1438973953;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_135;
				}
				IL_A9:
				if (this.customValues == null)
				{
					break;
				}
				num = (short)1434320898;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CB:
			return base.CheckRange(value);
			IL_135:
			goto IL_CB;
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000033E8 File Offset: 0x000015E8
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00003498 File Offset: 0x00001698
		public override int Value
		{
			get
			{
				short num = (short)1787297792;
				short num2 = num;
				num = (short)1162159377;
				short num3 = num;
				num = (short)1255154961;
				switch (num3 == num)
				{
				}
				num = (short)493682689;
				if (num != 0)
				{
				}
				num = (short)1414529024;
				if (num != 0)
				{
				}
				return base.Value;
			}
			set
			{
				short num = (short)947126273;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						this.FirePropertyChangedEvent();
						num = (short)1268228021;
						short num3 = num;
						num = (short)1587584949;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1815216128;
							if (num != 0)
							{
							}
							num = (short)1852178434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						goto IL_CE;
					}
					IL_31:
					bool uiinvalid = base.UIInvalid;
					base.UIInvalid = false;
					base.Value = value;
					this.ValueChanged = true;
					if (!uiinvalid)
					{
						goto IL_FB;
					}
					num = (short)1153433600;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CE:
				num = (short)1116340224;
				short num4 = num;
				IL_FB:
				num = (short)1826619393;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000024 RID: 36 RVA: 0x000035C8 File Offset: 0x000017C8
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000038A4 File Offset: 0x00001AA4
		public override string UIValue
		{
			get
			{
				short num = (short)1918631942;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_284;
					case 1:
					{
						num = (short)1044971521;
						if (num != 0)
						{
						}
						num = (short)1878919319;
						short num3 = num;
						num = (short)514721943;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_146;
						default:
							num = (short)1196097536;
							if (num != 0)
							{
							}
							num = (short)1426325516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_16F;
					case 3:
						num = (short)240189451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.minLabel != null)
						{
							num = (short)396754954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_286;
					case 5:
						goto IL_7C;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					case 7:
						goto IL_21D;
					case 8:
						if (this.customValues != null)
						{
							num = (short)906362883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C8;
					case 9:
						if (this.Value == base.Min)
						{
							num = (short)35520512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_286;
					case 10:
						num = (short)2061697033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.customValues.ContainsKey(this.Value))
						{
							num = (short)1178075143;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C8;
					case 12:
						goto IL_146;
					case 13:
						if (this.maxLabel != null)
						{
							num = (short)603979777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81;
					}
					IL_5D:
					if (base.UIInvalid)
					{
						num = (short)1523187717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1316356096;
					short num4 = num;
					num = (short)259784708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_81:
					num = (short)949747720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_146:
					if (this.Value == base.Max)
					{
						num = (short)1316945922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_81;
					IL_286:
					num = (short)1150156813;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_7C:
				return base.DirectUIValue;
				IL_16F:
				return this.maxLabel;
				IL_21D:
				return this.customValues[this.Value];
				IL_284:
				return this.minLabel;
				IL_2C8:
				return base.UIValue;
			}
			set
			{
				short num = (short)375128086;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1534263301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (value == string.Empty)
						{
							num = (short)1159331863;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)168034314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1637482525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.minLabel.StartsWith(value, global::System.StringComparison.CurrentCultureIgnoreCase))
						{
							num = (short)462094363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_500;
					case 4:
						if (value != null)
						{
							num = (short)1512701959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_666;
					case 5:
						if (this.IsUISpecial)
						{
							num = (short)1693646856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_469;
					case 7:
						num = (short)317390876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						base.SetUITimer();
						num = (short)535363593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return;
					case 10:
						goto IL_29B;
					case 11:
						if (value != null)
						{
							num = (short)1156972560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_500;
					case 12:
						return;
					case 13:
						if (this.customValues != null)
						{
							num = (short)626393090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_310;
					case 14:
						goto IL_25C;
					case 15:
						if (this.UIValue != value)
						{
							num = (short)459407360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						num = (short)73728003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						num = (short)691651999;
						short num3 = num;
						num = (short)2091304351;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_29B;
						default:
							num = (short)1204420608;
							if (num != 0)
							{
							}
							num = (short)848953355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 18:
						num = (short)1393885185;
						if (num != 0)
						{
						}
						try
						{
							num = (short)744161282;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1309474819;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (this.UIValue != value)
									{
										num = (short)1920598024;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11D;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_118;
									}
									continue;
								case 3:
									goto IL_249;
								case 4:
									goto IL_131;
								case 5:
								{
									global::System.Collections.Generic.Dictionary<int, string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1211432960;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<int, string> keyValuePair = enumerator.Current;
									num = (short)418906118;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::System.Collections.Generic.KeyValuePair<int, string> keyValuePair;
									if (keyValuePair.Value.StartsWith(value, global::System.StringComparison.CurrentCultureIgnoreCase))
									{
										num = (short)1519583239;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::System.Collections.Generic.KeyValuePair<int, string> keyValuePair;
									this.Value = keyValuePair.Key;
									this.FirePropertyChangedEvent();
									num = (short)94961665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									base.SetUITimer();
									num = (short)444268553;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_11D;
								}
								goto IL_118;
								IL_11D:
								num = (short)614924292;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D3:
								num = (short)175833093;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_118:
								goto IL_1D3;
							}
							IL_131:
							return;
							IL_249:
							goto IL_310;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<int, string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_25C;
					case 19:
					{
						global::System.Collections.Generic.Dictionary<int, string>.Enumerator enumerator = this.customValues.GetEnumerator();
						num = (short)943718418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_469;
					case 21:
						goto IL_469;
					case 22:
						switch (0)
						{
						case 0:
							goto IL_9D;
						}
						continue;
					case 23:
						this.Value = base.Min;
						num = (short)2134048792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_469;
					case 25:
						num = (short)171966468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (this.maxLabel != null)
						{
							num = (short)1321009177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_666;
					case 27:
						this.Value = base.Min;
						num = (short)710279174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (this.maxLabel.StartsWith(value, global::System.StringComparison.CurrentCultureIgnoreCase))
						{
							num = (short)127729678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_666;
					case 29:
						if (value != null)
						{
							num = (short)1856700435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_310;
					}
					IL_9D:
					if (value == this.UIValue)
					{
						num = (short)1045954572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1344995329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25C:
					this.Value = base.Max;
					num = (short)1959788564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_29B:
					if (this.minLabel != null)
					{
						num = (short)848101393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_500;
					IL_310:
					base.UIValue = value;
					num = (short)21823509;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_469:
					num = (short)835780608;
					short num4 = num;
					this.FirePropertyChangedEvent();
					num = (short)654966799;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_500:
					num = (short)811794458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_666:
					num = (short)1244463117;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00003F74 File Offset: 0x00002174
		private bool IsUISpecial
		{
			get
			{
				short num = (short)886505477;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.Dictionary<int, string>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_1C8;
					case 1:
					{
						num = (short)1503330304;
						short num3 = num;
						if (this.Value == base.Max)
						{
							num = (short)214564865;
							if (num != 0)
							{
							}
							num = (short)954269700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2147155971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)917307397;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1B8;
								case 1:
									result = true;
									num = (short)1416101894;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.KeyValuePair<int, string> keyValuePair;
									if (keyValuePair.Key == this.Value)
									{
										num = (short)1146683393;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)768081920;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)763101187;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)900091484;
									short num4 = num;
									num = (short)159272540;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)2026635264;
										if (num != 0)
										{
										}
										global::System.Collections.Generic.KeyValuePair<int, string> keyValuePair = enumerator.Current;
										num = (short)461307906;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_AB;
									}
									continue;
								case 6:
									goto IL_C8;
								}
								IL_165:
								num = (short)621543428;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AB:
								goto IL_165;
							}
							IL_C8:
							return result;
							IL_1B8:
							return false;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1C8;
					case 3:
						if (this.customValues != null)
						{
							num = (short)1080164352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						goto IL_285;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_41;
						}
						continue;
					case 6:
						num = (short)2052128769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_41:
					if (this.Value != base.Min)
					{
						num = (short)47644678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1C8:
					enumerator = this.customValues.GetEnumerator();
					num = (short)664993794;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_285:
				return true;
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00004268 File Offset: 0x00002468
		public void AddCustomValue(int customValue, string label)
		{
			short num = (short)1450901510;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1E2;
				case 1:
					if (customValue == this.Value)
					{
						num = (short)470220803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E4;
				case 2:
				{
					if (!this.CustomValueOutOfRange)
					{
						goto IL_1E4;
					}
					num = (short)32658952;
					short num3 = num;
					num = (short)2037929480;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B7;
					default:
						num = (short)1139867649;
						if (num != 0)
						{
						}
						num = (short)1615921152;
						if (num != 0)
						{
						}
						num = (short)1785856005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					base.ForceValid = true;
					base.UIInvalid = false;
					num = (short)1708916736;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1B7;
				case 5:
				{
					num = (short)1058406400;
					short num4 = num;
					num = (short)781647873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 7:
					this.customValues = new global::System.Collections.Generic.Dictionary<int, string>();
					num = (short)1692663812;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_45:
				if (this.customValues == null)
				{
					num = (short)1481900039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D2:
				this.CustomValueOutOfRange = !base.CheckRange(customValue);
				num = (short)18939906;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B7:
				goto IL_D2;
			}
			IL_1E2:
			IL_1E4:
			this.customValues[customValue] = label;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00004468 File Offset: 0x00002668
		public void ReplaceCustomValue(int customValue, string label)
		{
			short num = (short)1394072516;
			short num2 = num;
			num = (short)730782660;
			switch (num2 == num)
			{
			}
			num = (short)1014890496;
			if (num != 0)
			{
			}
			num = (short)772800513;
			if (num != 0)
			{
			}
			num = (short)515440640;
			short num3 = num;
			this.customValues.Clear();
			this.customValues[customValue] = label;
			this.FirePropertyChangedEvent();
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00004530 File Offset: 0x00002730
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000045E8 File Offset: 0x000027E8
		private bool CustomValueOutOfRange
		{
			get
			{
				short num = (short)213748381;
				short num2 = num;
				num = (short)118131357;
				switch (num2 == num)
				{
				}
				num = (short)163577857;
				if (num != 0)
				{
				}
				num = (short)2016608256;
				if (num != 0)
				{
				}
				num = (short)694616064;
				short num3 = num;
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.HasSpecialRange) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num;
				if (value)
				{
					for (;;)
					{
						num = (short)236928495;
						short num2 = num;
						num = (short)608779759;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_3D;
						}
					}
					IL_3D:
					num = (short)1498415104;
					if (num != 0)
					{
					}
					num = (short)1077805057;
					if (num != 0)
					{
					}
					this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.HasSpecialRange;
					return;
				}
				num = (short)1097400320;
				short num3 = num;
				this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.HasSpecialRange;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000046C0 File Offset: 0x000028C0
		public override void StepUp()
		{
			short num = (short)651952132;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)420741121;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (this.Value == base.Max)
					{
						num = (short)1942159363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24E;
				case 1:
					try
					{
						num = (short)188284933;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1D0;
							case 1:
								goto IL_16C;
							case 2:
							{
								num = (short)787713364;
								short num3 = num;
								num = (short)452889940;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_179;
								default:
									num = (short)91947008;
									if (num != 0)
									{
									}
									num = (short)2079719424;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								int value;
								this.Value = value;
								num = (short)173604865;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								int value;
								if (!base.CheckRange(value))
								{
									num = (short)1308753923;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								switch (0)
								{
								case 0:
									goto IL_C9;
								}
								continue;
							case 6:
							{
								global::System.Collections.Generic.Dictionary<int, string>.KeyCollection.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)2019295234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								int value = enumerator.Current;
								goto IL_179;
							}
							}
							IL_CB:
							num = (short)2108948486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C9:
							goto IL_CB;
							IL_179:
							num = (short)113508356;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_16C:
						IL_1D0:
						return;
					}
					finally
					{
						global::System.Collections.Generic.Dictionary<int, string>.KeyCollection.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1E3;
				case 2:
					return;
				case 3:
				{
					global::System.Collections.Generic.Dictionary<int, string>.KeyCollection.Enumerator enumerator = this.customValues.Keys.GetEnumerator();
					num = (short)864092161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_64;
					}
					continue;
				case 5:
					goto IL_1E3;
				}
				IL_64:
				if (this.CustomValueOutOfRange)
				{
					num = (short)470745093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_24E;
				IL_1E3:
				num = (short)1073741824;
				short num4 = num;
				num = (short)529006592;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_24E:
				base.StepUp();
				num = (short)216596482;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00004988 File Offset: 0x00002B88
		public override void StepDown()
		{
			short num = (short)2038431748;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.Value == base.Min)
					{
						num = (short)920780803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_246;
				case 1:
					try
					{
						num = (short)915144709;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1CA;
							case 1:
								goto IL_169;
							case 2:
							{
								num = (short)463094656;
								short num3 = num;
								num = (short)595018624;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_176;
								default:
									num = (short)2033385472;
									if (num != 0)
									{
									}
									num = (short)933494784;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								int value;
								this.Value = value;
								num = (short)459341825;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								int value;
								if (!base.CheckRange(value))
								{
									num = (short)1240399875;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								switch (0)
								{
								case 0:
									goto IL_C9;
								}
								continue;
							case 6:
							{
								global::System.Collections.Generic.Dictionary<int, string>.KeyCollection.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1174667266;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								int value = enumerator.Current;
								goto IL_176;
							}
							}
							IL_CB:
							num = (short)187301894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_C9:
							goto IL_CB;
							IL_176:
							num = (short)1349976068;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_169:
						IL_1CA:
						return;
					}
					finally
					{
						global::System.Collections.Generic.Dictionary<int, string>.KeyCollection.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1DD;
				case 2:
					return;
				case 3:
				{
					global::System.Collections.Generic.Dictionary<int, string>.KeyCollection.Enumerator enumerator = this.customValues.Keys.GetEnumerator();
					num = (short)1290207233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 5:
					goto IL_1DD;
				}
				IL_3D:
				num = (short)829685761;
				if (num != 0)
				{
				}
				if (this.CustomValueOutOfRange)
				{
					num = (short)1186267141;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_246;
				IL_1DD:
				num = (short)1807876096;
				short num4 = num;
				num = (short)1971912704;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_246:
				base.StepDown();
				num = (short)687210498;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004C48 File Offset: 0x00002E48
		public string GetSpecialValue(int value)
		{
			short num = (short)192086026;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_AE;
				case 1:
				{
					if (!this.customValues.ContainsKey(value))
					{
						goto IL_26A;
					}
					num = (short)1874770977;
					short num3 = num;
					num = (short)1033092129;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AE;
					default:
						num = (short)1828257792;
						if (num != 0)
						{
						}
						num = (short)1853489159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)1838415877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (value == base.Min)
					{
						num = (short)1481244676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_203;
				case 4:
					goto IL_131;
				case 5:
					if (value == base.Max)
					{
						num = (short)2035089417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78;
				case 6:
					num = (short)1880227843;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_1BF;
				case 8:
					num = (short)1639120897;
					if (num != 0)
					{
					}
					if (this.maxLabel != null)
					{
						num = (short)742195202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78;
				case 9:
					goto IL_1FE;
				case 10:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 11:
					if (this.customValues != null)
					{
						num = (short)1964179456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26A;
				}
				IL_54:
				if (this.minLabel != null)
				{
					num = (short)1418919942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_203;
				IL_78:
				num = (short)934871051;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_AE:
				num = (short)86573057;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_203:
				num = (short)1767964680;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_131:
			num = (short)1622671360;
			short num4 = num;
			return this.minLabel;
			IL_1BF:
			return this.customValues[value];
			IL_1FE:
			return this.maxLabel;
			IL_26A:
			return null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004EC0 File Offset: 0x000030C0
		public string GetSpecialValue(string value)
		{
			short num = (short)1313210377;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1952579584;
					short num3 = num;
					num = (short)1779302404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_258;
				case 2:
				{
					global::System.Collections.Generic.Dictionary<int, string>.Enumerator enumerator = this.customValues.GetEnumerator();
					num = (short)2067595270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					if (this.minLabel.StartsWith(value, global::System.StringComparison.CurrentCultureIgnoreCase))
					{
						num = (short)1586167809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_319;
				case 4:
					num = (short)1695678465;
					if (num != 0)
					{
					}
					if (this.maxLabel.StartsWith(value, global::System.StringComparison.CurrentCultureIgnoreCase))
					{
						num = (short)516751368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D2;
				case 5:
					num = (short)1089208323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					try
					{
						num = (short)46727173;
						num2 = (int)((global::System.IntPtr)num);
						string value2;
						for (;;)
						{
							global::System.Collections.Generic.KeyValuePair<int, string> keyValuePair;
							switch (num2)
							{
							case 0:
								goto IL_1BF;
							case 1:
								if (keyValuePair.Value.StartsWith(value, global::System.StringComparison.CurrentCultureIgnoreCase))
								{
									num = (short)1171849220;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 2:
							{
								num = (short)1633066859;
								short num4 = num;
								num = (short)441032555;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_182;
								default:
									num = (short)1299709952;
									if (num != 0)
									{
									}
									num = (short)1095892992;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								goto IL_1A3;
							case 4:
								goto IL_182;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_B6;
								}
								continue;
							case 6:
							{
								global::System.Collections.Generic.Dictionary<int, string>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)798097410;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								keyValuePair = enumerator.Current;
								num = (short)920256513;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_B8:
							num = (short)109248518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B6:
							goto IL_B8;
							IL_182:
							value2 = keyValuePair.Value;
							num = (short)1375928323;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1A3:
						return value2;
						IL_1BF:
						goto IL_283;
					}
					finally
					{
						global::System.Collections.Generic.Dictionary<int, string>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_1D2;
				case 7:
					if (this.maxLabel != null)
					{
						num = (short)1561657344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D2;
				case 8:
					goto IL_317;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 10:
					if (this.customValues != null)
					{
						num = (short)1985150978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_283;
				}
				IL_50:
				if (this.minLabel != null)
				{
					num = (short)1114439685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_319;
				IL_1D2:
				num = (short)316669962;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_319:
				num = (short)818610183;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_258:
			return this.minLabel;
			IL_283:
			return null;
			IL_317:
			return this.maxLabel;
		}

		// Token: 0x04000006 RID: 6
		private global::System.Collections.Generic.Dictionary<int, string> customValues;

		// Token: 0x04000007 RID: 7
		private string minLabel;

		// Token: 0x04000008 RID: 8
		private string maxLabel;
	}
}
