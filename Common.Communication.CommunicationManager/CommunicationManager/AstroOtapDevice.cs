using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000029 RID: 41
	internal class AstroOtapDevice : global::Motorola.Common.Communication.CommunicationManager.MotoDevice
	{
		// Token: 0x0600008E RID: 142 RVA: 0x0000C628 File Offset: 0x0000A828
		public AstroOtapDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory) : base(deviceInfo, null, sequenceManagerFactory, communicationManager, communicationPipeFactory)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000C644 File Offset: 0x0000A844
		public override ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			int a_ = 1;
			switch (0)
			{
			case 0:
				goto IL_59;
			}
			int num;
			short num2;
			ushort num4;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)564607112;
					short num3 = num2;
					num2 = (short)628308104;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1DA;
					default:
						num2 = (short)295043072;
						if (num2 != 0)
						{
						}
						num2 = (short)1274085382;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_22B;
				case 2:
					if ((base.SequenceManager as global::Motorola.Common.Communication.IDifferentialWritable).DifferentialWriteSupported(num4, operationType))
					{
						num2 = (short)1724186633;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_116;
				case 3:
					if (sessionParameter != null)
					{
						num2 = (short)1901592584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_138;
				case 4:
					if (this.DeviceInfo.ConnectionInfo.IsTlsPskCompatible)
					{
						num2 = (short)2003304448;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_335;
				case 5:
					if (sessionParameter.ArchiveSession)
					{
						num2 = (short)266076161;
						if (num2 != 0)
						{
						}
						num2 = (short)489095181;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_335;
				case 6:
					if (sessionParameter != null)
					{
						num2 = (short)77922316;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_335;
				case 7:
					num2 = (short)1919221762;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᥕⱗ㭙ⱛ繝たၡţၥŧթᥫᵭ偯ⅱᅳյ୷፹፻ၽꁿ쮁삃벅ꢇ", a_) + sessionParameter.PreviousSessionID.ToString(), global::System.Array.Empty<object>());
					num2 = (short)1149960202;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)692322304;
					short num5 = num2;
					base.DifferentialWriteCapableRadio = true;
					this.InitDeviceExtendedDeviceParams();
					num2 = (short)729481217;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					goto IL_138;
				case 11:
					goto IL_22B;
				case 12:
					num2 = (short)579796997;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_1DA;
				case 14:
					if (base.SequenceManager is global::Motorola.Common.Communication.IDifferentialWritable)
					{
						num2 = (short)1923088391;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_116;
				case 15:
					goto IL_293;
				}
				goto IL_59;
				IL_116:
				this.InitDeviceParams();
				num2 = (short)1836056587;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_138:
				num2 = (short)774766606;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1DA:
				base.OpenSession(operationType, sessionParameter);
				num2 = (short)2059993103;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_22B:
				num2 = (short)1550188548;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_293:
			IL_335:
			base.UpdateSession(operationType, sessionParameter, num4);
			return num4;
			IL_59:
			num4 = base.OpenSession(global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create, sessionParameter);
			num2 = (short)1192886275;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000C990 File Offset: 0x0000AB90
		public override global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo()
		{
			switch (0)
			{
			case 0:
				goto IL_60;
			}
			int num;
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo extendedDeviceInfo;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_2BC;
				case 1:
				{
					if (!string.IsNullOrEmpty(extendedDeviceInfo.RadioID))
					{
						goto IL_1D1;
					}
					num2 = (short)64724887;
					short num3 = num2;
					num2 = (short)883007383;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)1779826689;
						if (num2 != 0)
						{
						}
						num2 = (short)1942290432;
						if (num2 != 0)
						{
						}
						num2 = (short)780992512;
						short num4 = num2;
						num2 = (short)380698631;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					this.DeviceInfo.ConnectionInfo.OtapConnectionType = extendedDeviceInfo.ConnectionInfo.OtapConnectionType;
					num2 = (short)897056784;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)929955849;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)242286600;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1306132492;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (this.DeviceInfo.ConnectionInfo != null)
					{
						num2 = (short)1842085891;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_35C;
				case 7:
					extendedDeviceInfo.RadioID = this.DeviceInfo.RadioID;
					num2 = (short)832634891;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (extendedDeviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRepeaterRadio)
					{
						num2 = (short)9699328;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return extendedDeviceInfo;
				case 9:
					if (extendedDeviceInfo.ConnectionInfo != null)
					{
						num2 = (short)1454374914;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_35C;
				case 10:
					goto IL_27D;
				case 11:
					goto IL_1D1;
				case 12:
					if (this.DeviceInfo.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.DMR3Network)
					{
						num2 = (short)1234108426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return extendedDeviceInfo;
				case 13:
					if (this.DeviceInfo.ConnectionInfo.ConnectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.LENetwork)
					{
						num2 = (short)91881477;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_27D;
				case 14:
					return extendedDeviceInfo;
				case 15:
					if (base.DifferentialWriteCapableRadio)
					{
						num2 = (short)1983578130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_403;
				case 16:
					goto IL_35C;
				case 17:
					if (extendedDeviceInfo.Family != global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio)
					{
						num2 = (short)300875780;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2BC;
				case 18:
					this.DeviceInfo.RadioStorage = extendedDeviceInfo.RadioStorage;
					base.ExtendedDeviceInfo = extendedDeviceInfo;
					num2 = (short)1486487571;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_403;
				}
				goto IL_60;
				IL_1D1:
				num2 = (short)1544814607;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_27D:
				num2 = (short)1903624209;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2BC:
				this.DeviceInfo.Family = extendedDeviceInfo.Family;
				num2 = (short)1470431246;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_35C:
				extendedDeviceInfo.ConnectionInfo = this.DeviceInfo.ConnectionInfo;
				extendedDeviceInfo.RadioState = global::Motorola.Common.Communication.CommonUtil.RadioState.Ready;
				this.DeviceInfo.CodeplugVersion = extendedDeviceInfo.CodeplugVersion;
				this.DeviceInfo.ModelNumber = extendedDeviceInfo.ModelNumber;
				this.DeviceInfo.SerialNumber = extendedDeviceInfo.SerialNumber;
				this.DeviceInfo.SoftwareVersion = extendedDeviceInfo.SoftwareVersion;
				num2 = (short)1984102413;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_403:
				num2 = (short)1774845958;
				num = (int)((global::System.IntPtr)num2);
			}
			return extendedDeviceInfo;
			IL_60:
			extendedDeviceInfo = base.SequenceManager.ReadExtendedDeviceInfo();
			num2 = (short)1140654081;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
