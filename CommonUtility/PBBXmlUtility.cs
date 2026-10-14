using System;
using System.Text;
using System.Xml;

namespace CommonUtility
{
	// Token: 0x02000039 RID: 57
	public static class PBBXmlUtility
	{
		// Token: 0x0600012A RID: 298 RVA: 0x0001F634 File Offset: 0x0001D834
		public static string FormatXmlDocument(global::System.Xml.XmlDocument doc)
		{
			int a_ = 18;
			short num = (short)641583066;
			short num2 = num;
			num = (short)1563084762;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_16E;
			case 1:
				break;
			default:
			{
				num = (short)961150976;
				short num3 = num;
				break;
			}
			}
			num = (short)1052835840;
			if (num != 0)
			{
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			global::System.Xml.XmlWriterSettings settings = new global::System.Xml.XmlWriterSettings
			{
				Indent = true,
				IndentChars = global::CommonUtility.VersionUtility.b("捂敄杆", a_),
				NewLineHandling = global::System.Xml.NewLineHandling.Replace,
				NewLineChars = global::CommonUtility.VersionUtility.b("乂佄", a_),
				Encoding = global::System.Text.Encoding.UTF8
			};
			global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(stringBuilder, settings);
			try
			{
				doc.Save(xmlWriter);
			}
			finally
			{
				num = (short)1679032321;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)169934849;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						((global::System.IDisposable)xmlWriter).Dispose();
						num = (short)1965031426;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_136;
						}
						continue;
					case 2:
						goto IL_16B;
					}
					IL_136:
					if (xmlWriter == null)
					{
						break;
					}
					num = (short)36503552;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_16B:;
			}
			IL_16E:
			stringBuilder.Replace(global::CommonUtility.VersionUtility.b("♂⭄⑆♈⽊⑌ⅎ㙐湒睔≖ⵘ㵚灜湞坠䅢", a_), global::CommonUtility.VersionUtility.b("♂⭄⑆♈⽊⑌ⅎ㙐湒睔≖ⵘ㵚灜杞䍠", a_));
			return stringBuilder.ToString();
		}
	}
}
