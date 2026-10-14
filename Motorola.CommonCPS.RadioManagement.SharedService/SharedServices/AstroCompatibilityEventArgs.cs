using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000077 RID: 119
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class AstroCompatibilityEventArgs : global::System.EventArgs
	{
		// Token: 0x060007D8 RID: 2008 RVA: 0x0005E554 File Offset: 0x0005C754
		public AstroCompatibilityEventArgs(global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug deviceCpObj, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate templateCpObj, string targetModelnumber)
		{
			this.workingCp = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.Clone<global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug>(deviceCpObj);
			this.templateCp = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.Clone<global::Motorola.CommonCPS.Server.EntityModel.APXTemplate>(templateCpObj);
			this.TargetModelnumber = targetModelnumber;
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x0005E588 File Offset: 0x0005C788
		public global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug DeviceCodeplug
		{
			get
			{
				short num = (short)118751232;
				short num2 = num;
				num = (short)656871712;
				short num3 = num;
				num = (short)1370820896;
				switch (num3 == num)
				{
				}
				num = (short)93257729;
				if (num != 0)
				{
				}
				num = (short)1563688960;
				if (num != 0)
				{
				}
				return this.workingCp;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x0005E634 File Offset: 0x0005C834
		public global::Motorola.CommonCPS.Server.EntityModel.APXTemplate TemplateCodeplug
		{
			get
			{
				short num = (short)1585184768;
				short num2 = num;
				num = (short)284033025;
				if (num != 0)
				{
				}
				num = (short)1308124488;
				short num3 = num;
				num = (short)1682400584;
				switch (num3 == num)
				{
				}
				num = (short)1867972608;
				if (num != 0)
				{
				}
				return this.templateCp;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060007DB RID: 2011 RVA: 0x0005E6E4 File Offset: 0x0005C8E4
		// (set) Token: 0x060007DC RID: 2012 RVA: 0x0005E794 File Offset: 0x0005C994
		[global::System.Runtime.Serialization.DataMember]
		public string TargetModelnumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)326565888;
				short num2 = num;
				num = (short)132962832;
				short num3 = num;
				num = (short)949738000;
				switch (num3 == num)
				{
				}
				num = (short)1508376577;
				if (num != 0)
				{
				}
				num = (short)888012800;
				if (num != 0)
				{
				}
				return this.<TargetModelnumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1734017024;
				short num2 = num;
				num = (short)1853263971;
				short num3 = num;
				num = (short)2062323811;
				switch (num3 == num)
				{
				}
				num = (short)1441726465;
				if (num != 0)
				{
				}
				num = (short)1711341568;
				if (num != 0)
				{
				}
				this.<TargetModelnumber>k__BackingField = value;
			}
		}

		// Token: 0x040000AC RID: 172
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug workingCp;

		// Token: 0x040000AD RID: 173
		[global::System.Runtime.Serialization.DataMember]
		private global::Motorola.CommonCPS.Server.EntityModel.APXTemplate templateCp;
	}
}
