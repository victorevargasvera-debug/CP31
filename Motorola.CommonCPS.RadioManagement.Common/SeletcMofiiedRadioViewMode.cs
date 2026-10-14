using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x0200001F RID: 31
	public class SeletcMofiiedRadioViewMode : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000E690 File Offset: 0x0000C890
		// (set) Token: 0x060000BC RID: 188 RVA: 0x0000E740 File Offset: 0x0000C940
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SelectModifiedRadioContext SelectModifiedRadioContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1831677080;
				short num2 = num;
				num = (short)457845912;
				switch (num2 == num)
				{
				}
				num = (short)727580672;
				if (num != 0)
				{
				}
				num = (short)591462400;
				short num3 = num;
				num = (short)1729757185;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)720383641;
				short num2 = num;
				num = (short)1860120217;
				switch (num2 == num)
				{
				}
				num = (short)565313537;
				if (num != 0)
				{
				}
				num = (short)1016528896;
				short num3 = num;
				num = (short)505544704;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000E7F4 File Offset: 0x0000C9F4
		public SeletcMofiiedRadioViewMode(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectModifiedRadioContext context) : base(eventAggregator, commandHandler)
		{
			this.SelectModifiedRadioContext = context;
			this.SelectModifiedRadioContext.SelectedRadios.CollectionChanged += this.a;
			this.c = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.FieldCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.a));
			this.SelectedAllCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object>(new global::System.Action<object>(this.a));
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000E880 File Offset: 0x0000CA80
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)389714993;
			short num2 = num;
			num = (short)610047025;
			switch (num2 == num)
			{
			}
			num = (short)387645441;
			if (num != 0)
			{
			}
			num = (short)1785724928;
			short num3 = num;
			num = (short)27525120;
			if (num != 0)
			{
			}
			this.SelectModifiedRadioCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000E934 File Offset: 0x0000CB34
		private void b()
		{
			short num;
			try
			{
				num = (short)1195245569;
				if (num != 0)
				{
				}
				num = (short)1669678309;
				short num2 = num;
				num = (short)865027301;
				switch (num2 == num)
				{
				}
				num = (short)1963458560;
				if (num != 0)
				{
				}
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1457651712;
			short num3 = num;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000EA04 File Offset: 0x0000CC04
		private void a(object[] A_0)
		{
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
			if ((bool)A_0[2])
			{
				short num = (short)970473017;
				short num2 = num;
				num = (short)1546731065;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1288962049;
					if (num != 0)
					{
					}
					num = (short)1479540736;
					if (num != 0)
					{
					}
					num = (short)1147797504;
					short num3 = num;
					this.SelectModifiedRadioContext.SelectedRadios.Add(item);
					return;
				}
				}
			}
			this.SelectModifiedRadioContext.SelectedRadios.Remove(item);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
		private void a(object A_0)
		{
			short num = (short)1348665344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator;
				object[] array;
				for (;;)
				{
					IL_28:
					bool? flag;
					bool flag2;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> list;
					switch (num2)
					{
					case 0:
						flag = (bool?)A_0;
						flag2 = true;
						num = (short)1511522311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						enumerator = this.SelectModifiedRadioContext.ModifiedRadios.GetEnumerator();
						num = (short)1753677826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_2A6;
					case 3:
						goto IL_350;
					case 4:
						try
						{
							num = (short)1518075908;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_204;
								case 2:
								{
									num = (short)1414940088;
									short num3 = num;
									num = (short)8865208;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)610074624;
										if (num != 0)
										{
										}
										global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)81854467;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uimodelBase = enumerator2.Current;
										this.SelectModifiedRadioContext.SelectedRadios.Add(uimodelBase as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase);
										break;
									}
									}
									num = (short)240386048;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)421396481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_126;
									}
									continue;
								}
								IL_128:
								num = (short)126746626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_126:
								goto IL_128;
							}
							IL_204:
							return;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator2;
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_217;
					case 5:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)22872070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.SelectModifiedRadioContext.SelectedRadios.Clear();
						num = (short)745275395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator2 = list.GetEnumerator();
						num = (short)849543172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)143327233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48B;
					case 8:
						if (array == null)
						{
							num = (short)2046492672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					}
					goto IL_53;
					IL_217:
					bool? flag3 = (bool?)array[0];
					list = (array[1] as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>);
					flag = flag3;
					flag2 = true;
					num = (short)336723973;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2A6:
				try
				{
					num = (short)1293549572;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)494075905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_417;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1212219392;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = enumerator.Current;
							this.SelectModifiedRadioContext.SelectedRadios.Add(item);
							num = (short)1895694338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_38F;
							}
							continue;
						}
						IL_3C3:
						num = (short)1208156163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_38F:
						goto IL_3C3;
					}
					IL_417:
					return;
				}
				finally
				{
					num = (short)591134722;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_488;
						case 1:
							enumerator.Dispose();
							num = (short)889520128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_44F;
							}
							continue;
						}
						IL_44F:
						if (enumerator == null)
						{
							break;
						}
						num = (short)68616193;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_488:;
				}
				goto IL_48B;
				IL_350:
				return;
				IL_48B:
				this.SelectModifiedRadioContext.SelectedRadios.Clear();
				return;
				IL_53:
				array = (A_0 as object[]);
				num = (short)1235746817;
				if (num != 0)
				{
				}
				num = (short)1750007808;
				short num4 = num;
				num = (short)1545863176;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000EFC8 File Offset: 0x0000D1C8
		private bool a()
		{
			short num = (short)420291896;
			short num2 = num;
			num = (short)1713055032;
			switch (num2 == num)
			{
			}
			num = (short)905248769;
			if (num != 0)
			{
			}
			num = (short)456458240;
			short num3 = num;
			num = (short)518651904;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000F074 File Offset: 0x0000D274
		// (set) Token: 0x060000C4 RID: 196 RVA: 0x0000F120 File Offset: 0x0000D320
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> FieldCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1353505195;
				short num2 = num;
				num = (short)152426923;
				switch (num2 == num)
				{
				}
				num = (short)312213504;
				if (num != 0)
				{
				}
				num = (short)295632896;
				short num3 = num;
				num = (short)1194459137;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)814180339;
				short num2 = num;
				num = (short)1936615411;
				switch (num2 == num)
				{
				}
				num = (short)273088513;
				if (num != 0)
				{
				}
				num = (short)840040448;
				short num3 = num;
				num = (short)834338816;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000F1D0 File Offset: 0x0000D3D0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectModifiedRadioCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)193599252;
				short num2 = num;
				num = (short)1085085460;
				switch (num2 == num)
				{
				}
				num = (short)759234561;
				if (num != 0)
				{
				}
				num = (short)363069440;
				short num3 = num;
				num = (short)1561657344;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000F280 File Offset: 0x0000D480
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000F330 File Offset: 0x0000D530
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> SelectedAllCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1588860514;
				short num2 = num;
				num = (short)1917458018;
				switch (num2 == num)
				{
				}
				num = (short)1804140544;
				if (num != 0)
				{
				}
				num = (short)2095054848;
				short num3 = num;
				num = (short)1467547649;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1716583784;
				short num2 = num;
				num = (short)698875240;
				switch (num2 == num)
				{
				}
				num = (short)933298177;
				if (num != 0)
				{
				}
				num = (short)1767833600;
				short num3 = num;
				num = (short)446627840;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x040000A6 RID: 166
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SelectModifiedRadioContext a;

		// Token: 0x040000A7 RID: 167
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> b;

		// Token: 0x040000A8 RID: 168
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x040000A9 RID: 169
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object> d;
	}
}
