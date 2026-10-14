using System;
using NPOI.HSSF.Record;
using NPOI.HSSF.Record.CF;
using NPOI.HSSF.Record.Common;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x02000352 RID: 850
	public class HSSFColorScaleFormatting : global::NPOI.SS.UserModel.IColorScaleFormatting
	{
		// Token: 0x0600193C RID: 6460 RVA: 0x0004D860 File Offset: 0x0004BA60
		protected internal HSSFColorScaleFormatting(global::NPOI.HSSF.Record.CFRule12Record cfRule12Record, global::NPOI.HSSF.UserModel.HSSFSheet sheet)
		{
			this.sheet = sheet;
			this.cfRule12Record = cfRule12Record;
			this.colorFormatting = this.cfRule12Record.ColorGradientFormatting;
		}

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x0600193D RID: 6461 RVA: 0x0004D887 File Offset: 0x0004BA87
		// (set) Token: 0x0600193E RID: 6462 RVA: 0x0004D894 File Offset: 0x0004BA94
		public int NumControlPoints
		{
			get
			{
				return this.colorFormatting.NumControlPoints;
			}
			set
			{
				this.colorFormatting.NumControlPoints = value;
			}
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x0600193F RID: 6463 RVA: 0x0004D8A4 File Offset: 0x0004BAA4
		// (set) Token: 0x06001940 RID: 6464 RVA: 0x0004D8E4 File Offset: 0x0004BAE4
		public global::NPOI.SS.UserModel.IColor[] Colors
		{
			get
			{
				global::NPOI.HSSF.Record.Common.ExtendedColor[] colors = this.colorFormatting.Colors;
				global::NPOI.HSSF.UserModel.HSSFExtendedColor[] array = new global::NPOI.HSSF.UserModel.HSSFExtendedColor[colors.Length];
				for (int i = 0; i < colors.Length; i++)
				{
					array[i] = new global::NPOI.HSSF.UserModel.HSSFExtendedColor(colors[i]);
				}
				return array;
			}
			set
			{
				global::NPOI.HSSF.Record.Common.ExtendedColor[] array = new global::NPOI.HSSF.Record.Common.ExtendedColor[value.Length];
				for (int i = 0; i < value.Length; i++)
				{
					array[i] = ((global::NPOI.HSSF.UserModel.HSSFExtendedColor)value[i]).ExtendedColor;
				}
				this.colorFormatting.Colors = array;
			}
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001941 RID: 6465 RVA: 0x0004D924 File Offset: 0x0004BB24
		// (set) Token: 0x06001942 RID: 6466 RVA: 0x0004D96C File Offset: 0x0004BB6C
		public global::NPOI.SS.UserModel.IConditionalFormattingThreshold[] Thresholds
		{
			get
			{
				global::NPOI.HSSF.Record.CF.Threshold[] thresholds = this.colorFormatting.Thresholds;
				global::NPOI.HSSF.Record.CF.Threshold[] array = thresholds;
				global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold[] array2 = new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold[array.Length];
				for (int i = 0; i < array.Length; i++)
				{
					array2[i] = new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold(array[i], this.sheet);
				}
				return array2;
			}
			set
			{
				global::NPOI.HSSF.Record.CF.ColorGradientThreshold[] array = new global::NPOI.HSSF.Record.CF.ColorGradientThreshold[value.Length];
				for (int i = 0; i < array.Length; i++)
				{
					global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold hssfconditionalFormattingThreshold = (global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold)value[i];
					array[i] = (global::NPOI.HSSF.Record.CF.ColorGradientThreshold)hssfconditionalFormattingThreshold.Threshold;
				}
				this.colorFormatting.Thresholds = array;
			}
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0004D9B3 File Offset: 0x0004BBB3
		public global::NPOI.SS.UserModel.IConditionalFormattingThreshold CreateThreshold()
		{
			return new global::NPOI.HSSF.UserModel.HSSFConditionalFormattingThreshold(new global::NPOI.HSSF.Record.CF.ColorGradientThreshold(), this.sheet);
		}

		// Token: 0x04000A12 RID: 2578
		private global::NPOI.HSSF.UserModel.HSSFSheet sheet;

		// Token: 0x04000A13 RID: 2579
		private global::NPOI.HSSF.Record.CFRule12Record cfRule12Record;

		// Token: 0x04000A14 RID: 2580
		private global::NPOI.HSSF.Record.CF.ColorGradientFormatting colorFormatting;
	}
}
