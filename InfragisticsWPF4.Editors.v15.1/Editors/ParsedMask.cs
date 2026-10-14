using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A2 RID: 162
	public class ParsedMask
	{
		// Token: 0x060008DE RID: 2270 RVA: 0x000294CF File Offset: 0x000276CF
		public ParsedMask(string mask) : this(mask, null)
		{
		}

		// Token: 0x060008DF RID: 2271 RVA: 0x000294D9 File Offset: 0x000276D9
		public ParsedMask(string mask, global::System.IFormatProvider formatProvider) : this(mask, formatProvider, '_', ' ')
		{
		}

		// Token: 0x060008E0 RID: 2272 RVA: 0x000294E8 File Offset: 0x000276E8
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
			if (this._sections != null)
			{
				global::Infragistics.Windows.Editors.MaskInfo maskInfo = new global::Infragistics.Windows.Editors.MaskInfo();
				maskInfo.Initialize(this._sections, formatProvider);
				this._sections.Initialize(maskInfo);
			}
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00029558 File Offset: 0x00027758
		public string ApplyMask(string data, global::Infragistics.Windows.Editors.MaskMode maskMode)
		{
			global::Infragistics.Windows.Editors.XamMaskedEditor.SetText(this._sections, data, this._promptChar, this._padChar);
			return global::Infragistics.Windows.Editors.XamMaskedEditor.GetText(this._sections, maskMode, this._promptChar, this._padChar);
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0002958B File Offset: 0x0002778B
		public string Mask
		{
			get
			{
				return this._mask;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x00029593 File Offset: 0x00027793
		public char PromptCharacter
		{
			get
			{
				return this._promptChar;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0002959B File Offset: 0x0002779B
		public char PadCharacter
		{
			get
			{
				return this._padChar;
			}
		}

		// Token: 0x0400033B RID: 827
		private string _mask;

		// Token: 0x0400033C RID: 828
		private global::Infragistics.Windows.Editors.SectionsCollection _sections;

		// Token: 0x0400033D RID: 829
		private char _promptChar;

		// Token: 0x0400033E RID: 830
		private char _padChar;
	}
}
