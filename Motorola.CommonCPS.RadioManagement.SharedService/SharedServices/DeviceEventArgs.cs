using System;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000087 RID: 135
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class DeviceEventArgs : global::System.EventArgs
	{
		// Token: 0x06000843 RID: 2115 RVA: 0x00062680 File Offset: 0x00060880
		public DeviceEventArgs(byte[] fileContent, global::Motorola.CommonCPS.Server.EntityModel.Radio device = null, global::Motorola.CommonCPS.Server.EntityModel.Template template = null, string filePathName = null)
		{
			this.fileContent = fileContent;
			this.deviceObj = device;
			this.templateObj = template;
			this.filePathName = filePathName;
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000844 RID: 2116 RVA: 0x000626B0 File Offset: 0x000608B0
		public global::Motorola.CommonCPS.Server.EntityModel.Radio DeviceObj
		{
			get
			{
				short num = (short)1371094276;
				short num2 = num;
				num = (short)1978678532;
				switch (num2 == num)
				{
				}
				num = (short)1058209792;
				short num3 = num;
				num = (short)1858535425;
				if (num != 0)
				{
				}
				num = (short)188088320;
				if (num != 0)
				{
				}
				return this.deviceObj;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00062760 File Offset: 0x00060960
		public global::Motorola.CommonCPS.Server.EntityModel.Template TempalteObj
		{
			get
			{
				short num = (short)308235096;
				short num2 = num;
				num = (short)1004751704;
				switch (num2 == num)
				{
				}
				num = (short)1024720896;
				short num3 = num;
				num = (short)932446209;
				if (num != 0)
				{
				}
				num = (short)904921088;
				if (num != 0)
				{
				}
				return this.templateObj;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x00062810 File Offset: 0x00060A10
		public byte[] FileContent
		{
			get
			{
				short num = (short)1123370186;
				short num2 = num;
				num = (short)219890890;
				switch (num2 == num)
				{
				}
				num = (short)1755774976;
				short num3 = num;
				num = (short)637140992;
				if (num != 0)
				{
				}
				num = (short)556597249;
				if (num != 0)
				{
				}
				return this.fileContent;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x000628C4 File Offset: 0x00060AC4
		public string FilePathName
		{
			get
			{
				short num = (short)320864257;
				if (num != 0)
				{
				}
				num = (short)1122480074;
				short num2 = num;
				num = (short)1486532554;
				switch (num2 == num)
				{
				default:
				{
					num = (short)244121600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)195756032;
				if (num != 0)
				{
				}
				return this.filePathName;
			}
		}

		// Token: 0x040000DE RID: 222
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.EntityModel.Radio deviceObj;

		// Token: 0x040000DF RID: 223
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.EntityModel.Template templateObj;

		// Token: 0x040000E0 RID: 224
		[global::System.Runtime.Serialization.DataMember]
		private byte[] fileContent;

		// Token: 0x040000E1 RID: 225
		[global::System.Runtime.Serialization.DataMember]
		private string filePathName;
	}
}
