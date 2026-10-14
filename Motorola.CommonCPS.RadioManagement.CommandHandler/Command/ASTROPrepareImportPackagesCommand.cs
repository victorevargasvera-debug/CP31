using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000BF RID: 191
	internal class ASTROPrepareImportPackagesCommand : global::Motorola.CommonCPS.RadioManagement.Command.PrepareImportPackagesCommand
	{
		// Token: 0x06000406 RID: 1030 RVA: 0x00043778 File Offset: 0x00041978
		private bool a(global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType A_0)
		{
			short num = (short)252706816;
			short num2 = num;
			num = (short)1605519374;
			short num3 = num;
			num = (short)1077889038;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1233846273;
				if (num != 0)
				{
				}
				num = (short)931594240;
				if (num != 0)
				{
				}
				if (A_0 != global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Firmware)
				{
					return false;
				}
				break;
			}
			return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ProductFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00043838 File Offset: 0x00041A38
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)2064893062;
			short num2 = num;
			num = (short)1452721286;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_88:
				switch (0)
				{
				case 0:
					goto IL_A8;
				}
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)592379904;
				short num3 = num;
				goto IL_5E;
			}
			}
			int num4;
			for (;;)
			{
				IL_92:
				switch (num4)
				{
				case 0:
					goto IL_88;
				case 1:
					num = (short)1213399043;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return false;
				case 3:
					if (this.a((global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType)paras[0]))
					{
						num = (short)598016001;
						if (num != 0)
						{
						}
						num = (short)2115239938;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_133;
				}
				goto IL_A8;
			}
			return false;
			IL_5E:
			num = (short)26935296;
			if (num != 0)
			{
			}
			num = (short)1769799680;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_92;
			IL_A8:
			if (paras.Any<object>())
			{
				num = (short)692781057;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_92;
			}
			IL_133:
			return base.CanExecute(paras);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00043980 File Offset: 0x00041B80
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1807810560;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 1:
				{
					num = (short)64880640;
					short num3 = num;
					num = (short)1367474185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					string[] array;
					global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportASTROFrimwareBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportASTROFrimwareBatchOp(new global::System.Collections.Generic.List<string>(array));
					base.ExecuteBatchOp<string>(op);
					num = (short)422313991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					bool flag = (global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType)paras[0] != global::Motorola.CommonCPS.Server.CommonDBConstants.PackageType.Firmware;
					base.ExecuteCmd(paras);
					if (!flag)
					{
						num = (short)1045626888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24C;
				}
				case 4:
				{
					string[] array;
					if (array != null)
					{
						num = (short)247332874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24C;
				}
				case 5:
					goto IL_1D5;
				case 6:
				{
					string[] array;
					if (array.Length == 0)
					{
						goto IL_191;
					}
					num = (short)578385609;
					short num4 = num;
					num = (short)1157527241;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_201;
					default:
						num = (short)1660289024;
						if (num != 0)
						{
						}
						num = (short)1772224514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					goto IL_201;
				case 8:
				{
					string[] array = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowFolderBrowserDialogForImportAstroFWs();
					num = (short)266797060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					if (paras.Count<object>() <= 0)
					{
						num = (short)633470981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)575668227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)1314717702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_51:
				if (paras == null)
				{
					break;
				}
				num = (short)1709113345;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_162:
			num = (short)964755457;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException();
			IL_191:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SERVER_PACKAGE_NOT_FOUND);
			IL_1D5:
			goto IL_162;
			IL_201:
			IL_24C:
			return true;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00043BF4 File Offset: 0x00041DF4
		// Note: this type is marked as 'beforefieldinit'.
		static ASTROPrepareImportPackagesCommand()
		{
			short num = (short)525860864;
			short num2 = num;
			num = (short)601575781;
			short num3 = num;
			num = (short)435769701;
			switch (num3 == num)
			{
			}
			num = (short)781975553;
			if (num != 0)
			{
			}
			num = (short)1297612800;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Command.ASTROPrepareImportPackagesCommand.a = string.Empty;
		}

		// Token: 0x040000C7 RID: 199
		private static string a;
	}
}
