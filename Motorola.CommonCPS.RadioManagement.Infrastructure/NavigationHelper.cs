using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x0200003A RID: 58
	public static class NavigationHelper
	{
		// Token: 0x06000162 RID: 354 RVA: 0x00014BCC File Offset: 0x00012DCC
		static NavigationHelper()
		{
			short num = (short)99549184;
			short num2 = num;
			num = (short)400773032;
			short num3 = num;
			num = (short)507465640;
			switch (num3 == num)
			{
			}
			num = (short)639959041;
			if (num != 0)
			{
			}
			num = (short)697106432;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.a = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>();
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00014C88 File Offset: 0x00012E88
		public static void AppendInfoToNavigationPath(string info)
		{
			short num = (short)705626112;
			short num2 = num;
			num = (short)1302570571;
			short num3 = num;
			num = (short)1356441163;
			switch (num3 == num)
			{
			}
			num = (short)23724033;
			if (num != 0)
			{
			}
			num = (short)1742667776;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.a a = new global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.a();
			a.a = info;
			global::System.Windows.Application.Current.Dispatcher.BeginInvoke(new global::System.Action(a.b), global::System.Array.Empty<object>());
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00014D64 File Offset: 0x00012F64
		public static void Go(string viewName)
		{
			short num = (short)256507904;
			short num2 = num;
			num = (short)609430987;
			short num3 = num;
			num = (short)1391865291;
			switch (num3 == num)
			{
			}
			num = (short)2119368704;
			if (num != 0)
			{
			}
			num = (short)886046721;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(string.Empty, viewName);
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00014E18 File Offset: 0x00013018
		public static void Go(string moduleName, string viewName)
		{
			short num = (short)1916600320;
			short num2 = num;
			num = (short)1478122415;
			short num3 = num;
			num = (short)2033933231;
			switch (num3 == num)
			{
			}
			num = (short)1880817665;
			if (num != 0)
			{
			}
			num = (short)1166082048;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(moduleName, viewName, null);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00014EC8 File Offset: 0x000130C8
		public static void Go(string viewName, global::System.Collections.Generic.List<string> parameters)
		{
			short num = (short)516161536;
			short num2 = num;
			num = (short)721173918;
			short num3 = num;
			num = (short)2141994398;
			switch (num3 == num)
			{
			}
			num = (short)1103560704;
			if (num != 0)
			{
			}
			num = (short)639434753;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(string.Empty, viewName, parameters);
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00014F7C File Offset: 0x0001317C
		public static void Go(string moduleName, string viewName, global::System.Collections.Generic.List<string> parameters)
		{
			int a_ = 10;
			short num = (short)1404239872;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				string str;
				global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor waitCursor;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.List<string>.Enumerator enumerator;
					global::System.Text.StringBuilder stringBuilder;
					switch (num2)
					{
					case 0:
						if (parameters != null)
						{
							num = (short)316080130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC;
					case 1:
						goto IL_AC;
					case 2:
					{
						num = (short)1163591680;
						short num3 = num;
						goto IL_216;
					}
					case 3:
						goto IL_CC;
					case 4:
						try
						{
							num = (short)581173248;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_149;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1776746499;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string value = enumerator.Current;
									stringBuilder.Append(global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("С", a_));
									stringBuilder.Append(value);
									num = (short)503775233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)344981508;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1D9;
								}
								IL_14B:
								num = (short)612106242;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_149:
								goto IL_14B;
							}
							IL_1D9:
							goto IL_D1;
						}
						finally
						{
							num = (short)674627585;
							if (num != 0)
							{
							}
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_216;
						IL_D1:
						str = global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxies.CompositeCommand.CompositeCommandBuilderFactory.b("ᴡ", a_) + stringBuilder.ToString(1, stringBuilder.Length - 1);
						num = (short)483721217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B;
					IL_AC:
					waitCursor = new global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor();
					num = (short)537526275;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_216:
					stringBuilder = new global::System.Text.StringBuilder();
					enumerator = parameters.GetEnumerator();
					num = (short)979369988;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_CC:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_26D;
					}
					for (;;)
					{
						IL_24A:
						switch (num2)
						{
						case 0:
							if (!string.IsNullOrEmpty(moduleName))
							{
								num = (short)402194436;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2E7;
						case 1:
							global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.NavigateToViewRequestedEvent>().Publish(viewName + str);
							num = (short)1365704707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_2E7;
						case 3:
							goto IL_3A3;
						case 4:
						{
							global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.NavigateToMainModuleRequestedEvent>().Publish(moduleName + str);
							num = (short)1553624979;
							short num4 = num;
							num = (short)1222995859;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)220790784;
								if (num != 0)
								{
								}
								num = (short)170459138;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							if (!string.IsNullOrEmpty(viewName))
							{
								num = (short)1770127361;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3A3;
						case 6:
							goto IL_3BB;
						}
						goto IL_26D;
						IL_2E7:
						num = (short)652935173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3A3:
						num = (short)2073755654;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3BB:
					return;
					IL_26D:
					global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.FocusMainModuleRequestedEvent>().Publish(null);
					num = (short)1291255808;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_24A;
				}
				finally
				{
					num = (short)398852096;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_3EF;
							}
							continue;
						case 1:
							((global::System.IDisposable)waitCursor).Dispose();
							num = (short)84672514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_427;
						}
						IL_3EF:
						if (waitCursor == null)
						{
							break;
						}
						num = (short)1146028033;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_427:;
				}
				return;
				IL_4B:
				str = string.Empty;
				num = (short)792854528;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000153E8 File Offset: 0x000135E8
		public static void UpdateNavigationPath(global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> pathSections)
		{
			short num = (short)1447886848;
			short num2 = num;
			num = (short)1530453471;
			short num3 = num;
			num = (short)242736607;
			switch (num3 == num)
			{
			}
			num = (short)1632960513;
			if (num != 0)
			{
			}
			num = (short)2137325568;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.UpdateNavigationPathRequestedEvent>().Publish(pathSections);
		}

		// Token: 0x0400009C RID: 156
		private static global::Microsoft.Practices.Prism.Events.IEventAggregator a;

		// Token: 0x0200003B RID: 59
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600016A RID: 362 RVA: 0x000154B4 File Offset: 0x000136B4
			internal void b()
			{
				short num = (short)2037776384;
				short num2 = num;
				num = (short)1135491669;
				short num3 = num;
				num = (short)948517461;
				switch (num3 == num)
				{
				}
				num = (short)1376845825;
				if (num != 0)
				{
				}
				num = (short)1222115328;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.a.GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.AppendInfoToNavigationPathRequestedEvent>().Publish(this.a);
			}

			// Token: 0x0400009D RID: 157
			public string a;
		}
	}
}
