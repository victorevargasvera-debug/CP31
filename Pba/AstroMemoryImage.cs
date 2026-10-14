using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000007 RID: 7
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroMemoryImage : global::Motorola.Common.Communication.Pba.RadioImage
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002EF8 File Offset: 0x000010F8
		// (set) Token: 0x06000019 RID: 25 RVA: 0x00002FA8 File Offset: 0x000011A8
		[global::System.Runtime.Serialization.DataMember]
		public string ComponentName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1343559419;
				short num2 = num;
				num = (short)190715643;
				switch (num2 == num)
				{
				}
				num = (short)888274944;
				if (num != 0)
				{
				}
				num = (short)7536641;
				if (num != 0)
				{
				}
				num = (short)729153536;
				short num3 = num;
				return this.<ComponentName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)635033468;
				short num2 = num;
				num = (short)1873663868;
				switch (num2 == num)
				{
				}
				num = (short)230752257;
				if (num != 0)
				{
				}
				num = (short)1708064768;
				if (num != 0)
				{
				}
				num = (short)1382547456;
				short num3 = num;
				this.<ComponentName>k__BackingField = value;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003058 File Offset: 0x00001258
		public AstroMemoryImage()
		{
			base.FilePath = null;
			base.FileType = global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.Unknown;
			this.ComponentName = null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003080 File Offset: 0x00001280
		public AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string filePath, string componentName)
		{
			base.FilePath = filePath;
			base.FileType = fileType;
			this.ComponentName = componentName;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000030A8 File Offset: 0x000012A8
		public AstroMemoryImage(global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string filePath)
		{
			base.FilePath = filePath;
			base.FileType = fileType;
			this.ComponentName = null;
		}
	}
}
