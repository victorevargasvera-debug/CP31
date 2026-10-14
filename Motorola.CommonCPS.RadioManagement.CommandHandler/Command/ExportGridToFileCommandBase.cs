using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using Motorola.Common.CustomException;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.Common.CommonUtility.CSV;
using Motorola.CommonCPS.Common.CommonUtility.ExcelFile;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200000C RID: 12
	public abstract class ExportGridToFileCommandBase<RecordType> : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600002A RID: 42 RVA: 0x00003DB8 File Offset: 0x00001FB8
		public override bool CanExecute(params object[] paras)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1910833154;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)726189008;
						short num3 = num;
						num = (short)994034640;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1917714432;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.IEnumerable<RecordType> enumerable;
							if (enumerable != null)
							{
								num = (short)590741510;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						}
						}
						break;
					}
					case 1:
						goto IL_18E;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					case 3:
						return true;
					case 4:
					{
						global::System.Collections.Generic.IEnumerable<RecordType> enumerable;
						if (enumerable.Count<RecordType>() > 0)
						{
							num = (short)302972931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 5:
						num = (short)408289287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1740308484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						if (paras.Count<object>() <= 0)
						{
							num = (short)121438209;
							if (num != 0)
							{
							}
							num = (short)285016065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerable<RecordType> enumerable = paras[0] as global::System.Collections.Generic.IEnumerable<RecordType>;
						num = (short)974192640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_44:
					if (paras == null)
					{
						goto IL_192;
					}
					num = (short)1952579589;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
			IL_18E:
			IL_192:
			num = (short)1313734656;
			short num4 = num;
			return false;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003F84 File Offset: 0x00002184
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 14;
			short num = (short)70254592;
			switch (num)
			{
			default:
			{
				num = (short)1412628480;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					case 1:
						goto IL_457;
					case 2:
						num = (short)886571011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Collections.Generic.IEnumerable<RecordType> enumerable;
						if (enumerable.Count<RecordType>() > 0)
						{
							num = (short)1476067334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_411;
					}
					case 4:
					{
						if (paras.Count<object>() < 1)
						{
							num = (short)2045313029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.b = this.GetDataGridInfo();
						global::System.Collections.Generic.IEnumerable<RecordType> enumerable = paras[0] as global::System.Collections.Generic.IEnumerable<RecordType>;
						this.Initialize(paras);
						num = (short)1004863496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_40F;
					case 6:
					{
						num = (short)1854799873;
						if (num != 0)
						{
						}
						string text = null;
						num = (short)27000832;
						short num3 = num;
						num = (short)1909063681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1394212868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::System.Collections.Generic.IEnumerable<RecordType> enumerable;
						if (enumerable != null)
						{
							num = (short)1710096386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_411;
					}
					}
					IL_71:
					if (paras == null)
					{
						break;
					}
					num = (short)423034887;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3C1:
				throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("닾栀瀂瘄渆月氊ⴌ挎砐怒愔㜖瘘級㴜洞䐠䀢䨤唦䴨堪ബ嬮帰ጲ倴伶䤸吺似䬾潀", a_));
				IL_40F:
				goto IL_3C1;
				IL_411:
				return null;
				IL_457:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_C3;
					}
					string text;
					object result;
					for (;;)
					{
						IL_9C:
						switch (num2)
						{
						case 0:
							goto IL_1FA;
						case 1:
							goto IL_1CD;
						case 2:
						{
							if (string.IsNullOrEmpty(text))
							{
								num = (short)987955206;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<string> a_2 = this.b();
							global::System.Collections.Generic.List<string> a_3 = this.a();
							global::System.Collections.Generic.IEnumerable<RecordType> enumerable;
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> a_4 = this.a(enumerable);
							num = (short)547422211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							if (text.EndsWith(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("퇾戀瀂猄", a_), global::System.StringComparison.Ordinal))
							{
								num = (short)403439620;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.List<string> a_2;
							global::System.Collections.Generic.List<string> a_3;
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> a_4;
							this.a(text, a_2, a_3, a_4);
							num = (short)1337589761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::System.Collections.Generic.List<string> a_2;
							global::System.Collections.Generic.List<string> a_3;
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> a_4;
							this.b(text, a_2, a_3, a_4);
							num = (short)79953927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_17D;
						case 6:
							result = null;
							num = (short)1733427205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_1CD;
						}
						goto IL_C3;
						IL_1CD:
						base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Message_Export_successful, global::Motorola.CommonCPS.ResourceRepository.Resources.ExportDevicesAction_Title);
						num = (short)936247296;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_17D:
					return result;
					IL_1FA:
					goto IL_411;
					IL_C3:
					text = this.GetExportFilePath();
					num = (short)1494286338;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_9C;
				}
				catch (global::Motorola.Common.CustomException.CommonException ex)
				{
					base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportFile_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("\udffe", a_) + global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null), global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
					goto IL_411;
				}
				catch (global::System.IO.IOException ex2)
				{
					string content = string.Empty;
					int num4 = ex2.HResult & 65535;
					string text;
					if (num4 != 112)
					{
						num = (short)1250619106;
						short num5 = num;
						num = (short)588246754;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_313;
						default:
							num = (short)1150418944;
							if (num != 0)
							{
							}
							if (num4 != 39)
							{
								content = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportFile_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("\udffe", a_) + string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.The_Process_Cannot_Access_File, text);
								goto IL_330;
							}
							break;
						}
					}
					content = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportFile_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("\udffe", a_) + string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.No_Enough_Space_On_The_Disk, global::System.Array.Empty<object>());
					if (string.IsNullOrEmpty(text))
					{
						goto IL_330;
					}
					IL_313:
					if (global::System.IO.File.Exists(text))
					{
						try
						{
							global::System.IO.File.Delete(text);
						}
						catch
						{
						}
					}
					IL_330:
					base.Interaction.ShowNotificationDialog(content, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
					goto IL_411;
				}
				catch (global::System.UnauthorizedAccessException)
				{
					string text;
					string content2 = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportFile_Error + global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("\udffe", a_) + string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportFile_Access_Error, text);
					base.Interaction.ShowNotificationDialog(content2, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
					goto IL_411;
				}
				catch (global::System.Exception e)
				{
					global::Motorola.Common.LogUtility.LogManager.GetLogger(global::Motorola.CommonCPS.RadioManagement.CommonBase.LoggerName.RMCLoggerName).Error(e, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("닾搀眂洄栆洈ㄊ䠌眎愐簒朔挖䴘琚堜朞䈠䘢䤤愦䀨䜪䠬", a_));
					base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_ExportFile_Error, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
					goto IL_411;
				}
				goto IL_3C1;
			}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000452C File Offset: 0x0000272C
		protected virtual void Initialize(params object[] paras)
		{
			short num = (short)1528015231;
			short num2 = num;
			num = (short)355969407;
			switch (num2 == num)
			{
			}
			num = (short)861208576;
			if (num != 0)
			{
			}
			num = (short)608763905;
			if (num != 0)
			{
			}
			num = (short)2139815936;
			short num3 = num;
		}

		// Token: 0x0600002D RID: 45
		protected abstract global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo GetDataGridInfo();

		// Token: 0x0600002E RID: 46 RVA: 0x000045D4 File Offset: 0x000027D4
		protected virtual string ConvertFieldNameToHeader(string fieldName)
		{
			short num = (short)1006579449;
			short num2 = num;
			num = (short)216739577;
			switch (num2 == num)
			{
			}
			num = (short)109969409;
			if (num != 0)
			{
			}
			num = (short)1072627712;
			if (num != 0)
			{
			}
			num = (short)1664221184;
			short num3 = num;
			return fieldName;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004680 File Offset: 0x00002880
		protected virtual string ConvertFieldValueForExport(string fieldName, object value, RecordType record)
		{
			if (value == null)
			{
				short num = (short)1773605433;
				short num2 = num;
				num = (short)670241337;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)205193217;
					if (num != 0)
					{
					}
					num = (short)324403200;
					if (num != 0)
					{
					}
					num = (short)78118912;
					short num3 = num;
					return string.Empty;
				}
				}
			}
			return value.ToString();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004740 File Offset: 0x00002940
		protected virtual bool ExportColumnSelector(global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo columnInfo)
		{
			short num = (short)585200438;
			short num2 = num;
			num = (short)718566198;
			switch (num2 == num)
			{
			}
			num = (short)1082720256;
			if (num != 0)
			{
			}
			num = (short)405405697;
			if (num != 0)
			{
			}
			num = (short)2138112000;
			short num3 = num;
			return true;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000047EC File Offset: 0x000029EC
		protected virtual global::System.Collections.Generic.ICollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo> GetExtraExportColumns()
		{
			short num = (short)1933254639;
			short num2 = num;
			num = (short)1250631663;
			switch (num2 == num)
			{
			}
			num = (short)44826625;
			if (num != 0)
			{
			}
			num = (short)533266432;
			if (num != 0)
			{
			}
			num = (short)1810300928;
			short num3 = num;
			return new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo>();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0000489C File Offset: 0x00002A9C
		private global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo> c()
		{
			short num = (short)501757435;
			short num2 = num;
			num = (short)1450980859;
			switch (num2 == num)
			{
			}
			num = (short)1152712705;
			if (num != 0)
			{
			}
			num = (short)693764096;
			if (num != 0)
			{
			}
			num = (short)801243136;
			short num3 = num;
			return this.b.Columns.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo, bool>(this.ExportColumnSelector)).Union(this.GetExtraExportColumns());
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00004970 File Offset: 0x00002B70
		private global::System.Reflection.PropertyInfo a(RecordType A_0, string A_1)
		{
			if (!this.a.ContainsKey(A_1))
			{
				short num = (short)1772929604;
				short num2 = num;
				num = (short)383369796;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1454309377;
					if (num != 0)
					{
					}
					num = (short)737935360;
					if (num != 0)
					{
					}
					num = (short)270991360;
					short num3 = num;
					global::System.Reflection.PropertyInfo property = A_0.GetType().GetProperty(A_1);
					this.a.Add(A_1, property);
					return property;
				}
				}
			}
			return this.a[A_1];
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00004A5C File Offset: 0x00002C5C
		private global::System.Collections.Generic.List<string> a(RecordType A_0)
		{
			short num = (short)216399872;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo> enumerator = this.c().GetEnumerator();
				try
				{
					num = (short)2128674819;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_107;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)907608068;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo rmdataGridColumnInfo = enumerator.Current;
							string fieldName = rmdataGridColumnInfo.FieldName;
							object fieldValue = this.GetFieldValue(fieldName, A_0);
							string item = this.ConvertFieldValueForExport(rmdataGridColumnInfo.FieldName, fieldValue, A_0);
							list.Add(item);
							num = (short)1007812609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_6C;
							}
							continue;
						case 4:
							num = (short)1396178944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_B6:
						num = (short)441778178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6C:
						goto IL_B6;
					}
					IL_107:;
				}
				finally
				{
					for (;;)
					{
						IL_10C:
						num = (short)88539137;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1C9;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_13F;
								}
								continue;
							case 2:
							{
								enumerator.Dispose();
								num = (short)1078975870;
								short num3 = num;
								num = (short)1454955902;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_10C;
								default:
									num = (short)1024720896;
									if (num != 0)
									{
									}
									num = (short)1347747840;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_13F:
							if (enumerator == null)
							{
								goto IL_1CB;
							}
							num = (short)1100021762;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_1C9:
					IL_1CB:;
				}
				num = (short)800980993;
				if (num != 0)
				{
				}
				num = (short)1022951424;
				short num4 = num;
				return list;
			}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00004C98 File Offset: 0x00002E98
		protected virtual object GetFieldValue(string fieldName, RecordType record)
		{
			global::System.Reflection.PropertyInfo propertyInfo = this.a(record, fieldName);
			if (!(propertyInfo != null))
			{
				short num = (short)2046660052;
				short num2 = num;
				num = (short)1069780436;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1646592001;
					if (num != 0)
					{
					}
					num = (short)169476096;
					if (num != 0)
					{
					}
					num = (short)319225856;
					short num3 = num;
					return null;
				}
				}
			}
			return propertyInfo.GetValue(record);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004D64 File Offset: 0x00002F64
		private global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> a(global::System.Collections.Generic.IEnumerable<RecordType> A_0)
		{
			short num = (short)565313536;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>();
				global::System.Collections.Generic.IEnumerator<RecordType> enumerator = A_0.GetEnumerator();
				try
				{
					num = (short)31981571;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_E4;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)459276292;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							RecordType a_ = enumerator.Current;
							global::System.Collections.Generic.List<string> item = this.a(a_);
							list.Add(item);
							num = (short)144965633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_68;
							}
							continue;
						case 4:
							num = (short)2015297536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_97:
						num = (short)53870594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_68:
						goto IL_97;
					}
					IL_E4:;
				}
				finally
				{
					for (;;)
					{
						IL_E9:
						num = (short)1297154049;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1CB;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_11C;
								}
								continue;
							case 2:
							{
								enumerator.Dispose();
								num = (short)28091324;
								short num3 = num;
								num = (short)985310140;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_E9;
								default:
									num = (short)1275199488;
									if (num != 0)
									{
									}
									num = (short)1326907392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_11C:
							if (enumerator == null)
							{
								goto IL_1CD;
							}
							num = (short)1645150209;
							if (num != 0)
							{
							}
							num = (short)392036354;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_1CB:
					IL_1CD:;
				}
				num = (short)790036480;
				short num4 = num;
				return list;
			}
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004F7C File Offset: 0x0000317C
		private global::System.Collections.Generic.List<string> b()
		{
			short num = (short)1367539712;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo> enumerator = this.c().GetEnumerator();
				try
				{
					num = (short)988217347;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)990511105;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_11D;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1720909828;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string fieldName = enumerator.Current.FieldName;
							string item = this.ConvertFieldNameToHeader(fieldName);
							list.Add(item);
							num = (short)2121728001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_92;
							}
							continue;
						case 4:
							num = (short)1930035200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_C8:
						num = (short)742653954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_92:
						goto IL_C8;
					}
					IL_11D:;
				}
				finally
				{
					for (;;)
					{
						IL_122:
						num = (short)1421672449;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1DB;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_154;
								}
								continue;
							case 2:
							{
								enumerator.Dispose();
								num = (short)356248323;
								short num3 = num;
								num = (short)2056841987;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_122;
								default:
									num = (short)1141571584;
									if (num != 0)
									{
									}
									num = (short)1898184704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_154:
							if (enumerator == null)
							{
								goto IL_1DD;
							}
							num = (short)583860226;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_1DB:
					IL_1DD:;
				}
				num = (short)1092419584;
				short num4 = num;
				return list;
			}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000051A4 File Offset: 0x000033A4
		private global::System.Collections.Generic.List<string> a()
		{
			short num = (short)1144061952;
			short num2 = num;
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridColumnInfo> enumerator = this.c().GetEnumerator();
			try
			{
				num = (short)44630019;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_114;
					case 2:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1394606081;
							if (num != 0)
							{
							}
							num = (short)1211170820;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						string fieldUIString = enumerator.Current.FieldUIString;
						list.Add(fieldUIString);
						num = (short)1989607425;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_76;
						}
						continue;
					case 4:
						num = (short)449249280;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A1:
					num = (short)1727725570;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_76:
					goto IL_A1;
				}
				IL_114:;
			}
			finally
			{
				for (;;)
				{
					IL_119:
					num = (short)1062535169;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_1CC;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_149;
							}
							continue;
						case 2:
						{
							enumerator.Dispose();
							num = (short)397083500;
							short num4 = num;
							num = (short)261751660;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_119;
							default:
								num = (short)708444160;
								if (num != 0)
								{
								}
								num = (short)2030239744;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_149:
						if (enumerator == null)
						{
							goto IL_1CE;
						}
						num = (short)341114882;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_1CC:
				IL_1CE:;
			}
			return list;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005394 File Offset: 0x00003594
		protected string GetExportFilePath()
		{
			short num = (short)718359478;
			short num2 = num;
			num = (short)339299254;
			switch (num2 == num)
			{
			}
			num = (short)87752705;
			if (num != 0)
			{
			}
			num = (short)1389428736;
			if (num != 0)
			{
			}
			num = (short)1772486656;
			short num3 = num;
			return base.Interaction.ShowSaveFileDialogForGridToFile(string.Empty);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005450 File Offset: 0x00003650
		private void b(string A_0, global::System.Collections.Generic.List<string> A_1, global::System.Collections.Generic.List<string> A_2, global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> A_3)
		{
			short num = (short)1835398703;
			short num2 = num;
			num = (short)436729391;
			switch (num2 == num)
			{
			default:
			{
				num = (short)883818496;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1260912641;
			if (num != 0)
			{
			}
			num = (short)1111490560;
			if (num != 0)
			{
			}
			new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile().ExportToCSV(A_0, A_1, A_3, A_2, null);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000550C File Offset: 0x0000370C
		private void a(string A_0, global::System.Collections.Generic.List<string> A_1, global::System.Collections.Generic.List<string> A_2, global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> A_3)
		{
			short num = (short)552915210;
			short num2 = num;
			num = (short)1777586442;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1903624192;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2109276160;
			if (num != 0)
			{
			}
			num = (short)499515393;
			if (num != 0)
			{
			}
			new global::Motorola.CommonCPS.Common.CommonUtility.ExcelFile.ExcelFile().ExportToExcel(A_0, A_1, A_3, A_2);
		}

		// Token: 0x04000014 RID: 20
		private global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo> a = new global::System.Collections.Generic.Dictionary<string, global::System.Reflection.PropertyInfo>();

		// Token: 0x04000015 RID: 21
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RMDataGridInfo b;
	}
}
