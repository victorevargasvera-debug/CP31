using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000013 RID: 19
	public sealed class AlphanumericChar : global::Infragistics.Controls.Editors.InputCharBase
	{
		// Token: 0x0600006E RID: 110 RVA: 0x00004298 File Offset: 0x00002498
		internal AlphanumericChar()
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000042A0 File Offset: 0x000024A0
		internal AlphanumericChar(global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000042AC File Offset: 0x000024AC
		public override bool MatchChar(char c)
		{
			char c2 = base.Filter(c);
			return char.IsLetterOrDigit(c2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000042C8 File Offset: 0x000024C8
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.AlphanumericChar alphanumericChar = new global::Infragistics.Controls.Editors.AlphanumericChar(section);
			this.InternalCopy(alphanumericChar);
			return alphanumericChar;
		}
	}
}
