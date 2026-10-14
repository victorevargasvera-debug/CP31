using System;
using System.IO;
using System.Text;
using System.Xml;

namespace Motorola.Common.Communication.AmpConfigPackage
{
	// Token: 0x02000039 RID: 57
	public static class ManifestXmlHelper
	{
		// Token: 0x060001A8 RID: 424 RVA: 0x0002AB88 File Offset: 0x00028D88
		public static global::System.IO.MemoryStream CreateManifest(string codeplugFileName)
		{
			short num = (short)847842939;
			short num2 = num;
			num = (short)923864699;
			switch (num2 == num)
			{
			}
			num = (short)1423966209;
			if (num != 0)
			{
			}
			num = (short)474939392;
			short num3 = num;
			num = (short)2070085632;
			if (num != 0)
			{
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::Motorola.Common.Communication.AmpConfigPackage.ManifestXmlHelper.a(memoryStream, codeplugFileName);
			memoryStream.Position = 0L;
			return memoryStream;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0002AC48 File Offset: 0x00028E48
		private static void a(global::System.IO.Stream A_0, string A_1)
		{
			int a_ = 2;
			short num = (short)2096234496;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Xml.XmlWriter xmlWriter;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
				{
					num = (short)125632512;
					short num3 = num;
					try
					{
						num = (short)515833857;
						if (num != 0)
						{
						}
						global::Motorola.Common.Communication.AmpConfigPackage.ManifestXmlHelper.b(xmlWriter, A_1);
						xmlWriter.Flush();
						return;
					}
					finally
					{
						num = (short)377880576;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_C8;
								}
								continue;
							case 1:
								goto IL_FF;
							case 2:
								((global::System.IDisposable)xmlWriter).Dispose();
								num = (short)1471479809;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_C8:
							if (xmlWriter == null)
							{
								break;
							}
							num = (short)910098434;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_FF:
						num = (short)1575244667;
						short num4 = num;
						num = (short)1089033083;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FF;
						default:
							num = (short)49479680;
							if (num != 0)
							{
							}
							break;
						}
					}
					goto IL_14D;
				}
				case 2:
					goto IL_58;
				}
				IL_39:
				if (string.IsNullOrEmpty(A_1))
				{
					num = (short)1440546818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_14D:
				global::System.Xml.XmlWriterSettings settings = new global::System.Xml.XmlWriterSettings
				{
					Indent = true,
					Encoding = global::System.Text.Encoding.UTF8
				};
				xmlWriter = global::System.Xml.XmlWriter.Create(A_0, settings);
				num = (short)862126081;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_58:
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("釱鯳鋵鷷諹郻诽柿䐁洃樅洇䐉洋挍甏", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꋱ闳蓵駷韹駻諽旿瀁␃攅椇搉戋愍搏㈑瘓猕㠗缙焛渝吟嬡У䤥娧਩䈫嬭尯帱", a_));
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0002AE3C File Offset: 0x0002903C
		private static void b(global::System.Xml.XmlWriter A_0, string A_1)
		{
			int a_ = 6;
			short num = (short)1735049634;
			short num2 = num;
			num = (short)649445794;
			switch (num2 == num)
			{
			}
			num = (short)1491468289;
			if (num != 0)
			{
			}
			num = (short)695730176;
			short num3 = num;
			num = (short)1357185024;
			if (num != 0)
			{
			}
			A_0.WriteStartDocument(true);
			A_0.WriteStartElement(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꓵ駷黹闻釽仿朁簃爅", a_));
			A_0.WriteAttributeString(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("藵鯷鋹駻鏽懿吁愃琅笇按挋怍", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("쟵훷쯹틻쿽", a_));
			A_0.WriteAttributeString(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("軵闷雹鋻跽", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("軵请鏹", a_), null, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("黵賷軹賻쓽⿿ⴁ猃焅缇␉笋㴍㸏紑易焕㜗⠙Ⱋ⸝ᄟഡ簣欥搧礩伫䘭唯弱唳ᬵ儷吹伻䨽ℿⱁ❃⍅", a_));
			A_0.WriteAttributeString(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("軵请鏹", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("飵韷듹鷻鏽旿焁球朅欇漉弋洍砏眑礓眕吗甙缛缝吟䬡䬣䠥", a_), null, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꏵ꫷뛹", a_));
			A_0.WriteElementString(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鯵駷铹闻飽旿焁瀃倅洇砉缋服缏簑", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("쟵훷쫹틻컽", a_));
			A_0.WriteElementString(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("蛵駷駹韻鿽柿朁刃挅稇礉攋愍縏", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("쟵훷쯹틻쿽", a_));
			A_0.WriteElementString(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("蛵駷駹韻鿽柿朁䀃挅笇椉縋服怏昑紓礕瘗", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("답鷷賹闻鷽旿∁䤃朅昇欉欋欍戏㈑圓礕瘗簙甛礝唟倡䔣別䄧䔩䈫อ瘯嬱堳匵ᠷ䰹഻ွ瀿汁畃", a_));
			global::Motorola.Common.Communication.AmpConfigPackage.ManifestXmlHelper.a(A_0, A_1);
			A_0.WriteEndElement();
			A_0.WriteEndDocument();
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0002B008 File Offset: 0x00029208
		private static void a(global::System.Xml.XmlWriter A_0, string A_1)
		{
			int a_ = 11;
			short num = (short)242812076;
			short num2 = num;
			num = (short)539428012;
			switch (num2 == num)
			{
			}
			num = (short)1288175617;
			if (num != 0)
			{
			}
			num = (short)229113856;
			short num3 = num;
			num = (short)1659961344;
			if (num != 0)
			{
			}
			A_0.WriteStartElement(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("飺鋼鋾焀氂欄戆月缊", a_));
			A_0.WriteElementString(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("裺鋼諾猀怂怄䄆怈朊栌愎瀐縒瀔", a_), A_1);
			A_0.WriteStartElement(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鷺铼鏾搀圂簄眆氈", a_));
			A_0.WriteAttributeString(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("裺裼鷾唀稂甄戆", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("룺鋼鯾搀猂椄爆済", a_));
			A_0.WriteString(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("룺鋼鯾搀猂椄爆済", a_));
			A_0.WriteEndElement();
			A_0.WriteStartElement(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鷺铼鏾搀䴂搄樆氈", a_));
			A_0.WriteString(string.Empty);
			A_0.WriteFullEndElement();
			A_0.WriteStartElement(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("迺鳼跾昀昂焄䌆怈礊", a_));
			A_0.WriteString(string.Empty);
			A_0.WriteFullEndElement();
			A_0.WriteEndElement();
		}
	}
}
