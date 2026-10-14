using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200007C RID: 124
	public sealed class AlphanumericChar : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x06000777 RID: 1911 RVA: 0x0001FFB4 File Offset: 0x0001E1B4
		internal AlphanumericChar()
		{
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0001FFBC File Offset: 0x0001E1BC
		internal AlphanumericChar(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		public override bool MatchChar(char c)
		{
			char c2 = base.Filter(c);
			return char.IsLetterOrDigit(c2);
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0001FFE4 File Offset: 0x0001E1E4
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.AlphanumericChar alphanumericChar = new global::Infragistics.Windows.Editors.AlphanumericChar(section);
			this.InternalCopy(alphanumericChar);
			return alphanumericChar;
		}
	}
}
