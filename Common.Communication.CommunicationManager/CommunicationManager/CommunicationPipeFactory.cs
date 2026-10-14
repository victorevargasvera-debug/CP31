using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000010 RID: 16
	public class CommunicationPipeFactory : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00008BDC File Offset: 0x00006DDC
		public CommunicationPipeFactory(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator> creators)
		{
			this.a = creators.SelectMany(delegate(global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator creator)
			{
				short num = (short)345955996;
				short num2 = num;
				num = (short)899276444;
				switch (num2 == num)
				{
				default:
				{
					num = (short)921370624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2127626241;
				if (num != 0)
				{
				}
				num = (short)680919040;
				if (num != 0)
				{
				}
				return creator.GetType().GetCustomAttributes<global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute>();
			}, delegate(global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator creator, global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute attribute)
			{
				short num = (short)1949044128;
				short num2 = num;
				num = (short)123866528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)401604608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)112263169;
				if (num != 0)
				{
				}
				num = (short)707133440;
				if (num != 0)
				{
				}
				return new
				{
					creator,
					attribute
				};
			}).ToDictionary(delegate(tuple)
			{
				short num = (short)766492751;
				short num2 = num;
				num = (short)1128579151;
				switch (num2 == num)
				{
				default:
				{
					num = (short)141623296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1078722560;
				if (num != 0)
				{
				}
				num = (short)501219329;
				if (num != 0)
				{
				}
				return tuple.attribute;
			}, delegate(tuple)
			{
				short num = (short)1909116276;
				short num2 = num;
				num = (short)1715719540;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1675296768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)682950657;
				if (num != 0)
				{
				}
				num = (short)1525940224;
				if (num != 0)
				{
				}
				return tuple.creator;
			});
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00008C8C File Offset: 0x00006E8C
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe CreateCommunicationPipe(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter = null)
		{
			short num = (short)1461588681;
			short num2 = num;
			num = (short)628363977;
			switch (num2 == num)
			{
			default:
			{
				num = (short)403243008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)691404800;
			if (num != 0)
			{
			}
			num = (short)832765953;
			if (num != 0)
			{
			}
			return this.FindCommunicationPipeCreator(deviceInfo, operation).Create(deviceInfo, sessionParameter);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00008D44 File Offset: 0x00006F44
		public global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator FindCommunicationPipeCreator(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			short num = (short)468058112;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)2142240768;
				short num3 = num;
				num = (short)1266614273;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute attrToMatch = new global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute(deviceInfo.ConnectionInfo.ConnectionType, deviceInfo.Family, deviceInfo.RadioStorage, operation);
				global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator value;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_B5;
					}
					global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator> keyValuePair;
					for (;;)
					{
						IL_A2:
						switch (num2)
						{
						case 0:
							goto IL_18D;
						case 1:
						{
							num = (short)1637555975;
							short num4 = num;
							num = (short)1385963271;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								goto IL_14B;
							}
							break;
						}
						case 2:
							if (keyValuePair.Equals(default(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator>)))
							{
								num = (short)1186856961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							value = keyValuePair.Value;
							num = (short)1594097664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5;
					}
					IL_14B:
					num = (short)902692864;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNoMatchedInitializer);
					IL_18D:
					return value;
					IL_B5:
					keyValuePair = this.a.SingleOrDefault(delegate(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator> x)
					{
						short num5 = (short)1500731825;
						short num6 = num5;
						num5 = (short)1525569969;
						switch (num6 == num5)
						{
						default:
						{
							num5 = (short)102760448;
							short num7 = num5;
							break;
						}
						case true:
							break;
						}
						num5 = (short)899547136;
						if (num5 != 0)
						{
						}
						num5 = (short)1843068929;
						if (num5 != 0)
						{
						}
						return x.Key.Match(attrToMatch);
					});
					num = (short)530448386;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_A2;
				}
				catch (global::System.InvalidOperationException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerTooManyMatchedInitializer);
				}
				return value;
			}
			}
		}

		// Token: 0x04000016 RID: 22
		private readonly global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator> a;
	}
}
