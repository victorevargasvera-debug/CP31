using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200000E RID: 14
	public abstract class InputCharBase : global::Infragistics.Controls.Editors.DisplayCharBase
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00003DE3 File Offset: 0x00001FE3
		internal InputCharBase()
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00003DEB File Offset: 0x00001FEB
		internal InputCharBase(global::Infragistics.Controls.Editors.SectionBase section) : base(section)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00003DF4 File Offset: 0x00001FF4
		public override bool IsEditable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00003DF7 File Offset: 0x00001FF7
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00003DFF File Offset: 0x00001FFF
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
					this.inputChar = base.Filter(value);
					base.NotifyPropertyChangedEvent(global::Infragistics.Controls.Editors.DisplayCharBase.PROPERTY_CHAR);
				}
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00003E40 File Offset: 0x00002040
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

		// Token: 0x06000052 RID: 82 RVA: 0x00003E9C File Offset: 0x0000209C
		internal override void InternalCopy(global::Infragistics.Controls.Editors.DisplayCharBase dest)
		{
			base.InternalCopy(dest);
			global::Infragistics.Controls.Editors.InputCharBase inputCharBase = (global::Infragistics.Controls.Editors.InputCharBase)dest;
			inputCharBase.inputChar = this.inputChar;
		}

		// Token: 0x0400004A RID: 74
		private char inputChar;
	}
}
