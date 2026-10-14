using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace AcpFileHandlerLib
{
	// Token: 0x02000008 RID: 8
	[global::System.Serializable]
	public class AcpFileHeader : global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00007664 File Offset: 0x00005864
		public AcpFileHeader()
		{
			this.modelNumber = string.Empty;
			this.serialNumber = string.Empty;
			this.flashCode = string.Empty;
			this.versionNumber = string.Empty;
			this.fileInfo = string.Empty;
			base..ctor();
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000076B0 File Offset: 0x000058B0
		// (set) Token: 0x0600004E RID: 78 RVA: 0x00007760 File Offset: 0x00005960
		public string ModelNumber
		{
			get
			{
				short num = (short)2085287663;
				short num2 = num;
				num = (short)1475933935;
				switch (num2 == num)
				{
				}
				num = (short)406519809;
				if (num != 0)
				{
				}
				num = (short)1944322048;
				if (num != 0)
				{
				}
				num = (short)1871249408;
				short num3 = num;
				return this.modelNumber;
			}
			set
			{
				short num = (short)740916806;
				short num2 = num;
				num = (short)1660714566;
				switch (num2 == num)
				{
				}
				num = (short)1477050369;
				if (num != 0)
				{
				}
				num = (short)223870976;
				if (num != 0)
				{
				}
				num = (short)132448256;
				short num3 = num;
				this.modelNumber = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00007814 File Offset: 0x00005A14
		// (set) Token: 0x06000050 RID: 80 RVA: 0x000078C0 File Offset: 0x00005AC0
		public string SerialNumber
		{
			get
			{
				short num = (short)610992129;
				if (num != 0)
				{
				}
				num = (short)989760192;
				short num2 = num;
				num = (short)1123257024;
				switch (num2 == num)
				{
				}
				num = (short)1649606656;
				if (num != 0)
				{
				}
				num = (short)1984364544;
				short num3 = num;
				return this.serialNumber;
			}
			set
			{
				short num = (short)332595201;
				if (num != 0)
				{
				}
				num = (short)1235952800;
				short num2 = num;
				num = (short)184362144;
				switch (num2 == num)
				{
				}
				num = (short)1958871040;
				if (num != 0)
				{
				}
				num = (short)133824512;
				short num3 = num;
				this.serialNumber = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000051 RID: 81 RVA: 0x00007970 File Offset: 0x00005B70
		// (set) Token: 0x06000052 RID: 82 RVA: 0x00007A1C File Offset: 0x00005C1C
		public string FlashCode
		{
			get
			{
				short num = (short)1103054986;
				short num2 = num;
				num = (short)615401610;
				switch (num2 == num)
				{
				}
				num = (short)1842937856;
				if (num != 0)
				{
				}
				num = (short)196542465;
				if (num != 0)
				{
				}
				num = (short)1439498240;
				short num3 = num;
				return this.flashCode;
			}
			set
			{
				short num = (short)1188805589;
				short num2 = num;
				num = (short)1368374229;
				switch (num2 == num)
				{
				}
				num = (short)169672705;
				if (num != 0)
				{
				}
				num = (short)1134231552;
				if (num != 0)
				{
				}
				num = (short)1583677440;
				short num3 = num;
				this.flashCode = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000053 RID: 83 RVA: 0x00007ACC File Offset: 0x00005CCC
		// (set) Token: 0x06000054 RID: 84 RVA: 0x00007B7C File Offset: 0x00005D7C
		public string VersionNumber
		{
			get
			{
				short num = (short)1927949449;
				short num2 = num;
				num = (short)558771337;
				switch (num2 == num)
				{
				}
				num = (short)1846738945;
				if (num != 0)
				{
				}
				num = (short)498663424;
				if (num != 0)
				{
				}
				num = (short)2118385664;
				short num3 = num;
				return this.versionNumber;
			}
			set
			{
				short num = (short)726973594;
				short num2 = num;
				num = (short)1129888922;
				switch (num2 == num)
				{
				}
				num = (short)1605632001;
				if (num != 0)
				{
				}
				num = (short)269942784;
				if (num != 0)
				{
				}
				num = (short)2101149696;
				short num3 = num;
				this.versionNumber = value;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00007C2C File Offset: 0x00005E2C
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00007CD8 File Offset: 0x00005ED8
		public string FileInfo
		{
			get
			{
				short num = (short)232652821;
				short num2 = num;
				num = (short)1122631701;
				switch (num2 == num)
				{
				}
				num = (short)297598977;
				if (num != 0)
				{
				}
				num = (short)356450304;
				if (num != 0)
				{
				}
				num = (short)280821760;
				short num3 = num;
				return this.fileInfo;
			}
			set
			{
				short num = (short)962712234;
				short num2 = num;
				num = (short)1238225578;
				switch (num2 == num)
				{
				}
				num = (short)908197888;
				if (num != 0)
				{
				}
				num = (short)1103822849;
				if (num != 0)
				{
				}
				num = (short)1732575232;
				short num3 = num;
				this.fileInfo = value;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00007D8C File Offset: 0x00005F8C
		[global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityAction.Demand, SerializationFormatter = true)]
		public virtual void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 0;
			if (info == null)
			{
				short num = (short)1768629299;
				short num2 = num;
				num = (short)2142643251;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)855441409;
					if (num != 0)
					{
					}
					num = (short)1317339136;
					if (num != 0)
					{
					}
					num = (short)625213440;
					short num3 = num;
					throw new global::System.ArgumentNullException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("뛞迠藢諤", a_));
				}
				}
			}
			info.AddValue(global::AcpFileHandlerLib.AcpSaveFileDialog.b("鋞軠蟢胤详짨ꗪ飬苮鏰雲蟴", a_), this.modelNumber);
			info.AddValue(global::AcpFileHandlerLib.AcpSaveFileDialog.b("賞蓠釢賤蛦藨쯪ꏬ髮鳰釲郴藶", a_), this.serialNumber);
			info.AddValue(global::AcpFileHandlerLib.AcpSaveFileDialog.b("駞跠苢雤迦짨꣪苬诮铰", a_), this.flashCode);
			info.AddValue(global::AcpFileHandlerLib.AcpSaveFileDialog.b("觞蓠釢雤軦蛨藪췬ꇮ蓰黲韴鋶诸", a_), this.versionNumber);
			info.AddValue(global::AcpFileHandlerLib.AcpSaveFileDialog.b("駞裠迢胤쟦ꃨ藪诬胮菰黲铴菶郸铺鏼", a_), this.fileInfo);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00007EDC File Offset: 0x000060DC
		protected AcpFileHeader(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 18;
			this.modelNumber = string.Empty;
			this.serialNumber = string.Empty;
			this.flashCode = string.Empty;
			this.versionNumber = string.Empty;
			this.fileInfo = string.Empty;
			base..ctor();
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::AcpFileHandlerLib.AcpSaveFileDialog.b("飰鷲鏴飶", a_));
			}
			this.modelNumber = info.GetString(global::AcpFileHandlerLib.AcpSaveFileDialog.b("볰鳲釴鋶闸\udbfa돼諾氀愂怄甆", a_));
			this.serialNumber = info.GetString(global::AcpFileHandlerLib.AcpSaveFileDialog.b("ꋰ雲蟴黶飸韺\uddfc뇾琀渂朄戆笈", a_));
			this.flashCode = info.GetString(global::AcpFileHandlerLib.AcpSaveFileDialog.b("런鿲铴蓶釸\udbfa뻼郾攀昂", a_));
			this.versionNumber = info.GetString(global::AcpFileHandlerLib.AcpSaveFileDialog.b("꟰雲蟴蓶郸铺鏼\udffe伀瘂栄攆氈礊", a_));
			this.fileInfo = info.GetString(global::AcpFileHandlerLib.AcpSaveFileDialog.b("런髲駴鋶\ud9f8닺鏼駾渀焂栄昆紈戊戌愎", a_));
		}

		// Token: 0x04000012 RID: 18
		private string modelNumber;

		// Token: 0x04000013 RID: 19
		private string serialNumber;

		// Token: 0x04000014 RID: 20
		private string flashCode;

		// Token: 0x04000015 RID: 21
		private string versionNumber;

		// Token: 0x04000016 RID: 22
		private string fileInfo;
	}
}
