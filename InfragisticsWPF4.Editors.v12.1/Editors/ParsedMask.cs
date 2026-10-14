using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200009B RID: 155
	public class ParsedMask
	{
		// Token: 0x06000871 RID: 2161 RVA: 0x00027713 File Offset: 0x00025913
		public ParsedMask(string mask) : this(mask, null)
		{
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x0002771D File Offset: 0x0002591D
		public ParsedMask(string mask, global::System.IFormatProvider formatProvider) : this(mask, formatProvider, '_', ' ')
		{
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x0002772B File Offset: 0x0002592B
		public ParsedMask(string mask, global::System.IFormatProvider formatProvider, char promptCharacter, char padCharacter)
		{
			if (string.IsNullOrEmpty(mask))
			{
				throw new global::System.ArgumentException();
			}
			this._mask = mask;
			this._promptChar = promptCharacter;
			this._padChar = padCharacter;
			global::Infragistics.Windows.Editors.MaskParser.Parse(this._mask, out this._sections, formatProvider);
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00027769 File Offset: 0x00025969
		public string ApplyMask(string data, global::Infragistics.Windows.Editors.MaskMode maskMode)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(this._sections, data, this._promptChar, this._padChar);
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(this._sections, maskMode, this._promptChar, this._padChar);
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0002779C File Offset: 0x0002599C
		public string Mask
		{
			get
			{
				return this._mask;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x000277A4 File Offset: 0x000259A4
		public char PromptCharacter
		{
			get
			{
				return this._promptChar;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000277AC File Offset: 0x000259AC
		public char PadCharacter
		{
			get
			{
				return this._padChar;
			}
		}

		// Token: 0x04000305 RID: 773
		private string _mask;

		// Token: 0x04000306 RID: 774
		private global::Infragistics.Windows.Editors.SectionsCollection _sections;

		// Token: 0x04000307 RID: 775
		private char _promptChar;

		// Token: 0x04000308 RID: 776
		private char _padChar;
	}
}
