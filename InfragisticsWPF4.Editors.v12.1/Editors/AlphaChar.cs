using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200007B RID: 123
	public sealed class AlphaChar : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x06000773 RID: 1907 RVA: 0x0001FF68 File Offset: 0x0001E168
		internal AlphaChar()
		{
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0001FF70 File Offset: 0x0001E170
		internal AlphaChar(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0001FF7C File Offset: 0x0001E17C
		public override bool MatchChar(char c)
		{
			char c2 = base.Filter(c);
			return char.IsLetter(c2);
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0001FF98 File Offset: 0x0001E198
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.AlphaChar alphaChar = new global::Infragistics.Windows.Editors.AlphaChar(section);
			this.InternalCopy(alphaChar);
			return alphaChar;
		}
	}
}
