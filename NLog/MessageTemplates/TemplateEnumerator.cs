using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace NLog.MessageTemplates
{
	// Token: 0x02000081 RID: 129
	internal struct TemplateEnumerator : global::System.Collections.Generic.IEnumerator<global::NLog.MessageTemplates.LiteralHole>, global::System.IDisposable, global::System.Collections.IEnumerator
	{
		// Token: 0x060008B3 RID: 2227 RVA: 0x00016A4C File Offset: 0x00014C4C
		public TemplateEnumerator(string template)
		{
			if (template == null)
			{
				throw new global::System.ArgumentNullException("template");
			}
			this._template = template;
			this._length = this._template.Length;
			this._position = 0;
			this._literalLength = 0;
			this._current = default(global::NLog.MessageTemplates.LiteralHole);
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x00016A9A File Offset: 0x00014C9A
		public global::NLog.MessageTemplates.LiteralHole Current
		{
			get
			{
				return this._current;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x00016AA2 File Offset: 0x00014CA2
		object global::System.Collections.IEnumerator.Current
		{
			get
			{
				return this._current;
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00016AAF File Offset: 0x00014CAF
		public void Dispose()
		{
			this._template = string.Empty;
			this._length = 0;
			this.Reset();
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00016AC9 File Offset: 0x00014CC9
		public void Reset()
		{
			this._position = 0;
			this._literalLength = 0;
			this._current = default(global::NLog.MessageTemplates.LiteralHole);
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00016AE8 File Offset: 0x00014CE8
		public bool MoveNext()
		{
			bool result;
			try
			{
				while (this._position < this._length)
				{
					char c = this.Peek();
					if (c == '{')
					{
						this.ParseOpenBracketPart();
						return true;
					}
					if (c == '}')
					{
						this.ParseCloseBracketPart();
						return true;
					}
					this.ParseTextPart();
				}
				if (this._literalLength != 0)
				{
					this.AddLiteral();
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (global::System.IndexOutOfRangeException)
			{
				throw new global::NLog.MessageTemplates.TemplateParserException("Unexpected end of template.", this._position, this._template);
			}
			return result;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x00016B70 File Offset: 0x00014D70
		private void AddLiteral()
		{
			this._current = new global::NLog.MessageTemplates.LiteralHole(new global::NLog.MessageTemplates.Literal
			{
				Print = this._literalLength,
				Skip = 0
			}, default(global::NLog.MessageTemplates.Hole));
			this._literalLength = 0;
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00016BB6 File Offset: 0x00014DB6
		private void ParseTextPart()
		{
			this._literalLength = (int)((short)this.SkipUntil(global::NLog.MessageTemplates.TemplateEnumerator.TextDelimiters, false));
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00016BCC File Offset: 0x00014DCC
		private void ParseOpenBracketPart()
		{
			this.Skip('{');
			char c = this.Peek();
			if (c == '$')
			{
				this.Skip('$');
				this.ParseHole(global::NLog.MessageTemplates.CaptureType.Stringify);
				return;
			}
			if (c == '@')
			{
				this.Skip('@');
				this.ParseHole(global::NLog.MessageTemplates.CaptureType.Serialize);
				return;
			}
			if (c == '{')
			{
				this.Skip('{');
				this._literalLength++;
				this.AddLiteral();
				return;
			}
			this.ParseHole(global::NLog.MessageTemplates.CaptureType.Normal);
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x00016C3C File Offset: 0x00014E3C
		private void ParseCloseBracketPart()
		{
			this.Skip('}');
			if (this.Read() != '}')
			{
				throw new global::NLog.MessageTemplates.TemplateParserException("Unexpected '}}' ", this._position - 2, this._template);
			}
			this._literalLength++;
			this.AddLiteral();
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x00016C88 File Offset: 0x00014E88
		private void ParseHole(global::NLog.MessageTemplates.CaptureType type)
		{
			int position = this._position;
			int num;
			string name = this.ParseName(out num);
			int num2 = 0;
			string format = null;
			if (this.Peek() != '}')
			{
				num2 = ((this.Peek() == ',') ? this.ParseAlignment() : 0);
				format = ((this.Peek() == ':') ? this.ParseFormat() : null);
				this.Skip('}');
			}
			else
			{
				this._position++;
			}
			int num3 = this._position - position + ((type == global::NLog.MessageTemplates.CaptureType.Normal) ? 1 : 2);
			this._current = new global::NLog.MessageTemplates.LiteralHole(new global::NLog.MessageTemplates.Literal
			{
				Print = this._literalLength,
				Skip = (short)num3
			}, new global::NLog.MessageTemplates.Hole(name, format, type, (short)num, (short)num2));
			this._literalLength = 0;
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00016D48 File Offset: 0x00014F48
		private string ParseName(out int parameterIndex)
		{
			parameterIndex = -1;
			char c = this.Peek();
			if (c >= '0' && c <= '9')
			{
				int position = this._position;
				int num = this.ReadInt();
				c = this.Peek();
				if (num >= 0)
				{
					if (c == '}' || c == ':' || c == ',')
					{
						parameterIndex = num;
						switch (parameterIndex)
						{
						case 0:
							return "0";
						case 1:
							return "1";
						case 2:
							return "2";
						case 3:
							return "3";
						case 4:
							return "4";
						case 5:
							return "5";
						case 6:
							return "6";
						case 7:
							return "7";
						case 8:
							return "8";
						case 9:
							return "9";
						default:
							return parameterIndex.ToString(global::System.Globalization.CultureInfo.InvariantCulture);
						}
					}
					else if (c == ' ')
					{
						this.SkipSpaces();
						c = this.Peek();
						if (c == '}' || c == ':' || c == ',')
						{
							parameterIndex = num;
						}
					}
				}
				this._position = position;
			}
			return this.ReadUntil(global::NLog.MessageTemplates.TemplateEnumerator.HoleDelimiters, true);
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00016E50 File Offset: 0x00015050
		private string ParseFormat()
		{
			this.Skip(':');
			string text = this.ReadUntil(global::NLog.MessageTemplates.TemplateEnumerator.TextDelimiters, true);
			char c2;
			for (;;)
			{
				char c = this.Read();
				if (c != '{')
				{
					if (c == '}')
					{
						if (this._position >= this._length || this.Peek() != '}')
						{
							break;
						}
						this.Skip('}');
						text += "}";
					}
				}
				else
				{
					c2 = this.Peek();
					if (c2 != '{')
					{
						goto IL_89;
					}
					this.Skip('{');
					text += "{";
				}
				text += this.ReadUntil(global::NLog.MessageTemplates.TemplateEnumerator.TextDelimiters, true);
			}
			this._position--;
			return text;
			IL_89:
			throw new global::NLog.MessageTemplates.TemplateParserException(string.Format("Expected '{{' but found '{0}' instead in format.", c2), this._position, this._template);
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00016F20 File Offset: 0x00015120
		private int ParseAlignment()
		{
			this.Skip(',');
			this.SkipSpaces();
			int result = this.ReadInt();
			this.SkipSpaces();
			char c = this.Peek();
			if (c != ':' && c != '}')
			{
				throw new global::NLog.MessageTemplates.TemplateParserException(string.Format("Expected ':' or '}}' but found '{0}' instead.", c), this._position, this._template);
			}
			return result;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00016F7A File Offset: 0x0001517A
		private char Peek()
		{
			return this._template[this._position];
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00016F90 File Offset: 0x00015190
		private char Read()
		{
			string template = this._template;
			int position = this._position;
			this._position = position + 1;
			return template[position];
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00016FB9 File Offset: 0x000151B9
		private void Skip(char c)
		{
			this._position++;
		}

		// Token: 0x060008C4 RID: 2244 RVA: 0x00016FC9 File Offset: 0x000151C9
		private void SkipSpaces()
		{
			while (this._template[this._position] == ' ')
			{
				this._position++;
			}
		}

		// Token: 0x060008C5 RID: 2245 RVA: 0x00016FF0 File Offset: 0x000151F0
		private int SkipUntil(char[] search, bool required = true)
		{
			int position = this._position;
			int num = this._template.IndexOfAny(search, this._position);
			if (num == -1 && required)
			{
				string arg = string.Join(", ", (from c in search
				select "'" + c.ToString() + "'").ToArray<string>());
				throw new global::NLog.MessageTemplates.TemplateParserException(string.Format("Reached end of template while expecting one of {0}.", arg), this._position, this._template);
			}
			this._position = ((num == -1) ? this._length : num);
			return this._position - position;
		}

		// Token: 0x060008C6 RID: 2246 RVA: 0x0001708C File Offset: 0x0001528C
		private int ReadInt()
		{
			bool flag = false;
			int num = 0;
			for (int i = 0; i < 12; i++)
			{
				char c = this.Peek();
				int num2 = (int)(c - '0');
				if (num2 < 0 || num2 > 9)
				{
					if ((i > 0 && !flag) || i > 1)
					{
						if (!flag)
						{
							return num;
						}
						return -num;
					}
					else
					{
						if (i != 0 || c != '-')
						{
							break;
						}
						flag = true;
						this._position++;
					}
				}
				else
				{
					this._position++;
					num = num * 10 + num2;
				}
			}
			throw new global::NLog.MessageTemplates.TemplateParserException("An integer is expected", this._position, this._template);
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x0001711C File Offset: 0x0001531C
		private string ReadUntil(char[] search, bool required = true)
		{
			int position = this._position;
			return this._template.Substring(position, this.SkipUntil(search, required));
		}

		// Token: 0x04000217 RID: 535
		private static readonly char[] HoleDelimiters = new char[]
		{
			'}',
			':',
			','
		};

		// Token: 0x04000218 RID: 536
		private static readonly char[] TextDelimiters = new char[]
		{
			'{',
			'}'
		};

		// Token: 0x04000219 RID: 537
		private string _template;

		// Token: 0x0400021A RID: 538
		private int _length;

		// Token: 0x0400021B RID: 539
		private int _position;

		// Token: 0x0400021C RID: 540
		private int _literalLength;

		// Token: 0x0400021D RID: 541
		private global::NLog.MessageTemplates.LiteralHole _current;

		// Token: 0x0400021E RID: 542
		private const short Zero = 0;
	}
}
