using System;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.LocalService;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200003E RID: 62
	public class ServiceProxy
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00015584 File Offset: 0x00013784
		private ServiceProxy()
		{
			this.a();
			this.LocalService = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService;
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600016D RID: 365 RVA: 0x000155B0 File Offset: 0x000137B0
		// (set) Token: 0x0600016E RID: 366 RVA: 0x00015660 File Offset: 0x00013860
		public global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler CommandHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)755499008;
				short num2 = num;
				num = (short)1823211521;
				if (num != 0)
				{
				}
				num = (short)806675810;
				short num3 = num;
				num = (short)144631138;
				switch (num3 == num)
				{
				}
				num = (short)104660992;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1654128640;
				short num2 = num;
				num = (short)798419872;
				short num3 = num;
				num = (short)629009312;
				switch (num3 == num)
				{
				}
				num = (short)1834156033;
				if (num != 0)
				{
				}
				num = (short)524419072;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00015710 File Offset: 0x00013910
		// (set) Token: 0x06000170 RID: 368 RVA: 0x000157C0 File Offset: 0x000139C0
		public global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService LocalService
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1331298304;
				short num2 = num;
				num = (short)2032755437;
				short num3 = num;
				num = (short)1466458861;
				switch (num3 == num)
				{
				}
				num = (short)1194000384;
				if (num != 0)
				{
				}
				num = (short)1500839937;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)813760512;
				short num2 = num;
				num = (short)1063817874;
				short num3 = num;
				num = (short)460362386;
				switch (num3 == num)
				{
				}
				num = (short)2094858241;
				if (num != 0)
				{
				}
				num = (short)198246400;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00015870 File Offset: 0x00013A70
		public static global::Motorola.CommonCPS.RadioManagement.Infrastructure.ServiceProxy GetInstance()
		{
			short num = (short)1462042624;
			short num2 = num;
			num = (short)1496973313;
			if (num != 0)
			{
			}
			num = (short)371950414;
			short num3 = num;
			num = (short)990348110;
			switch (num3 == num)
			{
			}
			num = (short)683606016;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.ServiceProxy result;
			if ((result = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ServiceProxy.a) == null)
			{
				result = (global::Motorola.CommonCPS.RadioManagement.Infrastructure.ServiceProxy.a = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.ServiceProxy());
			}
			return result;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00015930 File Offset: 0x00013B30
		public void UpdateCommandHandler()
		{
			short num = (short)1057161216;
			short num2 = num;
			num = (short)383452090;
			short num3 = num;
			num = (short)761267130;
			switch (num3 == num)
			{
			}
			num = (short)935264256;
			if (num != 0)
			{
			}
			num = (short)898891777;
			if (num != 0)
			{
			}
			this.a();
			global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().UpdateLocalService();
			this.LocalService = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService;
		}

		// Token: 0x06000173 RID: 371 RVA: 0x000159F8 File Offset: 0x00013BF8
		private void a()
		{
			short num = (short)1324875776;
			short num2 = num;
			num = (short)356319776;
			short num3 = num;
			num = (short)589627936;
			switch (num3 == num)
			{
			}
			num = (short)1023934465;
			if (num != 0)
			{
			}
			num = (short)1057554432;
			if (num != 0)
			{
			}
			this.CommandHandler = global::Motorola.CommonCPS.RadioManagement.CommandHandlerFactory.GetCommandHandlerInstance;
		}

		// Token: 0x040000B5 RID: 181
		private static global::Motorola.CommonCPS.RadioManagement.Infrastructure.ServiceProxy a;

		// Token: 0x040000B6 RID: 182
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler b;

		// Token: 0x040000B7 RID: 183
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService c;
	}
}
