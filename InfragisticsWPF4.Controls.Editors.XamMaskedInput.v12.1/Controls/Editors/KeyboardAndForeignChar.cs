using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200001A RID: 26
	internal sealed class KeyboardAndForeignChar : global::Infragistics.Controls.Editors.InputCharBase
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00004568 File Offset: 0x00002768
		internal KeyboardAndForeignChar()
		{
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00004570 File Offset: 0x00002770
		internal KeyboardAndForeignChar(global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000457C File Offset: 0x0000277C
		public override bool MatchChar(char c)
		{
			char c2 = base.Filter(c);
			int num = (int)c2;
			return num > 31 && num != 127;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000045A4 File Offset: 0x000027A4
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.KeyboardAndForeignChar keyboardAndForeignChar = new global::Infragistics.Controls.Editors.KeyboardAndForeignChar(section);
			this.InternalCopy(keyboardAndForeignChar);
			return keyboardAndForeignChar;
		}
	}
}
