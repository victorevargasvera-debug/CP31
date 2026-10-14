using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000012 RID: 18
	public sealed class AlphaChar : global::Infragistics.Controls.Editors.InputCharBase
	{
		// Token: 0x0600006A RID: 106 RVA: 0x0000424C File Offset: 0x0000244C
		internal AlphaChar()
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004254 File Offset: 0x00002454
		internal AlphaChar(global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004260 File Offset: 0x00002460
		public override bool MatchChar(char c)
		{
			char c2 = base.Filter(c);
			return char.IsLetter(c2);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000427C File Offset: 0x0000247C
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.AlphaChar alphaChar = new global::Infragistics.Controls.Editors.AlphaChar(section);
			this.InternalCopy(alphaChar);
			return alphaChar;
		}
	}
}
