using System;
using System.Text;
using NLog.Internal;

namespace NLog.Conditions
{
	// Token: 0x02000187 RID: 391
	internal sealed class ConditionTokenizer
	{
		// Token: 0x060010AA RID: 4266 RVA: 0x0002C3D6 File Offset: 0x0002A5D6
		public ConditionTokenizer(global::NLog.Internal.SimpleStringReader stringReader)
		{
			this._stringReader = stringReader;
			this.TokenType = global::NLog.Conditions.ConditionTokenType.BeginningOfInput;
			this.GetNextToken();
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x060010AB RID: 4267 RVA: 0x0002C3F2 File Offset: 0x0002A5F2
		// (set) Token: 0x060010AC RID: 4268 RVA: 0x0002C3FA File Offset: 0x0002A5FA
		public global::NLog.Conditions.ConditionTokenType TokenType { get; private set; }

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x060010AD RID: 4269 RVA: 0x0002C403 File Offset: 0x0002A603
		// (set) Token: 0x060010AE RID: 4270 RVA: 0x0002C40B File Offset: 0x0002A60B
		public string TokenValue { get; private set; }

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x060010AF RID: 4271 RVA: 0x0002C414 File Offset: 0x0002A614
		public string StringTokenValue
		{
			get
			{
				string tokenValue = this.TokenValue;
				return tokenValue.Substring(1, tokenValue.Length - 2).Replace("''", "'");
			}
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x0002C446 File Offset: 0x0002A646
		public void Expect(global::NLog.Conditions.ConditionTokenType tokenType)
		{
			if (this.TokenType != tokenType)
			{
				throw new global::NLog.Conditions.ConditionParseException(string.Format("Expected token of type: {0}, got {1} ({2}).", tokenType, this.TokenType, this.TokenValue));
			}
			this.GetNextToken();
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0002C47E File Offset: 0x0002A67E
		public string EatKeyword()
		{
			if (this.TokenType != global::NLog.Conditions.ConditionTokenType.Keyword)
			{
				throw new global::NLog.Conditions.ConditionParseException("Identifier expected");
			}
			string tokenValue = this.TokenValue;
			this.GetNextToken();
			return tokenValue;
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x0002C4A0 File Offset: 0x0002A6A0
		public bool IsKeyword(string keyword)
		{
			return this.TokenType == global::NLog.Conditions.ConditionTokenType.Keyword && this.TokenValue.Equals(keyword, global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x0002C4BA File Offset: 0x0002A6BA
		public bool IsEOF()
		{
			return this.TokenType == global::NLog.Conditions.ConditionTokenType.EndOfInput;
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x0002C4C5 File Offset: 0x0002A6C5
		public bool IsNumber()
		{
			return this.TokenType == global::NLog.Conditions.ConditionTokenType.Number;
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x0002C4D0 File Offset: 0x0002A6D0
		public bool IsToken(global::NLog.Conditions.ConditionTokenType tokenType)
		{
			return this.TokenType == tokenType;
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x0002C4DC File Offset: 0x0002A6DC
		public void GetNextToken()
		{
			if (this.TokenType == global::NLog.Conditions.ConditionTokenType.EndOfInput)
			{
				throw new global::NLog.Conditions.ConditionParseException("Cannot read past end of stream.");
			}
			this.SkipWhitespace();
			int num = this.PeekChar();
			if (num == -1)
			{
				this.TokenType = global::NLog.Conditions.ConditionTokenType.EndOfInput;
				return;
			}
			char c = (char)num;
			if (char.IsDigit(c))
			{
				this.ParseNumber(c);
				return;
			}
			if (c == '\'')
			{
				this.ParseSingleQuotedString(c);
				return;
			}
			if (c == '_' || char.IsLetter(c))
			{
				this.ParseKeyword(c);
				return;
			}
			if (c == '}' || c == ':')
			{
				this.TokenType = global::NLog.Conditions.ConditionTokenType.EndOfInput;
				return;
			}
			this.TokenValue = c.ToString();
			if (this.TryGetComparisonToken(c))
			{
				return;
			}
			if (this.TryGetLogicalToken(c))
			{
				return;
			}
			if (c < ' ' || c >= '\u0080')
			{
				throw new global::NLog.Conditions.ConditionParseException(string.Format("Invalid token: {0}", c));
			}
			global::NLog.Conditions.ConditionTokenType conditionTokenType = global::NLog.Conditions.ConditionTokenizer.charIndexToTokenType[(int)c];
			if (conditionTokenType != global::NLog.Conditions.ConditionTokenType.Invalid)
			{
				this.TokenType = conditionTokenType;
				this.TokenValue = new string(c, 1);
				this.ReadChar();
				return;
			}
			throw new global::NLog.Conditions.ConditionParseException(string.Format("Invalid punctuation: {0}", c));
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x0002C5E0 File Offset: 0x0002A7E0
		private bool TryGetComparisonToken(char ch)
		{
			if (ch == '<')
			{
				this.ReadChar();
				int num = this.PeekChar();
				if (num == 62)
				{
					this.TokenType = global::NLog.Conditions.ConditionTokenType.NotEqual;
					this.TokenValue = "<>";
					this.ReadChar();
					return true;
				}
				if (num == 61)
				{
					this.TokenType = global::NLog.Conditions.ConditionTokenType.LessThanOrEqualTo;
					this.TokenValue = "<=";
					this.ReadChar();
					return true;
				}
				this.TokenType = global::NLog.Conditions.ConditionTokenType.LessThan;
				this.TokenValue = "<";
				return true;
			}
			else
			{
				if (ch != '>')
				{
					return false;
				}
				this.ReadChar();
				if (this.PeekChar() == 61)
				{
					this.TokenType = global::NLog.Conditions.ConditionTokenType.GreaterThanOrEqualTo;
					this.TokenValue = ">=";
					this.ReadChar();
					return true;
				}
				this.TokenType = global::NLog.Conditions.ConditionTokenType.GreaterThan;
				this.TokenValue = ">";
				return true;
			}
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0002C6A0 File Offset: 0x0002A8A0
		private bool TryGetLogicalToken(char ch)
		{
			if (ch == '!')
			{
				this.ReadChar();
				if (this.PeekChar() == 61)
				{
					this.TokenType = global::NLog.Conditions.ConditionTokenType.NotEqual;
					this.TokenValue = "!=";
					this.ReadChar();
					return true;
				}
				this.TokenType = global::NLog.Conditions.ConditionTokenType.Not;
				this.TokenValue = "!";
				return true;
			}
			else if (ch == '&')
			{
				this.ReadChar();
				if (this.PeekChar() == 38)
				{
					this.TokenType = global::NLog.Conditions.ConditionTokenType.And;
					this.TokenValue = "&&";
					this.ReadChar();
					return true;
				}
				throw new global::NLog.Conditions.ConditionParseException("Expected '&&' but got '&'");
			}
			else if (ch == '|')
			{
				this.ReadChar();
				if (this.PeekChar() == 124)
				{
					this.TokenType = global::NLog.Conditions.ConditionTokenType.Or;
					this.TokenValue = "||";
					this.ReadChar();
					return true;
				}
				throw new global::NLog.Conditions.ConditionParseException("Expected '||' but got '|'");
			}
			else
			{
				if (ch != '=')
				{
					return false;
				}
				this.ReadChar();
				if (this.PeekChar() == 61)
				{
					this.TokenType = global::NLog.Conditions.ConditionTokenType.EqualTo;
					this.TokenValue = "==";
					this.ReadChar();
					return true;
				}
				this.TokenType = global::NLog.Conditions.ConditionTokenType.EqualTo;
				this.TokenValue = "=";
				return true;
			}
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x0002C7B8 File Offset: 0x0002A9B8
		private static global::NLog.Conditions.ConditionTokenType[] BuildCharIndexToTokenType()
		{
			global::NLog.Conditions.ConditionTokenizer.CharToTokenType[] array = new global::NLog.Conditions.ConditionTokenizer.CharToTokenType[]
			{
				new global::NLog.Conditions.ConditionTokenizer.CharToTokenType('(', global::NLog.Conditions.ConditionTokenType.LeftParen),
				new global::NLog.Conditions.ConditionTokenizer.CharToTokenType(')', global::NLog.Conditions.ConditionTokenType.RightParen),
				new global::NLog.Conditions.ConditionTokenizer.CharToTokenType('.', global::NLog.Conditions.ConditionTokenType.Dot),
				new global::NLog.Conditions.ConditionTokenizer.CharToTokenType(',', global::NLog.Conditions.ConditionTokenType.Comma),
				new global::NLog.Conditions.ConditionTokenizer.CharToTokenType('!', global::NLog.Conditions.ConditionTokenType.Not),
				new global::NLog.Conditions.ConditionTokenizer.CharToTokenType('-', global::NLog.Conditions.ConditionTokenType.Minus)
			};
			global::NLog.Conditions.ConditionTokenType[] array2 = new global::NLog.Conditions.ConditionTokenType[128];
			for (int i = 0; i < 128; i++)
			{
				array2[i] = global::NLog.Conditions.ConditionTokenType.Invalid;
			}
			foreach (global::NLog.Conditions.ConditionTokenizer.CharToTokenType charToTokenType in array)
			{
				array2[(int)charToTokenType.Character] = charToTokenType.TokenType;
			}
			return array2;
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0002C87C File Offset: 0x0002AA7C
		private void ParseSingleQuotedString(char ch)
		{
			this.TokenType = global::NLog.Conditions.ConditionTokenType.String;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(ch);
			this.ReadChar();
			int num;
			while ((num = this.PeekChar()) != -1)
			{
				ch = (char)num;
				stringBuilder.Append((char)this.ReadChar());
				if (ch == '\'')
				{
					if (this.PeekChar() != 39)
					{
						break;
					}
					stringBuilder.Append('\'');
					this.ReadChar();
				}
			}
			if (num == -1)
			{
				throw new global::NLog.Conditions.ConditionParseException("String literal is missing a closing quote character.");
			}
			this.TokenValue = stringBuilder.ToString();
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0002C900 File Offset: 0x0002AB00
		private void ParseKeyword(char ch)
		{
			this.TokenType = global::NLog.Conditions.ConditionTokenType.Keyword;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(ch);
			this.ReadChar();
			int num;
			while ((num = this.PeekChar()) != -1 && ((ushort)num == 95 || (ushort)num == 45 || char.IsLetterOrDigit((char)num)))
			{
				stringBuilder.Append((char)this.ReadChar());
			}
			this.TokenValue = stringBuilder.ToString();
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0002C968 File Offset: 0x0002AB68
		private void ParseNumber(char ch)
		{
			this.TokenType = global::NLog.Conditions.ConditionTokenType.Number;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(ch);
			this.ReadChar();
			int num;
			while ((num = this.PeekChar()) != -1)
			{
				ch = (char)num;
				if (!char.IsDigit(ch) && ch != '.')
				{
					break;
				}
				stringBuilder.Append((char)this.ReadChar());
			}
			this.TokenValue = stringBuilder.ToString();
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0002C9CC File Offset: 0x0002ABCC
		private void SkipWhitespace()
		{
			int num;
			while ((num = this.PeekChar()) != -1 && char.IsWhiteSpace((char)num))
			{
				this.ReadChar();
			}
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0002C9F6 File Offset: 0x0002ABF6
		private int PeekChar()
		{
			return this._stringReader.Peek();
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0002CA03 File Offset: 0x0002AC03
		private int ReadChar()
		{
			return this._stringReader.Read();
		}

		// Token: 0x04000498 RID: 1176
		private static readonly global::NLog.Conditions.ConditionTokenType[] charIndexToTokenType = global::NLog.Conditions.ConditionTokenizer.BuildCharIndexToTokenType();

		// Token: 0x04000499 RID: 1177
		private readonly global::NLog.Internal.SimpleStringReader _stringReader;

		// Token: 0x02000240 RID: 576
		private struct CharToTokenType
		{
			// Token: 0x060013BB RID: 5051 RVA: 0x00033243 File Offset: 0x00031443
			public CharToTokenType(char character, global::NLog.Conditions.ConditionTokenType tokenType)
			{
				this.Character = character;
				this.TokenType = tokenType;
			}

			// Token: 0x04000690 RID: 1680
			public readonly char Character;

			// Token: 0x04000691 RID: 1681
			public readonly global::NLog.Conditions.ConditionTokenType TokenType;
		}
	}
}
