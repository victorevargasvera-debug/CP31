using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x0200000E RID: 14
	[global::System.Serializable]
	public class FileItem
	{
		// Token: 0x0600004B RID: 75 RVA: 0x000052E0 File Offset: 0x000034E0
		public FileItem()
		{
			this.PartionID = 0;
			this.FilePath = string.Empty;
			this.FileSize = 0;
			this.FileContent = null;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005314 File Offset: 0x00003514
		public FileItem(ushort partionID, string filePath, int fileSize, byte[] fileContent, string uri = null, string name = null)
		{
			this.PartionID = partionID;
			this.FilePath = filePath;
			this.FileSize = fileSize;
			this.FileContent = fileContent;
			this.URI = uri;
			this.Name = name;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00005354 File Offset: 0x00003554
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00005408 File Offset: 0x00003608
		[global::System.Xml.Serialization.XmlAttribute("PartionID")]
		public ushort PartionID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)157395002;
				short num2 = num;
				num = (short)257140794;
				switch (num2 == num)
				{
				}
				num = (short)1438711808;
				short num3 = num;
				num = (short)857210881;
				if (num != 0)
				{
				}
				num = (short)709230592;
				if (num != 0)
				{
				}
				return this.<PartionID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1196048781;
				short num2 = num;
				num = (short)1274691981;
				switch (num2 == num)
				{
				}
				num = (short)427098112;
				short num3 = num;
				num = (short)291504129;
				if (num != 0)
				{
				}
				num = (short)439222272;
				if (num != 0)
				{
				}
				this.<PartionID>k__BackingField = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004F RID: 79 RVA: 0x000054B8 File Offset: 0x000036B8
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00005564 File Offset: 0x00003764
		[global::System.Xml.Serialization.XmlAttribute("SizeInBytes")]
		public int FileSize
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)688962535;
				short num2 = num;
				num = (short)191085543;
				switch (num2 == num)
				{
				}
				num = (short)1585905664;
				short num3 = num;
				num = (short)763035649;
				if (num != 0)
				{
				}
				num = (short)1173487616;
				if (num != 0)
				{
				}
				return this.<FileSize>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1747153227;
				short num2 = num;
				num = (short)1252356427;
				switch (num2 == num)
				{
				}
				num = (short)2076901376;
				short num3 = num;
				num = (short)1354301440;
				if (num != 0)
				{
				}
				num = (short)569376769;
				if (num != 0)
				{
				}
				this.<FileSize>k__BackingField = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00005614 File Offset: 0x00003814
		// (set) Token: 0x06000052 RID: 82 RVA: 0x000056C4 File Offset: 0x000038C4
		[global::System.Xml.Serialization.XmlAttribute("Path")]
		public string FilePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1910936592;
				short num2 = num;
				num = (short)1731630096;
				switch (num2 == num)
				{
				}
				num = (short)1422393344;
				short num3 = num;
				num = (short)2057895937;
				if (num != 0)
				{
				}
				num = (short)964886528;
				if (num != 0)
				{
				}
				return this.<FilePath>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)740665151;
				short num2 = num;
				num = (short)885761855;
				switch (num2 == num)
				{
				}
				num = (short)1031077888;
				short num3 = num;
				num = (short)922222592;
				if (num != 0)
				{
				}
				num = (short)675741697;
				if (num != 0)
				{
				}
				this.<FilePath>k__BackingField = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00005774 File Offset: 0x00003974
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00005824 File Offset: 0x00003A24
		[global::System.Xml.Serialization.XmlElement("Content")]
		public byte[] FileContent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1680735890;
				short num2 = num;
				num = (short)1279131282;
				switch (num2 == num)
				{
				}
				num = (short)1730019328;
				short num3 = num;
				num = (short)747700225;
				if (num != 0)
				{
				}
				num = (short)1115684864;
				if (num != 0)
				{
				}
				return this.<FileContent>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1153832026;
				short num2 = num;
				num = (short)1760957530;
				switch (num2 == num)
				{
				}
				num = (short)597491712;
				short num3 = num;
				num = (short)1052114944;
				if (num != 0)
				{
				}
				num = (short)431357953;
				if (num != 0)
				{
				}
				this.<FileContent>k__BackingField = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000055 RID: 85 RVA: 0x000058D8 File Offset: 0x00003AD8
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00005984 File Offset: 0x00003B84
		[global::System.Xml.Serialization.XmlAttribute("Name")]
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1872720751;
				short num2 = num;
				num = (short)662729583;
				switch (num2 == num)
				{
				}
				num = (short)603717632;
				short num3 = num;
				num = (short)1635319808;
				if (num != 0)
				{
				}
				num = (short)136577025;
				if (num != 0)
				{
				}
				return this.<Name>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1026534690;
				short num2 = num;
				num = (short)246656290;
				switch (num2 == num)
				{
				}
				num = (short)583729152;
				short num3 = num;
				num = (short)1209204736;
				if (num != 0)
				{
				}
				num = (short)1595604993;
				if (num != 0)
				{
				}
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x04000026 RID: 38
		[global::System.Xml.Serialization.XmlAttribute("URI")]
		[global::System.Runtime.Serialization.OptionalField]
		public string URI;
	}
}
