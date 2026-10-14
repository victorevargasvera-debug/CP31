using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.IshHandler;

namespace Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP
{
	// Token: 0x02000040 RID: 64
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.FileSystem, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash)]
	public class AmpFileFlashSequenceManagerCreator : global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerCreator
	{
		// Token: 0x06000153 RID: 339 RVA: 0x0001B068 File Offset: 0x00019268
		public global::Motorola.Common.Communication.ISequenceManager Create(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo ampDeviceInfo;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1050411008;
					short num3 = num2;
					global::ProcessorType processorType;
					if (processorType == global::ProcessorType.BP)
					{
						goto IL_6D;
					}
					num2 = (short)690336986;
					short num4 = num2;
					num2 = (short)1847571674;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D0;
					default:
						num2 = (short)1792212992;
						if (num2 != 0)
						{
						}
						num2 = (short)1860567044;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					num2 = (short)1963917318;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_6B;
				case 3:
				{
					if (ampDeviceInfo == null)
					{
						num2 = (short)1114114;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::ProcessorType processorType = ampDeviceInfo.ProcessorType;
					num2 = (short)737017857;
					if (num2 != 0)
					{
					}
					num2 = (short)394264576;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					num2 = (short)794165253;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					global::ProcessorType processorType;
					if (processorType != global::ProcessorType.AP)
					{
						num2 = (short)908722177;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D0;
				}
				case 6:
					goto IL_1EE;
				}
				goto IL_35;
			}
			IL_6B:
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᡚ㉜⩞ൠݢ䕤०٨Ὢ䵬౮ၰrŴ坶൸፺᡼彾놐횞쾠얢쪤螦\udda8쒪趬\udcb0쎲튶쾸튺\udebc\udabe裀귂ꏄ꣆꓊뿌뗐뛒ꏔ뻖뫘뻚铜뇞蟠賢엤郦裨飪췬臮蓰鿲駴\ud9f6", a_), global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("㽚㡜⥞ࡠbd⹦ݨ൪ɬ", a_));
			IL_6D:
			return new global::Motorola.Common.Communication.AmpBpSequenceManager(new global::Motorola.Common.Communication.IshHandler.RcmpMessageExecutor(communicationPipe));
			IL_D0:
			return new global::Motorola.Common.Communication.AmpApSequenceManager(new global::Motorola.Common.Communication.AmpHttpMessageExecutor(communicationPipe, deviceInfo.ConnectionInfo.Location, deviceInfo.ConnectionInfo.UniqueAddress), new global::Motorola.Common.Communication.AmpFileFlashPackageFilePathProvider());
			IL_1EE:
			throw new global::System.NotSupportedException(string.Format(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("ᕚ㉜⭞䅠ၢၤᝦᥨѪὬ᭮ᑰᝲ啴ݶ୸ᑺṼ᩾ꦈﾊﾎꦒ떔ꦘ뎜", a_), ampDeviceInfo.ProcessorType));
			IL_35:
			ampDeviceInfo = (deviceInfo as global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo);
			num2 = (short)1010368515;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0001B29C File Offset: 0x0001949C
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1958502136 + A_1) + (global::System.IntPtr)70 + (global::System.IntPtr)22);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}
	}
}
