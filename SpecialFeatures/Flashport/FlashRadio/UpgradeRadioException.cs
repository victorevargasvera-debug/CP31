using System;
using System.Runtime.Serialization;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000E9 RID: 233
	[global::System.Serializable]
	public sealed class UpgradeRadioException : global::System.Exception, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06000DD7 RID: 3543 RVA: 0x00002D72 File Offset: 0x00000F72
		public UpgradeRadioException(string message) : base(message)
		{
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0000313F File Offset: 0x0000133F
		internal UpgradeRadioException(string message, string details) : this(message, details, null)
		{
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x00002D86 File Offset: 0x00000F86
		internal UpgradeRadioException(string message, global::System.Exception innerException) : base(message, innerException)
		{
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x00130DA8 File Offset: 0x0012EFA8
		internal UpgradeRadioException(string message, string details, global::System.Exception innerException)
		{
			int a_ = 9;
			base..ctor(message, innerException);
			this.Data.Add(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("좋ﶓ歹", a_), details);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x00002D90 File Offset: 0x00000F90
		internal UpgradeRadioException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000DDC RID: 3548 RVA: 0x00130DE0 File Offset: 0x0012EFE0
		internal string Details
		{
			get
			{
				int a_ = 19;
				short num = (short)1961230337;
				if (num != 0)
				{
				}
				num = (short)73403631;
				short num2 = num;
				num = (short)1035341039;
				switch (num2 == num)
				{
				}
				num = (short)709623808;
				short num3 = num;
				num = (short)483852288;
				if (num != 0)
				{
				}
				return this.Data[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튕ﶗﶛ첟톡", a_)] as string;
			}
		}
	}
}
