using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using Motorola.Common.CustomException;

namespace Motorola.Security.SamlTokenComponent
{
	// Token: 0x02000010 RID: 16
	public class TokenIssuerConfigSectionHandler : global::System.Configuration.IConfigurationSectionHandler
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00012DC8 File Offset: 0x00010FC8
		public object Create(object parent, object configContext, global::System.Xml.XmlNode section)
		{
			int a_ = 3;
			short num = (short)2032402432;
			switch (num)
			{
			default:
			{
				num = (short)2081161218;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo> list;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_80;
					case 1:
						goto IL_139;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						continue;
					case 3:
					{
						num = (short)584187904;
						short num3 = num;
						global::System.Collections.Generic.IEnumerable<global::System.Xml.Linq.XElement> enumerable = global::System.Xml.Linq.XElement.Parse(section.OuterXml).Elements(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꃳ駵鏷鿹鋻럽珿焁焃挅稇", a_));
						if (enumerable.Count<global::System.Xml.Linq.XElement>() == 0)
						{
							goto Block_2;
						}
						list = new global::System.Collections.Generic.List<global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo>();
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator = enumerable.GetEnumerator();
						num = (short)1776025601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_5E:
					if (string.IsNullOrEmpty(section.InnerXml))
					{
						num = (short)272564224;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)11862019;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_80:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꃳ駵鏷鿹鋻럽珿焁焃挅稇⨉漋愍縏琑紓焕洗栙紛樝䤟䴡䨣إ嬧伩伫娭夯崱娳ᘵ儷䤹᰻匽⤿ㅁ㝃⽅♇ⵉ", a_));
				Block_2:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("ꃳ駵鏷鿹鋻럽珿焁焃挅稇⨉漋愍縏琑紓焕洗栙紛樝䤟䴡䨣إ嬧伩伫娭夯崱娳ᘵ儷䤹᰻匽⤿ㅁ㝃⽅♇ⵉ", a_));
				IL_139:
				try
				{
					num = (short)824639490;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)907411457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_221;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_177;
							}
							continue;
						case 4:
						{
							num = (short)130285569;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1424556032;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Xml.Linq.XElement a_2 = enumerator.Current;
							global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo tokenIssuerInfo = new global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo();
							global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.a(tokenIssuerInfo, a_2);
							list.Add(tokenIssuerInfo);
							num = (short)483000323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_1AB:
						num = (short)420347908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_177:
						goto IL_1AB;
					}
					IL_221:;
				}
				finally
				{
					num = (short)471597057;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_2DF;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_259;
							}
							continue;
						case 2:
						{
							num = (short)910670740;
							short num4 = num;
							num = (short)2024323988;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2DF;
							default:
								num = (short)426246144;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)1046020096;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_259:
						if (enumerator == null)
						{
							break;
						}
						num = (short)260964354;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2DF:;
				}
				return list;
			}
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000130C8 File Offset: 0x000112C8
		private static void a(global::Motorola.Security.SamlTokenComponent.TokenIssuerInfo A_0, global::System.Xml.Linq.XElement A_1)
		{
			int a_ = 0;
			short num = (short)1582266495;
			short num2 = num;
			num = (short)2108192895;
			switch (num2 == num)
			{
			}
			num = (short)713818113;
			if (num != 0)
			{
			}
			num = (short)295174144;
			short num3 = num;
			num = (short)1188757504;
			if (num != 0)
			{
			}
			A_0.address = A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("郰韲釴藶鳸裺軼", a_)).Value;
			A_0.binding = A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("鏰髲鯴鏶郸闺髼", a_)).Value;
			A_0.bindingConfiguration = A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("鏰髲鯴鏶郸闺髼볾渀洂挄渆済縊缌渎攐稒稔礖", a_)).Value;
			A_0.authenticationMethod = A_1.Attribute(global::Motorola.Security.SamlTokenComponent.TokenIssuerConfigSectionHandler.b("郰蛲致鿶鳸闺觼雾戀戂焄渆昈攊䀌樎攐笒稔猖", a_)).Value;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00013220 File Offset: 0x00011420
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(883491175 + A_1) + (global::System.IntPtr)65 + (global::System.IntPtr)72);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}
	}
}
