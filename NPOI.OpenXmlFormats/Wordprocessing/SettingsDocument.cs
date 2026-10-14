using System;
using System.IO;
using System.Xml;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000053 RID: 83
	public class SettingsDocument
	{
		// Token: 0x0600029A RID: 666 RVA: 0x00004620 File Offset: 0x00002820
		public SettingsDocument()
		{
			this.settings = new global::NPOI.OpenXmlFormats.Wordprocessing.CT_Settings();
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00004633 File Offset: 0x00002833
		public static global::NPOI.OpenXmlFormats.Wordprocessing.SettingsDocument Parse(global::System.Xml.XmlDocument doc, global::System.Xml.XmlNamespaceManager NameSpaceManager)
		{
			return new global::NPOI.OpenXmlFormats.Wordprocessing.SettingsDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Settings.Parse(doc.DocumentElement, NameSpaceManager));
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00004648 File Offset: 0x00002848
		public void Save(global::System.IO.Stream stream)
		{
			using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream))
			{
				this.settings.Write(streamWriter);
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00004684 File Offset: 0x00002884
		public SettingsDocument(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Settings settings)
		{
			this.settings = settings;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600029E RID: 670 RVA: 0x00004693 File Offset: 0x00002893
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Settings Settings
		{
			get
			{
				return this.settings;
			}
		}

		// Token: 0x040001B7 RID: 439
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Settings settings;
	}
}
