using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200000D RID: 13
	public abstract class InputCharBase : global::Infragistics.Controls.Editors.DisplayCharBase
	{
		// Token: 0x06000049 RID: 73 RVA: 0x0000377F File Offset: 0x0000197F
		internal InputCharBase()
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00003787 File Offset: 0x00001987
		internal InputCharBase(global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00003790 File Offset: 0x00001990
		public override bool IsEditable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00003793 File Offset: 0x00001993
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0000379B File Offset: 0x0000199B
		public override char Char
		{
			get
			{
				return this.inputChar;
			}
			set
			{
				if (value != '\0' && !this.MatchChar(value))
				{
					throw new global::System.ArgumentException(global::Infragistics.Controls.Editors.ValueInput.GetString("LE_ArgumentException_3"));
				}
				if (value != this.inputChar)
				{
					this.inputChar = this.Filter(value);
					base.NotifyPropertyChangedEvent(global::Infragistics.Controls.Editors.DisplayCharBase.PROPERTY_CHAR);
				}
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000037DC File Offset: 0x000019DC
		internal override char GetDrawChar()
		{
			char result = base.GetDrawChar();
			if (this.Char == '\0')
			{
				global::Infragistics.Controls.Editors.NumberSection numberSection = base.Section as global::Infragistics.Controls.Editors.NumberSection;
				if (numberSection != null && global::Infragistics.Controls.Editors.SignDisplayType.ShowAlways == numberSection.SignType && !numberSection.IsNegative)
				{
					global::Infragistics.Controls.Editors.DisplayCharBase firstFilledChar = numberSection.FirstFilledChar;
					global::Infragistics.Controls.Editors.DisplayCharBase displayCharBase = (firstFilledChar != null) ? firstFilledChar.PrevDisplayChar : null;
					if (this == displayCharBase)
					{
						result = numberSection.PlusSignChar;
					}
				}
			}
			return result;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00003838 File Offset: 0x00001A38
		internal override void InternalCopy(global::Infragistics.Controls.Editors.DisplayCharBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Controls.Editors.InputCharBase inputCharBase = (global::Infragistics.Controls.Editors.InputCharBase)dest;
			inputCharBase.inputChar = this.inputChar;
		}

		// Token: 0x0400004C RID: 76
		private char inputChar;
	}
}
