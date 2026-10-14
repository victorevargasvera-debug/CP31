using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000011 RID: 17
	public sealed class AlphaChar : global::Infragistics.Controls.Editors.InputCharBase
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00003BE8 File Offset: 0x00001DE8
		internal AlphaChar()
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003BF0 File Offset: 0x00001DF0
		internal AlphaChar(global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00003BFC File Offset: 0x00001DFC
		public override bool MatchChar(char c)
		{
			char c2 = this.Filter(c);
			return char.IsLetter(c2);
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00003C18 File Offset: 0x00001E18
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.AlphaChar alphaChar = new global::Infragistics.Controls.Editors.AlphaChar(section);
			this.InternalCopy(alphaChar);
			return alphaChar;
		}
	}
}
