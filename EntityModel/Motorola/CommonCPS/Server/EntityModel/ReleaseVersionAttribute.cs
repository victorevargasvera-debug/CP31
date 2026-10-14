using System;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001B0 RID: 432
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, Inherited = true, AllowMultiple = true)]
	public class ReleaseVersionAttribute : global::System.Attribute
	{
		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x0600167C RID: 5756 RVA: 0x000F1070 File Offset: 0x000EF270
		public global::Motorola.CommonCPS.Server.EntityModel.ReleaseVersionSection ReleaseVersoin
		{
			get
			{
				short num = (short)1578212768;
				short num2 = num;
				num = (short)1562484128;
				switch (num2 == num)
				{
				}
				num = (short)1565589505;
				if (num != 0)
				{
				}
				num = (short)1564344320;
				if (num != 0)
				{
				}
				num = (short)654114816;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x0600167D RID: 5757 RVA: 0x000F111C File Offset: 0x000EF31C
		// (set) Token: 0x0600167E RID: 5758 RVA: 0x000F11D0 File Offset: 0x000EF3D0
		public string Version
		{
			get
			{
				short num = (short)1780613121;
				if (num != 0)
				{
				}
				num = (short)90001953;
				short num2 = num;
				num = (short)1272533537;
				switch (num2 == num)
				{
				}
				num = (short)69140480;
				short num3 = num;
				num = (short)57016320;
				if (num != 0)
				{
				}
				return this.a.ReleaseVersion;
			}
			set
			{
				short num = (short)219869218;
				short num2 = num;
				num = (short)83554338;
				switch (num2 == num)
				{
				}
				num = (short)2022899712;
				if (num != 0)
				{
				}
				num = (short)995098624;
				short num3 = num;
				num = (short)1399193601;
				if (num != 0)
				{
				}
				this.a.ReleaseVersion = value;
			}
		}

		// Token: 0x04000A99 RID: 2713
		private readonly global::Motorola.CommonCPS.Server.EntityModel.ReleaseVersionSection a = new global::Motorola.CommonCPS.Server.EntityModel.ReleaseVersionSection();
	}
}
