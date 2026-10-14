using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using AcpUI.Common;

namespace AcpUI
{
	// Token: 0x02000053 RID: 83
	public static class HelpMapProvider
	{
		// Token: 0x060004BA RID: 1210 RVA: 0x00059EA0 File Offset: 0x000580A0
		public static global::System.Collections.Generic.Dictionary<string, global::AcpUI.HelpMapData> ParseHelpMapFile(string filePath)
		{
			short num;
			global::System.Collections.Generic.Dictionary<string, global::AcpUI.HelpMapData> result;
			try
			{
				num = (short)1479016449;
				if (num != 0)
				{
				}
				num = (short)1463986898;
				short num2 = num;
				num = (short)2046929618;
				switch (num2 == num)
				{
				}
				num = (short)1158414336;
				if (num != 0)
				{
				}
				result = global::AcpUI.HelpMapProvider.a(filePath);
			}
			catch
			{
				result = new global::System.Collections.Generic.Dictionary<string, global::AcpUI.HelpMapData>();
			}
			num = (short)1980891136;
			short num3 = num;
			return result;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00059F70 File Offset: 0x00058170
		private static global::System.Collections.Generic.Dictionary<string, global::AcpUI.HelpMapData> a(string A_0)
		{
			int a_ = 5;
			short num = (short)2004090880;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.Generic.Dictionary<string, global::AcpUI.HelpMapData> dictionary = new global::System.Collections.Generic.Dictionary<string, global::AcpUI.HelpMapData>(global::System.StringComparer.OrdinalIgnoreCase);
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				global::System.Collections.Generic.Dictionary<string, global::AcpUI.HelpMapData> result;
				try
				{
					xmlDocument.Load(A_0);
					goto IL_39;
				}
				catch (global::System.Exception)
				{
					result = dictionary;
					goto IL_414;
				}
				return dictionary;
				IL_39:
				int num3 = 0;
				global::System.Collections.IEnumerator enumerator = xmlDocument.LastChild.ChildNodes.GetEnumerator();
				try
				{
					num = (short)1869545476;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)287178761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							string fileNameWithoutExtension;
							global::AcpUI.HelpMapData value;
							dictionary.Add(fileNameWithoutExtension, value);
							num = (short)1565523980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::System.Xml.XmlAttribute xmlAttribute;
							if (!string.IsNullOrEmpty(xmlAttribute.Value))
							{
								num = (short)1665531909;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_111;
						}
						case 3:
							goto IL_111;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_CD;
							}
							continue;
						case 5:
							num = (short)1475084294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::System.Xml.XmlAttribute xmlAttribute2;
							if (xmlAttribute2 != null)
							{
								num = (short)539164672;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_111;
						}
						case 7:
							num = (short)1862270986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)996540423;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
							global::System.Xml.XmlAttribute xmlAttribute = xmlNode.Attributes[global::AcpUI.Common.Utility.c("列", a_)];
							global::System.Xml.XmlAttribute xmlAttribute2 = xmlNode.Attributes[global::AcpUI.Common.Utility.c("", a_)];
							num = (short)307757069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::System.Xml.XmlAttribute xmlAttribute2;
							if (string.IsNullOrEmpty(xmlAttribute2.Value))
							{
								num = (short)258473987;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.XmlAttribute xmlAttribute;
							string fileNameWithoutExtension = global::System.IO.Path.GetFileNameWithoutExtension(xmlAttribute.Value);
							string value2 = xmlAttribute2.Value;
							global::AcpUI.HelpMapData value = new global::AcpUI.HelpMapData(fileNameWithoutExtension, value2);
							num = (short)769261579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_31B;
						case 11:
						{
							global::AcpUI.HelpMapData value;
							if (!dictionary.ContainsKey(value.Id))
							{
								num = (short)1116340225;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 13:
						{
							global::System.Xml.XmlAttribute xmlAttribute;
							if (xmlAttribute != null)
							{
								num = (short)1025310734;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_111;
						}
						case 14:
							num = (short)904069122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_D2:
						num = (short)636878856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_CD:
						goto IL_D2;
						IL_111:
						num3++;
						num = (short)1101332495;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_31B:
					return dictionary;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_33D;
					}
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_32A:
						switch (num2)
						{
						case 0:
							goto IL_411;
						case 1:
							goto IL_3C6;
						case 2:
						{
							if (disposable == null)
							{
								goto IL_413;
							}
							num = (short)1826307457;
							short num4 = num;
							num = (short)2003254657;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3C6;
							default:
								num = (short)837484544;
								if (num != 0)
								{
								}
								num = (short)486866945;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_33D;
						IL_3C6:
						num = (short)67502081;
						if (num != 0)
						{
						}
						disposable.Dispose();
						num = (short)765198336;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_411:
					IL_413:
					goto EndFinally_12;
					IL_33D:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)911736834;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32A;
					EndFinally_12:;
				}
				IL_414:
				num = (short)1841233920;
				short num5 = num;
				return result;
			}
			}
		}

		// Token: 0x040002A4 RID: 676
		private const string a = "id";

		// Token: 0x040002A5 RID: 677
		private const string b = "url";
	}
}
