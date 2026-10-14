using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Text;

namespace System.Data.Entity.Core.EntityClient.Internal
{
	// Token: 0x020005E4 RID: 1508
	internal class DbConnectionOptions
	{
		// Token: 0x060049C3 RID: 18883 RVA: 0x0010491D File Offset: 0x00102B1D
		internal DbConnectionOptions()
		{
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x00104930 File Offset: 0x00102B30
		internal DbConnectionOptions(string connectionString, global::System.Collections.Generic.IList<string> validKeywords)
		{
			this._usersConnectionString = (connectionString ?? "");
			if (0 < this._usersConnectionString.Length)
			{
				this.KeyChain = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParseInternal(this._parsetable, this._usersConnectionString, validKeywords);
			}
		}

		// Token: 0x17000E97 RID: 3735
		// (get) Token: 0x060049C5 RID: 18885 RVA: 0x00104984 File Offset: 0x00102B84
		internal string UsersConnectionString
		{
			get
			{
				return this._usersConnectionString ?? string.Empty;
			}
		}

		// Token: 0x17000E98 RID: 3736
		// (get) Token: 0x060049C6 RID: 18886 RVA: 0x00104995 File Offset: 0x00102B95
		internal bool IsEmpty
		{
			get
			{
				return this.KeyChain == null;
			}
		}

		// Token: 0x17000E99 RID: 3737
		// (get) Token: 0x060049C7 RID: 18887 RVA: 0x001049A0 File Offset: 0x00102BA0
		internal global::System.Collections.Generic.Dictionary<string, string> Parsetable
		{
			get
			{
				return this._parsetable;
			}
		}

		// Token: 0x17000E9A RID: 3738
		internal virtual string this[string keyword]
		{
			get
			{
				string result;
				this._parsetable.TryGetValue(keyword, out result);
				return result;
			}
		}

		// Token: 0x060049C9 RID: 18889 RVA: 0x001049C8 File Offset: 0x00102BC8
		private static string GetKeyName(global::System.Text.StringBuilder buffer)
		{
			int num = buffer.Length;
			while (0 < num && char.IsWhiteSpace(buffer[num - 1]))
			{
				num--;
			}
			return buffer.ToString(0, num).ToLowerInvariant();
		}

		// Token: 0x060049CA RID: 18890 RVA: 0x00104A04 File Offset: 0x00102C04
		private static string GetKeyValue(global::System.Text.StringBuilder buffer, bool trimWhitespace)
		{
			int num = buffer.Length;
			int i = 0;
			if (trimWhitespace)
			{
				while (i < num)
				{
					if (!char.IsWhiteSpace(buffer[i]))
					{
						break;
					}
					i++;
				}
				while (0 < num && char.IsWhiteSpace(buffer[num - 1]))
				{
					num--;
				}
			}
			return buffer.ToString(i, num - i);
		}

		// Token: 0x060049CB RID: 18891 RVA: 0x00104A5C File Offset: 0x00102C5C
		private static int GetKeyValuePair(string connectionString, int currentPosition, global::System.Text.StringBuilder buffer, out string keyname, out string keyvalue)
		{
			int num = currentPosition;
			buffer.Length = 0;
			keyname = null;
			keyvalue = null;
			char c = '\0';
			global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.NothingYet;
			int length = connectionString.Length;
			while (currentPosition < length)
			{
				c = connectionString[currentPosition];
				switch (parserState)
				{
				case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.NothingYet:
					if (';' != c && !char.IsWhiteSpace(c))
					{
						if (c == '\0')
						{
							parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.NullTermination;
						}
						else
						{
							if (char.IsControl(c))
							{
								throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_ConnectionStringSyntax(num));
							}
							num = currentPosition;
							if ('=' != c)
							{
								parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.Key;
								goto IL_257;
							}
							parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.KeyEqual;
						}
					}
					break;
				case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.Key:
					if ('=' == c)
					{
						parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.KeyEqual;
					}
					else
					{
						if (!char.IsWhiteSpace(c) && char.IsControl(c))
						{
							throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_ConnectionStringSyntax(num));
						}
						goto IL_257;
					}
					break;
				case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.KeyEqual:
					if ('=' == c)
					{
						parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.Key;
						goto IL_257;
					}
					keyname = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.GetKeyName(buffer);
					if (string.IsNullOrEmpty(keyname))
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_ConnectionStringSyntax(num));
					}
					buffer.Length = 0;
					parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.KeyEnd;
					goto IL_117;
				case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.KeyEnd:
					goto IL_117;
				case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.UnquotedValue:
					if (char.IsWhiteSpace(c))
					{
						goto IL_257;
					}
					if (char.IsControl(c))
					{
						goto IL_26B;
					}
					if (';' == c)
					{
						goto IL_26B;
					}
					goto IL_257;
				case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.DoubleQuoteValue:
					if ('"' == c)
					{
						parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.DoubleQuoteValueQuote;
					}
					else
					{
						if (c == '\0')
						{
							throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_ConnectionStringSyntax(num));
						}
						goto IL_257;
					}
					break;
				case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.DoubleQuoteValueQuote:
					if ('"' == c)
					{
						parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.DoubleQuoteValue;
						goto IL_257;
					}
					keyvalue = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.GetKeyValue(buffer, false);
					parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.QuotedValueEnd;
					goto IL_200;
				case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.SingleQuoteValue:
					if ('\'' == c)
					{
						parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.SingleQuoteValueQuote;
					}
					else
					{
						if (c == '\0')
						{
							throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_ConnectionStringSyntax(num));
						}
						goto IL_257;
					}
					break;
				case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.SingleQuoteValueQuote:
					if ('\'' == c)
					{
						parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.SingleQuoteValue;
						goto IL_257;
					}
					keyvalue = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.GetKeyValue(buffer, false);
					parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.QuotedValueEnd;
					goto IL_200;
				case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.QuotedValueEnd:
					goto IL_200;
				case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.NullTermination:
					if (c != '\0' && !char.IsWhiteSpace(c))
					{
						throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_ConnectionStringSyntax(currentPosition));
					}
					break;
				default:
					throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_InternalProviderError(1015));
				}
				IL_25F:
				currentPosition++;
				continue;
				IL_117:
				if (char.IsWhiteSpace(c))
				{
					goto IL_25F;
				}
				if ('\'' == c)
				{
					parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.SingleQuoteValue;
					goto IL_25F;
				}
				if ('"' == c)
				{
					parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.DoubleQuoteValue;
					goto IL_25F;
				}
				if (';' == c || c == '\0')
				{
					break;
				}
				if (char.IsControl(c))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_ConnectionStringSyntax(num));
				}
				parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.UnquotedValue;
				goto IL_257;
				IL_200:
				if (char.IsWhiteSpace(c))
				{
					goto IL_25F;
				}
				if (';' == c)
				{
					break;
				}
				if (c == '\0')
				{
					parserState = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.NullTermination;
					goto IL_25F;
				}
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_ConnectionStringSyntax(num));
				IL_257:
				buffer.Append(c);
				goto IL_25F;
			}
			IL_26B:
			switch (parserState)
			{
			case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.NothingYet:
			case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.KeyEnd:
			case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.NullTermination:
				break;
			case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.Key:
			case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.DoubleQuoteValue:
			case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.SingleQuoteValue:
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_ConnectionStringSyntax(num));
			case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.KeyEqual:
				keyname = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.GetKeyName(buffer);
				if (string.IsNullOrEmpty(keyname))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_ConnectionStringSyntax(num));
				}
				break;
			case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.UnquotedValue:
			{
				keyvalue = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.GetKeyValue(buffer, true);
				char c2 = keyvalue[keyvalue.Length - 1];
				if ('\'' == c2 || '"' == c2)
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_ConnectionStringSyntax(num));
				}
				break;
			}
			case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.DoubleQuoteValueQuote:
			case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.SingleQuoteValueQuote:
			case global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.ParserState.QuotedValueEnd:
				keyvalue = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.GetKeyValue(buffer, false);
				break;
			default:
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ADP_InternalProviderError(1016));
			}
			if (';' == c && currentPosition < connectionString.Length)
			{
				currentPosition++;
			}
			return currentPosition;
		}

		// Token: 0x060049CC RID: 18892 RVA: 0x00104DB0 File Offset: 0x00102FB0
		private static global::System.Data.Entity.Core.EntityClient.NameValuePair ParseInternal(global::System.Collections.Generic.IDictionary<string, string> parsetable, string connectionString, global::System.Collections.Generic.IList<string> validKeywords)
		{
			global::System.Text.StringBuilder buffer = new global::System.Text.StringBuilder();
			global::System.Data.Entity.Core.EntityClient.NameValuePair nameValuePair = null;
			global::System.Data.Entity.Core.EntityClient.NameValuePair result = null;
			int i = 0;
			int length = connectionString.Length;
			while (i < length)
			{
				int currentPosition = i;
				string text;
				string value;
				i = global::System.Data.Entity.Core.EntityClient.Internal.DbConnectionOptions.GetKeyValuePair(connectionString, currentPosition, buffer, out text, out value);
				if (string.IsNullOrEmpty(text))
				{
					break;
				}
				if (!validKeywords.Contains(text))
				{
					throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.ADP_KeywordNotSupported(text));
				}
				parsetable[text] = value;
				if (nameValuePair != null)
				{
					nameValuePair = (nameValuePair.Next = new global::System.Data.Entity.Core.EntityClient.NameValuePair());
				}
				else
				{
					nameValuePair = (result = new global::System.Data.Entity.Core.EntityClient.NameValuePair());
				}
			}
			return result;
		}

		// Token: 0x04001A06 RID: 6662
		internal const string DataDirectory = "|datadirectory|";

		// Token: 0x04001A07 RID: 6663
		private readonly string _usersConnectionString;

		// Token: 0x04001A08 RID: 6664
		private readonly global::System.Collections.Generic.Dictionary<string, string> _parsetable = new global::System.Collections.Generic.Dictionary<string, string>();

		// Token: 0x04001A09 RID: 6665
		internal readonly global::System.Data.Entity.Core.EntityClient.NameValuePair KeyChain;

		// Token: 0x02000C29 RID: 3113
		private enum ParserState
		{
			// Token: 0x04003032 RID: 12338
			NothingYet = 1,
			// Token: 0x04003033 RID: 12339
			Key,
			// Token: 0x04003034 RID: 12340
			KeyEqual,
			// Token: 0x04003035 RID: 12341
			KeyEnd,
			// Token: 0x04003036 RID: 12342
			UnquotedValue,
			// Token: 0x04003037 RID: 12343
			DoubleQuoteValue,
			// Token: 0x04003038 RID: 12344
			DoubleQuoteValueQuote,
			// Token: 0x04003039 RID: 12345
			SingleQuoteValue,
			// Token: 0x0400303A RID: 12346
			SingleQuoteValueQuote,
			// Token: 0x0400303B RID: 12347
			QuotedValueEnd,
			// Token: 0x0400303C RID: 12348
			NullTermination
		}
	}
}
