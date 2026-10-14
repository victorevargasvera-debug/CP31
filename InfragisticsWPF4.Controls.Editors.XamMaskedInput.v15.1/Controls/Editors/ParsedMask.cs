using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200002E RID: 46
	public class ParsedMask
	{
		// Token: 0x0600014B RID: 331 RVA: 0x0000AD43 File Offset: 0x00008F43
		public ParsedMask(string mask) : this(mask, null)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000AD4D File Offset: 0x00008F4D
		public ParsedMask(string mask, global::System.IFormatProvider formatProvider) : this(mask, formatProvider, '_', ' ')
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000AD5C File Offset: 0x00008F5C
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
			if (this._sections != null)
			{
				global::Infragistics.Controls.Editors.MaskInfo maskInfo = new global::Infragistics.Controls.Editors.MaskInfo();
				maskInfo.Initialize(this._sections, formatProvider);
				this._sections.Initialize(maskInfo);
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000ADCC File Offset: 0x00008FCC
		public string ApplyMask(string data, global::Infragistics.Controls.Editors.InputMaskMode maskMode)
		{
			global::Infragistics.Controls.Editors.XamMaskedInput.SetText(this._sections, data, this._promptChar, this._padChar);
			return global::Infragistics.Controls.Editors.XamMaskedInput.GetText(this._sections, maskMode, this._promptChar, this._padChar);
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600014F RID: 335 RVA: 0x0000ADFF File Offset: 0x00008FFF
		public string Mask
		{
			get
			{
				return this._mask;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000AE07 File Offset: 0x00009007
		public char PromptCharacter
		{
			get
			{
				return this._promptChar;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000AE0F File Offset: 0x0000900F
		public char PadCharacter
		{
			get
			{
				return this._padChar;
			}
		}

		// Token: 0x040000B1 RID: 177
		private string _mask;

		// Token: 0x040000B2 RID: 178
		private global::Infragistics.Controls.Editors.SectionsCollection _sections;

		// Token: 0x040000B3 RID: 179
		private char _promptChar;

		// Token: 0x040000B4 RID: 180
		private char _padChar;
	}
}
