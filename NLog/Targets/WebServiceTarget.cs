using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Text;
using System.Xml;
using NLog.Common;
using NLog.Config;
using NLog.Internal;

namespace NLog.Targets
{
	// Token: 0x02000059 RID: 89
	[global::NLog.Targets.Target("WebService")]
	public sealed class WebServiceTarget : global::NLog.Targets.MethodCallTargetBase
	{
		// Token: 0x06000781 RID: 1921 RVA: 0x00012F8C File Offset: 0x0001118C
		public WebServiceTarget()
		{
			this.Protocol = global::NLog.Targets.WebServiceProtocol.Soap11;
			this.Encoding = new global::System.Text.UTF8Encoding(false);
			this.IncludeBOM = new bool?(false);
			base.OptimizeBufferReuse = true;
			this.Headers = new global::System.Collections.Generic.List<global::NLog.Targets.MethodCallParameter>();
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x00012FDB File Offset: 0x000111DB
		public WebServiceTarget(string name) : this()
		{
			base.Name = name;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000783 RID: 1923 RVA: 0x00012FEA File Offset: 0x000111EA
		// (set) Token: 0x06000784 RID: 1924 RVA: 0x00012FF2 File Offset: 0x000111F2
		public global::System.Uri Url { get; set; }

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000785 RID: 1925 RVA: 0x00012FFB File Offset: 0x000111FB
		// (set) Token: 0x06000786 RID: 1926 RVA: 0x00013003 File Offset: 0x00011203
		public string MethodName { get; set; }

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000787 RID: 1927 RVA: 0x0001300C File Offset: 0x0001120C
		// (set) Token: 0x06000788 RID: 1928 RVA: 0x00013014 File Offset: 0x00011214
		public string Namespace { get; set; }

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x0001301D File Offset: 0x0001121D
		// (set) Token: 0x0600078A RID: 1930 RVA: 0x0001302A File Offset: 0x0001122A
		[global::System.ComponentModel.DefaultValue("Soap11")]
		public global::NLog.Targets.WebServiceProtocol Protocol
		{
			get
			{
				return this._activeProtocol.Key;
			}
			set
			{
				this._activeProtocol = new global::System.Collections.Generic.KeyValuePair<global::NLog.Targets.WebServiceProtocol, global::NLog.Targets.WebServiceTarget.HttpPostFormatterBase>(value, null);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600078B RID: 1931 RVA: 0x00013039 File Offset: 0x00011239
		// (set) Token: 0x0600078C RID: 1932 RVA: 0x00013046 File Offset: 0x00011246
		[global::System.ComponentModel.DefaultValue("DefaultWebProxy")]
		public global::NLog.Targets.WebServiceProxyType ProxyType
		{
			get
			{
				return this._activeProxy.Key;
			}
			set
			{
				this._activeProxy = new global::System.Collections.Generic.KeyValuePair<global::NLog.Targets.WebServiceProxyType, global::System.Net.IWebProxy>(value, null);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600078D RID: 1933 RVA: 0x00013055 File Offset: 0x00011255
		// (set) Token: 0x0600078E RID: 1934 RVA: 0x0001305D File Offset: 0x0001125D
		public string ProxyAddress { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x0600078F RID: 1935 RVA: 0x00013066 File Offset: 0x00011266
		// (set) Token: 0x06000790 RID: 1936 RVA: 0x0001306E File Offset: 0x0001126E
		public bool? IncludeBOM { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000791 RID: 1937 RVA: 0x00013077 File Offset: 0x00011277
		// (set) Token: 0x06000792 RID: 1938 RVA: 0x0001307F File Offset: 0x0001127F
		public global::System.Text.Encoding Encoding { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x00013088 File Offset: 0x00011288
		// (set) Token: 0x06000794 RID: 1940 RVA: 0x00013090 File Offset: 0x00011290
		public bool EscapeDataRfc3986 { get; set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x00013099 File Offset: 0x00011299
		// (set) Token: 0x06000796 RID: 1942 RVA: 0x000130A1 File Offset: 0x000112A1
		public bool EscapeDataNLogLegacy { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000797 RID: 1943 RVA: 0x000130AA File Offset: 0x000112AA
		// (set) Token: 0x06000798 RID: 1944 RVA: 0x000130B2 File Offset: 0x000112B2
		public string XmlRoot { get; set; }

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000799 RID: 1945 RVA: 0x000130BB File Offset: 0x000112BB
		// (set) Token: 0x0600079A RID: 1946 RVA: 0x000130C3 File Offset: 0x000112C3
		public string XmlRootNamespace { get; set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x000130CC File Offset: 0x000112CC
		// (set) Token: 0x0600079C RID: 1948 RVA: 0x000130D4 File Offset: 0x000112D4
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Targets.MethodCallParameter), "header")]
		public global::System.Collections.Generic.IList<global::NLog.Targets.MethodCallParameter> Headers { get; private set; }

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x000130DD File Offset: 0x000112DD
		// (set) Token: 0x0600079E RID: 1950 RVA: 0x000130E5 File Offset: 0x000112E5
		public bool PreAuthenticate { get; set; }

		// Token: 0x0600079F RID: 1951 RVA: 0x000130EE File Offset: 0x000112EE
		protected override void DoInvoke(object[] parameters)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x000130F8 File Offset: 0x000112F8
		protected override void DoInvoke(object[] parameters, global::NLog.Common.AsyncContinuation continuation)
		{
			global::System.Net.HttpWebRequest request = (global::System.Net.HttpWebRequest)global::System.Net.WebRequest.Create(this.BuildWebServiceUrl(parameters));
			this.DoInvoke(parameters, request, continuation);
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x00013120 File Offset: 0x00011320
		protected override void DoInvoke(object[] parameters, global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			global::System.Net.HttpWebRequest httpWebRequest = (global::System.Net.HttpWebRequest)global::System.Net.WebRequest.Create(this.BuildWebServiceUrl(parameters));
			if (this.Headers != null && this.Headers.Count > 0)
			{
				for (int i = 0; i < this.Headers.Count; i++)
				{
					string text = base.RenderLogEvent(this.Headers[i].Layout, logEvent.LogEvent);
					if (text != null)
					{
						httpWebRequest.Headers[this.Headers[i].Name] = text;
					}
				}
			}
			this.DoInvoke(parameters, httpWebRequest, logEvent.Continuation);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x000131BC File Offset: 0x000113BC
		private void DoInvoke(object[] parameters, global::System.Net.HttpWebRequest request, global::NLog.Common.AsyncContinuation continuation)
		{
			global::System.Func<global::System.AsyncCallback, global::System.IAsyncResult> beginFunc = (global::System.AsyncCallback r) => request.BeginGetRequestStream(r, null);
			global::System.Func<global::System.IAsyncResult, global::System.IO.Stream> getStreamFunc = new global::System.Func<global::System.IAsyncResult, global::System.IO.Stream>(request.EndGetRequestStream);
			switch (this.ProxyType)
			{
			case global::NLog.Targets.WebServiceProxyType.DefaultWebProxy:
				goto IL_F9;
			case global::NLog.Targets.WebServiceProxyType.AutoProxy:
				if (this._activeProxy.Value == null)
				{
					global::System.Net.IWebProxy systemWebProxy = global::System.Net.WebRequest.GetSystemWebProxy();
					systemWebProxy.Credentials = global::System.Net.CredentialCache.DefaultCredentials;
					this._activeProxy = new global::System.Collections.Generic.KeyValuePair<global::NLog.Targets.WebServiceProxyType, global::System.Net.IWebProxy>(this.ProxyType, systemWebProxy);
				}
				request.Proxy = this._activeProxy.Value;
				goto IL_F9;
			case global::NLog.Targets.WebServiceProxyType.ProxyAddress:
				if (!string.IsNullOrEmpty(this.ProxyAddress))
				{
					if (this._activeProxy.Value == null)
					{
						global::System.Net.IWebProxy value = new global::System.Net.WebProxy(this.ProxyAddress, true);
						this._activeProxy = new global::System.Collections.Generic.KeyValuePair<global::NLog.Targets.WebServiceProxyType, global::System.Net.IWebProxy>(this.ProxyType, value);
					}
					request.Proxy = this._activeProxy.Value;
					goto IL_F9;
				}
				goto IL_F9;
			}
			request.Proxy = null;
			IL_F9:
			if (this.PreAuthenticate || this.ProxyType == global::NLog.Targets.WebServiceProxyType.AutoProxy)
			{
				request.PreAuthenticate = true;
			}
			this.DoInvoke(parameters, continuation, request, beginFunc, getStreamFunc);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x000132F0 File Offset: 0x000114F0
		internal void DoInvoke(object[] parameters, global::NLog.Common.AsyncContinuation continuation, global::System.Net.HttpWebRequest request, global::System.Func<global::System.AsyncCallback, global::System.IAsyncResult> beginFunc, global::System.Func<global::System.IAsyncResult, global::System.IO.Stream> getStreamFunc)
		{
			global::System.IO.Stream postPayload = null;
			if (this.Protocol == global::NLog.Targets.WebServiceProtocol.HttpGet)
			{
				this.PrepareGetRequest(request);
			}
			else
			{
				if (this._activeProtocol.Value == null)
				{
					this._activeProtocol = new global::System.Collections.Generic.KeyValuePair<global::NLog.Targets.WebServiceProtocol, global::NLog.Targets.WebServiceTarget.HttpPostFormatterBase>(this.Protocol, global::NLog.Targets.WebServiceTarget._postFormatterFactories[this.Protocol](this));
				}
				postPayload = this._activeProtocol.Value.PrepareRequest(request, parameters);
			}
			global::NLog.Common.AsyncContinuation sendContinuation = this.CreateSendContinuation(continuation, request);
			this.PostPayload(continuation, beginFunc, getStreamFunc, postPayload, sendContinuation);
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x0001336E File Offset: 0x0001156E
		private global::NLog.Common.AsyncContinuation CreateSendContinuation(global::NLog.Common.AsyncContinuation continuation, global::System.Net.HttpWebRequest request)
		{
			global::System.AsyncCallback <>9__1;
			return delegate(global::System.Exception ex)
			{
				if (ex != null)
				{
					this.DoInvokeCompleted(continuation, ex);
					return;
				}
				try
				{
					global::System.Net.WebRequest request2 = request;
					global::System.AsyncCallback callback;
					if ((callback = <>9__1) == null)
					{
						callback = (<>9__1 = delegate(global::System.IAsyncResult r)
						{
							try
							{
								using (request.EndGetResponse(r))
								{
								}
								this.DoInvokeCompleted(continuation, null);
							}
							catch (global::System.Exception ex3)
							{
								global::NLog.Common.InternalLogger.Error(ex3, "WebServiceTarget(Name={0}): Error sending request", new object[]
								{
									this.Name
								});
								if (ex3.MustBeRethrownImmediately())
								{
									throw;
								}
								this.DoInvokeCompleted(continuation, ex3);
							}
						});
					}
					request2.BeginGetResponse(callback, null);
				}
				catch (global::System.Exception ex2)
				{
					global::NLog.Common.InternalLogger.Error(ex2, "WebServiceTarget(Name={0}): Error starting request", new object[]
					{
						this.Name
					});
					if (ex2.MustBeRethrown())
					{
						throw;
					}
					this.DoInvokeCompleted(continuation, ex2);
				}
			};
		}

		// Token: 0x060007A5 RID: 1957 RVA: 0x00013398 File Offset: 0x00011598
		private void PostPayload(global::NLog.Common.AsyncContinuation continuation, global::System.Func<global::System.AsyncCallback, global::System.IAsyncResult> beginFunc, global::System.Func<global::System.IAsyncResult, global::System.IO.Stream> getStreamFunc, global::System.IO.Stream postPayload, global::NLog.Common.AsyncContinuation sendContinuation)
		{
			if (postPayload != null && postPayload.Length > 0L)
			{
				postPayload.Position = 0L;
				try
				{
					this._pendingManualFlushList.BeginOperation();
					beginFunc(delegate(global::System.IAsyncResult result)
					{
						try
						{
							using (global::System.IO.Stream stream = getStreamFunc(result))
							{
								global::NLog.Targets.WebServiceTarget.WriteStreamAndFixPreamble(postPayload, stream, this.IncludeBOM, this.Encoding);
								postPayload.Dispose();
							}
							sendContinuation(null);
						}
						catch (global::System.Exception ex2)
						{
							global::NLog.Common.InternalLogger.Error(ex2, "WebServiceTarget(Name={0}): Error sending post data", new object[]
							{
								this.Name
							});
							if (ex2.MustBeRethrownImmediately())
							{
								throw;
							}
							postPayload.Dispose();
							this.DoInvokeCompleted(continuation, ex2);
						}
					});
					return;
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Error(ex, "WebServiceTarget(Name={0}): Error starting post data", new object[]
					{
						base.Name
					});
					if (ex.MustBeRethrown())
					{
						throw;
					}
					this.DoInvokeCompleted(continuation, ex);
					return;
				}
			}
			this._pendingManualFlushList.BeginOperation();
			sendContinuation(null);
		}

		// Token: 0x060007A6 RID: 1958 RVA: 0x00013470 File Offset: 0x00011670
		private void DoInvokeCompleted(global::NLog.Common.AsyncContinuation continuation, global::System.Exception ex)
		{
			this._pendingManualFlushList.CompleteOperation(ex);
			continuation(ex);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00013485 File Offset: 0x00011685
		protected override void FlushAsync(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			this._pendingManualFlushList.RegisterCompletionNotification(asyncContinuation)(null);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00013499 File Offset: 0x00011699
		protected override void CloseTarget()
		{
			this._pendingManualFlushList.Clear();
			base.CloseTarget();
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x000134AC File Offset: 0x000116AC
		private global::System.Uri BuildWebServiceUrl(object[] parameterValues)
		{
			if (this.Protocol != global::NLog.Targets.WebServiceProtocol.HttpGet)
			{
				return this.Url;
			}
			string text = string.Empty;
			using (global::NLog.Internal.ReusableObjectCreator<global::System.Text.StringBuilder>.LockOject lockOject = base.OptimizeBufferReuse ? this.ReusableLayoutBuilder.Allocate() : this.ReusableLayoutBuilder.None)
			{
				global::System.Text.StringBuilder stringBuilder = lockOject.Result ?? new global::System.Text.StringBuilder();
				global::NLog.Internal.UrlHelper.EscapeEncodingFlag uriStringEncodingFlags = global::NLog.Internal.UrlHelper.GetUriStringEncodingFlags(this.EscapeDataNLogLegacy, false, this.EscapeDataRfc3986);
				this.BuildWebServiceQueryParameters(parameterValues, stringBuilder, uriStringEncodingFlags);
				text = stringBuilder.ToString();
			}
			global::System.UriBuilder uriBuilder = new global::System.UriBuilder(this.Url);
			if (uriBuilder.Query != null && uriBuilder.Query.Length > 1)
			{
				uriBuilder.Query = uriBuilder.Query.Substring(1) + "&" + text;
			}
			else
			{
				uriBuilder.Query = text;
			}
			return uriBuilder.Uri;
		}

		// Token: 0x060007AA RID: 1962 RVA: 0x00013594 File Offset: 0x00011794
		private void BuildWebServiceQueryParameters(object[] parameterValues, global::System.Text.StringBuilder sb, global::NLog.Internal.UrlHelper.EscapeEncodingFlag encodingFlags)
		{
			string value = string.Empty;
			for (int i = 0; i < base.Parameters.Count; i++)
			{
				sb.Append(value);
				sb.Append(base.Parameters[i].Name);
				sb.Append("=");
				string text = global::NLog.Internal.XmlHelper.XmlConvertToString(parameterValues[i]);
				if (!string.IsNullOrEmpty(text))
				{
					global::NLog.Internal.UrlHelper.EscapeDataEncode(text, sb, encodingFlags);
				}
				value = "&";
			}
		}

		// Token: 0x060007AB RID: 1963 RVA: 0x00013608 File Offset: 0x00011808
		private void PrepareGetRequest(global::System.Net.HttpWebRequest request)
		{
			request.Method = "GET";
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x00013618 File Offset: 0x00011818
		private static void WriteStreamAndFixPreamble(global::System.IO.Stream input, global::System.IO.Stream output, bool? writeUtf8BOM, global::System.Text.Encoding encoding)
		{
			bool flag = writeUtf8BOM == null || !(encoding is global::System.Text.UTF8Encoding);
			if (!flag)
			{
				bool flag2 = encoding.GetPreamble().Length == 3;
				flag = ((writeUtf8BOM.Value && flag2) || (!writeUtf8BOM.Value && !flag2));
			}
			int offset = flag ? 0 : 3;
			input.CopyWithOffset(output, offset);
		}

		// Token: 0x04000189 RID: 393
		private const string SoapEnvelopeNamespaceUri = "http://schemas.xmlsoap.org/soap/envelope/";

		// Token: 0x0400018A RID: 394
		private const string Soap12EnvelopeNamespaceUri = "http://www.w3.org/2003/05/soap-envelope";

		// Token: 0x0400018B RID: 395
		private static global::System.Collections.Generic.Dictionary<global::NLog.Targets.WebServiceProtocol, global::System.Func<global::NLog.Targets.WebServiceTarget, global::NLog.Targets.WebServiceTarget.HttpPostFormatterBase>> _postFormatterFactories = new global::System.Collections.Generic.Dictionary<global::NLog.Targets.WebServiceProtocol, global::System.Func<global::NLog.Targets.WebServiceTarget, global::NLog.Targets.WebServiceTarget.HttpPostFormatterBase>>
		{
			{
				global::NLog.Targets.WebServiceProtocol.Soap11,
				(global::NLog.Targets.WebServiceTarget t) => new global::NLog.Targets.WebServiceTarget.HttpPostSoap11Formatter(t)
			},
			{
				global::NLog.Targets.WebServiceProtocol.Soap12,
				(global::NLog.Targets.WebServiceTarget t) => new global::NLog.Targets.WebServiceTarget.HttpPostSoap12Formatter(t)
			},
			{
				global::NLog.Targets.WebServiceProtocol.HttpPost,
				(global::NLog.Targets.WebServiceTarget t) => new global::NLog.Targets.WebServiceTarget.HttpPostFormEncodedFormatter(t)
			},
			{
				global::NLog.Targets.WebServiceProtocol.JsonPost,
				(global::NLog.Targets.WebServiceTarget t) => new global::NLog.Targets.WebServiceTarget.HttpPostJsonFormatter(t)
			},
			{
				global::NLog.Targets.WebServiceProtocol.XmlPost,
				(global::NLog.Targets.WebServiceTarget t) => new global::NLog.Targets.WebServiceTarget.HttpPostXmlDocumentFormatter(t)
			}
		};

		// Token: 0x0400018F RID: 399
		private global::System.Collections.Generic.KeyValuePair<global::NLog.Targets.WebServiceProtocol, global::NLog.Targets.WebServiceTarget.HttpPostFormatterBase> _activeProtocol;

		// Token: 0x04000190 RID: 400
		private global::System.Collections.Generic.KeyValuePair<global::NLog.Targets.WebServiceProxyType, global::System.Net.IWebProxy> _activeProxy;

		// Token: 0x0400019A RID: 410
		private readonly global::NLog.Internal.AsyncOperationCounter _pendingManualFlushList = new global::NLog.Internal.AsyncOperationCounter();

		// Token: 0x020001D8 RID: 472
		private abstract class HttpPostFormatterBase
		{
			// Token: 0x06001224 RID: 4644 RVA: 0x0002F58C File Offset: 0x0002D78C
			protected HttpPostFormatterBase(global::NLog.Targets.WebServiceTarget target)
			{
				this.Target = target;
			}

			// Token: 0x1700035B RID: 859
			// (get) Token: 0x06001225 RID: 4645
			protected abstract string ContentType { get; }

			// Token: 0x1700035C RID: 860
			// (get) Token: 0x06001226 RID: 4646 RVA: 0x0002F59B File Offset: 0x0002D79B
			// (set) Token: 0x06001227 RID: 4647 RVA: 0x0002F5A3 File Offset: 0x0002D7A3
			private protected global::NLog.Targets.WebServiceTarget Target { protected get; private set; }

			// Token: 0x06001228 RID: 4648 RVA: 0x0002F5AC File Offset: 0x0002D7AC
			public global::System.IO.MemoryStream PrepareRequest(global::System.Net.HttpWebRequest request, object[] parameterValues)
			{
				this.InitRequest(request);
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				this.WriteContent(memoryStream, parameterValues);
				return memoryStream;
			}

			// Token: 0x06001229 RID: 4649 RVA: 0x0002F5CF File Offset: 0x0002D7CF
			protected virtual void InitRequest(global::System.Net.HttpWebRequest request)
			{
				request.Method = "POST";
				request.ContentType = this.ContentType + "; charset=" + this.Target.Encoding.WebName;
			}

			// Token: 0x0600122A RID: 4650
			protected abstract void WriteContent(global::System.IO.MemoryStream ms, object[] parameterValues);
		}

		// Token: 0x020001D9 RID: 473
		private class HttpPostFormEncodedFormatter : global::NLog.Targets.WebServiceTarget.HttpPostTextFormatterBase
		{
			// Token: 0x0600122B RID: 4651 RVA: 0x0002F602 File Offset: 0x0002D802
			public HttpPostFormEncodedFormatter(global::NLog.Targets.WebServiceTarget target) : base(target)
			{
				this._encodingFlags = global::NLog.Internal.UrlHelper.GetUriStringEncodingFlags(target.EscapeDataNLogLegacy, true, target.EscapeDataRfc3986);
			}

			// Token: 0x1700035D RID: 861
			// (get) Token: 0x0600122C RID: 4652 RVA: 0x0002F623 File Offset: 0x0002D823
			protected override string ContentType
			{
				get
				{
					return "application/x-www-form-urlencoded";
				}
			}

			// Token: 0x0600122D RID: 4653 RVA: 0x0002F62A File Offset: 0x0002D82A
			protected override void WriteStringContent(global::System.Text.StringBuilder builder, object[] parameterValues)
			{
				base.Target.BuildWebServiceQueryParameters(parameterValues, builder, this._encodingFlags);
			}

			// Token: 0x04000555 RID: 1365
			private readonly global::NLog.Internal.UrlHelper.EscapeEncodingFlag _encodingFlags;
		}

		// Token: 0x020001DA RID: 474
		private class HttpPostJsonFormatter : global::NLog.Targets.WebServiceTarget.HttpPostTextFormatterBase
		{
			// Token: 0x1700035E RID: 862
			// (get) Token: 0x0600122E RID: 4654 RVA: 0x0002F640 File Offset: 0x0002D840
			private global::NLog.IJsonConverter JsonConverter
			{
				get
				{
					global::NLog.IJsonConverter result;
					if ((result = this._jsonConverter) == null)
					{
						result = (this._jsonConverter = global::NLog.Config.ConfigurationItemFactory.Default.JsonConverter);
					}
					return result;
				}
			}

			// Token: 0x0600122F RID: 4655 RVA: 0x0002F66A File Offset: 0x0002D86A
			public HttpPostJsonFormatter(global::NLog.Targets.WebServiceTarget target) : base(target)
			{
			}

			// Token: 0x1700035F RID: 863
			// (get) Token: 0x06001230 RID: 4656 RVA: 0x0002F673 File Offset: 0x0002D873
			protected override string ContentType
			{
				get
				{
					return "application/json";
				}
			}

			// Token: 0x06001231 RID: 4657 RVA: 0x0002F67C File Offset: 0x0002D87C
			protected override void WriteStringContent(global::System.Text.StringBuilder builder, object[] parameterValues)
			{
				string value;
				if (base.Target.Parameters.Count == 1 && string.IsNullOrEmpty(base.Target.Parameters[0].Name) && (value = (parameterValues[0] as string)) != null)
				{
					builder.Append(value);
					return;
				}
				builder.Append("{");
				string value2 = string.Empty;
				for (int i = 0; i < base.Target.Parameters.Count; i++)
				{
					global::NLog.Targets.MethodCallParameter methodCallParameter = base.Target.Parameters[i];
					builder.Append(value2);
					builder.Append('"');
					builder.Append(methodCallParameter.Name);
					builder.Append("\":");
					this.JsonConverter.SerializeObject(parameterValues[i], builder);
					value2 = ",";
				}
				builder.Append('}');
			}

			// Token: 0x04000556 RID: 1366
			private global::NLog.IJsonConverter _jsonConverter;
		}

		// Token: 0x020001DB RID: 475
		private class HttpPostSoap11Formatter : global::NLog.Targets.WebServiceTarget.HttpPostSoapFormatterBase
		{
			// Token: 0x06001232 RID: 4658 RVA: 0x0002F756 File Offset: 0x0002D956
			public HttpPostSoap11Formatter(global::NLog.Targets.WebServiceTarget target) : base(target)
			{
			}

			// Token: 0x17000360 RID: 864
			// (get) Token: 0x06001233 RID: 4659 RVA: 0x0002F75F File Offset: 0x0002D95F
			protected override string SoapEnvelopeNamespace
			{
				get
				{
					return "http://schemas.xmlsoap.org/soap/envelope/";
				}
			}

			// Token: 0x17000361 RID: 865
			// (get) Token: 0x06001234 RID: 4660 RVA: 0x0002F766 File Offset: 0x0002D966
			protected override string SoapName
			{
				get
				{
					return "soap";
				}
			}

			// Token: 0x06001235 RID: 4661 RVA: 0x0002F770 File Offset: 0x0002D970
			protected override void InitRequest(global::System.Net.HttpWebRequest request)
			{
				base.InitRequest(request);
				string value;
				if (base.Target.Namespace.EndsWith("/", global::System.StringComparison.Ordinal))
				{
					value = base.Target.Namespace + base.Target.MethodName;
				}
				else
				{
					value = base.Target.Namespace + "/" + base.Target.MethodName;
				}
				request.Headers["SOAPAction"] = value;
			}
		}

		// Token: 0x020001DC RID: 476
		private class HttpPostSoap12Formatter : global::NLog.Targets.WebServiceTarget.HttpPostSoapFormatterBase
		{
			// Token: 0x06001236 RID: 4662 RVA: 0x0002F7EC File Offset: 0x0002D9EC
			public HttpPostSoap12Formatter(global::NLog.Targets.WebServiceTarget target) : base(target)
			{
			}

			// Token: 0x17000362 RID: 866
			// (get) Token: 0x06001237 RID: 4663 RVA: 0x0002F7F5 File Offset: 0x0002D9F5
			protected override string SoapEnvelopeNamespace
			{
				get
				{
					return "http://www.w3.org/2003/05/soap-envelope";
				}
			}

			// Token: 0x17000363 RID: 867
			// (get) Token: 0x06001238 RID: 4664 RVA: 0x0002F7FC File Offset: 0x0002D9FC
			protected override string SoapName
			{
				get
				{
					return "soap12";
				}
			}
		}

		// Token: 0x020001DD RID: 477
		private abstract class HttpPostSoapFormatterBase : global::NLog.Targets.WebServiceTarget.HttpPostXmlFormatterBase
		{
			// Token: 0x06001239 RID: 4665 RVA: 0x0002F803 File Offset: 0x0002DA03
			protected HttpPostSoapFormatterBase(global::NLog.Targets.WebServiceTarget target) : base(target)
			{
				this._xmlWriterSettings = new global::System.Xml.XmlWriterSettings
				{
					Encoding = target.Encoding
				};
			}

			// Token: 0x17000364 RID: 868
			// (get) Token: 0x0600123A RID: 4666
			protected abstract string SoapEnvelopeNamespace { get; }

			// Token: 0x17000365 RID: 869
			// (get) Token: 0x0600123B RID: 4667
			protected abstract string SoapName { get; }

			// Token: 0x0600123C RID: 4668 RVA: 0x0002F824 File Offset: 0x0002DA24
			protected override void WriteContent(global::System.IO.MemoryStream ms, object[] parameterValues)
			{
				global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(ms, this._xmlWriterSettings);
				xmlWriter.WriteStartElement(this.SoapName, "Envelope", this.SoapEnvelopeNamespace);
				xmlWriter.WriteStartElement("Body", this.SoapEnvelopeNamespace);
				xmlWriter.WriteStartElement(base.Target.MethodName, base.Target.Namespace);
				base.WriteAllParametersToCurrenElement(xmlWriter, parameterValues);
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndElement();
				xmlWriter.WriteEndElement();
				xmlWriter.Flush();
			}

			// Token: 0x04000557 RID: 1367
			private readonly global::System.Xml.XmlWriterSettings _xmlWriterSettings;
		}

		// Token: 0x020001DE RID: 478
		private abstract class HttpPostTextFormatterBase : global::NLog.Targets.WebServiceTarget.HttpPostFormatterBase
		{
			// Token: 0x0600123D RID: 4669 RVA: 0x0002F8A2 File Offset: 0x0002DAA2
			protected HttpPostTextFormatterBase(global::NLog.Targets.WebServiceTarget target) : base(target)
			{
				this._encodingPreamble = target.Encoding.GetPreamble();
			}

			// Token: 0x0600123E RID: 4670 RVA: 0x0002F8D8 File Offset: 0x0002DAD8
			protected override void WriteContent(global::System.IO.MemoryStream ms, object[] parameterValues)
			{
				global::NLog.Internal.ReusableBuilderCreator reusableStringBuilder = this._reusableStringBuilder;
				lock (reusableStringBuilder)
				{
					using (global::NLog.Internal.ReusableObjectCreator<global::System.Text.StringBuilder>.LockOject lockOject = this._reusableStringBuilder.Allocate())
					{
						this.WriteStringContent(lockOject.Result, parameterValues);
						using (global::NLog.Internal.ReusableObjectCreator<char[]>.LockOject lockOject2 = this._reusableEncodingBuffer.Allocate())
						{
							if (this._encodingPreamble.Length != 0)
							{
								ms.Write(this._encodingPreamble, 0, this._encodingPreamble.Length);
							}
							lockOject.Result.CopyToStream(ms, base.Target.Encoding, lockOject2.Result);
						}
					}
				}
			}

			// Token: 0x0600123F RID: 4671
			protected abstract void WriteStringContent(global::System.Text.StringBuilder builder, object[] parameterValues);

			// Token: 0x04000558 RID: 1368
			private readonly global::NLog.Internal.ReusableBuilderCreator _reusableStringBuilder = new global::NLog.Internal.ReusableBuilderCreator();

			// Token: 0x04000559 RID: 1369
			private readonly global::NLog.Internal.ReusableBufferCreator _reusableEncodingBuffer = new global::NLog.Internal.ReusableBufferCreator(1024);

			// Token: 0x0400055A RID: 1370
			private readonly byte[] _encodingPreamble;
		}

		// Token: 0x020001DF RID: 479
		private class HttpPostXmlDocumentFormatter : global::NLog.Targets.WebServiceTarget.HttpPostXmlFormatterBase
		{
			// Token: 0x17000366 RID: 870
			// (get) Token: 0x06001240 RID: 4672 RVA: 0x0002F9A8 File Offset: 0x0002DBA8
			protected override string ContentType
			{
				get
				{
					return "application/xml";
				}
			}

			// Token: 0x06001241 RID: 4673 RVA: 0x0002F9B0 File Offset: 0x0002DBB0
			public HttpPostXmlDocumentFormatter(global::NLog.Targets.WebServiceTarget target) : base(target)
			{
				if (string.IsNullOrEmpty(target.XmlRoot))
				{
					throw new global::System.InvalidOperationException("WebServiceProtocol.Xml requires WebServiceTarget.XmlRoot to be set.");
				}
				this._xmlWriterSettings = new global::System.Xml.XmlWriterSettings
				{
					Encoding = target.Encoding,
					OmitXmlDeclaration = true,
					Indent = false
				};
			}

			// Token: 0x06001242 RID: 4674 RVA: 0x0002FA04 File Offset: 0x0002DC04
			protected override void WriteContent(global::System.IO.MemoryStream ms, object[] parameterValues)
			{
				global::System.Xml.XmlWriter xmlWriter = global::System.Xml.XmlWriter.Create(ms, this._xmlWriterSettings);
				xmlWriter.WriteStartElement(base.Target.XmlRoot, base.Target.XmlRootNamespace);
				base.WriteAllParametersToCurrenElement(xmlWriter, parameterValues);
				xmlWriter.WriteEndElement();
				xmlWriter.Flush();
			}

			// Token: 0x0400055B RID: 1371
			private readonly global::System.Xml.XmlWriterSettings _xmlWriterSettings;
		}

		// Token: 0x020001E0 RID: 480
		private abstract class HttpPostXmlFormatterBase : global::NLog.Targets.WebServiceTarget.HttpPostFormatterBase
		{
			// Token: 0x06001243 RID: 4675 RVA: 0x0002FA4E File Offset: 0x0002DC4E
			protected HttpPostXmlFormatterBase(global::NLog.Targets.WebServiceTarget target) : base(target)
			{
			}

			// Token: 0x17000367 RID: 871
			// (get) Token: 0x06001244 RID: 4676 RVA: 0x0002FA57 File Offset: 0x0002DC57
			protected override string ContentType
			{
				get
				{
					return "text/xml";
				}
			}

			// Token: 0x06001245 RID: 4677 RVA: 0x0002FA60 File Offset: 0x0002DC60
			protected void WriteAllParametersToCurrenElement(global::System.Xml.XmlWriter currentXmlWriter, object[] parameterValues)
			{
				for (int i = 0; i < base.Target.Parameters.Count; i++)
				{
					string value = global::NLog.Internal.XmlHelper.XmlConvertToStringSafe(parameterValues[i]);
					currentXmlWriter.WriteElementString(base.Target.Parameters[i].Name, value);
				}
			}
		}
	}
}
