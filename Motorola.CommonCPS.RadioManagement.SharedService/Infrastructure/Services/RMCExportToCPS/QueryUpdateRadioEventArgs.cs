using System;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure.Services.RMCExportToCPS
{
	// Token: 0x02000007 RID: 7
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class QueryUpdateRadioEventArgs : global::System.EventArgs
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002618 File Offset: 0x00000818
		public QueryUpdateRadioEventArgs(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> devices, global::System.Collections.ObjectModel.ObservableCollection<bool> isOwnerSystemIDSupported)
		{
			this.devices = devices;
			this.isOwnerSystemIDSupported = isOwnerSystemIDSupported;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000263C File Offset: 0x0000083C
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000026EC File Offset: 0x000008EC
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> Devices
		{
			get
			{
				short num = (short)1952267264;
				short num2 = num;
				num = (short)834354176;
				switch (num2 == num)
				{
				}
				num = (short)1133248512;
				short num3 = num;
				num = (short)1076887553;
				if (num != 0)
				{
				}
				num = (short)535363584;
				if (num != 0)
				{
				}
				return this.devices;
			}
			set
			{
				short num = (short)1708965408;
				short num2 = num;
				num = (short)1286913568;
				switch (num2 == num)
				{
				}
				num = (short)1721892864;
				short num3 = num;
				num = (short)1042415617;
				if (num != 0)
				{
				}
				num = (short)68354048;
				if (num != 0)
				{
				}
				this.devices = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x0000279C File Offset: 0x0000099C
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000284C File Offset: 0x00000A4C
		public global::System.Collections.ObjectModel.ObservableCollection<bool> IsOwnerSystemIDSupported
		{
			get
			{
				short num = (short)1792875943;
				short num2 = num;
				num = (short)656416167;
				switch (num2 == num)
				{
				}
				num = (short)1332805632;
				short num3 = num;
				num = (short)68878337;
				if (num != 0)
				{
				}
				num = (short)585695232;
				if (num != 0)
				{
				}
				return this.isOwnerSystemIDSupported;
			}
			set
			{
				short num = (short)816514103;
				short num2 = num;
				num = (short)1033634871;
				switch (num2 == num)
				{
				}
				num = (short)138543104;
				short num3 = num;
				num = (short)1727594496;
				if (num != 0)
				{
				}
				num = (short)1135869953;
				if (num != 0)
				{
				}
				this.isOwnerSystemIDSupported = value;
			}
		}

		// Token: 0x04000005 RID: 5
		[global::System.Runtime.Serialization.DataMember]
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> devices;

		// Token: 0x04000006 RID: 6
		[global::System.Runtime.Serialization.DataMember]
		private global::System.Collections.ObjectModel.ObservableCollection<bool> isOwnerSystemIDSupported;
	}
}
