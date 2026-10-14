using System;
using System.Windows;

namespace Infragistics.DragDrop
{
	// Token: 0x0200000B RID: 11
	public class DragDropEventArgs : global::System.EventArgs
	{
		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00005D2B File Offset: 0x00003F2B
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00005D33 File Offset: 0x00003F33
		public global::System.Windows.DataTemplate CopyCursorTemplate { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00005D3C File Offset: 0x00003F3C
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00005D44 File Offset: 0x00003F44
		public object Data { get; set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00005D4D File Offset: 0x00003F4D
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00005D55 File Offset: 0x00003F55
		public global::System.Windows.UIElement DragSource { get; internal set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00005D5E File Offset: 0x00003F5E
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00005D66 File Offset: 0x00003F66
		public global::System.Windows.DataTemplate DragTemplate { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00005D6F File Offset: 0x00003F6F
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00005D77 File Offset: 0x00003F77
		public global::System.Windows.DataTemplate DropNotAllowedCursorTemplate { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00005D80 File Offset: 0x00003F80
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00005D88 File Offset: 0x00003F88
		public global::System.Windows.UIElement DropTarget { get; internal set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00005D91 File Offset: 0x00003F91
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00005D99 File Offset: 0x00003F99
		public global::System.Windows.DataTemplate MoveCursorTemplate { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00005DA2 File Offset: 0x00003FA2
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00005DAA File Offset: 0x00003FAA
		public global::Infragistics.DragDrop.OperationType? OperationType { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00005DB3 File Offset: 0x00003FB3
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00005DBB File Offset: 0x00003FBB
		public global::System.Windows.UIElement OriginalDragSource { get; internal set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00005DC4 File Offset: 0x00003FC4
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00005DCC File Offset: 0x00003FCC
		public global::System.Windows.UIElement CustomMouseHolder { get; set; }
	}
}
