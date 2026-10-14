using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000D8 RID: 216
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class BooleanQueryExpression : global::Newtonsoft.Json.Linq.JsonPath.QueryExpression
	{
		// Token: 0x06000C11 RID: 3089 RVA: 0x000304BC File Offset: 0x0002E6BC
		public BooleanQueryExpression(global::Newtonsoft.Json.Linq.JsonPath.QueryOperator @operator, object left, [global::System.Runtime.CompilerServices.Nullable(2)] object right) : base(@operator)
		{
			this.Left = left;
			this.Right = right;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000304D4 File Offset: 0x0002E6D4
		private global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> GetResult(global::Newtonsoft.Json.Linq.JToken root, global::Newtonsoft.Json.Linq.JToken t, [global::System.Runtime.CompilerServices.Nullable(2)] object o)
		{
			global::Newtonsoft.Json.Linq.JToken jtoken = o as global::Newtonsoft.Json.Linq.JToken;
			if (jtoken != null)
			{
				return new global::Newtonsoft.Json.Linq.JToken[]
				{
					jtoken
				};
			}
			global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.PathFilter> list = o as global::System.Collections.Generic.List<global::Newtonsoft.Json.Linq.JsonPath.PathFilter>;
			if (list != null)
			{
				return global::Newtonsoft.Json.Linq.JsonPath.JPath.Evaluate(list, root, t, null);
			}
			return global::Newtonsoft.Json.Utilities.CollectionUtils.ArrayEmpty<global::Newtonsoft.Json.Linq.JToken>();
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x00030510 File Offset: 0x0002E710
		public override bool IsMatch(global::Newtonsoft.Json.Linq.JToken root, global::Newtonsoft.Json.Linq.JToken t, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			if (this.Operator == global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.Exists)
			{
				return this.GetResult(root, t, this.Left).Any<global::Newtonsoft.Json.Linq.JToken>();
			}
			using (global::System.Collections.Generic.IEnumerator<global::Newtonsoft.Json.Linq.JToken> enumerator = this.GetResult(root, t, this.Left).GetEnumerator())
			{
				if (enumerator.MoveNext())
				{
					global::System.Collections.Generic.IEnumerable<global::Newtonsoft.Json.Linq.JToken> result = this.GetResult(root, t, this.Right);
					global::System.Collections.Generic.ICollection<global::Newtonsoft.Json.Linq.JToken> collection = (result as global::System.Collections.Generic.ICollection<global::Newtonsoft.Json.Linq.JToken>) ?? result.ToList<global::Newtonsoft.Json.Linq.JToken>();
					do
					{
						global::Newtonsoft.Json.Linq.JToken leftResult = enumerator.Current;
						foreach (global::Newtonsoft.Json.Linq.JToken rightResult in collection)
						{
							if (this.MatchTokens(leftResult, rightResult, settings))
							{
								return true;
							}
						}
					}
					while (enumerator.MoveNext());
				}
			}
			return false;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x000305EC File Offset: 0x0002E7EC
		private bool MatchTokens(global::Newtonsoft.Json.Linq.JToken leftResult, global::Newtonsoft.Json.Linq.JToken rightResult, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			global::Newtonsoft.Json.Linq.JValue jvalue = leftResult as global::Newtonsoft.Json.Linq.JValue;
			if (jvalue != null)
			{
				global::Newtonsoft.Json.Linq.JValue jvalue2 = rightResult as global::Newtonsoft.Json.Linq.JValue;
				if (jvalue2 != null)
				{
					switch (this.Operator)
					{
					case global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.Equals:
						if (global::Newtonsoft.Json.Linq.JsonPath.BooleanQueryExpression.EqualsWithStringCoercion(jvalue, jvalue2))
						{
							return true;
						}
						return false;
					case global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.NotEquals:
						if (!global::Newtonsoft.Json.Linq.JsonPath.BooleanQueryExpression.EqualsWithStringCoercion(jvalue, jvalue2))
						{
							return true;
						}
						return false;
					case global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.Exists:
						return true;
					case global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.LessThan:
						if (jvalue.CompareTo(jvalue2) < 0)
						{
							return true;
						}
						return false;
					case global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.LessThanOrEquals:
						if (jvalue.CompareTo(jvalue2) <= 0)
						{
							return true;
						}
						return false;
					case global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.GreaterThan:
						if (jvalue.CompareTo(jvalue2) > 0)
						{
							return true;
						}
						return false;
					case global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.GreaterThanOrEquals:
						if (jvalue.CompareTo(jvalue2) >= 0)
						{
							return true;
						}
						return false;
					case global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.And:
					case global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.Or:
						return false;
					case global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.RegexEquals:
						if (global::Newtonsoft.Json.Linq.JsonPath.BooleanQueryExpression.RegexEquals(jvalue, jvalue2, settings))
						{
							return true;
						}
						return false;
					case global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.StrictEquals:
						if (global::Newtonsoft.Json.Linq.JsonPath.BooleanQueryExpression.EqualsWithStrictMatch(jvalue, jvalue2))
						{
							return true;
						}
						return false;
					case global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.StrictNotEquals:
						if (!global::Newtonsoft.Json.Linq.JsonPath.BooleanQueryExpression.EqualsWithStrictMatch(jvalue, jvalue2))
						{
							return true;
						}
						return false;
					default:
						return false;
					}
				}
			}
			global::Newtonsoft.Json.Linq.JsonPath.QueryOperator @operator = this.Operator;
			if (@operator - global::Newtonsoft.Json.Linq.JsonPath.QueryOperator.NotEquals <= 1)
			{
				return true;
			}
			return false;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x000306D0 File Offset: 0x0002E8D0
		private static bool RegexEquals(global::Newtonsoft.Json.Linq.JValue input, global::Newtonsoft.Json.Linq.JValue pattern, [global::System.Runtime.CompilerServices.Nullable(2)] global::Newtonsoft.Json.Linq.JsonSelectSettings settings)
		{
			if (input.Type != global::Newtonsoft.Json.Linq.JTokenType.String || pattern.Type != global::Newtonsoft.Json.Linq.JTokenType.String)
			{
				return false;
			}
			string text = (string)pattern.Value;
			int num = text.LastIndexOf('/');
			string pattern2 = text.Substring(1, num - 1);
			string optionsText = text.Substring(num + 1);
			global::System.TimeSpan matchTimeout = ((settings != null) ? settings.RegexMatchTimeout : null) ?? global::System.Text.RegularExpressions.Regex.InfiniteMatchTimeout;
			return global::System.Text.RegularExpressions.Regex.IsMatch((string)input.Value, pattern2, global::Newtonsoft.Json.Utilities.MiscellaneousUtils.GetRegexOptions(optionsText), matchTimeout);
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x00030760 File Offset: 0x0002E960
		internal static bool EqualsWithStringCoercion(global::Newtonsoft.Json.Linq.JValue value, global::Newtonsoft.Json.Linq.JValue queryValue)
		{
			if (value.Equals(queryValue))
			{
				return true;
			}
			if ((value.Type == global::Newtonsoft.Json.Linq.JTokenType.Integer && queryValue.Type == global::Newtonsoft.Json.Linq.JTokenType.Float) || (value.Type == global::Newtonsoft.Json.Linq.JTokenType.Float && queryValue.Type == global::Newtonsoft.Json.Linq.JTokenType.Integer))
			{
				return global::Newtonsoft.Json.Linq.JValue.Compare(value.Type, value.Value, queryValue.Value) == 0;
			}
			if (queryValue.Type != global::Newtonsoft.Json.Linq.JTokenType.String)
			{
				return false;
			}
			string b = (string)queryValue.Value;
			string a;
			switch (value.Type)
			{
			case global::Newtonsoft.Json.Linq.JTokenType.Date:
				using (global::System.IO.StringWriter stringWriter = global::Newtonsoft.Json.Utilities.StringUtils.CreateStringWriter(64))
				{
					object value2 = value.Value;
					if (value2 is global::System.DateTimeOffset)
					{
						global::System.DateTimeOffset value3 = (global::System.DateTimeOffset)value2;
						global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDateTimeOffsetString(stringWriter, value3, global::Newtonsoft.Json.DateFormatHandling.IsoDateFormat, null, global::System.Globalization.CultureInfo.InvariantCulture);
					}
					else
					{
						global::Newtonsoft.Json.Utilities.DateTimeUtils.WriteDateTimeString(stringWriter, (global::System.DateTime)value.Value, global::Newtonsoft.Json.DateFormatHandling.IsoDateFormat, null, global::System.Globalization.CultureInfo.InvariantCulture);
					}
					a = stringWriter.ToString();
					goto IL_122;
				}
				break;
			case global::Newtonsoft.Json.Linq.JTokenType.Raw:
				return false;
			case global::Newtonsoft.Json.Linq.JTokenType.Bytes:
				break;
			case global::Newtonsoft.Json.Linq.JTokenType.Guid:
			case global::Newtonsoft.Json.Linq.JTokenType.TimeSpan:
				a = value.Value.ToString();
				goto IL_122;
			case global::Newtonsoft.Json.Linq.JTokenType.Uri:
				a = ((global::System.Uri)value.Value).OriginalString;
				goto IL_122;
			default:
				return false;
			}
			a = global::System.Convert.ToBase64String((byte[])value.Value);
			IL_122:
			return string.Equals(a, b, global::System.StringComparison.Ordinal);
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000308A8 File Offset: 0x0002EAA8
		internal static bool EqualsWithStrictMatch(global::Newtonsoft.Json.Linq.JValue value, global::Newtonsoft.Json.Linq.JValue queryValue)
		{
			if ((value.Type == global::Newtonsoft.Json.Linq.JTokenType.Integer && queryValue.Type == global::Newtonsoft.Json.Linq.JTokenType.Float) || (value.Type == global::Newtonsoft.Json.Linq.JTokenType.Float && queryValue.Type == global::Newtonsoft.Json.Linq.JTokenType.Integer))
			{
				return global::Newtonsoft.Json.Linq.JValue.Compare(value.Type, value.Value, queryValue.Value) == 0;
			}
			return value.Type == queryValue.Type && value.Equals(queryValue);
		}

		// Token: 0x040003C9 RID: 969
		public readonly object Left;

		// Token: 0x040003CA RID: 970
		[global::System.Runtime.CompilerServices.Nullable(2)]
		public readonly object Right;
	}
}
