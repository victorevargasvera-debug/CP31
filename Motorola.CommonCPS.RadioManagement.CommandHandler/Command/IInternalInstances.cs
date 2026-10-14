using System;
using Motorola.Common.LogUtility.PerformanceMeasurement;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200001E RID: 30
	public interface IInternalInstances
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060001C5 RID: 453
		// (set) Token: 0x060001C6 RID: 454
		global::Motorola.CommonCPS.RadioManagement.InteractionHelper.IInteraction Interaction { get; set; }

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060001C7 RID: 455
		// (set) Token: 0x060001C8 RID: 456
		global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService LocalService { get; set; }

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060001C9 RID: 457
		// (set) Token: 0x060001CA RID: 458
		global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService AstroLocalService { get; set; }

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060001CB RID: 459
		// (set) Token: 0x060001CC RID: 460
		global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase UiValidateService { get; set; }

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060001CD RID: 461
		// (set) Token: 0x060001CE RID: 462
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor ServerAccessor { get; set; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060001CF RID: 463
		// (set) Token: 0x060001D0 RID: 464
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer ServiceContainer { get; set; }

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060001D1 RID: 465
		// (set) Token: 0x060001D2 RID: 466
		global::Motorola.CommonCPS.RadioManagement.SharedServices.IRadioFeatureOperation RadioFeatureOperation { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060001D3 RID: 467
		// (set) Token: 0x060001D4 RID: 468
		global::Motorola.Common.LogUtility.PerformanceMeasurement.IPerformanceMeasurer PerformanceMeasurer { get; set; }
	}
}
