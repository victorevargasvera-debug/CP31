using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000089 RID: 137
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ExportDVRSEventArgs : global::System.EventArgs
	{
		// Token: 0x06000853 RID: 2131 RVA: 0x00062F6C File Offset: 0x0006116C
		public ExportDVRSEventArgs(byte[] fileContent, string filePathName)
		{
			this.fileContent = fileContent;
			this.filePathName = filePathName;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000854 RID: 2132 RVA: 0x00062F90 File Offset: 0x00061190
		public byte[] FileContent
		{
			get
			{
				short num = (short)996270999;
				short num2 = num;
				num = (short)1835000727;
				switch (num2 == num)
				{
				}
				num = (short)1289420800;
				if (num != 0)
				{
				}
				num = (short)354287616;
				short num3 = num;
				num = (short)1169358849;
				if (num != 0)
				{
				}
				return this.fileContent;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0006303C File Offset: 0x0006123C
		public string FilePathName
		{
			get
			{
				short num = (short)561643521;
				if (num != 0)
				{
				}
				num = (short)392912516;
				short num2 = num;
				num = (short)1059675780;
				switch (num2 == num)
				{
				}
				num = (short)441778176;
				short num3 = num;
				num = (short)2028929024;
				if (num != 0)
				{
				}
				return this.filePathName;
			}
		}

		// Token: 0x040000E8 RID: 232
		[global::System.Runtime.Serialization.DataMember]
		private byte[] fileContent;

		// Token: 0x040000E9 RID: 233
		[global::System.Runtime.Serialization.DataMember]
		private string filePathName;
	}
}
