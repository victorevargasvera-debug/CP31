using System;
using System.Text;
using NPOI.HSSF.Record.Common;
using NPOI.Util;

namespace NPOI.HSSF.Record.CF
{
	// Token: 0x020004C0 RID: 1216
	public class ColorGradientFormatting : global::System.ICloneable
	{
		// Token: 0x06002DA4 RID: 11684 RVA: 0x0008700D File Offset: 0x0008520D
		public ColorGradientFormatting()
		{
			this.options = 3;
			this.thresholds = new global::NPOI.HSSF.Record.CF.ColorGradientThreshold[3];
			this.colors = new global::NPOI.HSSF.Record.Common.ExtendedColor[3];
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00087034 File Offset: 0x00085234
		public ColorGradientFormatting(global::NPOI.Util.ILittleEndianInput in1)
		{
			in1.ReadShort();
			in1.ReadByte();
			int num = in1.ReadByte();
			int num2 = in1.ReadByte();
			this.options = (byte)in1.ReadByte();
			this.thresholds = new global::NPOI.HSSF.Record.CF.ColorGradientThreshold[num];
			for (int i = 0; i < this.thresholds.Length; i++)
			{
				this.thresholds[i] = new global::NPOI.HSSF.Record.CF.ColorGradientThreshold(in1);
			}
			this.colors = new global::NPOI.HSSF.Record.Common.ExtendedColor[num2];
			for (int j = 0; j < this.colors.Length; j++)
			{
				in1.ReadDouble();
				this.colors[j] = new global::NPOI.HSSF.Record.Common.ExtendedColor(in1);
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x06002DA6 RID: 11686 RVA: 0x000870D5 File Offset: 0x000852D5
		// (set) Token: 0x06002DA7 RID: 11687 RVA: 0x000870E0 File Offset: 0x000852E0
		public int NumControlPoints
		{
			get
			{
				return this.thresholds.Length;
			}
			set
			{
				if (value != this.thresholds.Length)
				{
					global::NPOI.HSSF.Record.CF.ColorGradientThreshold[] destinationArray = new global::NPOI.HSSF.Record.CF.ColorGradientThreshold[value];
					global::NPOI.HSSF.Record.Common.ExtendedColor[] destinationArray2 = new global::NPOI.HSSF.Record.Common.ExtendedColor[value];
					int length = global::System.Math.Min(this.thresholds.Length, value);
					global::System.Array.Copy(this.thresholds, 0, destinationArray, 0, length);
					global::System.Array.Copy(this.colors, 0, destinationArray2, 0, length);
					this.thresholds = destinationArray;
					this.colors = destinationArray2;
					this.updateThresholdPositions();
				}
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x06002DA8 RID: 11688 RVA: 0x00087147 File Offset: 0x00085347
		// (set) Token: 0x06002DA9 RID: 11689 RVA: 0x0008714F File Offset: 0x0008534F
		public global::NPOI.HSSF.Record.CF.ColorGradientThreshold[] Thresholds
		{
			get
			{
				return this.thresholds;
			}
			set
			{
				this.thresholds = ((value == null) ? null : ((global::NPOI.HSSF.Record.CF.ColorGradientThreshold[])value.Clone()));
				this.updateThresholdPositions();
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06002DAA RID: 11690 RVA: 0x0008716E File Offset: 0x0008536E
		// (set) Token: 0x06002DAB RID: 11691 RVA: 0x00087176 File Offset: 0x00085376
		public global::NPOI.HSSF.Record.Common.ExtendedColor[] Colors
		{
			get
			{
				return this.colors;
			}
			set
			{
				this.colors = ((value == null) ? null : ((global::NPOI.HSSF.Record.Common.ExtendedColor[])value.Clone()));
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06002DAC RID: 11692 RVA: 0x0008718F File Offset: 0x0008538F
		public bool IsClampToCurve
		{
			get
			{
				return this.GetOptionFlag(global::NPOI.HSSF.Record.CF.ColorGradientFormatting.clamp);
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06002DAD RID: 11693 RVA: 0x0008719C File Offset: 0x0008539C
		public bool IsAppliesToBackground
		{
			get
			{
				return this.GetOptionFlag(global::NPOI.HSSF.Record.CF.ColorGradientFormatting.background);
			}
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x000871A9 File Offset: 0x000853A9
		private bool GetOptionFlag(global::NPOI.Util.BitField field)
		{
			return field.GetValue((int)this.options) != 0;
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x000871BC File Offset: 0x000853BC
		private void updateThresholdPositions()
		{
			double num = 1.0 / (double)(this.thresholds.Length - 1);
			for (int i = 0; i < this.thresholds.Length; i++)
			{
				this.thresholds[i].Position = num * (double)i;
			}
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x00087204 File Offset: 0x00085404
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("    [Color Gradient Formatting]\n");
			stringBuilder.Append("          .clamp     = ").Append(this.IsClampToCurve).Append("\n");
			stringBuilder.Append("          .background= ").Append(this.IsAppliesToBackground).Append("\n");
			foreach (global::NPOI.HSSF.Record.CF.ColorGradientThreshold threshold in this.thresholds)
			{
				stringBuilder.Append(threshold.ToString());
			}
			foreach (global::NPOI.HSSF.Record.Common.ExtendedColor extendedColor in this.colors)
			{
				stringBuilder.Append(extendedColor.ToString());
			}
			stringBuilder.Append("    [/Color Gradient Formatting]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x000872C8 File Offset: 0x000854C8
		public object Clone()
		{
			global::NPOI.HSSF.Record.CF.ColorGradientFormatting colorGradientFormatting = new global::NPOI.HSSF.Record.CF.ColorGradientFormatting();
			colorGradientFormatting.options = this.options;
			colorGradientFormatting.thresholds = new global::NPOI.HSSF.Record.CF.ColorGradientThreshold[this.thresholds.Length];
			colorGradientFormatting.colors = new global::NPOI.HSSF.Record.Common.ExtendedColor[this.colors.Length];
			global::System.Array.Copy(this.thresholds, 0, colorGradientFormatting.thresholds, 0, this.thresholds.Length);
			global::System.Array.Copy(this.colors, 0, colorGradientFormatting.colors, 0, this.colors.Length);
			return colorGradientFormatting;
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06002DB2 RID: 11698 RVA: 0x00087344 File Offset: 0x00085544
		public int DataLength
		{
			get
			{
				int num = 6;
				foreach (global::NPOI.HSSF.Record.CF.ColorGradientThreshold threshold in this.thresholds)
				{
					num += threshold.DataLength;
				}
				foreach (global::NPOI.HSSF.Record.Common.ExtendedColor extendedColor in this.colors)
				{
					num += extendedColor.DataLength;
					num += 8;
				}
				return num;
			}
		}

		// Token: 0x06002DB3 RID: 11699 RVA: 0x000873A4 File Offset: 0x000855A4
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(0);
			out1.WriteByte(0);
			out1.WriteByte(this.thresholds.Length);
			out1.WriteByte(this.thresholds.Length);
			out1.WriteByte((int)this.options);
			global::NPOI.HSSF.Record.CF.ColorGradientThreshold[] array = this.thresholds;
			for (int i = 0; i < array.Length; i++)
			{
				array[i].Serialize(out1);
			}
			double num = 1.0 / (double)(this.colors.Length - 1);
			for (int j = 0; j < this.colors.Length; j++)
			{
				out1.WriteDouble((double)j * num);
				this.colors[j].Serialize(out1);
			}
		}

		// Token: 0x0400140E RID: 5134
		private byte options;

		// Token: 0x0400140F RID: 5135
		private global::NPOI.HSSF.Record.CF.ColorGradientThreshold[] thresholds;

		// Token: 0x04001410 RID: 5136
		private global::NPOI.HSSF.Record.Common.ExtendedColor[] colors;

		// Token: 0x04001411 RID: 5137
		private static global::NPOI.Util.BitField clamp = global::NPOI.Util.BitFieldFactory.GetInstance(1);

		// Token: 0x04001412 RID: 5138
		private static global::NPOI.Util.BitField background = global::NPOI.Util.BitFieldFactory.GetInstance(2);
	}
}
