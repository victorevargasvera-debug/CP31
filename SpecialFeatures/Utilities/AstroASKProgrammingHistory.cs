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
	// Token: 0x0200003F RID: 63
	[global::System.Serializable]
	public class AstroASKProgrammingHistory
	{
		// Token: 0x1700037A RID: 890
		// (get) Token: 0x0600075E RID: 1886 RVA: 0x0006D0B8 File Offset: 0x0006B2B8
		// (set) Token: 0x0600075F RID: 1887 RVA: 0x0006D168 File Offset: 0x0006B368
		public int Version
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)378077185;
				if (num != 0)
				{
				}
				num = (short)335670846;
				short num2 = num;
				num = (short)77065790;
				switch (num2 == num)
				{
				}
				num = (short)35454976;
				short num3 = num;
				num = (short)660209664;
				if (num != 0)
				{
				}
				return this.<Version>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)226230273;
				if (num != 0)
				{
				}
				num = (short)1999271779;
				short num2 = num;
				num = (short)852326243;
				switch (num2 == num)
				{
				}
				num = (short)1338834944;
				short num3 = num;
				num = (short)1427374080;
				if (num != 0)
				{
				}
				this.<Version>k__BackingField = value;
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000760 RID: 1888 RVA: 0x0006D218 File Offset: 0x0006B418
		// (set) Token: 0x06000761 RID: 1889 RVA: 0x0006D2C8 File Offset: 0x0006B4C8
		public global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem> Recset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2113994753;
				if (num != 0)
				{
				}
				num = (short)1177883570;
				short num2 = num;
				num = (short)14029746;
				switch (num2 == num)
				{
				}
				num = (short)1125449728;
				short num3 = num;
				num = (short)1705443328;
				if (num != 0)
				{
				}
				return this.<Recset>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)533127558;
				short num2 = num;
				num = (short)1052107142;
				switch (num2 == num)
				{
				}
				num = (short)1507065857;
				if (num != 0)
				{
				}
				num = (short)2099576832;
				short num3 = num;
				num = (short)2114060288;
				if (num != 0)
				{
				}
				this.<Recset>k__BackingField = value;
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x000027A4 File Offset: 0x000009A4
		public AstroASKProgrammingHistory()
		{
			this.a = new global::System.Xml.Serialization.XmlSerializer(typeof(global::SpecialFeatures.Utilities.AstroASKProgrammingHistory));
			base..ctor();
			this.Version = 1;
			this.Recset = new global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem>();
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0006D374 File Offset: 0x0006B574
		public AstroASKProgrammingHistory(string xmlData)
		{
			int a_ = 12;
			this.a = new global::System.Xml.Serialization.XmlSerializer(typeof(global::SpecialFeatures.Utilities.AstroASKProgrammingHistory));
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
					global::SpecialFeatures.Utilities.AstroASKProgrammingHistory astroASKProgrammingHistory = (global::SpecialFeatures.Utilities.AstroASKProgrammingHistory)this.a.Deserialize(xmlReader);
					this.Version = astroASKProgrammingHistory.Version;
					this.Recset = astroASKProgrammingHistory.Recset;
				}
				catch (global::System.Exception ex)
				{
					throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("캎슐\ud892얔ﲚﺞ철캢첤즦캨쒬\udcae얰\udcb2잴캶馸\ud8ba튼쪾귀Ꟃ꧆ꛈ뿊귎듐뇔닖꫘뻚꿜뛞胠迢賤鷦賨迪췬觮菰鳲飴ퟶꇸ뛺뇼\udffe攀戂焄昆㌈⬊", a_) + ex.Message);
				}
			}
			else
			{
				this.Version = 1;
				this.Recset = new global::System.Collections.ObjectModel.Collection<global::SpecialFeatures.Utilities.ASKProgrammingHistoryItem>();
			}
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0006D458 File Offset: 0x0006B658
		internal string ToXML()
		{
			int a_ = 7;
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
					throw new global::System.Exception(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮉\udf8b얍삏ﮓﮙ즟첡쎣솧\ud9a9\ud8ab솭슯쮱钳햵ힷ쾹킻\udabd곁ꯃ닅꣉꧋ꏏ럑ꛓ뿕맗뛙뗛ꓝ藟蛡\udee3웥", a_) + ex.Message);
				}
				num = (short)951844864;
				short num2 = num;
				num = (short)189447128;
				short num3 = num;
				num = (short)513326040;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_CE;
				}
			}
			IL_CE:
			num = (short)1320812544;
			if (num != 0)
			{
			}
			num = (short)1349124097;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x040002E6 RID: 742
		[global::System.NonSerialized]
		private global::System.Xml.Serialization.XmlSerializer a;
	}
}
