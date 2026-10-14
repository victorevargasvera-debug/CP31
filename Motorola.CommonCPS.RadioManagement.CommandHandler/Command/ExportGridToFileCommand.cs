using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.Converters;
using Motorola.CommonCPS.RadioManagement.ConvertorExtensions;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000A7 RID: 167
	public class ExportGridToFileCommand : global::Motorola.CommonCPS.RadioManagement.Command.ExportGridToFileCommandBase<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x060003B9 RID: 953 RVA: 0x0003CEF8 File Offset: 0x0003B0F8
		public ExportGridToFileCommand(global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService groupService)
		{
			this.a = groupService;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0003CF14 File Offset: 0x0003B114
		protected override global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetDataGridInfo()
		{
			short num = (short)52690945;
			if (num != 0)
			{
			}
			num = (short)1125745401;
			short num2 = num;
			num = (short)925926137;
			switch (num2 == num)
			{
			}
			num = (short)1592262656;
			short num3 = num;
			num = (short)821166080;
			if (num != 0)
			{
			}
			return base.Interaction.GetDataGridInfoForRadios();
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0003CFCC File Offset: 0x0003B1CC
		protected override bool ExportColumnSelector(global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo columnInfo)
		{
			int a_ = 4;
			short num = (short)447414273;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return true;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 2:
				{
					num = (short)120258560;
					short num3 = num;
					num = (short)223159607;
					short num4 = num;
					num = (short)1646863671;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_147;
					default:
						goto IL_D4;
					}
					break;
				}
				case 3:
					num = (short)1946484737;
					if (num != 0)
					{
					}
					if (string.Equals(columnInfo.FieldName, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꃴ蓶鳸觺근뛾伀", a_), global::System.StringComparison.Ordinal))
					{
						goto IL_147;
					}
					goto IL_166;
				}
				IL_3D:
				if (string.Equals(columnInfo.FieldName, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꛴鋶诸鋺鳼鏾伀瘂栄攆氈礊", a_), global::System.StringComparison.Ordinal))
				{
					num = (short)1374158848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1101987843;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_147:
				num = (short)697499650;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_D4:
			num = (short)51052544;
			if (num != 0)
			{
			}
			return false;
			IL_166:
			return columnInfo.IsVisible;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x0003D148 File Offset: 0x0003B348
		protected override global::System.Collections.Generic.ICollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo> GetExtraExportColumns()
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo> list;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier != global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration)
					{
						goto IL_13E;
					}
					num2 = (short)1525940224;
					short num3 = num2;
					num2 = (short)563619220;
					short num4 = num2;
					num2 = (short)1181164948;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1045495809;
						if (num2 != 0)
						{
						}
						num2 = (short)2110586880;
						if (num2 != 0)
						{
						}
						num2 = (short)1051590658;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_13C;
				case 2:
					list.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("믷闹賻蟽䛿瀁欃欅娇欉栋服缏", a_), global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("믷闹賻蟽⃿䐁瘃椅攇⨉帋漍琏笑笓", a_), true));
					num2 = (short)1195114497;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_25;
			}
			IL_13C:
			IL_13E:
			list.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꣷ鯹迻跽矿洁瘃戅", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.General_Serial_ReadWritePassword, true));
			list.Add(new global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("뛷鿹读뷽濿昁愃瘅搇缉欋帍焏愑朓愕眗栙砛", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.NewCodeplugPassword, true));
			return list;
			IL_25:
			list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo>();
			num2 = (short)485097472;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x0003D2D4 File Offset: 0x0003B4D4
		protected override string ConvertFieldValueForExport(string fieldName, object value, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase record)
		{
			int a_ = 5;
			short num = (short)1983381507;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (value != null)
					{
						num = (short)922419206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7F;
				case 1:
				{
					num = (short)1189281792;
					short num3 = num;
					num = (short)872611840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_1A3;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 4:
					goto IL_7A;
				case 5:
				{
					if (!string.Equals(fieldName, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꏵ뇷냹鏻鳽叿瘁攃爅紇礉", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)411959303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)754308605;
					short num4 = num;
					num = (short)1866847741;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1814888449;
						if (num != 0)
						{
						}
						num = (short)1525612544;
						if (num != 0)
						{
						}
						num = (short)1006895105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 6:
					goto IL_201;
				case 7:
					if (string.Equals(fieldName, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꛵駷觹迻觽濿瀁怃", a_), global::System.StringComparison.Ordinal))
					{
						num = (short)2065629186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_206;
				}
				IL_4E:
				if (string.Equals(fieldName, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("ꏵ뇷맹铻鿽滿攁愃伅昇渉攋洍焏昑笓搕", a_), global::System.StringComparison.Ordinal))
				{
					num = (short)1939865604;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)2090205189;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_7A:
			return global::Motorola.CommonCPS.RadioManagement.Converters.ChangeIndivatorConverter.ConvertChangeIndicatorToString((int)value);
			IL_7F:
			return string.Empty;
			IL_1A3:
			return string.Empty;
			IL_201:
			return ((global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus)value).ToResourceString();
			IL_206:
			return base.ConvertFieldValueForExport(fieldName, value, record);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x0003D4F0 File Offset: 0x0003B6F0
		protected override object GetFieldValue(string fieldName, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase record)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			int num;
			short num2;
			object result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_29D;
				case 1:
					goto IL_29D;
				case 2:
				{
					num2 = (short)282394624;
					short num3 = num2;
					num2 = (short)1040908293;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					IL_9A:
					global::System.Guid? id = record.CurentGroup.ID;
					num2 = (short)1315504141;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					result = record.TemplateName;
					num2 = (short)2033451009;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (record is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio)
					{
						num2 = (short)90505220;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_166;
				case 6:
					goto IL_29D;
				case 7:
					num2 = (short)1171914763;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_29D;
				case 9:
					if (string.Equals(fieldName, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("뫼跾渀瘂甄䤆栈昊栌", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						num2 = (short)251723779;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1618870282;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (fieldName == global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("뻼郾漀攂氄怆簈礊氌笎砐簒笔外砘瘚砜", a_))
					{
						num2 = (short)1668874247;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_166;
				case 11:
					if (record.ConfigurationName == null)
					{
						num2 = (short)1103757314;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_166;
				case 12:
					result = global::Motorola.CommonCPS.ResourceRepository.Resources.Group_Field_None;
					num2 = (short)1155399688;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
				{
					global::System.Guid? id;
					if (id == null)
					{
						num2 = (short)980287500;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2132344833;
					if (num2 != 0)
					{
					}
					result = this.a.GetGroupFullPath(record.CurentGroup.ID);
					num2 = (short)1654259718;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_51;
				IL_29D:
				num2 = (short)652181776;
				short num4 = num2;
				num2 = (short)69763344;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_9A;
				default:
					goto IL_2D1;
				}
				IL_166:
				result = base.GetFieldValue(fieldName, record);
				num2 = (short)164495360;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_2D1:
			num2 = (short)49086464;
			if (num2 != 0)
			{
			}
			return result;
			IL_51:
			result = null;
			num2 = (short)171114505;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x040000B5 RID: 181
		private readonly global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService a;
	}
}
