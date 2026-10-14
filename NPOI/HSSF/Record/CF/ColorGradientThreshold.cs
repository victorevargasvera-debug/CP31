using System;
using NPOI.Util;

namespace NPOI.HSSF.Record.CF
{
	// Token: 0x020004C1 RID: 1217
	public class ColorGradientThreshold : global::NPOI.HSSF.Record.CF.Threshold, global::System.ICloneable
	{
		// Token: 0x06002DB5 RID: 11701 RVA: 0x0008745E File Offset: 0x0008565E
		public ColorGradientThreshold()
		{
			this.position = 0.0;
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x00087475 File Offset: 0x00085675
		public ColorGradientThreshold(global::NPOI.Util.ILittleEndianInput in1) : base(in1)
		{
			this.position = in1.ReadDouble();
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x0008748A File Offset: 0x0008568A
		// (set) Token: 0x06002DB8 RID: 11704 RVA: 0x00087492 File Offset: 0x00085692
		public double Position
		{
			get
			{
				return this.position;
			}
			set
			{
				this.position = value;
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x06002DB9 RID: 11705 RVA: 0x0008749B File Offset: 0x0008569B
		public override int DataLength
		{
			get
			{
				return base.DataLength + 8;
			}
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x000874A8 File Offset: 0x000856A8
		public object Clone()
		{
			global::NPOI.HSSF.Record.CF.ColorGradientThreshold colorGradientThreshold = new global::NPOI.HSSF.Record.CF.ColorGradientThreshold();
			base.CopyTo(colorGradientThreshold);
			colorGradientThreshold.position = this.position;
			return colorGradientThreshold;
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x000874CF File Offset: 0x000856CF
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			base.Serialize(out1);
			out1.WriteDouble(this.position);
		}

		// Token: 0x04001413 RID: 5139
		private double position;
	}
}
