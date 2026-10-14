using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000047 RID: 71
	public abstract class PopoupViewModelBase : global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification, global::System.ComponentModel.INotifyPropertyChanged, global::Motorola.CommonCPS.RadioManagement.Infrastructure.IPopupWindowActionAware
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0001B0E0 File Offset: 0x000192E0
		public bool SetFocusOnFirstTextControl
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1331473801;
				short num2 = num;
				num = (short)1130343817;
				switch (num2 == num)
				{
				default:
				{
					num = (short)72679424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)641794049;
				if (num != 0)
				{
				}
				num = (short)563609600;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0001B18C File Offset: 0x0001938C
		protected PopoupViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator)
		{
			this.b = eventAggregator;
			this.d = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.Close));
			this.e = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.Search));
			eventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PopupWindowClosedEvent>().Subscribe(new global::System.Action<string>(this.a));
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0001B1F8 File Offset: 0x000193F8
		protected PopoupViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler) : this(eventAggregator)
		{
			this.c = commandHandler;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0001B214 File Offset: 0x00019414
		protected PopoupViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, bool setFocusOnFirstTextControl) : this(eventAggregator, commandHandler)
		{
			this.a = setFocusOnFirstTextControl;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0001B230 File Offset: 0x00019430
		private void a(string A_0)
		{
			string[] array = this.a();
			if (!array[array.Length - 1].StartsWith(A_0, global::System.StringComparison.Ordinal))
			{
				short num = (short)2025062401;
				if (num != 0)
				{
				}
				num = (short)1577844736;
				short num2 = num;
				num = (short)365714095;
				short num3 = num;
				num = (short)1262967471;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)861405184;
					if (num != 0)
					{
					}
					return;
				}
			}
			this.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.PopupWindowClosedEvent>().Unsubscribe(new global::System.Action<string>(this.a));
			this.OnWindowClosed();
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0001B318 File Offset: 0x00019518
		protected global::Microsoft.Practices.Prism.Events.IEventAggregator EventAggregator
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)263279214;
				short num2 = num;
				num = (short)773018222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)199098368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1771962369;
				if (num != 0)
				{
				}
				num = (short)280166400;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0001B3C8 File Offset: 0x000195C8
		protected global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler CommandHandler
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1801134797;
				short num2 = num;
				num = (short)1272193741;
				switch (num2 == num)
				{
				default:
				{
					num = (short)403439616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)554565633;
				if (num != 0)
				{
				}
				num = (short)12451840;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0001B478 File Offset: 0x00019678
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CloseCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)831229824;
				short num2 = num;
				num = (short)1064996736;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1172570112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)446824449;
				if (num != 0)
				{
				}
				num = (short)1995374592;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0001B528 File Offset: 0x00019728
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> SearchCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1277296641;
				if (num != 0)
				{
				}
				num = (short)1804402688;
				short num2 = num;
				num = (short)719980331;
				short num3 = num;
				num = (short)320603947;
				switch (num3 == num)
				{
				}
				num = (short)1104084992;
				if (num != 0)
				{
				}
				return this.e;
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x0001B5DC File Offset: 0x000197DC
		protected virtual void Close()
		{
			short num = (short)1770314875;
			short num2 = num;
			num = (short)1570495611;
			switch (num2 == num)
			{
			default:
			{
				num = (short)860946432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1637351425;
			if (num != 0)
			{
			}
			num = (short)2099052544;
			if (num != 0)
			{
			}
			string[] array = this.a();
			this.EventAggregator.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ClosePopupWindowRequestedEvent>().Publish(array[array.Length - 1]);
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0001B6A4 File Offset: 0x000198A4
		protected virtual void OnWindowClosed()
		{
			short num = (short)1477115904;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				int num6;
				global::System.Reflection.PropertyInfo[] properties2;
				for (;;)
				{
					IL_28:
					int num4;
					global::System.Reflection.PropertyInfo propertyInfo2;
					switch (num2)
					{
					case 0:
					{
						num = (short)973275137;
						if (num != 0)
						{
						}
						num = (short)1187190435;
						short num3 = num;
						num = (short)777655971;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B5;
						default:
							goto IL_328;
						}
						break;
					}
					case 1:
						return;
					case 2:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase obj = propertyInfo.GetValue(this) as global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase;
						global::System.Reflection.PropertyInfo[] properties = propertyInfo.PropertyType.GetProperties();
						num4 = 0;
						num = (short)754450441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_226;
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase obj;
						global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache = propertyInfo2.GetValue(obj) as global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache;
						if (viewCache == null)
						{
							num = (short)471072771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						viewCache.Close();
						num = (short)1029832709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_226;
					case 6:
					{
						global::System.Reflection.PropertyInfo[] properties;
						if (num4 >= properties.Length)
						{
							num = (short)1837236225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						propertyInfo2 = properties[num4];
						num = (short)1460338699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_291;
					case 8:
					{
						num = (short)503119872;
						short num5 = num;
						goto IL_192;
					}
					case 9:
						goto IL_192;
					case 10:
					{
						if (num6 >= properties2.Length)
						{
							num = (short)2024079360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Reflection.PropertyInfo propertyInfo = properties2[num6];
						num = (short)1376780301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_B5;
					case 12:
						goto IL_291;
					case 13:
					{
						global::System.Reflection.PropertyInfo propertyInfo;
						if (propertyInfo.PropertyType.IsSubclassOf(typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase)))
						{
							num = (short)1205862402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6++;
						num = (short)2003042311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)820576260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6B;
					IL_B5:
					if (typeof(global::System.Collections.ICollection).IsAssignableFrom(propertyInfo2.PropertyType))
					{
						num = (short)837353486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_226;
					IL_192:
					num = (short)513998854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_226:
					num4++;
					num = (short)1460142088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_291:
					num = (short)1883897866;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_328:
				num = (short)1130299392;
				if (num != 0)
				{
				}
				return;
				IL_6B:
				properties2 = base.GetType().GetProperties();
				num6 = 0;
				num = (short)815464460;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0001B9F4 File Offset: 0x00019BF4
		protected virtual void Search(object[] para)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			short num;
			string text;
			for (;;)
			{
				IL_13:
				num = (short)1052573697;
				if (num != 0)
				{
				}
				int num2;
				switch (num2)
				{
				case 0:
					goto IL_122;
				case 1:
					text = text.Substring(0, text.Length - global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䬜瘞䐠吢栤䠦䴨个䄬", a_).Length);
					num = (short)240189440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_B9;
				}
				goto IL_4C;
			}
			IL_122:
			goto IL_124;
			IL_4C:
			num = (short)462795738;
			short num3 = num;
			num = (short)455979994;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B9:
				if (text.EndsWith(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䬜瘞䐠吢栤䠦䴨个䄬", a_), global::System.StringComparison.Ordinal))
				{
					num = (short)1073676289;
					int num2 = (int)((global::System.IntPtr)num);
					goto IL_13;
				}
				break;
			default:
			{
				num = (short)1847001088;
				if (num != 0)
				{
				}
				text = this.a().Last<string>();
				num = (short)589234178;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			}
			IL_124:
			num = (short)237043712;
			short num4 = num;
			object[] paras = para.Concat(new string[]
			{
				text
			}).ToArray<object>();
			this.CommandHandler.FilterCommand.Execute(paras);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0001BB78 File Offset: 0x00019D78
		private string[] a()
		{
			int a_ = 17;
			if (this.ToString().IndexOf(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䤨ᨪ", a_), global::System.StringComparison.Ordinal) > 0)
			{
				short num = (short)1705118298;
				short num2 = num;
				num = (short)1374489178;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_FE;
				case 1:
					break;
				default:
				{
					num = (short)1033568256;
					short num3 = num;
					break;
				}
				}
				num = (short)1081933825;
				if (num != 0)
				{
				}
				num = (short)192020480;
				if (num != 0)
				{
				}
				return this.ToString().Substring(0, this.ToString().IndexOf(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("䤨ᨪ", a_), global::System.StringComparison.Ordinal)).Split(new char[]
				{
					'.'
				});
			}
			IL_FE:
			return this.ToString().Split(new char[]
			{
				'.'
			});
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0001BC9C File Offset: 0x00019E9C
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x0001BD4C File Offset: 0x00019F4C
		public global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification Notification
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)4019282;
				short num2 = num;
				num = (short)1039619154;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1031864320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1852768257;
				if (num != 0)
				{
				}
				num = (short)130285568;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)395238220;
				short num2 = num;
				num = (short)679861068;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1048051712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1502543872;
				if (num != 0)
				{
				}
				num = (short)972554241;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0001BDFC File Offset: 0x00019FFC
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0001BEB4 File Offset: 0x0001A0B4
		public global::System.Windows.Window Window
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1434910677;
				short num2 = num;
				num = (short)1448280021;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2125266944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)623640577;
				if (num != 0)
				{
				}
				num = (short)1283063808;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1662579826;
				short num2 = num;
				num = (short)1825043570;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1480130560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)915668993;
				if (num != 0)
				{
				}
				num = (short)647233536;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060001EB RID: 491 RVA: 0x0001BF68 File Offset: 0x0001A168
		// (remove) Token: 0x060001EC RID: 492 RVA: 0x0001C09C File Offset: 0x0001A29C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_FA;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)896270336;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_82;
					case 2:
						goto IL_80;
					}
					goto IL_1C;
				}
				IL_FA:
				num2 = (short)889651200;
				short num3 = num2;
				return;
				IL_1C:
				num2 = (short)1013276346;
				short num4 = num2;
				num2 = (short)1133469370;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_80:
					break;
				default:
					num2 = (short)2949120;
					if (num2 != 0)
					{
					}
					propertyChangedEventHandler = this.h;
					num2 = (short)1288175618;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_82:
				num2 = (short)775094273;
				if (num2 != 0)
				{
				}
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.h, value2, propertyChangedEventHandler2);
				num2 = (short)119734273;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_102;
					case 1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)2136932352;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B1;
					case 2:
						goto IL_AF;
					}
					goto IL_1C;
				}
				IL_102:
				num2 = (short)228458496;
				short num3 = num2;
				return;
				IL_1C:
				num2 = (short)1300185654;
				short num4 = num2;
				num2 = (short)1443381814;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_AF:
					break;
				default:
					num2 = (short)320733185;
					if (num2 != 0)
					{
					}
					num2 = (short)1163132928;
					if (num2 != 0)
					{
					}
					propertyChangedEventHandler = this.h;
					num2 = (short)1518272514;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_B1:
				propertyChangedEventHandler2 = propertyChangedEventHandler;
				global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
				propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.h, value2, propertyChangedEventHandler2);
				num2 = (short)1994653697;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0001C1D8 File Offset: 0x0001A3D8
		protected virtual void OnPropertyChanged([global::System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
		{
			short num = (short)510132225;
			if (num != 0)
			{
			}
			num = (short)683540480;
			short num2 = num;
			num = (short)443964788;
			short num3 = num;
			num = (short)148135284;
			switch (num3 == num)
			{
			}
			num = (short)1764884480;
			if (num != 0)
			{
			}
			global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.h;
			if (propertyChangedEventHandler == null)
			{
				return;
			}
			propertyChangedEventHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
		}

		// Token: 0x040000D1 RID: 209
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly bool a = true;

		// Token: 0x040000D2 RID: 210
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Events.IEventAggregator b;

		// Token: 0x040000D3 RID: 211
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler c;

		// Token: 0x040000D4 RID: 212
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand d;

		// Token: 0x040000D5 RID: 213
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> e;

		// Token: 0x040000D6 RID: 214
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Interactivity.InteractionRequest.Notification f;

		// Token: 0x040000D7 RID: 215
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Windows.Window g;

		// Token: 0x040000D8 RID: 216
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler h;
	}
}
