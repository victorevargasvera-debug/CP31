using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200007E RID: 126
	internal class LiteralChar : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x060007BD RID: 1981 RVA: 0x00021607 File Offset: 0x0001F807
		internal LiteralChar(char literal)
		{
			this.literal = literal;
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00021616 File Offset: 0x0001F816
		internal LiteralChar(char literal, global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
			this.literal = literal;
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x00021626 File Offset: 0x0001F826
		public override bool MatchChar(char c)
		{
			return this.Filter(c) == this.Filter(this.literal);
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0002163D File Offset: 0x0001F83D
		public override bool IsEditable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00021640 File Offset: 0x0001F840
		// (set) Token: 0x060007C2 RID: 1986 RVA: 0x00021648 File Offset: 0x0001F848
		public override char Char
		{
			get
			{
				return this.literal;
			}
			set
			{
				throw new global::System.InvalidOperationException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_InvalidOperationException_3"));
			}
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0002165C File Offset: 0x0001F85C
		internal override void InternalCopy(global::Infragistics.Windows.Editors.DisplayCharBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Windows.Editors.LiteralChar literalChar = (global::Infragistics.Windows.Editors.LiteralChar)dest;
			literalChar.literal = this.literal;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00021684 File Offset: 0x0001F884
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.LiteralChar literalChar = new global::Infragistics.Windows.Editors.LiteralChar(this.literal, section);
			this.InternalCopy(literalChar);
			return literalChar;
		}

		// Token: 0x040002CA RID: 714
		protected char literal;
	}
}
