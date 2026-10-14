using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x02000035 RID: 53
	public class RadioFeatureRequestProcessor : global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioFeatureRequestProcessor
	{
		// Token: 0x06000579 RID: 1401 RVA: 0x0003A95C File Offset: 0x00038B5C
		public RadioFeatureRequestProcessor(global::Motorola.CommonCPS.Server.EntityModel.Radio radio, global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureRequestProcessor.Operation operation)
		{
			this.a = radio.RadioFeatures.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature, bool>(this.b));
			this.b = operation;
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0003A994 File Offset: 0x00038B94
		public void Process(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> radioLicenseRequestList)
		{
			short num = (short)841285634;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)551288833;
					if (num != 0)
					{
					}
					this.c(radioLicenseRequestList);
					this.b(radioLicenseRequestList);
					num = (short)963641345;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)1599706676;
					short num3 = num;
					num = (short)1630639668;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						goto IL_F8;
					}
					break;
				}
				case 2:
					goto IL_14;
				}
				goto IL_59;
				IL_14:
				num = (short)250806272;
				short num4 = num;
				switch (0)
				{
				case 0:
					IL_59:
					if (!this.a(radioLicenseRequestList))
					{
						return;
					}
					num = (short)458817536;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F8:
			num = (short)426967040;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0003AAB4 File Offset: 0x00038CB4
		private void c(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> A_0)
		{
			short num = (short)231669772;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int? num4;
				int? num6;
				switch (num2)
				{
				case 0:
					if (this.b == global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureRequestProcessor.Operation.Restore)
					{
						num = (short)45875210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)272171008;
					short num3 = num;
					num = (short)1960312832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> enumerator = A_0.Where(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest, bool>(this.b)).GetEnumerator();
					num = (short)1117061131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					int? num5;
					num4 = num5;
					goto IL_202;
				}
				case 4:
				{
					global::Motorola.CommonCPS.Server.EntityModel.RadioFeature radioFeature = this.a.OrderByDescending(delegate(global::Motorola.CommonCPS.Server.EntityModel.RadioFeature f)
					{
						short num8 = (short)534839296;
						short num9 = num8;
						num8 = (short)2002996662;
						short num10 = num8;
						num8 = (short)509562294;
						switch (num10 == num8)
						{
						}
						num8 = (short)504168449;
						if (num8 != 0)
						{
						}
						num8 = (short)1556873216;
						if (num8 != 0)
						{
						}
						return f.FeatureName;
					}).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature>();
					if (radioFeature == null)
					{
						int? num5 = null;
						num = (short)2039545859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num4 = new int?(radioFeature.FeatureName);
					goto IL_202;
				}
				case 5:
					goto IL_121;
				case 6:
					num = (short)309460993;
					if (num != 0)
					{
					}
					if (num6 != null)
					{
						num = (short)1476657154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					if (A_0.Count(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest, bool>(this.c)) > 1)
					{
						num = (short)548798469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1102446600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (this.a.Any(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature, bool>(this.a)))
					{
						num = (short)947650569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)614203396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_176;
				case 10:
					goto IL_DE;
				case 11:
					goto IL_299;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				}
				IL_58:
				if (this.b != global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureRequestProcessor.Operation.Register)
				{
					num = (short)2041577473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_DE:
				num = (short)1554972679;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_202:
				num6 = num4;
				num = (short)1711800326;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_121:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CFS_SMA_Multiple_License_Activation);
			IL_176:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CFS_SMA_Already_Pending_activation);
			IL_299:
			try
			{
				num = (short)1800011781;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_3A8;
					case 1:
					{
						num = (short)1750991932;
						short num7 = num;
						num = (short)1901659196;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_309;
						default:
						{
							num = (short)20316160;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> enumerator;
							int featureName = enumerator.Current.FeatureName;
							int? num6;
							int? num5 = num6;
							if (featureName < num5.GetValueOrDefault() & num5 != null)
							{
								num = (short)120127488;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						break;
					}
					case 2:
						goto IL_309;
					case 3:
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)887750658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)498532353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_3CD;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_2D7;
						}
						continue;
					}
					IL_2D9:
					num = (short)1476591619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D7:
					goto IL_2D9;
					IL_309:
					num = (short)960299012;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3A8:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_CFS_SMA_Cannot_Activate_Older_License);
				IL_3CD:;
			}
			finally
			{
				num = (short)1065287682;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> enumerator;
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1202061313;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_433;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3FF;
						}
						continue;
					}
					IL_3FF:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1010827264;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_433:;
			}
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x0003AF14 File Offset: 0x00039114
		private void b(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> A_0)
		{
			int a_ = 0;
			short num = (short)353370112;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				int num3;
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> enumerator;
				global::System.Collections.Generic.List<int> requestedSMAFeatureCodes;
				global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest, bool> <>9__4;
				global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature, bool> <>9__5;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> enumerator2;
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.IEnumerable<int> first = this.a.Select(delegate(global::Motorola.CommonCPS.Server.EntityModel.RadioFeature l)
						{
							short num6 = (short)1158938624;
							short num7 = num6;
							num6 = (short)1966613942;
							short num8 = num6;
							num6 = (short)165488054;
							switch (num8 == num6)
							{
							}
							num6 = (short)1356857345;
							if (num6 != 0)
							{
							}
							num6 = (short)893321216;
							if (num6 != 0)
							{
							}
							return l.FeatureName;
						}).ToList<int>();
						requestedSMAFeatureCodes = A_0.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest req)
						{
							short num6 = (short)982253568;
							short num7 = num6;
							num6 = (short)1128497133;
							short num8 = num6;
							num6 = (short)887259117;
							switch (num8 == num6)
							{
							}
							num6 = (short)2102132736;
							if (num6 != 0)
							{
							}
							num6 = (short)2082996225;
							if (num6 != 0)
							{
							}
							return this.b(req.FeatureName);
						}).Select(delegate(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest req)
						{
							short num6 = (short)1735262208;
							short num7 = num6;
							num6 = (short)1169900331;
							short num8 = num6;
							num6 = (short)1536312107;
							switch (num8 == num6)
							{
							}
							num6 = (short)1097662465;
							if (num6 != 0)
							{
							}
							num6 = (short)1329266688;
							if (num6 != 0)
							{
							}
							return req.FeatureName;
						}).ToList<int>();
						num3 = first.Concat(requestedSMAFeatureCodes).OrderByDescending(delegate(int fc)
						{
							short num6 = (short)1246167040;
							short num7 = num6;
							num6 = (short)431681214;
							short num8 = num6;
							num6 = (short)1404300990;
							switch (num8 == num6)
							{
							}
							num6 = (short)1729101825;
							if (num6 != 0)
							{
							}
							num6 = (short)421003264;
							if (num6 != 0)
							{
							}
							return fc;
						}).First<int>();
						num = (short)356384771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> source = this.a;
						global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature, bool> predicate;
						if ((predicate = <>9__5) == null)
						{
							predicate = (<>9__5 = delegate(global::Motorola.CommonCPS.Server.EntityModel.RadioFeature l)
							{
								short num6 = (short)2126118912;
								short num7 = num6;
								num6 = (short)1584901606;
								short num8 = num6;
								num6 = (short)1523887590;
								switch (num8 == num6)
								{
								}
								num6 = (short)1621295105;
								if (num6 != 0)
								{
								}
								num6 = (short)1988493312;
								if (num6 != 0)
								{
								}
								return !requestedSMAFeatureCodes.Contains(l.FeatureName);
							});
						}
						enumerator = source.Where(predicate).GetEnumerator();
						num = (short)1133248516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)675696192;
						short num4 = num;
						num = (short)698568256;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_137;
						default:
						{
							num = (short)1687158784;
							if (num != 0)
							{
							}
							num = (short)1579548672;
							short num5 = num;
							try
							{
								num = (short)1086324736;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_25D;
										}
										continue;
									case 1:
									{
										global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest radioFeatureRequest;
										radioFeatureRequest.Visible = false;
										num = (short)1031274499;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)1534394373;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest radioFeatureRequest = enumerator2.Current;
										num = (short)1911947268;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest radioFeatureRequest;
										if (radioFeatureRequest.FeatureName < num3)
										{
											num = (short)1583349761;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										num = (short)1039269894;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										goto IL_313;
									}
									IL_25F:
									num = (short)1044709378;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_25D:
									goto IL_25F;
								}
								IL_313:;
							}
							finally
							{
								num = (short)506658817;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)209977346;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_348;
										}
										continue;
									case 2:
										goto IL_37F;
									}
									IL_348:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)2098593792;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_37F:;
							}
							num = (short)42205185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						goto IL_137;
					case 4:
						goto IL_3E9;
					}
					goto IL_4B;
					IL_137:
					num = (short)1359675393;
					if (num != 0)
					{
					}
					global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest, bool> predicate2;
					if ((predicate2 = <>9__4) == null)
					{
						predicate2 = (<>9__4 = delegate(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest l)
						{
							short num6 = (short)2133590016;
							short num7 = num6;
							num6 = (short)606675233;
							short num8 = num6;
							num6 = (short)1415717153;
							switch (num8 == num6)
							{
							}
							num6 = (short)329252865;
							if (num6 != 0)
							{
							}
							num6 = (short)642252800;
							if (num6 != 0)
							{
							}
							return this.b(l.FeatureName);
						});
					}
					enumerator2 = A_0.Where(predicate2).GetEnumerator();
					num = (short)1562509314;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3E9:
				try
				{
					num = (short)1875247104;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_42E;
							}
							continue;
						case 1:
							num = (short)1370095622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::Motorola.CommonCPS.Server.EntityModel.RadioFeature radioFeature;
							if (radioFeature.FeatureName < num3)
							{
								num = (short)974979077;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)390266881;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.RadioFeature radioFeature = enumerator.Current;
							num = (short)638648322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.CommonCPS.Server.EntityModel.RadioFeature radioFeature;
							global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest item = new global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest(radioFeature.FeatureName, global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus.Registered, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("킖햘풚\udf9c\ude9eﲢ", a_), A_0.First<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest>().RegionName, "", true)
							{
								Visible = false,
								FeatureNotice = radioFeature.FeatureNotice
							};
							A_0.Add(item);
							num = (short)632029187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_530;
						}
						IL_4D8:
						num = (short)1151991812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_42E:
						goto IL_4D8;
					}
					IL_530:;
				}
				finally
				{
					num = (short)1610874881;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1429405698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_564;
							}
							continue;
						case 2:
							goto IL_59C;
						}
						IL_564:
						if (enumerator == null)
						{
							break;
						}
						num = (short)359923712;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_59C:;
				}
				return;
				IL_4B:
				num = (short)1118765056;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x0003B4F4 File Offset: 0x000396F4
		private bool b(int featureName)
		{
			short num = (short)49159744;
			short num2 = num;
			num = (short)1418600000;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)475332608;
				short num3 = num;
				num = (short)606928897;
				if (num != 0)
				{
				}
				num = (short)1080819712;
				if (num != 0)
				{
				}
				if (featureName < 1000)
				{
					return false;
				}
				break;
			}
			}
			return featureName <= 1080;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x0003B5BC File Offset: 0x000397BC
		private bool a(int featureName)
		{
			short num = (short)1898789905;
			short num2 = num;
			num = (short)504052753;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2127298560;
				short num3 = num;
				num = (short)515637249;
				if (num != 0)
				{
				}
				num = (short)1260847104;
				if (num != 0)
				{
				}
				if (featureName <= 1001)
				{
					return false;
				}
				break;
			}
			}
			return featureName <= 1080;
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x0003B680 File Offset: 0x00039880
		private bool a(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> A_0)
		{
			short num = (short)151912448;
			short num2 = num;
			num = (short)1003334364;
			short num3 = num;
			num = (short)356297436;
			switch (num3 == num)
			{
			}
			num = (short)1035927553;
			if (num != 0)
			{
			}
			num = (short)1158807552;
			if (num != 0)
			{
			}
			return A_0.Any(new global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest, bool>(this.a));
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x0003B73C File Offset: 0x0003993C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b(global::Motorola.CommonCPS.Server.EntityModel.RadioFeature A_0)
		{
			short num = (short)1852378190;
			short num2 = num;
			num = (short)1349782606;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)19005440;
				short num3 = num;
				num = (short)416022529;
				if (num != 0)
				{
				}
				num = (short)1027866624;
				if (num != 0)
				{
				}
				if (!this.b(A_0.FeatureName))
				{
					return false;
				}
				break;
			}
			}
			return A_0.IsVisible;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x0003B800 File Offset: 0x00039A00
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest A_0)
		{
			short num = (short)438697984;
			short num2 = num;
			num = (short)1311309825;
			if (num != 0)
			{
			}
			num = (short)988437154;
			short num3 = num;
			num = (short)934894242;
			switch (num3 == num)
			{
			}
			num = (short)1132003328;
			if (num != 0)
			{
			}
			return this.b(A_0.FeatureName);
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x0003B8B8 File Offset: 0x00039AB8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.RadioFeature A_0)
		{
			for (;;)
			{
				IL_00:
				short num = (short)2110128128;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 1:
						if (A_0.DisplayStatus != 32)
						{
							num = (short)1524563971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
					{
						num = (short)1006764032;
						short num3 = num;
						num = (short)1027064524;
						short num4 = num;
						num = (short)635159244;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)2002386945;
							if (num != 0)
							{
							}
							num = (short)551485440;
							if (num != 0)
							{
							}
							num = (short)2024013825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_13B;
					}
					IL_34:
					if (!this.a(A_0.FeatureName))
					{
						goto IL_59;
					}
					num = (short)192479234;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_59:
			return A_0.DisplayStatus == 128;
			IL_13B:
			goto IL_59;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x0003BA08 File Offset: 0x00039C08
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest A_0)
		{
			short num = (short)436797440;
			short num2 = num;
			num = (short)1243691046;
			short num3 = num;
			num = (short)1750612006;
			switch (num3 == num)
			{
			}
			num = (short)176881664;
			if (num != 0)
			{
			}
			num = (short)1861419009;
			if (num != 0)
			{
			}
			return this.b(A_0.FeatureName);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0003BABC File Offset: 0x00039CBC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest A_0)
		{
			short num = (short)1792081920;
			short num2 = num;
			num = (short)1963386657;
			short num3 = num;
			num = (short)310896417;
			switch (num3 == num)
			{
			}
			num = (short)1515126785;
			if (num != 0)
			{
			}
			num = (short)1504837632;
			if (num != 0)
			{
			}
			return this.a(A_0.FeatureName);
		}

		// Token: 0x04000053 RID: 83
		private readonly global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature> a;

		// Token: 0x04000054 RID: 84
		private readonly global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureRequestProcessor.Operation b;

		// Token: 0x02000036 RID: 54
		public enum Operation
		{
			// Token: 0x04000056 RID: 86
			Register = 1,
			// Token: 0x04000057 RID: 87
			Restore,
			// Token: 0x04000058 RID: 88
			Recover
		}
	}
}
