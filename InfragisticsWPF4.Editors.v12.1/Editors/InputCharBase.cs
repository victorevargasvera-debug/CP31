using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x02000077 RID: 119
	public abstract class InputCharBase : global::Infragistics.Windows.Editors.DisplayCharBase
	{
		// Token: 0x06000755 RID: 1877 RVA: 0x0001FAFF File Offset: 0x0001DCFF
		internal InputCharBase()
		{
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0001FB07 File Offset: 0x0001DD07
		internal InputCharBase(global::Infragistics.Windows.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x0001FB10 File Offset: 0x0001DD10
		public override bool IsEditable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000758 RID: 1880 RVA: 0x0001FB13 File Offset: 0x0001DD13
		// (set) Token: 0x06000759 RID: 1881 RVA: 0x0001FB1B File Offset: 0x0001DD1B
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
					this.inputChar = base.Filter(value);
					base.NotifyPropertyChangedEvent(global::Infragistics.Windows.Editors.DisplayCharBase.PROPERTY_CHAR);
				}
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0001FB5C File Offset: 0x0001DD5C
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

		// Token: 0x0600075B RID: 1883 RVA: 0x0001FBB8 File Offset: 0x0001DDB8
		internal override void InternalCopy(global::Infragistics.Windows.Editors.DisplayCharBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Windows.Editors.InputCharBase inputCharBase = (global::Infragistics.Windows.Editors.InputCharBase)dest;
			inputCharBase.inputChar = this.inputChar;
		}

		// Token: 0x04000296 RID: 662
		private char inputChar;
	}
}
