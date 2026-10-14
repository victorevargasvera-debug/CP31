using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200018A RID: 394
	public enum BackForwardCacheNotRestoredReason
	{
		// Token: 0x0400060C RID: 1548
		[global::System.Runtime.Serialization.EnumMember(Value = "NotPrimaryMainFrame")]
		NotPrimaryMainFrame,
		// Token: 0x0400060D RID: 1549
		[global::System.Runtime.Serialization.EnumMember(Value = "BackForwardCacheDisabled")]
		BackForwardCacheDisabled,
		// Token: 0x0400060E RID: 1550
		[global::System.Runtime.Serialization.EnumMember(Value = "RelatedActiveContentsExist")]
		RelatedActiveContentsExist,
		// Token: 0x0400060F RID: 1551
		[global::System.Runtime.Serialization.EnumMember(Value = "HTTPStatusNotOK")]
		HTTPStatusNotOK,
		// Token: 0x04000610 RID: 1552
		[global::System.Runtime.Serialization.EnumMember(Value = "SchemeNotHTTPOrHTTPS")]
		SchemeNotHTTPOrHTTPS,
		// Token: 0x04000611 RID: 1553
		[global::System.Runtime.Serialization.EnumMember(Value = "Loading")]
		Loading,
		// Token: 0x04000612 RID: 1554
		[global::System.Runtime.Serialization.EnumMember(Value = "WasGrantedMediaAccess")]
		WasGrantedMediaAccess,
		// Token: 0x04000613 RID: 1555
		[global::System.Runtime.Serialization.EnumMember(Value = "DisableForRenderFrameHostCalled")]
		DisableForRenderFrameHostCalled,
		// Token: 0x04000614 RID: 1556
		[global::System.Runtime.Serialization.EnumMember(Value = "DomainNotAllowed")]
		DomainNotAllowed,
		// Token: 0x04000615 RID: 1557
		[global::System.Runtime.Serialization.EnumMember(Value = "HTTPMethodNotGET")]
		HTTPMethodNotGET,
		// Token: 0x04000616 RID: 1558
		[global::System.Runtime.Serialization.EnumMember(Value = "SubframeIsNavigating")]
		SubframeIsNavigating,
		// Token: 0x04000617 RID: 1559
		[global::System.Runtime.Serialization.EnumMember(Value = "Timeout")]
		Timeout,
		// Token: 0x04000618 RID: 1560
		[global::System.Runtime.Serialization.EnumMember(Value = "CacheLimit")]
		CacheLimit,
		// Token: 0x04000619 RID: 1561
		[global::System.Runtime.Serialization.EnumMember(Value = "JavaScriptExecution")]
		JavaScriptExecution,
		// Token: 0x0400061A RID: 1562
		[global::System.Runtime.Serialization.EnumMember(Value = "RendererProcessKilled")]
		RendererProcessKilled,
		// Token: 0x0400061B RID: 1563
		[global::System.Runtime.Serialization.EnumMember(Value = "RendererProcessCrashed")]
		RendererProcessCrashed,
		// Token: 0x0400061C RID: 1564
		[global::System.Runtime.Serialization.EnumMember(Value = "SchedulerTrackedFeatureUsed")]
		SchedulerTrackedFeatureUsed,
		// Token: 0x0400061D RID: 1565
		[global::System.Runtime.Serialization.EnumMember(Value = "ConflictingBrowsingInstance")]
		ConflictingBrowsingInstance,
		// Token: 0x0400061E RID: 1566
		[global::System.Runtime.Serialization.EnumMember(Value = "CacheFlushed")]
		CacheFlushed,
		// Token: 0x0400061F RID: 1567
		[global::System.Runtime.Serialization.EnumMember(Value = "ServiceWorkerVersionActivation")]
		ServiceWorkerVersionActivation,
		// Token: 0x04000620 RID: 1568
		[global::System.Runtime.Serialization.EnumMember(Value = "SessionRestored")]
		SessionRestored,
		// Token: 0x04000621 RID: 1569
		[global::System.Runtime.Serialization.EnumMember(Value = "ServiceWorkerPostMessage")]
		ServiceWorkerPostMessage,
		// Token: 0x04000622 RID: 1570
		[global::System.Runtime.Serialization.EnumMember(Value = "EnteredBackForwardCacheBeforeServiceWorkerHostAdded")]
		EnteredBackForwardCacheBeforeServiceWorkerHostAdded,
		// Token: 0x04000623 RID: 1571
		[global::System.Runtime.Serialization.EnumMember(Value = "RenderFrameHostReused_SameSite")]
		RenderFrameHostReusedSameSite,
		// Token: 0x04000624 RID: 1572
		[global::System.Runtime.Serialization.EnumMember(Value = "RenderFrameHostReused_CrossSite")]
		RenderFrameHostReusedCrossSite,
		// Token: 0x04000625 RID: 1573
		[global::System.Runtime.Serialization.EnumMember(Value = "ServiceWorkerClaim")]
		ServiceWorkerClaim,
		// Token: 0x04000626 RID: 1574
		[global::System.Runtime.Serialization.EnumMember(Value = "IgnoreEventAndEvict")]
		IgnoreEventAndEvict,
		// Token: 0x04000627 RID: 1575
		[global::System.Runtime.Serialization.EnumMember(Value = "HaveInnerContents")]
		HaveInnerContents,
		// Token: 0x04000628 RID: 1576
		[global::System.Runtime.Serialization.EnumMember(Value = "TimeoutPuttingInCache")]
		TimeoutPuttingInCache,
		// Token: 0x04000629 RID: 1577
		[global::System.Runtime.Serialization.EnumMember(Value = "BackForwardCacheDisabledByLowMemory")]
		BackForwardCacheDisabledByLowMemory,
		// Token: 0x0400062A RID: 1578
		[global::System.Runtime.Serialization.EnumMember(Value = "BackForwardCacheDisabledByCommandLine")]
		BackForwardCacheDisabledByCommandLine,
		// Token: 0x0400062B RID: 1579
		[global::System.Runtime.Serialization.EnumMember(Value = "NetworkRequestDatapipeDrainedAsBytesConsumer")]
		NetworkRequestDatapipeDrainedAsBytesConsumer,
		// Token: 0x0400062C RID: 1580
		[global::System.Runtime.Serialization.EnumMember(Value = "NetworkRequestRedirected")]
		NetworkRequestRedirected,
		// Token: 0x0400062D RID: 1581
		[global::System.Runtime.Serialization.EnumMember(Value = "NetworkRequestTimeout")]
		NetworkRequestTimeout,
		// Token: 0x0400062E RID: 1582
		[global::System.Runtime.Serialization.EnumMember(Value = "NetworkExceedsBufferLimit")]
		NetworkExceedsBufferLimit,
		// Token: 0x0400062F RID: 1583
		[global::System.Runtime.Serialization.EnumMember(Value = "NavigationCancelledWhileRestoring")]
		NavigationCancelledWhileRestoring,
		// Token: 0x04000630 RID: 1584
		[global::System.Runtime.Serialization.EnumMember(Value = "NotMostRecentNavigationEntry")]
		NotMostRecentNavigationEntry,
		// Token: 0x04000631 RID: 1585
		[global::System.Runtime.Serialization.EnumMember(Value = "BackForwardCacheDisabledForPrerender")]
		BackForwardCacheDisabledForPrerender,
		// Token: 0x04000632 RID: 1586
		[global::System.Runtime.Serialization.EnumMember(Value = "UserAgentOverrideDiffers")]
		UserAgentOverrideDiffers,
		// Token: 0x04000633 RID: 1587
		[global::System.Runtime.Serialization.EnumMember(Value = "ForegroundCacheLimit")]
		ForegroundCacheLimit,
		// Token: 0x04000634 RID: 1588
		[global::System.Runtime.Serialization.EnumMember(Value = "BrowsingInstanceNotSwapped")]
		BrowsingInstanceNotSwapped,
		// Token: 0x04000635 RID: 1589
		[global::System.Runtime.Serialization.EnumMember(Value = "BackForwardCacheDisabledForDelegate")]
		BackForwardCacheDisabledForDelegate,
		// Token: 0x04000636 RID: 1590
		[global::System.Runtime.Serialization.EnumMember(Value = "UnloadHandlerExistsInMainFrame")]
		UnloadHandlerExistsInMainFrame,
		// Token: 0x04000637 RID: 1591
		[global::System.Runtime.Serialization.EnumMember(Value = "UnloadHandlerExistsInSubFrame")]
		UnloadHandlerExistsInSubFrame,
		// Token: 0x04000638 RID: 1592
		[global::System.Runtime.Serialization.EnumMember(Value = "ServiceWorkerUnregistration")]
		ServiceWorkerUnregistration,
		// Token: 0x04000639 RID: 1593
		[global::System.Runtime.Serialization.EnumMember(Value = "CacheControlNoStore")]
		CacheControlNoStore,
		// Token: 0x0400063A RID: 1594
		[global::System.Runtime.Serialization.EnumMember(Value = "CacheControlNoStoreCookieModified")]
		CacheControlNoStoreCookieModified,
		// Token: 0x0400063B RID: 1595
		[global::System.Runtime.Serialization.EnumMember(Value = "CacheControlNoStoreHTTPOnlyCookieModified")]
		CacheControlNoStoreHTTPOnlyCookieModified,
		// Token: 0x0400063C RID: 1596
		[global::System.Runtime.Serialization.EnumMember(Value = "NoResponseHead")]
		NoResponseHead,
		// Token: 0x0400063D RID: 1597
		[global::System.Runtime.Serialization.EnumMember(Value = "Unknown")]
		Unknown,
		// Token: 0x0400063E RID: 1598
		[global::System.Runtime.Serialization.EnumMember(Value = "ActivationNavigationsDisallowedForBug1234857")]
		ActivationNavigationsDisallowedForBug1234857,
		// Token: 0x0400063F RID: 1599
		[global::System.Runtime.Serialization.EnumMember(Value = "ErrorDocument")]
		ErrorDocument,
		// Token: 0x04000640 RID: 1600
		[global::System.Runtime.Serialization.EnumMember(Value = "FencedFramesEmbedder")]
		FencedFramesEmbedder,
		// Token: 0x04000641 RID: 1601
		[global::System.Runtime.Serialization.EnumMember(Value = "WebSocket")]
		WebSocket,
		// Token: 0x04000642 RID: 1602
		[global::System.Runtime.Serialization.EnumMember(Value = "WebTransport")]
		WebTransport,
		// Token: 0x04000643 RID: 1603
		[global::System.Runtime.Serialization.EnumMember(Value = "WebRTC")]
		WebRTC,
		// Token: 0x04000644 RID: 1604
		[global::System.Runtime.Serialization.EnumMember(Value = "MainResourceHasCacheControlNoStore")]
		MainResourceHasCacheControlNoStore,
		// Token: 0x04000645 RID: 1605
		[global::System.Runtime.Serialization.EnumMember(Value = "MainResourceHasCacheControlNoCache")]
		MainResourceHasCacheControlNoCache,
		// Token: 0x04000646 RID: 1606
		[global::System.Runtime.Serialization.EnumMember(Value = "SubresourceHasCacheControlNoStore")]
		SubresourceHasCacheControlNoStore,
		// Token: 0x04000647 RID: 1607
		[global::System.Runtime.Serialization.EnumMember(Value = "SubresourceHasCacheControlNoCache")]
		SubresourceHasCacheControlNoCache,
		// Token: 0x04000648 RID: 1608
		[global::System.Runtime.Serialization.EnumMember(Value = "ContainsPlugins")]
		ContainsPlugins,
		// Token: 0x04000649 RID: 1609
		[global::System.Runtime.Serialization.EnumMember(Value = "DocumentLoaded")]
		DocumentLoaded,
		// Token: 0x0400064A RID: 1610
		[global::System.Runtime.Serialization.EnumMember(Value = "DedicatedWorkerOrWorklet")]
		DedicatedWorkerOrWorklet,
		// Token: 0x0400064B RID: 1611
		[global::System.Runtime.Serialization.EnumMember(Value = "OutstandingNetworkRequestOthers")]
		OutstandingNetworkRequestOthers,
		// Token: 0x0400064C RID: 1612
		[global::System.Runtime.Serialization.EnumMember(Value = "OutstandingIndexedDBTransaction")]
		OutstandingIndexedDBTransaction,
		// Token: 0x0400064D RID: 1613
		[global::System.Runtime.Serialization.EnumMember(Value = "RequestedMIDIPermission")]
		RequestedMIDIPermission,
		// Token: 0x0400064E RID: 1614
		[global::System.Runtime.Serialization.EnumMember(Value = "RequestedAudioCapturePermission")]
		RequestedAudioCapturePermission,
		// Token: 0x0400064F RID: 1615
		[global::System.Runtime.Serialization.EnumMember(Value = "RequestedVideoCapturePermission")]
		RequestedVideoCapturePermission,
		// Token: 0x04000650 RID: 1616
		[global::System.Runtime.Serialization.EnumMember(Value = "RequestedBackForwardCacheBlockedSensors")]
		RequestedBackForwardCacheBlockedSensors,
		// Token: 0x04000651 RID: 1617
		[global::System.Runtime.Serialization.EnumMember(Value = "RequestedBackgroundWorkPermission")]
		RequestedBackgroundWorkPermission,
		// Token: 0x04000652 RID: 1618
		[global::System.Runtime.Serialization.EnumMember(Value = "BroadcastChannel")]
		BroadcastChannel,
		// Token: 0x04000653 RID: 1619
		[global::System.Runtime.Serialization.EnumMember(Value = "IndexedDBConnection")]
		IndexedDBConnection,
		// Token: 0x04000654 RID: 1620
		[global::System.Runtime.Serialization.EnumMember(Value = "WebXR")]
		WebXR,
		// Token: 0x04000655 RID: 1621
		[global::System.Runtime.Serialization.EnumMember(Value = "SharedWorker")]
		SharedWorker,
		// Token: 0x04000656 RID: 1622
		[global::System.Runtime.Serialization.EnumMember(Value = "WebLocks")]
		WebLocks,
		// Token: 0x04000657 RID: 1623
		[global::System.Runtime.Serialization.EnumMember(Value = "WebHID")]
		WebHID,
		// Token: 0x04000658 RID: 1624
		[global::System.Runtime.Serialization.EnumMember(Value = "WebShare")]
		WebShare,
		// Token: 0x04000659 RID: 1625
		[global::System.Runtime.Serialization.EnumMember(Value = "RequestedStorageAccessGrant")]
		RequestedStorageAccessGrant,
		// Token: 0x0400065A RID: 1626
		[global::System.Runtime.Serialization.EnumMember(Value = "WebNfc")]
		WebNfc,
		// Token: 0x0400065B RID: 1627
		[global::System.Runtime.Serialization.EnumMember(Value = "OutstandingNetworkRequestFetch")]
		OutstandingNetworkRequestFetch,
		// Token: 0x0400065C RID: 1628
		[global::System.Runtime.Serialization.EnumMember(Value = "OutstandingNetworkRequestXHR")]
		OutstandingNetworkRequestXHR,
		// Token: 0x0400065D RID: 1629
		[global::System.Runtime.Serialization.EnumMember(Value = "AppBanner")]
		AppBanner,
		// Token: 0x0400065E RID: 1630
		[global::System.Runtime.Serialization.EnumMember(Value = "Printing")]
		Printing,
		// Token: 0x0400065F RID: 1631
		[global::System.Runtime.Serialization.EnumMember(Value = "WebDatabase")]
		WebDatabase,
		// Token: 0x04000660 RID: 1632
		[global::System.Runtime.Serialization.EnumMember(Value = "PictureInPicture")]
		PictureInPicture,
		// Token: 0x04000661 RID: 1633
		[global::System.Runtime.Serialization.EnumMember(Value = "Portal")]
		Portal,
		// Token: 0x04000662 RID: 1634
		[global::System.Runtime.Serialization.EnumMember(Value = "SpeechRecognizer")]
		SpeechRecognizer,
		// Token: 0x04000663 RID: 1635
		[global::System.Runtime.Serialization.EnumMember(Value = "IdleManager")]
		IdleManager,
		// Token: 0x04000664 RID: 1636
		[global::System.Runtime.Serialization.EnumMember(Value = "PaymentManager")]
		PaymentManager,
		// Token: 0x04000665 RID: 1637
		[global::System.Runtime.Serialization.EnumMember(Value = "SpeechSynthesis")]
		SpeechSynthesis,
		// Token: 0x04000666 RID: 1638
		[global::System.Runtime.Serialization.EnumMember(Value = "KeyboardLock")]
		KeyboardLock,
		// Token: 0x04000667 RID: 1639
		[global::System.Runtime.Serialization.EnumMember(Value = "WebOTPService")]
		WebOTPService,
		// Token: 0x04000668 RID: 1640
		[global::System.Runtime.Serialization.EnumMember(Value = "OutstandingNetworkRequestDirectSocket")]
		OutstandingNetworkRequestDirectSocket,
		// Token: 0x04000669 RID: 1641
		[global::System.Runtime.Serialization.EnumMember(Value = "InjectedJavascript")]
		InjectedJavascript,
		// Token: 0x0400066A RID: 1642
		[global::System.Runtime.Serialization.EnumMember(Value = "InjectedStyleSheet")]
		InjectedStyleSheet,
		// Token: 0x0400066B RID: 1643
		[global::System.Runtime.Serialization.EnumMember(Value = "KeepaliveRequest")]
		KeepaliveRequest,
		// Token: 0x0400066C RID: 1644
		[global::System.Runtime.Serialization.EnumMember(Value = "IndexedDBEvent")]
		IndexedDBEvent,
		// Token: 0x0400066D RID: 1645
		[global::System.Runtime.Serialization.EnumMember(Value = "Dummy")]
		Dummy,
		// Token: 0x0400066E RID: 1646
		[global::System.Runtime.Serialization.EnumMember(Value = "AuthorizationHeader")]
		AuthorizationHeader,
		// Token: 0x0400066F RID: 1647
		[global::System.Runtime.Serialization.EnumMember(Value = "ContentSecurityHandler")]
		ContentSecurityHandler,
		// Token: 0x04000670 RID: 1648
		[global::System.Runtime.Serialization.EnumMember(Value = "ContentWebAuthenticationAPI")]
		ContentWebAuthenticationAPI,
		// Token: 0x04000671 RID: 1649
		[global::System.Runtime.Serialization.EnumMember(Value = "ContentFileChooser")]
		ContentFileChooser,
		// Token: 0x04000672 RID: 1650
		[global::System.Runtime.Serialization.EnumMember(Value = "ContentSerial")]
		ContentSerial,
		// Token: 0x04000673 RID: 1651
		[global::System.Runtime.Serialization.EnumMember(Value = "ContentFileSystemAccess")]
		ContentFileSystemAccess,
		// Token: 0x04000674 RID: 1652
		[global::System.Runtime.Serialization.EnumMember(Value = "ContentMediaDevicesDispatcherHost")]
		ContentMediaDevicesDispatcherHost,
		// Token: 0x04000675 RID: 1653
		[global::System.Runtime.Serialization.EnumMember(Value = "ContentWebBluetooth")]
		ContentWebBluetooth,
		// Token: 0x04000676 RID: 1654
		[global::System.Runtime.Serialization.EnumMember(Value = "ContentWebUSB")]
		ContentWebUSB,
		// Token: 0x04000677 RID: 1655
		[global::System.Runtime.Serialization.EnumMember(Value = "ContentMediaSessionService")]
		ContentMediaSessionService,
		// Token: 0x04000678 RID: 1656
		[global::System.Runtime.Serialization.EnumMember(Value = "ContentScreenReader")]
		ContentScreenReader,
		// Token: 0x04000679 RID: 1657
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderPopupBlockerTabHelper")]
		EmbedderPopupBlockerTabHelper,
		// Token: 0x0400067A RID: 1658
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderSafeBrowsingTriggeredPopupBlocker")]
		EmbedderSafeBrowsingTriggeredPopupBlocker,
		// Token: 0x0400067B RID: 1659
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderSafeBrowsingThreatDetails")]
		EmbedderSafeBrowsingThreatDetails,
		// Token: 0x0400067C RID: 1660
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderAppBannerManager")]
		EmbedderAppBannerManager,
		// Token: 0x0400067D RID: 1661
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderDomDistillerViewerSource")]
		EmbedderDomDistillerViewerSource,
		// Token: 0x0400067E RID: 1662
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderDomDistillerSelfDeletingRequestDelegate")]
		EmbedderDomDistillerSelfDeletingRequestDelegate,
		// Token: 0x0400067F RID: 1663
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderOomInterventionTabHelper")]
		EmbedderOomInterventionTabHelper,
		// Token: 0x04000680 RID: 1664
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderOfflinePage")]
		EmbedderOfflinePage,
		// Token: 0x04000681 RID: 1665
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderChromePasswordManagerClientBindCredentialManager")]
		EmbedderChromePasswordManagerClientBindCredentialManager,
		// Token: 0x04000682 RID: 1666
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderPermissionRequestManager")]
		EmbedderPermissionRequestManager,
		// Token: 0x04000683 RID: 1667
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderModalDialog")]
		EmbedderModalDialog,
		// Token: 0x04000684 RID: 1668
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderExtensions")]
		EmbedderExtensions,
		// Token: 0x04000685 RID: 1669
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderExtensionMessaging")]
		EmbedderExtensionMessaging,
		// Token: 0x04000686 RID: 1670
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderExtensionMessagingForOpenPort")]
		EmbedderExtensionMessagingForOpenPort,
		// Token: 0x04000687 RID: 1671
		[global::System.Runtime.Serialization.EnumMember(Value = "EmbedderExtensionSentMessageToCachedFrame")]
		EmbedderExtensionSentMessageToCachedFrame
	}
}
