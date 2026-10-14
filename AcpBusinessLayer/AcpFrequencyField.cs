using System;
using AcpBusinessLayer.ValueConverters;
using AcpCommonLib;

namespace AcpBusinessLayer
{
	// Token: 0x0200000F RID: 15
	[global::System.Serializable]
	public class AcpFrequencyField : global::AcpBusinessLayer.AcpRangeField<int, string>
	{
		// Token: 0x06000142 RID: 322 RVA: 0x00018974 File Offset: 0x00016B74
		public AcpFrequencyField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(value, null, parent, name, uiLabel)
		{
			base.Converter = new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(base.StepSize);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x000189A0 File Offset: 0x00016BA0
		public AcpFrequencyField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : base(value, null, parent, name, uiLabel, legacyUILabels)
		{
			base.Converter = new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(base.StepSize);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x000189CC File Offset: 0x00016BCC
		public AcpFrequencyField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, bool kilohertz) : base(value, null, parent, name, uiLabel)
		{
			base.Converter = new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(kilohertz, base.StepSize);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000189F8 File Offset: 0x00016BF8
		public AcpFrequencyField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, bool kilohertz, string[] legacyUILabels) : base(value, null, parent, name, uiLabel, legacyUILabels)
		{
			base.Converter = new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(kilohertz, base.StepSize);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00018A28 File Offset: 0x00016C28
		public AcpFrequencyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(null, parent, name, uiLabel)
		{
			base.Converter = new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(base.StepSize);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00018A50 File Offset: 0x00016C50
		public AcpFrequencyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, bool kilohertz) : base(null, parent, name, uiLabel)
		{
			base.Converter = new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(kilohertz, base.StepSize);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00018A7C File Offset: 0x00016C7C
		public AcpFrequencyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, bool kilohertz, string[] legacyUILabels) : base(null, parent, name, uiLabel, legacyUILabels)
		{
			base.Converter = new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(kilohertz, base.StepSize);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00018AA8 File Offset: 0x00016CA8
		public AcpFrequencyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step) : base(new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(step), parent, name, uiLabel, min, max, step)
		{
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00018AC0 File Offset: 0x00016CC0
		public AcpFrequencyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, string[] legacyUILabels) : base(new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(step), parent, name, uiLabel, min, max, step, legacyUILabels)
		{
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00018AE8 File Offset: 0x00016CE8
		public AcpFrequencyField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step) : base(value, new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(step), parent, name, uiLabel, min, max, step)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00018B10 File Offset: 0x00016D10
		public AcpFrequencyField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, string[] legacyUILabels) : base(value, new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(step), parent, name, uiLabel, min, max, step, legacyUILabels)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00018B37 File Offset: 0x00016D37
		public AcpFrequencyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, bool kilohertz) : base(new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(kilohertz, step), parent, name, uiLabel, min, max, step)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00018B54 File Offset: 0x00016D54
		public AcpFrequencyField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, bool kilohertz) : base(value, new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(kilohertz, step), parent, name, uiLabel, min, max, step)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00018B7C File Offset: 0x00016D7C
		public AcpFrequencyField(int value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int min, int max, int step, bool kilohertz, string[] legacyUILabels) : base(value, new global::AcpBusinessLayer.ValueConverters.FrequencyConverter(kilohertz, step), parent, name, uiLabel, min, max, step, legacyUILabels)
		{
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000150 RID: 336 RVA: 0x00018BA8 File Offset: 0x00016DA8
		// (set) Token: 0x06000151 RID: 337 RVA: 0x00018C5C File Offset: 0x00016E5C
		public override int Value
		{
			get
			{
				short num = (short)277807104;
				short num2 = num;
				num = (short)925081655;
				short num3 = num;
				num = (short)1245159479;
				switch (num3 == num)
				{
				}
				num = (short)805568513;
				if (num != 0)
				{
				}
				num = (short)2145320960;
				if (num != 0)
				{
				}
				return base.Value;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						num2 = (short)1737841671;
						short num3 = num2;
						num2 = (short)1495030791;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_41;
						default:
						{
							num2 = (short)1686831104;
							if (num2 != 0)
							{
							}
							num2 = (short)1189085184;
							short num4 = num2;
							this.CalculateApplicability();
							this.CalculateValidity();
							num2 = (short)2059599872;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 2:
						if (!global::AcpCommonLib.ConstraintManager.Suspended)
						{
							goto IL_41;
						}
						return;
					}
					goto IL_1C;
					IL_41:
					num2 = (short)1355874305;
					if (num2 != 0)
					{
					}
					num2 = (short)154599425;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				base.Value = value;
				num2 = (short)295370754;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}
	}
}
