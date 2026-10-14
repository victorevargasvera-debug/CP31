using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000038 RID: 56
	internal class MigrateTemplateCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0001D9E8 File Offset: 0x0001BBE8
		// (set) Token: 0x0600023D RID: 573 RVA: 0x0001DA98 File Offset: 0x0001BC98
		private global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext Context
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)435699066;
				short num2 = num;
				num = (short)1657421178;
				switch (num2 == num)
				{
				default:
				{
					num = (short)356909056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)874184704;
				if (num != 0)
				{
				}
				num = (short)1331429377;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)845283329;
				if (num != 0)
				{
				}
				num = (short)861405184;
				short num2 = num;
				num = (short)851138158;
				short num3 = num;
				num = (short)1670207086;
				switch (num3 == num)
				{
				}
				num = (short)562692096;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0001DB48 File Offset: 0x0001BD48
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1559363585;
			if (num != 0)
			{
			}
			num = (short)519307264;
			short num2 = num;
			num = (short)1607922882;
			short num3 = num;
			num = (short)1164309698;
			switch (num3 == num)
			{
			}
			num = (short)255852544;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0001DBF4 File Offset: 0x0001BDF4
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 12;
			short num = (short)1811021825;
			if (num != 0)
			{
			}
			num = (short)264110086;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).SaveMigrationTemplateSelctions(this.Context.UnSelectedTemplates.Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo q)
					{
						short num5 = (short)1200772699;
						short num6 = num5;
						num5 = (short)352605787;
						switch (num6 == num5)
						{
						default:
						{
							num5 = (short)1236205568;
							short num7 = num5;
							break;
						}
						case true:
							break;
						}
						num5 = (short)331939840;
						if (num5 != 0)
						{
						}
						num5 = (short)351797249;
						if (num5 != 0)
						{
						}
						return q.TemplateUuid;
					}).ToList<global::System.Guid>());
					this.Context.StatusBarState = global::Motorola.CommonCPS.ResourceRepository.Resources.DISPLAY_STRING_RUNNING;
					this.Context.StatusBarMessage = null;
					this.Context.MigrationError = null;
					num = (short)564199431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					flag = true;
					goto IL_1A3;
				case 2:
				{
					num = (short)252343593;
					short num3 = num;
					num = (short)415069481;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_28D;
					default:
						goto IL_156;
					}
					break;
				}
				case 3:
					flag = !paras.Any<object>();
					goto IL_1A3;
				case 4:
					num = (short)1616707585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)579796992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_7C;
					}
					continue;
				case 7:
					goto IL_28D;
				case 8:
					if (this.Context.MigrationStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.MigrationStatus.TEMPLATE_SELECTION_SAVED)
					{
						num = (short)905707520;
						short num4 = num;
						num = (short)239468549;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_109;
				case 9:
					goto IL_1BD;
				}
				IL_7C:
				if (paras == null)
				{
					num = (short)559415300;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1021575171;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_109:
				num = (short)99155970;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_28D:
				goto IL_109;
				IL_1A3:
				if (flag)
				{
					num = (short)1266024457;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					this.Context = (global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext)paras[0];
					num = (short)781713416;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_156:
			num = (short)393412608;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> a_2 = this.Context.ValidateTemplates.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo q)
			{
				short num5 = (short)1244700624;
				short num6 = num5;
				num5 = (short)1374068688;
				switch (num6 == num5)
				{
				default:
				{
					num5 = (short)1021444096;
					short num7 = num5;
					break;
				}
				case true:
					break;
				}
				num5 = (short)530382849;
				if (num5 != 0)
				{
				}
				num5 = (short)541982720;
				if (num5 != 0)
				{
				}
				return !q.IsTemplateExist;
			}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>();
			this.a(a_2);
			return true;
			IL_1BD:
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("跼黾猀戂瘄", a_));
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0001DEE4 File Offset: 0x0001C0E4
		private void a(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> A_0)
		{
			short num = (short)1120403457;
			if (num != 0)
			{
			}
			num = (short)1464279427;
			short num2 = num;
			num = (short)1333010819;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1821835264;
				short num3 = num;
				num = (short)215482368;
				if (num != 0)
				{
				}
				if (A_0.Count <= 0)
				{
					this.a(null, null);
					return;
				}
				break;
			}
			}
			global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp migrateTemplateBatchOp = new global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp(A_0);
			migrateTemplateBatchOp.TemplateImportCompleteEvent += this.a;
			base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo>(migrateTemplateBatchOp);
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0001DFC0 File Offset: 0x0001C1C0
		private void a(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo> A_0)
		{
			short num = (short)504700994;
			short num2 = num;
			num = (short)406396994;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)633012225;
				if (num != 0)
				{
				}
				num = (short)1096876032;
				short num3 = num;
				num = (short)857145344;
				if (num != 0)
				{
				}
				if (A_0.Count <= 0)
				{
					this.a(null, null);
					return;
				}
				break;
			}
			}
			global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateRadioDataBacthOp migrateRadioDataBacthOp = new global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateRadioDataBacthOp(A_0);
			migrateRadioDataBacthOp.ApplyTemplateCompleteEvent += this.a;
			base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo>(migrateRadioDataBacthOp);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x0001E09C File Offset: 0x0001C29C
		private void a(object A_0 = null, global::Motorola.CommonCPS.RadioManagement.BatchOp.MigrateTemplateBatchOp.ApplyTemplatesEventArgs A_1 = null)
		{
			switch (0)
			{
			case 0:
				goto IL_5F;
			}
			short num;
			int num2;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo> list;
			global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo> source;
			for (;;)
			{
				IL_0A:
				num = (short)879296513;
				if (num != 0)
				{
				}
				bool flag;
				switch (num2)
				{
				case 0:
					flag = (null != null);
					goto IL_D1;
				case 1:
					goto IL_22B;
				case 2:
				{
					num = (short)338332130;
					short num3 = num;
					num = (short)644712930;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E0;
					default:
						num = (short)901513216;
						if (num != 0)
						{
						}
						num = (short)1498742793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					flag = (A_1.PerformedList != null);
					goto IL_D1;
				case 4:
					num = (short)1996423168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1C9;
				case 6:
					if (A_1 == null)
					{
						num = (short)629342212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)333971459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_1E0;
				case 8:
				{
					list.AddRange(A_1.PerformedList);
					num = (short)1731330048;
					short num4 = num;
					num = (short)1034158085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					if (A_1.PerformedList.Any<global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo>())
					{
						num = (short)707133448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C9;
				}
				goto IL_5F;
				IL_D1:
				if (flag)
				{
					num = (short)1773404162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1C9:
				num = (short)676659207;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E0:
				source = this.Context.ValidateTemplates.Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo q)
				{
					short num5 = (short)128241955;
					short num6 = num5;
					num5 = (short)1092866339;
					switch (num6 == num5)
					{
					default:
					{
						num5 = (short)2113077248;
						short num7 = num5;
						break;
					}
					case true:
						break;
					}
					num5 = (short)38731776;
					if (num5 != 0)
					{
					}
					num5 = (short)344391681;
					if (num5 != 0)
					{
					}
					return q.IsTemplateExist;
				});
				num = (short)1934557185;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_22B:
			list.AddRange(source.SelectMany(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo item)
			{
				short num5 = (short)240090430;
				short num6 = num5;
				num5 = (short)86998334;
				switch (num6 == num5)
				{
				default:
				{
					num5 = (short)136904704;
					short num7 = num5;
					break;
				}
				case true:
					break;
				}
				num5 = (short)1382875136;
				if (num5 != 0)
				{
				}
				num5 = (short)1958019073;
				if (num5 != 0)
				{
				}
				return item.ReferencedRadioList;
			}, delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationTemplateBasicInfo item, global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationRadioBasicInfo radioInfo)
			{
				short num5 = (short)159629552;
				short num6 = num5;
				num5 = (short)1693303024;
				switch (num6 == num5)
				{
				default:
				{
					num5 = (short)1012858880;
					short num7 = num5;
					break;
				}
				case true:
					break;
				}
				num5 = (short)2054815744;
				if (num5 != 0)
				{
				}
				num5 = (short)661454849;
				if (num5 != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo
				{
					TemplateUuid = item.TemplateUuid,
					TemplateName = item.TemplateName,
					RadioUuid = radioInfo.RadioUuid,
					SerialNumber = radioInfo.SerialNumber,
					HasPBA = radioInfo.HasPBA,
					Template = null
				};
			}));
			this.a(list);
			return;
			IL_5F:
			list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.BatchOp.DBMigrationApplyTemplateBaseInfo>();
			num = (short)378535942;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x0001E330 File Offset: 0x0001C530
		private void a(object A_0 = null, global::System.EventArgs A_1 = null)
		{
			short num = (short)1253872372;
			short num2 = num;
			num = (short)1219924724;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1266155520;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1601372161;
			if (num != 0)
			{
			}
			num = (short)394461184;
			if (num != 0)
			{
			}
			this.Context.MigrationStatus = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).MigrateTemplateAndApplyTemplateDone();
		}

		// Token: 0x04000038 RID: 56
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.DBMigrationContext a;
	}
}
