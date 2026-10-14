using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x0200001A RID: 26
	public partial class Styles : ResourceDictionary, IStyleConnector
	{
		// Token: 0x0600007A RID: 122 RVA: 0x00008490 File Offset: 0x00006690
		private void a(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)985957755;
			short num2 = num;
			num = (short)2038138235;
			switch (num2 == num)
			{
			}
			num = (short)582746113;
			if (num != 0)
			{
			}
			num = (short)1992949760;
			if (num != 0)
			{
			}
			num = (short)800980992;
			short num3 = num;
			((RMDataGrid)((RMLinkButton)A_0).Tag).ActiveRecord.IsSelected = true;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000086E4 File Offset: 0x000068E4
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerNonUserCode]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1748893697;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					for (;;)
					{
						num = (short)5901061;
						short num3 = num;
						num = (short)1741425413;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_82;
						}
					}
					IL_82:
					num = (short)1841889281;
					if (num != 0)
					{
					}
					num = (short)799145984;
					if (num != 0)
					{
					}
					num = (short)127270912;
					short num4 = num;
					((RMLinkButton)target).Click += this.a;
					num = (short)588120066;
					num2 = (int)((IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					return;
				}
				IL_31:
				if (connectionId != 1)
				{
					break;
				}
				num = (short)1018888192;
				num2 = (int)((IntPtr)num);
			}
		}
	}
}
