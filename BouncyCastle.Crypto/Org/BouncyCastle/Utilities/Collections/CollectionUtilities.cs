using System;
using System.Collections;
using System.Text;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x0200006B RID: 107
	public abstract class CollectionUtilities
	{
		// Token: 0x06000443 RID: 1091 RVA: 0x00015C20 File Offset: 0x00013E20
		public static void AddRange(global::System.Collections.IList to, global::System.Collections.IEnumerable range)
		{
			foreach (object o in range)
			{
				to.Add(o);
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00015C70 File Offset: 0x00013E70
		public static bool CheckElementsAreOfType(global::System.Collections.IEnumerable e, global::System.Type t)
		{
			foreach (object o in e)
			{
				if (!t.IsInstanceOfType(o))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00015CC8 File Offset: 0x00013EC8
		public static global::System.Collections.IDictionary ReadOnly(global::System.Collections.IDictionary d)
		{
			return new global::Org.BouncyCastle.Utilities.Collections.UnmodifiableDictionaryProxy(d);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00015CD0 File Offset: 0x00013ED0
		public static global::System.Collections.IList ReadOnly(global::System.Collections.IList l)
		{
			return new global::Org.BouncyCastle.Utilities.Collections.UnmodifiableListProxy(l);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00015CD8 File Offset: 0x00013ED8
		public static global::Org.BouncyCastle.Utilities.Collections.ISet ReadOnly(global::Org.BouncyCastle.Utilities.Collections.ISet s)
		{
			return new global::Org.BouncyCastle.Utilities.Collections.UnmodifiableSetProxy(s);
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00015CE0 File Offset: 0x00013EE0
		public static object RequireNext(global::System.Collections.IEnumerator e)
		{
			if (!e.MoveNext())
			{
				throw new global::System.InvalidOperationException();
			}
			return e.Current;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00015CF8 File Offset: 0x00013EF8
		public static string ToString(global::System.Collections.IEnumerable c)
		{
			global::System.Collections.IEnumerator e = c.GetEnumerator();
			if (!e.MoveNext())
			{
				return "[]";
			}
			global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder("[");
			sb.Append(e.Current.ToString());
			while (e.MoveNext())
			{
				sb.Append(", ");
				sb.Append(e.Current.ToString());
			}
			sb.Append(']');
			return sb.ToString();
		}
	}
}
