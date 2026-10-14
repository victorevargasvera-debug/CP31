using System;
using System.Collections.Generic;
using System.Text;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001D5 RID: 469
	internal class Parser_ListOfItems
	{
		// Token: 0x06001B4A RID: 6986 RVA: 0x00074C14 File Offset: 0x00072E14
		public Parser_ListOfItems(char openQuoteChar, char closeQuoteChar, char escapeCharacter, char itemsSepratorChar) : this(new char[]
		{
			openQuoteChar
		}, new char[]
		{
			closeQuoteChar
		}, escapeCharacter, itemsSepratorChar)
		{
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00074C44 File Offset: 0x00072E44
		public Parser_ListOfItems(char[] openQuoteChars, char[] closeQuoteChars, char escapeCharacter, char itemsSepratorChar)
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
			this._itemsSepratorChar = itemsSepratorChar;
			this._allSpecialChars = global::Infragistics.Windows.DataPresenter.GridUtilities.Aggregate<char>(new global::System.Collections.Generic.IEnumerable<char>[]
			{
				openQuoteChars,
				closeQuoteChars,
				new char[]
				{
					escapeCharacter,
					itemsSepratorChar
				}
			});
			this._specialCharsWithinQuotes = global::Infragistics.Windows.DataPresenter.GridUtilities.Aggregate<char>(new global::System.Collections.Generic.IEnumerable<char>[]
			{
				openQuoteChars,
				closeQuoteChars,
				new char[]
				{
					escapeCharacter
				}
			});
			this._mask_allSpecialChars = global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.CalcMask(this._allSpecialChars);
			this._mask_specialCharsWithinQuotes = global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.CalcMask(this._specialCharsWithinQuotes);
			this._mask_openQuoteChars = global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.CalcMask(this._openQuoteChars);
			this._mask_closeQuoteChars = global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.CalcMask(this._closeQuoteChars);
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x00074D34 File Offset: 0x00072F34
		private void AddItemHelper(global::System.Collections.Generic.List<string> itemList, global::System.Text.StringBuilder sb, ref int lastEscapedIndexInSB, bool trimTrailingSpaces, bool skipEmptyItems)
		{
			if (trimTrailingSpaces)
			{
				global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.TrimTrailingSpaces(sb, lastEscapedIndexInSB);
			}
			if (sb.Length > 0 || !skipEmptyItems)
			{
				itemList.Add(sb.ToString());
			}
			sb.Remove(0, sb.Length);
			lastEscapedIndexInSB = -1;
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00074D6C File Offset: 0x00072F6C
		private void Append_EncloseInQuotes(global::System.Text.StringBuilder sb, string item)
		{
			sb.Append(this._openQuoteChars[0]);
			string value = this.EscapeString(item, true, false);
			sb.Append(value);
			sb.Append(this._closeQuoteChars[0]);
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00074DAC File Offset: 0x00072FAC
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

		// Token: 0x06001B4F RID: 6991 RVA: 0x00074DDF File Offset: 0x00072FDF
		private bool DoesCharNeedEscaping(char c, bool withinQuotes)
		{
			if (!withinQuotes)
			{
				return this.DoesCharNeedEscaping(c);
			}
			return this.DoesCharNeedEscapingWithinQuotes(c);
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00074DF3 File Offset: 0x00072FF3
		private bool DoesCharNeedEscaping(char c)
		{
			return 0L == this._mask_allSpecialChars % (long)c && global::System.Array.IndexOf<char>(this._allSpecialChars, c) >= 0;
		}

		// Token: 0x06001B51 RID: 6993 RVA: 0x00074E16 File Offset: 0x00073016
		private bool DoesCharNeedEscapingWithinQuotes(char c)
		{
			return 0L == this._mask_specialCharsWithinQuotes % (long)c && global::System.Array.IndexOf<char>(this._specialCharsWithinQuotes, c) >= 0;
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00074E3C File Offset: 0x0007303C
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

		// Token: 0x06001B53 RID: 6995 RVA: 0x00074E77 File Offset: 0x00073077
		private bool IsCloseQuoteChar(char c)
		{
			return 0L == this._mask_closeQuoteChars % (long)c && global::System.Array.IndexOf<char>(this._closeQuoteChars, c) >= 0;
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x00074E9A File Offset: 0x0007309A
		private bool IsOpenQuoteChar(char c)
		{
			return 0L == this._mask_openQuoteChars % (long)c && global::System.Array.IndexOf<char>(this._openQuoteChars, c) >= 0;
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00074EC0 File Offset: 0x000730C0
		private static void TrimTrailingSpaces(global::System.Text.StringBuilder sb, int lastEscapedCharIndex)
		{
			int num = sb.Length - 1;
			while (num >= 0 && num > lastEscapedCharIndex && char.IsWhiteSpace(sb[num]))
			{
				sb.Remove(num, 1);
				num--;
			}
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x00074EFC File Offset: 0x000730FC
		public string ConstructList(string[] items, bool seprateEachItemBySpace)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (int i = 0; i < items.Length; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(this._itemsSepratorChar);
					if (seprateEachItemBySpace)
					{
						stringBuilder.Append(' ');
					}
				}
				stringBuilder.Append(this.EscapeString(items[i], false, true));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00074F54 File Offset: 0x00073154
		public string EscapeString(string text, bool withinQuotes, bool escapeLeadingAndTrailingWhiteSpace)
		{
			global::System.Text.StringBuilder stringBuilder = null;
			for (int i = 0; i < text.Length; i++)
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
			}
			if (stringBuilder != null)
			{
				return stringBuilder.ToString();
			}
			return text;
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x00074FE3 File Offset: 0x000731E3
		public string NormalizeEscapement(string text, bool withinQuotes)
		{
			return this.EscapeString(this.UnEscapeString(text), withinQuotes, true);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x00074FF4 File Offset: 0x000731F4
		public string[] ParseList(string text, bool skipEmptyItems)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State state = global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.Initial;
			char c = '\0';
			int num = -1;
			foreach (char c2 in text)
			{
				if (global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.Escape == (global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.Escape & state))
				{
					num = stringBuilder.Length;
					stringBuilder.Append(c2);
					state ^= global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.Escape;
				}
				else if (this._escapeCharacter == c2)
				{
					state |= global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.Escape;
				}
				else if (global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteOpened == (global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteOpened & state) && c2 == c)
				{
					this.AddItemHelper(list, stringBuilder, ref num, false, skipEmptyItems);
					state ^= global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteOpened;
					state |= global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteClosed;
				}
				else if (global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteOpened != (global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteOpened & state) && this.IsOpenQuoteChar(c2))
				{
					c = this.GetCorrespondingCloseQuoteChar(c2);
					state |= global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteOpened;
					state &= ~global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteClosed;
				}
				else if (global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteClosed == (global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteClosed & state) && this._itemsSepratorChar == c2)
				{
					state ^= global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteClosed;
				}
				else if (global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteClosed == (global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteClosed & state))
				{
					state ^= global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteClosed;
				}
				else if (global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.Initial != state || !char.IsWhiteSpace(c2) || stringBuilder.Length != 0)
				{
					if (global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.Initial == state && this._itemsSepratorChar == c2)
					{
						this.AddItemHelper(list, stringBuilder, ref num, true, skipEmptyItems);
						state &= ~global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.QuoteClosed;
					}
					else
					{
						stringBuilder.Append(c2);
					}
				}
			}
			if (global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.Initial == state || global::Infragistics.Windows.DataPresenter.Parser_ListOfItems.State.Escape != state)
			{
			}
			if (stringBuilder.Length > 0)
			{
				this.AddItemHelper(list, stringBuilder, ref num, true, skipEmptyItems);
			}
			return list.ToArray();
		}

		// Token: 0x06001B5A RID: 7002 RVA: 0x0007513C File Offset: 0x0007333C
		public string UnEscapeString(string text)
		{
			global::System.Text.StringBuilder stringBuilder = null;
			for (int i = 0; i < text.Length; i++)
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
			}
			if (stringBuilder != null)
			{
				return stringBuilder.ToString();
			}
			return text;
		}

		// Token: 0x04000B3D RID: 2877
		private char[] _openQuoteChars;

		// Token: 0x04000B3E RID: 2878
		private char[] _closeQuoteChars;

		// Token: 0x04000B3F RID: 2879
		private char _escapeCharacter;

		// Token: 0x04000B40 RID: 2880
		private char _itemsSepratorChar;

		// Token: 0x04000B41 RID: 2881
		private long _mask_allSpecialChars;

		// Token: 0x04000B42 RID: 2882
		private long _mask_openQuoteChars;

		// Token: 0x04000B43 RID: 2883
		private long _mask_closeQuoteChars;

		// Token: 0x04000B44 RID: 2884
		private long _mask_specialCharsWithinQuotes;

		// Token: 0x04000B45 RID: 2885
		private char[] _allSpecialChars;

		// Token: 0x04000B46 RID: 2886
		private char[] _specialCharsWithinQuotes;

		// Token: 0x020001D6 RID: 470
		[global::System.Flags]
		private enum State
		{
			// Token: 0x04000B48 RID: 2888
			Initial = 1,
			// Token: 0x04000B49 RID: 2889
			Escape = 2,
			// Token: 0x04000B4A RID: 2890
			QuoteOpened = 4,
			// Token: 0x04000B4B RID: 2891
			QuoteClosed = 8
		}
	}
}
