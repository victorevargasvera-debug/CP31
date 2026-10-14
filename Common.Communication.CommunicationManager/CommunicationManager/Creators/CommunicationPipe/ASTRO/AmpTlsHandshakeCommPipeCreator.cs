using System;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager.Creators.CommunicationPipe.ASTRO
{
	// Token: 0x02000042 RID: 66
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.TlsHandshake)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.TlsHandshake)]
	internal class AmpTlsHandshakeCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x06000158 RID: 344 RVA: 0x0001B634 File Offset: 0x00019834
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			int a_ = 6;
			short num = (short)243007492;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo ampDeviceInfo;
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					if (ampDeviceInfo != null)
					{
						num = (short)261357573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D6;
				case 1:
					goto IL_1DC;
				case 2:
					flag = true;
					goto IL_1E1;
				case 3:
				{
					if (ampDeviceInfo.ProcessorType == global::ProcessorType.AP)
					{
						goto IL_203;
					}
					num = (short)1734654625;
					short num3 = num;
					num = (short)170244769;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_113;
					default:
						num = (short)385679360;
						if (num != 0)
						{
						}
						num = (short)840695809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 5:
					num = (short)1216544771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_A7;
				case 7:
					num = (short)1848442886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_4D;
				IL_1E1:
				if (flag)
				{
					num = (short)1644232711;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				ampDeviceInfo = (deviceInfo as global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo);
				num = (short)346947584;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4D:
				global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = deviceInfo.ConnectionInfo;
				if (connectionInfo != null)
				{
					flag = !connectionInfo.IsTlsPskCompatible;
					goto IL_1E1;
				}
				IL_113:
				num = (short)577896448;
				short num4 = num;
				num = (short)276955138;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A7:
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ཚ㕜㙞በ䍢ࡤɦᵨͪɬ୮兰ቲᙴᑶᱸ୺ॼ౾ꆀꮊ\ud98c쎎슐뎒얔쒖튘뮚\ude9c철펢쒤펦삨즪솬쪮醰ힲ킴솶킸\ud8ba\ud8bc醾", a_), global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㽚㡜⥞ࡠbd⹦ݨ൪ɬ", a_));
			IL_D6:
			num = (short)1259732993;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ཚ㕜㙞በ䍢ࡤɦᵨͪɬ୮兰rtݶॸᑺོ୾ꎂ권캎\udc90쎒떔ﲘﲞ쒠킢薤캦잨讪ﾮ醰\udeb2\udab4펶\udcb8閺", a_));
			IL_1DC:
			goto IL_D6;
			IL_203:
			global::System.Net.IPAddress ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(ampDeviceInfo);
			int portNumber = int.Parse(deviceInfo.ConnectionInfo.Location);
			return new global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe(ipaddress, portNumber, false);
		}
	}
}
