using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using commonLicensing;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter
{
	// Token: 0x0200000E RID: 14
	public class RadioManagementSoftwareLicenseAdapter : global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.IRadioManagementSoftwareLicenseAdapter
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00004318 File Offset: 0x00002518
		private RadioManagementSoftwareLicenseAdapter()
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000432C File Offset: 0x0000252C
		public static global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.IRadioManagementSoftwareLicenseAdapter Instance
		{
			get
			{
				short num = (short)1483076493;
				short num2 = num;
				num = (short)2018374541;
				switch (num2 == num)
				{
				default:
				{
					num = (short)694419456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)387842049;
				if (num != 0)
				{
				}
				num = (short)69271552;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter.a;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000043DC File Offset: 0x000025DC
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> QueryLicensesFromEntitlementID(string eid)
		{
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioEntitledLicense> result;
			try
			{
				num = (short)1956970496;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_A3;
					}
					global::Motorola.CommonCPS.Server.EntityModel.EntitlementList entitlementDetails;
					int num4;
					for (;;)
					{
						IL_28:
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem>.Enumerator enumerator;
						switch (num2)
						{
						case 0:
							if (entitlementDetails.newFlashCode != null)
							{
								num = (short)667549715;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4A7;
						case 1:
						{
							string newFlashCode = entitlementDetails.newFlashCode;
							entitlementDetails.currentFlashCode = this.expandFlashcode(newFlashCode);
							num = (short)952041499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_95B;
						case 3:
							num = (short)2094137367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							try
							{
								num = (short)1726873606;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_3D0;
									case 1:
									{
										global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem;
										if (entitlementResponseItem.newFlashCode != null)
										{
											num = (short)727121933;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_462;
									case 3:
										num = (short)1385562114;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem;
										string newFlashCode2 = entitlementResponseItem.newFlashCode;
										entitlementResponseItem.newFlashCode = this.expandFlashcode(newFlashCode2);
										num = (short)1359544328;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem;
										if (entitlementResponseItem.newFlashCode.Length <= 15)
										{
											num = (short)639696900;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_243;
										}
										continue;
									case 7:
										num = (short)2111832076;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
									{
										num = (short)1980407472;
										short num3 = num;
										num = (short)40083120;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
										{
											num = (short)1258291200;
											if (num != 0)
											{
											}
											global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem;
											string currentFlashCode = entitlementResponseItem.currentFlashCode;
											entitlementResponseItem.currentFlashCode = this.expandFlashcode(currentFlashCode);
											break;
										}
										}
										num = (short)1583349760;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)889389059;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem = enumerator.Current;
										num = (short)1471545355;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
									{
										global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem;
										if (entitlementResponseItem.currentFlashCode != null)
										{
											num = (short)1610481671;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3D0;
									}
									case 12:
									{
										global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem;
										if (entitlementResponseItem.currentFlashCode.Length <= 15)
										{
											num = (short)2127298569;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_3D0;
									}
									case 13:
										num = (short)1276182533;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_243;
									IL_3D0:
									num = (short)1635844097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_40B:
									num = (short)2124218378;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_243:
									goto IL_40B;
								}
								IL_462:
								goto IL_99C;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_475;
						case 5:
							num = (short)1022885896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (entitlementDetails.newFlashCode != null)
							{
								num = (short)923664389;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_69D;
						case 7:
							if (!string.IsNullOrEmpty(entitlementDetails.currentFlashCode))
							{
								num = (short)1412235273;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_99C;
						case 8:
							if (entitlementDetails.newFlashCode.Length <= num4)
							{
								num = (short)1725038614;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_69D;
						case 9:
							num = (short)275447833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							num = (short)1156775964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							if (entitlementDetails.newFlashCode.Length <= 15)
							{
								num = (short)792526849;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4A7;
						case 12:
							goto IL_69D;
						case 13:
						{
							string currentFlashCode2 = entitlementDetails.currentFlashCode;
							entitlementDetails.currentFlashCode = this.expandFlashcode(currentFlashCode2);
							num = (short)1455751170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							if (entitlementDetails.currentFlashCode != null)
							{
								num = (short)133365770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_95B;
						case 15:
							goto IL_475;
						case 16:
							try
							{
								num = (short)1191575558;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem2;
										string currentFlashCode3 = entitlementResponseItem2.currentFlashCode;
										entitlementResponseItem2.currentFlashCode = this.expandFlashcode(currentFlashCode3);
										num = (short)1639251976;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
									{
										global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem2;
										if (entitlementResponseItem2.newFlashCode != null)
										{
											num = (short)2142961677;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_900;
									case 3:
									{
										global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem2;
										string newFlashCode3 = entitlementResponseItem2.newFlashCode;
										entitlementResponseItem2.newFlashCode = this.expandFlashcode(newFlashCode3);
										num = (short)1031798796;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										num = (short)963575817;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem2;
										if (entitlementResponseItem2.currentFlashCode != null)
										{
											num = (short)1918369796;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_85E;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_725;
										}
										continue;
									case 7:
										num = (short)1687617538;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										goto IL_85E;
									case 9:
									{
										global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem2;
										if (entitlementResponseItem2.currentFlashCode.Length <= num4)
										{
											num = (short)1999568896;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_85E;
									}
									case 10:
									{
										global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem2;
										if (entitlementResponseItem2.newFlashCode.Length <= num4)
										{
											num = (short)797966339;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 11:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1005060103;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem2 = enumerator.Current;
										num = (short)1767571461;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 13:
										num = (short)1691877386;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_7D5:
									num = (short)1534656523;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_725:
									goto IL_7D5;
									IL_85E:
									num = (short)1883832321;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_900:;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							num = (short)1553334286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							goto IL_9C9;
						case 18:
							goto IL_545;
						case 19:
							num = (short)1751908363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							if (entitlementDetails != null)
							{
								num = (short)1160642581;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_950;
						case 21:
							num = (short)1002962970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
						{
							string newFlashCode4 = entitlementDetails.newFlashCode;
							entitlementDetails.currentFlashCode = this.expandFlashcode(newFlashCode4);
							num = (short)770113548;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							if (entitlementDetails.currentFlashCode.Length <= num4)
							{
								num = (short)1681784847;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_587;
						case 24:
							goto IL_587;
						case 25:
							if (entitlementDetails.currentFlashCode != null)
							{
								num = (short)1564278787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_587;
						case 26:
							if (entitlementDetails.entitlementItems.Count == 0)
							{
								num = (short)127991826;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2137784327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							goto IL_4A7;
						case 28:
							if (entitlementDetails.currentFlashCode.Length <= 15)
							{
								num = (short)1841496077;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_95B;
						}
						goto IL_A3;
						IL_475:
						string currentFlashCode4 = entitlementDetails.currentFlashCode;
						entitlementDetails.currentFlashCode = this.expandFlashcode(currentFlashCode4);
						num = (short)1202192408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4A7:
						enumerator = entitlementDetails.entitlementItems.GetEnumerator();
						num = (short)795803652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_587:
						num = (short)1830289414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_69D:
						enumerator = entitlementDetails.entitlementItems.GetEnumerator();
						num = (short)572325904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_95B:
						num = (short)608174080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_99C:
						result = global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.e.a(entitlementDetails.currentFlashCode).a(entitlementDetails, eid);
						num = (short)1016004625;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_545:
					IL_950:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_License_Error_Empty_EID);
					IL_9C9:
					break;
					IL_A3:
					bool flag;
					entitlementDetails = global::commonLicensing.CommonLicenseInterface.GetEntitlementDetails(eid, out flag, false, false);
					num4 = 15;
					num = (short)1366949908;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_License_Error_Unknown);
			}
			num = (short)1133379584;
			short num5 = num;
			num = (short)1396637697;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004E7C File Offset: 0x0000307C
		public string expandFlashcode(string originalFlashcode)
		{
			int a_ = 4;
			short num = (short)244149401;
			short num2 = num;
			num = (short)997158041;
			switch (num2 == num)
			{
			}
			num = (short)285999105;
			if (num != 0)
			{
			}
			num = (short)893190144;
			if (num != 0)
			{
			}
			num = (short)1816723456;
			short num3 = num;
			string str = global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense.b("坹䱻乽끿늁뒃뚅ꖇ몉벋뺍ꂏꊑ꒓", a_);
			return originalFlashcode + str;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004F44 File Offset: 0x00003144
		public global::Motorola.CommonCPS.Server.EntityModel.EntitlementList QueryAppLicensesFromEntitlementID(string eid)
		{
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.EntitlementList entitlementDetails;
			try
			{
				num = (short)952470306;
				short num2 = num;
				num = (short)1146063650;
				switch (num2 == num)
				{
				}
				num = (short)1042939904;
				if (num != 0)
				{
				}
				bool flag;
				entitlementDetails = global::commonLicensing.CommonLicenseInterface.GetEntitlementDetails(eid, out flag, false, false);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_License_Error_Unknown);
			}
			num = (short)95158272;
			short num3 = num;
			num = (short)1161166849;
			if (num != 0)
			{
			}
			return entitlementDetails;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00005028 File Offset: 0x00003228
		public byte[] SubmitLicense(string radioSerialNumber, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> licenses)
		{
			short num;
			byte[] result;
			try
			{
				num = (short)2132869120;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_3F;
					}
					byte[] array;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense>.Enumerator enumerator;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> source;
					for (;;)
					{
						IL_28:
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation> list;
						switch (num2)
						{
						case 0:
							try
							{
								num = (short)97124354;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_12B;
									case 1:
									{
										global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense radioSoftwareLicense;
										if (!global::commonLicensing.CommonLicenseInterface.ValidateResponse(array, radioSerialNumber, radioSoftwareLicense.AID))
										{
											num = (short)728039424;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_B2;
										}
										continue;
									case 3:
										num = (short)1736704001;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_19B;
									case 5:
										num = (short)77987844;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1031471109;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense radioSoftwareLicense = enumerator.Current;
										num = (short)32309255;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense radioSoftwareLicense;
										if (radioSoftwareLicense.CanValidateResponseByAID)
										{
											num = (short)1233649667;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_B4:
									num = (short)1824063494;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_B2:
									goto IL_B4;
								}
								IL_12B:
								throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SFC_RM_ERROR_RESPSONSE_RECEIVED_FROM_SERVER);
								IL_19B:
								goto IL_442;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto Block_3;
							IL_442:
							result = array;
							num = (short)1428160513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_45D;
						case 2:
							goto IL_1AE;
						case 3:
							try
							{
								num = (short)1907949571;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_3FC;
									case 1:
										num = (short)769654784;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1574895617;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation> collection = enumerator.Current.GenerateActivationInfo();
										list.AddRange(collection);
										num = (short)254083076;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										switch (0)
										{
										case 0:
											goto IL_32B;
										}
										continue;
									case 4:
										goto IL_37A;
									}
									IL_32B:
									num = (short)1466943242;
									short num3 = num;
									num = (short)1853081354;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)176750592;
										if (num != 0)
										{
										}
										break;
									}
									IL_37A:
									num = (short)1398079490;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_3FC:
								goto IL_2BE;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_40F;
						}
						goto IL_3F;
						IL_2BE:
						array = global::commonLicensing.CommonLicenseInterface.SendRequestToServer(global::commonLicensing.CommonLicenseInterface.CreateActivationRequest(radioSerialNumber, list), false);
						enumerator = licenses.GetEnumerator();
						num = (short)794492928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						Block_3:
						try
						{
							IL_1AE:
							num = (short)104595460;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_243;
								case 1:
									goto IL_2AB;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)470548485;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense a = enumerator.Current;
									num = (short)2007695363;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									if (source.Any(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense, bool>(a2.b)))
									{
										num = (short)1907032064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1EC;
									}
									continue;
								case 5:
									num = (short)1719205889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_250:
								num = (short)693633026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1EC:
								goto IL_250;
							}
							IL_243:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_License_Error_Already_Registered);
							IL_2AB:
							goto IL_40F;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2BE;
						IL_40F:
						array = null;
						list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation>(licenses.Count);
						enumerator = licenses.GetEnumerator();
						num = (short)775684099;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_45D:
					break;
					IL_3F:
					array = null;
					source = this.RecoverLicenses(radioSerialNumber, out array);
					enumerator = licenses.GetEnumerator();
					num = (short)1042939906;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_License_Error_Unknown);
			}
			num = (short)196935681;
			if (num != 0)
			{
			}
			num = (short)1374879744;
			short num4 = num;
			return result;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00005574 File Offset: 0x00003774
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> RecoverLicenses(string radioSerialNumber, out byte[] capabilityResponse)
		{
			short num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> result;
			try
			{
				for (;;)
				{
					num = (short)242286592;
					switch (num)
					{
					default:
					{
						num = (short)1439733190;
						short num2 = num;
						num = (short)2089391558;
						switch ((num2 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_51;
						}
						break;
					}
					}
				}
				IL_51:
				num = (short)1722875904;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest deviceRequest = global::commonLicensing.CommonLicenseInterface.CreateRecoverRequest(radioSerialNumber);
				capabilityResponse = global::commonLicensing.CommonLicenseInterface.SendRefreshRequestToServer(deviceRequest, false);
				global::Motorola.CommonCPS.Server.EntityModel.FeatureList featureList = global::commonLicensing.CommonLicenseInterface.QueryFeaturesFromResponse(capabilityResponse, radioSerialNumber, string.Empty, string.Empty, false);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense>();
				global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.c c = global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.e.a(featureList.currentFlashCode);
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.FeatureItem>.Enumerator enumerator = featureList.features.GetEnumerator())
				{
					num = (short)1485307912;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (b.a != null)
							{
								num = (short)1918042116;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1999241222;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.FeatureItem a_ = enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense a = c.c(featureList, a_);
							num = (short)1472200704;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							list.Add(b.a);
							num = (short)187170821;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_21A;
						case 4:
							num = (short)1407582215;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)1179254787;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (!list.Any(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense, bool>(b.b)))
							{
								num = (short)2086731778;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_F6;
							}
							continue;
						}
						IL_152:
						num = (short)1276772353;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_F6:
						goto IL_152;
					}
					IL_21A:;
				}
				result = list;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_License_Error_Unknown);
			}
			num = (short)570556416;
			short num4 = num;
			num = (short)691339265;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00005864 File Offset: 0x00003A64
		public global::Motorola.CommonCPS.Server.EntityModel.FeatureList RetrieveLicenses(string deviceID, out byte[] capabilityResponse)
		{
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.FeatureList result;
			try
			{
				num = (short)2017267371;
				short num2 = num;
				num = (short)1257311915;
				switch (num2 == num)
				{
				}
				num = (short)189792256;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest deviceRequest = global::commonLicensing.CommonLicenseInterface.CreateRecoverRequest(deviceID);
				capabilityResponse = global::commonLicensing.CommonLicenseInterface.SendRefreshRequestToServer(deviceRequest, false);
				result = global::commonLicensing.CommonLicenseInterface.QueryFeaturesFromResponse(capabilityResponse, deviceID, string.Empty, string.Empty, false);
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_License_Error_Unknown);
			}
			num = (short)1764229120;
			short num3 = num;
			num = (short)1460404225;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00005960 File Offset: 0x00003B60
		public byte[] SubmitAppLicense(global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest request, string hostID, global::System.Collections.Generic.List<string> aidsToValidate, out string warningMessage)
		{
			short num = (short)65339392;
			short num2 = num;
			warningMessage = string.Empty;
			byte[] array = null;
			goto IL_36;
			byte[] result;
			try
			{
				for (;;)
				{
					IL_36:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					int num3;
					for (;;)
					{
						IL_40:
						switch (num3)
						{
						case 0:
							result = array;
							num = (short)964362244;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (global::commonLicensing.CommonLicenseInterface.ValidateResponse(array, hostID, aidsToValidate))
							{
								num = (short)1844183040;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15A;
						case 2:
						{
							num = (short)1285366510;
							short num4 = num;
							num = (short)312615662;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_36;
							default:
								num = (short)1016201217;
								if (num != 0)
								{
								}
								num = (short)655949824;
								if (num != 0)
								{
								}
								if (array != null)
								{
									num = (short)1171980291;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_15A;
							}
							break;
						}
						case 3:
							num = (short)699662337;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_158;
						}
						break;
					}
					IL_5A:
					array = global::commonLicensing.CommonLicenseInterface.SendRequestToServer(request, false);
					num = (short)352583682;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_40;
				}
				IL_158:
				return result;
				IL_15A:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SFC_RM_ERROR_RESPSONSE_RECEIVED_FROM_SERVER);
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.SFC_RM_NO_FEATURE_ON_SERVER)
				{
					throw;
				}
				warningMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.SFC_RM_NO_FEATURE_ON_SERVER;
				result = array;
			}
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005B0C File Offset: 0x00003D0C
		public byte[] SubmitAppLicense(global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest request, string hostID, string AID, out string warningMessage)
		{
			short num = (short)151322624;
			short num2 = num;
			warningMessage = string.Empty;
			byte[] array = null;
			goto IL_36;
			byte[] result;
			try
			{
				for (;;)
				{
					IL_36:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					int num3;
					for (;;)
					{
						IL_40:
						switch (num3)
						{
						case 0:
							result = array;
							num = (short)403767300;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (global::commonLicensing.CommonLicenseInterface.ValidateResponse(array, hostID, AID))
							{
								num = (short)753139712;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_160;
						case 2:
						{
							num = (short)2002513265;
							short num4 = num;
							num = (short)1276308849;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_36;
							default:
								num = (short)655753217;
								if (num != 0)
								{
								}
								num = (short)702283776;
								if (num != 0)
								{
								}
								if (array != null)
								{
									num = (short)1572867;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_160;
							}
							break;
						}
						case 3:
							num = (short)500891649;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_15E;
						}
						break;
					}
					IL_5A:
					array = global::commonLicensing.CommonLicenseInterface.SendRequestToServer(request, false);
					num = (short)11403266;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_40;
				}
				IL_15E:
				return result;
				IL_160:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SFC_RM_ERROR_RESPSONSE_RECEIVED_FROM_SERVER);
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.SFC_RM_NO_FEATURE_ON_SERVER)
				{
					throw;
				}
				warningMessage = global::Motorola.CommonCPS.ResourceRepository.Resources.SFC_RM_NO_FEATURE_ON_SERVER;
				result = array;
			}
			return result;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00005CC0 File Offset: 0x00003EC0
		public global::Motorola.CommonCPS.Server.EntityModel.FeatureList QueryFeaturesFromResponse(byte[] response, string deviceID, string featureName, string featureVersion, bool useTrustedStorage = false)
		{
			short num = (short)588600984;
			short num2 = num;
			num = (short)2077906584;
			switch (num2 == num)
			{
			}
			num = (short)1780219904;
			if (num != 0)
			{
			}
			num = (short)181862400;
			short num3 = num;
			num = (short)1265827841;
			if (num != 0)
			{
			}
			return global::commonLicensing.CommonLicenseInterface.QueryFeaturesFromResponse(response, deviceID, featureName, featureVersion, false);
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005D78 File Offset: 0x00003F78
		public string GetAIDFromFeature(global::Motorola.CommonCPS.Server.EntityModel.FeatureItem feature)
		{
			short num = (short)1313031168;
			short num2 = num;
			num = (short)431506432;
			switch (num2 == num)
			{
			}
			num = (short)1838678017;
			if (num != 0)
			{
			}
			num = (short)1487405056;
			short num3 = num;
			num = (short)1290928128;
			if (num != 0)
			{
			}
			return global::commonLicensing.CommonLicenseInterface.GetAIDFromFeature(feature);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00005E24 File Offset: 0x00004024
		public byte[] RecoverAppLicense(string hostID, out string warningMsg)
		{
			short num = (short)1114339026;
			short num2 = num;
			num = (short)1831040722;
			byte[] array;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1678180353;
				if (num != 0)
				{
				}
				num = (short)238354432;
				if (num != 0)
				{
				}
				num = (short)172032000;
				short num3 = num;
				array = null;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_B9;
					}
					int num4;
					for (;;)
					{
						IL_A7:
						switch (num4)
						{
						case 0:
							goto IL_FB;
						case 1:
							if (array == null)
							{
								num = (short)588906496;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)669515778;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_11D;
						}
						goto IL_B9;
					}
					IL_FB:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.SFC_RM_ERROR_RESPSONSE_RECEIVED_FROM_SERVER);
					IL_11D:
					break;
					IL_B9:
					global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest request = global::commonLicensing.CommonLicenseInterface.CreateRecoverRequest(hostID);
					array = this.SubmitAppLicense(request, hostID, string.Empty, out warningMsg);
					num = (short)1229258753;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_A7;
				}
				catch (global::Motorola.Common.CustomException.CommonException)
				{
					throw;
				}
				catch (global::System.Exception)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_License_Error_Unknown);
				}
				break;
			}
			}
			return array;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005F7C File Offset: 0x0000417C
		public global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest CreateActivationRequest(string hostID, string AID, int count)
		{
			short num = (short)1619052525;
			short num2 = num;
			num = (short)114870253;
			switch (num2 == num)
			{
			}
			num = (short)981401601;
			if (num != 0)
			{
			}
			num = (short)1125318656;
			short num3 = num;
			num = (short)174784512;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation item = default(global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation);
			item.ID = AID;
			item.Count = count;
			return global::commonLicensing.CommonLicenseInterface.CreateActivationRequest(hostID, new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation>
			{
				item
			});
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006050 File Offset: 0x00004250
		// Note: this type is marked as 'beforefieldinit'.
		static RadioManagementSoftwareLicenseAdapter()
		{
			short num = (short)1582219392;
			short num2 = num;
			num = (short)897499264;
			switch (num2 == num)
			{
			}
			num = (short)2114387969;
			if (num != 0)
			{
			}
			num = (short)533790720;
			short num3 = num;
			num = (short)575406080;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter.a = new global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter();
		}

		// Token: 0x0400000F RID: 15
		private static global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.IRadioManagementSoftwareLicenseAdapter a;

		// Token: 0x0200000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000053 RID: 83 RVA: 0x00006118 File Offset: 0x00004318
			internal bool b(global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense A_0)
			{
				short num = (short)967176492;
				short num2 = num;
				num = (short)834269484;
				switch (num2 == num)
				{
				}
				num = (short)181862401;
				if (num != 0)
				{
				}
				num = (short)1046478848;
				short num3 = num;
				num = (short)663683072;
				if (num != 0)
				{
				}
				return A_0.IsSameLicense(this.a);
			}

			// Token: 0x04000010 RID: 16
			public global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense a;
		}

		// Token: 0x02000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x06000055 RID: 85 RVA: 0x000061E0 File Offset: 0x000043E0
			internal bool b(global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense A_0)
			{
				short num = (short)1673905740;
				short num2 = num;
				num = (short)507561548;
				switch (num2 == num)
				{
				}
				num = (short)1426522112;
				if (num != 0)
				{
				}
				num = (short)1000472576;
				short num3 = num;
				num = (short)1212743681;
				if (num != 0)
				{
				}
				return A_0.IsSameLicense(this.a);
			}

			// Token: 0x04000011 RID: 17
			public global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioSoftwareLicense a;
		}
	}
}
