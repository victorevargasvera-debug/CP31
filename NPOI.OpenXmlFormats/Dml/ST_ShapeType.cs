using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Dml
{
	// Token: 0x020002DA RID: 730
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/drawingml/2006/main")]
	[global::System.Serializable]
	public enum ST_ShapeType
	{
		// Token: 0x0400164B RID: 5707
		none,
		// Token: 0x0400164C RID: 5708
		line,
		// Token: 0x0400164D RID: 5709
		lineInv,
		// Token: 0x0400164E RID: 5710
		triangle,
		// Token: 0x0400164F RID: 5711
		rtTriangle,
		// Token: 0x04001650 RID: 5712
		rect,
		// Token: 0x04001651 RID: 5713
		diamond,
		// Token: 0x04001652 RID: 5714
		parallelogram,
		// Token: 0x04001653 RID: 5715
		trapezoid,
		// Token: 0x04001654 RID: 5716
		nonIsoscelesTrapezoid,
		// Token: 0x04001655 RID: 5717
		pentagon,
		// Token: 0x04001656 RID: 5718
		hexagon,
		// Token: 0x04001657 RID: 5719
		heptagon,
		// Token: 0x04001658 RID: 5720
		octagon,
		// Token: 0x04001659 RID: 5721
		decagon,
		// Token: 0x0400165A RID: 5722
		dodecagon,
		// Token: 0x0400165B RID: 5723
		star4,
		// Token: 0x0400165C RID: 5724
		star5,
		// Token: 0x0400165D RID: 5725
		star6,
		// Token: 0x0400165E RID: 5726
		star7,
		// Token: 0x0400165F RID: 5727
		star8,
		// Token: 0x04001660 RID: 5728
		star10,
		// Token: 0x04001661 RID: 5729
		star12,
		// Token: 0x04001662 RID: 5730
		star16,
		// Token: 0x04001663 RID: 5731
		star24,
		// Token: 0x04001664 RID: 5732
		star32,
		// Token: 0x04001665 RID: 5733
		roundRect,
		// Token: 0x04001666 RID: 5734
		round1Rect,
		// Token: 0x04001667 RID: 5735
		round2SameRect,
		// Token: 0x04001668 RID: 5736
		round2DiagRect,
		// Token: 0x04001669 RID: 5737
		snipRoundRect,
		// Token: 0x0400166A RID: 5738
		snip1Rect,
		// Token: 0x0400166B RID: 5739
		snip2SameRect,
		// Token: 0x0400166C RID: 5740
		snip2DiagRect,
		// Token: 0x0400166D RID: 5741
		plaque,
		// Token: 0x0400166E RID: 5742
		ellipse,
		// Token: 0x0400166F RID: 5743
		teardrop,
		// Token: 0x04001670 RID: 5744
		homePlate,
		// Token: 0x04001671 RID: 5745
		chevron,
		// Token: 0x04001672 RID: 5746
		pieWedge,
		// Token: 0x04001673 RID: 5747
		pie,
		// Token: 0x04001674 RID: 5748
		blockArc,
		// Token: 0x04001675 RID: 5749
		donut,
		// Token: 0x04001676 RID: 5750
		noSmoking,
		// Token: 0x04001677 RID: 5751
		rightArrow,
		// Token: 0x04001678 RID: 5752
		leftArrow,
		// Token: 0x04001679 RID: 5753
		upArrow,
		// Token: 0x0400167A RID: 5754
		downArrow,
		// Token: 0x0400167B RID: 5755
		stripedRightArrow,
		// Token: 0x0400167C RID: 5756
		notchedRightArrow,
		// Token: 0x0400167D RID: 5757
		bentUpArrow,
		// Token: 0x0400167E RID: 5758
		leftRightArrow,
		// Token: 0x0400167F RID: 5759
		upDownArrow,
		// Token: 0x04001680 RID: 5760
		leftUpArrow,
		// Token: 0x04001681 RID: 5761
		leftRightUpArrow,
		// Token: 0x04001682 RID: 5762
		quadArrow,
		// Token: 0x04001683 RID: 5763
		leftArrowCallout,
		// Token: 0x04001684 RID: 5764
		rightArrowCallout,
		// Token: 0x04001685 RID: 5765
		upArrowCallout,
		// Token: 0x04001686 RID: 5766
		downArrowCallout,
		// Token: 0x04001687 RID: 5767
		leftRightArrowCallout,
		// Token: 0x04001688 RID: 5768
		upDownArrowCallout,
		// Token: 0x04001689 RID: 5769
		quadArrowCallout,
		// Token: 0x0400168A RID: 5770
		bentArrow,
		// Token: 0x0400168B RID: 5771
		uturnArrow,
		// Token: 0x0400168C RID: 5772
		circularArrow,
		// Token: 0x0400168D RID: 5773
		leftCircularArrow,
		// Token: 0x0400168E RID: 5774
		leftRightCircularArrow,
		// Token: 0x0400168F RID: 5775
		curvedRightArrow,
		// Token: 0x04001690 RID: 5776
		curvedLeftArrow,
		// Token: 0x04001691 RID: 5777
		curvedUpArrow,
		// Token: 0x04001692 RID: 5778
		curvedDownArrow,
		// Token: 0x04001693 RID: 5779
		swooshArrow,
		// Token: 0x04001694 RID: 5780
		cube,
		// Token: 0x04001695 RID: 5781
		can,
		// Token: 0x04001696 RID: 5782
		lightningBolt,
		// Token: 0x04001697 RID: 5783
		heart,
		// Token: 0x04001698 RID: 5784
		sun,
		// Token: 0x04001699 RID: 5785
		moon,
		// Token: 0x0400169A RID: 5786
		smileyFace,
		// Token: 0x0400169B RID: 5787
		irregularSeal1,
		// Token: 0x0400169C RID: 5788
		irregularSeal2,
		// Token: 0x0400169D RID: 5789
		foldedCorner,
		// Token: 0x0400169E RID: 5790
		bevel,
		// Token: 0x0400169F RID: 5791
		frame,
		// Token: 0x040016A0 RID: 5792
		halfFrame,
		// Token: 0x040016A1 RID: 5793
		corner,
		// Token: 0x040016A2 RID: 5794
		diagStripe,
		// Token: 0x040016A3 RID: 5795
		chord,
		// Token: 0x040016A4 RID: 5796
		arc,
		// Token: 0x040016A5 RID: 5797
		leftBracket,
		// Token: 0x040016A6 RID: 5798
		rightBracket,
		// Token: 0x040016A7 RID: 5799
		leftBrace,
		// Token: 0x040016A8 RID: 5800
		rightBrace,
		// Token: 0x040016A9 RID: 5801
		bracketPair,
		// Token: 0x040016AA RID: 5802
		bracePair,
		// Token: 0x040016AB RID: 5803
		straightConnector1,
		// Token: 0x040016AC RID: 5804
		bentConnector2,
		// Token: 0x040016AD RID: 5805
		bentConnector3,
		// Token: 0x040016AE RID: 5806
		bentConnector4,
		// Token: 0x040016AF RID: 5807
		bentConnector5,
		// Token: 0x040016B0 RID: 5808
		curvedConnector2,
		// Token: 0x040016B1 RID: 5809
		curvedConnector3,
		// Token: 0x040016B2 RID: 5810
		curvedConnector4,
		// Token: 0x040016B3 RID: 5811
		curvedConnector5,
		// Token: 0x040016B4 RID: 5812
		callout1,
		// Token: 0x040016B5 RID: 5813
		callout2,
		// Token: 0x040016B6 RID: 5814
		callout3,
		// Token: 0x040016B7 RID: 5815
		accentCallout1,
		// Token: 0x040016B8 RID: 5816
		accentCallout2,
		// Token: 0x040016B9 RID: 5817
		accentCallout3,
		// Token: 0x040016BA RID: 5818
		borderCallout1,
		// Token: 0x040016BB RID: 5819
		borderCallout2,
		// Token: 0x040016BC RID: 5820
		borderCallout3,
		// Token: 0x040016BD RID: 5821
		accentBorderCallout1,
		// Token: 0x040016BE RID: 5822
		accentBorderCallout2,
		// Token: 0x040016BF RID: 5823
		accentBorderCallout3,
		// Token: 0x040016C0 RID: 5824
		wedgeRectCallout,
		// Token: 0x040016C1 RID: 5825
		wedgeRoundRectCallout,
		// Token: 0x040016C2 RID: 5826
		wedgeEllipseCallout,
		// Token: 0x040016C3 RID: 5827
		cloudCallout,
		// Token: 0x040016C4 RID: 5828
		cloud,
		// Token: 0x040016C5 RID: 5829
		ribbon,
		// Token: 0x040016C6 RID: 5830
		ribbon2,
		// Token: 0x040016C7 RID: 5831
		ellipseRibbon,
		// Token: 0x040016C8 RID: 5832
		ellipseRibbon2,
		// Token: 0x040016C9 RID: 5833
		leftRightRibbon,
		// Token: 0x040016CA RID: 5834
		verticalScroll,
		// Token: 0x040016CB RID: 5835
		horizontalScroll,
		// Token: 0x040016CC RID: 5836
		wave,
		// Token: 0x040016CD RID: 5837
		doubleWave,
		// Token: 0x040016CE RID: 5838
		plus,
		// Token: 0x040016CF RID: 5839
		flowChartProcess,
		// Token: 0x040016D0 RID: 5840
		flowChartDecision,
		// Token: 0x040016D1 RID: 5841
		flowChartInputOutput,
		// Token: 0x040016D2 RID: 5842
		flowChartPredefinedProcess,
		// Token: 0x040016D3 RID: 5843
		flowChartInternalStorage,
		// Token: 0x040016D4 RID: 5844
		flowChartDocument,
		// Token: 0x040016D5 RID: 5845
		flowChartMultidocument,
		// Token: 0x040016D6 RID: 5846
		flowChartTerminator,
		// Token: 0x040016D7 RID: 5847
		flowChartPreparation,
		// Token: 0x040016D8 RID: 5848
		flowChartManualInput,
		// Token: 0x040016D9 RID: 5849
		flowChartManualOperation,
		// Token: 0x040016DA RID: 5850
		flowChartConnector,
		// Token: 0x040016DB RID: 5851
		flowChartPunchedCard,
		// Token: 0x040016DC RID: 5852
		flowChartPunchedTape,
		// Token: 0x040016DD RID: 5853
		flowChartSummingJunction,
		// Token: 0x040016DE RID: 5854
		flowChartOr,
		// Token: 0x040016DF RID: 5855
		flowChartCollate,
		// Token: 0x040016E0 RID: 5856
		flowChartSort,
		// Token: 0x040016E1 RID: 5857
		flowChartExtract,
		// Token: 0x040016E2 RID: 5858
		flowChartMerge,
		// Token: 0x040016E3 RID: 5859
		flowChartOfflineStorage,
		// Token: 0x040016E4 RID: 5860
		flowChartOnlineStorage,
		// Token: 0x040016E5 RID: 5861
		flowChartMagneticTape,
		// Token: 0x040016E6 RID: 5862
		flowChartMagneticDisk,
		// Token: 0x040016E7 RID: 5863
		flowChartMagneticDrum,
		// Token: 0x040016E8 RID: 5864
		flowChartDisplay,
		// Token: 0x040016E9 RID: 5865
		flowChartDelay,
		// Token: 0x040016EA RID: 5866
		flowChartAlternateProcess,
		// Token: 0x040016EB RID: 5867
		flowChartOffpageConnector,
		// Token: 0x040016EC RID: 5868
		actionButtonBlank,
		// Token: 0x040016ED RID: 5869
		actionButtonHome,
		// Token: 0x040016EE RID: 5870
		actionButtonHelp,
		// Token: 0x040016EF RID: 5871
		actionButtonInformation,
		// Token: 0x040016F0 RID: 5872
		actionButtonForwardNext,
		// Token: 0x040016F1 RID: 5873
		actionButtonBackPrevious,
		// Token: 0x040016F2 RID: 5874
		actionButtonEnd,
		// Token: 0x040016F3 RID: 5875
		actionButtonBeginning,
		// Token: 0x040016F4 RID: 5876
		actionButtonReturn,
		// Token: 0x040016F5 RID: 5877
		actionButtonDocument,
		// Token: 0x040016F6 RID: 5878
		actionButtonSound,
		// Token: 0x040016F7 RID: 5879
		actionButtonMovie,
		// Token: 0x040016F8 RID: 5880
		gear6,
		// Token: 0x040016F9 RID: 5881
		gear9,
		// Token: 0x040016FA RID: 5882
		funnel,
		// Token: 0x040016FB RID: 5883
		mathPlus,
		// Token: 0x040016FC RID: 5884
		mathMinus,
		// Token: 0x040016FD RID: 5885
		mathMultiply,
		// Token: 0x040016FE RID: 5886
		mathDivide,
		// Token: 0x040016FF RID: 5887
		mathEqual,
		// Token: 0x04001700 RID: 5888
		mathNotEqual,
		// Token: 0x04001701 RID: 5889
		cornerTabs,
		// Token: 0x04001702 RID: 5890
		squareTabs,
		// Token: 0x04001703 RID: 5891
		plaqueTabs,
		// Token: 0x04001704 RID: 5892
		chartX,
		// Token: 0x04001705 RID: 5893
		chartStar,
		// Token: 0x04001706 RID: 5894
		chartPlus
	}
}
