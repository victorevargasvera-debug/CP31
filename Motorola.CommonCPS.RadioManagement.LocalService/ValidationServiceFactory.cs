using System;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.SharedServices;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000058 RID: 88
	public class ValidationServiceFactory
	{
		// Token: 0x0600032C RID: 812 RVA: 0x0004F1B4 File Offset: 0x0004D3B4
		private ValidationServiceFactory() : this(global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance)
		{
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0004F1CC File Offset: 0x0004D3CC
		private ValidationServiceFactory(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer A_0)
		{
			this.UIValidateService = global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROUIValidationService.GetInstance(A_0);
			this.RadioValidationService = new global::Motorola.CommonCPS.RadioManagement.LocalService.ASTRORadioValidationService(A_0);
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0004F1F8 File Offset: 0x0004D3F8
		public static global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory Instance
		{
			get
			{
				short num = (short)132513792;
				short num2 = num;
				num = (short)1346043491;
				short num3 = num;
				num = (short)1198194275;
				switch (num3 == num)
				{
				}
				num = (short)1436286976;
				if (num != 0)
				{
				}
				num = (short)1649082369;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory();
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0004F2A4 File Offset: 0x0004D4A4
		public static global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory Create(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer serviceContainer)
		{
			short num = (short)1248591872;
			short num2 = num;
			num = (short)992027870;
			short num3 = num;
			num = (short)176825566;
			switch (num3 == num)
			{
			}
			num = (short)1250689025;
			if (num != 0)
			{
			}
			num = (short)562561024;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.ValidationServiceFactory(serviceContainer);
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0004F358 File Offset: 0x0004D558
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0004F408 File Offset: 0x0004D608
		public global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase UIValidateService
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1222836224;
				short num2 = num;
				num = (short)1113024209;
				short num3 = num;
				num = (short)1187014353;
				switch (num3 == num)
				{
				}
				num = (short)524419073;
				if (num != 0)
				{
				}
				num = (short)927334400;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)966197248;
				short num2 = num;
				num = (short)191064454;
				short num3 = num;
				num = (short)155085190;
				switch (num3 == num)
				{
				}
				num = (short)654901249;
				if (num != 0)
				{
				}
				num = (short)1461059584;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0004F4B8 File Offset: 0x0004D6B8
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0004F564 File Offset: 0x0004D764
		public global::Motorola.CommonCPS.RadioManagement.LocalService.IRadioValidationService RadioValidationService
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1652883456;
				short num2 = num;
				num = (short)1993574996;
				short num3 = num;
				num = (short)884247124;
				switch (num3 == num)
				{
				}
				num = (short)2100428801;
				if (num != 0)
				{
				}
				num = (short)1397161984;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1093474169;
				short num2 = num;
				num = (short)732239737;
				switch (num2 == num)
				{
				}
				num = (short)2028994560;
				if (num != 0)
				{
				}
				num = (short)858914817;
				if (num != 0)
				{
				}
				num = (short)492896256;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x0400008A RID: 138
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase a;

		// Token: 0x0400008B RID: 139
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.LocalService.IRadioValidationService b;
	}
}
