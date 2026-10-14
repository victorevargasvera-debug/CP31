using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000085 RID: 133
	internal static class XContainerExtensions
	{
		// Token: 0x0600045D RID: 1117 RVA: 0x0000F454 File Offset: 0x0000D654
		public static global::System.Xml.Linq.XElement GetOrAddElement(this global::System.Xml.Linq.XContainer container, global::System.Xml.Linq.XName name)
		{
			global::System.Xml.Linq.XElement xelement = container.Element(name);
			if (xelement == null)
			{
				xelement = new global::System.Xml.Linq.XElement(name);
				container.Add(xelement);
			}
			return xelement;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0000F47B File Offset: 0x0000D67B
		public static global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> Descendants(this global::System.Xml.Linq.XContainer container, global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> name)
		{
			return name.SelectMany(new global::System.Func<global::System.Xml.Linq.XName, global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement>>(container.Descendants));
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0000F48F File Offset: 0x0000D68F
		public static global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> Elements(this global::System.Xml.Linq.XContainer container, global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> name)
		{
			return name.SelectMany(new global::System.Func<global::System.Xml.Linq.XName, global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement>>(container.Elements));
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0000F4A4 File Offset: 0x0000D6A4
		public static global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> Descendants<T>(this global::System.Collections.Generic.IEnumerable<T> source, global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XName> name) where T : global::System.Xml.Linq.XContainer
		{
			return name.SelectMany((global::System.Xml.Linq.XName n) => source.SelectMany((T c) => c.Descendants(n)));
		}
	}
}
