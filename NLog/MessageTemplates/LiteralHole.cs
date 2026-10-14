using System;

namespace NLog.MessageTemplates
{
	// Token: 0x0200007D RID: 125
	internal struct LiteralHole
	{
		// Token: 0x06000898 RID: 2200 RVA: 0x000163BA File Offset: 0x000145BA
		public LiteralHole(global::NLog.MessageTemplates.Literal literal, global::NLog.MessageTemplates.Hole hole)
		{
			this.Literal = literal;
			this.Hole = hole;
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000899 RID: 2201 RVA: 0x000163CA File Offset: 0x000145CA
		public bool MaybePositionalTemplate
		{
			get
			{
				return this.Literal.Skip != 0 && this.Hole.Index != -1 && this.Hole.CaptureType == global::NLog.MessageTemplates.CaptureType.Normal;
			}
		}

		// Token: 0x0400020A RID: 522
		public readonly global::NLog.MessageTemplates.Literal Literal;

		// Token: 0x0400020B RID: 523
		public readonly global::NLog.MessageTemplates.Hole Hole;
	}
}
