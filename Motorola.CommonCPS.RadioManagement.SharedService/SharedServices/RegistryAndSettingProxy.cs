using System;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.Global;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000B6 RID: 182
	public class RegistryAndSettingProxy
	{
		// Token: 0x06000A8B RID: 2699 RVA: 0x00080510 File Offset: 0x0007E710
		private RegistryAndSettingProxy()
		{
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Template)
			{
				this.RegistryAndSetting = new global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateRegistryAndSetting();
				return;
			}
			this.RegistryAndSetting = new global::Motorola.CommonCPS.RadioManagement.SharedServices.ConfigurationRegistryAndSetting();
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000A8C RID: 2700 RVA: 0x00080544 File Offset: 0x0007E744
		// (set) Token: 0x06000A8D RID: 2701 RVA: 0x000805F4 File Offset: 0x0007E7F4
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IRegistryAndSetting RegistryAndSetting
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)657229384;
				short num2 = num;
				num = (short)1114539592;
				switch (num2 == num)
				{
				}
				num = (short)475201537;
				if (num != 0)
				{
				}
				num = (short)560922624;
				short num3 = num;
				num = (short)2012676096;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)791850213;
				short num2 = num;
				num = (short)1966058725;
				switch (num2 == num)
				{
				}
				num = (short)55967745;
				if (num != 0)
				{
				}
				num = (short)924319744;
				short num3 = num;
				num = (short)487129088;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x000806A4 File Offset: 0x0007E8A4
		public static global::Motorola.CommonCPS.RadioManagement.SharedServices.RegistryAndSettingProxy GetInstance()
		{
			short num = (short)902950469;
			short num2 = num;
			num = (short)1304751685;
			switch (num2 == num)
			{
			}
			num = (short)384040960;
			if (num != 0)
			{
			}
			num = (short)405078016;
			short num3 = num;
			num = (short)1229651969;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.SharedServices.RegistryAndSettingProxy result;
			if ((result = global::Motorola.CommonCPS.RadioManagement.SharedServices.RegistryAndSettingProxy.a) == null)
			{
				result = (global::Motorola.CommonCPS.RadioManagement.SharedServices.RegistryAndSettingProxy.a = new global::Motorola.CommonCPS.RadioManagement.SharedServices.RegistryAndSettingProxy());
			}
			return result;
		}

		// Token: 0x0400018B RID: 395
		private static global::Motorola.CommonCPS.RadioManagement.SharedServices.RegistryAndSettingProxy a;

		// Token: 0x0400018C RID: 396
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.IRegistryAndSetting b;
	}
}
