using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ASKLib
{
	// Token: 0x02000003 RID: 3
	[global::System.Serializable]
	public class AstroASKProgrammingHistory
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000021C8 File Offset: 0x000003C8
		public int Version
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)859255691;
				short num2 = num;
				num = (short)560542603;
				switch (num2 == num)
				{
				}
				num = (short)2013528064;
				short num3 = num;
				num = (short)1213333505;
				if (num != 0)
				{
				}
				num = (short)786235392;
				if (num != 0)
				{
				}
				return this.<Version>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1915809716;
				short num2 = num;
				num = (short)1001910196;
				switch (num2 == num)
				{
				}
				num = (short)1943011328;
				short num3 = num;
				num = (short)1074528257;
				if (num != 0)
				{
				}
				num = (short)1971453952;
				if (num != 0)
				{
				}
				this.<Version>k__BackingField = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002278 File Offset: 0x00000478
		// (set) Token: 0x06000007 RID: 7 RVA: 0x00002328 File Offset: 0x00000528
		public global::System.Collections.ObjectModel.Collection<global::ASKLib.ASKProgrammingHistoryItem> Recset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1019268478;
				short num2 = num;
				num = (short)1635306878;
				switch (num2 == num)
				{
				}
				num = (short)728104960;
				short num3 = num;
				num = (short)386859008;
				if (num != 0)
				{
				}
				num = (short)608960513;
				if (num != 0)
				{
				}
				return this.<Recset>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)995757674;
				short num2 = num;
				num = (short)1574506090;
				switch (num2 == num)
				{
				}
				num = (short)79888384;
				short num3 = num;
				num = (short)774832128;
				if (num != 0)
				{
				}
				num = (short)1937178625;
				if (num != 0)
				{
				}
				this.<Recset>k__BackingField = value;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000023D8 File Offset: 0x000005D8
		public AstroASKProgrammingHistory()
		{
			this.x = new global::System.Xml.Serialization.XmlSerializer(typeof(global::ASKLib.AstroASKProgrammingHistory));
			base..ctor();
			this.Version = 1;
			this.Recset = new global::System.Collections.ObjectModel.Collection<global::ASKLib.ASKProgrammingHistoryItem>();
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002414 File Offset: 0x00000614
		public AstroASKProgrammingHistory(string xmlData)
		{
			int a_ = 19;
			this.x = new global::System.Xml.Serialization.XmlSerializer(typeof(global::ASKLib.AstroASKProgrammingHistory));
			base..ctor();
			if (!string.IsNullOrWhiteSpace(xmlData))
			{
				try
				{
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::System.Text.Encoding.UTF8.GetBytes(xmlData));
					memoryStream.Flush();
					memoryStream.Position = 0L;
					global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
					xmlDocument.Load(memoryStream);
					global::System.Xml.XmlNodeReader xmlReader = new global::System.Xml.XmlNodeReader(xmlDocument.DocumentElement);
					global::ASKLib.AstroASKProgrammingHistory astroASKProgrammingHistory = (global::ASKLib.AstroASKProgrammingHistory)this.x.Deserialize(xmlReader);
					this.Version = astroASKProgrammingHistory.Version;
					this.Recset = astroASKProgrammingHistory.Recset;
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::ASKLib.SystemKeyManager.b("ꧧ맩꟫뻭苯鷱鏳蓵駷韹釻韽滿攁䰃漅笇縉挋簍椏㈑眓礕洗瘙砛㸝丟䴡倣إ䨧伩ఫ䨭唯䄱儳䐵儷嬹倻圽㨿❁⁃晅⹇㡉⍋⍍灏ੑᥓᩕ硗㹙㵛⩝ş塡䑣", a_) + ex.Message);
				}
			}
			else
			{
				this.Version = 1;
				this.Recset = new global::System.Collections.ObjectModel.Collection<global::ASKLib.ASKProgrammingHistoryItem>();
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000024F8 File Offset: 0x000006F8
		internal string a()
		{
			int a_ = 16;
			short num = (short)1879624755;
			short num2 = num;
			num = (short)1876020275;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_E2;
			case 1:
				break;
			default:
			{
				num = (short)1208156160;
				short num3 = num;
				break;
			}
			}
			num = (short)940310528;
			if (num != 0)
			{
			}
			string result = null;
			try
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				global::System.Xml.Serialization.XmlSerializerNamespaces xmlSerializerNamespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
				xmlSerializerNamespaces.Add("", "");
				this.x.Serialize(memoryStream, this, xmlSerializerNamespaces);
				result = global::System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
				memoryStream.Close();
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.Exception(global::ASKLib.SystemKeyManager.b("ꓤ듦ꋨ믪鿬胮雰臲铴髶铸鋺鏼飾䤀樂瘄猆昈礊琌⼎爐簒怔笖紘㬚猜瀞唠̢䜤䈦न堪䠬崮堰刲头帶䌸帺夼Ծ慀", a_) + ex.Message);
			}
			IL_E2:
			num = (short)1362034689;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x04000005 RID: 5
		private global::System.Xml.Serialization.XmlSerializer x;
	}
}
