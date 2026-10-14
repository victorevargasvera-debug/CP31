using System;
using System.Windows.Input;

namespace MackinawCPS
{
	// Token: 0x02000027 RID: 39
	public class CpsCommand : global::System.Windows.Input.ICommand
	{
		// Token: 0x06000085 RID: 133 RVA: 0x0000F73C File Offset: 0x0000D93C
		public CpsCommand(global::System.Action<object> execute, global::System.Func<object, bool> canExecute)
		{
			this._execute = execute;
			this._canExecute = canExecute;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000F760 File Offset: 0x0000D960
		public bool CanExecute(object parameter)
		{
			short num = (short)1150853074;
			short num2 = num;
			num = (short)125738962;
			switch (num2 == num)
			{
			}
			num = (short)770703361;
			if (num != 0)
			{
			}
			num = (short)305397760;
			short num3 = num;
			num = (short)1307049984;
			if (num != 0)
			{
			}
			return this._canExecute(parameter);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000F814 File Offset: 0x0000DA14
		public void Execute(object parameter)
		{
			short num = (short)439943169;
			if (num != 0)
			{
			}
			num = (short)1267668389;
			short num2 = num;
			num = (short)767169957;
			switch (num2 == num)
			{
			}
			num = (short)321519616;
			short num3 = num;
			num = (short)81788928;
			if (num != 0)
			{
			}
			this._execute(parameter);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000088 RID: 136 RVA: 0x0000F8CC File Offset: 0x0000DACC
		// (remove) Token: 0x06000089 RID: 137 RVA: 0x0000F980 File Offset: 0x0000DB80
		public event global::System.EventHandler CanExecuteChanged
		{
			add
			{
				short num = (short)434583232;
				short num2 = num;
				num = (short)2106996416;
				switch (num2 == num)
				{
				}
				num = (short)883818497;
				if (num != 0)
				{
				}
				num = (short)1632894976;
				short num3 = num;
				num = (short)1720188928;
				if (num != 0)
				{
				}
				global::System.Windows.Input.CommandManager.RequerySuggested += value;
			}
			remove
			{
				short num = (short)627113984;
				short num2 = num;
				num = (short)703332353;
				if (num != 0)
				{
				}
				num = (short)976401716;
				short num3 = num;
				num = (short)1502000436;
				switch (num3 == num)
				{
				}
				num = (short)863240192;
				if (num != 0)
				{
				}
				global::System.Windows.Input.CommandManager.RequerySuggested -= value;
			}
		}

		// Token: 0x0400003C RID: 60
		private global::System.Action<object> _execute;

		// Token: 0x0400003D RID: 61
		private global::System.Func<object, bool> _canExecute;

		// Token: 0x0400003E RID: 62
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
