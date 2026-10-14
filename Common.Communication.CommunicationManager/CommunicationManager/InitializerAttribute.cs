using System;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000030 RID: 48
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple = true)]
	public sealed class InitializerAttribute : global::System.Attribute
	{
		// Token: 0x06000110 RID: 272 RVA: 0x00016508 File Offset: 0x00014708
		public InitializerAttribute(global::Motorola.Common.Communication.CommonUtil.ConnectionType connectionType, global::Motorola.Common.Communication.CommonUtil.ProductFamily family, global::Motorola.Common.Communication.CommonUtil.RadioStorage storage, global::Motorola.Common.Communication.CommonUtil.RadioOperation operation)
		{
			this.a = connectionType;
			this.b = family;
			this.c = operation;
			this.d = storage;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00016538 File Offset: 0x00014738
		public global::Motorola.Common.Communication.CommonUtil.ConnectionType ConnectionType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)719472966;
				short num2 = num;
				num = (short)778783046;
				switch (num2 == num)
				{
				}
				num = (short)1038352385;
				if (num != 0)
				{
				}
				num = (short)854786048;
				short num3 = num;
				num = (short)1121452032;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000112 RID: 274 RVA: 0x000165E8 File Offset: 0x000147E8
		public global::Motorola.Common.Communication.CommonUtil.ProductFamily Family
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)526524539;
				short num2 = num;
				num = (short)85794939;
				switch (num2 == num)
				{
				}
				num = (short)669450240;
				if (num != 0)
				{
				}
				num = (short)519962624;
				short num3 = num;
				num = (short)848691201;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000113 RID: 275 RVA: 0x00016698 File Offset: 0x00014898
		public global::Motorola.Common.Communication.CommonUtil.RadioOperation Operation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1020808068;
				short num2 = num;
				num = (short)1483426692;
				switch (num2 == num)
				{
				}
				num = (short)432930817;
				if (num != 0)
				{
				}
				num = (short)1312030720;
				short num3 = num;
				num = (short)51249152;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000114 RID: 276 RVA: 0x00016748 File Offset: 0x00014948
		public global::Motorola.Common.Communication.CommonUtil.RadioStorage Storage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)847892774;
				short num2 = num;
				num = (short)1351799078;
				switch (num2 == num)
				{
				}
				num = (short)453115904;
				if (num != 0)
				{
				}
				num = (short)545062912;
				short num3 = num;
				num = (short)1551630337;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x000167F8 File Offset: 0x000149F8
		public override bool Match(object obj)
		{
			int num;
			global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute initializerAttribute;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return false;
					case 1:
						return false;
					case 2:
						if (!this.Family.HasFlag(initializerAttribute.Family))
						{
							num2 = (short)427294721;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1886126084;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						return false;
					case 4:
						if (!this.Operation.HasFlag(initializerAttribute.Operation))
						{
							num2 = (short)1277100035;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1287585799;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (!this.ConnectionType.HasFlag(initializerAttribute.ConnectionType))
						{
							num2 = (short)1496514569;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1101529090;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (initializerAttribute == null)
						{
							num2 = (short)1246232576;
							short num3 = num2;
							num2 = (short)51707904;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1166016517;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						num2 = (short)1462042625;
						if (num2 != 0)
						{
						}
						if (!this.Storage.HasFlag(initializerAttribute.Storage))
						{
							num2 = (short)941031432;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 8:
						goto IL_16C;
					case 9:
						return false;
					}
					goto IL_38;
				}
				return false;
				IL_16C:
				num2 = (short)543332511;
				short num4 = num2;
				num2 = (short)114399391;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3F;
				default:
					num2 = (short)1072365568;
					if (num2 != 0)
					{
					}
					return false;
				}
				return false;
			}
			}
			IL_38:
			initializerAttribute = (obj as global::Motorola.Common.Communication.CommunicationManager.InitializerAttribute);
			IL_3F:
			num2 = (short)720109574;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400003F RID: 63
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.Common.Communication.CommonUtil.ConnectionType a;

		// Token: 0x04000040 RID: 64
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.Common.Communication.CommonUtil.ProductFamily b;

		// Token: 0x04000041 RID: 65
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.Common.Communication.CommonUtil.RadioOperation c;

		// Token: 0x04000042 RID: 66
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.Common.Communication.CommonUtil.RadioStorage d;
	}
}
