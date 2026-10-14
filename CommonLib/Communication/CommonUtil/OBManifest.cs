using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000053 RID: 83
	public class OBManifest
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x000273C8 File Offset: 0x000255C8
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x0002747C File Offset: 0x0002567C
		public string schemaVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1034747904;
				short num2 = num;
				num = (short)573702145;
				if (num != 0)
				{
				}
				num = (short)1029476635;
				short num3 = num;
				num = (short)2054721819;
				switch (num3 == num)
				{
				}
				num = (short)965279744;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1914699776;
				short num2 = num;
				num = (short)1551734950;
				short num3 = num;
				num = (short)894998694;
				switch (num3 == num)
				{
				}
				num = (short)698548224;
				if (num != 0)
				{
				}
				num = (short)1866989569;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0002752C File Offset: 0x0002572C
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x000275E0 File Offset: 0x000257E0
		public string manifestVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1243676672;
				short num2 = num;
				num = (short)404428907;
				short num3 = num;
				num = (short)1621432427;
				switch (num3 == num)
				{
				}
				num = (short)1133051905;
				if (num != 0)
				{
				}
				num = (short)57540608;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1644429312;
				short num2 = num;
				num = (short)1141693605;
				short num3 = num;
				num = (short)1146543269;
				switch (num3 == num)
				{
				}
				num = (short)1047396352;
				if (num != 0)
				{
				}
				num = (short)2003042305;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x00027694 File Offset: 0x00025894
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00027744 File Offset: 0x00025944
		public string packageVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)321912832;
				short num2 = num;
				num = (short)1391294033;
				short num3 = num;
				num = (short)584939089;
				switch (num3 == num)
				{
				}
				num = (short)686948353;
				if (num != 0)
				{
				}
				num = (short)1663762432;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1893007360;
				short num2 = num;
				num = (short)574967904;
				short num3 = num;
				num = (short)1948733536;
				switch (num3 == num)
				{
				}
				num = (short)129433601;
				if (num != 0)
				{
				}
				num = (short)1480261632;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000277F4 File Offset: 0x000259F4
		// (set) Token: 0x060001FA RID: 506 RVA: 0x000278A0 File Offset: 0x00025AA0
		public string packageDescription
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1861812224;
				short num2 = num;
				num = (short)1965251662;
				short num3 = num;
				num = (short)373120078;
				switch (num3 == num)
				{
				}
				num = (short)933756929;
				if (num != 0)
				{
				}
				num = (short)1239744512;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1780350976;
				short num2 = num;
				num = (short)1780863028;
				short num3 = num;
				num = (short)91803700;
				switch (num3 == num)
				{
				}
				num = (short)1234239489;
				if (num != 0)
				{
				}
				num = (short)757202944;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001FB RID: 507 RVA: 0x00027954 File Offset: 0x00025B54
		// (set) Token: 0x060001FC RID: 508 RVA: 0x00027A00 File Offset: 0x00025C00
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.componet> components
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1490288640;
				short num2 = num;
				num = (short)346912950;
				short num3 = num;
				num = (short)1659599030;
				switch (num3 == num)
				{
				}
				num = (short)1616576513;
				if (num != 0)
				{
				}
				num = (short)2065235968;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1946222592;
				short num2 = num;
				num = (short)1667131624;
				short num3 = num;
				num = (short)1333029096;
				switch (num3 == num)
				{
				}
				num = (short)2106982401;
				if (num != 0)
				{
				}
				num = (short)416677888;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00027AB4 File Offset: 0x00025CB4
		public OBManifest(byte[] manifestFile)
		{
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(manifestFile))
			{
				xmlDocument.Load(memoryStream);
				this.a(xmlDocument);
				memoryStream.Close();
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00027B0C File Offset: 0x00025D0C
		public OBManifest(string manifestFile)
		{
			if (global::System.IO.File.Exists(manifestFile))
			{
				global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
				xmlDocument.Load(manifestFile);
				this.a(xmlDocument);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00027B40 File Offset: 0x00025D40
		private void a(global::System.Xml.XmlDocument A_0)
		{
			int a_ = 13;
			short num = (short)2127298560;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				global::System.Xml.XmlNode xmlNode;
				for (;;)
				{
					IL_30:
					global::System.Xml.XmlNodeList xmlNodeList;
					switch (num2)
					{
					case 0:
						if (xmlNodeList != null)
						{
							num = (short)2078801934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						this.packageVersion = xmlNode.InnerText.Trim();
						num = (short)1064108034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_139;
					case 3:
						this.packageDescription = xmlNode.InnerText.Trim();
						num = (short)529137670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (xmlNode != null)
						{
							num = (short)732168199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18F;
					case 5:
						num = (short)868024321;
						if (num != 0)
						{
						}
						try
						{
							num = (short)830406657;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.Common.Communication.CommonUtil.componet componet;
								switch (num2)
								{
								case 0:
									goto IL_403;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_231;
									}
									continue;
								case 2:
								{
									global::System.Collections.IEnumerator enumerator;
									global::System.Xml.XmlNode xmlNode2 = (global::System.Xml.XmlNode)enumerator.Current;
									componet = new global::Motorola.Common.Communication.CommonUtil.componet();
									xmlNode = xmlNode2.SelectSingleNode(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("成簒怔攖稘縚嬜瘞䴠䘢䬤䘦䐨个", a_));
									if (xmlNode != null)
									{
										componet.sourceFilename = xmlNode.InnerText.Trim();
									}
									xmlNode = xmlNode2.SelectSingleNode(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("眐稒礔爖䴘戚洜稞", a_));
									if (xmlNode != null)
									{
										componet.fileType = xmlNode.InnerText.Trim();
									}
									xmlNode = xmlNode2.SelectSingleNode(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("眐稒礔爖團稚瀜稞", a_));
									if (xmlNode != null)
									{
										componet.fileName = xmlNode.InnerText.Trim();
									}
									xmlNode = xmlNode2.SelectSingleNode(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("攐爒朔瀖簘漚夜瘞匠", a_));
									if (xmlNode != null)
									{
										componet.targetDir = xmlNode.InnerText.Trim();
									}
									xmlNode = xmlNode2.SelectSingleNode(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("眐稒礔爖崘縚渜簞匠䨢唤", a_));
									num = (short)1522401288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1965948928;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::System.Collections.IEnumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1355808771;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1871708162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									componet.fileDescrip = xmlNode.InnerText.Trim();
									num = (short)220397575;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_387;
								case 8:
									if (xmlNode != null)
									{
										num = (short)1307967494;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_387;
								}
								goto IL_231;
								IL_387:
								this.components.Add(componet);
								num = (short)953614340;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3AE:
								num = (short)1983250437;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_231:
								goto IL_3AE;
							}
							IL_403:
							return;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_425;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_412:
								switch (num2)
								{
								case 0:
									goto IL_4D1;
								case 1:
									disposable.Dispose();
									num = (short)234356736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									if (disposable == null)
									{
										goto IL_4D3;
									}
									num = (short)1599132237;
									short num3 = num;
									num = (short)152818253;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)1900412928;
										if (num != 0)
										{
										}
										num = (short)1876557825;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_425;
							}
							IL_4D1:
							IL_4D3:
							goto EndFinally_15;
							IL_425:
							global::System.Collections.IEnumerator enumerator;
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1192755202;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_412;
							EndFinally_15:;
						}
						goto IL_4D4;
					case 6:
						goto IL_CB;
					case 7:
						goto IL_4D4;
					case 8:
						if (xmlNode != null)
						{
							num = (short)1745944579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CB;
					case 9:
						if (xmlNode != null)
						{
							num = (short)366804993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139;
					case 10:
						goto IL_5FF;
					case 11:
						this.manifestVersion = xmlNode.InnerText.Trim();
						num = (short)437583882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (xmlNode != null)
						{
							num = (short)2112749579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FF;
					case 13:
					{
						num = (short)578551808;
						short num4 = num;
						goto IL_18F;
					}
					case 14:
					{
						global::System.Collections.IEnumerator enumerator = xmlNodeList.GetEnumerator();
						num = (short)1096417285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_73;
					IL_CB:
					xmlNodeList = A_0.DocumentElement.SelectNodes(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("爐簒研朖瘘甚砜焞唠", a_));
					this.components = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.componet>();
					this.components.Clear();
					num = (short)1464139776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_139:
					xmlNode = A_0.DocumentElement.SelectSingleNode(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("愐爒瘔簖砘簚砜嬞䐠倢䘤唦䀨嬪夬䘮帰崲", a_));
					num = (short)1132920840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18F:
					xmlNode = A_0.DocumentElement.SelectSingleNode(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("簐爒笔縖缘縚渜欞眠䘢圤否䀨䐪䌬", a_));
					num = (short)1925447692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D4:
					this.schemaVersion = xmlNode.Value.Trim();
					num = (short)981794829;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FF:
					xmlNode = A_0.DocumentElement.SelectSingleNode(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("愐爒瘔簖砘簚砜䤞䐠儢嘤並䘨䔪", a_));
					num = (short)409862153;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_73:
				xmlNode = A_0.DocumentElement.Attributes.GetNamedItem(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("成瀒純爖琘稚䬜稞匠倢䰤䠦䜨", a_));
				num = (short)849018884;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x040001EA RID: 490
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x040001EB RID: 491
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x040001EC RID: 492
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string c;

		// Token: 0x040001ED RID: 493
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;

		// Token: 0x040001EE RID: 494
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.componet> e;
	}
}
