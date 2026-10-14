using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000006 RID: 6
	public class AstroFlashSequenceManager : global::Motorola.Common.Communication.AstroCpsSequenceManager, global::Motorola.Common.Communication.IFlashSequenceManager, global::Motorola.Common.Communication.IUpdatesDeviceForFlash
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00004FA0 File Offset: 0x000031A0
		public AstroFlashSequenceManager(global::Motorola.Common.Communication.IMessageExecutor rcmpWrapper, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParam) : base(rcmpWrapper, sessionParam)
		{
			this.e = false;
			this.a = 1.0;
			this.c = 1368;
			this.d = new global::Motorola.Common.Communication.c(rcmpWrapper, this.c);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004FE8 File Offset: 0x000031E8
		public override void OpenSession(ushort sessionID, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)497549313;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_BA;
				case 1:
				{
					num = (short)705193737;
					short num3 = num;
					num = (short)1726244617;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BC;
					default:
						num = (short)1234501632;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					}
					break;
				}
				case 2:
					base.UnlockRadioPartition(0);
					base.EnterProgramMode();
					num = (short)739639296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7B:
				if (operation != global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
				{
					break;
				}
				num = (short)2072903682;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BA:
			IL_BC:
			num = (short)813301761;
			if (num != 0)
			{
			}
			num = (short)1928003584;
			short num4 = num;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00005100 File Offset: 0x00003300
		public override void CloseSession(ushort sessionId, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			short num = (short)335282180;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)919649119;
					short num3 = num;
					num = (short)1598733151;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1806827520;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)504889347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					this.ValidateUpdate();
					num = (short)337313797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
					if (!pendingDeploy)
					{
						num = (short)1596850177;
						if (num != 0)
						{
						}
						num = (short)596180993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 5:
					goto IL_A9;
				}
				IL_3D:
				if (operation == global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)
				{
					num = (short)1735131136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A9:
				base.ExitProgramMode();
				num = (short)510722048;
				short num4 = num;
				num = (short)1803354114;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00005280 File Offset: 0x00003480
		public void ValidateUpdate()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			byte b;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.d.a(5, ref b) != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
					{
						num2 = (short)1102577668;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_66;
				case 2:
					if (this.e)
					{
						num2 = (short)163971077;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					if (this.d.a(6, ref b) != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
					{
						num2 = (short)1644363777;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					b = 0;
					num2 = (short)898367490;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_149;
				case 5:
				{
					num2 = (short)523269796;
					short num3 = num2;
					num2 = (short)343570084;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_66;
					default:
						num2 = (short)1969946624;
						if (num2 != 0)
						{
						}
						num2 = (short)1373241344;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_28;
			}
			IL_66:
			num2 = (short)409206785;
			if (num2 != 0)
			{
			}
			num2 = (short)1784086528;
			short num4 = num2;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_CodeplugValidationFailed);
			IL_149:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_FirmwareValidationFailed);
			IL_28:
			b = 0;
			num2 = (short)603127811;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000542C File Offset: 0x0000362C
		public void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionId, bool hostedDepotOperation, int? userDefersAllowed = null)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_79;
			}
			short num;
			int num3;
			bool a_2;
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo;
			for (;;)
			{
				IL_13:
				num = (short)1744109568;
				short num2 = num;
				switch (num3)
				{
				case 0:
					a_2 = true;
					num = (short)1057619975;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.a(pbaObject))
					{
						num = (short)1466105868;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 2:
					if (!string.IsNullOrEmpty(extendedDeviceInfo.SoftwareVersion))
					{
						num = (short)879951885;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D9;
				case 3:
					if (pbaObject.UpdateData.MemoryImages.Count > 0)
					{
						num = (short)332267528;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					if (this.f.c())
					{
						goto IL_2F1;
					}
					goto IL_1EC;
				case 5:
					if (base.ProgressIndicator != null)
					{
						num = (short)1005322246;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_13A;
				case 6:
					base.ProgressIndicator.SetCurrentScope(8, 64);
					base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeRadio);
					num = (short)558104585;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_1E7;
				case 8:
					this.f = new global::Motorola.Common.Communication.a(pbaObject.UpdateData.MemoryImages[0].FilePath);
					num = (short)1814888452;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_13A;
				case 10:
				{
					num = (short)1313488568;
					short num4 = num;
					num = (short)2112569016;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2F1;
					default:
						num = (short)1306853376;
						if (num != 0)
						{
						}
						num = (short)323092481;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					if (extendedDeviceInfo.SoftwareVersion.Substring(1, 2) == global::Motorola.Common.Communication.Crc32.c("웵짷", a_))
					{
						num = (short)645332992;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D9;
				case 12:
					num = (short)988020737;
					if (num != 0)
					{
					}
					a_2 = false;
					num = (short)1840250882;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)1225326603;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_79;
				IL_13A:
				num = (short)1951662083;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F1:
				num = (short)356450314;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_D9:
			this.a(extendedDeviceInfo, pbaObject, a_2);
			return;
			IL_183:
			this.a(extendedDeviceInfo, pbaObject);
			return;
			IL_1E7:
			goto IL_D9;
			IL_1EC:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
			IL_79:
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.CheckIfParameterIsNull(pbaObject, global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
			base.WriteValidation(pbaObject);
			extendedDeviceInfo = base.ExtendedDeviceInfo;
			this.WriteDevice(pbaObject, 0, null, hostedDepotOperation);
			num = (short)1387266053;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00005790 File Offset: 0x00003990
		public void PreUpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionID, bool hostedDepotOperation)
		{
			short num = (short)438775689;
			short num2 = num;
			num = (short)1939681161;
			switch (num2 == num)
			{
			default:
			{
				num = (short)896794624;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1640235008;
			if (num != 0)
			{
			}
			num = (short)463994881;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00005840 File Offset: 0x00003A40
		public bool WriteRamdownloader(string filepath)
		{
			short num = (short)1231613500;
			short num2 = num;
			num = (short)604171836;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2049703936;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)201719809;
			if (num != 0)
			{
			}
			num = (short)572588032;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000058F0 File Offset: 0x00003AF0
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.Pba.UpdateDeviceData images)
		{
			short num = (short)1888026625;
			if (num != 0)
			{
			}
			num = (short)1274281984;
			short num2 = num;
			num = (short)743736507;
			short num3 = num;
			num = (short)2034074811;
			switch (num3 == num)
			{
			}
			num = (short)2051080192;
			if (num != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.NotImplemented);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000059A0 File Offset: 0x00003BA0
		public override global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject writePBA, ushort sessionID, string pcrNewPassword, bool hostedDepotOperation)
		{
			short num = (short)1320157184;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					goto IL_7A;
				case 2:
				{
					num = (short)190971905;
					if (num != 0)
					{
					}
					num = (short)1755887768;
					short num3 = num;
					num = (short)1566226584;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7A;
					default:
						goto IL_F9;
					}
					break;
				}
				}
				IL_31:
				num = (short)1512636416;
				short num4 = num;
				if (base.ProgressIndicator != null)
				{
					num = (short)1706295297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_112;
				IL_7A:
				base.ProgressIndicator.SetCurrentScope(0, 7);
				num = (short)1006239746;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_F9:
			num = (short)1969946624;
			if (num != 0)
			{
			}
			IL_112:
			this.WriteRadioCodeplug(writePBA, true, hostedDepotOperation);
			return writePBA;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00005ACC File Offset: 0x00003CCC
		public override global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject referencePba, ushort sessionID)
		{
			short num = (short)1851322996;
			short num2 = num;
			num = (short)813167220;
			switch (num2 == num)
			{
			default:
			{
				num = (short)572325888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)710672385;
			if (num != 0)
			{
			}
			num = (short)312016896;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.IshItemCollection codeplug = new global::Motorola.Common.Communication.CommonUtil.IshItemCollection();
			global::Motorola.Common.Communication.Pba.PbaObject pbaObject = new global::Motorola.Common.Communication.Pba.PbaObject();
			global::Motorola.Common.Communication.RadioParams radioParams = new global::Motorola.Common.Communication.RadioParams();
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.SetCurrentScope(0, 14);
				base.ProgressIndicator.UpdateProgress(0.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadingCP);
			}
			codeplug = base.ReadRadioCodeplug();
			pbaObject.SetCodeplug(codeplug);
			pbaObject.CodeplugData.CPVersion = radioParams.CodeplugVersion;
			if (base.ProgressIndicator != null)
			{
				base.ProgressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
			}
			return pbaObject;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005BF8 File Offset: 0x00003DF8
		private bool a(global::Motorola.Common.Communication.Pba.PbaObject A_0)
		{
			int a_ = 4;
			short num = (short)1199636480;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				bool result;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)267190278;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 1:
						goto IL_2DB;
					case 2:
						goto IL_200;
					case 3:
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFlashSequenceManager.<>c.<>9.a)))
						{
							num = (short)1143603207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage;
						string empty;
						this.f.a(astroMemoryImage.ComponentName, out empty);
						string text = global::Motorola.Common.Communication.Srecord.LoadSignatureFromSrecord(empty);
						num = (short)1112211456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						return result;
					case 6:
						num = (short)1400504321;
						if (num != 0)
						{
						}
						num = (short)1986199561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST);
						string empty = string.Empty;
						num = (short)518324225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						result = true;
						num = (short)1719336960;
						short num3 = num;
						num = (short)1146290181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						string text;
						if (text.Contains(global::Motorola.Common.Communication.Crc32.c("ꃧ곩믫뷭", a_)))
						{
							num = (short)133955592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 10:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage;
						if (global::System.IO.File.Exists(astroMemoryImage.FilePath))
						{
							num = (short)1420623876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E8;
					}
					case 11:
						num = (short)1319632906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_67;
				}
				IL_200:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_67:
				result = false;
				memoryImages = A_0.UpdateData.MemoryImages;
				num = (short)974465050;
				short num4 = num;
				num = (short)959260698;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_2DB:
					global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage;
					if (!string.IsNullOrEmpty(astroMemoryImage.ComponentName))
					{
						num = (short)2095382539;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_30;
					}
					break;
				}
				default:
					num = (short)131268608;
					if (num != 0)
					{
					}
					num = (short)78577667;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				IL_1E8:
				num = (short)2109276162;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005F10 File Offset: 0x00004110
		private void a(global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1, bool A_2)
		{
			int a_ = 1;
			short num = (short)1874526208;
			switch (num)
			{
			default:
			{
				num = (short)35258378;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool a_3;
					string empty5;
					switch (num2)
					{
					case 0:
						num = (short)1964310557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_3A5;
					case 2:
					{
						byte a_2;
						if (this.d.a(global::Motorola.Common.Communication.Crc32.c("ꇤꇦ뻨ꫪ", a_), global::Motorola.Common.Communication.Crc32.c("ꇤꇦ뻨ꧪ", a_), (uint)a_2) != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)1401946127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a += 1.0;
						string empty;
						this.d.a(empty, a_3, this.c, new global::Motorola.Common.Communication.c.a(this.k));
						num = (short)696320036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (this.e)
						{
							num = (short)982712354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFlashSequenceManager.<>c.<>9.b)))
						{
							num = (short)1512177697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_402;
					}
					case 5:
					{
						a_3 = false;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.ACCY);
						string empty2 = string.Empty;
						num = (short)381485073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						num = (short)1459978239;
						short num3 = num;
						num = (short)1523089407;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_221;
						default:
						{
							num = (short)727187456;
							if (num != 0)
							{
							}
							a_3 = false;
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
							global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.MACE);
							string empty3 = string.Empty;
							num = (short)1021247525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 7:
					{
						this.a += 1.0;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2;
						string empty3;
						this.f.a(astroMemoryImage2.ComponentName, out empty3);
						this.d.a(empty3, a_3, this.c, new global::Motorola.Common.Communication.c.a(this.j));
						num = (short)1588985864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_738;
					case 9:
						goto IL_991;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_F4;
						}
						continue;
					case 11:
						goto IL_866;
					case 12:
						goto IL_148;
					case 13:
						goto IL_402;
					case 14:
					{
						byte a_2;
						if (this.d.a(global::Motorola.Common.Communication.Crc32.c("귤ꇦ뻨ꫪ", a_), global::Motorola.Common.Communication.Crc32.c("귤ꇦ뻨ꧪ", a_), (uint)a_2) != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)668008473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)659423262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_52E;
					case 16:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFlashSequenceManager.<>c.<>9.d)))
						{
							num = (short)1145372673;
							if (num != 0)
							{
							}
							num = (short)827719686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_738;
					}
					case 17:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage;
						if (!string.IsNullOrEmpty(astroMemoryImage.ComponentName))
						{
							num = (short)284164115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_986;
					}
					case 18:
						goto IL_A2B;
					case 19:
					{
						this.a += 1.0;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage;
						string empty2;
						this.f.a(astroMemoryImage.ComponentName, out empty2);
						this.d.a(empty2, a_3, this.c, new global::Motorola.Common.Communication.c.a(this.h));
						num = (short)1862139913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						a_3 = true;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage3 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.DSP);
						string empty = string.Empty;
						num = (short)1359544343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4;
						if (!string.IsNullOrEmpty(astroMemoryImage4.ComponentName))
						{
							num = (short)1851129895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F7;
					}
					case 22:
					{
						this.a += 1.0;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage5;
						string empty4;
						this.f.a(astroMemoryImage5.ComponentName, out empty4);
						this.d.a(empty4, a_3, this.c, new global::Motorola.Common.Communication.c.a(this.i));
						num = (short)1310654475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage3;
						if (!string.IsNullOrEmpty(astroMemoryImage3.ComponentName))
						{
							num = (short)1132199968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58D;
					}
					case 24:
					{
						a_3 = false;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage5 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.OPTION);
						string empty4 = string.Empty;
						num = (short)1212350504;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_31D;
					case 26:
						a_3 = false;
						num = (short)473890817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4;
						if (global::System.IO.File.Exists(astroMemoryImage4.FilePath))
						{
							num = (short)1477181478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F7;
					}
					case 28:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFlashSequenceManager.<>c.<>9.e)))
						{
							num = (short)1609695256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_866;
					}
					case 29:
					{
						if (A_0 == null)
						{
							num = (short)442761228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_3 = true;
						this.b = A_1.UpdateData.MemoryImages.Count<global::Motorola.Common.Communication.Pba.RadioImage>() + 2;
						this.a = 1.0;
						this.d.a(new global::Motorola.Common.Communication.c.a(this.m));
						byte a_2 = this.d.a(1);
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = A_1.UpdateData.MemoryImages;
						num = (short)993198084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						if (A_2)
						{
							num = (short)1388707840;
							short num4 = num;
							num = (short)573636634;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A5;
					case 31:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFlashSequenceManager.<>c.<>9.c)))
						{
							num = (short)38797332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_598;
					}
					case 32:
					{
						string empty;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage3;
						this.f.a(astroMemoryImage3.ComponentName, out empty);
						num = (short)19202050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						a_3 = true;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST);
						empty5 = string.Empty;
						goto IL_221;
					}
					case 34:
						num = (short)768802857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFlashSequenceManager.<>c.<>9.f)))
						{
							num = (short)1075380229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_991;
					}
					case 36:
						goto IL_598;
					case 37:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2;
						if (!string.IsNullOrEmpty(astroMemoryImage2.ComponentName))
						{
							num = (short)563478535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72D;
					}
					case 38:
					{
						this.e = true;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4;
						this.f.a(astroMemoryImage4.ComponentName, out empty5);
						num = (short)858587150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						num = (short)816709659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage5;
						if (!string.IsNullOrEmpty(astroMemoryImage5.ComponentName))
						{
							num = (short)366739478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_85B;
					}
					case 41:
					{
						byte a_2;
						if (this.d.b(global::Motorola.Common.Communication.Crc32.c("뗤ꏦ뷨ꫪ", a_), global::Motorola.Common.Communication.Crc32.c("뗤ꏦ뷨ꧪ", a_), (uint)a_2) != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)999686162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_F4:
					if (A_1 != null)
					{
						num = (short)629604352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_221:
					num = (short)160694293;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A5:
					this.a += 1.0;
					this.d.a(empty5, a_3, this.c, new global::Motorola.Common.Communication.c.a(this.l));
					num = (short)1718812685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_402:
					num = (short)1691942943;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_598:
					num = (short)384565264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_738:
					num = (short)862322716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_866:
					num = (short)55115811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_991:
					num = (short)1417412611;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_148:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_31D:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_UnlockPsdtFlashSectionFailed);
				IL_3F7:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_52E:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_UnlockPsdtFlashSectionFailed);
				IL_58D:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_72D:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_85B:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_986:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_A2B:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_CopyPsdtFailed);
			}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00006958 File Offset: 0x00004B58
		private void a(global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1)
		{
			int a_ = 16;
			short num = (short)1453522944;
			switch (num)
			{
			default:
			{
				num = (short)1652817966;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage3;
				string empty6;
				for (;;)
				{
					bool flag;
					string empty3;
					string empty4;
					switch (num2)
					{
					case 0:
						num = (short)1871642628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (flag)
						{
							num = (short)455737392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74D;
					case 2:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage;
						if (!string.IsNullOrEmpty(astroMemoryImage.ComponentName))
						{
							num = (short)1929642038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A1C;
					}
					case 3:
						if (this.d.a() != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)1277558794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E2;
					case 4:
					{
						string text;
						if (text.Contains(global::Motorola.Common.Communication.Crc32.c("볳냵꿷믹", a_)))
						{
							num = (short)1029636133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_412;
					}
					case 5:
						goto IL_A27;
					case 6:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2;
						if (!string.IsNullOrEmpty(astroMemoryImage2.ComponentName))
						{
							num = (short)1008271372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C9;
					}
					case 7:
						num = (short)1169555476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)1483997184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_407;
					}
					case 9:
						if (!string.IsNullOrEmpty(astroMemoryImage3.ComponentName))
						{
							num = (short)692060182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C58;
					case 10:
						goto IL_4D5;
					case 11:
					{
						string text2;
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)533987355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C0;
					}
					case 12:
					{
						this.a += 1.0;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2;
						string empty;
						this.f.a(astroMemoryImage2.ComponentName, out empty);
						this.d.a(empty, false, this.c, new global::Motorola.Common.Communication.c.a(this.d));
						num = (short)385286159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.ACCY);
						string empty2 = string.Empty;
						num = (short)1353908253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_B52;
					case 15:
						goto IL_8D4;
					case 16:
						goto IL_6CB;
					case 17:
						goto IL_17B;
					case 18:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage2 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.MACE);
						string empty = string.Empty;
						num = (short)1506738182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						flag = true;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage5 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.DSP);
						empty3 = string.Empty;
						num = (short)1464664094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (A_0 == null)
						{
							num = (short)1573060625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1818361899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFlashSequenceManager.<>c.<>9.i)))
						{
							num = (short)1697710098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D4;
					}
					case 22:
						goto IL_C0B;
					case 23:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFlashSequenceManager.<>c.<>9.k)))
						{
							num = (short)796000269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B52;
					}
					case 24:
						goto IL_543;
					case 25:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage6;
						if (!string.IsNullOrEmpty(astroMemoryImage6.ComponentName))
						{
							num = (short)1697906716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_538;
					}
					case 26:
						goto IL_412;
					case 27:
						num = (short)1316618271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)429916161;
						if (num != 0)
						{
						}
						num = (short)1007026210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4;
						if (!string.IsNullOrEmpty(astroMemoryImage4.ComponentName))
						{
							num = (short)320733231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B47;
					}
					case 30:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage5;
						if (!string.IsNullOrEmpty(astroMemoryImage5.ComponentName))
						{
							num = (short)2128281644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79E;
					}
					case 31:
					{
						string text2;
						if (text2.Contains(global::Motorola.Common.Communication.Crc32.c("냳냵꿷믹", a_)))
						{
							num = (short)1396244518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CB;
					}
					case 32:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage6;
						this.f.a(astroMemoryImage6.ComponentName, out empty4);
						string text = global::Motorola.Common.Communication.Srecord.LoadSignatureFromSrecord(empty4);
						num = (short)2025717768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.OPTION);
						string empty5 = string.Empty;
						num = (short)1584660480;
						short num3 = num;
						num = (short)2077818882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage6;
						if (global::System.IO.File.Exists(astroMemoryImage6.FilePath))
						{
							num = (short)1719205920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_538;
					}
					case 35:
					{
						num = (short)355672744;
						short num4 = num;
						num = (short)1245520552;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_299;
						default:
							num = (short)289865728;
							if (num != 0)
							{
							}
							num = (short)50069507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 36:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFlashSequenceManager.<>c.<>9.g)))
						{
							num = (short)997654581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_543;
					}
					case 37:
						flag = false;
						num = (short)1445330970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						flag = false;
						num = (short)318046224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_740;
					case 40:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFlashSequenceManager.<>c.<>9.j)))
						{
							num = (short)702414881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A27;
					}
					case 41:
						if (this.d.a() != global::Motorola.Common.Communication.CommonUtil.SequenceManagerResult.Success)
						{
							num = (short)2027290663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74D;
					case 42:
						if (flag)
						{
							num = (short)1123221539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E2;
					case 43:
					{
						if (A_1.UpdateData.MemoryImages.Count <= 0)
						{
							num = (short)1090125869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = true;
						this.b = A_1.UpdateData.MemoryImages.Count<global::Motorola.Common.Communication.Pba.RadioImage>() + 2;
						this.a = 1.0;
						this.d.a(new global::Motorola.Common.Communication.c.a(this.g));
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages = A_1.UpdateData.MemoryImages;
						num = (short)88539172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
					{
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage5;
						this.f.a(astroMemoryImage5.ComponentName, out empty3);
						string text2 = global::Motorola.Common.Communication.Srecord.LoadSignatureFromSrecord(empty3);
						num = (short)384892939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						goto IL_1CA;
					case 46:
						switch (0)
						{
						case 0:
							goto IL_129;
						}
						continue;
					case 47:
					{
						this.a += 1.0;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage4;
						string empty2;
						this.f.a(astroMemoryImage4.ComponentName, out empty2);
						this.d.a(empty2, false, this.c, new global::Motorola.Common.Communication.c.a(this.b));
						num = (short)1751777294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						num = (short)674562089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						astroMemoryImage3 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.PSDT);
						empty6 = string.Empty;
						num = (short)783220745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFlashSequenceManager.<>c.<>9.l)))
						{
							num = (short)1391984689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 51:
					{
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						if (memoryImages.Any(new global::System.Func<global::Motorola.Common.Communication.Pba.RadioImage, bool>(global::Motorola.Common.Communication.AstroFlashSequenceManager.<>c.<>9.h)))
						{
							num = (short)1057882131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A9;
					}
					case 52:
						goto IL_7A9;
					case 53:
					{
						flag = true;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.RadioImage> memoryImages;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage6 = (global::Motorola.Common.Communication.Pba.AstroMemoryImage)global::Motorola.Common.Communication.Pba.RadioImage.GetImageFromList(memoryImages, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType.HOST);
						empty4 = string.Empty;
						goto IL_299;
					}
					case 54:
					{
						this.a += 1.0;
						global::Motorola.Common.Communication.Pba.AstroMemoryImage astroMemoryImage;
						string empty5;
						this.f.a(astroMemoryImage.ComponentName, out empty5);
						this.d.a(empty5, false, this.c, new global::Motorola.Common.Communication.c.a(this.c));
						num = (short)139198469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_129:
					if (A_1 != null)
					{
						num = (short)441516039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_299:
					num = (short)211484697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_412:
					num = (short)1981022250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E2:
					this.e = true;
					this.a += 1.0;
					this.d.a(empty4, flag, this.c, new global::Motorola.Common.Communication.c.a(this.f));
					num = (short)488308760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_543:
					num = (short)45219891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6CB:
					num = (short)1671626753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_74D:
					this.a += 1.0;
					this.d.a(empty3, flag, this.c, new global::Motorola.Common.Communication.c.a(this.e));
					num = (short)1275723828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A9:
					num = (short)738787349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D4:
					num = (short)99876904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A27:
					num = (short)224329751;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B52:
					num = (short)1248985138;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17B:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentNull);
				IL_1CA:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_MissingFlashData);
				IL_407:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_4D5:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_MissingUncompressedData);
				IL_538:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_6C0:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_740:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_MissingUncompressedData);
				IL_79E:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_8C9:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_A1C:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_B47:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
				IL_C0B:
				this.a += 1.0;
				this.f.a(astroMemoryImage3.ComponentName, out empty6);
				this.d.a(empty6, false, this.c, new global::Motorola.Common.Communication.c.a(this.a));
				return;
				IL_C58:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.UpdateDevice_Astro_InvalidFlashData);
			}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000075C8 File Offset: 0x000057C8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void m(double A_0)
		{
			short num;
			for (;;)
			{
				num = (short)1758068737;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)370278401;
						if (num != 0)
						{
						}
						base.ProgressIndicator.UpdateProgress(A_0 / 100.0 / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
						num = (short)1898905602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						goto IL_B0;
					}
					IL_31:
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)1841430528;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B2:
				num = (short)2033103349;
				short num3 = num;
				num = (short)1831973365;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_E6;
				}
				IL_B0:
				goto IL_B2;
			}
			IL_E6:
			num = (short)582156288;
			short num4 = num;
			num = (short)1592131584;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000076FC File Offset: 0x000058FC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void l(double A_0)
		{
			short num;
			for (;;)
			{
				num = (short)1736114177;
				if (num != 0)
				{
				}
				num = (short)11272193;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeHost);
						num = (short)1555234818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 2:
						goto IL_B1;
					}
					IL_59:
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)557907968;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B3:
				num = (short)1365439540;
				short num3 = num;
				num = (short)1224995892;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_E8;
				}
				IL_B1:
				goto IL_B3;
			}
			IL_E8:
			num = (short)1559363584;
			short num4 = num;
			num = (short)1086062592;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00007830 File Offset: 0x00005A30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void k(double A_0)
		{
			short num;
			for (;;)
			{
				num = (short)1945829377;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1021968385;
						if (num != 0)
						{
						}
						base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeDsp);
						num = (short)1183055874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						goto IL_B2;
					}
					IL_30:
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)941752320;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B4:
				num = (short)80291932;
				short num3 = num;
				num = (short)1363224668;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_E8;
				}
				IL_B2:
				goto IL_B4;
			}
			IL_E8:
			num = (short)280166400;
			short num4 = num;
			num = (short)1715994624;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00007968 File Offset: 0x00005B68
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void j(double A_0)
		{
			short num;
			for (;;)
			{
				num = (short)792920065;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeMace);
						num = (short)463601666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						goto IL_88;
					}
					IL_30:
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)862519296;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_8A:
				num = (short)1052592412;
				short num3 = num;
				num = (short)126437660;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_BF;
				}
				IL_88:
				goto IL_8A;
			}
			IL_BF:
			num = (short)277086209;
			if (num != 0)
			{
			}
			num = (short)724172800;
			if (num != 0)
			{
			}
			num = (short)1551761408;
			short num4 = num;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00007A9C File Offset: 0x00005C9C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void i(double A_0)
		{
			short num = (short)2009123829;
			short num2 = num;
			num = (short)871025653;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)850395137;
				if (num != 0)
				{
				}
				num = (short)1939603456;
				if (num != 0)
				{
				}
				num = (short)250281986;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_F9;
					case 1:
						base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeOptBrd);
						num = (short)1507524608;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					}
					IL_A1:
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)1633288193;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_F9:
				break;
			}
			}
			num = (short)2067070976;
			short num4 = num;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00007BCC File Offset: 0x00005DCC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void h(double A_0)
		{
			short num = (short)548515560;
			short num2 = num;
			num = (short)222998248;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)923664384;
				if (num != 0)
				{
				}
				num = (short)1043267586;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_101;
					case 1:
						base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeAccBrd);
						num = (short)53608448;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					IL_7D:
					num = (short)2058944513;
					if (num != 0)
					{
					}
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)462684161;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_101:
				break;
			}
			}
			num = (short)295436288;
			short num4 = num;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00007D04 File Offset: 0x00005F04
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void g(double A_0)
		{
			short num = (short)1941817673;
			short num2 = num;
			num = (short)986106185;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)519569408;
				if (num != 0)
				{
				}
				num = (short)708968450;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_FE;
					case 1:
						base.ProgressIndicator.UpdateProgress(A_0 / 100.0 / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.EraseFlash);
						num = (short)1282932736;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7C;
						}
						continue;
					}
					IL_7C:
					num = (short)231538689;
					if (num != 0)
					{
					}
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)1083375617;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_FE:
				break;
			}
			}
			num = (short)524353536;
			short num4 = num;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00007E3C File Offset: 0x0000603C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void f(double A_0)
		{
			short num = (short)1444568091;
			short num2 = num;
			num = (short)1095261211;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)99483648;
				if (num != 0)
				{
				}
				num = (short)497614850;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_101;
					case 1:
						base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeHost);
						num = (short)1400373248;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					}
					IL_7E:
					num = (short)550961153;
					if (num != 0)
					{
					}
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)1082327041;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_101:
				break;
			}
			}
			num = (short)1394671616;
			short num4 = num;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00007F74 File Offset: 0x00006174
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void e(double A_0)
		{
			short num = (short)1554901854;
			short num2 = num;
			num = (short)2089085790;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1340604416;
				if (num != 0)
				{
				}
				num = (short)1601699842;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)583794689;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_FF;
					case 1:
						base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeDsp);
						num = (short)1265172480;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					}
					IL_A4:
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)2057502721;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_FF:
				break;
			}
			}
			num = (short)151126016;
			short num4 = num;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000080AC File Offset: 0x000062AC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void d(double A_0)
		{
			short num = (short)132562764;
			short num2 = num;
			num = (short)306954060;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2139357184;
				if (num != 0)
				{
				}
				num = (short)1699020802;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_F8;
					case 1:
						base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeMace);
						num = (short)662110208;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)729219073;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_9F;
						}
						continue;
					}
					IL_9F:
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)1722679297;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_F8:
				break;
			}
			}
			num = (short)82247680;
			short num4 = num;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000081E0 File Offset: 0x000063E0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void c(double A_0)
		{
			short num = (short)1091371891;
			short num2 = num;
			num = (short)1157366643;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)958136320;
				if (num != 0)
				{
				}
				num = (short)1065549826;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_FB;
					case 1:
						base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeOptBrd);
						num = (short)873201664;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1107951617;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					}
					IL_A4:
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)1217396737;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_FB:
				break;
			}
			}
			num = (short)2038235136;
			short num4 = num;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00008314 File Offset: 0x00006514
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(double A_0)
		{
			short num = (short)1262468145;
			short num2 = num;
			num = (short)1278458929;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1027801089;
				if (num != 0)
				{
				}
				num = (short)398196736;
				if (num != 0)
				{
				}
				num = (short)897581058;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_FC;
					case 1:
						base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradeAccBrd);
						num = (short)551550976;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					}
					IL_A3:
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)625934337;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_FC:
				break;
			}
			}
			num = (short)1999110144;
			short num4 = num;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000844C File Offset: 0x0000664C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(double A_0)
		{
			short num = (short)1062191599;
			short num2 = num;
			num = (short)2059846127;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)889389056;
				if (num != 0)
				{
				}
				num = (short)345374722;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_FF;
					case 1:
						base.ProgressIndicator.UpdateProgress(A_0 / (double)this.b + this.a / (double)this.b, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.UpgradePsdt);
						num = (short)204210176;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)811073537;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					}
					IL_A5:
					if (base.ProgressIndicator == null)
					{
						break;
					}
					num = (short)613613569;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_FF:
				break;
			}
			}
			num = (short)220725248;
			short num4 = num;
		}

		// Token: 0x04000011 RID: 17
		private double a;

		// Token: 0x04000012 RID: 18
		private int b;

		// Token: 0x04000013 RID: 19
		private int c;

		// Token: 0x04000014 RID: 20
		private readonly global::Motorola.Common.Communication.c d;

		// Token: 0x04000015 RID: 21
		private bool e;

		// Token: 0x04000016 RID: 22
		private global::Motorola.Common.Communication.a f;
	}
}
