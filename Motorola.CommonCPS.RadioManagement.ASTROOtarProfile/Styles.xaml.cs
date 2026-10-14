using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.ASTROOtarProfile
{
	// Token: 0x0200001A RID: 26
	public partial class Styles : ResourceDictionary, IStyleConnector
	{
		// Token: 0x06000099 RID: 153 RVA: 0x000097A4 File Offset: 0x000079A4
		private void a(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)673900445;
			short num2 = num;
			num = (short)555673501;
			switch (num2 == num)
			{
			}
			num = (short)1435107328;
			short num3 = num;
			num = (short)75235329;
			if (num != 0)
			{
			}
			num = (short)659488768;
			if (num != 0)
			{
			}
			((RMDataGrid)((RMLinkButton)A_0).Tag).ActiveRecord.IsSelected = true;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000099FC File Offset: 0x00007BFC
		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1208614914;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					((RMLinkButton)target).Click += this.a;
					num = (short)133300225;
					num2 = (int)((IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				num = (short)1791314743;
				short num3 = num;
				num = (short)1887652663;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)1422327808;
					short num4 = num;
					num = (short)1657405441;
					if (num != 0)
					{
					}
					num = (short)1115226112;
					if (num != 0)
					{
					}
					if (connectionId != 1)
					{
						return;
					}
					num = (short)544145408;
					num2 = (int)((IntPtr)num);
					break;
				}
				}
			}
		}
	}
}
