using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.Common.CommonUtility.CSV;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x0200001D RID: 29
	public class ASTROImportCSVBatchOp : global::Motorola.CommonCPS.RadioManagement.BatchOp.ImportCSVBatchOp
	{
		// Token: 0x060000C3 RID: 195 RVA: 0x000110D8 File Offset: 0x0000F2D8
		public ASTROImportCSVBatchOp(global::Motorola.CommonCPS.RadioManagement.UIModels.Group currentGroup, global::System.Globalization.CultureInfo cultureInfo, global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile) : base(currentGroup, cultureInfo, csvFile)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00011108 File Offset: 0x0000F308
		protected override global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest CreateImportCSVRequest()
		{
			short num = (short)1844183040;
			short num2 = num;
			num = (short)694278121;
			short num3 = num;
			num = (short)821942249;
			switch (num3 == num)
			{
			}
			num = (short)6488064;
			if (num != 0)
			{
			}
			num = (short)825491457;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000111B8 File Offset: 0x0000F3B8
		protected override int ConvertPasswordPolicy(string value)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			int num2;
			short num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2++;
					num3 = (short)332660741;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					goto IL_AE;
				case 2:
					num2 += 2;
					num3 = (short)821821443;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 3:
				{
					num3 = (short)571138862;
					short num4 = num3;
					num3 = (short)1356194606;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AE;
					case 1:
						break;
					default:
					{
						num3 = (short)1889927168;
						short num5 = num3;
						break;
					}
					}
					num3 = (short)1835401216;
					if (num3 != 0)
					{
					}
					goto IL_D3;
				}
				case 4:
					num3 = (short)1997733889;
					if (num3 != 0)
					{
					}
					if (value.Contains(global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Open.ToString()))
					{
						num3 = (short)1932263425;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_11D;
				case 5:
					goto IL_1A7;
				case 6:
					if (value.Contains(global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Read.ToString()))
					{
						num3 = (short)1814429696;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1A7;
				case 7:
					if (value.Contains(global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Write.ToString()))
					{
						num3 = (short)503906306;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_D3;
				case 8:
					return num2;
				case 9:
					num2 = 0;
					num3 = (short)65863688;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 10:
					if (value.Contains(global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None.ToString()))
					{
						num3 = (short)1136459785;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return num2;
				case 11:
					goto IL_11D;
				}
				goto IL_40;
				IL_AE:
				num2 += 4;
				num3 = (short)1250099211;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_D3:
				num3 = (short)794624006;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_11D:
				num3 = (short)2087321607;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1A7:
				num3 = (short)689831946;
				num = (int)((global::System.IntPtr)num3);
			}
			return num2;
			IL_40:
			num2 = 0;
			num3 = (short)786366468;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00011450 File Offset: 0x0000F650
		protected override void ValidateSpecialFields(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio, global::System.Collections.Generic.IList<string> delCharFields)
		{
			int a_ = 13;
			short num = (short)77266944;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_163;
				}
				global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0 CS$<>8__locals1;
				global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				string text;
				for (;;)
				{
					IL_30:
					bool flag;
					switch (num2)
					{
					case 0:
						num = (short)952107020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.apxRq.SubscriberIP))
						{
							num = (short)372047914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E1;
					case 2:
						CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_SubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
						CS$<>8__locals1.apxRq.SubscriberIP = null;
						num = (short)195166218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						apxcodeplug = (apxradio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
						num = (short)34340886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_B60;
					case 5:
						if (apxradio != null)
						{
							num = (short)363724800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						if (flag)
						{
							num = (short)750059553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)986185791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_B60;
					case 8:
						if (apxradio != null)
						{
							num = (short)2086469679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					case 9:
						if (CS$<>8__locals1.apxRq.PasswordPerDevice)
						{
							num = (short)1151664145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1191;
					case 10:
						goto IL_9E9;
					case 11:
						goto IL_A32;
					case 12:
						if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.CodeplugPassword))
						{
							num = (short)208535598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F9E;
					case 13:
						goto IL_B60;
					case 14:
					{
						bool flag2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.IsQualifiedRadio(apxradio, radioRq);
						bool flag3 = false;
						if (!flag2 && (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.apxRq.BluetoothDUNSubscriberIP) || global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.apxRq.BluetoothDUNPeerIP)))
						{
							flag3 = true;
						}
						if (flag3)
						{
							CS$<>8__locals1.apxRq.BluetoothDUNSubscriberIP = null;
							CS$<>8__locals1.apxRq.BluetoothDUNPeerIP = null;
						}
						else
						{
							if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.BluetoothDUNSubscriberIP))
							{
								CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothDUNSubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
							}
							else if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.apxRq.BluetoothDUNSubscriberIP))
							{
								CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothDUNSubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
								CS$<>8__locals1.apxRq.BluetoothDUNSubscriberIP = null;
							}
							if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.BluetoothDUNPeerIP))
							{
								CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothDUNPeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
							}
							else if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.apxRq.BluetoothDUNPeerIP))
							{
								CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothDUNPeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
								CS$<>8__locals1.apxRq.BluetoothDUNPeerIP = null;
							}
						}
						if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.BluetoothFriendlyName))
						{
							CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothFriendlyName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
						}
						else if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.apxRq.BluetoothFriendlyName))
						{
							CS$<>8__locals1.apxRq.BluetoothFriendlyName = null;
						}
						if (delCharFields.Contains(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鷑ꃓ럕꫗鏙飛", a_)))
						{
							CS$<>8__locals1.apxRq.OtarID = null;
						}
						else if (CS$<>8__locals1.apxRq.OtarID == null)
						{
							CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_OtarID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
						}
						if (delCharFields.Contains(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("蓑蛓鿕鳗", a_)))
						{
							CS$<>8__locals1.apxRq.VRID = null;
						}
						else if (CS$<>8__locals1.apxRq.VRID == null)
						{
							CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_VRID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
						}
						flag = false;
						if (!flag2)
						{
							num = (short)222101553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7FE;
					}
					case 15:
						CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_UserName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
						num = (short)39911447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.apxRq.PeerIP))
						{
							num = (short)1794899998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B60;
					case 17:
						num = (short)56557626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_33D;
					case 19:
						goto IL_EF3;
					case 20:
						CS$<>8__locals1.apxRq.UserLoginUnitID = null;
						num = (short)719585350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_7FE;
					case 22:
						goto IL_21E;
					case 23:
						goto IL_C7A;
					case 24:
					{
						num = (short)1872426600;
						short num3 = num;
						num = (short)2128410216;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A32;
						default:
						{
							num = (short)1656422400;
							short num4 = num;
							num = (short)1773666304;
							if (num != 0)
							{
							}
							CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_UserLoginUnitID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
							num = (short)1652097049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 25:
						goto IL_E09;
					case 26:
						if (apxradio.WorkingCodeplug != null)
						{
							num = (short)1004732419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21E;
					case 27:
						CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_SubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
						num = (short)1080492066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (object.Equals(CS$<>8__locals1.apxRq.PasswordPerDevice, apxcodeplug.PasswordPerDevice))
						{
							num = (short)1408892976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1484;
					case 29:
						if (apxcodeplug != null)
						{
							num = (short)2092302386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 30:
						CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_PeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
						CS$<>8__locals1.apxRq.PeerIP = null;
						num = (short)2050424845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (CS$<>8__locals1.apxRq.UserLoginUnitID == null)
						{
							num = (short)1132265496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1311834149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.PeerIP))
						{
							num = (short)1249443851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)338296848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						CS$<>8__locals1.apxRq.SubscriberIP = null;
						CS$<>8__locals1.apxRq.PeerIP = null;
						num = (short)111017991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_9E9;
					case 35:
						num = (short)1688141825;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.ReadPassword))
						{
							num = (short)471990334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 36:
						if (CS$<>8__locals1.apxRq.PasswordPolicy != (int)apxcodeplug.PasswordPolicy)
						{
							num = (short)226361415;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 37:
						if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.apxRq.UserLoginUnitID))
						{
							num = (short)318308372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E09;
					case 38:
						return;
					case 39:
						if (string.Equals(CS$<>8__locals1.apxRq.CodeplugPassword, apxcodeplug.CodeplugPassword))
						{
							num = (short)1675493448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1484;
					case 40:
						if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.apxRq.UserName))
						{
							num = (short)1450573878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7A;
					case 41:
						if (string.Equals(CS$<>8__locals1.apxRq.ReadPassword, apxradio.ReadPassword))
						{
							num = (short)941359168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_PasswordPerDevice())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
						CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_CodeplugPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
						CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_PasswordPolicy())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
						num = (short)962134051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						num = (short)1620443195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						CS$<>8__locals1.apxRq.ForeignIP = null;
						num = (short)1223032850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (CS$<>8__locals1.apxRq.UserName == null)
						{
							num = (short)988807183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)453836840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						num = (short)149225538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						CS$<>8__locals1.apxRq.ReadPassword = string.Empty;
						num = (short)1609367626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						num = (short)1129578522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						num = (short)48300071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						num = (short)63045633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						num = (short)886702108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.ForeignIP))
						{
							num = (short)2019491893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1493827639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						text = "";
						(global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Instance.UIValidateService as global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService).ValidatePassWord(CS$<>8__locals1.apxRq.CodeplugPassword, out text);
						num = (short)1191051324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_ForeignIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
						num = (short)10092611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						CS$<>8__locals1.apxRq.UserName = null;
						num = (short)2090795077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.apxRq.ForeignIP))
						{
							num = (short)1792081963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33D;
					case 56:
						if (!string.IsNullOrEmpty(CS$<>8__locals1.apxRq.ReadPassword))
						{
							num = (short)1809317933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E85;
					case 57:
						goto IL_E85;
					case 58:
						if (!string.IsNullOrEmpty(CS$<>8__locals1.apxRq.CodeplugPassword))
						{
							num = (short)2108227636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1191;
					case 59:
						if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.apxRq.PeerIP))
						{
							num = (short)181862461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7FE;
					case 60:
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)489160769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 61:
						goto IL_7E1;
					case 62:
						num = (short)625868829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.SubscriberIP))
						{
							num = (short)773783579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)139853892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						num = (short)2110193673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						goto IL_10DD;
					case 66:
						if (existedRadio != null)
						{
							num = (short)583467065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF3;
					case 67:
						goto IL_33D;
					case 68:
						if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsDeleteChar(CS$<>8__locals1.apxRq.SubscriberIP))
						{
							num = (short)844103682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9E9;
					case 69:
						goto IL_C7A;
					case 70:
						goto IL_E09;
					case 71:
						goto IL_1484;
					case 72:
						num = (short)2133590052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						goto IL_11AA;
					case 74:
						goto IL_F9E;
					}
					goto IL_163;
					IL_21E:
					num = (short)1199243315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33D:
					num = (short)1836777486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E1:
					flag = true;
					num = (short)818937877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7FE:
					num = (short)395968518;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9E9:
					num = (short)807141408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A32:
					CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_PeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
					num = (short)540934148;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B60:
					num = (short)1436680236;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C7A:
					num = (short)20381727;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E09:
					num = (short)999358520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E85:
					CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_ReadPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
					num = (short)235405331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EF3:
					num = (short)1118175237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F9E:
					num = (short)160825385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1191:
					num = (short)73465929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1484:
					CS$<>8__locals1.apxRq.WarningMsg = global::Motorola.CommonCPS.ResourceRepository.Resources.ReadWritePasswordInvalid;
					num = (short)371589158;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10DD:
				CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_CodeplugPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
				CS$<>8__locals1.apxRq.IgnoreColumns.Add(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_PasswordPolicy())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>())));
				CS$<>8__locals1.apxRq.WarningMsg = text;
				return;
				IL_11AA:
				global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest apxRq = CS$<>8__locals1.apxRq;
				global::Motorola.CommonCPS.Server.EntityModel.Codeplug currentCodeplug = apxradio.CurrentCodeplug;
				string codeplugPassword;
				if (!string.IsNullOrEmpty((currentCodeplug != null) ? currentCodeplug.CodeplugPassword : null))
				{
					codeplugPassword = null;
				}
				else
				{
					global::Motorola.CommonCPS.Server.EntityModel.Codeplug currentCodeplug2 = apxradio.CurrentCodeplug;
					codeplugPassword = ((currentCodeplug2 != null) ? currentCodeplug2.CodeplugPassword : null);
				}
				apxRq.CodeplugPassword = codeplugPassword;
				CS$<>8__locals1.apxRq.PasswordPolicy = 0;
				return;
				IL_163:
				CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass4_0();
				base.ValidateSpecialFields(radioRq, existedRadio, delCharFields);
				CS$<>8__locals1.apxRq = (radioRq as global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest);
				apxradio = (existedRadio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
				apxcodeplug = null;
				num = (short)2142765064;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0001290C File Offset: 0x00010B0C
		protected override bool CheckIsNeedUpdated(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, global::Motorola.CommonCPS.Server.EntityModel.Radio existedRadio)
		{
			short num = (short)1184104448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1F7;
				}
				global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0 CS$<>8__locals1;
				bool flag;
				for (;;)
				{
					IL_28:
					string text;
					string text2;
					string text3;
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
					string text4;
					string text5;
					int? num3;
					string text6;
					string text7;
					string text8;
					string text9;
					string text10;
					string text11;
					string text12;
					int? num4;
					string text13;
					string text14;
					string text15;
					string text16;
					switch (num2)
					{
					case 0:
						num = (short)1677459547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return true;
					case 2:
						if ((text = CS$<>8__locals1.apxRq.SubscriberIP) == null)
						{
							num = (short)177012835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1206;
					case 3:
						text2 = null;
						goto IL_8E5;
					case 4:
						goto IL_11BE;
					case 5:
						flag = true;
						num = (short)1180696664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1505951778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)2043084893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1416364119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						text3 = null;
						goto IL_963;
					case 10:
						num = (short)1944649834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)213385259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (apxcodeplug.UserLoginUnitID != null)
						{
							num = (short)1323040787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)974520430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						flag = true;
						num = (short)438894606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return flag;
					case 15:
						num = (short)1163984990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (text4 != null)
						{
							num = (short)2029256735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B9;
					case 17:
						if (!CS$<>8__locals1.apxRq.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_OtarID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
						{
							num = (short)1279721550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F43;
					case 18:
						num = (short)116523067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1556807718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if ((text5 = CS$<>8__locals1.apxRq.PeerIP) == null)
						{
							num = (short)338100301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10E8;
					case 21:
						num = (short)921239588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.PeerIP))
						{
							num = (short)1629945906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A3;
					case 23:
						num = (short)308019217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)632750152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_6A3;
					case 26:
						if (!CS$<>8__locals1.apxRq.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_SubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
						{
							num = (short)2015166535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12DC;
					case 27:
						num3 = CS$<>8__locals1.apxRq.OtarID;
						num = (short)1046020162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						text6 = null;
						goto IL_862;
					case 29:
						if (!CS$<>8__locals1.apxRq.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_PeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
						{
							num = (short)1903558739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11BE;
					case 30:
						flag = true;
						num = (short)407765103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						text4 = text4.Trim();
						num = (short)1345519648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_2B9;
					case 33:
						flag = true;
						num = (short)1053491251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (!CS$<>8__locals1.apxRq.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothDUNPeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
						{
							num = (short)951386193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B83;
					case 35:
						num = (short)1110769712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						text2 = apxcodeplug.PeerIP.Trim();
						goto IL_8E5;
					case 37:
						num = (short)198705178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						text7 = apxcodeplug.UserLoginUnitID.Trim();
						goto IL_9E3;
					case 39:
						if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.UserName))
						{
							num = (short)255983713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A3;
					case 40:
						text8 = apxcodeplug.BluetoothDUNPeerIP.Trim();
						goto IL_765;
					case 41:
						goto IL_B83;
					case 42:
						num = (short)584515624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						text6 = apxcodeplug.BluetoothFriendlyName.Trim();
						goto IL_862;
					case 44:
						text9 = string.Empty;
						goto IL_1324;
					case 45:
						if (apxcodeplug.BluetoothDUNPeerIP != null)
						{
							num = (short)783351850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)383844353;
						if (num != 0)
						{
						}
						num = (short)612499529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (apxcodeplug.SubscriberIP != null)
						{
							num = (short)1206714368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1707081737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (apxcodeplug.BluetoothDUNSubscriberIP != null)
						{
							num = (short)940965896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1945894988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (existedRadio.WorkMode != global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Template)
						{
							num = (short)1396178967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F43;
					case 49:
						goto IL_3DB;
					case 50:
						num = (short)2109276228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						goto IL_DEE;
					case 52:
						if (flag)
						{
							num = (short)1507655681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						apxcodeplug = (existedRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
						text4 = (existedRadio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio).ForeignIP;
						num = (short)315490320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						text10 = apxcodeplug.UserName.Trim();
						goto IL_A61;
					case 54:
						num = (short)1179582531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.BluetoothFriendlyName))
						{
							num = (short)2097938459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A3;
					case 56:
						flag = true;
						num = (short)1483735104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						num = (short)1117192301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						if (apxcodeplug == null)
						{
							num = (short)480903192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1179516973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						if (!CS$<>8__locals1.apxRq.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_VRID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
						{
							num = (short)2056323077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_109F;
					case 60:
						text11 = string.Empty;
						goto IL_304;
					case 61:
						if (apxcodeplug.PeerIP != null)
						{
							num = (short)539623445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)166854659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						if ((text12 = CS$<>8__locals1.apxRq.BluetoothFriendlyName) == null)
						{
							num = (short)1166999655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CED;
					case 63:
						if (num3 != null)
						{
							num = (short)2032271385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 64:
						goto IL_13FC;
					case 65:
						num = (short)1851326534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						if (num3 == null)
						{
							num = (short)690290774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A3;
					case 67:
						if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.UserLoginUnitID))
						{
							num = (short)1107165291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A3;
					case 68:
						if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.SubscriberIP))
						{
							num = (short)1224933430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A3;
					case 69:
						num = (short)1026490397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (!CS$<>8__locals1.apxRq.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_ForeignIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
						{
							num = (short)1607467092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DB;
					case 71:
						flag = true;
						num = (short)842858578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.BluetoothDUNPeerIP))
						{
							num = (short)1371471887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A3;
					case 73:
						text8 = null;
						goto IL_765;
					case 74:
					{
						if (num4.GetValueOrDefault() == num3.GetValueOrDefault() & num4 != null == (num3 != null))
						{
							goto IL_109F;
						}
						num = (short)610464494;
						short num5 = num;
						num = (short)2142892782;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_477;
						default:
							num = (short)1162805248;
							if (num != 0)
							{
							}
							num = (short)1256980498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 75:
						if ((text13 = CS$<>8__locals1.apxRq.BluetoothDUNSubscriberIP) == null)
						{
							num = (short)179044444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BCD;
					case 76:
						text14 = null;
						goto IL_7E3;
					case 77:
						text5 = string.Empty;
						goto IL_10E8;
					case 78:
						flag = true;
						num = (short)1211367514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						if ((text9 = CS$<>8__locals1.apxRq.UserLoginUnitID) == null)
						{
							num = (short)1945174060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1324;
					case 80:
						if (!(num3.GetValueOrDefault() == num4.GetValueOrDefault() & num3 != null == (num4 != null)))
						{
							num = (short)1808990243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F43;
					case 81:
						flag = true;
						num = (short)519962665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						goto IL_12DC;
					case 83:
						flag = true;
						num = (short)1872035844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						flag = true;
						num = (short)1654915121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						text10 = null;
						goto IL_A61;
					case 86:
						num = (short)1910112278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						text14 = apxcodeplug.BluetoothDUNSubscriberIP.Trim();
						goto IL_7E3;
					case 88:
						goto IL_109F;
					case 89:
						num = (short)635830327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						goto IL_F43;
					case 91:
						text3 = apxcodeplug.SubscriberIP.Trim();
						goto IL_963;
					case 92:
						text13 = string.Empty;
						goto IL_BCD;
					case 93:
						if (!CS$<>8__locals1.apxRq.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothFriendlyName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
						{
							num = (short)2037448737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DEE;
					case 94:
						goto IL_477;
					case 95:
						text15 = string.Empty;
						goto IL_AAC;
					case 96:
						if ((text11 = CS$<>8__locals1.apxRq.ForeignIP) == null)
						{
							num = (short)360579132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_304;
					case 97:
						num3 = CS$<>8__locals1.apxRq.VRID;
						num = (short)727646271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						if ((text15 = CS$<>8__locals1.apxRq.BluetoothDUNPeerIP) == null)
						{
							num = (short)1270284383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AAC;
					case 99:
						text = string.Empty;
						goto IL_1206;
					case 100:
						num = (short)757399665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						return flag;
					case 102:
						if (apxcodeplug.UserName != null)
						{
							num = (short)520552553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)181207125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						text12 = string.Empty;
						goto IL_CED;
					case 104:
						if (apxcodeplug.BluetoothFriendlyName != null)
						{
							num = (short)740425739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)42598428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						num = (short)1565130805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						if (!CS$<>8__locals1.apxRq.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_UserName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
						{
							num = (short)448266253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 107:
						num = (short)1106444327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						text16 = string.Empty;
						goto IL_1445;
					case 109:
						if (!CS$<>8__locals1.apxRq.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothDUNSubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
						{
							num = (short)1488322590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CA5;
					case 110:
						text7 = null;
						goto IL_9E3;
					case 111:
						goto IL_CA5;
					case 112:
						if ((text16 = CS$<>8__locals1.apxRq.UserName) == null)
						{
							num = (short)1938489452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1445;
					case 113:
						if (!CS$<>8__locals1.apxRq.IgnoreColumns.Contains(global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0.apxRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_UserLoginUnitID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()))))
						{
							num = (short)1217658936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13FC;
					}
					goto IL_1F7;
					IL_2B9:
					num = (short)638582880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_304:
					if (text11 != (text4 ?? string.Empty))
					{
						num = (short)543162433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3DB:
					num = (short)1675034682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_477:
					if (string.IsNullOrEmpty(CS$<>8__locals1.apxRq.BluetoothDUNSubscriberIP))
					{
						num = (short)169869401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6A3:
					flag = true;
					num = (short)1243873381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_765:
					string text17 = text8;
					num = (short)1791426607;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E3:
					string text18 = text14;
					num = (short)641269864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_862:
					string text19 = text6;
					num = (short)1407451197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8E5:
					string text20 = text2;
					num = (short)1381302318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_963:
					string text21 = text3;
					num = (short)1632174092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9E3:
					string text22 = text7;
					num = (short)155123814;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A61:
					string text23 = text10;
					num = (short)138018914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AAC:
					if (text15 != (text17 ?? string.Empty))
					{
						num = (short)1301741574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B83:
					num = (short)163053643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BCD:
					if (text13 != (text18 ?? string.Empty))
					{
						num = (short)1895956537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_CA5:
					num = (short)123600958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CED:
					if (text12 != (text19 ?? string.Empty))
					{
						num = (short)187432960;
						short num6 = num;
						num = (short)749535239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DEE:
					num3 = CS$<>8__locals1.apxRq.OtarID;
					num4 = apxcodeplug.OtarID;
					num = (short)767623248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F43:
					num4 = CS$<>8__locals1.apxRq.VRID;
					num3 = apxcodeplug.VRID;
					num = (short)450363466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_109F:
					num = (short)1758724116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10E8:
					if (text5 != (text20 ?? string.Empty))
					{
						num = (short)900726853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_11BE:
					num = (short)2134179842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1206:
					if (text != (text21 ?? string.Empty))
					{
						num = (short)2103902245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_12DC:
					num = (short)842399823;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1324:
					if (text9 != (text22 ?? string.Empty))
					{
						num = (short)153092196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_13FC:
					num = (short)1815347312;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1445:
					if (!(text16 != (text23 ?? string.Empty)))
					{
						return flag;
					}
					num = (short)162201610;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_1F7:
				CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass5_0();
				CS$<>8__locals1.apxRq = (radioRq as global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest);
				flag = base.CheckIsNeedUpdated(radioRq, existedRadio);
				num = (short)915537972;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00013E38 File Offset: 0x00012038
		protected override global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier Pac
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)426135270;
				short num2 = num;
				num = (short)163139302;
				switch (num2 == num)
				{
				}
				num = (short)1223950337;
				if (num != 0)
				{
				}
				num = (short)1475543040;
				if (num != 0)
				{
				}
				num = (short)1695350784;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00013EE8 File Offset: 0x000120E8
		protected override void GenerateRelatedIPs(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest radioRq, out string error)
		{
			int a_ = 15;
			short num = (short)1974272000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A8;
				}
				string bluetoothDUNPeerIP;
				string subscriberIP;
				global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass9_0 CS$<>8__locals1;
				string bluetoothDUNSubscriberIP;
				string peerIP;
				for (;;)
				{
					IL_31:
					string propertyName;
					string propertyName2;
					string propertyName4;
					switch (num2)
					{
					case 0:
						if (!this.a.ValidateDeviceIP(bluetoothDUNPeerIP, out error))
						{
							num = (short)452001804;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)292290571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!this.a.ValidateDeviceIP(subscriberIP, out error))
						{
							num = (short)71434241;
							if (num != 0)
							{
							}
							num = (short)315228165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1080623104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1038484158;
						short num3 = num;
						num = (short)2090861246;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_20D;
						default:
							num = (short)742653952;
							if (num != 0)
							{
							}
							if (CS$<>8__locals1.apxRadioRq.IgnoreColumns.Contains(propertyName))
							{
								num = (short)1293942802;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3FD;
						}
						break;
					}
					case 3:
						CS$<>8__locals1.apxRadioRq.IgnoreColumns.Remove(propertyName);
						num = (short)1471152152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1565786122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_5A7;
					case 6:
						CS$<>8__locals1.apxRadioRq.IgnoreColumns.Remove(propertyName2);
						num = (short)1699151892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)140836883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						string propertyName3;
						if (CS$<>8__locals1.apxRadioRq.IgnoreColumns.Contains(propertyName3))
						{
							num = (short)69533700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20D;
					}
					case 9:
						if (!string.IsNullOrEmpty(CS$<>8__locals1.apxRadioRq.BluetoothDUNSubscriberIP))
						{
							num = (short)1013907459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FD;
					case 10:
						if (!string.IsNullOrEmpty(CS$<>8__locals1.apxRadioRq.PeerIP))
						{
							num = (short)589299725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20D;
					case 11:
					{
						if (!this.a.ValidateDeviceIP(bluetoothDUNSubscriberIP, out error))
						{
							num = (short)1594425371;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService as global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTRORadioService).AutoGenerateRelatedIPs(ref peerIP, ref subscriberIP, ref bluetoothDUNPeerIP, ref bluetoothDUNSubscriberIP);
						CS$<>8__locals1.apxRadioRq.PeerIP = peerIP;
						CS$<>8__locals1.apxRadioRq.SubscriberIP = subscriberIP;
						CS$<>8__locals1.apxRadioRq.BluetoothDUNPeerIP = bluetoothDUNPeerIP;
						CS$<>8__locals1.apxRadioRq.BluetoothDUNSubscriberIP = bluetoothDUNSubscriberIP;
						string propertyName3 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass9_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass9_0.apxRadioRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_PeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1246167048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_2E2;
					case 13:
					{
						string propertyName3;
						CS$<>8__locals1.apxRadioRq.IgnoreColumns.Remove(propertyName3);
						num = (short)972226581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						CS$<>8__locals1.apxRadioRq.IgnoreColumns.Remove(propertyName4);
						num = (short)235995162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (CS$<>8__locals1.apxRadioRq.IgnoreColumns.Contains(propertyName4))
						{
							num = (short)272629777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_132;
					case 16:
						if (!string.IsNullOrEmpty(CS$<>8__locals1.apxRadioRq.SubscriberIP))
						{
							num = (short)527368206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_132;
					case 17:
						num = (short)1872691216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						num = (short)540475392;
						short num4 = num;
						num = (short)1016528905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (!string.IsNullOrEmpty(CS$<>8__locals1.apxRadioRq.BluetoothDUNPeerIP))
						{
							num = (short)1730609158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 20:
						goto IL_4B8;
					case 21:
						goto IL_20D;
					case 22:
						if (CS$<>8__locals1.apxRadioRq.IgnoreColumns.Contains(propertyName2))
						{
							num = (short)1065091079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 23:
						goto IL_12D;
					case 24:
						goto IL_3FD;
					case 25:
						if (!this.a.ValidateDeviceIP(peerIP, out error))
						{
							num = (short)1203961879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)678035457;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_132;
					case 27:
						goto IL_53B;
					}
					goto IL_A8;
					IL_132:
					propertyName = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass9_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass9_0.apxRadioRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothDUNSubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1124335618;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20D:
					propertyName4 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass9_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass9_0.apxRadioRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_SubscriberIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)573112335;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FD:
					propertyName2 = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.PropertyHelper.GetPropertyName<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Field(global::System.Linq.Expressions.Expression.Constant(CS$<>8__locals1, typeof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass9_0)), fieldof(global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass9_0.apxRadioRq)), methodof(global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest.get_BluetoothDUNPeerIP())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1959067670;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12D:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_PeerIP + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + error;
				return;
				IL_2E2:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_BluetoothDUNPeerIP + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + error;
				return;
				IL_4B8:
				return;
				IL_53B:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_BluetoothDUNSubscriberIP + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + error;
				return;
				IL_5A7:
				error = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_SubscriberIP + global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("", a_) + error;
				return;
				IL_A8:
				CS$<>8__locals1 = new global::Motorola.CommonCPS.RadioManagement.BatchOp.ASTROImportCSVBatchOp.<>c__DisplayClass9_0();
				CS$<>8__locals1.apxRadioRq = (radioRq as global::Motorola.CommonCPS.Server.EntityModel.ImportAPXRadioFromCSVRequest);
				peerIP = CS$<>8__locals1.apxRadioRq.PeerIP;
				subscriberIP = CS$<>8__locals1.apxRadioRq.SubscriberIP;
				bluetoothDUNPeerIP = CS$<>8__locals1.apxRadioRq.BluetoothDUNPeerIP;
				bluetoothDUNSubscriberIP = CS$<>8__locals1.apxRadioRq.BluetoothDUNSubscriberIP;
				num = (short)1081933849;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00014690 File Offset: 0x00012890
		protected override bool ValidateASTROIPGroup(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase rd, out string error)
		{
			short num = (short)104096921;
			short num2 = num;
			num = (short)79914137;
			switch (num2 == num)
			{
			}
			num = (short)304545793;
			if (num != 0)
			{
			}
			num = (short)1340342272;
			if (num != 0)
			{
			}
			num = (short)432930816;
			short num3 = num;
			return base.ValidationServiceFactory.UIValidateService.ValidateNewRadio(rd, out error);
		}

		// Token: 0x04000039 RID: 57
		private readonly global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService a = global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.GetInstance(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance);

		// Token: 0x0400003A RID: 58
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier b = global::Motorola.CommonCPS.Server.CommonDBConstants.PacIdentifier.ASTRO;
	}
}
