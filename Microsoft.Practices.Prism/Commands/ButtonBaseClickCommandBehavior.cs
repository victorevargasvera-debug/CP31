using System;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace Microsoft.Practices.Prism.Commands
{
	// Token: 0x02000004 RID: 4
	[global::System.Obsolete("The ButtonBaseClickCommandBehavior is obsolete.  Silverlight supports the Command property for buttons.")]
	public class ButtonBaseClickCommandBehavior : global::Microsoft.Practices.Prism.Commands.CommandBehaviorBase<global::System.Windows.Controls.Primitives.ButtonBase>
	{
		// Token: 0x0600001D RID: 29 RVA: 0x000023A9 File Offset: 0x000005A9
		public ButtonBaseClickCommandBehavior(global::System.Windows.Controls.Primitives.ButtonBase clickableObject) : base(clickableObject)
		{
			if (clickableObject == null)
			{
				throw new global::System.ArgumentNullException("clickableObject");
			}
			clickableObject.Click += this.OnClick;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000023D2 File Offset: 0x000005D2
		private void OnClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			this.ExecuteCommand();
		}
	}
}
