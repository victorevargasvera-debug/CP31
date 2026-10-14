using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001FC RID: 508
	internal class SummaryStringFormatsParser
	{
		// Token: 0x06001F5B RID: 8027 RVA: 0x00088B14 File Offset: 0x00086D14
		internal static global::System.Collections.Generic.Dictionary<string, string> Parse(string calcStringFormats, out string errorText)
		{
			global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser summaryStringFormatsParser = new global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser();
			summaryStringFormatsParser.ParseHelper(calcStringFormats);
			errorText = summaryStringFormatsParser._parseErrorText;
			return summaryStringFormatsParser._calcFormats;
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00088B40 File Offset: 0x00086D40
		internal static bool IsValid(string calcStringFormats, out string errorText)
		{
			global::System.Collections.Generic.Dictionary<string, string> dictionary = global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.Parse(calcStringFormats, out errorText);
			return dictionary != null && dictionary.Count > 0 && string.IsNullOrEmpty(errorText);
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00088B6A File Offset: 0x00086D6A
		private bool ParseHelper(string calcStringFormats)
		{
			this._calcFormats = new global::System.Collections.Generic.Dictionary<string, string>(global::System.StringComparer.CurrentCultureIgnoreCase);
			return this.ParseImpl(calcStringFormats);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x00088B84 File Offset: 0x00086D84
		private bool ParseImpl(string calcStringFormats)
		{
			global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState parseState = global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.ParsingCalcName;
			string text = null;
			int i = 0;
			int num = 0;
			while (i < calcStringFormats.Length)
			{
				char c = calcStringFormats[i];
				char c2 = c;
				if (c2 <= ':')
				{
					if (c2 != ',')
					{
						if (c2 == ':')
						{
							if (parseState == global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.ParsingCalcName)
							{
								int num2 = i - num;
								if (num2 <= 0)
								{
									this.SetInvalidCharacterError(c, i, calcStringFormats);
									return false;
								}
								text = calcStringFormats.Substring(num, num2).Trim();
								if (string.IsNullOrEmpty(text))
								{
									this.SetInvalidCharacterError(c, i, calcStringFormats);
									return false;
								}
								parseState = global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.ParsingFormat;
								num = i + 1;
							}
						}
					}
					else if (parseState == global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.ParsingFormat)
					{
						int num3 = i - num;
						if (num3 <= 0)
						{
							this.SetFormatMissingError(i, calcStringFormats);
							return false;
						}
						string text2 = calcStringFormats.Substring(num, num3).Trim();
						if (string.IsNullOrEmpty(text2))
						{
							this.SetFormatMissingError(i, calcStringFormats);
							return false;
						}
						this.AddCalcFormat(text, text2);
						text = null;
						parseState = global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.ParsingCalcName;
						num = i + 1;
					}
				}
				else if (c2 != '\\')
				{
					switch (c2)
					{
					case '{':
						if (i + 1 < calcStringFormats.Length && calcStringFormats[i + 1] == '{')
						{
							i++;
						}
						else
						{
							if (parseState == global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.InsideFormatBracket)
							{
								this.SetInvalidCharacterError(c, i, calcStringFormats);
								return false;
							}
							if (parseState == global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.ParsingFormat)
							{
								parseState = global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.InsideFormatBracket;
							}
						}
						break;
					case '}':
						if (i + 1 < calcStringFormats.Length && calcStringFormats[i + 1] == '}')
						{
							i++;
						}
						else
						{
							if (parseState == global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.ParsingFormat)
							{
								this.SetInvalidCharacterError(c, i, calcStringFormats);
								return false;
							}
							if (parseState == global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.InsideFormatBracket)
							{
								parseState = global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.ParsingFormat;
							}
						}
						break;
					}
				}
				else
				{
					i++;
				}
				i++;
			}
			switch (parseState)
			{
			case global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.ParsingCalcName:
				this.SetFormatMissingError(i, calcStringFormats);
				break;
			case global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.ParsingFormat:
			{
				int num4 = i - num;
				if (num4 <= 0)
				{
					this.SetFormatMissingError(i, calcStringFormats);
				}
				else
				{
					string text3 = calcStringFormats.Substring(num, num4).Trim();
					if (!string.IsNullOrEmpty(text3))
					{
						this.AddCalcFormat(text, text3);
						return true;
					}
					this.SetFormatMissingError(i, calcStringFormats);
				}
				break;
			}
			case global::Infragistics.Windows.DataPresenter.SummaryStringFormatsParser.ParseState.InsideFormatBracket:
				this._parseErrorText = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("InvalidSummaryStringFormats_1", new object[]
				{
					calcStringFormats
				});
				break;
			}
			return false;
		}

		// Token: 0x06001F5F RID: 8031 RVA: 0x00088D90 File Offset: 0x00086F90
		private void SetFormatMissingError(int index, string calcStringFormats)
		{
			this._parseErrorText = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("InvalidSummaryStringFormats_3", new object[]
			{
				index,
				calcStringFormats
			});
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x00088DC4 File Offset: 0x00086FC4
		private void SetInvalidCharacterError(char chr, int index, string calcStringFormats)
		{
			this._parseErrorText = global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("InvalidSummaryStringFormats_2", new object[]
			{
				chr,
				index,
				calcStringFormats
			});
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x00088DFF File Offset: 0x00086FFF
		private void AddCalcFormat(string calcName, string format)
		{
			this._calcFormats[calcName.Trim()] = format.Trim();
		}

		// Token: 0x04000D2C RID: 3372
		private global::System.Collections.Generic.Dictionary<string, string> _calcFormats;

		// Token: 0x04000D2D RID: 3373
		private string _parseErrorText;

		// Token: 0x020001FD RID: 509
		private enum ParseState
		{
			// Token: 0x04000D2F RID: 3375
			ParsingCalcName,
			// Token: 0x04000D30 RID: 3376
			ParsingFormat,
			// Token: 0x04000D31 RID: 3377
			InsideFormatBracket
		}
	}
}
