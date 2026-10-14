using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.AmpPasswords;
using Motorola.Common.Communication.AmpRequest;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Extensions;
using Motorola.Common.Communication.Pba;
using Motorola.Common.Communication.Utils;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	public class AmpApSequenceManager : global::Motorola.Common.Communication.ISequenceManager, global::Motorola.Common.Communication.IIshBlockSupport, global::Motorola.Common.Communication.IUpdatesDeviceForFlash
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000256C File Offset: 0x0000076C
		public AmpApSequenceManager(global::Motorola.Common.Communication.IMessageExecutor messageExecutor, global::Motorola.Common.Communication.IAmpPackageFilePathProvider packagePathProvider)
		{
			this.b = messageExecutor;
			this.d = packagePathProvider;
			this.e = new global::Motorola.Common.Communication.Utils.AmpRequestRepeater(this.b, this.c);
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000025B8 File Offset: 0x000007B8
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002668 File Offset: 0x00000868
		public global::Motorola.Common.Communication.IProgressIndicator ProgressIndicator
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)918146041;
				short num2 = num;
				num = (short)869649401;
				switch (num2 == num)
				{
				}
				num = (short)1970995201;
				if (num != 0)
				{
				}
				num = (short)1124728832;
				short num3 = num;
				num = (short)667353088;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)620232705;
				if (num != 0)
				{
				}
				num = (short)1887723246;
				short num2 = num;
				num = (short)1976327918;
				switch (num2 == num)
				{
				}
				num = (short)1212612608;
				short num3 = num;
				num = (short)1255669760;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002718 File Offset: 0x00000918
		// (set) Token: 0x06000008 RID: 8 RVA: 0x000027C8 File Offset: 0x000009C8
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ExtendedDeviceInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)235609505;
				short num2 = num;
				num = (short)1005591969;
				switch (num2 == num)
				{
				}
				num = (short)1719795712;
				if (num != 0)
				{
				}
				num = (short)1850081280;
				short num3 = num;
				num = (short)727515137;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2073352156;
				short num2 = num;
				num = (short)1341052892;
				switch (num2 == num)
				{
				}
				num = (short)508428289;
				if (num != 0)
				{
				}
				num = (short)1981284352;
				short num3 = num;
				num = (short)737280000;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x0000287C File Offset: 0x00000A7C
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaobject, ushort sessionIdUshort)
		{
			int a_ = 6;
			short num;
			global::Motorola.Common.Communication.Pba.PbaObject result;
			try
			{
				num = (short)88408064;
				switch (num)
				{
				default:
				{
					num = (short)1237647367;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							string[] array = new string[6];
							int num3 = 0;
							string format = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("귵菷쫹臻ꏽ寿礁㔃笅唇儉看㰍洏休伓洕⬗朙䄛䔝爟䜡䔣䈥氧伩娫䜭匯圱椳", a_);
							object[] array2 = new object[4];
							int num4 = 0;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = this.ExtendedDeviceInfo;
							global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType;
							if (extendedDeviceInfo == null)
							{
								connectionType = null;
							}
							else
							{
								global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = extendedDeviceInfo.ConnectionInfo;
								connectionType = ((connectionInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo.ConnectionType) : null);
							}
							array2[num4] = connectionType;
							int num5 = 1;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo2 = this.ExtendedDeviceInfo;
							array2[num5] = ((extendedDeviceInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo2.Family) : null);
							int num6 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo3 = this.ExtendedDeviceInfo;
							array2[num6] = ((extendedDeviceInfo3 != null) ? extendedDeviceInfo3.SerialNumber : null);
							int num7 = 3;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo4 = this.ExtendedDeviceInfo;
							array2[num7] = ((extendedDeviceInfo4 != null) ? extendedDeviceInfo4.ModelNumber : null);
							array[num3] = string.Format(format, array2);
							array[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("귵", a_);
							int num8 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo5 = this.ExtendedDeviceInfo;
							array[num8] = ((extendedDeviceInfo5 != null) ? extendedDeviceInfo5.SoftwareVersion : null);
							array[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꯵ꏷ", a_);
							int num9 = 4;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo6 = this.ExtendedDeviceInfo;
							array[num9] = ((extendedDeviceInfo6 != null) ? extendedDeviceInfo6.CodeplugVersion : null);
							array[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꯵\ud8f7裹駻鿽擿∁會朅欇戉椋樍』焑笓爕紗標瀛欝䜟ȡ䴣唥ࠧ䰩䔫䀭夯䄱尳匵尷ᐹ", a_);
							global::System.Diagnostics.Trace.TraceInformation(string.Concat(array));
							result = this.f;
							num = (short)1884094465;
							if (num != 0)
							{
							}
							num = (short)1290928131;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							if (this.f != null)
							{
								num = (short)1253244934;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = this.a();
							num = (short)1995702276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator = this.ProgressIndicator;
							if (progressIndicator == null)
							{
								num = (short)529793029;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
							num = (short)309854217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_48F;
						case 4:
							goto IL_4B4;
						case 5:
							goto IL_302;
						case 6:
						{
							num = (short)346618832;
							short num10 = num;
							num = (short)1688533968;
							switch ((num10 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_C8;
							default:
								num = (short)896335872;
								if (num != 0)
								{
								}
								num = (short)949878786;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							switch (0)
							{
							case 0:
								goto IL_7F;
							}
							continue;
						case 8:
							goto IL_C8;
						case 9:
							goto IL_302;
						case 10:
						{
							string[] array3 = new string[6];
							int num11 = 0;
							string format2 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("귵菷쫹臻ꏽ寿礁㔃笅唇儉看㰍洏休伓洕⬗朙䄛䔝爟䜡䔣䈥氧伩娫䜭匯圱椳", a_);
							object[] array4 = new object[4];
							int num12 = 0;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo7 = this.ExtendedDeviceInfo;
							global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType2;
							if (extendedDeviceInfo7 == null)
							{
								connectionType2 = null;
							}
							else
							{
								global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo2 = extendedDeviceInfo7.ConnectionInfo;
								connectionType2 = ((connectionInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo2.ConnectionType) : null);
							}
							array4[num12] = connectionType2;
							int num13 = 1;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo8 = this.ExtendedDeviceInfo;
							array4[num13] = ((extendedDeviceInfo8 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo8.Family) : null);
							int num14 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo9 = this.ExtendedDeviceInfo;
							array4[num14] = ((extendedDeviceInfo9 != null) ? extendedDeviceInfo9.SerialNumber : null);
							int num15 = 3;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo10 = this.ExtendedDeviceInfo;
							array4[num15] = ((extendedDeviceInfo10 != null) ? extendedDeviceInfo10.ModelNumber : null);
							array3[num11] = string.Format(format2, array4);
							array3[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("귵", a_);
							int num16 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo11 = this.ExtendedDeviceInfo;
							array3[num16] = ((extendedDeviceInfo11 != null) ? extendedDeviceInfo11.SoftwareVersion : null);
							array3[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꯵ꏷ", a_);
							int num17 = 4;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo12 = this.ExtendedDeviceInfo;
							array3[num17] = ((extendedDeviceInfo12 != null) ? extendedDeviceInfo12.CodeplugVersion : null);
							array3[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꯵\ud8f7裹駻鿽擿∁會椅氇漉簋戍攏甑㐓缕欗㨙漛樝䄟倡倣䌥䰧Щ", a_);
							global::System.Diagnostics.Trace.TraceInformation(string.Concat(array3));
							num = (short)1700724737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_C8;
						}
						IL_7F:
						global::Motorola.Common.Communication.IProgressIndicator progressIndicator2 = this.ProgressIndicator;
						if (progressIndicator2 == null)
						{
							num = (short)1536819211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						progressIndicator2.UpdateProgress(0.0);
						num = (short)1110048776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C8:
						num = (short)124059658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_302:
						num = (short)1156644864;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_48F:
					IL_4B4:
					break;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				string[] array5 = new string[7];
				int num18 = 0;
				string format3 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("귵菷쫹臻ꏽ寿礁㔃笅唇儉看㰍洏休伓洕⬗朙䄛䔝爟䜡䔣䈥氧伩娫䜭匯圱椳", a_);
				object[] array6 = new object[4];
				int num19 = 0;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo13 = this.ExtendedDeviceInfo;
				global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType3;
				if (extendedDeviceInfo13 == null)
				{
					connectionType3 = null;
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo3 = extendedDeviceInfo13.ConnectionInfo;
					connectionType3 = ((connectionInfo3 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo3.ConnectionType) : null);
				}
				array6[num19] = connectionType3;
				int num20 = 1;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo14 = this.ExtendedDeviceInfo;
				array6[num20] = ((extendedDeviceInfo14 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo14.Family) : null);
				int num21 = 2;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo15 = this.ExtendedDeviceInfo;
				array6[num21] = ((extendedDeviceInfo15 != null) ? extendedDeviceInfo15.SerialNumber : null);
				int num22 = 3;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo16 = this.ExtendedDeviceInfo;
				array6[num22] = ((extendedDeviceInfo16 != null) ? extendedDeviceInfo16.ModelNumber : null);
				array5[num18] = string.Format(format3, array6);
				array5[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("귵", a_);
				int num23 = 2;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo17 = this.ExtendedDeviceInfo;
				array5[num23] = ((extendedDeviceInfo17 != null) ? extendedDeviceInfo17.SoftwareVersion : null);
				array5[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꯵ꏷ", a_);
				int num24 = 4;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo18 = this.ExtendedDeviceInfo;
				array5[num24] = ((extendedDeviceInfo18 != null) ? extendedDeviceInfo18.CodeplugVersion : null);
				array5[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꯵\ud8f7뿹蓻鷽旿爁瀃漅朇搉Ⰻ挍甏愑朓眕缗缙☛㸝", a_);
				array5[6] = ex.Message;
				global::System.Diagnostics.Trace.TraceError(string.Concat(array5), new object[]
				{
					ex.StackTrace,
					ex.StackTrace
				});
				throw ex;
			}
			num = (short)665714688;
			short num25 = num;
			return result;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002EDC File Offset: 0x000010DC
		private global::Motorola.Common.Communication.Pba.PbaObject a()
		{
			int a_ = 14;
			short num;
			global::Motorola.Common.Communication.Pba.PbaObject result;
			try
			{
				num = (short)1047068672;
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
					global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor a_4;
					for (;;)
					{
						IL_30:
						global::System.IO.Stream a_2;
						switch (num2)
						{
						case 0:
						{
							byte[] cmp = this.a(a_2);
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator = this.ProgressIndicator;
							if (progressIndicator != null)
							{
								progressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.ReadCPDone);
							}
							global::Motorola.Common.Communication.Pba.PbaObject pbaObject = cmp.ToPbaObject(this.ExtendedDeviceInfo.CodeplugVersion);
							global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo ampDeviceInfo = (global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo)this.ExtendedDeviceInfo;
							global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.UpdatePinPasswordAfterRead(pbaObject, ampDeviceInfo.ElectronicSerialNumber);
							global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.UpdateWiFiPasswordAfterRead(pbaObject, ampDeviceInfo.ElectronicSerialNumber);
							global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.UpdateExternalDataModemPasswordAfterRead(pbaObject, ampDeviceInfo.ElectronicSerialNumber);
							num = (short)1146486787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_187;
						case 2:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator2 = this.ProgressIndicator;
							if (progressIndicator2 == null)
							{
								num = (short)350552069;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator2.UpdateProgress(0.75);
							num = (short)402849801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							string[] array = new string[6];
							int num3 = 0;
							string format = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꗽ篿㈁礃嬅匇焉㴋猍䴏䤑漓␕攗䜙䜛攝ጟ弡礣紥稧伩䴫䨭琯圱䈳張嬷弹愻", a_);
							object[] array2 = new object[4];
							int num4 = 0;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = this.ExtendedDeviceInfo;
							global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType;
							if (extendedDeviceInfo == null)
							{
								connectionType = null;
							}
							else
							{
								global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = extendedDeviceInfo.ConnectionInfo;
								connectionType = ((connectionInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo.ConnectionType) : null);
							}
							array2[num4] = connectionType;
							int num5 = 1;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo2 = this.ExtendedDeviceInfo;
							array2[num5] = ((extendedDeviceInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo2.Family) : null);
							int num6 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo3 = this.ExtendedDeviceInfo;
							array2[num6] = ((extendedDeviceInfo3 != null) ? extendedDeviceInfo3.SerialNumber : null);
							int num7 = 3;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo4 = this.ExtendedDeviceInfo;
							array2[num7] = ((extendedDeviceInfo4 != null) ? extendedDeviceInfo4.ModelNumber : null);
							array[num3] = string.Format(format, array2);
							array[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꗽ", a_);
							int num8 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo5 = this.ExtendedDeviceInfo;
							array[num8] = ((extendedDeviceInfo5 != null) ? extendedDeviceInfo5.SoftwareVersion : null);
							array[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꏽ寿", a_);
							int num9 = 4;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo6 = this.ExtendedDeviceInfo;
							array[num9] = ((extendedDeviceInfo6 != null) ? extendedDeviceInfo6.CodeplugVersion : null);
							array[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꏽ⃿瀁愃朅氇⨉樋簍甏愑簓㘕笗甙砛笝借両儣䄥ࠧ䌩弫อ嘯嬱娳張䬷刹夻娽渿", a_);
							global::System.Diagnostics.Trace.TraceInformation(string.Concat(array));
							global::Motorola.Common.Communication.Pba.PbaObject pbaObject;
							result = pbaObject;
							goto IL_3DA;
						}
						case 4:
							goto IL_3F2;
						case 5:
							goto IL_20A;
						case 6:
							goto IL_187;
						case 7:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator3 = this.ProgressIndicator;
							if (progressIndicator3 == null)
							{
								num = (short)910622731;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator3.UpdateProgress(0.1);
							num = (short)1643970568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_CD;
						case 9:
							goto IL_20A;
						case 10:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator4 = this.ProgressIndicator;
							if (progressIndicator4 == null)
							{
								num = (short)1865089025;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator4.UpdateProgress(0.25);
							num = (short)1021313030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_CD;
						}
						goto IL_67;
						IL_CD:
						num = (short)536322644;
						short num10 = num;
						num = (short)1835180628;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.DeviceFileInfo> a_3;
						switch ((num10 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_3DA:
							num = (short)855572484;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)770572288;
							if (num != 0)
							{
							}
							a_3 = this.a(a_4);
							num = (short)1086259210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_187:
						a_2 = this.a(global::Motorola.Common.Communication.AmpApSequenceManager.a(a_3, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鷽濿氁戃漅漇娉洋洍笏猑猓猕㘗怙甛渝", a_)));
						num = (short)85983234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_20A:
						num = (short)529137664;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3F2:
					break;
					IL_67:
					a_4 = global::Motorola.Common.Communication.Utils.JobDescriptorFactory.BuildJobDescriptorForRead();
					num = (short)1703018503;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				string[] array3 = new string[7];
				int num11 = 0;
				string format2 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꗽ篿㈁礃嬅匇焉㴋猍䴏䤑漓␕攗䜙䜛攝ጟ弡礣紥稧伩䴫䨭琯圱䈳張嬷弹愻", a_);
				object[] array4 = new object[4];
				int num12 = 0;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo7 = this.ExtendedDeviceInfo;
				global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType2;
				if (extendedDeviceInfo7 == null)
				{
					connectionType2 = null;
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo2 = extendedDeviceInfo7.ConnectionInfo;
					connectionType2 = ((connectionInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo2.ConnectionType) : null);
				}
				array4[num12] = connectionType2;
				int num13 = 1;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo8 = this.ExtendedDeviceInfo;
				array4[num13] = ((extendedDeviceInfo8 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo8.Family) : null);
				int num14 = 2;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo9 = this.ExtendedDeviceInfo;
				array4[num14] = ((extendedDeviceInfo9 != null) ? extendedDeviceInfo9.SerialNumber : null);
				int num15 = 3;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo10 = this.ExtendedDeviceInfo;
				array4[num15] = ((extendedDeviceInfo10 != null) ? extendedDeviceInfo10.ModelNumber : null);
				array3[num11] = string.Format(format2, array4);
				array3[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꗽ", a_);
				int num16 = 2;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo11 = this.ExtendedDeviceInfo;
				array3[num16] = ((extendedDeviceInfo11 != null) ? extendedDeviceInfo11.SoftwareVersion : null);
				array3[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꏽ寿", a_);
				int num17 = 4;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo12 = this.ExtendedDeviceInfo;
				array3[num17] = ((extendedDeviceInfo12 != null) ? extendedDeviceInfo12.CodeplugVersion : null);
				array3[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꏽ⃿䜁簃攅洇稉砋服缏簑㐓笕紗椙漛缝䜟䜡ḣإ", a_);
				array3[6] = ex.Message;
				global::System.Diagnostics.Trace.TraceError(string.Concat(array3), new object[]
				{
					ex.StackTrace,
					ex.StackTrace
				});
				throw ex;
			}
			num = (short)1305280513;
			if (num != 0)
			{
			}
			num = (short)1158086656;
			short num18 = num;
			return result;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000034A8 File Offset: 0x000016A8
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionId, string pcrNewPassword, bool hostedDepotOperation, int? userDefersAllowed = null)
		{
			int a_ = 8;
			short num;
			global::Motorola.Common.Communication.Pba.PbaObject result;
			try
			{
				num = (short)1679360000;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_88;
					}
					global::Motorola.Common.Communication.IProgressIndicator progressIndicator4;
					for (;;)
					{
						IL_31:
						global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor a_3;
						string a_4;
						switch (num2)
						{
						case 0:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator = this.ProgressIndicator;
							if (progressIndicator == null)
							{
								num = (short)1761411082;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
							num = (short)2025783298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator2 = this.ProgressIndicator;
							if (progressIndicator2 == null)
							{
								num = (short)208338961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator2.UpdateProgress(0.1);
							num = (short)351862795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_55C;
						case 3:
						{
							pbaObject.CodeplugData.DataPartitions.RemoveAll(new global::System.Predicate<global::Motorola.Common.Communication.Pba.DataPartition>(global::Motorola.Common.Communication.AmpApSequenceManager.<>c.<>9.a));
							global::Motorola.Common.Communication.CodeplugParseHelper.UpdateOutOfBoxExperienceFlagToFalse(pbaObject);
							global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo ampDeviceInfo;
							global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.UpdatePinPasswordBeforeWrite(pbaObject, ampDeviceInfo.ElectronicSerialNumber);
							global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.UpdateWiFiPasswordBeforeWrite(pbaObject, ampDeviceInfo.ElectronicSerialNumber);
							global::Motorola.Common.Communication.AmpPasswords.AmpPasswordsHelper.UpdateExternalDataModemPasswordBeforeWrite(pbaObject, ampDeviceInfo.ElectronicSerialNumber);
							num = (short)1716584452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator3 = this.ProgressIndicator;
							if (progressIndicator3 == null)
							{
								num = (short)589430785;
								if (num != 0)
								{
								}
								num = (short)1863319557;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator3.UpdateProgress(0.0);
							num = (short)1852506120;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_34E;
						case 6:
							progressIndicator4 = this.ProgressIndicator;
							if (progressIndicator4 == null)
							{
								num = (short)1359872013;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_44D;
						case 7:
						{
							string[] array = new string[6];
							int num3 = 0;
							string format = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꏷ臹쳻菽巿夁缃㜅甇圉國甍∏漑䤓䴕挗⤙愛䌝笟甡嘣伥尧伩栫䬭䘯嬱圳匵攷", a_);
							object[] array2 = new object[4];
							int num4 = 0;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = this.ExtendedDeviceInfo;
							global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType;
							if (extendedDeviceInfo == null)
							{
								connectionType = null;
							}
							else
							{
								global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = extendedDeviceInfo.ConnectionInfo;
								connectionType = ((connectionInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo.ConnectionType) : null);
							}
							array2[num4] = connectionType;
							int num5 = 1;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo2 = this.ExtendedDeviceInfo;
							array2[num5] = ((extendedDeviceInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo2.Family) : null);
							int num6 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo3 = this.ExtendedDeviceInfo;
							array2[num6] = ((extendedDeviceInfo3 != null) ? extendedDeviceInfo3.SerialNumber : null);
							int num7 = 3;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo4 = this.ExtendedDeviceInfo;
							array2[num7] = ((extendedDeviceInfo4 != null) ? extendedDeviceInfo4.ModelNumber : null);
							array[num3] = string.Format(format, array2);
							array[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꏷ", a_);
							int num8 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo5 = this.ExtendedDeviceInfo;
							array[num8] = ((extendedDeviceInfo5 != null) ? extendedDeviceInfo5.SoftwareVersion : null);
							array[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꗷꇹ", a_);
							int num9 = 4;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo6 = this.ExtendedDeviceInfo;
							array[num9] = ((extendedDeviceInfo6 != null) ? extendedDeviceInfo6.CodeplugVersion : null);
							array[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꗷ\udaf9读賽槿瘁愃★欇攉栋欍怏縑愓焕㠗猙漛㸝匟嘡䔣吥尧伩䠫-", a_);
							global::System.Diagnostics.Trace.TraceInformation(string.Concat(array));
							this.ValidateCodeplugVersion(pbaObject);
							global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo ampDeviceInfo = (global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo)this.ExtendedDeviceInfo;
							num = (short)649199619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_34E;
						case 9:
							goto IL_6C4;
						case 10:
							goto IL_55C;
						case 11:
							goto IL_3BE;
						case 12:
							goto IL_475;
						case 13:
							goto IL_475;
						case 14:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator5 = this.ProgressIndicator;
							if (progressIndicator5 == null)
							{
								num = (short)1565786130;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator5.UpdateProgress(0.75);
							num = (short)1762197519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							goto IL_4EB;
						case 16:
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.DeviceFileInfo> a_2 = this.a(a_3);
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator6 = this.ProgressIndicator;
							if (progressIndicator6 != null)
							{
								progressIndicator6.UpdateProgress(0.25);
							}
							a_4 = global::Motorola.Common.Communication.AmpApSequenceManager.a(a_2, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鯷闹鋻飽槿攁吃朅欇愉洋植甏㰑渓缕栗", a_));
							num = (short)105381894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							goto IL_3BE;
						case 18:
							goto IL_4EB;
						case 19:
						{
							string[] array3 = new string[6];
							int num10 = 0;
							string format2 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꏷ臹쳻菽巿夁缃㜅甇圉國甍∏漑䤓䴕挗⤙愛䌝笟甡嘣伥尧伩栫䬭䘯嬱圳匵攷", a_);
							object[] array4 = new object[4];
							int num11 = 0;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo7 = this.ExtendedDeviceInfo;
							global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType2;
							if (extendedDeviceInfo7 == null)
							{
								connectionType2 = null;
							}
							else
							{
								global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo2 = extendedDeviceInfo7.ConnectionInfo;
								connectionType2 = ((connectionInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo2.ConnectionType) : null);
							}
							array4[num11] = connectionType2;
							int num12 = 1;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo8 = this.ExtendedDeviceInfo;
							array4[num12] = ((extendedDeviceInfo8 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo8.Family) : null);
							int num13 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo9 = this.ExtendedDeviceInfo;
							array4[num13] = ((extendedDeviceInfo9 != null) ? extendedDeviceInfo9.SerialNumber : null);
							int num14 = 3;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo10 = this.ExtendedDeviceInfo;
							array4[num14] = ((extendedDeviceInfo10 != null) ? extendedDeviceInfo10.ModelNumber : null);
							array3[num10] = string.Format(format2, array4);
							array3[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꏷ", a_);
							int num15 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo11 = this.ExtendedDeviceInfo;
							array3[num15] = ((extendedDeviceInfo11 != null) ? extendedDeviceInfo11.SoftwareVersion : null);
							array3[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꗷꇹ", a_);
							int num16 = 4;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo12 = this.ExtendedDeviceInfo;
							array3[num16] = ((extendedDeviceInfo12 != null) ? extendedDeviceInfo12.CodeplugVersion : null);
							array3[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꗷ\udaf9读賽槿瘁愃★欇攉栋欍怏縑愓焕㠗猙漛㸝䘟䬡䨣伥嬧䈩䤫䨭ḯ", a_);
							global::System.Diagnostics.Trace.TraceInformation(string.Concat(array3));
							global::Motorola.Common.Communication.Pba.PbaObject pbaObject2;
							result = pbaObject2;
							num = (short)1152253961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_88;
						IL_34E:
						a_3 = global::Motorola.Common.Communication.Utils.JobDescriptorFactory.BuildJobDescriptorForWriteCodeplug(userDefersAllowed);
						num = (short)737148929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3BE:
						num = (short)1814233104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_475:
						byte[] a_5 = new global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator().GeneratePackage(pbaObject);
						num = (short)1844772878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_4EB:
						this.b(a_4, a_5);
						num = (short)711655424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_55C:
						num = (short)1110573075;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_44D:
					progressIndicator4.UpdateProgress(0.5);
					goto IL_45B;
					IL_6C4:
					break;
					IL_88:
					num = (short)1581196206;
					short num17 = num;
					num = (short)1382491054;
					switch ((num17 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_45B:
						num = (short)1662386188;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_31;
					default:
					{
						num = (short)548077568;
						if (num != 0)
						{
						}
						global::Motorola.Common.Communication.Pba.PbaObject pbaObject2 = global::Motorola.Common.Communication.Pba.PbaObject.DeserializeFromBytes(pbaObject.SerializeToBytes(), false);
						pbaObject2.CodeplugData.ArchiveSessionID = sessionId;
						num = (short)1823539207;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_31;
					}
					}
					break;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				string[] array5 = new string[7];
				int num18 = 0;
				string format3 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꏷ臹쳻菽巿夁缃㜅甇圉國甍∏漑䤓䴕挗⤙愛䌝笟甡嘣伥尧伩栫䬭䘯嬱圳匵攷", a_);
				object[] array6 = new object[4];
				int num19 = 0;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo13 = this.ExtendedDeviceInfo;
				global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType3;
				if (extendedDeviceInfo13 == null)
				{
					connectionType3 = null;
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo3 = extendedDeviceInfo13.ConnectionInfo;
					connectionType3 = ((connectionInfo3 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo3.ConnectionType) : null);
				}
				array6[num19] = connectionType3;
				int num20 = 1;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo14 = this.ExtendedDeviceInfo;
				array6[num20] = ((extendedDeviceInfo14 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo14.Family) : null);
				int num21 = 2;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo15 = this.ExtendedDeviceInfo;
				array6[num21] = ((extendedDeviceInfo15 != null) ? extendedDeviceInfo15.SerialNumber : null);
				int num22 = 3;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo16 = this.ExtendedDeviceInfo;
				array6[num22] = ((extendedDeviceInfo16 != null) ? extendedDeviceInfo16.ModelNumber : null);
				array5[num18] = string.Format(format3, array6);
				array5[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꏷ", a_);
				int num23 = 2;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo17 = this.ExtendedDeviceInfo;
				array5[num23] = ((extendedDeviceInfo17 != null) ? extendedDeviceInfo17.SoftwareVersion : null);
				array5[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꗷꇹ", a_);
				int num24 = 4;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo18 = this.ExtendedDeviceInfo;
				array5[num24] = ((extendedDeviceInfo18 != null) ? extendedDeviceInfo18.CodeplugVersion : null);
				array5[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꗷ\udaf9맻蛽揿朁球爅愇攉戋⸍紏眑朓攕礗紙礛␝\u001f", a_);
				array5[6] = ex.Message;
				global::System.Diagnostics.Trace.TraceError(string.Concat(array5), new object[]
				{
					ex.StackTrace,
					ex.StackTrace
				});
				throw ex;
			}
			num = (short)1579679744;
			short num25 = num;
			return result;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00003D24 File Offset: 0x00001F24
		public void UpdateDevice(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, ushort sessionId, bool hostedDepotOperation, int? userDefersAllowed = null)
		{
			int a_ = 9;
			short num;
			try
			{
				num = (short)931332096;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					for (;;)
					{
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						for (;;)
						{
							IL_31:
							string packageFilePath;
							switch (num2)
							{
							case 0:
							{
								global::Motorola.Common.Communication.IProgressIndicator progressIndicator = this.ProgressIndicator;
								if (progressIndicator == null)
								{
									num = (short)2097217537;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								progressIndicator.UpdateProgress(0.0);
								num = (short)1412104194;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_117;
							case 2:
								goto IL_117;
							case 3:
								goto IL_438;
							case 4:
								num = (short)1204224005;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								string[] array = new string[6];
								int num3 = 0;
								string format = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꋸ胺췼苾尀堂縄㘆琈嘊嘌琎⌐渒䠔䰖战⠚怜䈞稠瘢唤䌦䠨弪䠬欮吰䔲尴吶尸昺", a_);
								object[] array2 = new object[4];
								int num4 = 0;
								global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = this.ExtendedDeviceInfo;
								global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType;
								if (extendedDeviceInfo == null)
								{
									connectionType = null;
								}
								else
								{
									global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = extendedDeviceInfo.ConnectionInfo;
									connectionType = ((connectionInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo.ConnectionType) : null);
								}
								array2[num4] = connectionType;
								int num5 = 1;
								global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo2 = this.ExtendedDeviceInfo;
								array2[num5] = ((extendedDeviceInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo2.Family) : null);
								int num6 = 2;
								global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo3 = this.ExtendedDeviceInfo;
								array2[num6] = ((extendedDeviceInfo3 != null) ? extendedDeviceInfo3.SerialNumber : null);
								int num7 = 3;
								global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo4 = this.ExtendedDeviceInfo;
								array2[num7] = ((extendedDeviceInfo4 != null) ? extendedDeviceInfo4.ModelNumber : null);
								array[num3] = string.Format(format, array2);
								array[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꋸ", a_);
								int num8 = 2;
								global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo5 = this.ExtendedDeviceInfo;
								array[num8] = ((extendedDeviceInfo5 != null) ? extendedDeviceInfo5.SoftwareVersion : null);
								array[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꓸꃺ", a_);
								int num9 = 4;
								global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo6 = this.ExtendedDeviceInfo;
								array[num9] = ((extendedDeviceInfo6 != null) ? extendedDeviceInfo6.CodeplugVersion : null);
								array[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꓸ\udbfa민ꣾ℀瘂甄挆栈缊栌⼎砐怒㔔搖洘稚漜欞䐠䜢ତ", a_);
								global::System.Diagnostics.Trace.TraceInformation(string.Concat(array));
								this.PerformFullUpdate(pbaObject, packageFilePath, userDefersAllowed);
								num = (short)1361313800;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								string[] array3 = new string[6];
								int num10 = 0;
								string format2 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꋸ胺췼苾尀堂縄㘆琈嘊嘌琎⌐渒䠔䰖战⠚怜䈞稠瘢唤䌦䠨弪䠬欮吰䔲尴吶尸昺", a_);
								object[] array4 = new object[4];
								int num11 = 0;
								global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo7 = this.ExtendedDeviceInfo;
								global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType2;
								if (extendedDeviceInfo7 == null)
								{
									connectionType2 = null;
								}
								else
								{
									global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo2 = extendedDeviceInfo7.ConnectionInfo;
									connectionType2 = ((connectionInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo2.ConnectionType) : null);
								}
								array4[num11] = connectionType2;
								int num12 = 1;
								global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo8 = this.ExtendedDeviceInfo;
								array4[num12] = ((extendedDeviceInfo8 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo8.Family) : null);
								int num13 = 2;
								global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo9 = this.ExtendedDeviceInfo;
								array4[num13] = ((extendedDeviceInfo9 != null) ? extendedDeviceInfo9.SerialNumber : null);
								int num14 = 3;
								global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo10 = this.ExtendedDeviceInfo;
								array4[num14] = ((extendedDeviceInfo10 != null) ? extendedDeviceInfo10.ModelNumber : null);
								array3[num10] = string.Format(format2, array4);
								array3[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꋸ", a_);
								int num15 = 2;
								global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo11 = this.ExtendedDeviceInfo;
								array3[num15] = ((extendedDeviceInfo11 != null) ? extendedDeviceInfo11.SoftwareVersion : null);
								array3[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꓸꃺ", a_);
								int num16 = 4;
								global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo12 = this.ExtendedDeviceInfo;
								array3[num16] = ((extendedDeviceInfo12 != null) ? extendedDeviceInfo12.CodeplugVersion : null);
								array3[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꓸ\udbfa민ꣾ℀瘂甄挆栈缊栌㔎ㄐ簒笔笖怘㬚帜瀞䔠䘢唤䬦尨䰪ബ娮䄰圲吴䌶尸ᬺ吼䰾慀あㅄ♆㭈㽊⡌⭎罐", a_);
								global::System.Diagnostics.Trace.TraceInformation(string.Concat(array3));
								this.PerformOnlyCodeplugUpdate(pbaObject, userDefersAllowed);
								num = (short)316866563;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								if (packageFilePath != null)
								{
									num = (short)272760836;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)840564742;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_438;
							case 9:
								goto IL_450;
							}
							break;
							IL_117:
							packageFilePath = this.d.GetPackageFilePath(pbaObject);
							num = (short)438501383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_438:
							num = (short)1994129417;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_60:
						this.ValidateCodeplugVersion(pbaObject);
						num = (short)1307926544;
						short num17 = num;
						num = (short)917004304;
						switch ((num17 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1512898560;
							if (num != 0)
							{
							}
							num = (short)1469054976;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_31;
						}
					}
					IL_450:
					break;
				}
			}
			catch (global::System.Exception ex)
			{
				string[] array5 = new string[7];
				int num18 = 0;
				string format3 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꋸ胺췼苾尀堂縄㘆琈嘊嘌琎⌐渒䠔䰖战⠚怜䈞稠瘢唤䌦䠨弪䠬欮吰䔲尴吶尸昺", a_);
				object[] array6 = new object[4];
				int num19 = 0;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo13 = this.ExtendedDeviceInfo;
				global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType3;
				if (extendedDeviceInfo13 == null)
				{
					connectionType3 = null;
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo3 = extendedDeviceInfo13.ConnectionInfo;
					connectionType3 = ((connectionInfo3 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo3.ConnectionType) : null);
				}
				array6[num19] = connectionType3;
				int num20 = 1;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo14 = this.ExtendedDeviceInfo;
				array6[num20] = ((extendedDeviceInfo14 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo14.Family) : null);
				int num21 = 2;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo15 = this.ExtendedDeviceInfo;
				array6[num21] = ((extendedDeviceInfo15 != null) ? extendedDeviceInfo15.SerialNumber : null);
				int num22 = 3;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo16 = this.ExtendedDeviceInfo;
				array6[num22] = ((extendedDeviceInfo16 != null) ? extendedDeviceInfo16.ModelNumber : null);
				array5[num18] = string.Format(format3, array6);
				array5[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꋸ", a_);
				int num23 = 2;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo17 = this.ExtendedDeviceInfo;
				array5[num23] = ((extendedDeviceInfo17 != null) ? extendedDeviceInfo17.SoftwareVersion : null);
				array5[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꓸꃺ", a_);
				int num24 = 4;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo18 = this.ExtendedDeviceInfo;
				array5[num24] = ((extendedDeviceInfo18 != null) ? extendedDeviceInfo18.CodeplugVersion : null);
				array5[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꓸ\udbfa룼蟾戀昂甄猆怈搊挌⼎簐瘒昔搖砘簚砜┞Ġ", a_);
				array5[6] = ex.Message;
				global::System.Diagnostics.Trace.TraceError(string.Concat(array5), new object[]
				{
					ex.StackTrace,
					ex.StackTrace
				});
				throw ex;
			}
			num = (short)1210777600;
			short num25 = num;
			num = (short)2042494977;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00004348 File Offset: 0x00002548
		public void PerformFullUpdate(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string firmwarePackageFilePath, int? userDefersAllowed)
		{
			int a_ = 12;
			short num;
			try
			{
				num = (short)1406533632;
				switch (num)
				{
				default:
				{
					num = (short)1265434626;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor a_3;
						string a_6;
						switch (num2)
						{
						case 0:
							goto IL_34A;
						case 1:
							goto IL_120;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_88;
							}
							continue;
						case 3:
						{
							string[] array = new string[6];
							int num3 = 0;
							string format = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꟻ藽ヿ缁夃崅猇㬉焋匍䬏椑☓欕䔗䄙望ⴝ崟缡缣猥堧丩䴫娭唯瘱儳䀵儷夹夻挽", a_);
							object[] array2 = new object[4];
							int num4 = 0;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = this.ExtendedDeviceInfo;
							global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType;
							if (extendedDeviceInfo == null)
							{
								connectionType = null;
							}
							else
							{
								global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = extendedDeviceInfo.ConnectionInfo;
								connectionType = ((connectionInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo.ConnectionType) : null);
							}
							array2[num4] = connectionType;
							int num5 = 1;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo2 = this.ExtendedDeviceInfo;
							array2[num5] = ((extendedDeviceInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo2.Family) : null);
							int num6 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo3 = this.ExtendedDeviceInfo;
							array2[num6] = ((extendedDeviceInfo3 != null) ? extendedDeviceInfo3.SerialNumber : null);
							int num7 = 3;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo4 = this.ExtendedDeviceInfo;
							array2[num7] = ((extendedDeviceInfo4 != null) ? extendedDeviceInfo4.ModelNumber : null);
							array[num3] = string.Format(format, array2);
							array[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꟻ", a_);
							int num8 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo5 = this.ExtendedDeviceInfo;
							array[num8] = ((extendedDeviceInfo5 != null) ? extendedDeviceInfo5.SoftwareVersion : null);
							array[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꇻꗽ", a_);
							int num9 = 4;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo6 = this.ExtendedDeviceInfo;
							array[num9] = ((extendedDeviceInfo6 != null) ? extendedDeviceInfo6.CodeplugVersion : null);
							array[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꇻ\udefd䛿唁␃猅砇渉洋稍甏㈑紓攕㠗簙甛瀝䤟儡䰣䌥䰧Щ", a_);
							global::System.Diagnostics.Trace.TraceInformation(string.Concat(array));
							num = (short)2028732417;
							if (num != 0)
							{
							}
							num = (short)670760966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator = this.ProgressIndicator;
							if (progressIndicator == null)
							{
								num = (short)574226446;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator.UpdateProgress(0.05);
							num = (short)154927117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.DeviceFileInfo> a_2 = this.a(a_3);
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator2 = this.ProgressIndicator;
							if (progressIndicator2 != null)
							{
								progressIndicator2.UpdateProgress(0.1);
							}
							string a_4 = global::Motorola.Common.Communication.AmpApSequenceManager.a(a_2, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鿻釽滿搁洃愅堇欉漋攍焏甑焓㠕戗猙氛", a_));
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator3 = this.ProgressIndicator;
							if (progressIndicator3 != null)
							{
								progressIndicator3.UpdateProgress(0.15);
							}
							byte[] a_5 = new global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator().GeneratePackage(pbaObject);
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator4 = this.ProgressIndicator;
							if (progressIndicator4 != null)
							{
								progressIndicator4.UpdateProgress(0.2);
							}
							this.b(a_4, a_5);
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator5 = this.ProgressIndicator;
							if (progressIndicator5 != null)
							{
								progressIndicator5.UpdateProgress(0.3);
							}
							a_6 = global::Motorola.Common.Communication.AmpApSequenceManager.a(a_2, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("髻韽狿漁猃朅稇漉尋漍猏礑甓焕紗㐙昛眝借", a_));
							num = (short)1850212364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_4D4;
						case 7:
							goto IL_34A;
						case 8:
							goto IL_2CE;
						case 9:
							goto IL_2A2;
						case 10:
							goto IL_120;
						case 11:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator6 = this.ProgressIndicator;
							if (progressIndicator6 == null)
							{
								num = (short)691863552;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator6.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteSoftwareDone);
							num = (short)1197998087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator7 = this.ProgressIndicator;
							if (progressIndicator7 == null)
							{
								num = (short)845611017;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator7.UpdateProgress(0.35);
							num = (short)1498546184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							goto IL_190;
						case 14:
							goto IL_190;
						}
						IL_88:
						num = (short)390255418;
						short num10 = num;
						num = (short)1262408506;
						switch ((num10 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_2A2:
							goto IL_2CE;
						default:
						{
							num = (short)366542848;
							if (num != 0)
							{
							}
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator8 = this.ProgressIndicator;
							if (progressIndicator8 == null)
							{
								num = (short)1695088650;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator8.UpdateProgress(0.0);
							num = (short)1103888385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_120:
						a_3 = global::Motorola.Common.Communication.Utils.JobDescriptorFactory.BuildJobDescriptorForWriteFirmware(userDefersAllowed);
						num = (short)427819012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_190:
						num = (short)24117253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2CE:
						this.a(a_6, firmwarePackageFilePath, new int?(15000));
						num = (short)1281622027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_34A:
						num = (short)1621229571;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4D4:
					break;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				string[] array3 = new string[7];
				int num11 = 0;
				string format2 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꟻ藽ヿ缁夃崅猇㬉焋匍䬏椑☓欕䔗䄙望ⴝ崟缡缣猥堧丩䴫娭唯瘱儳䀵儷夹夻挽", a_);
				object[] array4 = new object[4];
				int num12 = 0;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo7 = this.ExtendedDeviceInfo;
				global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType2;
				if (extendedDeviceInfo7 == null)
				{
					connectionType2 = null;
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo2 = extendedDeviceInfo7.ConnectionInfo;
					connectionType2 = ((connectionInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo2.ConnectionType) : null);
				}
				array4[num12] = connectionType2;
				int num13 = 1;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo8 = this.ExtendedDeviceInfo;
				array4[num13] = ((extendedDeviceInfo8 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo8.Family) : null);
				int num14 = 2;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo9 = this.ExtendedDeviceInfo;
				array4[num14] = ((extendedDeviceInfo9 != null) ? extendedDeviceInfo9.SerialNumber : null);
				int num15 = 3;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo10 = this.ExtendedDeviceInfo;
				array4[num15] = ((extendedDeviceInfo10 != null) ? extendedDeviceInfo10.ModelNumber : null);
				array3[num11] = string.Format(format2, array4);
				array3[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꟻ", a_);
				int num16 = 2;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo11 = this.ExtendedDeviceInfo;
				array3[num16] = ((extendedDeviceInfo11 != null) ? extendedDeviceInfo11.SoftwareVersion : null);
				array3[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꇻꗽ", a_);
				int num17 = 4;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo12 = this.ExtendedDeviceInfo;
				array3[num17] = ((extendedDeviceInfo12 != null) ? extendedDeviceInfo12.CodeplugVersion : null);
				array3[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꇻ\udefd䗿稁會挅砇縉攋愍縏㈑礓猕欗椙紛礝䔟ᠡУ", a_);
				array3[6] = ex.Message;
				global::System.Diagnostics.Trace.TraceError(string.Concat(array3), new object[]
				{
					ex.StackTrace,
					ex.StackTrace
				});
				throw ex;
			}
			num = (short)1623654400;
			short num18 = num;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000049D0 File Offset: 0x00002BD0
		public void PerformOnlyCodeplugUpdate(global::Motorola.Common.Communication.Pba.PbaObject pbaObject, int? userDefersAllowed)
		{
			int a_ = 19;
			short num;
			try
			{
				num = (short)2141913088;
				switch (num)
				{
				default:
				{
					num = (short)1178730501;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor a_3;
						string a_4;
						switch (num2)
						{
						case 0:
						{
							string[] array = new string[6];
							int num3 = 0;
							string format = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("堂縄㜆琈嘊嘌琎‐渒䠔䰖战⤚怜䈞稠堢ᘤ娦琨瀪砬弮唰刲䄴制紸帺䬼嘾≀♂ᡄ", a_);
							object[] array2 = new object[4];
							int num4 = 0;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = this.ExtendedDeviceInfo;
							global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType;
							if (extendedDeviceInfo == null)
							{
								connectionType = null;
							}
							else
							{
								global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = extendedDeviceInfo.ConnectionInfo;
								connectionType = ((connectionInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo.ConnectionType) : null);
							}
							array2[num4] = connectionType;
							int num5 = 1;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo2 = this.ExtendedDeviceInfo;
							array2[num5] = ((extendedDeviceInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo2.Family) : null);
							int num6 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo3 = this.ExtendedDeviceInfo;
							array2[num6] = ((extendedDeviceInfo3 != null) ? extendedDeviceInfo3.SerialNumber : null);
							int num7 = 3;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo4 = this.ExtendedDeviceInfo;
							array2[num7] = ((extendedDeviceInfo4 != null) ? extendedDeviceInfo4.ModelNumber : null);
							array[num3] = string.Format(format, array2);
							array[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("堂", a_);
							int num8 = 2;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo5 = this.ExtendedDeviceInfo;
							array[num8] = ((extendedDeviceInfo5 != null) ? extendedDeviceInfo5.SoftwareVersion : null);
							array[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("市帄", a_);
							int num9 = 4;
							global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo6 = this.ExtendedDeviceInfo;
							array[num9] = ((extendedDeviceInfo6 != null) ? extendedDeviceInfo6.CodeplugVersion : null);
							array[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("市⬄✆伈尊ⴌ税愐眒琔挖簘ℚ㴜瀞传伢尤ܦ樨䐪䤬䨮䄰弲䀴倶ᤸ为䴼嬾⁀㝂⁄杆⁈㡊浌⥎㡐㵒㱔⑖ㅘ㹚㥜煞", a_);
							global::System.Diagnostics.Trace.TraceInformation(string.Concat(array));
							num = (short)2113601540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_DF;
						case 2:
							goto IL_331;
						case 3:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator = this.ProgressIndicator;
							if (progressIndicator == null)
							{
								num = (short)475463687;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator.UpdateProgress(0.05);
							num = (short)238682129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_493;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_94;
							}
							continue;
						case 6:
							goto IL_24F;
						case 7:
							goto IL_14C;
						case 8:
							goto IL_331;
						case 9:
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.DeviceFileInfo> a_2 = this.a(a_3);
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator2 = this.ProgressIndicator;
							if (progressIndicator2 != null)
							{
								progressIndicator2.UpdateProgress(0.1);
							}
							a_4 = global::Motorola.Common.Communication.AmpApSequenceManager.a(a_2, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("怂樄椆漈戊樌弎瀐瀒縔瘖縘縚㌜攞䠠匢", a_));
							num = (short)297730064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_2C1;
						case 11:
							goto IL_2C1;
						case 12:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator3 = this.ProgressIndicator;
							if (progressIndicator3 == null)
							{
								num = (short)1955201035;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator3.UpdateProgress(0.2);
							num = (short)1123418122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							goto IL_DF;
						case 14:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator4 = this.ProgressIndicator;
							if (progressIndicator4 == null)
							{
								num = (short)1063059458;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator4.UpdateProgress(1.0, global::Motorola.Common.Communication.CommonUtil.ProgressStatus.WriteCPDone);
							num = (short)2088960008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
						{
							num = (short)1296010484;
							short num10 = num;
							num = (short)1280281844;
							switch ((num10 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_14C;
							default:
								num = (short)1271267328;
								if (num != 0)
								{
								}
								goto IL_24F;
							}
							break;
						}
						case 16:
						{
							global::Motorola.Common.Communication.IProgressIndicator progressIndicator5 = this.ProgressIndicator;
							if (progressIndicator5 == null)
							{
								num = (short)782761990;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							progressIndicator5.UpdateProgress(0.15);
							num = (short)994967567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 17:
							goto IL_14C;
						}
						IL_94:
						global::Motorola.Common.Communication.IProgressIndicator progressIndicator6 = this.ProgressIndicator;
						if (progressIndicator6 == null)
						{
							num = (short)1604255757;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						progressIndicator6.UpdateProgress(0.0);
						num = (short)1581842433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_DF:
						a_3 = global::Motorola.Common.Communication.Utils.JobDescriptorFactory.BuildJobDescriptorForWriteCodeplug(userDefersAllowed);
						num = (short)1965031427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_14C:
						num = (short)800391177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_24F:
						byte[] a_5 = new global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator().GeneratePackage(pbaObject);
						num = (short)1824522252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C1:
						this.b(a_4, a_5);
						num = (short)1515061262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_331:
						num = (short)78315520;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_493:
					break;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				string[] array3 = new string[7];
				int num11 = 0;
				string format2 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("堂縄㜆琈嘊嘌琎‐渒䠔䰖战⤚怜䈞稠堢ᘤ娦琨瀪砬弮唰刲䄴制紸帺䬼嘾≀♂ᡄ", a_);
				object[] array4 = new object[4];
				int num12 = 0;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo7 = this.ExtendedDeviceInfo;
				global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType2;
				if (extendedDeviceInfo7 == null)
				{
					connectionType2 = null;
				}
				else
				{
					global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo2 = extendedDeviceInfo7.ConnectionInfo;
					connectionType2 = ((connectionInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo2.ConnectionType) : null);
				}
				array4[num12] = connectionType2;
				int num13 = 1;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo8 = this.ExtendedDeviceInfo;
				array4[num13] = ((extendedDeviceInfo8 != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(extendedDeviceInfo8.Family) : null);
				int num14 = 2;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo9 = this.ExtendedDeviceInfo;
				array4[num14] = ((extendedDeviceInfo9 != null) ? extendedDeviceInfo9.SerialNumber : null);
				int num15 = 3;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo10 = this.ExtendedDeviceInfo;
				array4[num15] = ((extendedDeviceInfo10 != null) ? extendedDeviceInfo10.ModelNumber : null);
				array3[num11] = string.Format(format2, array4);
				array3[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("堂", a_);
				int num16 = 2;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo11 = this.ExtendedDeviceInfo;
				array3[num16] = ((extendedDeviceInfo11 != null) ? extendedDeviceInfo11.SoftwareVersion : null);
				array3[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("市帄", a_);
				int num17 = 4;
				global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo12 = this.ExtendedDeviceInfo;
				array3[num17] = ((extendedDeviceInfo12 != null) ? extendedDeviceInfo12.CodeplugVersion : null);
				array3[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("市┄䈆焈栊栌缎攐稒稔礖㤘瘚砜氞删䈢䈤䈦ጨପ", a_);
				array3[6] = ex.Message;
				global::System.Diagnostics.Trace.TraceError(string.Concat(array3), new object[]
				{
					ex.StackTrace,
					ex.StackTrace
				});
				throw ex;
			}
			num = (short)1202061313;
			if (num != 0)
			{
			}
			num = (short)1805385728;
			short num18 = num;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000503C File Offset: 0x0000323C
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo()
		{
			int a_ = 6;
			short num = (short)807010304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1142095872;
				short num3 = num;
				num = (short)2123300865;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo ampDeviceInfo = new global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo();
				try
				{
					switch (0)
					{
					case 0:
						goto IL_A7;
					}
					global::Motorola.Common.Communication.HttpGetAmpDeviceInventory httpGetAmpDeviceInventory;
					for (;;)
					{
						IL_8C:
						switch (num2)
						{
						case 0:
						{
							num = (short)962811151;
							short num4 = num;
							num = (short)794252559;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3CA;
							default:
								num = (short)1479278592;
								if (num != 0)
								{
								}
								if (httpGetAmpDeviceInventory.ResponseData != null)
								{
									num = (short)1257832452;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3CC;
							}
							break;
						}
						case 1:
						{
							string format = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("귵菷쫹臻ꏽ寿礁㔃笅唇儉看㰍洏休伓洕⬗朙䄛䔝嬟ᘡ夣笥猧儩ᤫ匭洯椱伳5䔷朹᰻夽⼿㙁摃≅ⵇ㱉╋ⵍ㕏牑㵓㡕⹗㽙㉛⩝ཟၡᵣ履", a_);
							object[] array = new object[7];
							int num5 = 0;
							global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType;
							if (ampDeviceInfo == null)
							{
								connectionType = null;
							}
							else
							{
								global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = ampDeviceInfo.ConnectionInfo;
								connectionType = ((connectionInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo.ConnectionType) : null);
							}
							array[num5] = connectionType;
							array[1] = ((ampDeviceInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(ampDeviceInfo.Family) : null);
							array[2] = ((ampDeviceInfo != null) ? ampDeviceInfo.SerialNumber : null);
							array[3] = ((ampDeviceInfo != null) ? ampDeviceInfo.ModelNumber : null);
							array[4] = ((ampDeviceInfo != null) ? ampDeviceInfo.OperationId : null);
							array[5] = ((ampDeviceInfo != null) ? ampDeviceInfo.SoftwareVersion : null);
							array[6] = ((ampDeviceInfo != null) ? ampDeviceInfo.CodeplugVersion : null);
							global::System.Diagnostics.Trace.TraceInformation(string.Format(format, array) + string.Format(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ﳵ菷臹賽懿昁洃椅䜇攉渋崍搏猑怓猕∗㨙望⸝崟ม⸣䨥䤧天堫紭唯䘱縳夵娷漹䤻圽␿硁摃㵅祇㝉恋䑍㵏㵑こ㍕㑗恙籛╝剟ὡ䡣汥१ᩩ⩫ᥭ♯᝱ٳյᅷᕹቻ䑽ꁿ女랃ﮅꒇ", a_), new object[]
							{
								(ampDeviceInfo != null) ? new bool?(ampDeviceInfo.RadioOobState) : null,
								(ampDeviceInfo != null) ? new global::System.Guid?(ampDeviceInfo.LastSetJobUuid) : null,
								(ampDeviceInfo != null) ? ampDeviceInfo.ModelNumber : null,
								(ampDeviceInfo != null) ? ampDeviceInfo.SoftwareVersion : null
							}) + string.Format(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ﳵ髷諹뫻觽囿朁瘃甅愇攉戋㐍』椑␓欕㐗မ缛焝䐟䜡吣䨥崧䴩稫䬭䈯䄱崳夵嘷9᰻䔽焿㽁桃䱅㡇㡉⍋⩍╏ㅑ⁓ၕ㥗㝙㕛㉝ᥟ塡䑣ᵥ婧ᝩ䁫摭ᱯűᩳ䱵塷Ź佻ͽ詿ﾁ旅", a_), new object[]
							{
								(ampDeviceInfo != null) ? ampDeviceInfo.BpFirmwareVersion : null,
								(ampDeviceInfo != null) ? ampDeviceInfo.CodeplugVersion : null,
								(ampDeviceInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(ampDeviceInfo.Family) : null,
								(ampDeviceInfo != null) ? ampDeviceInfo.SerialNumber : null
							}));
							num = (short)1211760642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_3CA;
						case 3:
							goto IL_3E5;
						case 4:
							ampDeviceInfo.MapFromDeviceInventoryResponse(httpGetAmpDeviceInventory.ResponseData);
							ampDeviceInfo.ProcessorType = global::ProcessorType.AP;
							global::System.Diagnostics.Trace.TraceInformation(string.Concat(new string[]
							{
								global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("럵ꣷꋹ\udcfb냽䗿威倃崅娇漉洋樍㼏攑易缕気缙䄛㸝䌟䴡䨣䀥䄧䴩ఫอ累崱倳匵吷ᨹ刻䬽ⴿ⁁⅃㑅桇⍉㽋瑍", a_),
								ampDeviceInfo.ModelNumber,
								global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("\udaf5\ud8f7\udaf9뫻ꧽ⃿吁愃琅笇按挋怍』笑朓Ⱅ", a_),
								ampDeviceInfo.SoftwareVersion,
								global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("\udaf5\ud8f7맹鏻髽旿刁栃猅漇尉椋簍挏笑笓砕㠗猙漛␝", a_),
								ampDeviceInfo.CodeplugVersion
							}));
							this.ExtendedDeviceInfo = ampDeviceInfo;
							num = (short)1072496641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A7;
						IL_3CC:
						num = (short)406650883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3CA:
						goto IL_3CC;
					}
					IL_3E5:
					return ampDeviceInfo;
					IL_A7:
					httpGetAmpDeviceInventory = new global::Motorola.Common.Communication.HttpGetAmpDeviceInventory();
					this.b.SendAndReceiveMessage(httpGetAmpDeviceInventory);
					num = (short)491388928;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_8C;
				}
				catch (global::System.Exception ex)
				{
					string[] array2 = new string[7];
					int num6 = 0;
					string format2 = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("귵菷쫹臻ꏽ寿礁㔃笅唇儉看㰍洏休伓洕⬗朙䄛䔝爟䜡䔣䈥氧伩娫䜭匯圱紳堵帷唹愻", a_);
					object[] array3 = new object[4];
					int num7 = 0;
					global::Motorola.Common.Communication.CommonUtil.ConnectionType? connectionType2;
					if (ampDeviceInfo == null)
					{
						connectionType2 = null;
					}
					else
					{
						global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo2 = ampDeviceInfo.ConnectionInfo;
						connectionType2 = ((connectionInfo2 != null) ? new global::Motorola.Common.Communication.CommonUtil.ConnectionType?(connectionInfo2.ConnectionType) : null);
					}
					array3[num7] = connectionType2;
					array3[1] = ((ampDeviceInfo != null) ? new global::Motorola.Common.Communication.CommonUtil.ProductFamily?(ampDeviceInfo.Family) : null);
					array3[2] = ((ampDeviceInfo != null) ? ampDeviceInfo.SerialNumber : null);
					array3[3] = ((ampDeviceInfo != null) ? ampDeviceInfo.ModelNumber : null);
					array2[num6] = string.Format(format2, array3);
					array2[1] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("귵", a_);
					array2[2] = ((ampDeviceInfo != null) ? ampDeviceInfo.SoftwareVersion : null);
					array2[3] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꯵ꏷ", a_);
					array2[4] = ((ampDeviceInfo != null) ? ampDeviceInfo.CodeplugVersion : null);
					array2[5] = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꯵\ud8f7뿹蓻鷽旿爁瀃漅朇搉Ⰻ挍甏愑朓眕缗缙☛㸝", a_);
					array2[6] = ex.Message;
					global::System.Diagnostics.Trace.TraceError(string.Concat(array2), new object[]
					{
						ex.StackTrace,
						ex.StackTrace
					});
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_CpsCouldNotReadDevice, ex.Message);
				}
				return ampDeviceInfo;
			}
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00005594 File Offset: 0x00003794
		public string ReadSerialNumber()
		{
			int a_ = 10;
			short num;
			string result;
			try
			{
				num = (short)1005544615;
				short num2 = num;
				num = (short)1446077607;
				switch (num2 == num)
				{
				}
				num = (short)1741291520;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.HttpGetAmpDeviceInventory httpGetAmpDeviceInventory = new global::Motorola.Common.Communication.HttpGetAmpDeviceInventory();
				this.b.SendAndReceiveMessage(httpGetAmpDeviceInventory);
				string lsn = httpGetAmpDeviceInventory.ResponseData.Lsn;
				global::System.Diagnostics.Trace.TraceInformation(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("꧹駻賽槿持栃★昇缉愋氍甏怑㐓愕礗椙☛㸝", a_) + lsn);
				result = lsn;
			}
			catch (global::System.Exception ex)
			{
				global::System.Diagnostics.Trace.TraceError(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("맹鏻诽泿昁␃栅朇縉Ⰻ簍甏昑易缕紗氙礛㸝吟䨡䄣إ䰧伩娫䜭匯圱ᐳ䔵崷䠹唻弽ⰿ扁⩃㍅╇⡉⥋㱍繏", a_));
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("맹鏻诽泿昁␃栅朇縉Ⰻ簍甏昑易缕紗氙礛㸝吟䨡䄣إ䰧伩娫䜭匯圱ᐳ䔵崷䠹唻弽ⰿ扁⩃㍅╇⡉⥋㱍繏", a_), ex);
			}
			num = (short)85786625;
			if (num != 0)
			{
			}
			num = (short)1716518912;
			short num3 = num;
			return result;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000056C0 File Offset: 0x000038C0
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo ampDeviceInfo = new global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo();
			short num2;
			try
			{
				int num;
				global::Motorola.Common.Communication.HttpGetAmpDeviceInventory httpGetAmpDeviceInventory;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_12:
						switch (num)
						{
						case 0:
							ampDeviceInfo.MapFromDeviceInventoryResponse(httpGetAmpDeviceInventory.ResponseData);
							ampDeviceInfo.ProcessorType = global::ProcessorType.AP;
							ampDeviceInfo.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo
							{
								IsTlsPskCompatible = true
							};
							this.ExtendedDeviceInfo = ampDeviceInfo;
							num2 = (short)1780744194;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							goto IL_11D;
						case 2:
							goto IL_105;
						case 3:
						{
							if (httpGetAmpDeviceInventory.ResponseData == null)
							{
								goto IL_105;
							}
							num2 = (short)2039144657;
							short num3 = num2;
							num2 = (short)768794833;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_3A;
							default:
								num2 = (short)733872128;
								if (num2 != 0)
								{
								}
								num2 = (short)1511391232;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						}
						goto IL_28;
						IL_105:
						num2 = (short)939261953;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_11D:
					goto IL_131;
				}
				IL_28:
				httpGetAmpDeviceInventory = new global::Motorola.Common.Communication.HttpGetAmpDeviceInventory();
				this.b.SendAndReceiveMessage(httpGetAmpDeviceInventory);
				IL_3A:
				num2 = (short)70713347;
				num = (int)((global::System.IntPtr)num2);
				goto IL_12;
			}
			catch (global::System.Exception ex)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_CpsCouldNotReadDevice, ex.Message);
			}
			IL_131:
			num2 = (short)1082458113;
			if (num2 != 0)
			{
			}
			num2 = (short)1564278784;
			short num4 = num2;
			return ampDeviceInfo;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00005870 File Offset: 0x00003A70
		public bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			short num = (short)1793645363;
			short num2 = num;
			num = (short)1890966323;
			switch (num2 == num)
			{
			default:
			{
				num = (short)414973952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1436811264;
			if (num != 0)
			{
			}
			num = (short)523304961;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00005920 File Offset: 0x00003B20
		public void OpenSession(ushort sessionId, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)868605646;
			short num2 = num;
			num = (short)103800526;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2041184256;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1880424449;
			if (num != 0)
			{
			}
			num = (short)397279232;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000059CC File Offset: 0x00003BCC
		public void CloseSession(ushort sessionId, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, bool pendingDeploy)
		{
			short num = (short)1180640894;
			short num2 = num;
			num = (short)1515857534;
			switch (num2 == num)
			{
			default:
			{
				num = (short)16252928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1016266753;
			if (num != 0)
			{
			}
			num = (short)1326907392;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00005A78 File Offset: 0x00003C78
		private byte[] a(global::System.IO.Stream A_0)
		{
			short num = (short)1556480001;
			if (num != 0)
			{
			}
			num = (short)1133969408;
			short num2 = num;
			num = (short)1920991232;
			switch (num)
			{
			default:
			{
				byte[] result;
				try
				{
					global::System.IO.Compression.ZipArchive zipArchive = new global::System.IO.Compression.ZipArchive(A_0, global::System.IO.Compression.ZipArchiveMode.Read);
					try
					{
						num = (short)2043412484;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.IO.Compression.ZipArchiveEntry zipArchiveEntry;
							global::System.IO.Stream stream;
							switch (num3)
							{
							case 0:
								if (zipArchiveEntry != null)
								{
									num = (short)246087681;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_212;
							case 1:
								goto IL_1EE;
							case 2:
								goto IL_231;
							case 3:
								try
								{
									return stream.ToArrayBytes();
								}
								finally
								{
									num = (short)123535362;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											goto IL_1EB;
										case 1:
											((global::System.IDisposable)stream).Dispose();
											num = (short)325976064;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_1B2;
											}
											continue;
										}
										IL_1B2:
										if (stream == null)
										{
											break;
										}
										num = (short)1447624705;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_1EB:;
								}
								goto IL_1EE;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_B6;
								}
								continue;
							}
							IL_B6:
							zipArchiveEntry = zipArchive.Entries.FirstOrDefault(new global::System.Func<global::System.IO.Compression.ZipArchiveEntry, bool>(global::Motorola.Common.Communication.AmpApSequenceManager.<>c.<>9.a));
							num = (short)1964805816;
							short num4 = num;
							num = (short)1540329144;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_212:
								result = global::System.Array.Empty<byte>();
								num = (short)1585709058;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)527761408;
								if (num != 0)
								{
								}
								num = (short)1764491264;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1EE:
							stream = zipArchiveEntry.Open();
							num = (short)865533955;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_231:;
					}
					finally
					{
						num = (short)533004290;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_29E;
							case 1:
								((global::System.IDisposable)zipArchive).Dispose();
								num = (short)166133760;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_268;
								}
								continue;
							}
							IL_268:
							if (zipArchive == null)
							{
								break;
							}
							num = (short)887488513;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_29E:;
					}
				}
				finally
				{
					num = (short)1074921474;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_30A;
						case 1:
							((global::System.IDisposable)A_0).Dispose();
							num = (short)2126774272;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2D3;
							}
							continue;
						}
						IL_2D3:
						if (A_0 == null)
						{
							break;
						}
						num = (short)170721281;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_30A:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00005DE0 File Offset: 0x00003FE0
		private global::System.IO.Stream a(string url)
		{
			int a_ = 13;
			short num;
			global::System.IO.Stream responseData;
			try
			{
				num = (short)1785724930;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_F5;
					case 1:
						goto IL_A1;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					}
					IL_39:
					num = (short)1203639324;
					short num3 = num;
					num = (short)2116686876;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A3;
					default:
						num = (short)457113600;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(url))
						{
							num = (short)2110849025;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							responseData = this.e.RepeatRequest<global::Motorola.Common.Communication.AmpRequest.GetFileRequest>(new global::Motorola.Common.Communication.AmpRequest.GetFileRequest(url), 3).ResponseData;
							num = (short)644022272;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
				}
				IL_A1:
				IL_A3:
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("裼跾洀", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뻼郾漀攂氄怆⤈笊氌氎稐爒爔爖㤘渚漜猞Ġ䨢嘤ܦ䜨帪䄬䌮ᄰ尲䜴᜶尸嘺䴼䬾㡀", a_));
				IL_F5:;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(string.Format(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("민黾栀漂怄挆⤈缊戌⼎瘐瘒愔㜖娘琚猜礞䠠䐢Ԥ眦䠨䠪䘬丮嘰嘲༴᜶䈸଺䀼", a_), ex), global::System.Array.Empty<object>());
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, ex.Message);
			}
			num = (short)1783758849;
			if (num != 0)
			{
			}
			num = (short)1069613056;
			short num4 = num;
			return responseData;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00005F88 File Offset: 0x00004188
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.DeviceFileInfo> a(global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor A_0)
		{
			int a_ = 4;
			short num;
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.DeviceFileInfo> files;
			try
			{
				num = (short)397803521;
				if (num != 0)
				{
				}
				files = this.e.RepeatRequest<global::Motorola.Common.Communication.AmpRequest.PostJobDescriptorRequest>(new global::Motorola.Common.Communication.AmpRequest.PostJobDescriptorRequest(A_0), 3).ResponseData.Files;
			}
			catch (global::Motorola.Common.CustomException.CommonException ex)
			{
				if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.GenericError)
				{
					goto IL_75;
				}
				IL_5E:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(ex.Message, global::System.Array.Empty<object>());
				IL_75:
				num = (short)1791588409;
				short num2 = num;
				num = (short)990935097;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5E;
				default:
					num = (short)1542979584;
					if (num != 0)
					{
					}
					throw;
				}
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(string.Format(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("닳韵釷雹駻髽⃿瘁欃★砇攉缋稍』堑笓琕㠗帙礛洝䌟倡䴣嘥尧䔩師ᐭု䤱г䬵", a_), ex2), global::System.Array.Empty<object>());
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, ex2.Message);
			}
			num = (short)1171128320;
			short num3 = num;
			return files;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000060D0 File Offset: 0x000042D0
		private static string a(global::System.Collections.Generic.List<global::Motorola.Common.Communication.AmpRequest.Models.DeviceFileInfo> A_0, string A_1)
		{
			int a_ = 13;
			string url;
			short num;
			for (;;)
			{
				global::Motorola.Common.Communication.AmpApSequenceManager.a a = new global::Motorola.Common.Communication.AmpApSequenceManager.a();
				a.a = A_1;
				try
				{
					url = A_0.First(new global::System.Func<global::Motorola.Common.Communication.AmpRequest.Models.DeviceFileInfo, bool>(a.b)).Url;
				}
				catch (global::System.Exception ex)
				{
					string text = global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("민雾洀昂䰄椆漈搊ⴌ砎砐朒純㜖弘爚焜稞漠䈢䠤䈦ᐨ", a_) + a.a + global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("\uddfc釾渀眂┄愆昈縊挌欎㼐㌒倔漖稘縚洜欞䠠䰢䬤ᴦन", a_) + ex.Message;
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(text, global::System.Array.Empty<object>());
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, text);
				}
				num = (short)849281025;
				if (num != 0)
				{
				}
				num = (short)2144403456;
				short num2 = num;
				num = (short)378239640;
				short num3 = num;
				num = (short)1457486488;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_FE;
				}
			}
			IL_FE:
			num = (short)865075200;
			if (num != 0)
			{
			}
			return url;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00006204 File Offset: 0x00004404
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks<T>(global::System.Collections.Generic.ICollection<T> blockList)
		{
			short num = (short)463091553;
			short num2 = num;
			num = (short)1943877473;
			switch (num2 == num)
			{
			default:
			{
				num = (short)966262784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)715915264;
			if (num != 0)
			{
			}
			num = (short)981663745;
			if (num != 0)
			{
			}
			return this.f = this.ReadDevice(null, 0);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000062C0 File Offset: 0x000044C0
		private void a(string A_0, string A_1, int? A_2 = null)
		{
			int a_ = 9;
			short num;
			global::System.SystemException ex2;
			object obj;
			global::System.SystemException ex;
			bool flag;
			short num3;
			int num4;
			try
			{
				num = (short)604110848;
				switch (num)
				{
				default:
				{
					num = (short)381288453;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							try
							{
								global::System.IO.FileStream fileStream;
								global::Motorola.Common.Communication.AmpRequest.HttpAmpPostFirmwarePackageRequest msg = new global::Motorola.Common.Communication.AmpRequest.HttpAmpPostFirmwarePackageRequest(A_0, fileStream, A_2);
								this.b.SendAndReceiveMessage(msg);
								goto IL_1B8;
							}
							finally
							{
								num = (short)1516961794;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.IO.FileStream fileStream;
									switch (num2)
									{
									case 0:
										goto IL_10E;
									case 1:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)537198592;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_D9;
										}
										continue;
									}
									IL_D9:
									if (fileStream == null)
									{
										break;
									}
									num = (short)1858863105;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_10E:;
							}
							goto IL_111;
							IL_1B8:
							num = (short)1769209859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_87;
						case 2:
						{
							if (string.IsNullOrEmpty(A_1))
							{
								num = (short)1376260;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_1, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
							num = (short)1582235648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_1D0;
						case 4:
							goto IL_1B6;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_66;
							}
							continue;
						}
						IL_66:
						if (string.IsNullOrEmpty(A_0))
						{
							num = (short)815857665;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)866713602;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_87:
					IL_111:
					throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鿸鋺迼鋾瘀戂眄戆專礊愌", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鿸鋺迼鋾瘀戂眄戆專礊愌⼎昐爒昔㜖眘渚焜猞Ġ䰢圤ܦ䰨䘪崬嬮䠰ᴲ", a_));
					IL_1B6:
					throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鿸鋺迼鋾瘀戂眄戆夈樊礌朎", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("鿸鋺迼鋾瘀戂眄戆夈樊礌朎ㄐ搒琔搖㤘甚栜猞䴠̢䨤唦न个䀬弮䔰䨲᬴", a_));
					IL_1D0:
					break;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch when (delegate
			{
				// Failed to create a 'catch-when' expression
				ex = (obj as global::System.SystemException);
				if (ex == null)
				{
					flag = false;
				}
				else
				{
					ex2 = ex;
					if (ex2 is global::System.NotSupportedException)
					{
						num = (short)2090648462;
						num3 = num;
						num = (short)1487389582;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1465319424;
							if (num != 0)
							{
							}
							num4 = 1;
							goto IL_249;
						}
					}
					num4 = ((ex2 is global::System.IO.IOException) ? 1 : 0);
					IL_249:
					flag = (num4 != 0);
				}
				endfilter(flag);
			})
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, ex2.Message);
			}
			catch (global::System.Exception ex3)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(string.Format(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뿸髺铼鏾搀朂┄猆昈⬊紌怎成朒㔔焖瀘眚砜㼞䈠䰢䬤匦䰨䔪夬༮䔰尲ᔴ匶尸䴺吼尾⑀祂敄㱆祈㙊", a_), ex3), global::System.Array.Empty<object>());
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, ex3.Message);
			}
			num = (short)508362753;
			if (num != 0)
			{
			}
			num = (short)1639251968;
			short num5 = num;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00006610 File Offset: 0x00004810
		private void b(string A_0, byte[] A_1)
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)2084569090;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1AA;
					case 1:
						goto IL_15F;
					case 2:
					{
						num = (short)1947286056;
						short num3 = num;
						num = (short)150747688;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_143;
						default:
							num = (short)738656256;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_96;
							}
							continue;
						}
						break;
					}
					case 3:
						goto IL_143;
					case 4:
						if (A_1 != null)
						{
							num = (short)179240965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
					case 5:
						num = (short)2107834371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_B2;
					}
					IL_96:
					if (string.IsNullOrEmpty(A_0))
					{
						num = (short)1971191814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1903165444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_143:
					if (A_1.Length == 0)
					{
						num = (short)1465319425;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.a(A_0, A_1);
						num = (short)816316416;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_B2:
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("戀氂欄愆怈氊堌紎紐", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("䈀氂欄愆怈氊堌紎紐㌒瘔砖氘眚礜焞ؠ圢Ԥ䔦䰨ପ䌬娮崰弲ᔴ堶䬸ᬺ堼刾ㅀ㝂㱄", a_));
				IL_D6:
				throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("戀氂欄愆怈氊崌渎爐砒琔瀖簘弚簜欞䀠", a_), global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("儀戂昄氆栈氊栌䬎瀐朒琔㜖稘琚栜猞䔠䴢Ȥ匦न䤪䠬༮弰䘲头嬶ᤸ吺似Ἶ⑀⹂㕄㍆え", a_));
				IL_15F:
				num = (short)681771009;
				if (num != 0)
				{
				}
				goto IL_D6;
				IL_1AA:;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(string.Format(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("䜀戂氄欆氈漊ⴌ笎縐㌒攔砖樘漚㴜礞䠠伢䀤ܦ䨨䐪䌬嬮吰崲䄴᜶䴸吺ᴼ嬾⑀㕂ⱄ⑆ⱈ煊浌㑎慐⹒", a_), ex), global::System.Array.Empty<object>());
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, ex.Message);
			}
			num = (short)485359616;
			short num4 = num;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000685C File Offset: 0x00004A5C
		private void a(string A_0, byte[] A_1)
		{
			short num = (short)1728053248;
			short num2 = num;
			num = (short)723216506;
			short num3 = num;
			num = (short)608659578;
			switch (num3 == num)
			{
			}
			num = (short)1801846785;
			if (num != 0)
			{
			}
			num = (short)1275527168;
			if (num != 0)
			{
			}
			this.e.RepeatRequest<global::Motorola.Common.Communication.AmpRequest.HttpAmpPostConfigPackageRequest>(new global::Motorola.Common.Communication.AmpRequest.HttpAmpPostConfigPackageRequest(A_0, A_1), 3);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00006918 File Offset: 0x00004B18
		public void ValidateCodeplugVersion(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			int a_ = 2;
			short num = (short)424083456;
			switch (num)
			{
			default:
			{
				num = (short)1722548238;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					string value;
					string value2;
					switch (num2)
					{
					case 0:
						num = (short)745078789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						int num3;
						int num4;
						if (num3 == num4)
						{
							num = (short)2015166477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
						goto IL_2EE;
					case 3:
						value = null;
						goto IL_3FA;
					case 4:
						goto IL_13E;
					case 5:
					{
						num = (short)121569280;
						short num5 = num;
						value2 = null;
						goto IL_3D3;
					}
					case 6:
					{
						global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo = this.ExtendedDeviceInfo;
						if (extendedDeviceInfo == null)
						{
							num = (short)888733699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						value = extendedDeviceInfo.CodeplugVersion;
						goto IL_3FA;
					}
					case 7:
						goto IL_41C;
					case 8:
					{
						global::Motorola.Common.Communication.Pba.PackedRadioData codeplugData = pba.CodeplugData;
						if (codeplugData == null)
						{
							num = (short)951975945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						value2 = codeplugData.CPVersion;
						goto IL_3D3;
					}
					case 9:
						value2 = null;
						goto IL_3D3;
					case 10:
					{
						int num3;
						int num4;
						if (num3 >= num4)
						{
							num = (short)275906562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_175;
					}
					case 11:
					{
						num = (short)882358370;
						short num6 = num;
						num = (short)1036564578;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2EE;
						default:
						{
							num = (short)1933180928;
							if (num != 0)
							{
							}
							if (!pba.CodeplugData.CPVersion.StartsWith(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("ꃱ", a_), global::System.StringComparison.Ordinal))
							{
								num = (short)282329103;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string codeplugVersion = this.ExtendedDeviceInfo.CodeplugVersion;
							string cpversion = pba.CodeplugData.CPVersion;
							int num4 = (int)global::System.Convert.ToInt16(codeplugVersion.Substring(1, 2), 10);
							int num3 = (int)global::System.Convert.ToInt16(cpversion.Substring(1, 2), 10);
							int num7 = (int)global::System.Convert.ToInt16(codeplugVersion.Substring(4, 2), 10);
							int num8 = (int)global::System.Convert.ToInt16(cpversion.Substring(4, 2), 10);
							num = (short)93716490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 12:
						num = (short)152436747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1858011154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						switch (0)
						{
						case 0:
							goto IL_98;
						}
						continue;
					case 15:
						goto IL_3CE;
					case 16:
						num = (short)496435206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (!pba.IsRetoreJob)
						{
							num = (short)631308300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
					{
						int num7;
						int num8;
						if (num8 < num7)
						{
							num = (short)245366785;
							if (num != 0)
							{
							}
							num = (short)240582660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_98:
					if (pba == null)
					{
						num = (short)626130944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1997209608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FA:
					if (string.IsNullOrEmpty(value))
					{
						num = (short)1369178119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1182728209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EE:
					num = (short)1605173249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D3:
					if (string.IsNullOrEmpty(value2))
					{
						goto IL_180;
					}
					num = (short)747962384;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13E:
				IL_175:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CPVersionVerifyFailed);
				IL_180:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CPVersionVerifyFailed);
				IL_3CE:
				return;
				IL_41C:
				goto IL_180;
			}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00006D48 File Offset: 0x00004F48
		public void ValidateUpdate()
		{
			short num = (short)149422080;
			short num2 = num;
			num = (short)424786124;
			short num3 = num;
			num = (short)1389607116;
			switch (num3 == num)
			{
			}
			num = (short)707002368;
			if (num != 0)
			{
			}
			num = (short)302252033;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000003 RID: 3
		private const int a = 15000;

		// Token: 0x04000004 RID: 4
		private readonly global::Motorola.Common.Communication.IMessageExecutor b;

		// Token: 0x04000005 RID: 5
		private readonly global::System.TimeSpan c = global::System.TimeSpan.FromSeconds(5.0);

		// Token: 0x04000006 RID: 6
		private readonly global::Motorola.Common.Communication.IAmpPackageFilePathProvider d;

		// Token: 0x04000007 RID: 7
		private readonly global::Motorola.Common.Communication.Utils.AmpRequestRepeater e;

		// Token: 0x04000008 RID: 8
		private global::Motorola.Common.Communication.Pba.PbaObject f;

		// Token: 0x04000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.IProgressIndicator g;

		// Token: 0x0400000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo h;

		// Token: 0x0200000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000025 RID: 37 RVA: 0x00007058 File Offset: 0x00005258
			internal bool b(global::Motorola.Common.Communication.AmpRequest.Models.DeviceFileInfo A_0)
			{
				short num = (short)582942720;
				short num2 = num;
				num = (short)1009874846;
				short num3 = num;
				num = (short)2075948958;
				switch (num3 == num)
				{
				}
				num = (short)979763201;
				if (num != 0)
				{
				}
				num = (short)37814272;
				if (num != 0)
				{
				}
				return string.Equals(A_0.FileName, this.a, global::System.StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x04000012 RID: 18
			public string a;
		}
	}
}
