using System;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule;

namespace Motorola.CommonCPS.RadioManagement
{
	// Token: 0x02000007 RID: 7
	public static class CommandHandlerFactory
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00003394 File Offset: 0x00001594
		static CommandHandlerFactory()
		{
			short num = (short)966393857;
			if (num != 0)
			{
			}
			num = (short)1327497216;
			short num2 = num;
			num = (short)714217413;
			short num3 = num;
			num = (short)1807357893;
			switch (num3 == num)
			{
			}
			num = (short)1481244672;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.CommandHandlerFactory.a = global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.InstanceResolver.GetInstance;
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000344C File Offset: 0x0000164C
		public static global::Motorola.CommonCPS.RadioManagement.Command.CommandHandler GetCommandHandlerInstance
		{
			get
			{
				short num = (short)668447486;
				short num2 = num;
				num = (short)2116662014;
				switch (num2 == num)
				{
				default:
				{
					num = (short)542703616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1384841217;
				if (num != 0)
				{
				}
				num = (short)1461714944;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.CommandHandlerFactory.a.Resolve<global::Motorola.CommonCPS.RadioManagement.Command.ASTROCommandHandler>();
			}
		}

		// Token: 0x04000009 RID: 9
		private static readonly global::Motorola.CommonCPS.RadioManagement.CommandHandlerDIModule.IInstanceResolver a;
	}
}
