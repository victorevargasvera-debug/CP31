using System;
using System.Runtime.CompilerServices;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200000F RID: 15
	public abstract class CommandBase : global::Motorola.CommonCPS.RadioManagement.Command.BatchJobCommandBase
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00006848 File Offset: 0x00004A48
		protected CommandBase() : base(global::Motorola.CommonCPS.RadioManagement.BatchOp.BatchOpManager.Instance)
		{
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000047 RID: 71 RVA: 0x0000686C File Offset: 0x00004A6C
		public virtual global::Motorola.CommonCPS.RadioManagement.Command.IInternalInstances InternalInstances
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1861353472;
				short num2 = num;
				num = (short)1239776276;
				short num3 = num;
				num = (short)1874361364;
				switch (num3 == num)
				{
				}
				num = (short)936378369;
				if (num != 0)
				{
				}
				num = (short)1519321088;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000691C File Offset: 0x00004B1C
		protected global::Motorola.CommonCPS.RadioManagement.InteractionHelper.IInteraction Interaction
		{
			get
			{
				short num = (short)1394081792;
				short num2 = num;
				num = (short)1992556545;
				if (num != 0)
				{
				}
				num = (short)769819751;
				short num3 = num;
				num = (short)1933345895;
				switch (num3 == num)
				{
				}
				num = (short)1457979392;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Command.IInternalInstances internalInstances = this.InternalInstances;
				if (internalInstances == null)
				{
					return null;
				}
				return internalInstances.Interaction;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000049 RID: 73 RVA: 0x000069DC File Offset: 0x00004BDC
		protected global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService LocalService
		{
			get
			{
				short num = (short)764936192;
				short num2 = num;
				num = (short)1588230130;
				short num3 = num;
				num = (short)172259314;
				switch (num3 == num)
				{
				}
				num = (short)1777664001;
				if (num != 0)
				{
				}
				num = (short)1309343744;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Command.IInternalInstances internalInstances = this.InternalInstances;
				if (internalInstances == null)
				{
					return null;
				}
				return internalInstances.LocalService;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00006A9C File Offset: 0x00004C9C
		protected global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService ASTROLocalService
		{
			get
			{
				short num = (short)1852375040;
				short num2 = num;
				num = (short)501088257;
				if (num != 0)
				{
				}
				num = (short)2102924010;
				short num3 = num;
				num = (short)1766593258;
				switch (num3 == num)
				{
				}
				num = (short)1257242624;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Command.IInternalInstances internalInstances = this.InternalInstances;
				if (internalInstances == null)
				{
					return null;
				}
				return internalInstances.AstroLocalService;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004B RID: 75 RVA: 0x00006B58 File Offset: 0x00004D58
		protected global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase UIValidateService
		{
			get
			{
				short num = (short)1605828608;
				short num2 = num;
				num = (short)254017537;
				if (num != 0)
				{
				}
				num = (short)1447884257;
				short num3 = num;
				num = (short)935523809;
				switch (num3 == num)
				{
				}
				num = (short)857735168;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Command.IInternalInstances internalInstances = this.InternalInstances;
				if (internalInstances == null)
				{
					return null;
				}
				return internalInstances.UiValidateService;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00006C14 File Offset: 0x00004E14
		protected global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier ViewCacheNotifier
		{
			get
			{
				short num = (short)276889600;
				short num2 = num;
				num = (short)1580391537;
				short num3 = num;
				num = (short)260562033;
				switch (num3 == num)
				{
				}
				num = (short)1537671169;
				if (num != 0)
				{
				}
				num = (short)1419902976;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.LocalService.ViewCacheNotifier.Instance;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00006CC0 File Offset: 0x00004EC0
		protected static global::Motorola.Common.LogUtility.ILog Logger
		{
			get
			{
				short num = (short)454409733;
				short num2 = num;
				num = (short)2002763269;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_FB:
					num = (short)1482883073;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)572325889;
					if (num != 0)
					{
					}
					num = (short)545718272;
					if (num != 0)
					{
					}
					num = (short)1015349248;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					case 1:
						goto IL_110;
					case 2:
						goto IL_C0;
					}
					IL_A5:
					if (global::Motorola.CommonCPS.RadioManagement.Command.CommandBase.b != null)
					{
						goto IL_112;
					}
					num = (short)1914634242;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_C0:
				num = (short)1397358592;
				short num4 = num;
				global::Motorola.CommonCPS.RadioManagement.Command.CommandBase.b = global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName);
				goto IL_FB;
				IL_110:
				IL_112:
				return global::Motorola.CommonCPS.RadioManagement.Command.CommandBase.b;
			}
		}

		// Token: 0x04000016 RID: 22
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.RadioManagement.Command.IInternalInstances a = new global::Motorola.CommonCPS.RadioManagement.Command.InternalInstances();

		// Token: 0x04000017 RID: 23
		private static global::Motorola.Common.LogUtility.ILog b;
	}
}
