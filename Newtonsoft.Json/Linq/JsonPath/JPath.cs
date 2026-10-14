using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D3 RID: 211
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class JPath
	{
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000BEF RID: 3055 RVA: 0x0002F116 File Offset: 0x0002D316
		public global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.PathFilter> Filters { get; }

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0002F11E File Offset: 0x0002D31E
		public JPath(string expression)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(expression, "expression");
			this._expression = expression;
			this.Filters = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.PathFilter>();
			this.ParseMain();
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x0002F14C File Offset: 0x0002D34C
		private void ParseMain()
		{
			int currentIndex = this._currentIndex;
			this.EatWhitespace();
			if (this._expression.Length == this._currentIndex)
			{
				return;
			}
			if (this._expression[this._currentIndex] == '$')
			{
				if (this._expression.Length == 1)
				{
					return;
				}
				char c = this._expression[this._currentIndex + 1];
				if (c == '.' || c == '[')
				{
					this._currentIndex++;
					currentIndex = this._currentIndex;
				}
			}
			if (!this.ParsePath(this.Filters, currentIndex, false))
			{
				int currentIndex2 = this._currentIndex;
				this.EatWhitespace();
				if (this._currentIndex < this._expression.Length)
				{
					throw new global::Newtonsoft.Json.JsonException("Unexpected character while parsing path: " + this._expression[currentIndex2].ToString());
				}
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0002F228 File Offset: 0x0002D428
		private bool ParsePath(global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.PathFilter> filters, int currentPartStartIndex, bool query)
		{
			bool scan = false;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			while (this._currentIndex < this._expression.Length && !flag3)
			{
				char c = this._expression[this._currentIndex];
				if (c <= ')')
				{
					if (c != ' ')
					{
						if (c != '(')
						{
							if (c != ')')
							{
								goto IL_189;
							}
							goto IL_CD;
						}
					}
					else
					{
						if (this._currentIndex < this._expression.Length)
						{
							flag3 = true;
							continue;
						}
						continue;
					}
				}
				else
				{
					if (c == '.')
					{
						if (this._currentIndex > currentPartStartIndex)
						{
							string text = this._expression.Substring(currentPartStartIndex, this._currentIndex - currentPartStartIndex);
							if (text == "*")
							{
								text = null;
							}
							filters.Add(global::Newtonsoft.Json.Linq.JsonPath.JPath.CreatePathFilter(text, scan));
							scan = false;
						}
						if (this._currentIndex + 1 < this._expression.Length && this._expression[this._currentIndex + 1] == '.')
						{
							scan = true;
							this._currentIndex++;
						}
						this._currentIndex++;
						currentPartStartIndex = this._currentIndex;
						flag = false;
						flag2 = true;
						continue;
					}
					if (c != '[')
					{
						if (c != ']')
						{
							goto IL_189;
						}
						goto IL_CD;
					}
				}
				if (this._currentIndex > currentPartStartIndex)
				{
					string text2 = this._expression.Substring(currentPartStartIndex, this._currentIndex - currentPartStartIndex);
					if (text2 == "*")
					{
						text2 = null;
					}
					filters.Add(global::Newtonsoft.Json.Linq.JsonPath.JPath.CreatePathFilter(text2, scan));
					scan = false;
				}
				filters.Add(this.ParseIndexer(c, scan));
				scan = false;
				this._currentIndex++;
				currentPartStartIndex = this._currentIndex;
				flag = true;
				flag2 = false;
				continue;
				IL_CD:
				flag3 = true;
				continue;
				IL_189:
				if (query && (c == '=' || c == '<' || c == '!' || c == '>' || c == '|' || c == '&'))
				{
					flag3 = true;
				}
				else
				{
					if (flag)
					{
						throw new global::Newtonsoft.Json.JsonException("Unexpected character following indexer: " + c.ToString());
					}
					this._currentIndex++;
				}
			}
			bool flag4 = this._currentIndex == this._expression.Length;
			if (this._currentIndex > currentPartStartIndex)
			{
				string text3 = this._expression.Substring(currentPartStartIndex, this._currentIndex - currentPartStartIndex).TrimEnd(new char[0]);
				if (text3 == "*")
				{
					text3 = null;
				}
				filters.Add(global::Newtonsoft.Json.Linq.JsonPath.JPath.CreatePathFilter(text3, scan));
			}
			else if (flag2 && (flag4 || query))
			{
				throw new global::Newtonsoft.Json.JsonException("Unexpected end while parsing path.");
			}
			return flag4;
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0002F4A0 File Offset: 0x0002D6A0
		private static global::Newtonsoft.Json.Linq.JsonPath.PathFilter CreatePathFilter([global::System.Runtime.CompilerServices.Nullable(2)] string member, bool scan)
		{
			if (!scan)
			{
				return new global::Newtonsoft.Json.Linq.JsonPath.FieldFilter(member);
			}
			return new global::Newtonsoft.Json.Linq.JsonPath.ScanFilter(member);
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0002F4B4 File Offset: 0x0002D6B4
		private global::Newtonsoft.Json.Linq.JsonPath.PathFilter ParseIndexer(char indexerOpenChar, bool scan)
		{
			this._currentIndex++;
			char indexerCloseChar = (indexerOpenChar == '[') ? ']' : ')';
			this.EnsureLength("Path ended with open indexer.");
			this.EatWhitespace();
			if (this._expression[this._currentIndex] == '\'')
			{
				return this.ParseQuotedField(indexerCloseChar, scan);
			}
			if (this._expression[this._currentIndex] == '?')
			{
				return this.ParseQuery(indexerCloseChar, scan);
			}
			return this.ParseArrayIndexer(indexerCloseChar);
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0002F530 File Offset: 0x0002D730
		private global::Newtonsoft.Json.Linq.JsonPath.PathFilter ParseArrayIndexer(char indexerCloseChar)
		{
			int currentIndex = this._currentIndex;
			int? num = null;
			global::System.Collections.Generic.List<int> list = null;
			int num2 = 0;
			int? start = null;
			int? end = null;
			int? step = null;
			while (this._currentIndex < this._expression.Length)
			{
				char c = this._expression[this._currentIndex];
				if (c == ' ')
				{
					num = new int?(this._currentIndex);
					this.EatWhitespace();
				}
				else if (c == indexerCloseChar)
				{
					int num3 = (num ?? this._currentIndex) - currentIndex;
					if (list != null)
					{
						if (num3 == 0)
						{
							throw new global::Newtonsoft.Json.JsonException("Array index expected.");
						}
						int item = global::System.Convert.ToInt32(this._expression.Substring(currentIndex, num3), global::System.Globalization.CultureInfo.InvariantCulture);
						list.Add(item);
						return new global::Newtonsoft.Json.Linq.JsonPath.ArrayMultipleIndexFilter(list);
					}
					else
					{
						if (num2 > 0)
						{
							if (num3 > 0)
							{
								int value = global::System.Convert.ToInt32(this._expression.Substring(currentIndex, num3), global::System.Globalization.CultureInfo.InvariantCulture);
								if (num2 == 1)
								{
									end = new int?(value);
								}
								else
								{
									step = new int?(value);
								}
							}
							return new global::Newtonsoft.Json.Linq.JsonPath.ArraySliceFilter
							{
								Start = start,
								End = end,
								Step = step
							};
						}
						if (num3 == 0)
						{
							throw new global::Newtonsoft.Json.JsonException("Array index expected.");
						}
						int value2 = global::System.Convert.ToInt32(this._expression.Substring(currentIndex, num3), global::System.Globalization.CultureInfo.InvariantCulture);
						return new global::Newtonsoft.Json.Linq.JsonPath.ArrayIndexFilter
						{
							Index = new int?(value2)
						};
					}
				}
				else if (c == ',')
				{
					int num4 = (num ?? this._currentIndex) - currentIndex;
					if (num4 == 0)
					{
						throw new global::Newtonsoft.Json.JsonException("Array index expected.");
					}
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<int>();
					}
					string value3 = this._expression.Substring(currentIndex, num4);
					list.Add(global::System.Convert.ToInt32(value3, global::System.Globalization.CultureInfo.InvariantCulture));
					this._currentIndex++;
					this.EatWhitespace();
					currentIndex = this._currentIndex;
					num = null;
				}
				else if (c == '*')
				{
					this._currentIndex++;
					this.EnsureLength("Path ended with open indexer.");
					this.EatWhitespace();
					if (this._expression[this._currentIndex] != indexerCloseChar)
					{
						throw new global::Newtonsoft.Json.JsonException("Unexpected character while parsing path indexer: " + c.ToString());
					}
					return new global::Newtonsoft.Json.Linq.JsonPath.ArrayIndexFilter();
				}
				else if (c == ':')
				{
					int num5 = (num ?? this._currentIndex) - currentIndex;
					if (num5 > 0)
					{
						int value4 = global::System.Convert.ToInt32(this._expression.Substring(currentIndex, num5), global::System.Globalization.CultureInfo.InvariantCulture);
						if (num2 == 0)
						{
							start = new int?(value4);
						}
						else if (num2 == 1)
						{
							end = new int?(value4);
						}
						else
						{
							step = new int?(value4);
						}
					}
					num2++;
					this._currentIndex++;
					this.EatWhitespace();
					currentIndex = this._currentIndex;
					num = null;
				}
				else
				{
					if (!char.IsDigit(c) && c != '-')
					{
						throw new global::Newtonsoft.Json.JsonException("Unexpected character while parsing path indexer: " + c.ToString());
					}
					if (num != null)
					{
						throw new global::Newtonsoft.Json.JsonException("Unexpected character while parsing path indexer: " + c.ToString());
					}
					this._currentIndex++;
				}
			}
			throw new global::Newtonsoft.Json.JsonException("Path ended with open indexer.");
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x0002F87F File Offset: 0x0002DA7F
		private void EatWhitespace()
		{
			while (this._currentIndex < this._expression.Length && this._expression[this._currentIndex] == ' ')
			{
				this._currentIndex++;
			}
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x0002F8BC File Offset: 0x0002DABC
		private global::Newtonsoft.Json.Linq.JsonPath.PathFilter ParseQuery(char indexerCloseChar, bool scan)
		{
			this._currentIndex++;
			this.EnsureLength("Path ended with open indexer.");
			if (this._expression[this._currentIndex] != '(')
			{
				throw new global::Newtonsoft.Json.JsonException("Unexpected character while parsing path indexer: " + this._expression[this._currentIndex].ToString());
			}
			this._currentIndex++;
			global::Newtonsoft.Json.Linq.JsonPath.QueryExpression expression = this.ParseExpression();
			this._currentIndex++;
			this.EnsureLength("Path ended with open indexer.");
			this.EatWhitespace();
			if (this._expression[this._currentIndex] != indexerCloseChar)
			{
				throw new global::Newtonsoft.Json.JsonException("Unexpected character while parsing path indexer: " + this._expression[this._currentIndex].ToString());
			}
			if (!scan)
			{
				return new global::Newtonsoft.Json.Linq.JsonPath.QueryFilter(expression);
			}
			return new global::Newtonsoft.Json.Linq.JsonPath.QueryScanFilter(expression);
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x0002F9A4 File Offset: 0x0002DBA4
		private bool TryParseExpression([global::System.Runtime.CompilerServices.Nullable(new byte[]
		{
			2,
			1
		})] out global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.PathFilter> expressionPath)
		{
			if (this._expression[this._currentIndex] == '$')
			{
				expressionPath = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.PathFilter>
				{
					global::Newtonsoft.Json.Linq.JsonPath.RootFilter.Instance
				};
			}
			else
			{
				if (this._expression[this._currentIndex] != '@')
				{
					expressionPath = null;
					return false;
				}
				expressionPath = new global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.PathFilter>();
			}
			this._currentIndex++;
			if (this.ParsePath(expressionPath, this._currentIndex, true))
			{
				throw new global::Newtonsoft.Json.JsonException("Path ended with open query.");
			}
			return true;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x0002FA28 File Offset: 0x0002DC28
		private global::Newtonsoft.Json.JsonException CreateUnexpectedCharacterException()
		{
			return new global::Newtonsoft.Json.JsonException("Unexpected character while parsing path query: " + this._expression[this._currentIndex].ToString());
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x0002FA60 File Offset: 0x0002DC60
		private object ParseSide()
		{
			this.EatWhitespace();
			global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.PathFilter> result;
			if (this.TryParseExpression(out result))
			{
				this.EatWhitespace();
				this.EnsureLength("Path ended with open query.");
				return result;
			}
			object value;
			if (this.TryParseValue(out value))
			{
				this.EatWhitespace();
				this.EnsureLength("Path ended with open query.");
				return new global::Newtonsoft.Json.Linq.JValue(value);
			}
			throw this.CreateUnexpectedCharacterException();
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x0002FAB8 File Offset: 0x0002DCB8
		private global::Newtonsoft.Json.Linq.JsonPath.QueryExpression ParseExpression()
		{
			global::Newtonsoft.Json.Linq.JsonPath.QueryExpression queryExpression = null;
			global::Newtonsoft.Json.Linq.JsonPath.CompositeExpression compositeExpression = null;
			while (this._currentIndex < this._expression.Length)
			{
				object left = this.ParseSide();
				object right = null;
				global::Newtonsoft.Json.Linq.JsonPath.QueryOperator @operator;
				if (this._expression[this._currentIndex] == ')' || this._expression[this._currentIndex] == '|' || this._expression[this._currentIndex] == '&')
				{
					@operator = global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.Exists;
				}
				else
				{
					@operator = this.ParseOperator();
					right = this.ParseSide();
				}
				global::Newtonsoft.Json.Linq.JsonPath.BooleanQueryExpression booleanQueryExpression = new global::Newtonsoft.Json.Linq.JsonPath.BooleanQueryExpression(@operator, left, right);
				if (this._expression[this._currentIndex] == ')')
				{
					if (compositeExpression != null)
					{
						compositeExpression.Expressions.Add(booleanQueryExpression);
						return queryExpression;
					}
					return booleanQueryExpression;
				}
				else
				{
					if (this._expression[this._currentIndex] == '&')
					{
						if (!this.Match("&&"))
						{
							throw this.CreateUnexpectedCharacterException();
						}
						if (compositeExpression == null || compositeExpression.Operator != global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.And)
						{
							global::Newtonsoft.Json.Linq.JsonPath.CompositeExpression compositeExpression2 = new global::Newtonsoft.Json.Linq.JsonPath.CompositeExpression(global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.And);
							if (compositeExpression != null)
							{
								compositeExpression.Expressions.Add(compositeExpression2);
							}
							compositeExpression = compositeExpression2;
							if (queryExpression == null)
							{
								queryExpression = compositeExpression;
							}
						}
						compositeExpression.Expressions.Add(booleanQueryExpression);
					}
					if (this._expression[this._currentIndex] == '|')
					{
						if (!this.Match("||"))
						{
							throw this.CreateUnexpectedCharacterException();
						}
						if (compositeExpression == null || compositeExpression.Operator != global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.Or)
						{
							global::Newtonsoft.Json.Linq.JsonPath.CompositeExpression compositeExpression3 = new global::Newtonsoft.Json.Linq.JsonPath.CompositeExpression(global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.Or);
							if (compositeExpression != null)
							{
								compositeExpression.Expressions.Add(compositeExpression3);
							}
							compositeExpression = compositeExpression3;
							if (queryExpression == null)
							{
								queryExpression = compositeExpression;
							}
						}
						compositeExpression.Expressions.Add(booleanQueryExpression);
					}
				}
			}
			throw new global::Newtonsoft.Json.JsonException("Path ended with open query.");
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x0002FC48 File Offset: 0x0002DE48
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		private bool TryParseValue(out object value)
		{
			char c = this._expression[this._currentIndex];
			if (c == '\'')
			{
				value = this.ReadQuotedString();
				return true;
			}
			if (char.IsDigit(c) || c == '-')
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append(c);
				this._currentIndex++;
				while (this._currentIndex < this._expression.Length)
				{
					c = this._expression[this._currentIndex];
					if (c == ' ' || c == ')')
					{
						string text = stringBuilder.ToString();
						if (text.IndexOfAny(global::Newtonsoft.Json.Linq.JsonPath.JPath.FloatCharacters) != -1)
						{
							double num;
							bool result = double.TryParse(text, global::System.Globalization.NumberStyles.AllowLeadingWhite | global::System.Globalization.NumberStyles.AllowTrailingWhite | global::System.Globalization.NumberStyles.AllowLeadingSign | global::System.Globalization.NumberStyles.AllowDecimalPoint | global::System.Globalization.NumberStyles.AllowThousands | global::System.Globalization.NumberStyles.AllowExponent, global::System.Globalization.CultureInfo.InvariantCulture, out num);
							value = num;
							return result;
						}
						long num2;
						bool result2 = long.TryParse(text, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out num2);
						value = num2;
						return result2;
					}
					else
					{
						stringBuilder.Append(c);
						this._currentIndex++;
					}
				}
			}
			else if (c == 't')
			{
				if (this.Match("true"))
				{
					value = true;
					return true;
				}
			}
			else if (c == 'f')
			{
				if (this.Match("false"))
				{
					value = false;
					return true;
				}
			}
			else if (c == 'n')
			{
				if (this.Match("null"))
				{
					value = null;
					return true;
				}
			}
			else if (c == '/')
			{
				value = this.ReadRegexString();
				return true;
			}
			value = null;
			return false;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0002FD98 File Offset: 0x0002DF98
		private string ReadQuotedString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			this._currentIndex++;
			while (this._currentIndex < this._expression.Length)
			{
				char c = this._expression[this._currentIndex];
				if (c == '\\' && this._currentIndex + 1 < this._expression.Length)
				{
					this._currentIndex++;
					c = this._expression[this._currentIndex];
					char value;
					if (c <= '\\')
					{
						if (c <= '\'')
						{
							if (c != '"' && c != '\'')
							{
								goto IL_CB;
							}
						}
						else if (c != '/' && c != '\\')
						{
							goto IL_CB;
						}
						value = c;
					}
					else if (c <= 'f')
					{
						if (c != 'b')
						{
							if (c != 'f')
							{
								goto IL_CB;
							}
							value = '\f';
						}
						else
						{
							value = '\b';
						}
					}
					else if (c != 'n')
					{
						if (c != 'r')
						{
							if (c != 't')
							{
								goto IL_CB;
							}
							value = '\t';
						}
						else
						{
							value = '\r';
						}
					}
					else
					{
						value = '\n';
					}
					stringBuilder.Append(value);
					this._currentIndex++;
					continue;
					IL_CB:
					throw new global::Newtonsoft.Json.JsonException("Unknown escape character: \\" + c.ToString());
				}
				if (c == '\'')
				{
					this._currentIndex++;
					return stringBuilder.ToString();
				}
				this._currentIndex++;
				stringBuilder.Append(c);
			}
			throw new global::Newtonsoft.Json.JsonException("Path ended with an open string.");
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0002FEF0 File Offset: 0x0002E0F0
		private string ReadRegexString()
		{
			int currentIndex = this._currentIndex;
			this._currentIndex++;
			while (this._currentIndex < this._expression.Length)
			{
				char c = this._expression[this._currentIndex];
				if (c == '\\' && this._currentIndex + 1 < this._expression.Length)
				{
					this._currentIndex += 2;
				}
				else
				{
					if (c == '/')
					{
						this._currentIndex++;
						while (this._currentIndex < this._expression.Length)
						{
							c = this._expression[this._currentIndex];
							if (!char.IsLetter(c))
							{
								break;
							}
							this._currentIndex++;
						}
						return this._expression.Substring(currentIndex, this._currentIndex - currentIndex);
					}
					this._currentIndex++;
				}
			}
			throw new global::Newtonsoft.Json.JsonException("Path ended with an open regex.");
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0002FFE8 File Offset: 0x0002E1E8
		private bool Match(string s)
		{
			int num = this._currentIndex;
			for (int i = 0; i < s.Length; i++)
			{
				if (num >= this._expression.Length || this._expression[num] != s[i])
				{
					return false;
				}
				num++;
			}
			this._currentIndex = num;
			return true;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00030040 File Offset: 0x0002E240
		private global::Newtonsoft.Json.Linq.JsonPath.QueryOperator ParseOperator()
		{
			if (this._currentIndex + 1 >= this._expression.Length)
			{
				throw new global::Newtonsoft.Json.JsonException("Path ended with open query.");
			}
			if (this.Match("==="))
			{
				return global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.StrictEquals;
			}
			if (this.Match("=="))
			{
				return global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.Equals;
			}
			if (this.Match("=~"))
			{
				return global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.RegexEquals;
			}
			if (this.Match("!=="))
			{
				return global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.StrictNotEquals;
			}
			if (this.Match("!=") || this.Match("<>"))
			{
				return global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.NotEquals;
			}
			if (this.Match("<="))
			{
				return global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.LessThanOrEquals;
			}
			if (this.Match("<"))
			{
				return global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.LessThan;
			}
			if (this.Match(">="))
			{
				return global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.GreaterThanOrEquals;
			}
			if (this.Match(">"))
			{
				return global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.GreaterThan;
			}
			throw new global::Newtonsoft.Json.JsonException("Could not read query operator.");
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x00030110 File Offset: 0x0002E310
		private global::Newtonsoft.Json.Linq.JsonPath.PathFilter ParseQuotedField(char indexerCloseChar, bool scan)
		{
			global::System.Collections.Generic.List<string> list = null;
			while (this._currentIndex < this._expression.Length)
			{
				string text = this.ReadQuotedString();
				this.EatWhitespace();
				this.EnsureLength("Path ended with open indexer.");
				if (this._expression[this._currentIndex] == indexerCloseChar)
				{
					if (list == null)
					{
						return global::Newtonsoft.Json.Linq.JsonPath.JPath.CreatePathFilter(text, scan);
					}
					list.Add(text);
					if (!scan)
					{
						return new global::Newtonsoft.Json.Linq.JsonPath.FieldMultipleFilter(list);
					}
					return new global::Newtonsoft.Json.Linq.JsonPath.ScanMultipleFilter(list);
				}
				else
				{
					if (this._expression[this._currentIndex] != ',')
					{
						throw new global::Newtonsoft.Json.JsonException("Unexpected character while parsing path indexer: " + this._expression[this._currentIndex].ToString());
					}
					this._currentIndex++;
					this.EatWhitespace();
					if (list == null)
					{
						list = new global::System.Collections.Generic.List<string>();
					}
					list.Add(text);
				}
			}
			throw new global::Newtonsoft.Json.JsonException("Path ended with open indexer.");
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x000301F7 File Offset: 0x0002E3F7
		private void EnsureLength(string message)
		{
			if (this._currentIndex >= this._expression.Length)
			{
				throw new global::Newtonsoft.Json.JsonException(message);
			}
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x00030213 File Offset: 0x0002E413
		internal global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> Evaluate(global::Newtonsoft.Json.Linq.JToken root, global::Newtonsoft.Json.Linq.JToken t, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			return global::Newtonsoft.Json.Linq.JsonPath.JPath.Evaluate(this.Filters, root, t, settings);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x00030224 File Offset: 0x0002E424
		internal static global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> Evaluate(global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.PathFilter> filters, global::Newtonsoft.Json.Linq.JToken root, global::Newtonsoft.Json.Linq.JToken t, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> enumerable = new global::Newtonsoft.Json.Linq.JToken[]
			{
				t
			};
			foreach (global::Newtonsoft.Json.Linq.JsonPath.PathFilter pathFilter in filters)
			{
				enumerable = pathFilter.ExecuteFilter(root, enumerable, settings);
			}
			return enumerable;
		}

		// Token: 0x040003B5 RID: 949
		private static readonly char[] FloatCharacters = new char[]
		{
			'.',
			'E',
			'e'
		};

		// Token: 0x040003B6 RID: 950
		private readonly string _expression;

		// Token: 0x040003B8 RID: 952
		private int _currentIndex;
	}
}
