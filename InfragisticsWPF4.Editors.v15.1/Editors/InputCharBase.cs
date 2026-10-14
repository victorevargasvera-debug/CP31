using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200007D RID: 125
	public abstract class InputCharBase : global::Infragistics.Windows.Editors.DisplayCharBase
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x00021527 File Offset: 0x0001F727
		internal InputCharBase()
		{
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0002152F File Offset: 0x0001F72F
		internal InputCharBase(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00021538 File Offset: 0x0001F738
		public override bool IsEditable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0002153B File Offset: 0x0001F73B
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x00021543 File Offset: 0x0001F743
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
					throw new global::System.ArgumentException(global::Infragistics.Windows.Editors.ValueEditor.GetString("LE_ArgumentException_3"));
				}
				if (value != this.inputChar)
				{
					this.inputChar = this.Filter(value);
					base.NotifyPropertyChangedEvent(global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_CHAR);
				}
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x00021584 File Offset: 0x0001F784
		internal override char GetDrawChar()
		{
			char result = base.GetDrawChar();
			if (this.Char == '\0')
			{
				global::Infragistics.Windows.Editors.NumberSection numberSection = base.Section as global::Infragistics.Windows.Editors.NumberSection;
				if (numberSection != null && global::Infragistics.Windows.Editors.SignDisplayType.ShowAlways == numberSection.SignType && !numberSection.IsNegative)
				{
					global::Infragistics.Windows.Editors.DisplayCharBase firstFilledChar = numberSection.FirstFilledChar;
					global::Infragistics.Windows.Editors.DisplayCharBase displayCharBase = (firstFilledChar != null) ? firstFilledChar.PrevDisplayChar : null;
					if (this == displayCharBase)
					{
						result = numberSection.PlusSignChar;
					}
				}
			}
			return result;
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000215E0 File Offset: 0x0001F7E0
		internal override void InternalCopy(global::Infragistics.Windows.Editors.DisplayCharBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Windows.Editors.InputCharBase inputCharBase = (global::Infragistics.Windows.Editors.InputCharBase)dest;
			inputCharBase.inputChar = this.inputChar;
		}

		// Token: 0x040002C9 RID: 713
		private char inputChar;
	}
}
