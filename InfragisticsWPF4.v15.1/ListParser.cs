using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infragistics
{
	// Token: 0x02000070 RID: 112
	internal class ListParser
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x00011D4C File Offset: 0x0000FF4C
		public ListParser(char openQuoteChar, char closeQuoteChar, char escapeCharacter, char itemsSeparatorChar) : this(new char[]
		{
			openQuoteChar
		}, new char[]
		{
			closeQuoteChar
		}, escapeCharacter, itemsSeparatorChar)
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00011D7C File Offset: 0x0000FF7C
		public ListParser(char[] openQuoteChars, char[] closeQuoteChars, char escapeCharacter, char itemsSeparatorChar)
		{
			if (openQuoteChars.Length == 0)
			{
				throw new global::System.ArgumentException("Open quote chars not specified.");
			}
			if (openQuoteChars.Length != closeQuoteChars.Length)
			{
				throw new global::System.ArgumentException("Open and close quote chars must match.");
			}
			this._openQuoteChars = openQuoteChars;
			this._closeQuoteChars = closeQuoteChars;
			this._escapeCharacter = escapeCharacter;
			this._itemsSeparatorChar = itemsSeparatorChar;
			this._allSpecialChars = global::Infragistics.ListParser.Aggregate<char>(new global::System.Collections.Generic.IEnumerable<char>[]
			{
				openQuoteChars,
				closeQuoteChars,
				new char[]
				{
					escapeCharacter,
					itemsSeparatorChar
				}
			});
			this._specialCharsWithinQuotes = global::Infragistics.ListParser.Aggregate<char>(new global::System.Collections.Generic.IEnumerable<char>[]
			{
				openQuoteChars,
				closeQuoteChars,
				new char[]
				{
					escapeCharacter
				}
			});
			this._mask_allSpecialChars = global::Infragistics.ListParser.CalcMask(this._allSpecialChars);
			this._mask_specialCharsWithinQuotes = global::Infragistics.ListParser.CalcMask(this._specialCharsWithinQuotes);
			this._mask_openQuoteChars = global::Infragistics.ListParser.CalcMask(this._openQuoteChars);
			this._mask_closeQuoteChars = global::Infragistics.ListParser.CalcMask(this._closeQuoteChars);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00011E6C File Offset: 0x0001006C
		private void AddItemHelper(global::System.Collections.Generic.IList<string> itemList, global::System.Text.StringBuilder sb, ref int lastEscapedIndexInSB, bool trimTrailingSpaces, bool skipEmptyItems)
		{
			if (trimTrailingSpaces)
			{
				global::Infragistics.ListParser.TrimTrailingSpaces(sb, lastEscapedIndexInSB);
			}
			if (sb.Length > 0 || !skipEmptyItems)
			{
				itemList.Add(sb.ToString());
			}
			sb.Remove(0, sb.Length);
			lastEscapedIndexInSB = -1;
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00011EA4 File Offset: 0x000100A4
		private static T[] Aggregate<T>(params global::System.Collections.Generic.IEnumerable<T>[] collections)
		{
			return new global::Infragistics.CoreUtilities.AggregateEnumerable<T>(collections).ToArray<T>();
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00011EB4 File Offset: 0x000100B4
		private void Append_EncloseInQuotes(global::System.Text.StringBuilder sb, string item)
		{
			sb.Append(this._openQuoteChars[0]);
			string value = this.EscapeString(item, true, false);
			sb.Append(value);
			sb.Append(this._closeQuoteChars[0]);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00011EF4 File Offset: 0x000100F4
		private static long CalcMask(char[] arr)
		{
			long num = 1L;
			for (int i = 0; i < arr.Length; i++)
			{
				long num2 = num * (long)arr[i];
				if (num2 <= num)
				{
					num = 0L;
					break;
				}
				num = num2;
			}
			return num;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00011F27 File Offset: 0x00010127
		private static bool ContainsCharHelper(char[] arr, char c, long mask)
		{
			return 0L == mask % (long)c && global::System.Array.IndexOf<char>(arr, c) >= 0;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00011F40 File Offset: 0x00010140
		private bool DoesCharNeedEscaping(char c, bool withinQuotes)
		{
			if (!withinQuotes)
			{
				return this.DoesCharNeedEscaping(c);
			}
			return this.DoesCharNeedEscapingWithinQuotes(c);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00011F54 File Offset: 0x00010154
		private bool DoesCharNeedEscaping(char c)
		{
			return global::Infragistics.ListParser.ContainsCharHelper(this._allSpecialChars, c, this._mask_allSpecialChars);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00011F68 File Offset: 0x00010168
		private bool DoesCharNeedEscapingWithinQuotes(char c)
		{
			return global::Infragistics.ListParser.ContainsCharHelper(this._specialCharsWithinQuotes, c, this._mask_specialCharsWithinQuotes);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00011F7C File Offset: 0x0001017C
		private char GetCorrespondingCloseQuoteChar(char openQuote)
		{
			char[] openQuoteChars = this._openQuoteChars;
			for (int i = 0; i < openQuoteChars.Length; i++)
			{
				if (openQuote == openQuoteChars[i])
				{
					return this._closeQuoteChars[i];
				}
			}
			throw new global::System.ArgumentException("Specified character is not an open quote character.");
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00011FB7 File Offset: 0x000101B7
		private bool IsCloseQuoteChar(char c)
		{
			return global::Infragistics.ListParser.ContainsCharHelper(this._closeQuoteChars, c, this._mask_closeQuoteChars);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00011FCB File Offset: 0x000101CB
		private bool IsOpenQuoteChar(char c)
		{
			return global::Infragistics.ListParser.ContainsCharHelper(this._openQuoteChars, c, this._mask_openQuoteChars);
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00011FE0 File Offset: 0x000101E0
		private static void TrimTrailingSpaces(global::System.Text.StringBuilder sb, int lastEscapedCharIndex)
		{
			int num = sb.Length - 1;
			while (num >= 0 && num > lastEscapedCharIndex && char.IsWhiteSpace(sb[num]))
			{
				sb.Remove(num, 1);
				num--;
			}
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x0001201C File Offset: 0x0001021C
		internal static global::Infragistics.ListParser CreateDefault(char separatorChar = ',')
		{
			char[] array = new char[]
			{
				'\'',
				'"'
			};
			return new global::Infragistics.ListParser(array, array, '\\', separatorChar);
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00012048 File Offset: 0x00010248
		public void ConstructList(global::System.Collections.Generic.IEnumerable<string> items, bool separateEachItemBySpace, global::System.Text.StringBuilder dest)
		{
			int num = 0;
			if (items != null)
			{
				foreach (string text in items)
				{
					if (num > 0)
					{
						dest.Append(this._itemsSeparatorChar);
						if (separateEachItemBySpace)
						{
							dest.Append(' ');
						}
					}
					dest.Append(this.EscapeString(text, false, true));
					num++;
				}
			}
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x000120C0 File Offset: 0x000102C0
		public string ConstructList(global::System.Collections.Generic.IEnumerable<string> items, bool separateEachItemBySpace)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			this.ConstructList(items, separateEachItemBySpace, stringBuilder);
			return stringBuilder.ToString();
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x000120E4 File Offset: 0x000102E4
		public string EscapeString(string text, bool withinQuotes, bool escapeLeadingAndTrailingWhiteSpace)
		{
			global::System.Text.StringBuilder stringBuilder = null;
			int i = 0;
			int num = (text == null) ? 0 : text.Length;
			while (i < num)
			{
				char c = text[i];
				if (this.DoesCharNeedEscaping(c, withinQuotes) || (escapeLeadingAndTrailingWhiteSpace && (i == 0 || 1 + i == text.Length) && !withinQuotes && char.IsWhiteSpace(c)))
				{
					if (stringBuilder == null)
					{
						stringBuilder = new global::System.Text.StringBuilder(text, 0, i, 2 * text.Length - i);
					}
					stringBuilder.Append(this._escapeCharacter).Append(c);
				}
				else if (stringBuilder != null)
				{
					stringBuilder.Append(c);
				}
				i++;
			}
			if (stringBuilder != null)
			{
				return stringBuilder.ToString();
			}
			return text;
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x0001217C File Offset: 0x0001037C
		internal int GetNextSeparator(string text, int startIndex)
		{
			bool flag = false;
			int i = startIndex;
			int length = text.Length;
			while (i < length)
			{
				if (!flag && this._itemsSeparatorChar == text[i])
				{
					return i;
				}
				i++;
			}
			return -1;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x000121B3 File Offset: 0x000103B3
		public string NormalizeEscapement(string text, bool withinQuotes)
		{
			return this.EscapeString(this.UnEscapeString(text), withinQuotes, true);
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x000121C4 File Offset: 0x000103C4
		public void ParseList(string text, bool skipEmptyItems, global::System.Collections.Generic.IList<string> dest)
		{
			if (text != null)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				global::Infragistics.ListParser.State state = global::Infragistics.ListParser.State.Initial;
				char c = '\0';
				int num = -1;
				int i = 0;
				int length = text.Length;
				while (i < length)
				{
					char c2 = text[i];
					if (global::Infragistics.ListParser.State.Escape == (global::Infragistics.ListParser.State.Escape & state))
					{
						num = stringBuilder.Length;
						stringBuilder.Append(c2);
						state ^= global::Infragistics.ListParser.State.Escape;
					}
					else if (this._escapeCharacter == c2)
					{
						state |= global::Infragistics.ListParser.State.Escape;
					}
					else if (global::Infragistics.ListParser.State.QuoteOpened == (global::Infragistics.ListParser.State.QuoteOpened & state) && c2 == c)
					{
						this.AddItemHelper(dest, stringBuilder, ref num, false, skipEmptyItems);
						state ^= global::Infragistics.ListParser.State.QuoteOpened;
						state |= global::Infragistics.ListParser.State.QuoteClosed;
					}
					else if (global::Infragistics.ListParser.State.QuoteOpened != (global::Infragistics.ListParser.State.QuoteOpened & state) && this.IsOpenQuoteChar(c2))
					{
						c = this.GetCorrespondingCloseQuoteChar(c2);
						state |= global::Infragistics.ListParser.State.QuoteOpened;
						state &= ~global::Infragistics.ListParser.State.QuoteClosed;
					}
					else if (global::Infragistics.ListParser.State.QuoteClosed == (global::Infragistics.ListParser.State.QuoteClosed & state) && this._itemsSeparatorChar == c2)
					{
						state ^= global::Infragistics.ListParser.State.QuoteClosed;
					}
					else if (global::Infragistics.ListParser.State.QuoteClosed == (global::Infragistics.ListParser.State.QuoteClosed & state))
					{
						state ^= global::Infragistics.ListParser.State.QuoteClosed;
					}
					else if (global::Infragistics.ListParser.State.Initial != state || !char.IsWhiteSpace(c2) || stringBuilder.Length != 0)
					{
						if (global::Infragistics.ListParser.State.Initial == state && this._itemsSeparatorChar == c2)
						{
							this.AddItemHelper(dest, stringBuilder, ref num, true, skipEmptyItems);
							state &= ~global::Infragistics.ListParser.State.QuoteClosed;
						}
						else
						{
							stringBuilder.Append(c2);
						}
					}
					i++;
				}
				if (global::Infragistics.ListParser.State.Initial == state || global::Infragistics.ListParser.State.Escape != state)
				{
				}
				if (stringBuilder.Length > 0)
				{
					this.AddItemHelper(dest, stringBuilder, ref num, true, skipEmptyItems);
				}
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00012308 File Offset: 0x00010508
		public global::System.Collections.Generic.IList<string> ParseList(string text, bool skipEmptyItems)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			this.ParseList(text, skipEmptyItems, list);
			return list;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00012328 File Offset: 0x00010528
		public string UnEscapeString(string text)
		{
			global::System.Text.StringBuilder stringBuilder = null;
			int i = 0;
			int num = (text == null) ? 0 : text.Length;
			while (i < num)
			{
				char c = text[i];
				if (this._escapeCharacter == c)
				{
					if (stringBuilder == null)
					{
						stringBuilder = new global::System.Text.StringBuilder(text, 0, i, text.Length - 1);
					}
					i++;
					if (i < text.Length)
					{
						stringBuilder.Append(text[i]);
					}
				}
				else if (stringBuilder != null)
				{
					stringBuilder.Append(c);
				}
				i++;
			}
			if (stringBuilder != null)
			{
				return stringBuilder.ToString();
			}
			return text;
		}

		// Token: 0x0400019A RID: 410
		private char[] _openQuoteChars;

		// Token: 0x0400019B RID: 411
		private char[] _closeQuoteChars;

		// Token: 0x0400019C RID: 412
		private char _escapeCharacter;

		// Token: 0x0400019D RID: 413
		private char _itemsSeparatorChar;

		// Token: 0x0400019E RID: 414
		private long _mask_allSpecialChars;

		// Token: 0x0400019F RID: 415
		private long _mask_openQuoteChars;

		// Token: 0x040001A0 RID: 416
		private long _mask_closeQuoteChars;

		// Token: 0x040001A1 RID: 417
		private long _mask_specialCharsWithinQuotes;

		// Token: 0x040001A2 RID: 418
		private char[] _allSpecialChars;

		// Token: 0x040001A3 RID: 419
		private char[] _specialCharsWithinQuotes;

		// Token: 0x02000071 RID: 113
		[global::System.Flags]
		private enum State
		{
			// Token: 0x040001A5 RID: 421
			Initial = 1,
			// Token: 0x040001A6 RID: 422
			Escape = 2,
			// Token: 0x040001A7 RID: 423
			QuoteOpened = 4,
			// Token: 0x040001A8 RID: 424
			QuoteClosed = 8
		}
	}
}
