using System;
using System.Runtime.CompilerServices;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200001F RID: 31
	public class InternalInstances : global::Motorola.CommonCPS.RadioManagement.Command.IInternalInstances
	{
		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00017944 File Offset: 0x00015B44
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x00017A0C File Offset: 0x00015C0C
		public global::Motorola.CommonCPS.RadioManagement.InteractionHelper.IInteraction Interaction
		{
			get
			{
				short num = (short)609664987;
				short num2 = num;
				num = (short)70565851;
				switch (num2 == num)
				{
				default:
				{
					num = (short)749535232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2138767360;
				if (num != 0)
				{
				}
				num = (short)1957494785;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.InteractionHelper.IInteraction result;
				if ((result = this.a) == null)
				{
					result = (this.a = global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance());
				}
				return result;
			}
			set
			{
				short num = (short)320317911;
				short num2 = num;
				num = (short)2097064407;
				switch (num2 == num)
				{
				default:
				{
					num = (short)325910528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2109079553;
				if (num != 0)
				{
				}
				num = (short)2084241408;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x00017ABC File Offset: 0x00015CBC
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x00017B88 File Offset: 0x00015D88
		public global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService LocalService
		{
			get
			{
				short num = (short)2096461149;
				short num2 = num;
				num = (short)1935111517;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1080819712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1325662208;
				if (num != 0)
				{
				}
				num = (short)763887617;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService result;
				if ((result = this.b) == null)
				{
					result = (this.b = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService);
				}
				return result;
			}
			set
			{
				short num = (short)1562013902;
				short num2 = num;
				num = (short)1414099150;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1849556992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1289289729;
				if (num != 0)
				{
				}
				num = (short)1025966080;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00017C38 File Offset: 0x00015E38
		// (set) Token: 0x060001DA RID: 474 RVA: 0x00017D04 File Offset: 0x00015F04
		public global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService AstroLocalService
		{
			get
			{
				short num = (short)502744534;
				short num2 = num;
				num = (short)1951221206;
				switch (num2 == num)
				{
				default:
				{
					num = (short)259588096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1070727169;
				if (num != 0)
				{
				}
				num = (short)1147863040;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService result;
				if ((result = this.c) == null)
				{
					result = (this.c = (global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService)global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService);
				}
				return result;
			}
			set
			{
				short num = (short)630532742;
				short num2 = num;
				num = (short)1865689734;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1984954368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1977024513;
				if (num != 0)
				{
				}
				num = (short)1563164672;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00017DB4 File Offset: 0x00015FB4
		// (set) Token: 0x060001DC RID: 476 RVA: 0x00017E80 File Offset: 0x00016080
		public global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase UiValidateService
		{
			get
			{
				short num = (short)1003740800;
				short num2 = num;
				num = (short)1453383296;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1376256000;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)88670209;
				if (num != 0)
				{
				}
				num = (short)1849491456;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase result;
				if ((result = this.d) == null)
				{
					result = (this.d = global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory.Instance.UIValidateService);
				}
				return result;
			}
			set
			{
				short num = (short)885168626;
				short num2 = num;
				num = (short)1465227762;
				switch (num2 == num)
				{
				default:
				{
					num = (short)27000832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)29556737;
				if (num != 0)
				{
				}
				num = (short)422117376;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00017F30 File Offset: 0x00016130
		// (set) Token: 0x060001DE RID: 478 RVA: 0x00017FF8 File Offset: 0x000161F8
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor ServerAccessor
		{
			get
			{
				short num = (short)1998266682;
				short num2 = num;
				num = (short)439034170;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1338966016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1757937665;
				if (num != 0)
				{
				}
				num = (short)1129054208;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor result;
				if ((result = this.e) == null)
				{
					result = (this.e = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false));
				}
				return result;
			}
			set
			{
				short num = (short)1520962039;
				short num2 = num;
				num = (short)701106679;
				switch (num2 == num)
				{
				default:
				{
					num = (short)946995200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)314769409;
				if (num != 0)
				{
				}
				num = (short)280756224;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000180A8 File Offset: 0x000162A8
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x00018170 File Offset: 0x00016370
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer ServiceContainer
		{
			get
			{
				short num = (short)1548103201;
				short num2 = num;
				num = (short)23211553;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1514930176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2115174400;
				if (num != 0)
				{
				}
				num = (short)1930821633;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer result;
				if ((result = this.f) == null)
				{
					result = (this.f = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance);
				}
				return result;
			}
			set
			{
				short num = (short)1581563769;
				short num2 = num;
				num = (short)1998831481;
				switch (num2 == num)
				{
				default:
				{
					num = (short)990314496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1789132801;
				if (num != 0)
				{
				}
				num = (short)212205568;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x00018220 File Offset: 0x00016420
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x000182E4 File Offset: 0x000164E4
		public global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioFeatureOperation RadioFeatureOperation
		{
			get
			{
				short num = (short)665246959;
				short num2 = num;
				num = (short)1475402991;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1222705152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)645529601;
				if (num != 0)
				{
				}
				num = (short)1368915968;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioFeatureOperation result;
				if ((result = this.g) == null)
				{
					result = (this.g = global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance());
				}
				return result;
			}
			set
			{
				short num = (short)350482669;
				short num2 = num;
				num = (short)994504941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)122748928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1993932801;
				if (num != 0)
				{
				}
				num = (short)1492713472;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x00018394 File Offset: 0x00016594
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x00018444 File Offset: 0x00016644
		public global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer PerformanceMeasurer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)411946624;
				short num2 = num;
				num = (short)1113575040;
				switch (num2 == num)
				{
				default:
				{
					num = (short)636551168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1751973889;
				if (num != 0)
				{
				}
				num = (short)1097465856;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1458253480;
				short num2 = num;
				num = (short)1709256360;
				switch (num2 == num)
				{
				default:
				{
					num = (short)181927936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)424935425;
				if (num != 0)
				{
				}
				num = (short)451149824;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x04000020 RID: 32
		private global::Motorola.CommonCPS.RadioManagement.InteractionHelper.IInteraction a;

		// Token: 0x04000021 RID: 33
		private global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService b;

		// Token: 0x04000022 RID: 34
		private global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService c;

		// Token: 0x04000023 RID: 35
		private global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase d;

		// Token: 0x04000024 RID: 36
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor e;

		// Token: 0x04000025 RID: 37
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer f;

		// Token: 0x04000026 RID: 38
		private global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioFeatureOperation g;

		// Token: 0x04000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer h;
	}
}
