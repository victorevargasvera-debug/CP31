using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000081 RID: 129
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class ASTROIndividualIdEditingEventArgs : global::System.EventArgs
	{
		// Token: 0x06000819 RID: 2073 RVA: 0x00060CA8 File Offset: 0x0005EEA8
		public ASTROIndividualIdEditingEventArgs(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem radioSys, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug cp, string modelNumber)
		{
			this.systemObj = radioSys;
			this.cpObj = cp;
			this.TargetModelNumber = modelNumber;
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00060CD0 File Offset: 0x0005EED0
		public global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem ASTRORadioSystem
		{
			get
			{
				short num = (short)994952630;
				short num2 = num;
				num = (short)773899702;
				switch (num2 == num)
				{
				}
				num = (short)671547392;
				short num3 = num;
				num = (short)1107755008;
				if (num != 0)
				{
				}
				num = (short)471924737;
				if (num != 0)
				{
				}
				return this.systemObj;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00060D80 File Offset: 0x0005EF80
		public global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug CodeplugObject
		{
			get
			{
				short num = (short)79866555;
				short num2 = num;
				num = (short)917744315;
				switch (num2 == num)
				{
				}
				num = (short)253689856;
				short num3 = num;
				num = (short)1675886593;
				if (num != 0)
				{
				}
				num = (short)1379729408;
				if (num != 0)
				{
				}
				return this.cpObj;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00060E30 File Offset: 0x0005F030
		// (set) Token: 0x0600081D RID: 2077 RVA: 0x00060EE0 File Offset: 0x0005F0E0
		[global::System.Runtime.Serialization.DataMember]
		public string TargetModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)453416503;
				short num2 = num;
				num = (short)233805367;
				switch (num2 == num)
				{
				}
				num = (short)45219840;
				short num3 = num;
				num = (short)1544224769;
				if (num != 0)
				{
				}
				num = (short)1374486528;
				if (num != 0)
				{
				}
				return this.<TargetModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1477411957;
				short num2 = num;
				num = (short)667518069;
				switch (num2 == num)
				{
				}
				num = (short)488898560;
				short num3 = num;
				num = (short)250150913;
				if (num != 0)
				{
				}
				num = (short)2129657856;
				if (num != 0)
				{
				}
				this.<TargetModelNumber>k__BackingField = value;
			}
		}

		// Token: 0x040000CB RID: 203
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug cpObj;

		// Token: 0x040000CC RID: 204
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem systemObj;
	}
}
