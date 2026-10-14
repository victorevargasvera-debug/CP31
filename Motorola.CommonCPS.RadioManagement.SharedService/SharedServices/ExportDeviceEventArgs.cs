using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000088 RID: 136
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ExportDeviceEventArgs : global::System.EventArgs
	{
		// Token: 0x06000848 RID: 2120 RVA: 0x00062974 File Offset: 0x00060B74
		public ExportDeviceEventArgs(byte[] fileContent, global::Motorola.CommonCPS.Server.CommonDBConstants.FileType fileType, string filePathName, global::Motorola.CommonCPS.Server.EntityModel.Radio rd, bool IsForRestore)
		{
			this.fileContent = fileContent;
			this.filePathName = filePathName;
			this.fileType = fileType;
			this.radio = rd;
			this.IsForRestore = IsForRestore;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000629AC File Offset: 0x00060BAC
		public ExportDeviceEventArgs(byte[] fileContent, global::Motorola.CommonCPS.Server.CommonDBConstants.FileType fileType, string filePathName, global::Motorola.CommonCPS.Server.EntityModel.Radio radio) : this(fileContent, fileType, filePathName, radio, false)
		{
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000629C8 File Offset: 0x00060BC8
		public ExportDeviceEventArgs(byte[] fileContent, string firmwareVersion, global::Motorola.CommonCPS.Server.CommonDBConstants.FileType fileType, string filePathName, global::Motorola.CommonCPS.Server.EntityModel.Radio radio) : this(fileContent, fileType, filePathName, radio)
		{
			this.FirmwareVersion = firmwareVersion;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x000629E8 File Offset: 0x00060BE8
		public byte[] FileContent
		{
			get
			{
				short num = (short)2077137425;
				short num2 = num;
				num = (short)1985452561;
				switch (num2 == num)
				{
				}
				num = (short)1562836992;
				short num3 = num;
				num = (short)736165889;
				if (num != 0)
				{
				}
				num = (short)1435893760;
				if (num != 0)
				{
				}
				return this.fileContent;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600084C RID: 2124 RVA: 0x00062A9C File Offset: 0x00060C9C
		public global::Motorola.CommonCPS.Server.CommonDBConstants.FileType ExportFileType
		{
			get
			{
				short num = (short)2043006095;
				short num2 = num;
				num = (short)406244495;
				switch (num2 == num)
				{
				}
				num = (short)475004928;
				short num3 = num;
				num = (short)1279066112;
				if (num != 0)
				{
				}
				num = (short)1019871233;
				if (num != 0)
				{
				}
				return this.fileType;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00062B4C File Offset: 0x00060D4C
		public string FilePathName
		{
			get
			{
				short num = (short)1357447169;
				if (num != 0)
				{
				}
				num = (short)1107899484;
				short num2 = num;
				num = (short)744764508;
				switch (num2 == num)
				{
				default:
				{
					num = (short)612106240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1073807360;
				if (num != 0)
				{
				}
				return this.filePathName;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600084E RID: 2126 RVA: 0x00062BFC File Offset: 0x00060DFC
		public global::Motorola.CommonCPS.Server.EntityModel.Radio ExportRadio
		{
			get
			{
				short num = (short)103525214;
				short num2 = num;
				num = (short)1501014878;
				switch (num2 == num)
				{
				}
				num = (short)796524544;
				short num3 = num;
				num = (short)1084948481;
				if (num != 0)
				{
				}
				num = (short)1041825792;
				if (num != 0)
				{
				}
				return this.radio;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00062CAC File Offset: 0x00060EAC
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x00062D5C File Offset: 0x00060F5C
		[global::System.Runtime.Serialization.DataMember]
		public bool IsForRestore
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)348344714;
				short num2 = num;
				num = (short)1636716938;
				switch (num2 == num)
				{
				}
				num = (short)1048641536;
				short num3 = num;
				num = (short)836173824;
				if (num != 0)
				{
				}
				num = (short)1382875137;
				if (num != 0)
				{
				}
				return this.<IsForRestore>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1204558924;
				short num2 = num;
				num = (short)858397772;
				switch (num2 == num)
				{
				}
				num = (short)1673854976;
				short num3 = num;
				num = (short)2110062593;
				if (num != 0)
				{
				}
				num = (short)2068119552;
				if (num != 0)
				{
				}
				this.<IsForRestore>k__BackingField = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x00062E0C File Offset: 0x0006100C
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00062EBC File Offset: 0x000610BC
		[global::System.Runtime.Serialization.DataMember]
		public string FirmwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)590280307;
				short num2 = num;
				num = (short)1626601075;
				switch (num2 == num)
				{
				}
				num = (short)1248264192;
				short num3 = num;
				num = (short)1652031488;
				if (num != 0)
				{
				}
				num = (short)107151361;
				if (num != 0)
				{
				}
				return this.<FirmwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1413129381;
				short num2 = num;
				num = (short)1571136677;
				switch (num2 == num)
				{
				}
				num = (short)1829437440;
				short num3 = num;
				num = (short)1781661697;
				if (num != 0)
				{
				}
				num = (short)228982784;
				if (num != 0)
				{
				}
				this.<FirmwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x040000E2 RID: 226
		[global::System.Runtime.Serialization.DataMember]
		private byte[] fileContent;

		// Token: 0x040000E3 RID: 227
		[global::System.Runtime.Serialization.DataMember]
		private string filePathName;

		// Token: 0x040000E4 RID: 228
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.FileType fileType;

		// Token: 0x040000E5 RID: 229
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.EntityModel.Radio radio;
	}
}
