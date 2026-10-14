using System;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationPipe;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000019 RID: 25
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.TlsHandshake)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, global::Motorola.Common.Communication.CommonUtil.RadioOperation.TlsHandshake)]
	internal class AstroUsbBtTlsHandshakeCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x06000067 RID: 103 RVA: 0x0000A530 File Offset: 0x00008730
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			int a_ = 17;
			short num = (short)1899692033;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					num = (short)1286275074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 2:
				{
					num = (short)38329213;
					short num3 = num;
					num = (short)1702484861;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_113;
					default:
						goto IL_D9;
					}
					break;
				}
				case 3:
					num = (short)1677000705;
					if (num != 0)
					{
					}
					flag = true;
					goto IL_111;
				}
				IL_3E:
				global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = deviceInfo.ConnectionInfo;
				if (connectionInfo == null)
				{
					num = (short)1687945219;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag = !connectionInfo.IsTlsPskCompatible;
				goto IL_111;
				IL_113:
				num = (short)40042496;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_111:
				if (flag)
				{
					goto IL_113;
				}
				goto IL_139;
			}
			IL_D9:
			num = (short)1568079872;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㉥gͩὫ乭ᵯ᝱sṵ᝷ṹ屻ώﲇ黎겋ﺏﺑ뚕첗횙쾛뺝蚥얩솫\udead톯욱\uddb3풵풷\udfb9鲻\udabdꖿ듁귃ꗅ귇", a_), global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ɥ൧ᱩի൭ᕯ㭱ᩳၵ᝷", a_));
			IL_139:
			num = (short)1791754240;
			short num4 = num;
			global::System.Net.IPAddress ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(deviceInfo);
			int portNumber = int.Parse(deviceInfo.ConnectionInfo.Location);
			return new global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe(ipaddress, portNumber, false);
		}
	}
}
