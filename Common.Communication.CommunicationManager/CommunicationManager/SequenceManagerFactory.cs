using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000036 RID: 54
	public class SequenceManagerFactory : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory
	{
		// Token: 0x0600012B RID: 299 RVA: 0x000184E8 File Offset: 0x000166E8
		public SequenceManagerFactory(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator> creators)
		{
			this.a = creators.SelectMany(delegate(global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator creator)
			{
				short num = (short)1517561738;
				short num2 = num;
				num = (short)720709514;
				switch (num2 == num)
				{
				}
				num = (short)1749155841;
				if (num != 0)
				{
				}
				num = (short)1555300352;
				short num3 = num;
				num = (short)1057226752;
				if (num != 0)
				{
				}
				return creator.GetType().GetCustomAttributes<global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute>();
			}, delegate(global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator creator, global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute attribute)
			{
				short num = (short)1504233965;
				short num2 = num;
				num = (short)94161389;
				switch (num2 == num)
				{
				}
				num = (short)310444032;
				if (num != 0)
				{
				}
				num = (short)1630011392;
				short num3 = num;
				num = (short)1974992897;
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
				short num = (short)1345347292;
				short num2 = num;
				num = (short)1550343900;
				switch (num2 == num)
				{
				}
				num = (short)143392768;
				if (num != 0)
				{
				}
				num = (short)1974861824;
				short num3 = num;
				num = (short)687079425;
				if (num != 0)
				{
				}
				return tuple.attribute;
			}, delegate(tuple)
			{
				short num = (short)323957850;
				short num2 = num;
				num = (short)1329804378;
				switch (num2 == num)
				{
				}
				num = (short)815595520;
				if (num != 0)
				{
				}
				num = (short)1629159424;
				short num3 = num;
				num = (short)1240793089;
				if (num != 0)
				{
				}
				return tuple.creator;
			});
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00018598 File Offset: 0x00016798
		public global::Motorola.Common.Communication.ISequenceManager CreateSequenceManager(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe iCommPipe, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			short num = (short)835470048;
			short num2 = num;
			num = (short)2054767328;
			switch (num2 == num)
			{
			}
			num = (short)1815871489;
			if (num != 0)
			{
			}
			num = (short)1721171968;
			short num3 = num;
			num = (short)354156544;
			if (num != 0)
			{
			}
			return this.a(deviceInfo, operation).Create(iCommPipe, deviceInfo, sessionParameter, operation);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00018650 File Offset: 0x00016850
		private global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation A_1)
		{
			short num = (short)1713635328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)277676033;
				if (num != 0)
				{
				}
				num = (short)1497169920;
				short num3 = num;
				global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute attrToMatch = new global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute(A_0.ConnectionInfo.ConnectionType, A_0.Family, A_0.RadioStorage, A_1);
				global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator value;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_B7;
					}
					global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator> keyValuePair;
					for (;;)
					{
						IL_A4:
						switch (num2)
						{
						case 0:
							goto IL_162;
						case 1:
							goto IL_18F;
						case 2:
						{
							num = (short)916690802;
							short num4 = num;
							num = (short)1739954034;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)2002059264;
								if (num != 0)
								{
								}
								if (keyValuePair.Equals(default(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator>)))
								{
									num = (short)1545863168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								value = keyValuePair.Value;
								num = (short)1827667969;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_B7;
					}
					IL_162:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerNoMatchedInitializer);
					IL_18F:
					return value;
					IL_B7:
					keyValuePair = this.a.SingleOrDefault(delegate(global::System.Collections.Generic.KeyValuePair<global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator> x)
					{
						short num5 = (short)697201438;
						short num6 = num5;
						num5 = (short)1190753054;
						switch (num6 == num5)
						{
						}
						num5 = (short)1283194880;
						if (num5 != 0)
						{
						}
						num5 = (short)1153826816;
						short num7 = num5;
						num5 = (short)1945894913;
						if (num5 != 0)
						{
						}
						return x.Key.Match(attrToMatch);
					});
					num = (short)1317142530;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_A4;
				}
				catch (global::System.InvalidOperationException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerTooManyMatchedInitializer);
				}
				return value;
			}
			}
		}

		// Token: 0x0400004F RID: 79
		private readonly global::System.Collections.Generic.Dictionary<global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator> a;
	}
}
