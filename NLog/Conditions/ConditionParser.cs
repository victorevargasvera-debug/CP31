using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using NLog.Common;
using NLog.Config;
using NLog.Internal;
using NLog.Layouts;

namespace NLog.Conditions
{
	// Token: 0x02000184 RID: 388
	public class ConditionParser
	{
		// Token: 0x0600108B RID: 4235 RVA: 0x0002B929 File Offset: 0x00029B29
		private ConditionParser(global::NLog.Internal.SimpleStringReader stringReader, global::NLog.Config.ConfigurationItemFactory configurationItemFactory)
		{
			this._configurationItemFactory = configurationItemFactory;
			this._tokenizer = new global::NLog.Conditions.ConditionTokenizer(stringReader);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0002B944 File Offset: 0x00029B44
		public static global::NLog.Conditions.ConditionExpression ParseExpression(string expressionText)
		{
			return global::NLog.Conditions.ConditionParser.ParseExpression(expressionText, global::NLog.Config.ConfigurationItemFactory.Default);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x0002B954 File Offset: 0x00029B54
		public static global::NLog.Conditions.ConditionExpression ParseExpression(string expressionText, global::NLog.Config.ConfigurationItemFactory configurationItemFactories)
		{
			if (expressionText == null)
			{
				return null;
			}
			global::NLog.Conditions.ConditionParser conditionParser = new global::NLog.Conditions.ConditionParser(new global::NLog.Internal.SimpleStringReader(expressionText), configurationItemFactories);
			global::NLog.Conditions.ConditionExpression result = conditionParser.ParseExpression();
			if (!conditionParser._tokenizer.IsEOF())
			{
				throw new global::NLog.Conditions.ConditionParseException(string.Format("Unexpected token: {0}", conditionParser._tokenizer.TokenValue));
			}
			return result;
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x0002B9A1 File Offset: 0x00029BA1
		internal static global::NLog.Conditions.ConditionExpression ParseExpression(global::NLog.Internal.SimpleStringReader stringReader, global::NLog.Config.ConfigurationItemFactory configurationItemFactories)
		{
			return new global::NLog.Conditions.ConditionParser(stringReader, configurationItemFactories).ParseExpression();
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x0002B9B0 File Offset: 0x00029BB0
		private global::NLog.Conditions.ConditionMethodExpression ParsePredicate(string functionName)
		{
			global::System.Collections.Generic.List<global::NLog.Conditions.ConditionExpression> list = new global::System.Collections.Generic.List<global::NLog.Conditions.ConditionExpression>();
			while (!this._tokenizer.IsEOF() && this._tokenizer.TokenType != global::NLog.Conditions.ConditionTokenType.RightParen)
			{
				list.Add(this.ParseExpression());
				if (this._tokenizer.TokenType != global::NLog.Conditions.ConditionTokenType.Comma)
				{
					break;
				}
				this._tokenizer.GetNextToken();
			}
			this._tokenizer.Expect(global::NLog.Conditions.ConditionTokenType.RightParen);
			global::NLog.Conditions.ConditionMethodExpression result;
			try
			{
				global::System.Reflection.MethodInfo methodInfo = this._configurationItemFactory.ConditionMethods.CreateInstance(functionName);
				result = new global::NLog.Conditions.ConditionMethodExpression(functionName, methodInfo, list);
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "Cannot resolve function '{0}'", new object[]
				{
					functionName
				});
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
				throw new global::NLog.Conditions.ConditionParseException(string.Format("Cannot resolve function '{0}'", functionName), ex);
			}
			return result;
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x0002BA74 File Offset: 0x00029C74
		private global::NLog.Conditions.ConditionExpression ParseLiteralExpression()
		{
			if (this._tokenizer.IsToken(global::NLog.Conditions.ConditionTokenType.LeftParen))
			{
				this._tokenizer.GetNextToken();
				global::NLog.Conditions.ConditionExpression result = this.ParseExpression();
				this._tokenizer.Expect(global::NLog.Conditions.ConditionTokenType.RightParen);
				return result;
			}
			if (this._tokenizer.IsToken(global::NLog.Conditions.ConditionTokenType.Minus))
			{
				this._tokenizer.GetNextToken();
				if (!this._tokenizer.IsNumber())
				{
					throw new global::NLog.Conditions.ConditionParseException(string.Format("Number expected, got {0}", this._tokenizer.TokenType));
				}
				return this.ParseNumber(true);
			}
			else
			{
				if (this._tokenizer.IsNumber())
				{
					return this.ParseNumber(false);
				}
				if (this._tokenizer.TokenType == global::NLog.Conditions.ConditionTokenType.String)
				{
					global::NLog.Conditions.ConditionExpression result2 = new global::NLog.Conditions.ConditionLayoutExpression(global::NLog.Layouts.Layout.FromString(this._tokenizer.StringTokenValue, this._configurationItemFactory));
					this._tokenizer.GetNextToken();
					return result2;
				}
				if (this._tokenizer.TokenType == global::NLog.Conditions.ConditionTokenType.Keyword)
				{
					string text = this._tokenizer.EatKeyword();
					global::NLog.Conditions.ConditionExpression result3;
					if (this.TryPlainKeywordToExpression(text, out result3))
					{
						return result3;
					}
					if (this._tokenizer.TokenType == global::NLog.Conditions.ConditionTokenType.LeftParen)
					{
						this._tokenizer.GetNextToken();
						return this.ParsePredicate(text);
					}
				}
				throw new global::NLog.Conditions.ConditionParseException("Unexpected token: " + this._tokenizer.TokenValue);
			}
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0002BBAC File Offset: 0x00029DAC
		private bool TryPlainKeywordToExpression(string keyword, out global::NLog.Conditions.ConditionExpression expression)
		{
			if (string.Compare(keyword, "level", global::System.StringComparison.OrdinalIgnoreCase) == 0)
			{
				expression = new global::NLog.Conditions.ConditionLevelExpression();
				return true;
			}
			if (string.Compare(keyword, "logger", global::System.StringComparison.OrdinalIgnoreCase) == 0)
			{
				expression = new global::NLog.Conditions.ConditionLoggerNameExpression();
				return true;
			}
			if (string.Compare(keyword, "message", global::System.StringComparison.OrdinalIgnoreCase) == 0)
			{
				expression = new global::NLog.Conditions.ConditionMessageExpression();
				return true;
			}
			if (string.Compare(keyword, "loglevel", global::System.StringComparison.OrdinalIgnoreCase) == 0)
			{
				this._tokenizer.Expect(global::NLog.Conditions.ConditionTokenType.Dot);
				expression = new global::NLog.Conditions.ConditionLiteralExpression(global::NLog.LogLevel.FromString(this._tokenizer.EatKeyword()));
				return true;
			}
			if (string.Compare(keyword, "true", global::System.StringComparison.OrdinalIgnoreCase) == 0)
			{
				expression = new global::NLog.Conditions.ConditionLiteralExpression(true);
				return true;
			}
			if (string.Compare(keyword, "false", global::System.StringComparison.OrdinalIgnoreCase) == 0)
			{
				expression = new global::NLog.Conditions.ConditionLiteralExpression(false);
				return true;
			}
			if (string.Compare(keyword, "null", global::System.StringComparison.OrdinalIgnoreCase) == 0)
			{
				expression = new global::NLog.Conditions.ConditionLiteralExpression(null);
				return true;
			}
			expression = null;
			return false;
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x0002BC88 File Offset: 0x00029E88
		private global::NLog.Conditions.ConditionExpression ParseNumber(bool negative)
		{
			string tokenValue = this._tokenizer.TokenValue;
			this._tokenizer.GetNextToken();
			if (tokenValue.IndexOf('.') >= 0)
			{
				double num = double.Parse(tokenValue, global::System.Globalization.CultureInfo.InvariantCulture);
				return new global::NLog.Conditions.ConditionLiteralExpression(negative ? (-num) : num);
			}
			int num2 = int.Parse(tokenValue, global::System.Globalization.CultureInfo.InvariantCulture);
			return new global::NLog.Conditions.ConditionLiteralExpression(negative ? (-num2) : num2);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x0002BCF4 File Offset: 0x00029EF4
		private global::NLog.Conditions.ConditionExpression ParseBooleanRelation()
		{
			global::NLog.Conditions.ConditionExpression conditionExpression = this.ParseLiteralExpression();
			if (this._tokenizer.IsToken(global::NLog.Conditions.ConditionTokenType.EqualTo))
			{
				this._tokenizer.GetNextToken();
				return new global::NLog.Conditions.ConditionRelationalExpression(conditionExpression, this.ParseLiteralExpression(), global::NLog.Conditions.ConditionRelationalOperator.Equal);
			}
			if (this._tokenizer.IsToken(global::NLog.Conditions.ConditionTokenType.NotEqual))
			{
				this._tokenizer.GetNextToken();
				return new global::NLog.Conditions.ConditionRelationalExpression(conditionExpression, this.ParseLiteralExpression(), global::NLog.Conditions.ConditionRelationalOperator.NotEqual);
			}
			if (this._tokenizer.IsToken(global::NLog.Conditions.ConditionTokenType.LessThan))
			{
				this._tokenizer.GetNextToken();
				return new global::NLog.Conditions.ConditionRelationalExpression(conditionExpression, this.ParseLiteralExpression(), global::NLog.Conditions.ConditionRelationalOperator.Less);
			}
			if (this._tokenizer.IsToken(global::NLog.Conditions.ConditionTokenType.GreaterThan))
			{
				this._tokenizer.GetNextToken();
				return new global::NLog.Conditions.ConditionRelationalExpression(conditionExpression, this.ParseLiteralExpression(), global::NLog.Conditions.ConditionRelationalOperator.Greater);
			}
			if (this._tokenizer.IsToken(global::NLog.Conditions.ConditionTokenType.LessThanOrEqualTo))
			{
				this._tokenizer.GetNextToken();
				return new global::NLog.Conditions.ConditionRelationalExpression(conditionExpression, this.ParseLiteralExpression(), global::NLog.Conditions.ConditionRelationalOperator.LessOrEqual);
			}
			if (this._tokenizer.IsToken(global::NLog.Conditions.ConditionTokenType.GreaterThanOrEqualTo))
			{
				this._tokenizer.GetNextToken();
				return new global::NLog.Conditions.ConditionRelationalExpression(conditionExpression, this.ParseLiteralExpression(), global::NLog.Conditions.ConditionRelationalOperator.GreaterOrEqual);
			}
			return conditionExpression;
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x0002BDF7 File Offset: 0x00029FF7
		private global::NLog.Conditions.ConditionExpression ParseBooleanPredicate()
		{
			if (this._tokenizer.IsKeyword("not") || this._tokenizer.IsToken(global::NLog.Conditions.ConditionTokenType.Not))
			{
				this._tokenizer.GetNextToken();
				return new global::NLog.Conditions.ConditionNotExpression(this.ParseBooleanPredicate());
			}
			return this.ParseBooleanRelation();
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0002BE38 File Offset: 0x0002A038
		private global::NLog.Conditions.ConditionExpression ParseBooleanAnd()
		{
			global::NLog.Conditions.ConditionExpression conditionExpression = this.ParseBooleanPredicate();
			while (this._tokenizer.IsKeyword("and") || this._tokenizer.IsToken(global::NLog.Conditions.ConditionTokenType.And))
			{
				this._tokenizer.GetNextToken();
				conditionExpression = new global::NLog.Conditions.ConditionAndExpression(conditionExpression, this.ParseBooleanPredicate());
			}
			return conditionExpression;
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x0002BE88 File Offset: 0x0002A088
		private global::NLog.Conditions.ConditionExpression ParseBooleanOr()
		{
			global::NLog.Conditions.ConditionExpression conditionExpression = this.ParseBooleanAnd();
			while (this._tokenizer.IsKeyword("or") || this._tokenizer.IsToken(global::NLog.Conditions.ConditionTokenType.Or))
			{
				this._tokenizer.GetNextToken();
				conditionExpression = new global::NLog.Conditions.ConditionOrExpression(conditionExpression, this.ParseBooleanAnd());
			}
			return conditionExpression;
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x0002BED8 File Offset: 0x0002A0D8
		private global::NLog.Conditions.ConditionExpression ParseBooleanExpression()
		{
			return this.ParseBooleanOr();
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x0002BEE0 File Offset: 0x0002A0E0
		private global::NLog.Conditions.ConditionExpression ParseExpression()
		{
			return this.ParseBooleanExpression();
		}

		// Token: 0x0400048B RID: 1163
		private readonly global::NLog.Conditions.ConditionTokenizer _tokenizer;

		// Token: 0x0400048C RID: 1164
		private readonly global::NLog.Config.ConfigurationItemFactory _configurationItemFactory;
	}
}
