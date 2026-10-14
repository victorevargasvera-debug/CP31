using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000057 RID: 87
	public class ASTROModifyCodeplugPasswordCommand : global::Motorola.CommonCPS.RadioManagement.Command.ModifyCodeplugPasswordCommand
	{
		// Token: 0x060002D2 RID: 722 RVA: 0x00029D08 File Offset: 0x00027F08
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)2091057152;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROModifyCodeplugPasswordContext astromodifyCodeplugPasswordContext;
				global::Motorola.CommonCPS.Server.EntityModel.ASTROPasswordInfo astropasswordInfo;
				object obj;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_125;
					case 1:
						IL_87:
						astromodifyCodeplugPasswordContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROModifyCodeplugPasswordContext);
						astropasswordInfo = new global::Motorola.CommonCPS.Server.EntityModel.ASTROPasswordInfo();
						astropasswordInfo.CodeplugPasswordForValidate = astromodifyCodeplugPasswordContext.OldPasswordForValidate;
						astropasswordInfo.PasswordPerDevice = astromodifyCodeplugPasswordContext.PasswordPerDevice;
						astropasswordInfo.PasswordPolicy = this.a(astromodifyCodeplugPasswordContext);
						num = (short)923009031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						astropasswordInfo.CodeplugPasswordForWrite = string.Empty;
						num = (short)1591017475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_14E;
					case 4:
						if (obj == null)
						{
							num = (short)1664417793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return obj;
					case 5:
						num = (short)667877382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (astropasswordInfo.PasswordPolicy == global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None)
						{
							num = (short)577110018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C;
					case 7:
						num = (short)2062417921;
						if (num != 0)
						{
						}
						if (astropasswordInfo.PasswordPerDevice)
						{
							num = (short)368246789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C;
					}
					goto IL_4F;
					IL_8C:
					num = (short)723089634;
					short num3 = num;
					num = (short)2137356514;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_87;
					default:
					{
						num = (short)1037959168;
						if (num != 0)
						{
						}
						astropasswordInfo.CodeplugPasswordForWrite = astromodifyCodeplugPasswordContext.NewRadioPassword;
						num = (short)1889009664;
						short num4 = num;
						num = (short)1021313024;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_125:
				IL_14E:
				astropasswordInfo.Id = astromodifyCodeplugPasswordContext.ID.Value;
				return base.UpdatePassword(astromodifyCodeplugPasswordContext, astropasswordInfo);
				IL_4F:
				obj = base.ExecuteCmd(paras);
				num = (short)1272709124;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00029F60 File Offset: 0x00028160
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1013645318;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROModifyCodeplugPasswordContext astromodifyCodeplugPasswordContext;
				switch (num2)
				{
				case 0:
					return false;
				case 1:
				{
					num = (short)1648794891;
					short num3 = num;
					num = (short)1054448907;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_132;
					default:
						goto IL_DC;
					}
					break;
				}
				case 2:
					goto IL_132;
				case 3:
					if (!astromodifyCodeplugPasswordContext.AstroOpenFilePasswordEnabled)
					{
						num = (short)522518529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					if (!string.IsNullOrEmpty(astromodifyCodeplugPasswordContext.NewRadioPassword))
					{
						num = (short)1148583944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					num = (short)142082051;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 7:
					if (!astromodifyCodeplugPasswordContext.AstroWritePasswordEnabled)
					{
						num = (short)900792325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 8:
					num = (short)1659568129;
					if (num != 0)
					{
					}
					num = (short)72876034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)677511175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4D:
				if (!base.CanExecute(paras))
				{
					num = (short)1496973312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				astromodifyCodeplugPasswordContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROModifyCodeplugPasswordContext);
				num = (short)1419575300;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_132:
				if (astromodifyCodeplugPasswordContext.AstroReadPasswordEnabled)
				{
					return true;
				}
				num = (short)1562640393;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_DC:
			num = (short)152698880;
			if (num != 0)
			{
			}
			num = (short)1107034112;
			short num4 = num;
			return false;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0002A178 File Offset: 0x00028378
		private global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy a(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROModifyCodeplugPasswordContext A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy astropasswordPolicy;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1598418300;
					short num3 = num2;
					num2 = (short)873852284;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_71;
					default:
						num2 = (short)974913536;
						if (num2 != 0)
						{
						}
						if (A_0.AstroOpenFilePasswordEnabled)
						{
							num2 = (short)1493237760;
							short num4 = num2;
							num2 = (short)729874433;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return astropasswordPolicy;
					}
					break;
				}
				case 1:
					astropasswordPolicy |= global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Open;
					num2 = (short)235601927;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					astropasswordPolicy |= global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Read;
					num2 = (short)649134083;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_17D;
				case 4:
					astropasswordPolicy |= global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Write;
					num2 = (short)1895890952;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (A_0.AstroReadPasswordEnabled)
					{
						num2 = (short)183435266;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17D;
				case 6:
					num2 = (short)431816705;
					if (num2 != 0)
					{
					}
					if (A_0.AstroWritePasswordEnabled)
					{
						num2 = (short)1448148996;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_71;
				case 7:
					return astropasswordPolicy;
				case 8:
					goto IL_71;
				}
				goto IL_34;
				IL_71:
				num2 = (short)121372672;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_17D:
				num2 = (short)1832648710;
				num = (int)((global::System.IntPtr)num2);
			}
			return astropasswordPolicy;
			IL_34:
			astropasswordPolicy = global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None;
			num2 = (short)1106706437;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
