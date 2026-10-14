using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Controls;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.RadioLicense
{
	// Token: 0x02000014 RID: 20
	public class RegisterLicenseViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x0000B12C File Offset: 0x0000932C
		public RegisterLicenseViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registRadioLicenseContext, int ftype = 0) : base(eventAggregator, commandHandler)
		{
			this.RegistRadioLicenseContext = registRadioLicenseContext;
			this.RegistRadioLicenseContext.PropertyChanged += this.a;
			this.AddRadiosCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.o), new global::System.Func<bool>(this.g));
			this.AddAllRadiosCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.n), new global::System.Func<bool>(this.f));
			this.AvailableSelectionChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>>(new global::System.Action<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>>(this.b));
			this.ClearAllEIDHistroyCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.m), new global::System.Func<bool>(this.e));
			this.FieldCheckChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.a));
			this.QueryEIDCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.l), new global::System.Func<bool>(this.d));
			this.RegisterRadioLicenseCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.k), new global::System.Func<bool>(this.c));
			this.RemoveRadiosCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.j), new global::System.Func<bool>(this.b));
			this.RemoveAllRadiosCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.i), new global::System.Func<bool>(this.a));
			this.SelectedSelectionChangedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>>(new global::System.Action<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>>(this.a));
			this.SelectedGroupChangedCommad = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>(this.b), new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Group, bool>(this.a));
			this.RegistRadioLicenseContext.AvailableDevices.CollectionChanged += this.b;
			this.RegistRadioLicenseContext.SelectedDevices.CollectionChanged += this.a;
			this.RegistRadioLicenseContext.EidSelectChanaged += this.a;
			this.a = ftype;
			this.h();
			this.RegistRadioLicenseContext.OKCommandExecuted = false;
			this.RegistRadioLicenseContext.CancelCommandExecuted = false;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000B334 File Offset: 0x00009534
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail A_0)
		{
			short num = (short)871432192;
			short num2 = num;
			num = (short)2081032910;
			short num3 = num;
			num = (short)223611598;
			switch (num3 == num)
			{
			}
			num = (short)761462784;
			if (num != 0)
			{
			}
			num = (short)787677185;
			if (num != 0)
			{
			}
			this.ClearAllEIDHistroyCommand.RaiseCanExecuteChanged();
			this.RegisterRadioLicenseCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000B3F4 File Offset: 0x000095F4
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000B4A4 File Offset: 0x000096A4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext RegistRadioLicenseContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)88735744;
				short num2 = num;
				num = (short)643728521;
				short num3 = num;
				num = (short)1780384905;
				switch (num3 == num)
				{
				}
				num = (short)218431488;
				if (num != 0)
				{
				}
				num = (short)738852865;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1859518464;
				short num2 = num;
				num = (short)1210449921;
				if (num != 0)
				{
				}
				num = (short)1506637704;
				short num3 = num;
				num = (short)2098100104;
				switch (num3 == num)
				{
				}
				num = (short)173932544;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000B554 File Offset: 0x00009754
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0000B604 File Offset: 0x00009804
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand AddRadiosCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)560988160;
				short num2 = num;
				num = (short)919812611;
				short num3 = num;
				num = (short)2025273859;
				switch (num3 == num)
				{
				}
				num = (short)734658561;
				if (num != 0)
				{
				}
				num = (short)912392192;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1460994048;
				short num2 = num;
				num = (short)602865665;
				if (num != 0)
				{
				}
				num = (short)1677318414;
				short num3 = num;
				num = (short)1227217166;
				switch (num3 == num)
				{
				}
				num = (short)1903362048;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x0000B6B4 File Offset: 0x000098B4
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x0000B764 File Offset: 0x00009964
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand AddAllRadiosCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1182793728;
				short num2 = num;
				num = (short)1290101861;
				short num3 = num;
				num = (short)182543461;
				switch (num3 == num)
				{
				}
				num = (short)812318720;
				if (num != 0)
				{
				}
				num = (short)1863647233;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)701104128;
				short num2 = num;
				num = (short)1879035535;
				short num3 = num;
				num = (short)1890832015;
				switch (num3 == num)
				{
				}
				num = (short)119537665;
				if (num != 0)
				{
				}
				num = (short)1250820096;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x0000B810 File Offset: 0x00009A10
		// (set) Token: 0x060000AA RID: 170 RVA: 0x0000B8C0 File Offset: 0x00009AC0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>> AvailableSelectionChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1873149952;
				short num2 = num;
				num = (short)428761078;
				short num3 = num;
				num = (short)1755734006;
				switch (num3 == num)
				{
				}
				num = (short)65404929;
				if (num != 0)
				{
				}
				num = (short)2025717760;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)588251136;
				short num2 = num;
				num = (short)205311508;
				short num3 = num;
				num = (short)1070845460;
				switch (num3 == num)
				{
				}
				num = (short)1790574593;
				if (num != 0)
				{
				}
				num = (short)759824384;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000AB RID: 171 RVA: 0x0000B970 File Offset: 0x00009B70
		// (set) Token: 0x060000AC RID: 172 RVA: 0x0000BA20 File Offset: 0x00009C20
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ClearAllEIDHistroyCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1801453568;
				short num2 = num;
				num = (short)655505704;
				short num3 = num;
				num = (short)340146472;
				switch (num3 == num)
				{
				}
				num = (short)1039204353;
				if (num != 0)
				{
				}
				num = (short)924057600;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1409220608;
				short num2 = num;
				num = (short)1476977001;
				short num3 = num;
				num = (short)1840570729;
				switch (num3 == num)
				{
				}
				num = (short)1023475713;
				if (num != 0)
				{
				}
				num = (short)215482368;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000BAD0 File Offset: 0x00009CD0
		// (set) Token: 0x060000AE RID: 174 RVA: 0x0000BB7C File Offset: 0x00009D7C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> FieldCheckChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)890109952;
				short num2 = num;
				num = (short)1239285761;
				if (num != 0)
				{
				}
				num = (short)2000414805;
				short num3 = num;
				num = (short)467462229;
				switch (num3 == num)
				{
				}
				num = (short)670433280;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)737214464;
				short num2 = num;
				num = (short)275032597;
				short num3 = num;
				num = (short)1929357845;
				switch (num3 == num)
				{
				}
				num = (short)400097281;
				if (num != 0)
				{
				}
				num = (short)1412497408;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000BC28 File Offset: 0x00009E28
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x0000BCD4 File Offset: 0x00009ED4
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand QueryEIDCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2089484288;
				short num2 = num;
				num = (short)147366212;
				short num3 = num;
				num = (short)202416452;
				switch (num3 == num)
				{
				}
				num = (short)237961217;
				if (num != 0)
				{
				}
				num = (short)755302400;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)808189952;
				short num2 = num;
				num = (short)1986602537;
				short num3 = num;
				num = (short)324347433;
				switch (num3 == num)
				{
				}
				num = (short)1647378432;
				if (num != 0)
				{
				}
				num = (short)517799937;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B1 RID: 177 RVA: 0x0000BD84 File Offset: 0x00009F84
		// (set) Token: 0x060000B2 RID: 178 RVA: 0x0000BE34 File Offset: 0x0000A034
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RegisterRadioLicenseCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1033043968;
				short num2 = num;
				num = (short)844938492;
				short num3 = num;
				num = (short)86686972;
				switch (num3 == num)
				{
				}
				num = (short)1743519744;
				if (num != 0)
				{
				}
				num = (short)1092288513;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)471531520;
				short num2 = num;
				num = (short)564448728;
				short num3 = num;
				num = (short)1780796888;
				switch (num3 == num)
				{
				}
				num = (short)2121662465;
				if (num != 0)
				{
				}
				num = (short)712835072;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000B3 RID: 179 RVA: 0x0000BEE4 File Offset: 0x0000A0E4
		// (set) Token: 0x060000B4 RID: 180 RVA: 0x0000BF90 File Offset: 0x0000A190
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RemoveRadiosCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1587347456;
				short num2 = num;
				num = (short)1368901391;
				short num3 = num;
				num = (short)312461071;
				switch (num3 == num)
				{
				}
				num = (short)218300417;
				if (num != 0)
				{
				}
				num = (short)980156416;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)2050162688;
				short num2 = num;
				num = (short)126772473;
				short num3 = num;
				num = (short)916743417;
				switch (num3 == num)
				{
				}
				num = (short)1720254465;
				if (num != 0)
				{
				}
				num = (short)2041839616;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B5 RID: 181 RVA: 0x0000C040 File Offset: 0x0000A240
		// (set) Token: 0x060000B6 RID: 182 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand RemoveAllRadiosCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1754905813;
				short num2 = num;
				num = (short)938720469;
				switch (num2 == num)
				{
				default:
				{
					num = (short)359006208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1799225345;
				if (num != 0)
				{
				}
				num = (short)367263744;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1780274315;
				short num2 = num;
				num = (short)764204171;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1078591488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1997209601;
				if (num != 0)
				{
				}
				num = (short)2135621632;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B7 RID: 183 RVA: 0x0000C1A0 File Offset: 0x0000A3A0
		// (set) Token: 0x060000B8 RID: 184 RVA: 0x0000C250 File Offset: 0x0000A450
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>> SelectedSelectionChangedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1523751175;
				short num2 = num;
				num = (short)504797447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1671233536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1535574016;
				if (num != 0)
				{
				}
				num = (short)619839489;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)246160071;
				short num2 = num;
				num = (short)1117657799;
				switch (num2 == num)
				{
				default:
				{
					num = (short)56885248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)240320513;
				if (num != 0)
				{
				}
				num = (short)1914830848;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000C2FC File Offset: 0x0000A4FC
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000C3AC File Offset: 0x0000A5AC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> SelectedGroupChangedCommad
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)624408460;
				short num2 = num;
				num = (short)1020049292;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1050869760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)571408385;
				if (num != 0)
				{
				}
				num = (short)9568256;
				if (num != 0)
				{
				}
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)728073398;
				short num2 = num;
				num = (short)1099465910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1101332480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2057109504;
				if (num != 0)
				{
				}
				num = (short)800391169;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000C458 File Offset: 0x0000A658
		private void o()
		{
			short num = (short)1143372852;
			short num2 = num;
			num = (short)1057389620;
			switch (num2 == num)
			{
			default:
			{
				num = (short)389480448;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)52887553;
			if (num != 0)
			{
			}
			num = (short)1719992320;
			if (num != 0)
			{
			}
			base.CommandHandler.AddSelectedDevices.Execute(new object[]
			{
				this.RegistRadioLicenseContext,
				false
			});
			this.RemoveAllRadiosCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000C534 File Offset: 0x0000A734
		private void n()
		{
			short num = (short)859475372;
			short num2 = num;
			num = (short)1792052652;
			switch (num2 == num)
			{
			default:
			{
				num = (short)446627840;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1329922049;
			if (num != 0)
			{
			}
			num = (short)1182859264;
			if (num != 0)
			{
			}
			base.CommandHandler.AddSelectedDevices.Execute(new object[]
			{
				this.RegistRadioLicenseContext,
				true
			});
			this.RemoveAllRadiosCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000C610 File Offset: 0x0000A810
		private void b(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> A_0)
		{
			short num = (short)1678901249;
			if (num != 0)
			{
			}
			num = (short)1741881344;
			short num2 = num;
			num = (short)1974611421;
			short num3 = num;
			num = (short)1920019933;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1005715456;
				if (num != 0)
				{
				}
				this.RegistRadioLicenseContext.AvailableListBoxSelectedItems.Clear();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator = A_0.GetEnumerator())
				{
					num = (short)1163919361;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_EB;
							}
							continue;
						case 2:
							goto IL_16F;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1596915716;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = enumerator.Current as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
							this.RegistRadioLicenseContext.AvailableListBoxSelectedItems.Add(item);
							num = (short)33030144;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)1438253058;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_121:
						num = (short)1688141827;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_EB:
						goto IL_121;
					}
					IL_16F:;
				}
				break;
			}
			this.AddRadiosCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000C7B8 File Offset: 0x0000A9B8
		private void m()
		{
			short num;
			try
			{
				num = (short)1458782909;
				short num2 = num;
				num = (short)1577796285;
				switch (num2 == num)
				{
				}
				num = (short)324403200;
				if (num != 0)
				{
				}
				base.CommandHandler.ClearAllEIDHistory.Execute(new object[]
				{
					this.RegistRadioLicenseContext
				});
				this.ClearAllEIDHistroyCommand.RaiseCanExecuteChanged();
			}
			catch (global::System.Exception exception)
			{
				this.RegistRadioLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1164836864;
			short num3 = num;
			num = (short)1121583105;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
		private void a(object[] A_0)
		{
			short num;
			try
			{
				num = (short)1717881755;
				short num2 = num;
				num = (short)1945226139;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1270808576;
					if (num != 0)
					{
					}
					global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor waitCursor = new global::Motorola.CommonCPS.RadioManagement.Controls.WaitCursor();
					try
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail eiddetail = A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail;
						eiddetail.IsSelected = (bool)A_0[2];
						this.RegistRadioLicenseContext.SelectChangeSource = eiddetail;
						base.CommandHandler.FilterAvailableDevicesCommand.Execute(new object[]
						{
							this.RegistRadioLicenseContext,
							this.a
						});
						this.AddAllRadiosCommand.RaiseCanExecuteChanged();
						this.RegisterRadioLicenseCommand.RaiseCanExecuteChanged();
					}
					finally
					{
						num = (short)389611520;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_EB;
								}
								continue;
							case 1:
								goto IL_11E;
							case 2:
								((global::System.IDisposable)waitCursor).Dispose();
								num = (short)1528758273;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_EB:
							if (waitCursor == null)
							{
								break;
							}
							num = (short)996081666;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_11E:;
					}
					break;
				}
				}
			}
			catch (global::System.Exception exception)
			{
				this.RegistRadioLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1153826816;
			short num4 = num;
			num = (short)345702401;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000CA80 File Offset: 0x0000AC80
		private void l()
		{
			short num;
			try
			{
				num = (short)453669455;
				short num2 = num;
				num = (short)1670738511;
				switch (num2 == num)
				{
				}
				num = (short)483393537;
				if (num != 0)
				{
				}
				num = (short)31784960;
				if (num != 0)
				{
				}
				base.CommandHandler.QueryEIDCommand.Execute(new object[]
				{
					this.RegistRadioLicenseContext,
					this.a
				});
				this.ClearAllEIDHistroyCommand.RaiseCanExecuteChanged();
				this.RegisterRadioLicenseCommand.RaiseCanExecuteChanged();
			}
			catch (global::System.Exception exception)
			{
				this.ClearAllEIDHistroyCommand.RaiseCanExecuteChanged();
				this.RegistRadioLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)478740480;
			short num3 = num;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000CBA4 File Offset: 0x0000ADA4
		private void k()
		{
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)978962654;
						short num3 = num2;
						num2 = (short)1223018718;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FD;
						default:
							num2 = (short)979304448;
							if (num2 != 0)
							{
							}
							if ((bool)base.CommandHandler.RegisterRadioLicenseCommand.Execute(new object[]
							{
								this.RegistRadioLicenseContext,
								this.a
							}))
							{
								num2 = (short)237895682;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_FD;
						}
						break;
					}
					case 1:
						goto IL_115;
					case 2:
						base.CloseCommand.Execute();
						num2 = (short)851509251;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						goto IL_FD;
					}
					goto IL_20;
					IL_FD:
					num2 = (short)1808924673;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_115:
				num2 = (short)480837633;
				if (num2 != 0)
				{
				}
				goto IL_156;
				IL_20:
				this.RegistRadioLicenseContext.OKCommandExecuted = true;
				num2 = (short)1265893376;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			catch (global::System.Exception exception)
			{
				this.RegistRadioLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			IL_156:
			num2 = (short)1626210304;
			short num4 = num2;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000CD50 File Offset: 0x0000AF50
		private void j()
		{
			short num = (short)1627722596;
			short num2 = num;
			num = (short)1205867364;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1405812736;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1757675521;
			if (num != 0)
			{
			}
			num = (short)1768488960;
			if (num != 0)
			{
			}
			base.CommandHandler.RemoveSelectedDevices.Execute(new object[]
			{
				this.RegistRadioLicenseContext,
				false
			});
			this.AddAllRadiosCommand.RaiseCanExecuteChanged();
			this.AddRadiosCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000CE38 File Offset: 0x0000B038
		private void i()
		{
			short num = (short)23678173;
			short num2 = num;
			num = (short)101731549;
			switch (num2 == num)
			{
			default:
			{
				num = (short)620101632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1761476609;
			if (num != 0)
			{
			}
			num = (short)1476001792;
			if (num != 0)
			{
			}
			base.CommandHandler.RemoveSelectedDevices.Execute(new object[]
			{
				this.RegistRadioLicenseContext,
				true
			});
			this.AddAllRadiosCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000CF14 File Offset: 0x0000B114
		private void b(global::Motorola.CommonCPS.RadioManagement.UIModels.Group A_0)
		{
			short num;
			try
			{
				num = (short)2039310234;
				short num2 = num;
				num = (short)628058010;
				switch (num2 == num)
				{
				}
				num = (short)507117568;
				if (num != 0)
				{
				}
				this.RegistRadioLicenseContext.SelectedGroup = A_0;
				base.CommandHandler.RegistRadioFeatureGroupChangeCommand.Execute(new object[]
				{
					this.RegistRadioLicenseContext,
					this.a
				});
			}
			catch (global::System.Exception exception)
			{
				this.RegistRadioLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)384696320;
			short num3 = num;
			num = (short)1536163841;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000D020 File Offset: 0x0000B220
		private void a(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase> A_0)
		{
			short num = (short)1990328321;
			if (num != 0)
			{
			}
			num = (short)380829696;
			short num2 = num;
			num = (short)324397609;
			short num3 = num;
			num = (short)1981934121;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1767964672;
				if (num != 0)
				{
				}
				this.RegistRadioLicenseContext.SelectedListBoxSelctedItems.Clear();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>.Enumerator enumerator = A_0.GetEnumerator())
				{
					num = (short)1156710401;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_EA;
							}
							continue;
						case 2:
							goto IL_170;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)218628100;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase item = enumerator.Current as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
							this.RegistRadioLicenseContext.SelectedListBoxSelctedItems.Add(item);
							num = (short)86376448;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)240451586;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_121:
						num = (short)1227685891;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_EA:
						goto IL_121;
					}
					IL_170:;
				}
				break;
			}
			this.RemoveRadiosCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000D1C8 File Offset: 0x0000B3C8
		private void h()
		{
			short num = (short)1186397915;
			short num2 = num;
			num = (short)2081947355;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1840316416;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1983643649;
			if (num != 0)
			{
			}
			num = (short)1889009664;
			if (num != 0)
			{
			}
			this.RegistRadioLicenseContext.AstroVisibility = global::System.Windows.Visibility.Visible;
			this.RegistRadioLicenseContext.AstroPCRVisibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000D28C File Offset: 0x0000B48C
		private bool g()
		{
			short num = (short)681291825;
			short num2 = num;
			num = (short)786214961;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1743585280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1704067073;
			if (num != 0)
			{
			}
			num = (short)1224278016;
			if (num != 0)
			{
			}
			return base.CommandHandler.AddSelectedDevices.CanExecute(new object[]
			{
				this.RegistRadioLicenseContext,
				false
			});
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000D35C File Offset: 0x0000B55C
		private bool f()
		{
			short num = (short)1129971713;
			if (num != 0)
			{
			}
			num = (short)2080047104;
			short num2 = num;
			num = (short)696500952;
			short num3 = num;
			num = (short)689291992;
			switch (num3 == num)
			{
			}
			num = (short)1023606784;
			if (num != 0)
			{
			}
			return this.RegistRadioLicenseContext.AvailableDevices.Count > 0;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000D418 File Offset: 0x0000B618
		private bool e()
		{
			short num;
			bool result;
			try
			{
				num = (short)1227040008;
				short num2 = num;
				num = (short)265626888;
				switch (num2 == num)
				{
				}
				num = (short)43384832;
				if (num != 0)
				{
				}
				result = base.CommandHandler.ClearAllEIDHistory.CanExecute(new object[]
				{
					this.RegistRadioLicenseContext
				});
			}
			catch (global::System.Exception exception)
			{
				this.RegistRadioLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)236584960;
			short num3 = num;
			num = (short)397672449;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000D510 File Offset: 0x0000B710
		private bool d()
		{
			short num;
			bool result;
			try
			{
				num = (short)376974208;
				short num2 = num;
				num = (short)1708141440;
				switch (num2 == num)
				{
				}
				num = (short)359661569;
				if (num != 0)
				{
				}
				num = (short)113049600;
				if (num != 0)
				{
				}
				result = base.CommandHandler.QueryEIDCommand.CanExecute(new object[]
				{
					this.RegistRadioLicenseContext
				});
			}
			catch (global::System.Exception exception)
			{
				this.RegistRadioLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1655832576;
			short num3 = num;
			return result;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000D600 File Offset: 0x0000B800
		private bool c()
		{
			short num;
			bool result;
			try
			{
				num = (short)354564431;
				short num2 = num;
				num = (short)1381120335;
				switch (num2 == num)
				{
				}
				num = (short)918880256;
				if (num != 0)
				{
				}
				result = base.CommandHandler.RegisterRadioLicenseCommand.CanExecute(new object[]
				{
					this.RegistRadioLicenseContext
				});
			}
			catch (global::System.Exception exception)
			{
				this.RegistRadioLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)846266368;
			short num3 = num;
			num = (short)763232257;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000D6F8 File Offset: 0x0000B8F8
		private bool b()
		{
			short num = (short)72877299;
			short num2 = num;
			num = (short)1332741363;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1584005120;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1625554945;
			if (num != 0)
			{
			}
			num = (short)1075576832;
			if (num != 0)
			{
			}
			return base.CommandHandler.RemoveSelectedDevices.CanExecute(new object[]
			{
				this.RegistRadioLicenseContext,
				false
			});
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000D7CC File Offset: 0x0000B9CC
		private bool a()
		{
			short num = (short)1210853828;
			short num2 = num;
			num = (short)1858021828;
			switch (num2 == num)
			{
			default:
			{
				num = (short)269877248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)45416449;
			if (num != 0)
			{
			}
			num = (short)1414529024;
			if (num != 0)
			{
			}
			return this.RegistRadioLicenseContext.SelectedDevices.Count > 0;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000D888 File Offset: 0x0000BA88
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.Group A_0)
		{
			short num;
			bool result;
			try
			{
				num = (short)1433075713;
				if (num != 0)
				{
				}
				num = (short)1324743203;
				short num2 = num;
				num = (short)880933411;
				switch (num2 == num)
				{
				}
				num = (short)68485120;
				if (num != 0)
				{
				}
				this.RegistRadioLicenseContext.SelectedGroup = A_0;
				result = base.CommandHandler.RegistRadioFeatureGroupChangeCommand.CanExecute(new object[]
				{
					this.RegistRadioLicenseContext
				});
			}
			catch (global::System.Exception exception)
			{
				this.RegistRadioLicenseContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1753219072;
			short num3 = num;
			return result;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000D98C File Offset: 0x0000BB8C
		private void b(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1921300869;
			short num2 = num;
			num = (short)431208837;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1222574080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)510590977;
			if (num != 0)
			{
			}
			num = (short)1974534144;
			if (num != 0)
			{
			}
			this.AddRadiosCommand.RaiseCanExecuteChanged();
			this.AddAllRadiosCommand.RaiseCanExecuteChanged();
			this.RegisterRadioLicenseCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000DA58 File Offset: 0x0000BC58
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 19;
			short num = (short)1016413790;
			short num2 = num;
			num = (short)635977310;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1824325632;
				if (num != 0)
				{
				}
				num = (short)2097938433;
				if (num != 0)
				{
				}
				if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("父䄸堺堼伾㕀⩂⩄⥆ш⹊㹌㱎ぐ㑒ご", a_))
				{
					num = (short)427819008;
					short num3 = num;
					return;
				}
				break;
			}
			this.RegistRadioLicenseContext.ExceptionMessage = string.Empty;
			this.QueryEIDCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000DB44 File Offset: 0x0000BD44
		private void a(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)489553921;
			if (num != 0)
			{
			}
			num = (short)678494208;
			short num2 = num;
			num = (short)854776189;
			short num3 = num;
			num = (short)612096381;
			switch (num3 == num)
			{
			}
			num = (short)1242365952;
			if (num != 0)
			{
			}
			this.RemoveRadiosCommand.RaiseCanExecuteChanged();
			this.RemoveAllRadiosCommand.RaiseCanExecuteChanged();
			this.RegisterRadioLicenseCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000DC14 File Offset: 0x0000BE14
		protected override void OnWindowClosed()
		{
			short num = (short)1066167873;
			short num2 = num;
			num = (short)34303553;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2097283073;
				if (num != 0)
				{
				}
				num = (short)1769406464;
				if (num != 0)
				{
				}
				base.OnWindowClosed();
				if (this.RegistRadioLicenseContext.OKCommandExecuted)
				{
					num = (short)1474232320;
					short num3 = num;
					this.RegistRadioLicenseContext.CancelCommandExecuted = false;
					return;
				}
				break;
			}
			this.RegistRadioLicenseContext.CancelCommandExecuted = true;
		}

		// Token: 0x0400004D RID: 77
		private int a;

		// Token: 0x0400004E RID: 78
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext b;

		// Token: 0x0400004F RID: 79
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x04000050 RID: 80
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand d;

		// Token: 0x04000051 RID: 81
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>> e;

		// Token: 0x04000052 RID: 82
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand f;

		// Token: 0x04000053 RID: 83
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> g;

		// Token: 0x04000054 RID: 84
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand h;

		// Token: 0x04000055 RID: 85
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand i;

		// Token: 0x04000056 RID: 86
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand j;

		// Token: 0x04000057 RID: 87
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand k;

		// Token: 0x04000058 RID: 88
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase>> l;

		// Token: 0x04000059 RID: 89
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.Group> m;
	}
}
