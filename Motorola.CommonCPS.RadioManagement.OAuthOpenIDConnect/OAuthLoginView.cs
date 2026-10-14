using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Navigation;
using IdentityModel.OidcClient;
using IdentityModel.OidcClient.Browser;
using Microsoft.CSharp.RuntimeBinder;
using Motorola.Common.LogUtility;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels;
using mshtml;

namespace Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect
{
	// Token: 0x02000004 RID: 4
	public class OAuthLoginView : global::System.Windows.Controls.UserControl, global::IdentityModel.OidcClient.Browser.IBrowser, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002130 File Offset: 0x00000330
		public OAuthLoginView()
		{
			this.InitializeComponent();
			global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel.RaiseOAuthLoginEvent = (global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel.OAuthLoginEvent)global::System.Delegate.Combine(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel.RaiseOAuthLoginEvent, new global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel.OAuthLoginEvent(this.HandleOAuthLoginEvent));
		}

		// Token: 0x17000003 RID: 3
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002174 File Offset: 0x00000374
		[global::System.ComponentModel.Composition.Import]
		public global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel ViewModel
		{
			set
			{
				short num = (short)1547996257;
				short num2 = num;
				num = (short)1941998689;
				switch (num2 == num)
				{
				}
				num = (short)1428750336;
				short num3 = num;
				num = (short)992542721;
				if (num != 0)
				{
				}
				num = (short)502464512;
				if (num != 0)
				{
				}
				base.DataContext = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002224 File Offset: 0x00000424
		public global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext Context
		{
			get
			{
				if (base.DataContext == null)
				{
					short num = (short)202493544;
					short num2 = num;
					num = (short)888524392;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)44695553;
						if (num != 0)
						{
						}
						num = (short)407044096;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)1008205824;
					short num3 = num;
					return null;
				}
				return ((global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel)base.DataContext).OAuthLoginContext;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022F0 File Offset: 0x000004F0
		public void HandleOAuthLoginEvent(global::System.EventArgs e)
		{
			short num = (short)136800696;
			short num2 = num;
			num = (short)796355000;
			switch (num2 == num)
			{
			}
			num = (short)2125266944;
			short num3 = num;
			num = (short)515309568;
			if (num != 0)
			{
			}
			num = (short)2065104897;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.a a;
			a.b = global::System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Create();
			a.c = this;
			a.a = -1;
			a.b.Start<global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.a>(ref a);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000023C4 File Offset: 0x000005C4
		public global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.LoginResult> LaunchOAuthLoginDialog()
		{
			short num = (short)791740417;
			if (num != 0)
			{
			}
			num = (short)1220902487;
			short num2 = num;
			num = (short)270433879;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1609039872;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1068630016;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.b b;
			b.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::IdentityModel.OidcClient.LoginResult>.Create();
			b.c = this;
			b.a = -1;
			b.b.Start<global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.b>(ref b);
			return b.b.Task;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000024A4 File Offset: 0x000006A4
		global::System.Threading.Tasks.Task<global::IdentityModel.OidcClient.Browser.BrowserResult> global::IdentityModel.OidcClient.Browser.IBrowser.InvokeAsync(global::IdentityModel.OidcClient.Browser.BrowserOptions options)
		{
			short num = (short)529470602;
			short num2 = num;
			num = (short)1497502858;
			switch (num2 == num)
			{
			}
			num = (short)1263665152;
			short num3 = num;
			num = (short)576520193;
			if (num != 0)
			{
			}
			num = (short)1727528960;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.d d;
			d.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::IdentityModel.OidcClient.Browser.BrowserResult>.Create();
			d.c = this;
			d.d = options;
			d.a = -1;
			d.b.Start<global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.d>(ref d);
			return d.b.Task;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002590 File Offset: 0x00000790
		private bool a(global::System.Uri A_0)
		{
			short num = (short)1493662738;
			short num2 = num;
			num = (short)1626504210;
			switch (num2 == num)
			{
			}
			num = (short)2049769472;
			short num3 = num;
			num = (short)1503789057;
			if (num != 0)
			{
			}
			num = (short)597164032;
			if (num != 0)
			{
			}
			return A_0.AbsoluteUri.StartsWith(this._options.EndUrl);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002650 File Offset: 0x00000850
		private string b(global::System.Windows.Controls.WebBrowser A_0)
		{
			int a_ = 11;
			global::System.Collections.Generic.IEnumerable<global::mshtml.IHTMLElement> enumerable = ((global::mshtml.IHTMLDocument3)A_0.Document).getElementsByTagName(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("礯簱搳挵氷", a_)).OfType<global::mshtml.IHTMLElement>();
			string text = global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("༯", a_);
			global::System.Collections.Generic.IEnumerator<global::mshtml.IHTMLElement> enumerator = enumerable.GetEnumerator();
			short num;
			try
			{
				num = (short)601423883;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_11C;
					case 1:
						if (global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.f == null)
						{
							num = (short)189267977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28C;
					case 3:
					{
						global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, string> target = global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.f.Target;
						global::System.Runtime.CompilerServices.CallSite f = global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.f;
						if (global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.e == null)
						{
							global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.e = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::System.Linq.Expressions.ExpressionType.AddAssign, typeof(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
							{
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
							}));
						}
						global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object> target2 = global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.e.Target;
						global::System.Runtime.CompilerServices.CallSite e = global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.e;
						string arg = text;
						if (global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.d == null)
						{
							global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.d = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, string, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::System.Linq.Expressions.ExpressionType.Add, typeof(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
							{
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType | global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						global::mshtml.IHTMLElement ihtmlelement;
						text = target(f, target2(e, arg, global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.d.Target(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.d, ihtmlelement.getAttribute(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("䘯匱堳䌵崷", a_), 0), global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("ᘯ", a_))));
						num = (short)836763650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.c == null)
						{
							num = (short)516161546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11C;
					case 5:
					{
						num = (short)1071270142;
						short num3 = num;
						num = (short)64768254;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_272;
						default:
							goto IL_424;
						}
						break;
					}
					case 6:
					{
						global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, string> target3 = global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.c.Target;
						global::System.Runtime.CompilerServices.CallSite c = global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.c;
						if (global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.b == null)
						{
							global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.b = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::System.Linq.Expressions.ExpressionType.AddAssign, typeof(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
							{
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null)
							}));
						}
						global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object> target4 = global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.b.Target;
						global::System.Runtime.CompilerServices.CallSite b = global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.b;
						string arg2 = text;
						if (global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.a == null)
						{
							global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.a = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, string, object>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.BinaryOperation(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.None, global::System.Linq.Expressions.ExpressionType.Add, typeof(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView), new global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo[]
							{
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.None, null),
								global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfo.Create(global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.UseCompileTimeType | global::Microsoft.CSharp.RuntimeBinder.CSharpArgumentInfoFlags.Constant, null)
							}));
						}
						global::mshtml.IHTMLElement ihtmlelement;
						text = target3(c, target4(b, arg2, global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.a.Target(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.a, ihtmlelement.getAttribute(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("帯匱夳匵", a_), 0), global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("യ", a_))));
						num = (short)114688001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_28C;
					case 8:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)71041036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::mshtml.IHTMLElement ihtmlelement = enumerator.Current;
						num = (short)1769275396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.f = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, string>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.Convert(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView)));
						goto IL_272;
					case 10:
						global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView.e.c = global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, string>>.Create(global::Microsoft.CSharp.RuntimeBinder.Binder.Convert(global::Microsoft.CSharp.RuntimeBinder.CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView)));
						num = (short)1251213312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_9D;
						}
						continue;
					case 12:
						num = (short)239075333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9D;
					IL_11C:
					num = (short)120782854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_272:
					num = (short)99418119;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28C:
					num = (short)1463615491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39E:
					num = (short)1826357256;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9D:
					goto IL_39E;
				}
				IL_424:
				num = (short)1305346048;
				if (num != 0)
				{
				}
			}
			finally
			{
				num = (short)1840054273;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1086259202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_46B;
						}
						continue;
					case 2:
						goto IL_4A0;
					}
					IL_46B:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1618804736;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4A0:;
			}
			num = (short)1334444032;
			short num4 = num;
			num = (short)233570305;
			if (num != 0)
			{
			}
			text = text.TrimEnd(new char[]
			{
				'&'
			});
			return text;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002B80 File Offset: 0x00000D80
		private bool a(global::System.Threading.SemaphoreSlim A_0)
		{
			int num;
			bool result;
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
						A_0.Release();
						result = true;
						num2 = (short)243269634;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						num2 = (short)527892481;
						if (num2 != 0)
						{
						}
						if (!A_0.Wait(0))
						{
							num2 = (short)162004992;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
						goto IL_9B;
					}
					goto IL_1C;
				}
				IL_9B:
				num2 = (short)513264831;
				short num3 = num2;
				num2 = (short)93506751;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1E;
				case 1:
					break;
				default:
				{
					num2 = (short)1371013120;
					short num4 = num2;
					break;
				}
				}
				num2 = (short)1760100352;
				if (num2 != 0)
				{
				}
				return result;
			}
			}
			IL_1C:
			result = false;
			IL_1E:
			num2 = (short)1443495937;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002CA0 File Offset: 0x00000EA0
		private void a(global::System.Windows.Controls.WebBrowser A_0)
		{
			int a_ = 11;
			short num2;
			try
			{
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					int num;
					global::System.Reflection.FieldInfo field;
					for (;;)
					{
						IL_13:
						switch (num)
						{
						case 0:
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(string.Format(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("支就唳吵吷弹᰻䨽⼿扁㝃㍅㡇㩉㹋⭍⍏⅑瑓♕㥗㵙㥛繝፟šᙣཥᡧṩ䱫୭ɯq᭳ѵ୷婹养幽흿쒅慎ﮋﶍ뒓힕ﮗ얟瑱蒣잧쒩\ud8ab\udcad\udfaf\udeb1钳\ud8b5ힷ캹鲻\ud8bd꾿럁꫃ꋅ", a_), global::System.Array.Empty<object>()), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							num2 = (short)1988231174;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							goto IL_1FD;
						case 2:
						{
							if (field == null)
							{
								num2 = (short)2058158080;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							object value = field.GetValue(A_0);
							num2 = (short)1566638084;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 3:
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(string.Format(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("支就唳吵吷弹᰻䨽⼿扁㝃㍅㡇㩉㹋⭍⍏⅑瑓♕㥗㵙㥛繝፟šᙣཥᡧṩ䱫୭ɯq᭳ѵ୷婹养幽흿쒅慎ﮋﶍ뒓힕ﮗ얟瑱蒣잧쒩\ud8ab\udcad\udfaf\udeb1钳\ud8b5ힷ캹鲻춽ꖿ뛁", a_), global::System.Array.Empty<object>()), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							num2 = (short)1606811653;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 4:
						{
							object value;
							if (value == null)
							{
								num2 = (short)2136211459;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							value.GetType().InvokeMember(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("振嬱堳匵嘷丹", a_), global::System.Reflection.BindingFlags.SetProperty, null, value, new object[]
							{
								true
							});
							num2 = (short)2058747905;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						case 5:
							goto IL_C5;
						case 6:
							goto IL_1B4;
						}
						goto IL_35;
					}
					IL_C5:
					num2 = (short)1177302489;
					short num3 = num2;
					num2 = (short)213333465;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_FB;
					}
					IL_35:
					field = typeof(global::System.Windows.Controls.WebBrowser).GetField(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("漯匱䰳缵漷弹帻簽㈿ⵁ㍃㕅ⵇ㡉繋", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic);
					num2 = (short)1009385474;
					num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				IL_FB:
				num2 = (short)19595265;
				if (num2 != 0)
				{
				}
				num2 = (short)1821769728;
				if (num2 != 0)
				{
				}
				IL_1B4:
				IL_1FD:;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(string.Format(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("甯䀱䘳夵䨷ᨹ伻䬽〿㉁㙃⍅㭇㥉╋⁍㝏牑⑓㝕㽗㽙籛ⵝ͟ၡൣᙥᱧ䩩५ᱭɯᵱٳյ䉷婹ݻ乽ﵿ", a_), ex.Message), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
			}
			num2 = (short)425852928;
			short num4 = num2;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002F14 File Offset: 0x00001114
		private void a(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int num;
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
					{
						global::System.EventArgs e = new global::System.EventArgs();
						global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel.RaiseOAuthLoginEvent(e);
						num2 = (short)1101791234;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						num2 = (short)1679360001;
						if (num2 != 0)
						{
						}
						if (global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginViewModel.RaiseOAuthLoginEvent != null)
						{
							num2 = (short)414515200;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
						goto IL_125;
					}
					goto IL_1C;
				}
				IL_125:
				num2 = (short)576755162;
				short num3 = num2;
				num2 = (short)1211536858;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_9A;
				case 1:
					break;
				default:
				{
					num2 = (short)1656815616;
					short num4 = num2;
					break;
				}
				}
				num2 = (short)763101184;
				if (num2 != 0)
				{
				}
				return;
			}
			}
			IL_1C:
			this.UserControlWindow = global::System.Windows.Window.GetWindow(this);
			this.UserControlWindow.Topmost = true;
			this.UserControlWindow.Activate();
			this.UserControlWindow.Topmost = false;
			this.UserControlWindow.ShowInTaskbar = true;
			this.UserControlWindow.ResizeMode = global::System.Windows.ResizeMode.CanResizeWithGrip;
			base.Width = global::System.Windows.SystemParameters.PrimaryScreenWidth * 0.8;
			base.Height = global::System.Windows.SystemParameters.PrimaryScreenHeight * 0.8;
			this.UserControlWindow.WindowStartupLocation = global::System.Windows.WindowStartupLocation.CenterScreen;
			IL_9A:
			num2 = (short)1948385281;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000030BC File Offset: 0x000012BC
		private void a(object A_0, global::System.Windows.SizeChangedEventArgs A_1)
		{
			short num = (short)1776091136;
			short num2 = num;
			num = (short)2023476214;
			short num3 = num;
			num = (short)1551223798;
			switch (num3 == num)
			{
			}
			num = (short)432996353;
			if (num != 0)
			{
			}
			num = (short)226623488;
			if (num != 0)
			{
			}
			base.Width = this.UserControlWindow.ActualWidth;
			base.Height = this.UserControlWindow.ActualHeight;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00003188 File Offset: 0x00001388
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 4;
			short num = (short)979757909;
			short num2 = num;
			num = (short)1011739477;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B1;
			case 1:
				break;
			default:
			{
				num = (short)515833856;
				short num3 = num;
				break;
			}
			}
			num = (short)450428929;
			if (num != 0)
			{
			}
			num = (short)1525350400;
			if (num != 0)
			{
			}
			if (this._contentLoaded)
			{
				return;
			}
			IL_B1:
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("ب昪䈬嬮帰䄲娴嬶堸ᔺ縼倾ⱀ⹂⩄⥆ੈᭊṌ慎͐㉒ㅔ㹖㙘ᙚ㱜ㅞ`Ѣd੦౨ժᥬ䅮㹰㉲tͶᅸ㑺ർ᩾쪂솄쒆꺔쾠욢쮤펦蚨쒪첬\udaae얰\udbb2\ud9b4\ud8b6\udeb8튺펼즾ꣀꛂ닄ꛈ꫊료믎말뿒뫔냖냘뗚ꯜ뛞蓠铢쯤鿦裨蛪臬", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000326C File Offset: 0x0000146C
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1282408448;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)612433920;
				short num3 = num;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 1:
					num = (short)659030018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_D7;
				case 3:
					goto IL_A6;
				case 4:
				{
					if (connectionId == 2)
					{
						goto IL_15E;
					}
					num = (short)1152755837;
					short num4 = num;
					num = (short)1327409277;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A6;
					default:
						num = (short)2019950592;
						if (num != 0)
						{
						}
						num = (short)1839529985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_63:
				if (connectionId != 1)
				{
					num = (short)1740636161;
					if (num != 0)
					{
					}
					num = (short)970850307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A6:
				num = (short)1653342212;
				num2 = (int)((global::System.IntPtr)num);
			}
			((global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView)target).Loaded += this.a;
			return;
			IL_D7:
			this._contentLoaded = true;
			return;
			IL_15E:
			this.browserContainer = (global::System.Windows.Controls.ContentControl)target;
		}

		// Token: 0x04000003 RID: 3
		private global::IdentityModel.OidcClient.LoginResult loginResult;

		// Token: 0x04000004 RID: 4
		private global::IdentityModel.OidcClient.Browser.BrowserOptions _options;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Window UserControlWindow;

		// Token: 0x04000006 RID: 6
		private string _startUrl = string.Empty;

		// Token: 0x04000007 RID: 7
		internal global::System.Windows.Controls.ContentControl browserContainer;

		// Token: 0x04000008 RID: 8
		private bool _contentLoaded;

		// Token: 0x02000007 RID: 7
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x06000018 RID: 24 RVA: 0x00003FF0 File Offset: 0x000021F0
			internal void e(object A_0, global::System.Windows.Navigation.NavigatingCancelEventArgs A_1)
			{
				int a_ = 8;
				this.a.a((global::System.Windows.Controls.WebBrowser)A_0);
				short num;
				if (this.a.a(A_1.Uri))
				{
					num = (short)531365888;
					short num2 = num;
					num = (short)1613465440;
					short num3 = num;
					num = (short)1138001760;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1824915456;
						if (num != 0)
						{
						}
						try
						{
							global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.NativeMethods.EnableCloseWndButton(this.a.UserControlWindow, false);
							A_1.Cancel = true;
							string response = this.a.b(this.b);
							this.c = new global::IdentityModel.OidcClient.Browser.BrowserResult
							{
								ResultType = global::IdentityModel.OidcClient.Browser.BrowserResultType.Success,
								Response = response
							};
							this.a.a(this.d);
						}
						catch (global::System.Exception ex)
						{
							global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(string.Format(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("栬崮䌰尲䜴᜶䬸帺䤼䴾⡀♂㍄⹆❈ⱊ浌㩎≐㙒❔灖⩘筚㑜ㅞݠౢᝤ੦ࡨὪѬnὰ卲፴նᙸᙺ嵼୾ꖄ캆ﮎ랖쪘ﺚ쒠톢龤螦튨鮪킬", a_), ex.Message), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
							this.c = new global::IdentityModel.OidcClient.Browser.BrowserResult
							{
								ResultType = global::IdentityModel.OidcClient.Browser.BrowserResultType.UnknownError
							};
							this.a.Context.LoginResult = global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginResult.Error;
							this.a.UserControlWindow.Close();
						}
						break;
					}
				}
				num = (short)1875574785;
				if (num != 0)
				{
				}
			}

			// Token: 0x06000019 RID: 25 RVA: 0x00004188 File Offset: 0x00002388
			internal void e(object A_0, global::System.ComponentModel.CancelEventArgs A_1)
			{
				int a_ = 14;
				short num2;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_29;
					}
					int num;
					for (;;)
					{
						IL_13:
						switch (num)
						{
						case 0:
						{
							num2 = (short)1609565174;
							short num3 = num2;
							num2 = (short)1345324022;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_7B;
							default:
								num2 = (short)1153630208;
								if (num2 != 0)
								{
								}
								goto IL_E8;
							}
							break;
						}
						case 1:
							goto IL_7B;
						case 2:
							goto IL_100;
						case 3:
							if (this.a.Context.LoginResult == global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginResult.None)
							{
								num2 = (short)1912078337;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_E8;
						}
						goto IL_29;
						IL_7B:
						A_1.Cancel = true;
						num2 = (short)1959526400;
						num = (int)((global::System.IntPtr)num2);
						continue;
						IL_E8:
						num2 = (short)1878786050;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_100:
					goto IL_124;
					IL_29:
					this.a.a(this.d);
					num2 = (short)497614851;
					num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.LogInfoToFilenEvent(string.Format(global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.SelectAgencyViewModel.b("瘲䜴䔶嘸䤺ᴼ尾ⵀⱂ㙄⹆❈ⱊ浌⍎㹐㑒㱔㥖祘㽚㑜㹞ൠౢɤ䝦Ṩɪͬ୮ṰѲ佴坶ɸ䭺|", a_), ex.Message), global::Motorola.Common.LogUtility.LoggingLevel.EventInfo);
				}
				IL_124:
				num2 = (short)2140340225;
				if (num2 != 0)
				{
				}
				num2 = (short)813891584;
				short num4 = num2;
			}

			// Token: 0x04000011 RID: 17
			public global::Motorola.CommonCPS.RadioManagement.OAuthOpenIDConnect.OAuthLoginView a;

			// Token: 0x04000012 RID: 18
			public global::System.Windows.Controls.WebBrowser b;

			// Token: 0x04000013 RID: 19
			public global::IdentityModel.OidcClient.Browser.BrowserResult c;

			// Token: 0x04000014 RID: 20
			public global::System.Threading.SemaphoreSlim d;
		}

		// Token: 0x02000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static class e
		{
			// Token: 0x0400001B RID: 27
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, string, object>> a;

			// Token: 0x0400001C RID: 28
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object>> b;

			// Token: 0x0400001D RID: 29
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, string>> c;

			// Token: 0x0400001E RID: 30
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, string, object>> d;

			// Token: 0x0400001F RID: 31
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, string, object, object>> e;

			// Token: 0x04000020 RID: 32
			public static global::System.Runtime.CompilerServices.CallSite<global::System.Func<global::System.Runtime.CompilerServices.CallSite, object, string>> f;
		}
	}
}
