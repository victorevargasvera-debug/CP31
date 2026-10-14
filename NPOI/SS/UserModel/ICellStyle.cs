using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200004E RID: 78
	public interface ICellStyle
	{
		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002D0 RID: 720
		// (set) Token: 0x060002D1 RID: 721
		bool ShrinkToFit { get; set; }

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002D2 RID: 722
		short Index { get; }

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002D3 RID: 723
		// (set) Token: 0x060002D4 RID: 724
		short DataFormat { get; set; }

		// Token: 0x060002D5 RID: 725
		string GetDataFormatString();

		// Token: 0x060002D6 RID: 726
		void SetFont(global::NPOI.SS.UserModel.IFont font);

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002D7 RID: 727
		short FontIndex { get; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002D8 RID: 728
		// (set) Token: 0x060002D9 RID: 729
		bool IsHidden { get; set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002DA RID: 730
		// (set) Token: 0x060002DB RID: 731
		bool IsLocked { get; set; }

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002DC RID: 732
		// (set) Token: 0x060002DD RID: 733
		global::NPOI.SS.UserModel.HorizontalAlignment Alignment { get; set; }

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002DE RID: 734
		// (set) Token: 0x060002DF RID: 735
		bool WrapText { get; set; }

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060002E0 RID: 736
		// (set) Token: 0x060002E1 RID: 737
		global::NPOI.SS.UserModel.VerticalAlignment VerticalAlignment { get; set; }

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060002E2 RID: 738
		// (set) Token: 0x060002E3 RID: 739
		short Rotation { get; set; }

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060002E4 RID: 740
		// (set) Token: 0x060002E5 RID: 741
		short Indention { get; set; }

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002E6 RID: 742
		// (set) Token: 0x060002E7 RID: 743
		global::NPOI.SS.UserModel.BorderStyle BorderLeft { get; set; }

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002E8 RID: 744
		// (set) Token: 0x060002E9 RID: 745
		global::NPOI.SS.UserModel.BorderStyle BorderRight { get; set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002EA RID: 746
		// (set) Token: 0x060002EB RID: 747
		global::NPOI.SS.UserModel.BorderStyle BorderTop { get; set; }

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002EC RID: 748
		// (set) Token: 0x060002ED RID: 749
		global::NPOI.SS.UserModel.BorderStyle BorderBottom { get; set; }

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002EE RID: 750
		// (set) Token: 0x060002EF RID: 751
		short LeftBorderColor { get; set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002F0 RID: 752
		// (set) Token: 0x060002F1 RID: 753
		short RightBorderColor { get; set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002F2 RID: 754
		// (set) Token: 0x060002F3 RID: 755
		short TopBorderColor { get; set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002F4 RID: 756
		// (set) Token: 0x060002F5 RID: 757
		short BottomBorderColor { get; set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002F6 RID: 758
		// (set) Token: 0x060002F7 RID: 759
		global::NPOI.SS.UserModel.FillPattern FillPattern { get; set; }

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060002F8 RID: 760
		// (set) Token: 0x060002F9 RID: 761
		short FillBackgroundColor { get; set; }

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060002FA RID: 762
		// (set) Token: 0x060002FB RID: 763
		short FillForegroundColor { get; set; }

		// Token: 0x060002FC RID: 764
		void CloneStyleFrom(global::NPOI.SS.UserModel.ICellStyle source);

		// Token: 0x060002FD RID: 765
		global::NPOI.SS.UserModel.IFont GetFont(global::NPOI.SS.UserModel.IWorkbook parentWorkbook);

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060002FE RID: 766
		// (set) Token: 0x060002FF RID: 767
		short BorderDiagonalColor { get; set; }

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000300 RID: 768
		// (set) Token: 0x06000301 RID: 769
		global::NPOI.SS.UserModel.BorderStyle BorderDiagonalLineStyle { get; set; }

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000302 RID: 770
		// (set) Token: 0x06000303 RID: 771
		global::NPOI.SS.UserModel.BorderDiagonal BorderDiagonal { get; set; }

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000304 RID: 772
		global::NPOI.SS.UserModel.IColor FillBackgroundColorColor { get; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000305 RID: 773
		global::NPOI.SS.UserModel.IColor FillForegroundColorColor { get; }
	}
}
