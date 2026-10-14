using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200000F RID: 15
	internal class LiteralChar : global::Infragistics.Controls.Editors.InputCharBase
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00003EC3 File Offset: 0x000020C3
		internal LiteralChar(char literal)
		{
			this.literal = literal;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00003ED2 File Offset: 0x000020D2
		internal LiteralChar(char literal, global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
			this.literal = literal;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003EE2 File Offset: 0x000020E2
		public override bool MatchChar(char c)
		{
			return base.Filter(c) == base.Filter(this.literal);
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000056 RID: 86 RVA: 0x00003EF9 File Offset: 0x000020F9
		public override bool IsEditable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00003EFC File Offset: 0x000020FC
		// (set) Token: 0x06000058 RID: 88 RVA: 0x00003F04 File Offset: 0x00002104
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

		// Token: 0x06000059 RID: 89 RVA: 0x00003F18 File Offset: 0x00002118
		internal override void InternalCopy(global::Infragistics.Controls.Editors.DisplayCharBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Controls.Editors.LiteralChar literalChar = (global::Infragistics.Controls.Editors.LiteralChar)dest;
			literalChar.literal = this.literal;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003F40 File Offset: 0x00002140
		internal override global::Infragistics.Controls.Editors.DisplayCharBase InternalClone(global::Infragistics.Controls.Editors.SectionBase section)
		{
			global::Infragistics.Controls.Editors.LiteralChar literalChar = new global::Infragistics.Controls.Editors.LiteralChar(this.literal, section);
			this.InternalCopy(literalChar);
			return literalChar;
		}

		// Token: 0x0400004B RID: 75
		protected char literal;
	}
}
