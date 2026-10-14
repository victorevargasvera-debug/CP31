using System;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000016 RID: 22
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.TlsHandshake)]
	internal class AstroOtapTlsHandshakeCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x06000061 RID: 97 RVA: 0x0000A010 File Offset: 0x00008210
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			int a_ = 6;
			short num = (short)902430723;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)891486209;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					num = (short)1532428290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_15E;
				case 2:
					if (deviceInfo.ConnectionInfo.OtapConnectionType != global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LTE)
					{
						goto IL_147;
					}
					goto IL_160;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				}
				IL_65:
				if (!deviceInfo.ConnectionInfo.IsTlsPskCompatible)
				{
					break;
				}
				num = (short)344596453;
				short num3 = num;
				num = (short)1522933733;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1583939584;
					if (num != 0)
					{
					}
					num = (short)1953955840;
					short num4 = num;
					num = (short)1527906304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_147:
				num = (short)1389232129;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_100:
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ཚ㕜㙞በ䍢ࡤɦᵨͪɬ୮兰ቲᙴᑶᱸ୺ॼ౾ꆀꮊ\ud98c쎎슐뎒얔쒖튘뮚\ude9c철펢쒤펦삨즪솬쪮醰ힲ킴솶킸\ud8ba\ud8bc醾", a_), global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㽚㡜⥞ࡠbd⹦ݨ൪ɬ", a_));
			IL_15E:
			goto IL_100;
			IL_160:
			global::System.Net.IPAddress ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(deviceInfo);
			int portNumber = int.Parse(deviceInfo.ConnectionInfo.Location);
			return new global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe(ipaddress, portNumber, false);
		}
	}
}
