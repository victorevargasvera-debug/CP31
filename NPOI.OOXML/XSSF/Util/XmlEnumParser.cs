using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml.Serialization;

namespace NPOI.XSSF.Util
{
	// Token: 0x0200005B RID: 91
	public class XmlEnumParser<TReturn>
	{
		// Token: 0x06000411 RID: 1041 RVA: 0x000105C0 File Offset: 0x0000E7C0
		static XmlEnumParser()
		{
			global::System.Type typeFromHandle = typeof(TReturn);
			global::System.Reflection.MemberInfo[] members = typeFromHandle.GetMembers(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
			global::System.Enum.GetNames(typeFromHandle);
			global::NPOI.XSSF.Util.XmlEnumParser<TReturn>.values = new global::System.Collections.Generic.Dictionary<string, TReturn>();
			typeFromHandle.GetEnumValues();
			foreach (global::System.Reflection.MemberInfo memberInfo in members)
			{
				object[] customAttributes = memberInfo.GetCustomAttributes(typeof(global::System.Xml.Serialization.XmlEnumAttribute), false);
				if (customAttributes.Length != 0)
				{
					global::System.Xml.Serialization.XmlEnumAttribute xmlEnumAttribute = (global::System.Xml.Serialization.XmlEnumAttribute)customAttributes[0];
					global::NPOI.XSSF.Util.XmlEnumParser<TReturn>.values.Add(xmlEnumAttribute.Name, (TReturn)((object)global::System.Enum.Parse(typeFromHandle, memberInfo.Name)));
				}
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00010650 File Offset: 0x0000E850
		public static TReturn ForName(string name, TReturn defaultValue)
		{
			if (global::NPOI.XSSF.Util.XmlEnumParser<TReturn>.values.ContainsKey(name))
			{
				return global::NPOI.XSSF.Util.XmlEnumParser<TReturn>.values[name];
			}
			return defaultValue;
		}

		// Token: 0x04000256 RID: 598
		private static global::System.Collections.Generic.Dictionary<string, TReturn> values;
	}
}
