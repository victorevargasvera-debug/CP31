using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000012 RID: 18
	public sealed class AlphanumericChar : global::Infragistics.Controls.Editors.InputCharBase
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00003C34 File Offset: 0x00001E34
		internal AlphanumericChar()
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003C3C File Offset: 0x00001E3C
		internal AlphanumericChar(global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003C48 File Offset: 0x00001E48
		public override bool MatchChar(char c)
		{
			char c2 = this.Filter(c);
			return char.IsLetterOrDigit(c2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003C64 File Offset: 0x00001E64
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.AlphanumericChar alphanumericChar = new global::Infragistics.Controls.Editors.AlphanumericChar(section);
			this.InternalCopy(alphanumericChar);
			return alphanumericChar;
		}
	}
}
