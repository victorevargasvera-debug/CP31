using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000019 RID: 25
	internal sealed class KeyboardAndForeignChar : global::Infragistics.Controls.Editors.InputCharBase
	{
		// Token: 0x06000081 RID: 129 RVA: 0x00003F44 File Offset: 0x00002144
		internal KeyboardAndForeignChar()
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00003F4C File Offset: 0x0000214C
		internal KeyboardAndForeignChar(global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003F58 File Offset: 0x00002158
		public override bool MatchChar(char c)
		{
			char c2 = this.Filter(c);
			int num = (int)c2;
			return num > 31 && num != 127;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003F80 File Offset: 0x00002180
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.KeyboardAndForeignChar keyboardAndForeignChar = new global::Infragistics.Controls.Editors.KeyboardAndForeignChar(section);
			this.InternalCopy(keyboardAndForeignChar);
			return keyboardAndForeignChar;
		}
	}
}
