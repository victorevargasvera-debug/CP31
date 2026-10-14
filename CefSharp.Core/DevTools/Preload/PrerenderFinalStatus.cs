using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x020000A5 RID: 165
	public enum PrerenderFinalStatus
	{
		// Token: 0x04000260 RID: 608
		[global::System.Runtime.Serialization.EnumMember(Value = "Activated")]
		Activated,
		// Token: 0x04000261 RID: 609
		[global::System.Runtime.Serialization.EnumMember(Value = "Destroyed")]
		Destroyed,
		// Token: 0x04000262 RID: 610
		[global::System.Runtime.Serialization.EnumMember(Value = "LowEndDevice")]
		LowEndDevice,
		// Token: 0x04000263 RID: 611
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidSchemeRedirect")]
		InvalidSchemeRedirect,
		// Token: 0x04000264 RID: 612
		[global::System.Runtime.Serialization.EnumMember(Value = "InvalidSchemeNavigation")]
		InvalidSchemeNavigation,
		// Token: 0x04000265 RID: 613
		[global::System.Runtime.Serialization.EnumMember(Value = "InProgressNavigation")]
		InProgressNavigation,
		// Token: 0x04000266 RID: 614
		[global::System.Runtime.Serialization.EnumMember(Value = "NavigationRequestBlockedByCsp")]
		NavigationRequestBlockedByCsp,
		// Token: 0x04000267 RID: 615
		[global::System.Runtime.Serialization.EnumMember(Value = "MainFrameNavigation")]
		MainFrameNavigation,
		// Token: 0x04000268 RID: 616
		[global::System.Runtime.Serialization.EnumMember(Value = "MojoBinderPolicy")]
		MojoBinderPolicy,
		// Token: 0x04000269 RID: 617
		[global::System.Runtime.Serialization.EnumMember(Value = "RendererProcessCrashed")]
		RendererProcessCrashed,
		// Token: 0x0400026A RID: 618
		[global::System.Runtime.Serialization.EnumMember(Value = "RendererProcessKilled")]
		RendererProcessKilled,
		// Token: 0x0400026B RID: 619
		[global::System.Runtime.Serialization.EnumMember(Value = "Download")]
		Download,
		// Token: 0x0400026C RID: 620
		[global::System.Runtime.Serialization.EnumMember(Value = "TriggerDestroyed")]
		TriggerDestroyed,
		// Token: 0x0400026D RID: 621
		[global::System.Runtime.Serialization.EnumMember(Value = "NavigationNotCommitted")]
		NavigationNotCommitted,
		// Token: 0x0400026E RID: 622
		[global::System.Runtime.Serialization.EnumMember(Value = "NavigationBadHttpStatus")]
		NavigationBadHttpStatus,
		// Token: 0x0400026F RID: 623
		[global::System.Runtime.Serialization.EnumMember(Value = "ClientCertRequested")]
		ClientCertRequested,
		// Token: 0x04000270 RID: 624
		[global::System.Runtime.Serialization.EnumMember(Value = "NavigationRequestNetworkError")]
		NavigationRequestNetworkError,
		// Token: 0x04000271 RID: 625
		[global::System.Runtime.Serialization.EnumMember(Value = "MaxNumOfRunningPrerendersExceeded")]
		MaxNumOfRunningPrerendersExceeded,
		// Token: 0x04000272 RID: 626
		[global::System.Runtime.Serialization.EnumMember(Value = "CancelAllHostsForTesting")]
		CancelAllHostsForTesting,
		// Token: 0x04000273 RID: 627
		[global::System.Runtime.Serialization.EnumMember(Value = "DidFailLoad")]
		DidFailLoad,
		// Token: 0x04000274 RID: 628
		[global::System.Runtime.Serialization.EnumMember(Value = "Stop")]
		Stop,
		// Token: 0x04000275 RID: 629
		[global::System.Runtime.Serialization.EnumMember(Value = "SslCertificateError")]
		SslCertificateError,
		// Token: 0x04000276 RID: 630
		[global::System.Runtime.Serialization.EnumMember(Value = "LoginAuthRequested")]
		LoginAuthRequested,
		// Token: 0x04000277 RID: 631
		[global::System.Runtime.Serialization.EnumMember(Value = "UaChangeRequiresReload")]
		UaChangeRequiresReload,
		// Token: 0x04000278 RID: 632
		[global::System.Runtime.Serialization.EnumMember(Value = "BlockedByClient")]
		BlockedByClient,
		// Token: 0x04000279 RID: 633
		[global::System.Runtime.Serialization.EnumMember(Value = "AudioOutputDeviceRequested")]
		AudioOutputDeviceRequested,
		// Token: 0x0400027A RID: 634
		[global::System.Runtime.Serialization.EnumMember(Value = "MixedContent")]
		MixedContent,
		// Token: 0x0400027B RID: 635
		[global::System.Runtime.Serialization.EnumMember(Value = "TriggerBackgrounded")]
		TriggerBackgrounded,
		// Token: 0x0400027C RID: 636
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderTriggeredAndCrossOriginRedirected")]
		EmbedderTriggeredAndCrossOriginRedirected,
		// Token: 0x0400027D RID: 637
		[global::System.Runtime.Serialization.EnumMember(Value = "MemoryLimitExceeded")]
		MemoryLimitExceeded,
		// Token: 0x0400027E RID: 638
		[global::System.Runtime.Serialization.EnumMember(Value = "FailToGetMemoryUsage")]
		FailToGetMemoryUsage,
		// Token: 0x0400027F RID: 639
		[global::System.Runtime.Serialization.EnumMember(Value = "DataSaverEnabled")]
		DataSaverEnabled,
		// Token: 0x04000280 RID: 640
		[global::System.Runtime.Serialization.EnumMember(Value = "HasEffectiveUrl")]
		HasEffectiveUrl,
		// Token: 0x04000281 RID: 641
		[global::System.Runtime.Serialization.EnumMember(Value = "ActivatedBeforeStarted")]
		ActivatedBeforeStarted,
		// Token: 0x04000282 RID: 642
		[global::System.Runtime.Serialization.EnumMember(Value = "InactivePageRestriction")]
		InactivePageRestriction,
		// Token: 0x04000283 RID: 643
		[global::System.Runtime.Serialization.EnumMember(Value = "StartFailed")]
		StartFailed,
		// Token: 0x04000284 RID: 644
		[global::System.Runtime.Serialization.EnumMember(Value = "TimeoutBackgrounded")]
		TimeoutBackgrounded,
		// Token: 0x04000285 RID: 645
		[global::System.Runtime.Serialization.EnumMember(Value = "CrossSiteRedirectInInitialNavigation")]
		CrossSiteRedirectInInitialNavigation,
		// Token: 0x04000286 RID: 646
		[global::System.Runtime.Serialization.EnumMember(Value = "CrossSiteNavigationInInitialNavigation")]
		CrossSiteNavigationInInitialNavigation,
		// Token: 0x04000287 RID: 647
		[global::System.Runtime.Serialization.EnumMember(Value = "SameSiteCrossOriginRedirectNotOptInInInitialNavigation")]
		SameSiteCrossOriginRedirectNotOptInInInitialNavigation,
		// Token: 0x04000288 RID: 648
		[global::System.Runtime.Serialization.EnumMember(Value = "SameSiteCrossOriginNavigationNotOptInInInitialNavigation")]
		SameSiteCrossOriginNavigationNotOptInInInitialNavigation,
		// Token: 0x04000289 RID: 649
		[global::System.Runtime.Serialization.EnumMember(Value = "ActivationNavigationParameterMismatch")]
		ActivationNavigationParameterMismatch,
		// Token: 0x0400028A RID: 650
		[global::System.Runtime.Serialization.EnumMember(Value = "ActivatedInBackground")]
		ActivatedInBackground,
		// Token: 0x0400028B RID: 651
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderHostDisallowed")]
		EmbedderHostDisallowed,
		// Token: 0x0400028C RID: 652
		[global::System.Runtime.Serialization.EnumMember(Value = "ActivationNavigationDestroyedBeforeSuccess")]
		ActivationNavigationDestroyedBeforeSuccess,
		// Token: 0x0400028D RID: 653
		[global::System.Runtime.Serialization.EnumMember(Value = "TabClosedByUserGesture")]
		TabClosedByUserGesture,
		// Token: 0x0400028E RID: 654
		[global::System.Runtime.Serialization.EnumMember(Value = "TabClosedWithoutUserGesture")]
		TabClosedWithoutUserGesture,
		// Token: 0x0400028F RID: 655
		[global::System.Runtime.Serialization.EnumMember(Value = "PrimaryMainFrameRendererProcessCrashed")]
		PrimaryMainFrameRendererProcessCrashed,
		// Token: 0x04000290 RID: 656
		[global::System.Runtime.Serialization.EnumMember(Value = "PrimaryMainFrameRendererProcessKilled")]
		PrimaryMainFrameRendererProcessKilled,
		// Token: 0x04000291 RID: 657
		[global::System.Runtime.Serialization.EnumMember(Value = "ActivationFramePolicyNotCompatible")]
		ActivationFramePolicyNotCompatible,
		// Token: 0x04000292 RID: 658
		[global::System.Runtime.Serialization.EnumMember(Value = "PreloadingDisabled")]
		PreloadingDisabled,
		// Token: 0x04000293 RID: 659
		[global::System.Runtime.Serialization.EnumMember(Value = "BatterySaverEnabled")]
		BatterySaverEnabled,
		// Token: 0x04000294 RID: 660
		[global::System.Runtime.Serialization.EnumMember(Value = "ActivatedDuringMainFrameNavigation")]
		ActivatedDuringMainFrameNavigation,
		// Token: 0x04000295 RID: 661
		[global::System.Runtime.Serialization.EnumMember(Value = "PreloadingUnsupportedByWebContents")]
		PreloadingUnsupportedByWebContents,
		// Token: 0x04000296 RID: 662
		[global::System.Runtime.Serialization.EnumMember(Value = "CrossSiteRedirectInMainFrameNavigation")]
		CrossSiteRedirectInMainFrameNavigation,
		// Token: 0x04000297 RID: 663
		[global::System.Runtime.Serialization.EnumMember(Value = "CrossSiteNavigationInMainFrameNavigation")]
		CrossSiteNavigationInMainFrameNavigation,
		// Token: 0x04000298 RID: 664
		[global::System.Runtime.Serialization.EnumMember(Value = "SameSiteCrossOriginRedirectNotOptInInMainFrameNavigation")]
		SameSiteCrossOriginRedirectNotOptInInMainFrameNavigation,
		// Token: 0x04000299 RID: 665
		[global::System.Runtime.Serialization.EnumMember(Value = "SameSiteCrossOriginNavigationNotOptInInMainFrameNavigation")]
		SameSiteCrossOriginNavigationNotOptInInMainFrameNavigation,
		// Token: 0x0400029A RID: 666
		[global::System.Runtime.Serialization.EnumMember(Value = "MemoryPressureOnTrigger")]
		MemoryPressureOnTrigger,
		// Token: 0x0400029B RID: 667
		[global::System.Runtime.Serialization.EnumMember(Value = "MemoryPressureAfterTriggered")]
		MemoryPressureAfterTriggered
	}
}
