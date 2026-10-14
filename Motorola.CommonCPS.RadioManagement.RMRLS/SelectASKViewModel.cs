using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using ASK.Interface;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.Command;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.RadioLicense
{
	// Token: 0x02000016 RID: 22
	public class SelectASKViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.PopoupViewModelBase
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x0000E1C8 File Offset: 0x0000C3C8
		public SelectASKViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, global::Motorola.CommonCPS.RadioManagement.Command.ICommandHandler commandHandler, global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext selectASKForCFSContext) : base(eventAggregator, commandHandler)
		{
			this.SelectASKForCFSContext = selectASKForCFSContext;
			this.ApplyASKToRadioCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]>(new global::System.Action<object[]>(this.a));
			this.CancelCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.c));
			this.SelectASKForCFSCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.b), new global::System.Func<bool>(this.a));
			this.SelectASKForCFSContext.PropertyChanged += this.a;
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000E24C File Offset: 0x0000C44C
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000E2FC File Offset: 0x0000C4FC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext SelectASKForCFSContext
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1924746818;
				short num2 = num;
				num = (short)1751273026;
				switch (num2 == num)
				{
				}
				num = (short)1506213888;
				short num3 = num;
				num = (short)1963458561;
				if (num != 0)
				{
				}
				num = (short)353828864;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)210420478;
				short num2 = num;
				num = (short)1995358974;
				switch (num2 == num)
				{
				}
				num = (short)509214720;
				short num3 = num;
				num = (short)1624571904;
				if (num != 0)
				{
				}
				num = (short)899219457;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000E3AC File Offset: 0x0000C5AC
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000E45C File Offset: 0x0000C65C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand SelectASKForCFSCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)30137679;
				short num2 = num;
				num = (short)25025871;
				switch (num2 == num)
				{
				}
				num = (short)853671936;
				short num3 = num;
				num = (short)663486465;
				if (num != 0)
				{
				}
				num = (short)1568866304;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1707635142;
				short num2 = num;
				num = (short)1410232774;
				switch (num2 == num)
				{
				}
				num = (short)1552547840;
				short num3 = num;
				num = (short)580386817;
				if (num != 0)
				{
				}
				num = (short)1518010368;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000E50C File Offset: 0x0000C70C
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000E5BC File Offset: 0x0000C7BC
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CancelCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1076128193;
				short num2 = num;
				num = (short)1047357889;
				switch (num2 == num)
				{
				}
				num = (short)1154088960;
				short num3 = num;
				num = (short)1469644800;
				if (num != 0)
				{
				}
				num = (short)723189761;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1794818044;
				short num2 = num;
				num = (short)1201979388;
				switch (num2 == num)
				{
				}
				num = (short)200081408;
				short num3 = num;
				num = (short)426835969;
				if (num != 0)
				{
				}
				num = (short)1827733504;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000E66C File Offset: 0x0000C86C
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000E71C File Offset: 0x0000C91C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> ApplyASKToRadioCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1149285708;
				short num2 = num;
				num = (short)916829516;
				switch (num2 == num)
				{
				}
				num = (short)500760576;
				short num3 = num;
				num = (short)68878337;
				if (num != 0)
				{
				}
				num = (short)416284672;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1957977306;
				short num2 = num;
				num = (short)1979997402;
				switch (num2 == num)
				{
				}
				num = (short)107610112;
				short num3 = num;
				num = (short)992083969;
				if (num != 0)
				{
				}
				num = (short)1060831232;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000E7CC File Offset: 0x0000C9CC
		private void a(object[] A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
			global::ASK.Interface.ISystemKeyData value;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					for (;;)
					{
						this.SelectASKForCFSContext.RadioASKMapping[radioBase] = value;
						num2 = (short)624689152;
						short num3 = num2;
						num2 = (short)279697080;
						short num4 = num2;
						num2 = (short)2050348728;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_13D;
						}
					}
					IL_13D:
					num2 = (short)858914816;
					if (num2 != 0)
					{
					}
					num2 = (short)2127495171;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_9F;
				case 2:
					if (this.SelectASKForCFSContext.RadioASKMapping.Keys.Contains(radioBase))
					{
						num2 = (short)1982595072;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.SelectASKForCFSContext.RadioASKMapping.Add(radioBase, value);
					num2 = (short)1188233217;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_169;
				}
				goto IL_20;
			}
			IL_9F:
			num2 = (short)735903745;
			if (num2 != 0)
			{
			}
			IL_169:
			this.SelectASKForCFSCommand.RaiseCanExecuteChanged();
			return;
			IL_20:
			radioBase = (A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase);
			value = (A_0[2] as global::ASK.Interface.ISystemKeyData);
			num2 = (short)437256194;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000E950 File Offset: 0x0000CB50
		private void c()
		{
			short num = (short)2090180786;
			short num2 = num;
			num = (short)268607666;
			switch (num2 == num)
			{
			}
			num = (short)2111897600;
			short num3 = num;
			num = (short)174850049;
			if (num != 0)
			{
			}
			num = (short)72744960;
			if (num != 0)
			{
			}
			this.SelectASKForCFSContext.IsSelected = false;
			base.CloseCommand.Execute();
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000EA10 File Offset: 0x0000CC10
		private void b()
		{
			short num;
			try
			{
				num = (short)1686904120;
				short num2 = num;
				num = (short)4922680;
				switch (num2 == num)
				{
				}
				num = (short)252444673;
				if (num != 0)
				{
				}
				num = (short)1479081984;
				if (num != 0)
				{
				}
				base.CommandHandler.SelectASKForCFSCommand.Execute(new object[]
				{
					this.SelectASKForCFSContext
				});
				this.SelectASKForCFSContext.IsSelected = true;
				base.CloseCommand.Execute();
			}
			catch (global::System.Exception exception)
			{
				this.SelectASKForCFSContext.ExceptionMessage = global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
			}
			num = (short)1323106304;
			short num3 = num;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000EB18 File Offset: 0x0000CD18
		private bool a()
		{
			short num;
			bool result;
			try
			{
				num = (short)475398776;
				short num2 = num;
				num = (short)210567800;
				switch (num2 == num)
				{
				}
				num = (short)1371668480;
				if (num != 0)
				{
				}
				num = (short)1244725249;
				if (num != 0)
				{
				}
				result = base.CommandHandler.SelectASKForCFSCommand.CanExecute(new object[]
				{
					this.SelectASKForCFSContext
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)2013855744;
			short num3 = num;
			return result;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000EC04 File Offset: 0x0000CE04
		private void a(object A_0, global::System.ComponentModel.PropertyChangedEventArgs A_1)
		{
			int a_ = 2;
			if (A_1.PropertyName == global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("挥倧䤩䤫席䐯嬱嬳堵男弹伻䴽ℿ╁⅃", a_))
			{
				short num = (short)809697281;
				if (num != 0)
				{
				}
				num = (short)65717977;
				short num2 = num;
				num = (short)1871562457;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1004273664;
					short num3 = num;
					num = (short)344784896;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			this.SelectASKForCFSContext.ExceptionMessage = string.Empty;
			this.SelectASKForCFSCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000ECF4 File Offset: 0x0000CEF4
		internal static string d(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(389369300 + A_1) + (global::System.IntPtr)74 + (global::System.IntPtr)60 + (global::System.IntPtr)94 + (global::System.IntPtr)96 + (global::System.IntPtr)11);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}

		// Token: 0x0400005F RID: 95
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.SelectASKForCFSContext a;

		// Token: 0x04000060 RID: 96
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand b;

		// Token: 0x04000061 RID: 97
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x04000062 RID: 98
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<object[]> d;
	}
}
