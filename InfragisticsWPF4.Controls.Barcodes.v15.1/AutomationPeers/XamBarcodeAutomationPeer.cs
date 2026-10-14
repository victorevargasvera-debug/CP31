using System;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;

namespace Infragistics.Controls.Barcodes.AutomationPeers
{
	// Token: 0x0200001C RID: 28
	public class XamBarcodeAutomationPeer : global::System.Windows.Automation.Peers.FrameworkElementAutomationPeer, global::System.Windows.Automation.Provider.IValueProvider
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x0000DD38 File Offset: 0x0000BF38
		public XamBarcodeAutomationPeer(global::Infragistics.Controls.Barcodes.XamBarcode barcode) : base(barcode)
		{
			this.Barcode = barcode;
			this.Barcode.DataChanged += this.Barcode_DataChanged;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000DD5F File Offset: 0x0000BF5F
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000DD67 File Offset: 0x0000BF67
		public global::Infragistics.Controls.Barcodes.XamBarcode Barcode { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000DD70 File Offset: 0x0000BF70
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000DD73 File Offset: 0x0000BF73
		public string Value
		{
			get
			{
				return this.Barcode.Data;
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000DD80 File Offset: 0x0000BF80
		public void SetValue(string value)
		{
			if (!string.IsNullOrEmpty(value))
			{
				this.Barcode.Data = value;
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000DD96 File Offset: 0x0000BF96
		protected override global::System.Windows.Automation.Peers.AutomationControlType GetAutomationControlTypeCore()
		{
			return global::System.Windows.Automation.Peers.AutomationControlType.Custom;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000DD9A File Offset: 0x0000BF9A
		protected override string GetClassNameCore()
		{
			return this.Barcode.GetType().Name;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000DDAC File Offset: 0x0000BFAC
		protected override string GetNameCore()
		{
			if (string.IsNullOrEmpty(this.Barcode.Name))
			{
				return this.Barcode.GetType().Name;
			}
			return this.Barcode.Name;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000DDDC File Offset: 0x0000BFDC
		public override object GetPattern(global::System.Windows.Automation.Peers.PatternInterface patternInterface)
		{
			if (patternInterface == global::System.Windows.Automation.Peers.PatternInterface.Value)
			{
				return this;
			}
			return base.GetPattern(patternInterface);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000DDEB File Offset: 0x0000BFEB
		private void Barcode_DataChanged(object sender, global::Infragistics.Controls.Barcodes.DataChangedEventArgs e)
		{
			this.RaiseDataChangedEvent(e.NewData);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000DDF9 File Offset: 0x0000BFF9
		private void RaiseDataChangedEvent(string newData)
		{
			if (global::System.Windows.Automation.Peers.AutomationPeer.ListenerExists(global::System.Windows.Automation.Peers.AutomationEvents.PropertyChanged))
			{
				base.RaisePropertyChangedEvent(global::System.Windows.Automation.ValuePatternIdentifiers.ValueProperty, "", newData);
			}
		}
	}
}
