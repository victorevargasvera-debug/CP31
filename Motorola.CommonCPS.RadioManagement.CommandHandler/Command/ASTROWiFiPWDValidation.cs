using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Threading;
using System.Windows.Input;
using authAES;
using commonLicensing;
using Microsoft.Practices.Prism.ViewModel;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Common.CommonUtility;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000050 RID: 80
	public class ASTROWiFiPWDValidation : global::Microsoft.Practices.Prism.ViewModel.NotificationObject
	{
		// Token: 0x060002AE RID: 686 RVA: 0x000269B4 File Offset: 0x00024BB4
		static ASTROWiFiPWDValidation()
		{
			int a_ = 12;
			short num = (short)896928924;
			short num2 = num;
			num = (short)467078300;
			switch (num2 == num)
			{
			default:
			{
				num = (short)224526336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)163119104;
			if (num != 0)
			{
			}
			num = (short)1375404033;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation.b = string.Empty;
			global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation.b = global::commonLicensing.HostID.getNewHostID(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("꿼닾䈀", a_));
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00026A8C File Offset: 0x00024C8C
		public ASTROWiFiPWDValidation(global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext wiFiPasswordValidationContext)
		{
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork> listAPXWiFiNetwork = wiFiPasswordValidationContext.ListAPXWiFiNetwork;
			this.c = wiFiPasswordValidationContext;
			foreach (global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork apxwiFiNetwork in listAPXWiFiNetwork)
			{
				if (apxwiFiNetwork.NetworkSecureType != global::Motorola.CommonCPS.RadioManagement.UIModels.APXWiFiNetwork.SECURITY_TYPE_NONE)
				{
					if (string.IsNullOrEmpty(apxwiFiNetwork.NetworkSSID))
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_WiFi_Network_SSID_Can_Not_Be_Empty);
					}
					global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord item = new global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord
					{
						NetworkSSID = apxwiFiNetwork.NetworkSSID,
						NetworkPWD = string.Empty,
						IsValid = true
					};
					this.d.Add(item);
					if (this.e.ContainsKey(apxwiFiNetwork.NetworkSSID))
					{
						throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_WiFi_Two_Same_Network_SSID, apxwiFiNetwork.NetworkSSID));
					}
					this.e.Add(apxwiFiNetwork.NetworkSSID, apxwiFiNetwork.NetworkPWD);
				}
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00026BB0 File Offset: 0x00024DB0
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00026E4C File Offset: 0x0002504C
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord> WifiNetworkItemSource
		{
			get
			{
				short num = (short)768737280;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					num = (short)246153217;
					if (num != 0)
					{
					}
					num = (short)1642070016;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							IL_5B:
							switch (0)
							{
							case 0:
								goto IL_78;
							}
							continue;
						case 1:
							goto IL_9F;
						case 2:
							try
							{
								num = (short)730791938;
								num2 = (int)((global::System.IntPtr)num);
								global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord> observableCollection;
								for (;;)
								{
									switch (num2)
									{
									case 1:
									{
										global::System.Collections.IEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1183776771;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord item = (global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord)enumerator.Current;
										observableCollection.Add(item);
										num = (short)91815936;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_DF;
										}
										continue;
									case 3:
										num = (short)272433156;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_159;
									}
									IL_10D:
									num = (short)749731841;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_DF:
									goto IL_10D;
								}
								IL_159:
								return observableCollection;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_17B;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_168:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)514129921;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_1CF;
									case 1:
										disposable.Dispose();
										num = (short)443744258;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_1CD;
									}
									goto IL_17B;
								}
								IL_1CD:
								IL_1CF:
								goto EndFinally_6;
								IL_17B:
								global::System.Collections.IEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)288030720;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_168;
								EndFinally_6:;
							}
							goto IL_1D0;
						}
						IL_78:
						if (this.c.WiFiNetworks == null)
						{
							num = (short)1465384961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1D0:
						num = (short)245956608;
						short num3 = num;
						num = (short)2146889386;
						short num4 = num;
						num = (short)1677127338;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5B;
						default:
						{
							num = (short)224133120;
							if (num != 0)
							{
							}
							global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord> observableCollection = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord>();
							global::System.Collections.IEnumerator enumerator = this.c.WiFiNetworks.GetEnumerator();
							num = (short)1752432642;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
					IL_9F:
					return this.d;
				}
			}
			set
			{
				short num = (short)486399280;
				short num2 = num;
				num = (short)1095163184;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1438253056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1729626113;
				if (num != 0)
				{
				}
				num = (short)1991573504;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00026EFC File Offset: 0x000250FC
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00026FAC File Offset: 0x000251AC
		public bool HasInvalidPWD
		{
			get
			{
				short num = (short)107297131;
				short num2 = num;
				num = (short)143079787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)694157312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)975044608;
				if (num != 0)
				{
				}
				num = (short)1766129665;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)1647840857;
				short num2 = num;
				num = (short)358944345;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1865154560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1928331265;
				if (num != 0)
				{
				}
				num = (short)438304768;
				if (num != 0)
				{
				}
				this.g = value;
				base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation)), methodof(global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation.get_HasInvalidPWD())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00027094 File Offset: 0x00025294
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00027144 File Offset: 0x00025344
		public string ApxTemplateName
		{
			get
			{
				short num = (short)2013549345;
				short num2 = num;
				num = (short)1229017889;
				switch (num2 == num)
				{
				}
				num = (short)670826496;
				if (num != 0)
				{
				}
				num = (short)133234689;
				if (num != 0)
				{
				}
				num = (short)228392960;
				short num3 = num;
				return this.h;
			}
			set
			{
				int a_ = 5;
				short num = (short)91947009;
				if (num != 0)
				{
				}
				num = (short)1176896922;
				short num2 = num;
				num = (short)1893139866;
				switch (num2 == num)
				{
				}
				num = (short)1342767104;
				if (num != 0)
				{
				}
				num = (short)1794441216;
				short num3 = num;
				this.h = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("践죷蟹웻\udefd篿㌁礃", a_), global::Motorola.CommonCPS.ResourceRepository.Resources.General_Template_Name, value);
				base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation)), methodof(global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation.get_ApxTemplateName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00027250 File Offset: 0x00025450
		public bool NeedValidation(string templateID, string templateName)
		{
			int a_ = 5;
			short num = (short)1232797698;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_111;
				case 1:
					return false;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (this.d.Count != 0)
				{
					this.f = string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("践죷蟹ꏻ藽ㇿ缁", a_), global::Motorola.CommonCPS.RadioManagement.Command.ASTROWiFiPWDValidation.b, templateID);
					num = (short)755022533;
					short num3 = num;
					num = (short)1577106117;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)553779200;
						short num4 = num;
						num = (short)1684144128;
						if (num != 0)
						{
						}
						num = (short)1368784896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
				}
				num = (short)1912209409;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_111:
			num = (short)1052114945;
			if (num != 0)
			{
			}
			bool flag = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).IsSessionOutOfTime(this.f);
			if (!flag)
			{
				global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).RefreshSessionTimer(this.f);
				return flag;
			}
			this.ApxTemplateName = templateName;
			return flag;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000273C8 File Offset: 0x000255C8
		public bool NeedValidation(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			short num = (short)1100012978;
			short num2 = num;
			num = (short)1924718002;
			switch (num2 == num)
			{
			}
			num = (short)552337408;
			if (num != 0)
			{
			}
			num = (short)393609217;
			if (num != 0)
			{
			}
			num = (short)470876160;
			short num3 = num;
			return this.NeedValidation(template.Uuid.ToString(), template.Name);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00027490 File Offset: 0x00025690
		public bool NeedValidation(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase templateBase)
		{
			short num = (short)768977561;
			short num2 = num;
			num = (short)745843353;
			switch (num2 == num)
			{
			}
			num = (short)157417473;
			if (num != 0)
			{
			}
			num = (short)841744384;
			if (num != 0)
			{
			}
			num = (short)931987456;
			short num3 = num;
			return this.NeedValidation(templateBase.ID.ToString(), templateBase.Name);
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00027558 File Offset: 0x00025758
		public bool NeedValidation(global::Motorola.CommonCPS.Server.EntityModel.ConfigurationViewSummary recordSummary)
		{
			int a_ = 18;
			short num = (short)663289856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_78;
				}
				global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnodeContainedByConfiguration;
				global::Motorola.CommonCPS.Server.EntityModel.Record record;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
						if ((dbnode as global::Motorola.CommonCPS.Server.EntityModel.DBField).Value.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture) == bool.FalseString.ToUpper(global::System.Globalization.CultureInfo.InvariantCulture))
						{
							num = (short)887685129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_360;
					}
					case 1:
					{
						num = (short)1868109411;
						short num3 = num;
						num = (short)1874597475;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return false;
						default:
						{
							num = (short)909180928;
							if (num != 0)
							{
							}
							global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode = global::Motorola.CommonCPS.Common.CommonUtility.Utility.BFSNodeByNodeName(dbnodeContainedByConfiguration, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䜂搄猆栈尊搌欎琐䐒尔儖倘帚猜縞䌠伢䀤砦ᴨᤪᠬἮܰ", a_));
							num = (short)1350369291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						goto IL_285;
					case 3:
						if (!string.IsNullOrEmpty(record.SetName))
						{
							num = (short)1239875584;
							short num4 = num;
							num = (short)402391042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39A;
					case 4:
						if (dbnodeContainedByConfiguration != null)
						{
							num = (short)1855913996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39A;
					case 5:
						num = (short)446300161;
						if (num != 0)
						{
						}
						if (record != null)
						{
							num = (short)605683719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39A;
					case 6:
						if (!string.IsNullOrEmpty(record.UUID))
						{
							num = (short)281280525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39A;
					case 7:
						num = (short)1331036166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2;
						if (dbnode2 != null)
						{
							num = (short)1406140431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39A;
					}
					case 9:
						goto IL_215;
					case 10:
						if (dbnodeContainedByConfiguration != null)
						{
							num = (short)183959553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_360;
					case 11:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
						if (dbnode != null)
						{
							num = (short)180944910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_360;
					}
					case 12:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2 = global::Motorola.CommonCPS.Common.CommonUtility.Utility.BFSNodeByNodeName(dbnodeContainedByConfiguration, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䜂搄猆栈尊搌欎琐", a_));
						num = (short)1932984328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)1397358595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)344457216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2;
						record = (dbnode2.ChildNodesList[0] as global::Motorola.CommonCPS.Server.EntityModel.Record);
						num = (short)324141061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_78;
					IL_360:
					num = (short)1185873924;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_215:
				return false;
				IL_285:
				return this.NeedValidation(record.UUID, record.SetName);
				IL_39A:
				return this.NeedValidation(recordSummary.Uuid.ToString(), recordSummary.Name);
				IL_78:
				dbnodeContainedByConfiguration = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetDBNodeContainedByConfiguration(recordSummary.Uuid, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("䜂搄猆栈尊搌欎琐", a_));
				num = (short)1455423498;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00027920 File Offset: 0x00025B20
		public bool ValidatePWD()
		{
			short num = (short)1199833088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)136577025;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8B;
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext wiFiPasswordValidationContext;
				bool flag;
				for (;;)
				{
					IL_50:
					global::System.Collections.IEnumerator enumerator;
					string text;
					switch (num2)
					{
					case 0:
						global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).RefreshSessionTimer(this.f);
						num = (short)958136325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!this.NeedValidation(wiFiPasswordValidationContext.ConfigurationViewSummary))
						{
							num = (short)61734921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CE;
					case 2:
						goto IL_594;
					case 3:
						num = (short)427884554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							num = (short)498270217;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord wiFiRecord;
								switch (num2)
								{
								case 0:
									goto IL_2FA;
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)1725628429;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									wiFiRecord = (global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord)enumerator.Current;
									num = (short)1209401350;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (!wiFiRecord.IsValid)
									{
										num = (short)1253834755;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									flag = true;
									num = (short)1326186504;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (text == null)
									{
										num = (short)1254686725;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4A0;
								case 5:
									text = string.Empty;
									num = (short)1429733383;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (this.c.ConfigurationViewSummary != null)
									{
										num = (short)919601163;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									text = global::authAES.AESCryptography.AESEncryptWithDefKey_ForWiFiPassword(wiFiRecord.NetworkPWD);
									num = (short)250019852;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_4A0;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_2F5;
									}
									continue;
								case 10:
									goto IL_519;
								case 11:
									text = wiFiRecord.NetworkPWD;
									num = (short)1958871040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_2FA;
								case 13:
									num = (short)1809383434;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2F5;
								IL_2FA:
								num = (short)138594195;
								short num3 = num;
								num = (short)1528285075;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_2F5:
									break;
								default:
									num = (short)386007040;
									if (num != 0)
									{
									}
									num = (short)1371209732;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1607598081;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4A0:
								wiFiRecord.IsValid = text.Equals(this.e[wiFiRecord.NetworkSSID]);
								num = (short)1258291202;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_519:
							goto IL_1A2;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_53B;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_528:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)287309826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)2110062592;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_593;
								case 2:
									goto IL_591;
								}
								goto IL_53B;
							}
							IL_591:
							IL_593:
							goto EndFinally_13;
							IL_53B:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)302710785;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_528;
							EndFinally_13:;
						}
						goto IL_594;
						IL_1A2:
						this.HasInvalidPWD = flag;
						num = (short)1363279878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_157;
					case 6:
					{
						if (!this.HasInvalidPWD)
						{
							num = (short)13107200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetWaitCount(this.f);
						global::System.Windows.Input.Cursor overrideCursor = global::System.Windows.Input.Mouse.OverrideCursor;
						global::System.Windows.Input.Mouse.OverrideCursor = global::System.Windows.Input.Cursors.Wait;
						global::System.Threading.Thread.Sleep(1000 * num4);
						global::System.Windows.Input.Mouse.OverrideCursor = overrideCursor;
						num4 *= 2;
						global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).SetWaitCount(this.f, num4);
						num = (short)1722220556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (wiFiPasswordValidationContext.ConfigurationViewSummary != null)
						{
							num = (short)1983905794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CE;
					case 8:
						if (wiFiPasswordValidationContext.APXTemplate != null)
						{
							num = (short)816971779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)656539655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return true;
					case 10:
						if (!this.NeedValidation(wiFiPasswordValidationContext.APXTemplate))
						{
							num = (short)1414266891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CE;
					case 11:
						goto IL_19D;
					case 12:
						goto IL_24F;
					}
					goto IL_8B;
					IL_CE:
					text = null;
					flag = false;
					enumerator = this.c.WiFiNetworks.GetEnumerator();
					num = (short)883425284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_594:
					num = (short)72417281;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_157:
				goto IL_5DB;
				IL_19D:
				num = (short)936443904;
				short num5 = num;
				return true;
				IL_24F:
				IL_5DB:
				return !flag;
				IL_8B:
				wiFiPasswordValidationContext = this.c;
				num = (short)1017708552;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x0400004F RID: 79
		private const int a = 1000;

		// Token: 0x04000050 RID: 80
		private static string b;

		// Token: 0x04000051 RID: 81
		private global::Motorola.CommonCPS.RadioManagement.UIModels.WiFiPasswordValidationContext c;

		// Token: 0x04000052 RID: 82
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord> d = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.Command.WiFiRecord>();

		// Token: 0x04000053 RID: 83
		private global::System.Collections.Generic.Dictionary<string, string> e = new global::System.Collections.Generic.Dictionary<string, string>();

		// Token: 0x04000054 RID: 84
		private string f;

		// Token: 0x04000055 RID: 85
		private bool g;

		// Token: 0x04000056 RID: 86
		private string h;
	}
}
