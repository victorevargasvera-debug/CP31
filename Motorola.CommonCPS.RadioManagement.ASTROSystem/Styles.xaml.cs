using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.ASTROSystem
{
	// Token: 0x0200000D RID: 13
	public partial class Styles : ResourceDictionary, IStyleConnector
	{
		// Token: 0x06000022 RID: 34 RVA: 0x00003644 File Offset: 0x00001844
		private void a(object A_0, RoutedEventArgs A_1)
		{
			short num = (short)1696923649;
			if (num != 0)
			{
			}
			num = (short)2030895104;
			short num2 = num;
			num = (short)2070957412;
			short num3 = num;
			num = (short)1100565860;
			switch (num3 == num)
			{
			}
			num = (short)153747456;
			if (num != 0)
			{
			}
			((RMDataGrid)((RMLinkButton)A_0).Tag).ActiveRecord.IsSelected = true;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003898 File Offset: 0x00001A98
		[DebuggerNonUserCode]
		[GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		void IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1106182144;
			int num2 = (int)((IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
				{
					num = (short)1014038089;
					short num3 = num;
					num = (short)1942552137;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)65011712;
						if (num != 0)
						{
						}
						((RMLinkButton)target).Click += this.a;
						num = (short)366084098;
						num2 = (int)((IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_ED;
				}
				IL_30:
				num = (short)356974593;
				if (num != 0)
				{
				}
				if (connectionId != 1)
				{
					return;
				}
				num = (short)515571713;
				num2 = (int)((IntPtr)num);
			}
			IL_ED:
			num = (short)1960771584;
			short num4 = num;
		}
	}
}
