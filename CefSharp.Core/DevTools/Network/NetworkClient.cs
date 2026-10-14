using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CefSharp.DevTools.Emulation;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000241 RID: 577
	public class NetworkClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x060011AB RID: 4523 RVA: 0x00012BD0 File Offset: 0x00010DD0
		public NetworkClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400006E RID: 110
		// (add) Token: 0x060011AC RID: 4524 RVA: 0x00012BDF File Offset: 0x00010DDF
		// (remove) Token: 0x060011AD RID: 4525 RVA: 0x00012BF2 File Offset: 0x00010DF2
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.DataReceivedEventArgs> DataReceived
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.DataReceivedEventArgs>("Network.dataReceived", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.DataReceivedEventArgs>("Network.dataReceived", value);
			}
		}

		// Token: 0x1400006F RID: 111
		// (add) Token: 0x060011AE RID: 4526 RVA: 0x00012C06 File Offset: 0x00010E06
		// (remove) Token: 0x060011AF RID: 4527 RVA: 0x00012C19 File Offset: 0x00010E19
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.EventSourceMessageReceivedEventArgs> EventSourceMessageReceived
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.EventSourceMessageReceivedEventArgs>("Network.eventSourceMessageReceived", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.EventSourceMessageReceivedEventArgs>("Network.eventSourceMessageReceived", value);
			}
		}

		// Token: 0x14000070 RID: 112
		// (add) Token: 0x060011B0 RID: 4528 RVA: 0x00012C2D File Offset: 0x00010E2D
		// (remove) Token: 0x060011B1 RID: 4529 RVA: 0x00012C40 File Offset: 0x00010E40
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.LoadingFailedEventArgs> LoadingFailed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.LoadingFailedEventArgs>("Network.loadingFailed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.LoadingFailedEventArgs>("Network.loadingFailed", value);
			}
		}

		// Token: 0x14000071 RID: 113
		// (add) Token: 0x060011B2 RID: 4530 RVA: 0x00012C54 File Offset: 0x00010E54
		// (remove) Token: 0x060011B3 RID: 4531 RVA: 0x00012C67 File Offset: 0x00010E67
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.LoadingFinishedEventArgs> LoadingFinished
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.LoadingFinishedEventArgs>("Network.loadingFinished", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.LoadingFinishedEventArgs>("Network.loadingFinished", value);
			}
		}

		// Token: 0x14000072 RID: 114
		// (add) Token: 0x060011B4 RID: 4532 RVA: 0x00012C7B File Offset: 0x00010E7B
		// (remove) Token: 0x060011B5 RID: 4533 RVA: 0x00012C8E File Offset: 0x00010E8E
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.RequestServedFromCacheEventArgs> RequestServedFromCache
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.RequestServedFromCacheEventArgs>("Network.requestServedFromCache", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.RequestServedFromCacheEventArgs>("Network.requestServedFromCache", value);
			}
		}

		// Token: 0x14000073 RID: 115
		// (add) Token: 0x060011B6 RID: 4534 RVA: 0x00012CA2 File Offset: 0x00010EA2
		// (remove) Token: 0x060011B7 RID: 4535 RVA: 0x00012CB5 File Offset: 0x00010EB5
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.RequestWillBeSentEventArgs> RequestWillBeSent
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.RequestWillBeSentEventArgs>("Network.requestWillBeSent", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.RequestWillBeSentEventArgs>("Network.requestWillBeSent", value);
			}
		}

		// Token: 0x14000074 RID: 116
		// (add) Token: 0x060011B8 RID: 4536 RVA: 0x00012CC9 File Offset: 0x00010EC9
		// (remove) Token: 0x060011B9 RID: 4537 RVA: 0x00012CDC File Offset: 0x00010EDC
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.ResourceChangedPriorityEventArgs> ResourceChangedPriority
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.ResourceChangedPriorityEventArgs>("Network.resourceChangedPriority", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.ResourceChangedPriorityEventArgs>("Network.resourceChangedPriority", value);
			}
		}

		// Token: 0x14000075 RID: 117
		// (add) Token: 0x060011BA RID: 4538 RVA: 0x00012CF0 File Offset: 0x00010EF0
		// (remove) Token: 0x060011BB RID: 4539 RVA: 0x00012D03 File Offset: 0x00010F03
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.SignedExchangeReceivedEventArgs> SignedExchangeReceived
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.SignedExchangeReceivedEventArgs>("Network.signedExchangeReceived", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.SignedExchangeReceivedEventArgs>("Network.signedExchangeReceived", value);
			}
		}

		// Token: 0x14000076 RID: 118
		// (add) Token: 0x060011BC RID: 4540 RVA: 0x00012D17 File Offset: 0x00010F17
		// (remove) Token: 0x060011BD RID: 4541 RVA: 0x00012D2A File Offset: 0x00010F2A
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.ResponseReceivedEventArgs> ResponseReceived
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.ResponseReceivedEventArgs>("Network.responseReceived", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.ResponseReceivedEventArgs>("Network.responseReceived", value);
			}
		}

		// Token: 0x14000077 RID: 119
		// (add) Token: 0x060011BE RID: 4542 RVA: 0x00012D3E File Offset: 0x00010F3E
		// (remove) Token: 0x060011BF RID: 4543 RVA: 0x00012D51 File Offset: 0x00010F51
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.WebSocketClosedEventArgs> WebSocketClosed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.WebSocketClosedEventArgs>("Network.webSocketClosed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.WebSocketClosedEventArgs>("Network.webSocketClosed", value);
			}
		}

		// Token: 0x14000078 RID: 120
		// (add) Token: 0x060011C0 RID: 4544 RVA: 0x00012D65 File Offset: 0x00010F65
		// (remove) Token: 0x060011C1 RID: 4545 RVA: 0x00012D78 File Offset: 0x00010F78
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.WebSocketCreatedEventArgs> WebSocketCreated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.WebSocketCreatedEventArgs>("Network.webSocketCreated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.WebSocketCreatedEventArgs>("Network.webSocketCreated", value);
			}
		}

		// Token: 0x14000079 RID: 121
		// (add) Token: 0x060011C2 RID: 4546 RVA: 0x00012D8C File Offset: 0x00010F8C
		// (remove) Token: 0x060011C3 RID: 4547 RVA: 0x00012D9F File Offset: 0x00010F9F
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.WebSocketFrameErrorEventArgs> WebSocketFrameError
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.WebSocketFrameErrorEventArgs>("Network.webSocketFrameError", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.WebSocketFrameErrorEventArgs>("Network.webSocketFrameError", value);
			}
		}

		// Token: 0x1400007A RID: 122
		// (add) Token: 0x060011C4 RID: 4548 RVA: 0x00012DB3 File Offset: 0x00010FB3
		// (remove) Token: 0x060011C5 RID: 4549 RVA: 0x00012DC6 File Offset: 0x00010FC6
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.WebSocketFrameReceivedEventArgs> WebSocketFrameReceived
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.WebSocketFrameReceivedEventArgs>("Network.webSocketFrameReceived", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.WebSocketFrameReceivedEventArgs>("Network.webSocketFrameReceived", value);
			}
		}

		// Token: 0x1400007B RID: 123
		// (add) Token: 0x060011C6 RID: 4550 RVA: 0x00012DDA File Offset: 0x00010FDA
		// (remove) Token: 0x060011C7 RID: 4551 RVA: 0x00012DED File Offset: 0x00010FED
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.WebSocketFrameSentEventArgs> WebSocketFrameSent
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.WebSocketFrameSentEventArgs>("Network.webSocketFrameSent", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.WebSocketFrameSentEventArgs>("Network.webSocketFrameSent", value);
			}
		}

		// Token: 0x1400007C RID: 124
		// (add) Token: 0x060011C8 RID: 4552 RVA: 0x00012E01 File Offset: 0x00011001
		// (remove) Token: 0x060011C9 RID: 4553 RVA: 0x00012E14 File Offset: 0x00011014
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.WebSocketHandshakeResponseReceivedEventArgs> WebSocketHandshakeResponseReceived
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.WebSocketHandshakeResponseReceivedEventArgs>("Network.webSocketHandshakeResponseReceived", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.WebSocketHandshakeResponseReceivedEventArgs>("Network.webSocketHandshakeResponseReceived", value);
			}
		}

		// Token: 0x1400007D RID: 125
		// (add) Token: 0x060011CA RID: 4554 RVA: 0x00012E28 File Offset: 0x00011028
		// (remove) Token: 0x060011CB RID: 4555 RVA: 0x00012E3B File Offset: 0x0001103B
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.WebSocketWillSendHandshakeRequestEventArgs> WebSocketWillSendHandshakeRequest
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.WebSocketWillSendHandshakeRequestEventArgs>("Network.webSocketWillSendHandshakeRequest", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.WebSocketWillSendHandshakeRequestEventArgs>("Network.webSocketWillSendHandshakeRequest", value);
			}
		}

		// Token: 0x1400007E RID: 126
		// (add) Token: 0x060011CC RID: 4556 RVA: 0x00012E4F File Offset: 0x0001104F
		// (remove) Token: 0x060011CD RID: 4557 RVA: 0x00012E62 File Offset: 0x00011062
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.WebTransportCreatedEventArgs> WebTransportCreated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.WebTransportCreatedEventArgs>("Network.webTransportCreated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.WebTransportCreatedEventArgs>("Network.webTransportCreated", value);
			}
		}

		// Token: 0x1400007F RID: 127
		// (add) Token: 0x060011CE RID: 4558 RVA: 0x00012E76 File Offset: 0x00011076
		// (remove) Token: 0x060011CF RID: 4559 RVA: 0x00012E89 File Offset: 0x00011089
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.WebTransportConnectionEstablishedEventArgs> WebTransportConnectionEstablished
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.WebTransportConnectionEstablishedEventArgs>("Network.webTransportConnectionEstablished", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.WebTransportConnectionEstablishedEventArgs>("Network.webTransportConnectionEstablished", value);
			}
		}

		// Token: 0x14000080 RID: 128
		// (add) Token: 0x060011D0 RID: 4560 RVA: 0x00012E9D File Offset: 0x0001109D
		// (remove) Token: 0x060011D1 RID: 4561 RVA: 0x00012EB0 File Offset: 0x000110B0
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.WebTransportClosedEventArgs> WebTransportClosed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.WebTransportClosedEventArgs>("Network.webTransportClosed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.WebTransportClosedEventArgs>("Network.webTransportClosed", value);
			}
		}

		// Token: 0x14000081 RID: 129
		// (add) Token: 0x060011D2 RID: 4562 RVA: 0x00012EC4 File Offset: 0x000110C4
		// (remove) Token: 0x060011D3 RID: 4563 RVA: 0x00012ED7 File Offset: 0x000110D7
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.RequestWillBeSentExtraInfoEventArgs> RequestWillBeSentExtraInfo
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.RequestWillBeSentExtraInfoEventArgs>("Network.requestWillBeSentExtraInfo", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.RequestWillBeSentExtraInfoEventArgs>("Network.requestWillBeSentExtraInfo", value);
			}
		}

		// Token: 0x14000082 RID: 130
		// (add) Token: 0x060011D4 RID: 4564 RVA: 0x00012EEB File Offset: 0x000110EB
		// (remove) Token: 0x060011D5 RID: 4565 RVA: 0x00012EFE File Offset: 0x000110FE
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.ResponseReceivedExtraInfoEventArgs> ResponseReceivedExtraInfo
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.ResponseReceivedExtraInfoEventArgs>("Network.responseReceivedExtraInfo", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.ResponseReceivedExtraInfoEventArgs>("Network.responseReceivedExtraInfo", value);
			}
		}

		// Token: 0x14000083 RID: 131
		// (add) Token: 0x060011D6 RID: 4566 RVA: 0x00012F12 File Offset: 0x00011112
		// (remove) Token: 0x060011D7 RID: 4567 RVA: 0x00012F25 File Offset: 0x00011125
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.TrustTokenOperationDoneEventArgs> TrustTokenOperationDone
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.TrustTokenOperationDoneEventArgs>("Network.trustTokenOperationDone", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.TrustTokenOperationDoneEventArgs>("Network.trustTokenOperationDone", value);
			}
		}

		// Token: 0x14000084 RID: 132
		// (add) Token: 0x060011D8 RID: 4568 RVA: 0x00012F39 File Offset: 0x00011139
		// (remove) Token: 0x060011D9 RID: 4569 RVA: 0x00012F4C File Offset: 0x0001114C
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.SubresourceWebBundleMetadataReceivedEventArgs> SubresourceWebBundleMetadataReceived
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.SubresourceWebBundleMetadataReceivedEventArgs>("Network.subresourceWebBundleMetadataReceived", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.SubresourceWebBundleMetadataReceivedEventArgs>("Network.subresourceWebBundleMetadataReceived", value);
			}
		}

		// Token: 0x14000085 RID: 133
		// (add) Token: 0x060011DA RID: 4570 RVA: 0x00012F60 File Offset: 0x00011160
		// (remove) Token: 0x060011DB RID: 4571 RVA: 0x00012F73 File Offset: 0x00011173
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.SubresourceWebBundleMetadataErrorEventArgs> SubresourceWebBundleMetadataError
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.SubresourceWebBundleMetadataErrorEventArgs>("Network.subresourceWebBundleMetadataError", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.SubresourceWebBundleMetadataErrorEventArgs>("Network.subresourceWebBundleMetadataError", value);
			}
		}

		// Token: 0x14000086 RID: 134
		// (add) Token: 0x060011DC RID: 4572 RVA: 0x00012F87 File Offset: 0x00011187
		// (remove) Token: 0x060011DD RID: 4573 RVA: 0x00012F9A File Offset: 0x0001119A
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.SubresourceWebBundleInnerResponseParsedEventArgs> SubresourceWebBundleInnerResponseParsed
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.SubresourceWebBundleInnerResponseParsedEventArgs>("Network.subresourceWebBundleInnerResponseParsed", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.SubresourceWebBundleInnerResponseParsedEventArgs>("Network.subresourceWebBundleInnerResponseParsed", value);
			}
		}

		// Token: 0x14000087 RID: 135
		// (add) Token: 0x060011DE RID: 4574 RVA: 0x00012FAE File Offset: 0x000111AE
		// (remove) Token: 0x060011DF RID: 4575 RVA: 0x00012FC1 File Offset: 0x000111C1
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.SubresourceWebBundleInnerResponseErrorEventArgs> SubresourceWebBundleInnerResponseError
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.SubresourceWebBundleInnerResponseErrorEventArgs>("Network.subresourceWebBundleInnerResponseError", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.SubresourceWebBundleInnerResponseErrorEventArgs>("Network.subresourceWebBundleInnerResponseError", value);
			}
		}

		// Token: 0x14000088 RID: 136
		// (add) Token: 0x060011E0 RID: 4576 RVA: 0x00012FD5 File Offset: 0x000111D5
		// (remove) Token: 0x060011E1 RID: 4577 RVA: 0x00012FE8 File Offset: 0x000111E8
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.ReportingApiReportAddedEventArgs> ReportingApiReportAdded
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.ReportingApiReportAddedEventArgs>("Network.reportingApiReportAdded", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.ReportingApiReportAddedEventArgs>("Network.reportingApiReportAdded", value);
			}
		}

		// Token: 0x14000089 RID: 137
		// (add) Token: 0x060011E2 RID: 4578 RVA: 0x00012FFC File Offset: 0x000111FC
		// (remove) Token: 0x060011E3 RID: 4579 RVA: 0x0001300F File Offset: 0x0001120F
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.ReportingApiReportUpdatedEventArgs> ReportingApiReportUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.ReportingApiReportUpdatedEventArgs>("Network.reportingApiReportUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.ReportingApiReportUpdatedEventArgs>("Network.reportingApiReportUpdated", value);
			}
		}

		// Token: 0x1400008A RID: 138
		// (add) Token: 0x060011E4 RID: 4580 RVA: 0x00013023 File Offset: 0x00011223
		// (remove) Token: 0x060011E5 RID: 4581 RVA: 0x00013036 File Offset: 0x00011236
		public event global::System.EventHandler<global::CefSharp.DevTools.Network.ReportingApiEndpointsChangedForOriginEventArgs> ReportingApiEndpointsChangedForOrigin
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Network.ReportingApiEndpointsChangedForOriginEventArgs>("Network.reportingApiEndpointsChangedForOrigin", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Network.ReportingApiEndpointsChangedForOriginEventArgs>("Network.reportingApiEndpointsChangedForOrigin", value);
			}
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x0001304C File Offset: 0x0001124C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetAcceptedEncodingsAsync(global::CefSharp.DevTools.Network.ContentEncoding[] encodings)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("encodings", base.EnumToString(encodings));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.setAcceptedEncodings", dictionary);
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00013084 File Offset: 0x00011284
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearAcceptedEncodingsOverrideAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.clearAcceptedEncodingsOverride", parameters);
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x000130A4 File Offset: 0x000112A4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearBrowserCacheAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.clearBrowserCache", parameters);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x000130C4 File Offset: 0x000112C4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ClearBrowserCookiesAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.clearBrowserCookies", parameters);
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x000130E4 File Offset: 0x000112E4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DeleteCookiesAsync(string name, string url = null, string domain = null, string path = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("name", name);
			if (!string.IsNullOrEmpty(url))
			{
				dictionary.Add("url", url);
			}
			if (!string.IsNullOrEmpty(domain))
			{
				dictionary.Add("domain", domain);
			}
			if (!string.IsNullOrEmpty(path))
			{
				dictionary.Add("path", path);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.deleteCookies", dictionary);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00013154 File Offset: 0x00011354
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.disable", parameters);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00013174 File Offset: 0x00011374
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EmulateNetworkConditionsAsync(bool offline, double latency, double downloadThroughput, double uploadThroughput, global::CefSharp.DevTools.Network.ConnectionType? connectionType = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("offline", offline);
			dictionary.Add("latency", latency);
			dictionary.Add("downloadThroughput", downloadThroughput);
			dictionary.Add("uploadThroughput", uploadThroughput);
			if (connectionType != null)
			{
				dictionary.Add("connectionType", base.EnumToString(connectionType));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.emulateNetworkConditions", dictionary);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00013200 File Offset: 0x00011400
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync(int? maxTotalBufferSize = null, int? maxResourceBufferSize = null, int? maxPostDataSize = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (maxTotalBufferSize != null)
			{
				dictionary.Add("maxTotalBufferSize", maxTotalBufferSize.Value);
			}
			if (maxResourceBufferSize != null)
			{
				dictionary.Add("maxResourceBufferSize", maxResourceBufferSize.Value);
			}
			if (maxPostDataSize != null)
			{
				dictionary.Add("maxPostDataSize", maxPostDataSize.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.enable", dictionary);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00013284 File Offset: 0x00011484
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Network.GetCertificateResponse> GetCertificateAsync(string origin)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("origin", origin);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Network.GetCertificateResponse>("Network.getCertificate", dictionary);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x000132B4 File Offset: 0x000114B4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Network.GetCookiesResponse> GetCookiesAsync(string[] urls = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (urls != null)
			{
				dictionary.Add("urls", urls);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Network.GetCookiesResponse>("Network.getCookies", dictionary);
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x000132E8 File Offset: 0x000114E8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Network.GetResponseBodyResponse> GetResponseBodyAsync(string requestId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("requestId", requestId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Network.GetResponseBodyResponse>("Network.getResponseBody", dictionary);
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00013318 File Offset: 0x00011518
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Network.GetRequestPostDataResponse> GetRequestPostDataAsync(string requestId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("requestId", requestId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Network.GetRequestPostDataResponse>("Network.getRequestPostData", dictionary);
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00013348 File Offset: 0x00011548
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Network.GetResponseBodyForInterceptionResponse> GetResponseBodyForInterceptionAsync(string interceptionId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("interceptionId", interceptionId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Network.GetResponseBodyForInterceptionResponse>("Network.getResponseBodyForInterception", dictionary);
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00013378 File Offset: 0x00011578
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Network.TakeResponseBodyForInterceptionAsStreamResponse> TakeResponseBodyForInterceptionAsStreamAsync(string interceptionId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("interceptionId", interceptionId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Network.TakeResponseBodyForInterceptionAsStreamResponse>("Network.takeResponseBodyForInterceptionAsStream", dictionary);
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x000133A8 File Offset: 0x000115A8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ReplayXHRAsync(string requestId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("requestId", requestId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.replayXHR", dictionary);
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x000133D8 File Offset: 0x000115D8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Network.SearchInResponseBodyResponse> SearchInResponseBodyAsync(string requestId, string query, bool? caseSensitive = null, bool? isRegex = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("requestId", requestId);
			dictionary.Add("query", query);
			if (caseSensitive != null)
			{
				dictionary.Add("caseSensitive", caseSensitive.Value);
			}
			if (isRegex != null)
			{
				dictionary.Add("isRegex", isRegex.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Network.SearchInResponseBodyResponse>("Network.searchInResponseBody", dictionary);
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x00013454 File Offset: 0x00011654
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetBlockedURLsAsync(string[] urls)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("urls", urls);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.setBlockedURLs", dictionary);
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00013484 File Offset: 0x00011684
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetBypassServiceWorkerAsync(bool bypass)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("bypass", bypass);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.setBypassServiceWorker", dictionary);
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x000134BC File Offset: 0x000116BC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetCacheDisabledAsync(bool cacheDisabled)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("cacheDisabled", cacheDisabled);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.setCacheDisabled", dictionary);
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x000134F4 File Offset: 0x000116F4
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Network.SetCookieResponse> SetCookieAsync(string name, string value, string url = null, string domain = null, string path = null, bool? secure = null, bool? httpOnly = null, global::CefSharp.DevTools.Network.CookieSameSite? sameSite = null, double? expires = null, global::CefSharp.DevTools.Network.CookiePriority? priority = null, bool? sameParty = null, global::CefSharp.DevTools.Network.CookieSourceScheme? sourceScheme = null, int? sourcePort = null, string partitionKey = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("name", name);
			dictionary.Add("value", value);
			if (!string.IsNullOrEmpty(url))
			{
				dictionary.Add("url", url);
			}
			if (!string.IsNullOrEmpty(domain))
			{
				dictionary.Add("domain", domain);
			}
			if (!string.IsNullOrEmpty(path))
			{
				dictionary.Add("path", path);
			}
			if (secure != null)
			{
				dictionary.Add("secure", secure.Value);
			}
			if (httpOnly != null)
			{
				dictionary.Add("httpOnly", httpOnly.Value);
			}
			if (sameSite != null)
			{
				dictionary.Add("sameSite", base.EnumToString(sameSite));
			}
			if (expires != null)
			{
				dictionary.Add("expires", expires.Value);
			}
			if (priority != null)
			{
				dictionary.Add("priority", base.EnumToString(priority));
			}
			if (sameParty != null)
			{
				dictionary.Add("sameParty", sameParty.Value);
			}
			if (sourceScheme != null)
			{
				dictionary.Add("sourceScheme", base.EnumToString(sourceScheme));
			}
			if (sourcePort != null)
			{
				dictionary.Add("sourcePort", sourcePort.Value);
			}
			if (!string.IsNullOrEmpty(partitionKey))
			{
				dictionary.Add("partitionKey", partitionKey);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Network.SetCookieResponse>("Network.setCookie", dictionary);
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0001368C File Offset: 0x0001188C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetCookiesAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.Network.CookieParam> cookies)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("cookies", from x in cookies
			select x.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.setCookies", dictionary);
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x000136E0 File Offset: 0x000118E0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetExtraHTTPHeadersAsync(global::CefSharp.DevTools.Network.Headers headers)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("headers", headers.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.setExtraHTTPHeaders", dictionary);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x00013718 File Offset: 0x00011918
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetAttachDebugStackAsync(bool enabled)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enabled", enabled);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.setAttachDebugStack", dictionary);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x00013750 File Offset: 0x00011950
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetUserAgentOverrideAsync(string userAgent, string acceptLanguage = null, string platform = null, global::CefSharp.DevTools.Emulation.UserAgentMetadata userAgentMetadata = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("userAgent", userAgent);
			if (!string.IsNullOrEmpty(acceptLanguage))
			{
				dictionary.Add("acceptLanguage", acceptLanguage);
			}
			if (!string.IsNullOrEmpty(platform))
			{
				dictionary.Add("platform", platform);
			}
			if (userAgentMetadata != null)
			{
				dictionary.Add("userAgentMetadata", userAgentMetadata.ToDictionary());
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.setUserAgentOverride", dictionary);
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x000137C0 File Offset: 0x000119C0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Network.GetSecurityIsolationStatusResponse> GetSecurityIsolationStatusAsync(string frameId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(frameId))
			{
				dictionary.Add("frameId", frameId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Network.GetSecurityIsolationStatusResponse>("Network.getSecurityIsolationStatus", dictionary);
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x000137F8 File Offset: 0x000119F8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableReportingApiAsync(bool enable)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("enable", enable);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Network.enableReportingApi", dictionary);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x00013830 File Offset: 0x00011A30
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Network.LoadNetworkResourceResponse> LoadNetworkResourceAsync(string url, global::CefSharp.DevTools.Network.LoadNetworkResourceOptions options, string frameId = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("url", url);
			dictionary.Add("options", options.ToDictionary());
			if (!string.IsNullOrEmpty(frameId))
			{
				dictionary.Add("frameId", frameId);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Network.LoadNetworkResourceResponse>("Network.loadNetworkResource", dictionary);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x00013888 File Offset: 0x00011A88
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Network.LoadNetworkResourceResponse> LoadNetworkResourceAsync(string frameId, string url, global::CefSharp.DevTools.Network.LoadNetworkResourceOptions options)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (!string.IsNullOrEmpty(frameId))
			{
				dictionary.Add("frameId", frameId);
			}
			dictionary.Add("url", url);
			dictionary.Add("options", options.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Network.LoadNetworkResourceResponse>("Network.loadNetworkResource", dictionary);
		}

		// Token: 0x040009B1 RID: 2481
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
