using System;
using System.Collections.Generic;

namespace CefSharp.Wpf.Handler
{
	// Token: 0x0200001C RID: 28
	public class ContextMenuExecuteModel
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x000067E2 File Offset: 0x000049E2
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x000067EA File Offset: 0x000049EA
		public global::CefSharp.CefMenuCommand MenuCommand { get; private set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000067F3 File Offset: 0x000049F3
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x000067FB File Offset: 0x000049FB
		public global::System.Collections.Generic.IList<string> DictionarySuggestions { get; private set; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001AA RID: 426 RVA: 0x00006804 File Offset: 0x00004A04
		// (set) Token: 0x060001AB RID: 427 RVA: 0x0000680C File Offset: 0x00004A0C
		public int XCoord { get; private set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001AC RID: 428 RVA: 0x00006815 File Offset: 0x00004A15
		// (set) Token: 0x060001AD RID: 429 RVA: 0x0000681D File Offset: 0x00004A1D
		public int YCoord { get; private set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00006826 File Offset: 0x00004A26
		// (set) Token: 0x060001AF RID: 431 RVA: 0x0000682E File Offset: 0x00004A2E
		public string SelectionText { get; private set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00006837 File Offset: 0x00004A37
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x0000683F File Offset: 0x00004A3F
		public string MisspelledWord { get; private set; }

		// Token: 0x060001B2 RID: 434 RVA: 0x00006848 File Offset: 0x00004A48
		public ContextMenuExecuteModel(global::CefSharp.CefMenuCommand menuCommand, global::System.Collections.Generic.IList<string> dictionarySuggestions, int xCoord, int yCoord, string selectionText, string misspelledWord)
		{
			this.MenuCommand = menuCommand;
			this.DictionarySuggestions = dictionarySuggestions;
			this.XCoord = xCoord;
			this.YCoord = yCoord;
			this.SelectionText = selectionText;
			this.MisspelledWord = misspelledWord;
		}
	}
}
