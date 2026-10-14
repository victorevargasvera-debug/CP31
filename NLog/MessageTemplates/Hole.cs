using System;

namespace NLog.MessageTemplates
{
	// Token: 0x0200007B RID: 123
	internal struct Hole
	{
		// Token: 0x06000897 RID: 2199 RVA: 0x00016393 File Offset: 0x00014593
		public Hole(string name, string format, global::NLog.MessageTemplates.CaptureType captureType, short position, short alignment)
		{
			this.Name = name;
			this.Format = format;
			this.CaptureType = captureType;
			this.Index = position;
			this.Alignment = alignment;
		}

		// Token: 0x04000203 RID: 515
		public readonly string Name;

		// Token: 0x04000204 RID: 516
		public readonly string Format;

		// Token: 0x04000205 RID: 517
		public readonly global::NLog.MessageTemplates.CaptureType CaptureType;

		// Token: 0x04000206 RID: 518
		public readonly short Index;

		// Token: 0x04000207 RID: 519
		public readonly short Alignment;
	}
}
