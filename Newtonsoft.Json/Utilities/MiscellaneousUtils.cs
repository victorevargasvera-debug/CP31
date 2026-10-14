using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000064 RID: 100
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal static class MiscellaneousUtils
	{
		// Token: 0x06000575 RID: 1397 RVA: 0x00017648 File Offset: 0x00015848
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		[global::System.Diagnostics.Conditional("DEBUG")]
		public static void Assert([global::System.Diagnostics.CodeAnalysis.DoesNotReturnIf(false)] bool condition, string message = null)
		{
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x0001764C File Offset: 0x0001584C
		[global::System.Runtime.CompilerServices.NullableContext(2)]
		public static bool ValueEquals(object objA, object objB)
		{
			if (objA == objB)
			{
				return true;
			}
			if (objA == null || objB == null)
			{
				return false;
			}
			if (!(objA.GetType() != objB.GetType()))
			{
				return objA.Equals(objB);
			}
			if (global::Newtonsoft.Json.Utilities.ConvertUtils.IsInteger(objA) && global::Newtonsoft.Json.Utilities.ConvertUtils.IsInteger(objB))
			{
				return global::System.Convert.ToDecimal(objA, global::System.Globalization.CultureInfo.CurrentCulture).Equals(global::System.Convert.ToDecimal(objB, global::System.Globalization.CultureInfo.CurrentCulture));
			}
			return (objA is double || objA is float || objA is decimal) && (objB is double || objB is float || objB is decimal) && global::Newtonsoft.Json.Utilities.MathUtils.ApproxEquals(global::System.Convert.ToDouble(objA, global::System.Globalization.CultureInfo.CurrentCulture), global::System.Convert.ToDouble(objB, global::System.Globalization.CultureInfo.CurrentCulture));
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00017700 File Offset: 0x00015900
		public static global::System.ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			string message2 = message + global::System.Environment.NewLine + "Actual value was {0}.".FormatWith(global::System.Globalization.CultureInfo.InvariantCulture, actualValue);
			return new global::System.ArgumentOutOfRangeException(paramName, message2);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00017730 File Offset: 0x00015930
		public static string ToString([global::System.Runtime.CompilerServices.Nullable(2)] object value)
		{
			if (value == null)
			{
				return "{null}";
			}
			string text = value as string;
			if (text == null)
			{
				return value.ToString();
			}
			return "\"" + text + "\"";
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00017768 File Offset: 0x00015968
		public static int ByteArrayCompare(byte[] a1, byte[] a2)
		{
			int num = a1.Length.CompareTo(a2.Length);
			if (num != 0)
			{
				return num;
			}
			for (int i = 0; i < a1.Length; i++)
			{
				int num2 = a1[i].CompareTo(a2[i]);
				if (num2 != 0)
				{
					return num2;
				}
			}
			return 0;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x000177B0 File Offset: 0x000159B0
		[return: global::System.Runtime.CompilerServices.Nullable(2)]
		public static string GetPrefix(string qualifiedName)
		{
			string result;
			string text;
			global::Newtonsoft.Json.Utilities.MiscellaneousUtils.GetQualifiedNameParts(qualifiedName, out result, out text);
			return result;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x000177C8 File Offset: 0x000159C8
		public static string GetLocalName(string qualifiedName)
		{
			string text;
			string result;
			global::Newtonsoft.Json.Utilities.MiscellaneousUtils.GetQualifiedNameParts(qualifiedName, out text, out result);
			return result;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000177E0 File Offset: 0x000159E0
		public static void GetQualifiedNameParts(string qualifiedName, [global::System.Runtime.CompilerServices.Nullable(2)] out string prefix, out string localName)
		{
			int num = qualifiedName.IndexOf(':');
			if (num == -1 || num == 0 || qualifiedName.Length - 1 == num)
			{
				prefix = null;
				localName = qualifiedName;
				return;
			}
			prefix = qualifiedName.Substring(0, num);
			localName = qualifiedName.Substring(num + 1);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00017824 File Offset: 0x00015A24
		internal static global::System.Text.RegularExpressions.RegexOptions GetRegexOptions(string optionsText)
		{
			global::System.Text.RegularExpressions.RegexOptions regexOptions = global::System.Text.RegularExpressions.RegexOptions.None;
			foreach (char c in optionsText)
			{
				if (c <= 'm')
				{
					if (c != 'i')
					{
						if (c == 'm')
						{
							regexOptions |= global::System.Text.RegularExpressions.RegexOptions.Multiline;
						}
					}
					else
					{
						regexOptions |= global::System.Text.RegularExpressions.RegexOptions.IgnoreCase;
					}
				}
				else if (c != 's')
				{
					if (c == 'x')
					{
						regexOptions |= global::System.Text.RegularExpressions.RegexOptions.ExplicitCapture;
					}
				}
				else
				{
					regexOptions |= global::System.Text.RegularExpressions.RegexOptions.Singleline;
				}
			}
			return regexOptions;
		}
	}
}
