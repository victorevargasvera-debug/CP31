using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000A4 RID: 164
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class GenerateLicenseFilterEventArgs : global::System.EventArgs
	{
		// Token: 0x060009ED RID: 2541 RVA: 0x000750C0 File Offset: 0x000732C0
		public GenerateLicenseFilterEventArgs(global::System.Collections.Generic.IList<string> selectedlicenseGroup)
		{
			this.SelectedlicenseGroup = selectedlicenseGroup;
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x000750DC File Offset: 0x000732DC
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x00075190 File Offset: 0x00073390
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.IList<string> SelectedlicenseGroup
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)468053274;
				short num2 = num;
				num = (short)2117135642;
				switch (num2 == num)
				{
				}
				num = (short)655687680;
				short num3 = num;
				num = (short)377946112;
				if (num != 0)
				{
				}
				num = (short)2112487425;
				if (num != 0)
				{
				}
				return this.<SelectedlicenseGroup>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1172991893;
				short num2 = num;
				num = (short)854355861;
				switch (num2 == num)
				{
				}
				num = (short)2140143616;
				short num3 = num;
				num = (short)2006515713;
				if (num != 0)
				{
				}
				num = (short)1899560960;
				if (num != 0)
				{
				}
				this.<SelectedlicenseGroup>k__BackingField = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x00075244 File Offset: 0x00073444
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x000752F4 File Offset: 0x000734F4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.MatrixRadioFeatureFilter LicenseFilter
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1925959662;
				short num2 = num;
				num = (short)676384750;
				switch (num2 == num)
				{
				}
				num = (short)843448320;
				short num3 = num;
				num = (short)1274871809;
				if (num != 0)
				{
				}
				num = (short)1359675392;
				if (num != 0)
				{
				}
				return this.<LicenseFilter>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)513742887;
				short num2 = num;
				num = (short)723392551;
				switch (num2 == num)
				{
				}
				num = (short)543555584;
				short num3 = num;
				num = (short)1846804481;
				if (num != 0)
				{
				}
				num = (short)1262288896;
				if (num != 0)
				{
				}
				this.<LicenseFilter>k__BackingField = value;
			}
		}
	}
}
