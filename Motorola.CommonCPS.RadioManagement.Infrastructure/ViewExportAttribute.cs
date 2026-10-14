using System;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000031 RID: 49
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple = false)]
	[global::System.ComponentModel.Composition.MetadataAttribute]
	public sealed class ViewExportAttribute : global::System.ComponentModel.Composition.ExportAttribute, global::Motorola.CommonCPS.RadioManagement.Infrastructure.IViewRegionRegistration
	{
		// Token: 0x060000BA RID: 186 RVA: 0x0000D000 File Offset: 0x0000B200
		public ViewExportAttribute() : base(typeof(object))
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000D020 File Offset: 0x0000B220
		public ViewExportAttribute(string viewName) : base(viewName, typeof(object))
		{
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000D040 File Offset: 0x0000B240
		public string ViewName
		{
			get
			{
				short num = (short)697293655;
				short num2 = num;
				num = (short)69983063;
				switch (num2 == num)
				{
				}
				num = (short)1894121473;
				if (num != 0)
				{
				}
				num = (short)1954152448;
				if (num != 0)
				{
				}
				num = (short)754581504;
				short num3 = num;
				return base.ContractName;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000D0F0 File Offset: 0x0000B2F0
		// (set) Token: 0x060000BE RID: 190 RVA: 0x0000D1A0 File Offset: 0x0000B3A0
		public string RegionName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)887158893;
				short num2 = num;
				num = (short)1157822573;
				switch (num2 == num)
				{
				}
				num = (short)1261568000;
				if (num != 0)
				{
				}
				num = (short)819986433;
				if (num != 0)
				{
				}
				num = (short)1158152192;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)402876415;
				short num2 = num;
				num = (short)1053583359;
				switch (num2 == num)
				{
				}
				num = (short)1657929729;
				if (num != 0)
				{
				}
				num = (short)688193536;
				if (num != 0)
				{
				}
				num = (short)695533568;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x0400003F RID: 63
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
