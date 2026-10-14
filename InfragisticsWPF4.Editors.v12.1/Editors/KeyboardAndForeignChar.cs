using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000083 RID: 131
	internal sealed class KeyboardAndForeignChar : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x0600078C RID: 1932 RVA: 0x00020298 File Offset: 0x0001E498
		internal KeyboardAndForeignChar()
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x000202A0 File Offset: 0x0001E4A0
		internal KeyboardAndForeignChar(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x000202AC File Offset: 0x0001E4AC
		public override bool MatchChar(char c)
		{
			char c2 = base.Filter(c);
			int num = (int)c2;
			return num > 31 && num != 127;
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x000202D4 File Offset: 0x0001E4D4
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.KeyboardAndForeignChar keyboardAndForeignChar = new global::Infragistics.Windows.Editors.KeyboardAndForeignChar(section);
			this.InternalCopy(keyboardAndForeignChar);
			return keyboardAndForeignChar;
		}
	}
}
