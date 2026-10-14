using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200000E RID: 14
	internal class LiteralChar : global::Infragistics.Controls.Editors.InputCharBase
	{
		// Token: 0x06000050 RID: 80 RVA: 0x0000385F File Offset: 0x00001A5F
		internal LiteralChar(char literal)
		{
			this.literal = literal;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000386E File Offset: 0x00001A6E
		internal LiteralChar(char literal, global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
			this.literal = literal;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000387E File Offset: 0x00001A7E
		public override bool MatchChar(char c)
		{
			return this.Filter(c) == this.Filter(this.literal);
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00003895 File Offset: 0x00001A95
		public override bool IsEditable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000054 RID: 84 RVA: 0x00003898 File Offset: 0x00001A98
		// (set) Token: 0x06000055 RID: 85 RVA: 0x000038A0 File Offset: 0x00001AA0
		public override char Char
		{
			get
			{
				return this.literal;
			}
			set
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_InvalidOperationException_3"));
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000038B4 File Offset: 0x00001AB4
		internal override void InternalCopy(global::Infragistics.Controls.Editors.DisplayCharBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Controls.Editors.LiteralChar literalChar = (global::Infragistics.Controls.Editors.LiteralChar)dest;
			literalChar.literal = this.literal;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000038DC File Offset: 0x00001ADC
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.LiteralChar literalChar = new global::Infragistics.Controls.Editors.LiteralChar(this.literal, section);
			this.InternalCopy(literalChar);
			return literalChar;
		}

		// Token: 0x0400004D RID: 77
		protected char literal;
	}
}
