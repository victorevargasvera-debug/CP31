using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000086 RID: 134
	public enum ShapeTypes
	{
		// Token: 0x0400027F RID: 639
		None,
		// Token: 0x04000280 RID: 640
		Line,
		// Token: 0x04000281 RID: 641
		LineInv,
		// Token: 0x04000282 RID: 642
		Triangle,
		// Token: 0x04000283 RID: 643
		RightTriangle,
		// Token: 0x04000284 RID: 644
		Rectangle,
		// Token: 0x04000285 RID: 645
		Diamond,
		// Token: 0x04000286 RID: 646
		Parallelogram,
		// Token: 0x04000287 RID: 647
		Trapezoid,
		// Token: 0x04000288 RID: 648
		NonIsoscelesTrapezoid,
		// Token: 0x04000289 RID: 649
		Pentagon,
		// Token: 0x0400028A RID: 650
		Hexagon,
		// Token: 0x0400028B RID: 651
		Heptagon,
		// Token: 0x0400028C RID: 652
		Octagon,
		// Token: 0x0400028D RID: 653
		Decagon,
		// Token: 0x0400028E RID: 654
		Dodecagon,
		// Token: 0x0400028F RID: 655
		Star4,
		// Token: 0x04000290 RID: 656
		Star5,
		// Token: 0x04000291 RID: 657
		Star6,
		// Token: 0x04000292 RID: 658
		Star7,
		// Token: 0x04000293 RID: 659
		Star8,
		// Token: 0x04000294 RID: 660
		Star10,
		// Token: 0x04000295 RID: 661
		Star12,
		// Token: 0x04000296 RID: 662
		Star16,
		// Token: 0x04000297 RID: 663
		Star24,
		// Token: 0x04000298 RID: 664
		Star32,
		// Token: 0x04000299 RID: 665
		RoundedRectangle,
		// Token: 0x0400029A RID: 666
		Rounded1Rectangle,
		// Token: 0x0400029B RID: 667
		Rounded2SameRectangle,
		// Token: 0x0400029C RID: 668
		Rounded2DiagonalRectangle,
		// Token: 0x0400029D RID: 669
		SnipRoundedRectangle,
		// Token: 0x0400029E RID: 670
		Snip1Rectangle,
		// Token: 0x0400029F RID: 671
		Snip2SameRectangle,
		// Token: 0x040002A0 RID: 672
		Snip2DiagonalRectangle,
		// Token: 0x040002A1 RID: 673
		Plaque,
		// Token: 0x040002A2 RID: 674
		Ellipse,
		// Token: 0x040002A3 RID: 675
		Teardrop,
		// Token: 0x040002A4 RID: 676
		HomePlate,
		// Token: 0x040002A5 RID: 677
		Chevron,
		// Token: 0x040002A6 RID: 678
		PieWedge,
		// Token: 0x040002A7 RID: 679
		Pie,
		// Token: 0x040002A8 RID: 680
		BlockArc,
		// Token: 0x040002A9 RID: 681
		Donut,
		// Token: 0x040002AA RID: 682
		NoSmoking,
		// Token: 0x040002AB RID: 683
		RightArrow,
		// Token: 0x040002AC RID: 684
		LeftArrow,
		// Token: 0x040002AD RID: 685
		UpArrow,
		// Token: 0x040002AE RID: 686
		DownArrow,
		// Token: 0x040002AF RID: 687
		StripedRightArrow,
		// Token: 0x040002B0 RID: 688
		NotchedRightArrow,
		// Token: 0x040002B1 RID: 689
		BentUpArrow,
		// Token: 0x040002B2 RID: 690
		LeftRightArrow,
		// Token: 0x040002B3 RID: 691
		UpDownArrow,
		// Token: 0x040002B4 RID: 692
		LeftUpArrow,
		// Token: 0x040002B5 RID: 693
		LeftRightUpArrow,
		// Token: 0x040002B6 RID: 694
		QuadArrow,
		// Token: 0x040002B7 RID: 695
		LeftArrowCallout,
		// Token: 0x040002B8 RID: 696
		RightArrowCallout,
		// Token: 0x040002B9 RID: 697
		UpArrowCallout,
		// Token: 0x040002BA RID: 698
		DownArrowCallout,
		// Token: 0x040002BB RID: 699
		LeftRightArrowCallout,
		// Token: 0x040002BC RID: 700
		UpDownArrowCallout,
		// Token: 0x040002BD RID: 701
		QuadArrowCallout,
		// Token: 0x040002BE RID: 702
		BentArrow,
		// Token: 0x040002BF RID: 703
		UTurnArrow,
		// Token: 0x040002C0 RID: 704
		CircularArrow,
		// Token: 0x040002C1 RID: 705
		LeftCircularArrow,
		// Token: 0x040002C2 RID: 706
		LeftRightCircularArrow,
		// Token: 0x040002C3 RID: 707
		CurvedRightArrow,
		// Token: 0x040002C4 RID: 708
		CurvedLeftArrow,
		// Token: 0x040002C5 RID: 709
		CurvedUpArrow,
		// Token: 0x040002C6 RID: 710
		CurvedDownArrow,
		// Token: 0x040002C7 RID: 711
		SwooshArrow,
		// Token: 0x040002C8 RID: 712
		Cube,
		// Token: 0x040002C9 RID: 713
		Can,
		// Token: 0x040002CA RID: 714
		LightningBolt,
		// Token: 0x040002CB RID: 715
		Heart,
		// Token: 0x040002CC RID: 716
		Sun,
		// Token: 0x040002CD RID: 717
		Moon,
		// Token: 0x040002CE RID: 718
		SmileyFace,
		// Token: 0x040002CF RID: 719
		IrregularSeal1,
		// Token: 0x040002D0 RID: 720
		IrregularSeal2,
		// Token: 0x040002D1 RID: 721
		FoldedCorner,
		// Token: 0x040002D2 RID: 722
		Bevel,
		// Token: 0x040002D3 RID: 723
		Frame,
		// Token: 0x040002D4 RID: 724
		HalfFrame,
		// Token: 0x040002D5 RID: 725
		Corner,
		// Token: 0x040002D6 RID: 726
		DiagonalStripe,
		// Token: 0x040002D7 RID: 727
		Chord,
		// Token: 0x040002D8 RID: 728
		Arc,
		// Token: 0x040002D9 RID: 729
		LeftBracket,
		// Token: 0x040002DA RID: 730
		RightBracket,
		// Token: 0x040002DB RID: 731
		LeftBrace,
		// Token: 0x040002DC RID: 732
		RightBrace,
		// Token: 0x040002DD RID: 733
		BracketPair,
		// Token: 0x040002DE RID: 734
		BracePair,
		// Token: 0x040002DF RID: 735
		StraightConnector1,
		// Token: 0x040002E0 RID: 736
		BentConnector2,
		// Token: 0x040002E1 RID: 737
		BentConnector3,
		// Token: 0x040002E2 RID: 738
		BentConnector4,
		// Token: 0x040002E3 RID: 739
		BentConnector5,
		// Token: 0x040002E4 RID: 740
		CurvedConnector2,
		// Token: 0x040002E5 RID: 741
		CurvedConnector3,
		// Token: 0x040002E6 RID: 742
		CurvedConnector4,
		// Token: 0x040002E7 RID: 743
		CurvedConnector5,
		// Token: 0x040002E8 RID: 744
		Callout1,
		// Token: 0x040002E9 RID: 745
		Callout2,
		// Token: 0x040002EA RID: 746
		Callout3,
		// Token: 0x040002EB RID: 747
		AccentCallout1,
		// Token: 0x040002EC RID: 748
		AccentCallout2,
		// Token: 0x040002ED RID: 749
		AccentCallout3,
		// Token: 0x040002EE RID: 750
		BorderCallout1,
		// Token: 0x040002EF RID: 751
		BorderCallout2,
		// Token: 0x040002F0 RID: 752
		BorderCallout3,
		// Token: 0x040002F1 RID: 753
		AccentBorderCallout1,
		// Token: 0x040002F2 RID: 754
		AccentBorderCallout2,
		// Token: 0x040002F3 RID: 755
		AccentBorderCallout3,
		// Token: 0x040002F4 RID: 756
		WedgeRectangleCallout,
		// Token: 0x040002F5 RID: 757
		WedgeRoundRectangleCallout,
		// Token: 0x040002F6 RID: 758
		WedgeEllipseCallout,
		// Token: 0x040002F7 RID: 759
		CloudCallout,
		// Token: 0x040002F8 RID: 760
		Cloud,
		// Token: 0x040002F9 RID: 761
		Ribbon,
		// Token: 0x040002FA RID: 762
		Ribbon2,
		// Token: 0x040002FB RID: 763
		EllipseRibbon,
		// Token: 0x040002FC RID: 764
		EllipseRibbon2,
		// Token: 0x040002FD RID: 765
		LeftRightRibbon,
		// Token: 0x040002FE RID: 766
		VerticalScroll,
		// Token: 0x040002FF RID: 767
		HorizontalScroll,
		// Token: 0x04000300 RID: 768
		Wave,
		// Token: 0x04000301 RID: 769
		DoubleWave,
		// Token: 0x04000302 RID: 770
		Plus,
		// Token: 0x04000303 RID: 771
		FlowChartProcess,
		// Token: 0x04000304 RID: 772
		FlowChartDecision,
		// Token: 0x04000305 RID: 773
		FlowChartInputOutput,
		// Token: 0x04000306 RID: 774
		FlowChartPredefinedProcess,
		// Token: 0x04000307 RID: 775
		FlowChartInternalStorage,
		// Token: 0x04000308 RID: 776
		FlowChartDocument,
		// Token: 0x04000309 RID: 777
		FlowChartMultiDocument,
		// Token: 0x0400030A RID: 778
		FlowChartTerminator,
		// Token: 0x0400030B RID: 779
		FlowChartPreparation,
		// Token: 0x0400030C RID: 780
		FlowChartManualInput,
		// Token: 0x0400030D RID: 781
		FlowChartManualOperation,
		// Token: 0x0400030E RID: 782
		FlowChartConnector,
		// Token: 0x0400030F RID: 783
		FlowChartPunchedCard,
		// Token: 0x04000310 RID: 784
		FlowChartPunchedTape,
		// Token: 0x04000311 RID: 785
		FlowChartSummingJunction,
		// Token: 0x04000312 RID: 786
		FlowChartOr,
		// Token: 0x04000313 RID: 787
		FlowChartCollate,
		// Token: 0x04000314 RID: 788
		FlowChartSort,
		// Token: 0x04000315 RID: 789
		FlowChartExtract,
		// Token: 0x04000316 RID: 790
		FlowChartMerge,
		// Token: 0x04000317 RID: 791
		FlowChartOfflineStorage,
		// Token: 0x04000318 RID: 792
		FlowChartOnlineStorage,
		// Token: 0x04000319 RID: 793
		FlowChartMagneticTape,
		// Token: 0x0400031A RID: 794
		FlowChartMagneticDisk,
		// Token: 0x0400031B RID: 795
		FlowChartMagneticDrum,
		// Token: 0x0400031C RID: 796
		FlowChartDisplay,
		// Token: 0x0400031D RID: 797
		FlowChartDelay,
		// Token: 0x0400031E RID: 798
		FlowChartAlternateProcess,
		// Token: 0x0400031F RID: 799
		FlowChartOffpageConnector,
		// Token: 0x04000320 RID: 800
		ActionButtonBlank,
		// Token: 0x04000321 RID: 801
		ActionButtonHome,
		// Token: 0x04000322 RID: 802
		ActionButtonHelp,
		// Token: 0x04000323 RID: 803
		ActionButtonInformation,
		// Token: 0x04000324 RID: 804
		ActionButtonForwardNext,
		// Token: 0x04000325 RID: 805
		ActionButtonBackPrevious,
		// Token: 0x04000326 RID: 806
		ActionButtonEnd,
		// Token: 0x04000327 RID: 807
		ActionButtonBeginning,
		// Token: 0x04000328 RID: 808
		ActionButtonReturn,
		// Token: 0x04000329 RID: 809
		ActionButtonDocument,
		// Token: 0x0400032A RID: 810
		ActionButtonSound,
		// Token: 0x0400032B RID: 811
		ActionButtonMovie,
		// Token: 0x0400032C RID: 812
		Gear6,
		// Token: 0x0400032D RID: 813
		Gear9,
		// Token: 0x0400032E RID: 814
		Funnel,
		// Token: 0x0400032F RID: 815
		MathPlus,
		// Token: 0x04000330 RID: 816
		MathMinus,
		// Token: 0x04000331 RID: 817
		MathMultiply,
		// Token: 0x04000332 RID: 818
		MathDivide,
		// Token: 0x04000333 RID: 819
		MathEqual,
		// Token: 0x04000334 RID: 820
		MathNotEqual,
		// Token: 0x04000335 RID: 821
		CornerTabs,
		// Token: 0x04000336 RID: 822
		SquareTabs,
		// Token: 0x04000337 RID: 823
		PlaqueTabs,
		// Token: 0x04000338 RID: 824
		ChartX,
		// Token: 0x04000339 RID: 825
		ChartStar,
		// Token: 0x0400033A RID: 826
		ChartPlus
	}
}
