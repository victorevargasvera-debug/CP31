using System;
using System.Windows.Input;

namespace SpecialFeatures.Utilities
{
	// Token: 0x0200003D RID: 61
	public class RelayCommand : global::System.Windows.Input.ICommand
	{
		// Token: 0x06000754 RID: 1876 RVA: 0x00002779 File Offset: 0x00000979
		public RelayCommand(global::System.Action<object> execute) : this(execute, null)
		{
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x00002783 File Offset: 0x00000983
		public RelayCommand(global::System.Action<object> execute, global::System.Predicate<object> canExecute)
		{
			if (execute == null)
			{
				throw new global::System.ArgumentNullException();
			}
			this.a = execute;
			this.b = canExecute;
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0006BE3C File Offset: 0x0006A03C
		public bool CanExecute(object parameter)
		{
			while (this.b != null)
			{
				short num = (short)2018653824;
				short num2 = num;
				num = (short)1819752064;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)474546177;
					if (num != 0)
					{
					}
					num = (short)1604255744;
					if (num != 0)
					{
					}
					num = (short)1970012160;
					short num3 = num;
					return this.b(parameter);
				}
				}
			}
			return true;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000757 RID: 1879 RVA: 0x0006BEFC File Offset: 0x0006A0FC
		// (remove) Token: 0x06000758 RID: 1880 RVA: 0x0006BFAC File Offset: 0x0006A1AC
		public event global::System.EventHandler CanExecuteChanged
		{
			add
			{
				short num = (short)148242433;
				if (num != 0)
				{
				}
				num = (short)1635986375;
				short num2 = num;
				num = (short)999631815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1995309056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)457900032;
				if (num != 0)
				{
				}
				global::System.Windows.Input.CommandManager.RequerySuggested += value;
			}
			remove
			{
				short num = (short)1093084808;
				short num2 = num;
				num = (short)1383736968;
				switch (num2 == num)
				{
				}
				num = (short)1149566976;
				short num3 = num;
				num = (short)1322713088;
				if (num != 0)
				{
				}
				num = (short)1292173313;
				if (num != 0)
				{
				}
				global::System.Windows.Input.CommandManager.RequerySuggested -= value;
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0006C05C File Offset: 0x0006A25C
		public void Execute(object parameter)
		{
			short num = (short)1196655881;
			short num2 = num;
			num = (short)1401521417;
			switch (num2 == num)
			{
			}
			num = (short)673513472;
			short num3 = num;
			num = (short)172883968;
			if (num != 0)
			{
			}
			num = (short)998440961;
			if (num != 0)
			{
			}
			this.a(parameter);
		}

		// Token: 0x040002E2 RID: 738
		private readonly global::System.Action<object> a;

		// Token: 0x040002E3 RID: 739
		private readonly global::System.Predicate<object> b;
	}
}
