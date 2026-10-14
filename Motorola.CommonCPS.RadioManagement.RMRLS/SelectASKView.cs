using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.RadioLicense
{
	// Token: 0x02000015 RID: 21
	public class SelectASKView : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060000D3 RID: 211 RVA: 0x0000DCEC File Offset: 0x0000BEEC
		public SelectASKView()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000DD08 File Offset: 0x0000BF08
		private void a(object A_0, global::System.Windows.DependencyPropertyChangedEventArgs A_1)
		{
			int a_ = 0;
			global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.Record> enumerator = ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Record>)this.dgrRadios.Records).GetEnumerator();
			short num;
			try
			{
				num = (short)956694530;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Infragistics.Windows.DataPresenter.Record record;
						((global::Infragistics.Windows.DataPresenter.DataRecord)record).Cells[global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("攣甥挧", a_)].Value = null;
						num = (short)1336868865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_31;
					case 3:
					{
						global::Infragistics.Windows.DataPresenter.Record record;
						if (record.IsDataRecord)
						{
							num = (short)1018560512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_178;
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1701183494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Infragistics.Windows.DataPresenter.Record record = enumerator.Current;
						num = (short)548798467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						num = (short)942296795;
						short num3 = num;
						num = (short)1792888539;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_31;
						default:
							num = (short)1680343040;
							if (num != 0)
							{
							}
							num = (short)790560772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_5D;
					IL_31:
					switch (0)
					{
					case 0:
						IL_5D:
						goto IL_9E;
					}
					continue;
					IL_9E:
					num = (short)1700593669;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_178:;
			}
			finally
			{
				num = (short)787021825;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)747110402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1AC;
						}
						continue;
					case 2:
						goto IL_1E0;
					}
					IL_1AC:
					if (enumerator == null)
					{
						break;
					}
					num = (short)2008547328;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E0:;
			}
			num = (short)499253248;
			short num4 = num;
			num = (short)620232705;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000DF68 File Offset: 0x0000C168
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 15;
			if (this._contentLoaded)
			{
				short num = (short)254045013;
				short num2 = num;
				num = (short)2027187029;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)733544449;
					if (num != 0)
					{
					}
					num = (short)1897201664;
					short num3 = num;
					num = (short)706609152;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKViewModel.d("ᰲ破堶䴸吺似倾ⵀ≂歄ц♈♊⁌⁎㽐ၒՔі睘ग़㱜㭞ࡠౢ⡤٦ݨ੪੬੮ᱰᙲ᭴Ͷ坸⥺ぼ⵾춀킂뺄ﶌﾐﮔ뚘좠킢톤슦\udba8잪쒬첮풰\uddb2운튶쾸튺\ud8bc좾냂ꃄꯆ곈꣊만껎ꋐ룒ꏔ뻖볘곚꟞胠転觤", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000E04C File Offset: 0x0000C24C
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1266352129;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1074659328;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)1360658434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_16;
				case 2:
					goto IL_BC;
				}
				goto IL_5D;
				IL_16:
				switch (0)
				{
				case 0:
					IL_5D:
					switch (connectionId)
					{
					case 1:
						goto IL_141;
					case 2:
						goto IL_98;
					case 3:
						goto IL_8B;
					case 4:
					{
						num = (short)1176278696;
						short num4 = num;
						num = (short)1268487848;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16;
						default:
							goto IL_F8;
						}
						break;
					}
					default:
						num = (short)862191616;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
			}
			IL_8B:
			this.btnOK = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_98:
			this.dgrRadios = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
			return;
			IL_BC:
			this._contentLoaded = true;
			return;
			IL_F8:
			num = (short)1663893505;
			if (num != 0)
			{
			}
			num = (short)1448738816;
			if (num != 0)
			{
			}
			this.btnCancel = (global::Motorola.CommonCPS.RadioManagement.Controls.RMButton)target;
			return;
			IL_141:
			this.uscRadios = (global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKView)target;
			this.uscRadios.DataContextChanged += this.a;
		}

		// Token: 0x0400005A RID: 90
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.RadioLicense.SelectASKView uscRadios;

		// Token: 0x0400005B RID: 91
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrRadios;

		// Token: 0x0400005C RID: 92
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnOK;

		// Token: 0x0400005D RID: 93
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMButton btnCancel;

		// Token: 0x0400005E RID: 94
		private bool _contentLoaded;
	}
}
