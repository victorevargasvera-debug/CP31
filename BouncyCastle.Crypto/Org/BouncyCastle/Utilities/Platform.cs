using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Security;

namespace Org.BouncyCastle.Utilities
{
	// Token: 0x0200003A RID: 58
	internal abstract class Platform
	{
		// Token: 0x0600029B RID: 667 RVA: 0x0000C81D File Offset: 0x0000AA1D
		private static string GetNewLine()
		{
			return global::System.Environment.NewLine;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000C824 File Offset: 0x0000AA24
		internal static bool EqualsIgnoreCase(string a, string b)
		{
			return global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(a) == global::Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(b);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000C838 File Offset: 0x0000AA38
		internal static string GetEnvironmentVariable(string variable)
		{
			string result;
			try
			{
				result = global::System.Environment.GetEnvironmentVariable(variable);
			}
			catch (global::System.Security.SecurityException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000C864 File Offset: 0x0000AA64
		internal static global::System.Exception CreateNotImplementedException(string message)
		{
			return new global::System.NotImplementedException(message);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000C86C File Offset: 0x0000AA6C
		internal static global::System.Collections.IList CreateArrayList()
		{
			return new global::System.Collections.ArrayList();
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000C873 File Offset: 0x0000AA73
		internal static global::System.Collections.IList CreateArrayList(int capacity)
		{
			return new global::System.Collections.ArrayList(capacity);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000C87B File Offset: 0x0000AA7B
		internal static global::System.Collections.IList CreateArrayList(global::System.Collections.ICollection collection)
		{
			return new global::System.Collections.ArrayList(collection);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000C884 File Offset: 0x0000AA84
		internal static global::System.Collections.IList CreateArrayList(global::System.Collections.IEnumerable collection)
		{
			global::System.Collections.ArrayList result = new global::System.Collections.ArrayList();
			foreach (object o in collection)
			{
				result.Add(o);
			}
			return result;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0000C8DC File Offset: 0x0000AADC
		internal static global::System.Collections.IDictionary CreateHashtable()
		{
			return new global::System.Collections.Hashtable();
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x0000C8E3 File Offset: 0x0000AAE3
		internal static global::System.Collections.IDictionary CreateHashtable(int capacity)
		{
			return new global::System.Collections.Hashtable(capacity);
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x0000C8EB File Offset: 0x0000AAEB
		internal static global::System.Collections.IDictionary CreateHashtable(global::System.Collections.IDictionary dictionary)
		{
			return new global::System.Collections.Hashtable(dictionary);
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x0000C8F3 File Offset: 0x0000AAF3
		internal static string ToLowerInvariant(string s)
		{
			return s.ToLower(global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000C900 File Offset: 0x0000AB00
		internal static string ToUpperInvariant(string s)
		{
			return s.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000C90D File Offset: 0x0000AB0D
		internal static void Dispose(global::System.IO.Stream s)
		{
			s.Close();
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x0000C915 File Offset: 0x0000AB15
		internal static void Dispose(global::System.IO.TextWriter t)
		{
			t.Close();
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000C91D File Offset: 0x0000AB1D
		internal static int IndexOf(string source, string value)
		{
			return global::Org.BouncyCastle.Utilities.Platform.InvariantCompareInfo.IndexOf(source, value, global::System.Globalization.CompareOptions.Ordinal);
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000C930 File Offset: 0x0000AB30
		internal static int LastIndexOf(string source, string value)
		{
			return global::Org.BouncyCastle.Utilities.Platform.InvariantCompareInfo.LastIndexOf(source, value, global::System.Globalization.CompareOptions.Ordinal);
		}

		// Token: 0x060002AC RID: 684 RVA: 0x0000C943 File Offset: 0x0000AB43
		internal static bool StartsWith(string source, string prefix)
		{
			return global::Org.BouncyCastle.Utilities.Platform.InvariantCompareInfo.IsPrefix(source, prefix, global::System.Globalization.CompareOptions.Ordinal);
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000C956 File Offset: 0x0000AB56
		internal static bool EndsWith(string source, string suffix)
		{
			return global::Org.BouncyCastle.Utilities.Platform.InvariantCompareInfo.IsSuffix(source, suffix, global::System.Globalization.CompareOptions.Ordinal);
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000C969 File Offset: 0x0000AB69
		internal static string GetTypeName(object obj)
		{
			return obj.GetType().FullName;
		}

		// Token: 0x040000F8 RID: 248
		private static readonly global::System.Globalization.CompareInfo InvariantCompareInfo = global::System.Globalization.CultureInfo.InvariantCulture.CompareInfo;

		// Token: 0x040000F9 RID: 249
		internal static readonly string NewLine = global::Org.BouncyCastle.Utilities.Platform.GetNewLine();
	}
}
