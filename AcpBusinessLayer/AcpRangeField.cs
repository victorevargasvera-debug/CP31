using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Data;
using AcpBusinessLayer.Impl;
using AcpBusinessLayer.UndoRedo;
using AcpBusinessLayer.ValueConverters;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer
{
	// Token: 0x02000007 RID: 7
	[global::System.Serializable]
	public class AcpRangeField<TDBType, TUIType> : global::AcpBusinessLayer.AcpFieldX<int, TUIType>, global::AcpCommonLib.IAcpRangeField where TDBType : global::System.IComparable where TUIType : global::System.IComparable
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0000524C File Offset: 0x0000344C
		public AcpRangeField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(value, parent, name, uiLabel)
		{
			if (converter == null)
			{
				base.Converter = new global::AcpBusinessLayer.ValueConverters.DummyConverter();
				return;
			}
			base.Converter = converter;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005280 File Offset: 0x00003480
		public AcpRangeField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : base(value, parent, name, uiLabel, legacyUILabels)
		{
			if (converter == null)
			{
				base.Converter = new global::AcpBusinessLayer.ValueConverters.DummyConverter();
				return;
			}
			base.Converter = converter;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000052B4 File Offset: 0x000034B4
		public AcpRangeField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(converter, parent, name, uiLabel)
		{
			if (converter == null)
			{
				base.Converter = new global::AcpBusinessLayer.ValueConverters.DummyConverter();
				return;
			}
			base.Converter = converter;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000052E4 File Offset: 0x000034E4
		public AcpRangeField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : base(converter, parent, name, uiLabel, legacyUILabels)
		{
			if (converter == null)
			{
				base.Converter = new global::AcpBusinessLayer.ValueConverters.DummyConverter();
				return;
			}
			base.Converter = converter;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00005318 File Offset: 0x00003518
		public AcpRangeField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step) : base(value, parent, name, uiLabel)
		{
			if (step <= 0)
			{
				this.StepSize = 1;
			}
			else
			{
				this.StepSize = step;
			}
			this.Min = min;
			this.Max = max;
			if (converter == null)
			{
				base.Converter = new global::AcpBusinessLayer.ValueConverters.DummyConverter();
				return;
			}
			base.Converter = converter;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005374 File Offset: 0x00003574
		public AcpRangeField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, string[] legacyUILabels) : base(value, parent, name, uiLabel, legacyUILabels)
		{
			if (step <= 0)
			{
				this.StepSize = 1;
			}
			else
			{
				this.StepSize = step;
			}
			this.Min = min;
			this.Max = max;
			if (converter == null)
			{
				base.Converter = new global::AcpBusinessLayer.ValueConverters.DummyConverter();
				return;
			}
			base.Converter = converter;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000053D4 File Offset: 0x000035D4
		public AcpRangeField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step) : base(min, parent, name, uiLabel)
		{
			if (step <= 0)
			{
				this.StepSize = 1;
			}
			else
			{
				this.StepSize = step;
			}
			this.Min = min;
			this.Max = max;
			if (converter == null)
			{
				base.Converter = new global::AcpBusinessLayer.ValueConverters.DummyConverter();
				return;
			}
			base.Converter = converter;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005430 File Offset: 0x00003630
		public AcpRangeField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, string[] legacyUILabels) : base(min, parent, name, uiLabel, legacyUILabels)
		{
			if (step <= 0)
			{
				this.StepSize = 1;
			}
			else
			{
				this.StepSize = step;
			}
			this.Min = min;
			this.Max = max;
			if (converter == null)
			{
				base.Converter = new global::AcpBusinessLayer.ValueConverters.DummyConverter();
				return;
			}
			base.Converter = converter;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005490 File Offset: 0x00003690
		public AcpRangeField(TUIType uiValue, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step) : base(uiValue, converter, parent, name, uiLabel)
		{
			if (step <= 0)
			{
				this.StepSize = 1;
			}
			else
			{
				this.StepSize = step;
			}
			this.Min = min;
			this.Max = max;
			if (converter == null)
			{
				base.Converter = new global::AcpBusinessLayer.ValueConverters.DummyConverter();
				return;
			}
			base.Converter = converter;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000038 RID: 56 RVA: 0x000054EC File Offset: 0x000036EC
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0000559C File Offset: 0x0000379C
		public override int Value
		{
			get
			{
				short num = (short)1195008196;
				short num2 = num;
				num = (short)216162500;
				switch (num2 == num)
				{
				default:
				{
					num = (short)667287552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)832438273;
				if (num != 0)
				{
				}
				num = (short)1365377024;
				if (num != 0)
				{
				}
				return base.Value;
			}
			set
			{
				short num = (short)742195200;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					bool forceValid;
					bool uiinvalid;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
							if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
							{
								num = (short)1116274700;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_137;
						case 1:
							base.CalculateValidityWithDep();
							num = (short)2085421074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (!this.CheckRange(value))
							{
								num = (short)1315242005;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_137;
						case 3:
							if (!forceValid)
							{
								num = (short)954466314;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_191;
						case 4:
							num = (short)1508376583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (!forceValid)
							{
								num = (short)1570308097;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 6:
							num = (short)1715929093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (base.UIInvalid)
							{
								num = (short)329515019;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4F1;
						case 8:
							goto IL_290;
						case 9:
							if (this.Value == value)
							{
								num = (short)622854145;
								if (num != 0)
								{
								}
								num = (short)1616969747;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)517406720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							base.CalculateValidityWithDep();
							num = (short)2143485972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_270;
						case 12:
							num = (short)288227330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							num = (short)1464205312;
							short num3 = num;
							if (!uiinvalid)
							{
								num = (short)50659332;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_270;
						}
						case 14:
							num = (short)276824067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (base.ForceValid)
							{
								num = (short)2144337926;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 16:
							goto IL_230;
						case 17:
							if (base.ForceValid)
							{
								num = (short)1748762638;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_191;
						case 18:
							goto IL_18C;
						case 19:
							base.ForceValid = this.CheckRange(this.Value);
							num = (short)1425342479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							goto IL_191;
						case 21:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_2BA;
								}
								global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
								for (;;)
								{
									IL_29F:
									switch (num2)
									{
									case 0:
									{
										global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(undoableTask.ToString());
										containerTask.AddTask(undoableTask);
										this.CallValueSetter(containerTask);
										global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
										base.SetUITimer();
										num = (short)671219713;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_37C;
									case 2:
										if (base.ValueSetter != null)
										{
											num = (short)146997248;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.UndoRedo.UndoManager.AddTask(undoableTask);
										num = (short)1579352067;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_37C;
									case 4:
										goto IL_394;
									}
									goto IL_2BA;
									IL_37C:
									num = (short)2053111812;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_394:
								goto IL_230;
								IL_2BA:
								object obj = base.Converter.Convert(value, null, base.ConverterParameterObject, null);
								undoableTask = new global::AcpBusinessLayer.UndoRedo.SetValueTask(this, obj.ToString());
								num = (short)1878589442;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_29F;
							}
							catch
							{
								base.Value = value;
								base.ForceValid = this.CheckRange(this.Value);
								goto IL_230;
							}
							return;
						}
						goto IL_86;
						IL_137:
						base.Value = value;
						base.ForceValid = this.CheckRange(this.Value);
						num = (short)350158864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_191:
						num = (short)57212941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_230:
						num = (short)1949564945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_270:
						this.FirePropertyChangedEvent();
						num = (short)1568079880;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_18C:
					return;
					IL_290:
					IL_4F1:
					num = (short)44931455;
					short num4 = num;
					num = (short)546871679;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_290;
					default:
						num = (short)323682304;
						if (num != 0)
						{
						}
						return;
					}
					IL_86:
					uiinvalid = base.UIInvalid;
					forceValid = base.ForceValid;
					num = (short)1260781577;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00005B04 File Offset: 0x00003D04
		// (set) Token: 0x0600003B RID: 59 RVA: 0x00005BB4 File Offset: 0x00003DB4
		public override TUIType UIValue
		{
			get
			{
				short num = (short)1125439881;
				short num2 = num;
				num = (short)1363466633;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1222377472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1698824193;
				if (num != 0)
				{
				}
				num = (short)1061093376;
				if (num != 0)
				{
				}
				return base.UIValue;
			}
			set
			{
				short num = (short)1024458753;
				if (num != 0)
				{
				}
				num = (short)521666560;
				short num2 = num;
				num = (short)25890664;
				short num3 = num;
				num = (short)589565800;
				switch (num3 == num)
				{
				}
				num = (short)665845760;
				if (num != 0)
				{
				}
				base.UIValue = value;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005C64 File Offset: 0x00003E64
		protected virtual bool CheckRange(int value)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_B3;
				case 1:
					if (num2.CompareTo(value) <= 0)
					{
						num3 = (short)132841472;
						short num4 = num3;
						num3 = (short)50790400;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 2:
				{
					if (num2.CompareTo(value) < 0)
					{
						return false;
					}
					num3 = (short)1798699690;
					short num5 = num3;
					num3 = (short)893844138;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B3;
					default:
						num3 = (short)426639360;
						if (num3 != 0)
						{
						}
						num3 = (short)2035351555;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 3:
					goto IL_14B;
				}
				goto IL_20;
				IL_B3:
				num2 = this.Max;
				num3 = (short)404684802;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_14B:
			return this.c(value);
			IL_20:
			num3 = (short)424214529;
			if (num3 != 0)
			{
			}
			num2 = this.Min;
			num3 = (short)649986049;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00005DC4 File Offset: 0x00003FC4
		protected internal override void FirePropertyChangedEvent()
		{
			int a_ = 10;
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
						num2 = (short)711131137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)1613037569;
					if (num2 != 0)
					{
					}
					num2 = (short)23724032;
					short num3 = num2;
					((global::AcpBusinessLayer.FeatureSection)base.Parent).FirePropertyChanged(base.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("菛雝藟髡뇣꿥뻧诩胫鯭闯", a_));
					num2 = (short)991651838;
					short num4 = num2;
					num2 = (short)2006476798;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num2 = (short)1334509568;
						if (num2 != 0)
						{
						}
						num2 = (short)1742209026;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_25;
			}
			return;
			IL_25:
			base.FirePropertyChangedEvent();
			num2 = (short)1917059072;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005F0C File Offset: 0x0000410C
		internal override void DeepCopy(global::AcpCommonLib.IAcpField source)
		{
			short num = (short)2097090570;
			short num2 = num;
			num = (short)869666826;
			switch (num2 == num)
			{
			default:
			{
				num = (short)149553152;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)270467073;
			if (num != 0)
			{
			}
			num = (short)2092171264;
			if (num != 0)
			{
			}
			base.DeepCopy(source);
			base.ForceValid = this.CheckRange(this.Value);
			this.UIValue = ((global::AcpBusinessLayer.AcpRangeField<TDBType, TUIType>)source).UIValue;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00005FE0 File Offset: 0x000041E0
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00006194 File Offset: 0x00004394
		public string HexUIValue
		{
			get
			{
				int a_ = 14;
				switch (0)
				{
				case 0:
					goto IL_2D;
				}
				int num;
				short num2;
				string text;
				for (;;)
				{
					IL_13:
					int length;
					switch (num)
					{
					case 0:
						num2 = (short)1154416641;
						if (num2 != 0)
						{
						}
						goto IL_C2;
					case 1:
						goto IL_BD;
					case 2:
						if (this.ShowLeadingZeros)
						{
							num2 = (short)649265152;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_195;
					case 3:
						if (length > 0)
						{
							num2 = (short)269615108;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_195;
					case 4:
					{
						num2 = (short)1305571155;
						short num3 = num2;
						num2 = (short)721842003;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C2;
						default:
						{
							num2 = (short)1766981632;
							if (num2 != 0)
							{
							}
							num2 = (short)1387462656;
							short num4 = num2;
							text += length.ToString();
							num2 = (short)1324220417;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_2D;
					IL_C2:
					length = this.Max.ToString(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("룟", a_)).Trim().Length;
					num2 = (short)1576927235;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_BD:
				IL_195:
				return this.Value.ToString(text);
				IL_2D:
				text = global::AcpBusinessLayer.UndoRedo.SetValueTask.b("룟", a_);
				num2 = (short)1980039170;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			set
			{
				short num = (short)1735589891;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)743243777;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)1220244812;
						short num3 = num;
						num = (short)66811212;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_184;
						default:
							goto IL_12E;
						}
						break;
					}
					case 1:
						goto IL_184;
					case 2:
					{
						base.DirectUIValue = (TUIType)((object)base.Converter.Convert(this.Value, null, base.ConverterParameterObject, null));
						num = (short)1982005248;
						short num4 = num;
						num = (short)174456832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_64;
						}
						continue;
					case 4:
						if (base.UIInvalid)
						{
							num = (short)1689583618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A5;
					case 5:
						goto IL_147;
					}
					IL_64:
					int value2;
					if (int.TryParse(value, global::System.Globalization.NumberStyles.HexNumber, null, out value2))
					{
						num = (short)1961492481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_147:
					num = (short)156172292;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_184:
					this.Value = value2;
					num = (short)1075249157;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12E:
				num = (short)1490747392;
				if (num != 0)
				{
				}
				IL_1A5:
				base.SetUITimer();
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000041 RID: 65 RVA: 0x0000634C File Offset: 0x0000454C
		// (set) Token: 0x06000042 RID: 66 RVA: 0x00006404 File Offset: 0x00004604
		public bool ShowHexValue
		{
			get
			{
				short num = (short)1130351115;
				short num2 = num;
				num = (short)1833814539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)947650560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)265748480;
				if (num != 0)
				{
				}
				num = (short)312737793;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ShowHexValue) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num;
				for (;;)
				{
					num = (short)945225729;
					if (num != 0)
					{
					}
					if (!value)
					{
						goto IL_B9;
					}
					num = (short)1969889825;
					short num2 = num;
					num = (short)2111775265;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_65;
					}
				}
				IL_65:
				num = (short)1655963648;
				short num3 = num;
				num = (short)967704576;
				if (num != 0)
				{
				}
				this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ShowHexValue;
				return;
				IL_B9:
				this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ShowHexValue;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000064DC File Offset: 0x000046DC
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00006598 File Offset: 0x00004798
		public bool ShowLeadingZeros
		{
			get
			{
				short num = (short)1934323005;
				short num2 = num;
				num = (short)632319293;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2044133376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)225443841;
				if (num != 0)
				{
				}
				num = (short)113639424;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ShowLeadingZeros) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num;
				while (value)
				{
					num = (short)775321437;
					short num2 = num;
					num = (short)1225291613;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1604845568;
						if (num != 0)
						{
						}
						num = (short)201588736;
						short num3 = num;
						this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ShowLeadingZeros;
						return;
					}
					}
				}
				num = (short)1669988353;
				if (num != 0)
				{
				}
				this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ShowLeadingZeros;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00006670 File Offset: 0x00004870
		// (set) Token: 0x06000046 RID: 70 RVA: 0x0000672C File Offset: 0x0000492C
		public int Min
		{
			get
			{
				short num = (short)1452205156;
				short num2 = num;
				num = (short)1290658916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)356450304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)803340288;
				if (num != 0)
				{
				}
				num = (short)1253769217;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpRangeFieldImpl)base.FieldData).Min;
			}
			set
			{
				short num = (short)1784128206;
				short num2 = num;
				num = (short)830317262;
				switch (num2 == num)
				{
				default:
				{
					num = (short)363266048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)354418688;
				if (num != 0)
				{
				}
				num = (short)631832577;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.Impl.AcpRangeFieldImpl)base.FieldData).Min = value;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000047 RID: 71 RVA: 0x000067E8 File Offset: 0x000049E8
		// (set) Token: 0x06000048 RID: 72 RVA: 0x000068A0 File Offset: 0x00004AA0
		public int Max
		{
			get
			{
				short num = (short)1663898762;
				short num2 = num;
				num = (short)817370250;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1799487488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)663027713;
				if (num != 0)
				{
				}
				num = (short)1290010624;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpRangeFieldImpl)base.FieldData).Max;
			}
			set
			{
				short num = (short)1337786369;
				if (num != 0)
				{
				}
				num = (short)416612352;
				short num2 = num;
				num = (short)1252681966;
				short num3 = num;
				num = (short)887056622;
				switch (num3 == num)
				{
				}
				num = (short)849018880;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.Impl.AcpRangeFieldImpl)base.FieldData).Max = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00006958 File Offset: 0x00004B58
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00006A14 File Offset: 0x00004C14
		public int StepSize
		{
			get
			{
				short num = (short)1809567670;
				short num2 = num;
				num = (short)1487982518;
				switch (num2 == num)
				{
				}
				num = (short)1469382656;
				short num3 = num;
				num = (short)664731649;
				if (num != 0)
				{
				}
				num = (short)910426112;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpRangeFieldImpl)base.FieldData).StepSize;
			}
			set
			{
				short num = (short)1151989953;
				short num2 = num;
				num = (short)2000746689;
				switch (num2 == num)
				{
				}
				num = (short)1215823872;
				short num3 = num;
				num = (short)545521665;
				if (num != 0)
				{
				}
				num = (short)275054592;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.Impl.AcpRangeFieldImpl)base.FieldData).StepSize = value;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006ACC File Offset: 0x00004CCC
		public virtual void StepUp()
		{
			short num = (short)1400176642;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (base.ForceValid)
					{
						num = (short)1468727302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.Value = this.a(this.Value);
					num = (short)807534600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.Value < this.Min)
					{
						num = (short)485294083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2130509824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)675938473;
					short num3 = num;
					num = (short)271122601;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_206;
					default:
						num = (short)972357633;
						if (num != 0)
						{
						}
						num = (short)1378091008;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_BB;
						}
						continue;
					}
					break;
				}
				case 3:
					goto IL_1B6;
				case 4:
					goto IL_204;
				case 5:
					goto IL_10B;
				case 6:
					this.Value += this.StepSize;
					num = (short)1925644293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)197132289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1B4;
				}
				IL_BB:
				if (this.Value < this.Max)
				{
					num = (short)611385351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1B6:
				num = (short)1528823808;
				short num4 = num;
				this.Value = this.Min;
				num = (short)1006043140;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			IL_1B4:
			IL_204:
			IL_206:
			base.ForceValid = true;
			base.UIInvalid = false;
			base.SetUITimer();
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006CF4 File Offset: 0x00004EF4
		public virtual void StepDown()
		{
			short num = (short)1321533442;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (base.ForceValid)
					{
						num = (short)351862790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.Value = this.b(this.Value);
					num = (short)367853576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.Value > this.Max)
					{
						num = (short)1673134083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)946929664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)493492321;
					short num3 = num;
					num = (short)1227167841;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_204;
					default:
						num = (short)1789329408;
						if (num != 0)
						{
						}
						num = (short)2137653249;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_BB;
						}
						continue;
					}
					break;
				}
				case 3:
					goto IL_1B5;
				case 4:
					goto IL_202;
				case 5:
					goto IL_10B;
				case 6:
					this.Value -= this.StepSize;
					num = (short)1835401221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1061224449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1B3;
				}
				IL_BB:
				if (this.Value > this.Min)
				{
					num = (short)1247281159;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1B5:
				num = (short)1249574912;
				short num4 = num;
				this.Value = this.Max;
				num = (short)827850756;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10B:
			IL_1B3:
			IL_202:
			IL_204:
			base.ForceValid = true;
			base.UIInvalid = false;
			base.SetUITimer();
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00006F1C File Offset: 0x0000511C
		public global::System.Collections.Generic.IEnumerable<TUIType> UIValues
		{
			get
			{
				short num = (short)331683144;
				short num2 = num;
				num = (short)2026313032;
				switch (num2 == num)
				{
				}
				num = (short)14942208;
				short num3 = num;
				num = (short)616890369;
				if (num != 0)
				{
				}
				num = (short)958398464;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpRangeField<TDBType, TUIType>.<get_UIValues>d__39 <get_UIValues>d__ = new global::AcpBusinessLayer.AcpRangeField<TDBType, TUIType>.<get_UIValues>d__39(-2);
				<get_UIValues>d__.<>4__this = this;
				return <get_UIValues>d__;
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006FD8 File Offset: 0x000051D8
		private bool c(int A_0)
		{
			short num = (short)624227994;
			short num2 = num;
			num = (short)1712912026;
			switch (num2 == num)
			{
			}
			num = (short)1021640704;
			short num3 = num;
			num = (short)87293953;
			if (num != 0)
			{
			}
			num = (short)673316864;
			if (num != 0)
			{
			}
			return (A_0 - this.Min) % this.StepSize == 0;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00007094 File Offset: 0x00005294
		private int b(int A_0)
		{
			short num = (short)2035744770;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0 > this.Max)
					{
						num = (short)1302462467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12E;
				case 1:
					num = (short)367656960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)952369153;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 3:
					goto IL_12C;
				}
				IL_5C:
				num = (short)1739763640;
				short num3 = num;
				num = (short)1727901624;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C5;
				default:
					num = (short)532021248;
					if (num != 0)
					{
					}
					if (A_0 < this.Min)
					{
						goto IL_C5;
					}
					num = (short)460652545;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C5:
			num = (short)2077032448;
			short num4 = num;
			return this.Max;
			IL_12C:
			goto IL_C5;
			IL_12E:
			int num5 = (A_0 - this.Min) / this.StepSize;
			return this.Min + this.StepSize * num5;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000071F0 File Offset: 0x000053F0
		private int a(int A_0)
		{
			short num = (short)2140143618;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0 >= this.Max)
					{
						num = (short)1860567043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_133;
				case 1:
				{
					num = (short)1722155008;
					short num3 = num;
					num = (short)531890176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 3:
					goto IL_107;
				}
				IL_35:
				num = (short)1336998426;
				short num4 = num;
				num = (short)2050554394;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A0;
				default:
					num = (short)328597504;
					if (num != 0)
					{
					}
					if (A_0 < this.Min)
					{
						goto IL_A0;
					}
					num = (short)56426497;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_A0:
			return this.Min;
			IL_107:
			num = (short)1015742465;
			if (num != 0)
			{
			}
			goto IL_A0;
			IL_133:
			int num5 = (A_0 - this.Min) / this.StepSize + 1;
			return this.Min + this.StepSize * num5;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007354 File Offset: 0x00005554
		internal override void CreateFieldData(string uiName)
		{
			short num = (short)55129519;
			short num2 = num;
			num = (short)804992431;
			switch (num2 == num)
			{
			}
			num = (short)964100096;
			short num3 = num;
			num = (short)283705345;
			if (num != 0)
			{
			}
			num = (short)1031929856;
			if (num != 0)
			{
			}
			base.FieldData = new global::AcpBusinessLayer.Impl.AcpRangeFieldImpl(uiName);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00007408 File Offset: 0x00005608
		internal override int CompareToHelper(global::AcpBusinessLayer.AcpFieldBase otherField)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_CF;
				case 1:
				{
					num2 = (short)973602816;
					short num3 = num2;
					num2 = (short)682688515;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_68;
				case 3:
					if (otherField.UIInvalid)
					{
						num2 = (short)2065301504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return 0;
				case 4:
					if (base.CompareToHelper(otherField) != 0)
					{
						num2 = (short)1136656386;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2109341701;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					num2 = (short)858837913;
					short num4 = num2;
					num2 = (short)477156249;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1331560448;
						if (num2 != 0)
						{
						}
						num2 = (short)502661121;
						if (num2 != 0)
						{
						}
						if (base.UIInvalid)
						{
							goto IL_19D;
						}
						break;
					}
					num2 = (short)1324220417;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_28;
			}
			IL_68:
			TUIType uivalue = this.UIValue;
			TUIType uivalue2;
			return uivalue.CompareTo(uivalue2);
			IL_CF:
			IL_19D:
			uivalue = this.UIValue;
			return uivalue.CompareTo(uivalue2);
			IL_28:
			uivalue2 = ((global::AcpBusinessLayer.AcpRangeField<TDBType, TUIType>)otherField).UIValue;
			num2 = (short)327745540;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000075D0 File Offset: 0x000057D0
		private global::AcpCommonLib.UndoRedo.UndoableTask a(TUIType A_0)
		{
			global::AcpBusinessLayer.UndoRedo.ModifyUIValueTask<TUIType> modifyUIValueTask = new global::AcpBusinessLayer.UndoRedo.ModifyUIValueTask<TUIType>(this, A_0);
			if (base.ValueSetter != null)
			{
				short num;
				for (;;)
				{
					num = (short)1924486166;
					short num2 = num;
					num = (short)185160726;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4C;
					}
				}
				IL_4C:
				num = (short)811139072;
				short num3 = num;
				num = (short)1813315585;
				if (num != 0)
				{
				}
				num = (short)321912832;
				if (num != 0)
				{
				}
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(modifyUIValueTask.ToString());
				containerTask.AddTask(modifyUIValueTask);
				this.CallValueSetter(containerTask);
				return containerTask;
			}
			return modifyUIValueTask;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000076B0 File Offset: 0x000058B0
		public override global::AcpCommonLib.UndoRedo.UndoableTask CopyValueOf(global::AcpCommonLib.IAcpField source)
		{
			short num = (short)1704525824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1687945216;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				TUIType uivalue2;
				int value;
				int value2;
				for (;;)
				{
					IL_50:
					switch (num2)
					{
					case 0:
						goto IL_18D;
					case 1:
					{
						TUIType uivalue = this.UIValue;
						num = (short)1332150275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_13B;
					case 3:
					{
						TUIType uivalue;
						if (!uivalue.Equals(uivalue2))
						{
							num = (short)1770127360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3;
					}
					case 4:
						if (!value.Equals(value2))
						{
							num = (short)776601602;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)599588869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (this.UIValue != null)
						{
							num = (short)425590785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DB;
					}
					goto IL_6F;
				}
				IL_13B:
				return base.CopyValueOf(source);
				IL_18D:
				IL_1DB:
				return this.a(uivalue2);
				IL_6F:
				num = (short)2085158913;
				if (num != 0)
				{
				}
				value2 = ((global::AcpBusinessLayer.AcpRangeField<TDBType, TUIType>)source).Value;
				uivalue2 = ((global::AcpBusinessLayer.AcpRangeField<TDBType, TUIType>)source).UIValue;
				value = this.Value;
				num = (short)492109496;
				short num4 = num;
				num = (short)110100152;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1E3:
					return null;
				default:
					num = (short)1997275136;
					if (num != 0)
					{
					}
					num = (short)1432223748;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_50;
				}
				break;
			}
			}
		}
	}
}
