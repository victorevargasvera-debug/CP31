using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000078 RID: 120
	internal class LiteralChar : global::Infragistics.Windows.Editors.InputCharBase
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x0001FBDF File Offset: 0x0001DDDF
		internal LiteralChar(char literal)
		{
			this.literal = literal;
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0001FBEE File Offset: 0x0001DDEE
		internal LiteralChar(char literal, global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
			this.literal = literal;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0001FBFE File Offset: 0x0001DDFE
		public override bool MatchChar(char c)
		{
			return base.Filter(c) == base.Filter(this.literal);
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x0001FC15 File Offset: 0x0001DE15
		public override bool IsEditable
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x0001FC18 File Offset: 0x0001DE18
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x0001FC20 File Offset: 0x0001DE20
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

		// Token: 0x06000762 RID: 1890 RVA: 0x0001FC34 File Offset: 0x0001DE34
		internal override void InternalCopy(global::Infragistics.Windows.Editors.DisplayCharBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Windows.Editors.LiteralChar literalChar = (global::Infragistics.Windows.Editors.LiteralChar)dest;
			literalChar.literal = this.literal;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0001FC5C File Offset: 0x0001DE5C
		internal override global::Infragistics.Windows.Editors.DisplayCharBase InternalClone(global::Infragistics.Windows.Editors.SectionBase section)
		{
			global::Infragistics.Windows.Editors.LiteralChar literalChar = new global::Infragistics.Windows.Editors.LiteralChar(this.literal, section);
			this.InternalCopy(literalChar);
			return literalChar;
		}

		// Token: 0x04000297 RID: 663
		protected char literal;
	}
}
