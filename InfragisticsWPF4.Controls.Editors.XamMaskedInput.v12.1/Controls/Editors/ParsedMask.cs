using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200002F RID: 47
	public class ParsedMask
	{
		// Token: 0x0600014C RID: 332 RVA: 0x0000B143 File Offset: 0x00009343
		public ParsedMask(string mask) : this(mask, null)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000B14D File Offset: 0x0000934D
		public ParsedMask(string mask, global::System.IFormatProvider formatProvider) : this(mask, formatProvider, '_', ' ')
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000B15B File Offset: 0x0000935B
		public ParsedMask(string mask, global::System.IFormatProvider formatProvider, char promptCharacter, char padCharacter)
		{
			if (string.IsNullOrEmpty(mask))
			{
				throw new global::System.ArgumentException();
			}
			this._mask = mask;
			this._promptChar = promptCharacter;
			this._padChar = padCharacter;
			global::Infragistics.Controls.Editors.MaskParser.Parse(this._mask, out this._sections, formatProvider);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000B199 File Offset: 0x00009399
		public string ApplyMask(string data, global::Infragistics.Controls.Editors.InputMaskMode maskMode)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput.SetText(this._sections, data, this._promptChar, this._padChar);
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetText(this._sections, maskMode, this._promptChar, this._padChar);
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000B1CC File Offset: 0x000093CC
		public string Mask
		{
			get
			{
				return this._mask;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000B1D4 File Offset: 0x000093D4
		public char PromptCharacter
		{
			get
			{
				return this._promptChar;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0000B1DC File Offset: 0x000093DC
		public char PadCharacter
		{
			get
			{
				return this._padChar;
			}
		}

		// Token: 0x040000AF RID: 175
		private string _mask;

		// Token: 0x040000B0 RID: 176
		private global::Infragistics.Controls.Editors.SectionsCollection _sections;

		// Token: 0x040000B1 RID: 177
		private char _promptChar;

		// Token: 0x040000B2 RID: 178
		private char _padChar;
	}
}
