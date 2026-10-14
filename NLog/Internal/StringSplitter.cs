using System;
using System.Collections.Generic;
using System.Text;

namespace NLog.Internal
{
	// Token: 0x0200012A RID: 298
	internal static class StringSplitter
	{
		// Token: 0x06000DBF RID: 3519 RVA: 0x00022E63 File Offset: 0x00021063
		public static global::System.Collections.Generic.IEnumerable<string> SplitWithSelfEscape(this string text, char splitChar)
		{
			return global::NLog.Internal.StringSplitter.SplitWithSelfEscape2(text, splitChar);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00022E6C File Offset: 0x0002106C
		public static global::System.Collections.Generic.IEnumerable<string> SplitWithEscape(this string text, char splitChar, char escapeChar)
		{
			if (splitChar == escapeChar)
			{
				return global::NLog.Internal.StringSplitter.SplitWithSelfEscape2(text, splitChar);
			}
			return global::NLog.Internal.StringSplitter.SplitWithEscape2(text, splitChar, escapeChar);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00022E82 File Offset: 0x00021082
		private static global::System.Collections.Generic.IEnumerable<string> SplitWithEscape2(string text, char splitChar, char escapeChar)
		{
			if (!string.IsNullOrEmpty(text))
			{
				bool prevWasEscape = false;
				global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
				int num;
				for (int i = 0; i < text.Length; i = num + 1)
				{
					char c = text[i];
					bool flag = c == splitChar;
					if (prevWasEscape)
					{
						if (flag)
						{
							if (sb.Length > 0)
							{
								global::System.Text.StringBuilder stringBuilder = sb;
								num = stringBuilder.Length;
								stringBuilder.Length = num - 1;
							}
							sb.Append(c);
							prevWasEscape = false;
						}
						else
						{
							sb.Append(c);
							prevWasEscape = (c == escapeChar);
						}
					}
					else if (flag)
					{
						string text2 = sb.ToString();
						sb.Length = 0;
						yield return text2;
						if (text.Length - 1 == i)
						{
							yield return string.Empty;
							break;
						}
					}
					else
					{
						sb.Append(c);
						prevWasEscape = (c == escapeChar);
					}
					num = i;
				}
				string lastPart = global::NLog.Internal.StringSplitter.GetLastPart(sb);
				if (lastPart != null)
				{
					yield return lastPart;
				}
				sb = null;
			}
			yield break;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00022EA0 File Offset: 0x000210A0
		private static global::System.Collections.Generic.IEnumerable<string> SplitWithSelfEscape2(string text, char splitAndEscapeChar)
		{
			if (!string.IsNullOrEmpty(text))
			{
				bool prevWasEscape = false;
				global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
				int num;
				for (int i = 0; i < text.Length; i = num + 1)
				{
					char c = text[i];
					bool flag = c == splitAndEscapeChar;
					bool flag2 = i == text.Length - 1;
					if (prevWasEscape)
					{
						if (flag)
						{
							prevWasEscape = false;
						}
						else
						{
							global::System.Text.StringBuilder stringBuilder = sb;
							num = stringBuilder.Length;
							stringBuilder.Length = num - 1;
							string text2 = sb.ToString();
							sb.Length = 0;
							prevWasEscape = false;
							sb.Append(c);
							yield return text2;
						}
					}
					else if (flag2 && flag)
					{
						string text3 = sb.ToString();
						sb.Length = 0;
						yield return text3;
						yield return string.Empty;
					}
					else
					{
						sb.Append(c);
						if (flag)
						{
							prevWasEscape = true;
						}
					}
					num = i;
				}
				string lastPart = global::NLog.Internal.StringSplitter.GetLastPart(sb);
				if (lastPart != null)
				{
					yield return lastPart;
				}
				sb = null;
			}
			yield break;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00022EB8 File Offset: 0x000210B8
		public static global::System.Collections.Generic.IEnumerable<string> SplitQuoted(this string text, char splitChar, char quoteChar, char escapeChar)
		{
			if (string.IsNullOrEmpty(text))
			{
				return new global::System.Collections.Generic.List<string>();
			}
			if (splitChar == quoteChar)
			{
				throw new global::System.NotSupportedException("Quote character should different from split character");
			}
			if (splitChar == escapeChar)
			{
				throw new global::System.NotSupportedException("Escape character should different from split character");
			}
			if (quoteChar == escapeChar)
			{
				return global::NLog.Internal.StringSplitter.SplitSelfQuoted2(text, splitChar, quoteChar);
			}
			return global::NLog.Internal.StringSplitter.SplitQuoted2(text, splitChar, quoteChar, escapeChar);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00022F07 File Offset: 0x00021107
		private static global::System.Collections.Generic.IEnumerable<string> SplitSelfQuoted2(string text, char splitChar, char quoteAndEscapeChar)
		{
			bool inQuotedMode = false;
			global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
			bool isNewPart = true;
			int num;
			for (int i = 0; i < text.Length; i = num + 1)
			{
				char c = text[i];
				bool flag = c == splitChar;
				bool flag2 = c == quoteAndEscapeChar;
				bool isLastChar = i == text.Length - 1;
				if (isNewPart)
				{
					isNewPart = false;
					flag2 = (c == quoteAndEscapeChar);
					if (flag2)
					{
						if (isLastChar)
						{
							sb.Append(c);
							break;
						}
						num = i;
						i = num + 1;
						c = text[i];
						if (c == quoteAndEscapeChar)
						{
							sb.Append(quoteAndEscapeChar);
						}
						else
						{
							sb.Append(c);
							inQuotedMode = true;
						}
					}
					else if (flag)
					{
						string text2 = sb.ToString();
						sb.Length = 0;
						yield return text2;
						if (isLastChar)
						{
							yield return string.Empty;
							break;
						}
						isNewPart = true;
					}
					else
					{
						sb.Append(c);
					}
				}
				else if (inQuotedMode)
				{
					if (flag2)
					{
						num = i;
						i = num + 1;
						inQuotedMode = false;
						string text3 = sb.ToString();
						sb.Length = 0;
						yield return text3;
					}
					else
					{
						sb.Append(c);
					}
				}
				else if (flag)
				{
					string text4 = sb.ToString();
					sb.Length = 0;
					yield return text4;
					if (isLastChar)
					{
						yield return string.Empty;
						break;
					}
					isNewPart = true;
				}
				else
				{
					sb.Append(c);
				}
				num = i;
			}
			string text5 = global::NLog.Internal.StringSplitter.GetLastPart(sb);
			if (inQuotedMode)
			{
				text5 = quoteAndEscapeChar.ToString() + text5;
			}
			if (text5 != null)
			{
				yield return text5;
			}
			yield break;
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00022F25 File Offset: 0x00021125
		private static global::System.Collections.Generic.IEnumerable<string> SplitQuoted2(string text, char splitChar, char quoteChar, char escapeChar)
		{
			bool inQuotedMode = false;
			global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
			bool isNewPart = true;
			bool prevIsEscape = false;
			int num;
			for (int i = 0; i < text.Length; i = num + 1)
			{
				char c = text[i];
				bool flag = c == splitChar;
				bool flag2 = c == quoteChar;
				bool flag3 = c == escapeChar;
				bool isLastChar = i == text.Length - 1;
				if (isNewPart)
				{
					isNewPart = false;
					flag2 = (c == quoteChar);
					flag3 = (c == escapeChar);
					if (flag3)
					{
						if (isLastChar)
						{
							sb.Append(c);
							break;
						}
						num = i;
						i = num + 1;
						c = text[i];
						if (c == quoteChar)
						{
							sb.Append(quoteChar);
						}
						else
						{
							sb.Append(escapeChar);
							sb.Append(c);
						}
					}
					else if (flag)
					{
						string text2 = sb.ToString();
						sb.Length = 0;
						yield return text2;
						if (isLastChar)
						{
							yield return string.Empty;
							break;
						}
						isNewPart = true;
					}
					else if (flag2)
					{
						if (sb.Length > 0)
						{
							global::System.Text.StringBuilder stringBuilder = sb;
							num = stringBuilder.Length;
							stringBuilder.Length = num - 1;
						}
						inQuotedMode = true;
					}
					else
					{
						sb.Append(c);
					}
				}
				else if (inQuotedMode)
				{
					if (flag2)
					{
						if (prevIsEscape)
						{
							if (sb.Length > 0)
							{
								global::System.Text.StringBuilder stringBuilder2 = sb;
								num = stringBuilder2.Length;
								stringBuilder2.Length = num - 1;
							}
							sb.Append(c);
							break;
						}
						num = i;
						i = num + 1;
						inQuotedMode = false;
						string text3 = sb.ToString();
						sb.Length = 0;
						yield return text3;
					}
					else
					{
						prevIsEscape = flag3;
						sb.Append(c);
					}
				}
				else if (flag)
				{
					string text4 = sb.ToString();
					sb.Length = 0;
					yield return text4;
					if (isLastChar)
					{
						yield return string.Empty;
						break;
					}
					isNewPart = true;
				}
				else
				{
					sb.Append(c);
				}
				num = i;
			}
			string text5 = global::NLog.Internal.StringSplitter.GetLastPart(sb);
			if (inQuotedMode)
			{
				text5 = quoteChar.ToString() + text5;
			}
			if (text5 != null)
			{
				yield return text5;
			}
			yield break;
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00022F4A File Offset: 0x0002114A
		private static string GetLastPart(global::System.Text.StringBuilder sb)
		{
			if (sb.Length > 0)
			{
				return sb.ToString();
			}
			return null;
		}
	}
}
