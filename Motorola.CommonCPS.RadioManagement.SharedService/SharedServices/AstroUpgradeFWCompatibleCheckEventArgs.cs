using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000085 RID: 133
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroUpgradeFWCompatibleCheckEventArgs : global::System.EventArgs
	{
		// Token: 0x0600082F RID: 2095 RVA: 0x00061994 File Offset: 0x0005FB94
		public AstroUpgradeFWCompatibleCheckEventArgs(string cvnVersion)
		{
			this.cvnHostVersion = cvnVersion;
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x000619B0 File Offset: 0x0005FBB0
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x00061A5C File Offset: 0x0005FC5C
		[global::System.Runtime.Serialization.DataMember]
		public bool IsCompatible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)721616897;
				if (num != 0)
				{
				}
				num = (short)394290312;
				short num2 = num;
				num = (short)1016423560;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1409351680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)281935872;
				if (num != 0)
				{
				}
				return this.<IsCompatible>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)550830081;
				if (num != 0)
				{
				}
				num = (short)538177764;
				short num2 = num;
				num = (short)115142884;
				switch (num2 == num)
				{
				default:
				{
					num = (short)783482880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)962396160;
				if (num != 0)
				{
				}
				this.<IsCompatible>k__BackingField = value;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00061B0C File Offset: 0x0005FD0C
		public string CVNHostVersion
		{
			get
			{
				short num = (short)596379076;
				short num2 = num;
				num = (short)1932723652;
				switch (num2 == num)
				{
				}
				num = (short)988282880;
				short num3 = num;
				num = (short)1249837057;
				if (num != 0)
				{
				}
				num = (short)30867456;
				if (num != 0)
				{
				}
				return this.cvnHostVersion;
			}
		}

		// Token: 0x040000D4 RID: 212
		[global::System.Runtime.Serialization.DataMember]
		private string cvnHostVersion;
	}
}
