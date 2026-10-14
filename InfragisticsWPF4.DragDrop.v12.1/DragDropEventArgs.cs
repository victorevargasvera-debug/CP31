using System;
using System.Windows;

namespace Infragistics.DragDrop
{
	// Token: 0x0200000B RID: 11
	public class DragDropEventArgs : global::System.EventArgs
	{
		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00005B97 File Offset: 0x00003D97
		// (set) Token: 0x0600009B RID: 155 RVA: 0x00005B9F File Offset: 0x00003D9F
		public global::System.Windows.DataTemplate CopyCursorTemplate { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00005BA8 File Offset: 0x00003DA8
		// (set) Token: 0x0600009D RID: 157 RVA: 0x00005BB0 File Offset: 0x00003DB0
		public object Data { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009E RID: 158 RVA: 0x00005BB9 File Offset: 0x00003DB9
		// (set) Token: 0x0600009F RID: 159 RVA: 0x00005BC1 File Offset: 0x00003DC1
		public global::System.Windows.UIElement DragSource { get; internal set; }

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00005BCA File Offset: 0x00003DCA
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x00005BD2 File Offset: 0x00003DD2
		public global::System.Windows.DataTemplate DragTemplate { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00005BDB File Offset: 0x00003DDB
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00005BE3 File Offset: 0x00003DE3
		public global::System.Windows.DataTemplate DropNotAllowedCursorTemplate { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00005BEC File Offset: 0x00003DEC
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00005BF4 File Offset: 0x00003DF4
		public global::System.Windows.UIElement DropTarget { get; internal set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x00005BFD File Offset: 0x00003DFD
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00005C05 File Offset: 0x00003E05
		public global::System.Windows.DataTemplate MoveCursorTemplate { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00005C0E File Offset: 0x00003E0E
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x00005C16 File Offset: 0x00003E16
		public global::Infragistics.DragDrop.OperationType? OperationType { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00005C1F File Offset: 0x00003E1F
		// (set) Token: 0x060000AB RID: 171 RVA: 0x00005C27 File Offset: 0x00003E27
		public global::System.Windows.UIElement OriginalDragSource { get; internal set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00005C30 File Offset: 0x00003E30
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00005C38 File Offset: 0x00003E38
		public global::System.Windows.UIElement CustomMouseHolder { get; set; }
	}
}
