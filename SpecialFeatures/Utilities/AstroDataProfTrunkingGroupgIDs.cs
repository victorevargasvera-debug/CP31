using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Utilities
{
	// Token: 0x02000041 RID: 65
	[global::System.Serializable]
	public class AstroDataProfTrunkingGroupgIDs
	{
		// Token: 0x1700037E RID: 894
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x0006D844 File Offset: 0x0006BA44
		// (set) Token: 0x0600076B RID: 1899 RVA: 0x0006D8F0 File Offset: 0x0006BAF0
		public int Version
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1411713977;
				short num2 = num;
				num = (short)1615203257;
				switch (num2 == num)
				{
				}
				num = (short)1273888769;
				if (num != 0)
				{
				}
				num = (short)1491468288;
				short num3 = num;
				num = (short)1741488128;
				if (num != 0)
				{
				}
				return this.<Version>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)309460993;
				if (num != 0)
				{
				}
				num = (short)1080166170;
				short num2 = num;
				num = (short)1087637274;
				switch (num2 == num)
				{
				}
				num = (short)574488576;
				short num3 = num;
				num = (short)973864960;
				if (num != 0)
				{
				}
				this.<Version>k__BackingField = value;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x0006D9A4 File Offset: 0x0006BBA4
		// (set) Token: 0x0600076D RID: 1901 RVA: 0x0006DA54 File Offset: 0x0006BC54
		public global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Utilities.Astro25DataGroupID> Recset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1947400082;
				short num2 = num;
				num = (short)1738798994;
				switch (num2 == num)
				{
				}
				num = (short)694419457;
				if (num != 0)
				{
				}
				num = (short)343474176;
				short num3 = num;
				num = (short)2003369984;
				if (num != 0)
				{
				}
				return this.<Recset>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1921777665;
				if (num != 0)
				{
				}
				num = (short)501092840;
				short num2 = num;
				num = (short)177279464;
				switch (num2 == num)
				{
				}
				num = (short)98238464;
				short num3 = num;
				num = (short)675610624;
				if (num != 0)
				{
				}
				this.<Recset>k__BackingField = value;
			}
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000027D3 File Offset: 0x000009D3
		internal AstroDataProfTrunkingGroupgIDs()
		{
			this.a = new global::System.Xml.Serialization.XmlSerializer(typeof(global::SpecialFeatures.Utilities.AstroDataProfTrunkingGroupgIDs));
			base..ctor();
			this.Version = 1;
			this.Recset = new global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Utilities.Astro25DataGroupID>();
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0006DB08 File Offset: 0x0006BD08
		public AstroDataProfTrunkingGroupgIDs(string xmlData)
		{
			int a_ = 17;
			this.a = new global::System.Xml.Serialization.XmlSerializer(typeof(global::SpecialFeatures.Utilities.AstroDataProfTrunkingGroupgIDs));
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
					global::SpecialFeatures.Utilities.AstroDataProfTrunkingGroupgIDs astroDataProfTrunkingGroupgIDs = (global::SpecialFeatures.Utilities.AstroDataProfTrunkingGroupgIDs)this.a.Deserialize(xmlReader);
					this.Version = astroDataProfTrunkingGroupgIDs.Version;
					this.Recset = astroDataProfTrunkingGroupgIDs.Recset;
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햓\uda9d솟횡얣\udaa7얩쪫節슯잱\udab3\uddb5톷풹\udbbb尿늿귁뇃뛅꿇菉裋뷍뇑믓ꏕ듗뻙ﳛ냝迟雡쓣蓥跧쫩裫语華韱蛳鿵駷雹闻蓽旿昁␃怅稇攉愋⸍䠏弑堓㘕簗笙栛缝᨟ȡ", a_) + ex.Message);
				}
			}
			else
			{
				this.Version = 1;
				this.Recset = new global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Utilities.Astro25DataGroupID>();
			}
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0006DBEC File Offset: 0x0006BDEC
		internal string ToXML()
		{
			int a_ = 10;
			string result;
			short num;
			for (;;)
			{
				result = null;
				try
				{
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
					global::System.Xml.Serialization.XmlSerializerNamespaces xmlSerializerNamespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
					xmlSerializerNamespaces.Add("", "");
					this.a.Serialize(memoryStream, this, xmlSerializerNamespaces);
					result = global::System.Text.Encoding.UTF8.GetString(memoryStream.ToArray());
					memoryStream.Close();
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("첌ﲎ杖펖ﲜ쾞펠첢쎤\udba8\udeaa쎬쒮\ud8b0\uddb2튴쮸풺좼쾾ꛀ諂臄듆꣊ꋌ뫎뷐럒맖뛘꿚﷜뷞蓠쏢雤苦鯨苪賬菮飰觲郴鏶쏸\udbfa", a_) + ex.Message);
				}
				num = (short)1594228736;
				short num2 = num;
				num = (short)711525299;
				short num3 = num;
				num = (short)68158387;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_D0;
				}
			}
			IL_D0:
			num = (short)4128768;
			if (num != 0)
			{
			}
			num = (short)1738932225;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x040002EB RID: 747
		[global::System.NonSerialized]
		private global::System.Xml.Serialization.XmlSerializer a;
	}
}
