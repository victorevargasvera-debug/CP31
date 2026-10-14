using System;
using System.Collections;

namespace NPOI.DDF
{
	// Token: 0x02000540 RID: 1344
	public class EscherProperties
	{
		// Token: 0x060032D0 RID: 13008 RVA: 0x0009D9C0 File Offset: 0x0009BBC0
		private static void InitProps()
		{
			if (global::NPOI.DDF.EscherProperties.properties == null)
			{
				global::NPOI.DDF.EscherProperties.properties = new global::System.Collections.Hashtable();
				global::NPOI.DDF.EscherProperties.AddProp(4, global::NPOI.DDF.EscherProperties.GetData("transform.rotation"));
				global::NPOI.DDF.EscherProperties.AddProp(119, global::NPOI.DDF.EscherProperties.GetData("protection.lockrotation"));
				global::NPOI.DDF.EscherProperties.AddProp(120, global::NPOI.DDF.EscherProperties.GetData("protection.lockaspectratio"));
				global::NPOI.DDF.EscherProperties.AddProp(121, global::NPOI.DDF.EscherProperties.GetData("protection.lockposition"));
				global::NPOI.DDF.EscherProperties.AddProp(122, global::NPOI.DDF.EscherProperties.GetData("protection.lockagainstselect"));
				global::NPOI.DDF.EscherProperties.AddProp(123, global::NPOI.DDF.EscherProperties.GetData("protection.lockcropping"));
				global::NPOI.DDF.EscherProperties.AddProp(124, global::NPOI.DDF.EscherProperties.GetData("protection.lockvertices"));
				global::NPOI.DDF.EscherProperties.AddProp(125, global::NPOI.DDF.EscherProperties.GetData("protection.locktext"));
				global::NPOI.DDF.EscherProperties.AddProp(126, global::NPOI.DDF.EscherProperties.GetData("protection.lockadjusthandles"));
				global::NPOI.DDF.EscherProperties.AddProp(127, global::NPOI.DDF.EscherProperties.GetData("protection.lockagainstgrouping", 1));
				global::NPOI.DDF.EscherProperties.AddProp(128, global::NPOI.DDF.EscherProperties.GetData("text.textid"));
				global::NPOI.DDF.EscherProperties.AddProp(129, global::NPOI.DDF.EscherProperties.GetData("text.textleft"));
				global::NPOI.DDF.EscherProperties.AddProp(130, global::NPOI.DDF.EscherProperties.GetData("text.texttop"));
				global::NPOI.DDF.EscherProperties.AddProp(131, global::NPOI.DDF.EscherProperties.GetData("text.textright"));
				global::NPOI.DDF.EscherProperties.AddProp(132, global::NPOI.DDF.EscherProperties.GetData("text.textbottom"));
				global::NPOI.DDF.EscherProperties.AddProp(133, global::NPOI.DDF.EscherProperties.GetData("text.wraptext"));
				global::NPOI.DDF.EscherProperties.AddProp(134, global::NPOI.DDF.EscherProperties.GetData("text.scaletext"));
				global::NPOI.DDF.EscherProperties.AddProp(135, global::NPOI.DDF.EscherProperties.GetData("text.anchortext"));
				global::NPOI.DDF.EscherProperties.AddProp(136, global::NPOI.DDF.EscherProperties.GetData("text.textflow"));
				global::NPOI.DDF.EscherProperties.AddProp(137, global::NPOI.DDF.EscherProperties.GetData("text.fontrotation"));
				global::NPOI.DDF.EscherProperties.AddProp(138, global::NPOI.DDF.EscherProperties.GetData("text.idofnextshape"));
				global::NPOI.DDF.EscherProperties.AddProp(139, global::NPOI.DDF.EscherProperties.GetData("text.bidir"));
				global::NPOI.DDF.EscherProperties.AddProp(187, global::NPOI.DDF.EscherProperties.GetData("text.singleclickselects"));
				global::NPOI.DDF.EscherProperties.AddProp(188, global::NPOI.DDF.EscherProperties.GetData("text.usehostmargins"));
				global::NPOI.DDF.EscherProperties.AddProp(189, global::NPOI.DDF.EscherProperties.GetData("text.rotatetextwithshape"));
				global::NPOI.DDF.EscherProperties.AddProp(190, global::NPOI.DDF.EscherProperties.GetData("text.sizeshapetofittext"));
				global::NPOI.DDF.EscherProperties.AddProp(191, global::NPOI.DDF.EscherProperties.GetData("text.sizetexttofitshape", 1));
				global::NPOI.DDF.EscherProperties.AddProp(192, global::NPOI.DDF.EscherProperties.GetData("geotext.unicode"));
				global::NPOI.DDF.EscherProperties.AddProp(193, global::NPOI.DDF.EscherProperties.GetData("geotext.rtftext"));
				global::NPOI.DDF.EscherProperties.AddProp(194, global::NPOI.DDF.EscherProperties.GetData("geotext.alignmentoncurve"));
				global::NPOI.DDF.EscherProperties.AddProp(195, global::NPOI.DDF.EscherProperties.GetData("geotext.defaultpointsize"));
				global::NPOI.DDF.EscherProperties.AddProp(196, global::NPOI.DDF.EscherProperties.GetData("geotext.textspacing"));
				global::NPOI.DDF.EscherProperties.AddProp(197, global::NPOI.DDF.EscherProperties.GetData("geotext.fontfamilyname"));
				global::NPOI.DDF.EscherProperties.AddProp(240, global::NPOI.DDF.EscherProperties.GetData("geotext.reverseroworder"));
				global::NPOI.DDF.EscherProperties.AddProp(241, global::NPOI.DDF.EscherProperties.GetData("geotext.hastexteffect"));
				global::NPOI.DDF.EscherProperties.AddProp(242, global::NPOI.DDF.EscherProperties.GetData("geotext.rotatecharacters"));
				global::NPOI.DDF.EscherProperties.AddProp(243, global::NPOI.DDF.EscherProperties.GetData("geotext.kerncharacters"));
				global::NPOI.DDF.EscherProperties.AddProp(244, global::NPOI.DDF.EscherProperties.GetData("geotext.tightortrack"));
				global::NPOI.DDF.EscherProperties.AddProp(245, global::NPOI.DDF.EscherProperties.GetData("geotext.stretchtofitshape"));
				global::NPOI.DDF.EscherProperties.AddProp(246, global::NPOI.DDF.EscherProperties.GetData("geotext.charboundingbox"));
				global::NPOI.DDF.EscherProperties.AddProp(247, global::NPOI.DDF.EscherProperties.GetData("geotext.scaletextonpath"));
				global::NPOI.DDF.EscherProperties.AddProp(248, global::NPOI.DDF.EscherProperties.GetData("geotext.stretchcharheight"));
				global::NPOI.DDF.EscherProperties.AddProp(249, global::NPOI.DDF.EscherProperties.GetData("geotext.nomeasurealongpath"));
				global::NPOI.DDF.EscherProperties.AddProp(250, global::NPOI.DDF.EscherProperties.GetData("geotext.boldfont"));
				global::NPOI.DDF.EscherProperties.AddProp(251, global::NPOI.DDF.EscherProperties.GetData("geotext.italicfont"));
				global::NPOI.DDF.EscherProperties.AddProp(252, global::NPOI.DDF.EscherProperties.GetData("geotext.underlinefont"));
				global::NPOI.DDF.EscherProperties.AddProp(253, global::NPOI.DDF.EscherProperties.GetData("geotext.shadowfont"));
				global::NPOI.DDF.EscherProperties.AddProp(254, global::NPOI.DDF.EscherProperties.GetData("geotext.smallcapsfont"));
				global::NPOI.DDF.EscherProperties.AddProp(255, global::NPOI.DDF.EscherProperties.GetData("geotext.strikethroughfont"));
				global::NPOI.DDF.EscherProperties.AddProp(256, global::NPOI.DDF.EscherProperties.GetData("blip.cropfromtop"));
				global::NPOI.DDF.EscherProperties.AddProp(257, global::NPOI.DDF.EscherProperties.GetData("blip.cropfrombottom"));
				global::NPOI.DDF.EscherProperties.AddProp(258, global::NPOI.DDF.EscherProperties.GetData("blip.cropfromleft"));
				global::NPOI.DDF.EscherProperties.AddProp(259, global::NPOI.DDF.EscherProperties.GetData("blip.cropfromright"));
				global::NPOI.DDF.EscherProperties.AddProp(260, global::NPOI.DDF.EscherProperties.GetData("blip.bliptodisplay"));
				global::NPOI.DDF.EscherProperties.AddProp(261, global::NPOI.DDF.EscherProperties.GetData("blip.blipfilename"));
				global::NPOI.DDF.EscherProperties.AddProp(262, global::NPOI.DDF.EscherProperties.GetData("blip.blipflags"));
				global::NPOI.DDF.EscherProperties.AddProp(263, global::NPOI.DDF.EscherProperties.GetData("blip.transparentcolor"));
				global::NPOI.DDF.EscherProperties.AddProp(264, global::NPOI.DDF.EscherProperties.GetData("blip.contrastSetting"));
				global::NPOI.DDF.EscherProperties.AddProp(265, global::NPOI.DDF.EscherProperties.GetData("blip.brightnessSetting"));
				global::NPOI.DDF.EscherProperties.AddProp(266, global::NPOI.DDF.EscherProperties.GetData("blip.gamma"));
				global::NPOI.DDF.EscherProperties.AddProp(267, global::NPOI.DDF.EscherProperties.GetData("blip.pictureid"));
				global::NPOI.DDF.EscherProperties.AddProp(268, global::NPOI.DDF.EscherProperties.GetData("blip.doublemod"));
				global::NPOI.DDF.EscherProperties.AddProp(269, global::NPOI.DDF.EscherProperties.GetData("blip.pictureFillmod"));
				global::NPOI.DDF.EscherProperties.AddProp(270, global::NPOI.DDF.EscherProperties.GetData("blip.pictureline"));
				global::NPOI.DDF.EscherProperties.AddProp(271, global::NPOI.DDF.EscherProperties.GetData("blip.printblip"));
				global::NPOI.DDF.EscherProperties.AddProp(272, global::NPOI.DDF.EscherProperties.GetData("blip.printblipfilename"));
				global::NPOI.DDF.EscherProperties.AddProp(273, global::NPOI.DDF.EscherProperties.GetData("blip.printflags"));
				global::NPOI.DDF.EscherProperties.AddProp(316, global::NPOI.DDF.EscherProperties.GetData("blip.nohittestpicture"));
				global::NPOI.DDF.EscherProperties.AddProp(317, global::NPOI.DDF.EscherProperties.GetData("blip.picturegray"));
				global::NPOI.DDF.EscherProperties.AddProp(318, global::NPOI.DDF.EscherProperties.GetData("blip.picturebilevel"));
				global::NPOI.DDF.EscherProperties.AddProp(319, global::NPOI.DDF.EscherProperties.GetData("blip.pictureactive"));
				global::NPOI.DDF.EscherProperties.AddProp(320, global::NPOI.DDF.EscherProperties.GetData("geometry.left"));
				global::NPOI.DDF.EscherProperties.AddProp(321, global::NPOI.DDF.EscherProperties.GetData("geometry.top"));
				global::NPOI.DDF.EscherProperties.AddProp(322, global::NPOI.DDF.EscherProperties.GetData("geometry.right"));
				global::NPOI.DDF.EscherProperties.AddProp(323, global::NPOI.DDF.EscherProperties.GetData("geometry.bottom"));
				global::NPOI.DDF.EscherProperties.AddProp(324, global::NPOI.DDF.EscherProperties.GetData("geometry.shapepath", 3));
				global::NPOI.DDF.EscherProperties.AddProp(325, global::NPOI.DDF.EscherProperties.GetData("geometry.vertices", 5));
				global::NPOI.DDF.EscherProperties.AddProp(326, global::NPOI.DDF.EscherProperties.GetData("geometry.segmentinfo", 5));
				global::NPOI.DDF.EscherProperties.AddProp(327, global::NPOI.DDF.EscherProperties.GetData("geometry.adjustvalue"));
				global::NPOI.DDF.EscherProperties.AddProp(328, global::NPOI.DDF.EscherProperties.GetData("geometry.adjust2value"));
				global::NPOI.DDF.EscherProperties.AddProp(329, global::NPOI.DDF.EscherProperties.GetData("geometry.adjust3value"));
				global::NPOI.DDF.EscherProperties.AddProp(330, global::NPOI.DDF.EscherProperties.GetData("geometry.adjust4value"));
				global::NPOI.DDF.EscherProperties.AddProp(331, global::NPOI.DDF.EscherProperties.GetData("geometry.adjust5value"));
				global::NPOI.DDF.EscherProperties.AddProp(332, global::NPOI.DDF.EscherProperties.GetData("geometry.adjust6value"));
				global::NPOI.DDF.EscherProperties.AddProp(333, global::NPOI.DDF.EscherProperties.GetData("geometry.adjust7value"));
				global::NPOI.DDF.EscherProperties.AddProp(334, global::NPOI.DDF.EscherProperties.GetData("geometry.adjust8value"));
				global::NPOI.DDF.EscherProperties.AddProp(335, global::NPOI.DDF.EscherProperties.GetData("geometry.adjust9value"));
				global::NPOI.DDF.EscherProperties.AddProp(336, global::NPOI.DDF.EscherProperties.GetData("geometry.adjust10value"));
				global::NPOI.DDF.EscherProperties.AddProp(378, global::NPOI.DDF.EscherProperties.GetData("geometry.shadowOK"));
				global::NPOI.DDF.EscherProperties.AddProp(379, global::NPOI.DDF.EscherProperties.GetData("geometry.3dok"));
				global::NPOI.DDF.EscherProperties.AddProp(380, global::NPOI.DDF.EscherProperties.GetData("geometry.lineok"));
				global::NPOI.DDF.EscherProperties.AddProp(381, global::NPOI.DDF.EscherProperties.GetData("geometry.geotextok"));
				global::NPOI.DDF.EscherProperties.AddProp(382, global::NPOI.DDF.EscherProperties.GetData("geometry.fillshadeshapeok"));
				global::NPOI.DDF.EscherProperties.AddProp(383, global::NPOI.DDF.EscherProperties.GetData("geometry.fillok", 1));
				global::NPOI.DDF.EscherProperties.AddProp(384, global::NPOI.DDF.EscherProperties.GetData("fill.filltype"));
				global::NPOI.DDF.EscherProperties.AddProp(385, global::NPOI.DDF.EscherProperties.GetData("fill.fillcolor", 2));
				global::NPOI.DDF.EscherProperties.AddProp(386, global::NPOI.DDF.EscherProperties.GetData("fill.fillopacity"));
				global::NPOI.DDF.EscherProperties.AddProp(387, global::NPOI.DDF.EscherProperties.GetData("fill.fillbackcolor", 2));
				global::NPOI.DDF.EscherProperties.AddProp(388, global::NPOI.DDF.EscherProperties.GetData("fill.backopacity"));
				global::NPOI.DDF.EscherProperties.AddProp(389, global::NPOI.DDF.EscherProperties.GetData("fill.crmod"));
				global::NPOI.DDF.EscherProperties.AddProp(390, global::NPOI.DDF.EscherProperties.GetData("fill.patterntexture"));
				global::NPOI.DDF.EscherProperties.AddProp(391, global::NPOI.DDF.EscherProperties.GetData("fill.blipfilename"));
				global::NPOI.DDF.EscherProperties.AddProp(392, global::NPOI.DDF.EscherProperties.GetData("fill.blipflags"));
				global::NPOI.DDF.EscherProperties.AddProp(393, global::NPOI.DDF.EscherProperties.GetData("fill.width"));
				global::NPOI.DDF.EscherProperties.AddProp(394, global::NPOI.DDF.EscherProperties.GetData("fill.height"));
				global::NPOI.DDF.EscherProperties.AddProp(395, global::NPOI.DDF.EscherProperties.GetData("fill.angle"));
				global::NPOI.DDF.EscherProperties.AddProp(396, global::NPOI.DDF.EscherProperties.GetData("fill.focus"));
				global::NPOI.DDF.EscherProperties.AddProp(397, global::NPOI.DDF.EscherProperties.GetData("fill.toleft"));
				global::NPOI.DDF.EscherProperties.AddProp(398, global::NPOI.DDF.EscherProperties.GetData("fill.totop"));
				global::NPOI.DDF.EscherProperties.AddProp(399, global::NPOI.DDF.EscherProperties.GetData("fill.toright"));
				global::NPOI.DDF.EscherProperties.AddProp(400, global::NPOI.DDF.EscherProperties.GetData("fill.tobottom"));
				global::NPOI.DDF.EscherProperties.AddProp(401, global::NPOI.DDF.EscherProperties.GetData("fill.rectleft"));
				global::NPOI.DDF.EscherProperties.AddProp(402, global::NPOI.DDF.EscherProperties.GetData("fill.recttop"));
				global::NPOI.DDF.EscherProperties.AddProp(403, global::NPOI.DDF.EscherProperties.GetData("fill.rectright"));
				global::NPOI.DDF.EscherProperties.AddProp(404, global::NPOI.DDF.EscherProperties.GetData("fill.rectbottom"));
				global::NPOI.DDF.EscherProperties.AddProp(405, global::NPOI.DDF.EscherProperties.GetData("fill.dztype"));
				global::NPOI.DDF.EscherProperties.AddProp(406, global::NPOI.DDF.EscherProperties.GetData("fill.shadepReset"));
				global::NPOI.DDF.EscherProperties.AddProp(407, global::NPOI.DDF.EscherProperties.GetData("fill.shadecolors", 5));
				global::NPOI.DDF.EscherProperties.AddProp(408, global::NPOI.DDF.EscherProperties.GetData("fill.originx"));
				global::NPOI.DDF.EscherProperties.AddProp(409, global::NPOI.DDF.EscherProperties.GetData("fill.originy"));
				global::NPOI.DDF.EscherProperties.AddProp(410, global::NPOI.DDF.EscherProperties.GetData("fill.shapeoriginx"));
				global::NPOI.DDF.EscherProperties.AddProp(411, global::NPOI.DDF.EscherProperties.GetData("fill.shapeoriginy"));
				global::NPOI.DDF.EscherProperties.AddProp(412, global::NPOI.DDF.EscherProperties.GetData("fill.shadetype"));
				global::NPOI.DDF.EscherProperties.AddProp(443, global::NPOI.DDF.EscherProperties.GetData("fill.filled"));
				global::NPOI.DDF.EscherProperties.AddProp(444, global::NPOI.DDF.EscherProperties.GetData("fill.hittestfill"));
				global::NPOI.DDF.EscherProperties.AddProp(445, global::NPOI.DDF.EscherProperties.GetData("fill.shape"));
				global::NPOI.DDF.EscherProperties.AddProp(446, global::NPOI.DDF.EscherProperties.GetData("fill.userect"));
				global::NPOI.DDF.EscherProperties.AddProp(447, global::NPOI.DDF.EscherProperties.GetData("fill.nofillhittest", 1));
				global::NPOI.DDF.EscherProperties.AddProp(448, global::NPOI.DDF.EscherProperties.GetData("linestyle.color", 2));
				global::NPOI.DDF.EscherProperties.AddProp(449, global::NPOI.DDF.EscherProperties.GetData("linestyle.opacity"));
				global::NPOI.DDF.EscherProperties.AddProp(450, global::NPOI.DDF.EscherProperties.GetData("linestyle.backcolor", 2));
				global::NPOI.DDF.EscherProperties.AddProp(451, global::NPOI.DDF.EscherProperties.GetData("linestyle.crmod"));
				global::NPOI.DDF.EscherProperties.AddProp(452, global::NPOI.DDF.EscherProperties.GetData("linestyle.linetype"));
				global::NPOI.DDF.EscherProperties.AddProp(453, global::NPOI.DDF.EscherProperties.GetData("linestyle.fillblip"));
				global::NPOI.DDF.EscherProperties.AddProp(454, global::NPOI.DDF.EscherProperties.GetData("linestyle.fillblipname"));
				global::NPOI.DDF.EscherProperties.AddProp(455, global::NPOI.DDF.EscherProperties.GetData("linestyle.fillblipflags"));
				global::NPOI.DDF.EscherProperties.AddProp(456, global::NPOI.DDF.EscherProperties.GetData("linestyle.fillwidth"));
				global::NPOI.DDF.EscherProperties.AddProp(457, global::NPOI.DDF.EscherProperties.GetData("linestyle.fillheight"));
				global::NPOI.DDF.EscherProperties.AddProp(458, global::NPOI.DDF.EscherProperties.GetData("linestyle.filldztype"));
				global::NPOI.DDF.EscherProperties.AddProp(459, global::NPOI.DDF.EscherProperties.GetData("linestyle.linewidth"));
				global::NPOI.DDF.EscherProperties.AddProp(460, global::NPOI.DDF.EscherProperties.GetData("linestyle.linemiterlimit"));
				global::NPOI.DDF.EscherProperties.AddProp(461, global::NPOI.DDF.EscherProperties.GetData("linestyle.linestyle"));
				global::NPOI.DDF.EscherProperties.AddProp(462, global::NPOI.DDF.EscherProperties.GetData("linestyle.linedashing"));
				global::NPOI.DDF.EscherProperties.AddProp(463, global::NPOI.DDF.EscherProperties.GetData("linestyle.linedashstyle", 5));
				global::NPOI.DDF.EscherProperties.AddProp(464, global::NPOI.DDF.EscherProperties.GetData("linestyle.linestartarrowhead"));
				global::NPOI.DDF.EscherProperties.AddProp(465, global::NPOI.DDF.EscherProperties.GetData("linestyle.lineendarrowhead"));
				global::NPOI.DDF.EscherProperties.AddProp(466, global::NPOI.DDF.EscherProperties.GetData("linestyle.linestartarrowwidth"));
				global::NPOI.DDF.EscherProperties.AddProp(467, global::NPOI.DDF.EscherProperties.GetData("linestyle.linestartarrowlength"));
				global::NPOI.DDF.EscherProperties.AddProp(468, global::NPOI.DDF.EscherProperties.GetData("linestyle.lineendarrowwidth"));
				global::NPOI.DDF.EscherProperties.AddProp(469, global::NPOI.DDF.EscherProperties.GetData("linestyle.lineendarrowlength"));
				global::NPOI.DDF.EscherProperties.AddProp(470, global::NPOI.DDF.EscherProperties.GetData("linestyle.linejoinstyle"));
				global::NPOI.DDF.EscherProperties.AddProp(471, global::NPOI.DDF.EscherProperties.GetData("linestyle.lineendcapstyle"));
				global::NPOI.DDF.EscherProperties.AddProp(507, global::NPOI.DDF.EscherProperties.GetData("linestyle.arrowheadsok"));
				global::NPOI.DDF.EscherProperties.AddProp(508, global::NPOI.DDF.EscherProperties.GetData("linestyle.anyline"));
				global::NPOI.DDF.EscherProperties.AddProp(509, global::NPOI.DDF.EscherProperties.GetData("linestyle.hitlinetest"));
				global::NPOI.DDF.EscherProperties.AddProp(510, global::NPOI.DDF.EscherProperties.GetData("linestyle.linefillshape"));
				global::NPOI.DDF.EscherProperties.AddProp(511, global::NPOI.DDF.EscherProperties.GetData("linestyle.nolinedrawdash", 1));
				global::NPOI.DDF.EscherProperties.AddProp(1407, global::NPOI.DDF.EscherProperties.GetData("linestyle.nolinedrawdash.left", 1));
				global::NPOI.DDF.EscherProperties.AddProp(1471, global::NPOI.DDF.EscherProperties.GetData("linestyle.nolinedrawdash.top", 1));
				global::NPOI.DDF.EscherProperties.AddProp(1599, global::NPOI.DDF.EscherProperties.GetData("linestyle.nolinedrawdash.bottom", 1));
				global::NPOI.DDF.EscherProperties.AddProp(1535, global::NPOI.DDF.EscherProperties.GetData("linestyle.nolinedrawdash.right", 1));
				global::NPOI.DDF.EscherProperties.AddProp(512, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.type"));
				global::NPOI.DDF.EscherProperties.AddProp(513, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.color", 2));
				global::NPOI.DDF.EscherProperties.AddProp(514, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.highlight"));
				global::NPOI.DDF.EscherProperties.AddProp(515, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.crmod"));
				global::NPOI.DDF.EscherProperties.AddProp(516, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.opacity"));
				global::NPOI.DDF.EscherProperties.AddProp(517, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.offsetx"));
				global::NPOI.DDF.EscherProperties.AddProp(518, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.offsety"));
				global::NPOI.DDF.EscherProperties.AddProp(519, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.secondoffsetx"));
				global::NPOI.DDF.EscherProperties.AddProp(520, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.secondoffsety"));
				global::NPOI.DDF.EscherProperties.AddProp(521, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.scalextox"));
				global::NPOI.DDF.EscherProperties.AddProp(522, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.scaleytox"));
				global::NPOI.DDF.EscherProperties.AddProp(523, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.scalextoy"));
				global::NPOI.DDF.EscherProperties.AddProp(524, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.scaleytoy"));
				global::NPOI.DDF.EscherProperties.AddProp(525, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.perspectivex"));
				global::NPOI.DDF.EscherProperties.AddProp(526, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.perspectivey"));
				global::NPOI.DDF.EscherProperties.AddProp(527, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.weight"));
				global::NPOI.DDF.EscherProperties.AddProp(528, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.originx"));
				global::NPOI.DDF.EscherProperties.AddProp(529, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.originy"));
				global::NPOI.DDF.EscherProperties.AddProp(574, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.shadow"));
				global::NPOI.DDF.EscherProperties.AddProp(575, global::NPOI.DDF.EscherProperties.GetData("shadowstyle.shadowobsured"));
				global::NPOI.DDF.EscherProperties.AddProp(576, global::NPOI.DDF.EscherProperties.GetData("perspective.type"));
				global::NPOI.DDF.EscherProperties.AddProp(577, global::NPOI.DDF.EscherProperties.GetData("perspective.offsetx"));
				global::NPOI.DDF.EscherProperties.AddProp(578, global::NPOI.DDF.EscherProperties.GetData("perspective.offsety"));
				global::NPOI.DDF.EscherProperties.AddProp(579, global::NPOI.DDF.EscherProperties.GetData("perspective.scalextox"));
				global::NPOI.DDF.EscherProperties.AddProp(580, global::NPOI.DDF.EscherProperties.GetData("perspective.scaleytox"));
				global::NPOI.DDF.EscherProperties.AddProp(581, global::NPOI.DDF.EscherProperties.GetData("perspective.scalextoy"));
				global::NPOI.DDF.EscherProperties.AddProp(582, global::NPOI.DDF.EscherProperties.GetData("perspective.scaleytoy"));
				global::NPOI.DDF.EscherProperties.AddProp(583, global::NPOI.DDF.EscherProperties.GetData("perspective.perspectivex"));
				global::NPOI.DDF.EscherProperties.AddProp(584, global::NPOI.DDF.EscherProperties.GetData("perspective.perspectivey"));
				global::NPOI.DDF.EscherProperties.AddProp(585, global::NPOI.DDF.EscherProperties.GetData("perspective.weight"));
				global::NPOI.DDF.EscherProperties.AddProp(586, global::NPOI.DDF.EscherProperties.GetData("perspective.originx"));
				global::NPOI.DDF.EscherProperties.AddProp(587, global::NPOI.DDF.EscherProperties.GetData("perspective.originy"));
				global::NPOI.DDF.EscherProperties.AddProp(639, global::NPOI.DDF.EscherProperties.GetData("perspective.perspectiveon"));
				global::NPOI.DDF.EscherProperties.AddProp(640, global::NPOI.DDF.EscherProperties.GetData("3d.specularamount"));
				global::NPOI.DDF.EscherProperties.AddProp(661, global::NPOI.DDF.EscherProperties.GetData("3d.diffuseamount"));
				global::NPOI.DDF.EscherProperties.AddProp(662, global::NPOI.DDF.EscherProperties.GetData("3d.shininess"));
				global::NPOI.DDF.EscherProperties.AddProp(663, global::NPOI.DDF.EscherProperties.GetData("3d.edGethickness"));
				global::NPOI.DDF.EscherProperties.AddProp(664, global::NPOI.DDF.EscherProperties.GetData("3d.extrudeforward"));
				global::NPOI.DDF.EscherProperties.AddProp(665, global::NPOI.DDF.EscherProperties.GetData("3d.extrudebackward"));
				global::NPOI.DDF.EscherProperties.AddProp(666, global::NPOI.DDF.EscherProperties.GetData("3d.extrudeplane"));
				global::NPOI.DDF.EscherProperties.AddProp(667, global::NPOI.DDF.EscherProperties.GetData("3d.extrusioncolor", 2));
				global::NPOI.DDF.EscherProperties.AddProp(648, global::NPOI.DDF.EscherProperties.GetData("3d.crmod"));
				global::NPOI.DDF.EscherProperties.AddProp(700, global::NPOI.DDF.EscherProperties.GetData("3d.3deffect"));
				global::NPOI.DDF.EscherProperties.AddProp(701, global::NPOI.DDF.EscherProperties.GetData("3d.metallic"));
				global::NPOI.DDF.EscherProperties.AddProp(702, global::NPOI.DDF.EscherProperties.GetData("3d.useextrusioncolor", 2));
				global::NPOI.DDF.EscherProperties.AddProp(703, global::NPOI.DDF.EscherProperties.GetData("3d.lightface"));
				global::NPOI.DDF.EscherProperties.AddProp(704, global::NPOI.DDF.EscherProperties.GetData("3dstyle.yrotationangle"));
				global::NPOI.DDF.EscherProperties.AddProp(705, global::NPOI.DDF.EscherProperties.GetData("3dstyle.xrotationangle"));
				global::NPOI.DDF.EscherProperties.AddProp(706, global::NPOI.DDF.EscherProperties.GetData("3dstyle.rotationaxisx"));
				global::NPOI.DDF.EscherProperties.AddProp(707, global::NPOI.DDF.EscherProperties.GetData("3dstyle.rotationaxisy"));
				global::NPOI.DDF.EscherProperties.AddProp(708, global::NPOI.DDF.EscherProperties.GetData("3dstyle.rotationaxisz"));
				global::NPOI.DDF.EscherProperties.AddProp(709, global::NPOI.DDF.EscherProperties.GetData("3dstyle.rotationangle"));
				global::NPOI.DDF.EscherProperties.AddProp(710, global::NPOI.DDF.EscherProperties.GetData("3dstyle.rotationcenterx"));
				global::NPOI.DDF.EscherProperties.AddProp(711, global::NPOI.DDF.EscherProperties.GetData("3dstyle.rotationcentery"));
				global::NPOI.DDF.EscherProperties.AddProp(712, global::NPOI.DDF.EscherProperties.GetData("3dstyle.rotationcenterz"));
				global::NPOI.DDF.EscherProperties.AddProp(713, global::NPOI.DDF.EscherProperties.GetData("3dstyle.rendermode"));
				global::NPOI.DDF.EscherProperties.AddProp(714, global::NPOI.DDF.EscherProperties.GetData("3dstyle.tolerance"));
				global::NPOI.DDF.EscherProperties.AddProp(715, global::NPOI.DDF.EscherProperties.GetData("3dstyle.xviewpoint"));
				global::NPOI.DDF.EscherProperties.AddProp(716, global::NPOI.DDF.EscherProperties.GetData("3dstyle.yviewpoint"));
				global::NPOI.DDF.EscherProperties.AddProp(717, global::NPOI.DDF.EscherProperties.GetData("3dstyle.zviewpoint"));
				global::NPOI.DDF.EscherProperties.AddProp(718, global::NPOI.DDF.EscherProperties.GetData("3dstyle.originx"));
				global::NPOI.DDF.EscherProperties.AddProp(719, global::NPOI.DDF.EscherProperties.GetData("3dstyle.originy"));
				global::NPOI.DDF.EscherProperties.AddProp(720, global::NPOI.DDF.EscherProperties.GetData("3dstyle.skewangle"));
				global::NPOI.DDF.EscherProperties.AddProp(721, global::NPOI.DDF.EscherProperties.GetData("3dstyle.skewamount"));
				global::NPOI.DDF.EscherProperties.AddProp(722, global::NPOI.DDF.EscherProperties.GetData("3dstyle.ambientintensity"));
				global::NPOI.DDF.EscherProperties.AddProp(723, global::NPOI.DDF.EscherProperties.GetData("3dstyle.keyx"));
				global::NPOI.DDF.EscherProperties.AddProp(724, global::NPOI.DDF.EscherProperties.GetData("3dstyle.keyy"));
				global::NPOI.DDF.EscherProperties.AddProp(725, global::NPOI.DDF.EscherProperties.GetData("3dstyle.keyz"));
				global::NPOI.DDF.EscherProperties.AddProp(726, global::NPOI.DDF.EscherProperties.GetData("3dstyle.keyintensity"));
				global::NPOI.DDF.EscherProperties.AddProp(727, global::NPOI.DDF.EscherProperties.GetData("3dstyle.fillx"));
				global::NPOI.DDF.EscherProperties.AddProp(728, global::NPOI.DDF.EscherProperties.GetData("3dstyle.filly"));
				global::NPOI.DDF.EscherProperties.AddProp(729, global::NPOI.DDF.EscherProperties.GetData("3dstyle.fillz"));
				global::NPOI.DDF.EscherProperties.AddProp(730, global::NPOI.DDF.EscherProperties.GetData("3dstyle.fillintensity"));
				global::NPOI.DDF.EscherProperties.AddProp(763, global::NPOI.DDF.EscherProperties.GetData("3dstyle.constrainrotation"));
				global::NPOI.DDF.EscherProperties.AddProp(764, global::NPOI.DDF.EscherProperties.GetData("3dstyle.rotationcenterauto"));
				global::NPOI.DDF.EscherProperties.AddProp(765, global::NPOI.DDF.EscherProperties.GetData("3dstyle.parallel"));
				global::NPOI.DDF.EscherProperties.AddProp(766, global::NPOI.DDF.EscherProperties.GetData("3dstyle.keyharsh"));
				global::NPOI.DDF.EscherProperties.AddProp(767, global::NPOI.DDF.EscherProperties.GetData("3dstyle.fillharsh"));
				global::NPOI.DDF.EscherProperties.AddProp(769, global::NPOI.DDF.EscherProperties.GetData("shape.master"));
				global::NPOI.DDF.EscherProperties.AddProp(771, global::NPOI.DDF.EscherProperties.GetData("shape.connectorstyle"));
				global::NPOI.DDF.EscherProperties.AddProp(772, global::NPOI.DDF.EscherProperties.GetData("shape.blackandwhiteSettings"));
				global::NPOI.DDF.EscherProperties.AddProp(773, global::NPOI.DDF.EscherProperties.GetData("shape.wmodepurebw"));
				global::NPOI.DDF.EscherProperties.AddProp(774, global::NPOI.DDF.EscherProperties.GetData("shape.wmodebw"));
				global::NPOI.DDF.EscherProperties.AddProp(826, global::NPOI.DDF.EscherProperties.GetData("shape.oleicon"));
				global::NPOI.DDF.EscherProperties.AddProp(827, global::NPOI.DDF.EscherProperties.GetData("shape.preferrelativeresize"));
				global::NPOI.DDF.EscherProperties.AddProp(828, global::NPOI.DDF.EscherProperties.GetData("shape.lockshapetype"));
				global::NPOI.DDF.EscherProperties.AddProp(830, global::NPOI.DDF.EscherProperties.GetData("shape.deleteattachedobject"));
				global::NPOI.DDF.EscherProperties.AddProp(831, global::NPOI.DDF.EscherProperties.GetData("shape.backgroundshape"));
				global::NPOI.DDF.EscherProperties.AddProp(832, global::NPOI.DDF.EscherProperties.GetData("callout.callouttype"));
				global::NPOI.DDF.EscherProperties.AddProp(833, global::NPOI.DDF.EscherProperties.GetData("callout.xycalloutgap"));
				global::NPOI.DDF.EscherProperties.AddProp(834, global::NPOI.DDF.EscherProperties.GetData("callout.calloutangle"));
				global::NPOI.DDF.EscherProperties.AddProp(835, global::NPOI.DDF.EscherProperties.GetData("callout.calloutdroptype"));
				global::NPOI.DDF.EscherProperties.AddProp(836, global::NPOI.DDF.EscherProperties.GetData("callout.calloutdropspecified"));
				global::NPOI.DDF.EscherProperties.AddProp(837, global::NPOI.DDF.EscherProperties.GetData("callout.calloutlengthspecified"));
				global::NPOI.DDF.EscherProperties.AddProp(889, global::NPOI.DDF.EscherProperties.GetData("callout.iscallout"));
				global::NPOI.DDF.EscherProperties.AddProp(890, global::NPOI.DDF.EscherProperties.GetData("callout.calloutaccentbar"));
				global::NPOI.DDF.EscherProperties.AddProp(891, global::NPOI.DDF.EscherProperties.GetData("callout.callouttextborder"));
				global::NPOI.DDF.EscherProperties.AddProp(892, global::NPOI.DDF.EscherProperties.GetData("callout.calloutminusx"));
				global::NPOI.DDF.EscherProperties.AddProp(893, global::NPOI.DDF.EscherProperties.GetData("callout.calloutminusy"));
				global::NPOI.DDF.EscherProperties.AddProp(894, global::NPOI.DDF.EscherProperties.GetData("callout.dropauto"));
				global::NPOI.DDF.EscherProperties.AddProp(895, global::NPOI.DDF.EscherProperties.GetData("callout.lengthspecified"));
				global::NPOI.DDF.EscherProperties.AddProp(896, global::NPOI.DDF.EscherProperties.GetData("groupshape.shapename"));
				global::NPOI.DDF.EscherProperties.AddProp(897, global::NPOI.DDF.EscherProperties.GetData("groupshape.description"));
				global::NPOI.DDF.EscherProperties.AddProp(898, global::NPOI.DDF.EscherProperties.GetData("groupshape.hyperlink"));
				global::NPOI.DDF.EscherProperties.AddProp(899, global::NPOI.DDF.EscherProperties.GetData("groupshape.wrappolygonvertices", 5));
				global::NPOI.DDF.EscherProperties.AddProp(900, global::NPOI.DDF.EscherProperties.GetData("groupshape.wrapdistleft"));
				global::NPOI.DDF.EscherProperties.AddProp(901, global::NPOI.DDF.EscherProperties.GetData("groupshape.wrapdisttop"));
				global::NPOI.DDF.EscherProperties.AddProp(902, global::NPOI.DDF.EscherProperties.GetData("groupshape.wrapdistright"));
				global::NPOI.DDF.EscherProperties.AddProp(903, global::NPOI.DDF.EscherProperties.GetData("groupshape.wrapdistbottom"));
				global::NPOI.DDF.EscherProperties.AddProp(904, global::NPOI.DDF.EscherProperties.GetData("groupshape.regroupid"));
				global::NPOI.DDF.EscherProperties.AddProp(953, global::NPOI.DDF.EscherProperties.GetData("groupshape.editedwrap"));
				global::NPOI.DDF.EscherProperties.AddProp(954, global::NPOI.DDF.EscherProperties.GetData("groupshape.behinddocument"));
				global::NPOI.DDF.EscherProperties.AddProp(955, global::NPOI.DDF.EscherProperties.GetData("groupshape.ondblclicknotify"));
				global::NPOI.DDF.EscherProperties.AddProp(956, global::NPOI.DDF.EscherProperties.GetData("groupshape.isbutton"));
				global::NPOI.DDF.EscherProperties.AddProp(957, global::NPOI.DDF.EscherProperties.GetData("groupshape.1dadjustment"));
				global::NPOI.DDF.EscherProperties.AddProp(958, global::NPOI.DDF.EscherProperties.GetData("groupshape.hidden"));
				global::NPOI.DDF.EscherProperties.AddProp(959, global::NPOI.DDF.EscherProperties.GetData("groupshape.print", 1));
			}
		}

		// Token: 0x060032D1 RID: 13009 RVA: 0x0009EF91 File Offset: 0x0009D191
		private static void AddProp(int s, global::NPOI.DDF.EscherPropertyMetaData data)
		{
			global::NPOI.DDF.EscherProperties.properties[(short)s] = data;
		}

		// Token: 0x060032D2 RID: 13010 RVA: 0x0009EFA5 File Offset: 0x0009D1A5
		private static global::NPOI.DDF.EscherPropertyMetaData GetData(string propName, byte type)
		{
			return new global::NPOI.DDF.EscherPropertyMetaData(propName, type);
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x0009EFAE File Offset: 0x0009D1AE
		private static global::NPOI.DDF.EscherPropertyMetaData GetData(string propName)
		{
			return new global::NPOI.DDF.EscherPropertyMetaData(propName);
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x0009EFB8 File Offset: 0x0009D1B8
		public static string GetPropertyName(short propertyId)
		{
			global::NPOI.DDF.EscherProperties.InitProps();
			global::NPOI.DDF.EscherPropertyMetaData escherPropertyMetaData = (global::NPOI.DDF.EscherPropertyMetaData)global::NPOI.DDF.EscherProperties.properties[propertyId];
			if (escherPropertyMetaData != null)
			{
				return escherPropertyMetaData.Description;
			}
			return "unknown";
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x0009EFF0 File Offset: 0x0009D1F0
		public static byte GetPropertyType(short propertyId)
		{
			global::NPOI.DDF.EscherProperties.InitProps();
			global::NPOI.DDF.EscherPropertyMetaData escherPropertyMetaData = (global::NPOI.DDF.EscherPropertyMetaData)global::NPOI.DDF.EscherProperties.properties[propertyId];
			if (escherPropertyMetaData != null)
			{
				return escherPropertyMetaData.Type;
			}
			return 0;
		}

		// Token: 0x040016B7 RID: 5815
		public const short TRANSFORM__ROTATION = 4;

		// Token: 0x040016B8 RID: 5816
		public const short PROTECTION__LOCKROTATION = 119;

		// Token: 0x040016B9 RID: 5817
		public const short PROTECTION__LOCKASPECTRATIO = 120;

		// Token: 0x040016BA RID: 5818
		public const short PROTECTION__LOCKPOSITION = 121;

		// Token: 0x040016BB RID: 5819
		public const short PROTECTION__LOCKAGAINSTSELECT = 122;

		// Token: 0x040016BC RID: 5820
		public const short PROTECTION__LOCKCROPPING = 123;

		// Token: 0x040016BD RID: 5821
		public const short PROTECTION__LOCKVERTICES = 124;

		// Token: 0x040016BE RID: 5822
		public const short PROTECTION__LOCKTEXT = 125;

		// Token: 0x040016BF RID: 5823
		public const short PROTECTION__LOCKADJUSTHANDLES = 126;

		// Token: 0x040016C0 RID: 5824
		public const short PROTECTION__LOCKAGAINSTGROUPING = 127;

		// Token: 0x040016C1 RID: 5825
		public const short TEXT__TEXTID = 128;

		// Token: 0x040016C2 RID: 5826
		public const short TEXT__TEXTLEFT = 129;

		// Token: 0x040016C3 RID: 5827
		public const short TEXT__TEXTTOP = 130;

		// Token: 0x040016C4 RID: 5828
		public const short TEXT__TEXTRIGHT = 131;

		// Token: 0x040016C5 RID: 5829
		public const short TEXT__TEXTBOTTOM = 132;

		// Token: 0x040016C6 RID: 5830
		public const short TEXT__WRAPTEXT = 133;

		// Token: 0x040016C7 RID: 5831
		public const short TEXT__SCALETEXT = 134;

		// Token: 0x040016C8 RID: 5832
		public const short TEXT__ANCHORTEXT = 135;

		// Token: 0x040016C9 RID: 5833
		public const short TEXT__TEXTFLOW = 136;

		// Token: 0x040016CA RID: 5834
		public const short TEXT__FONTROTATION = 137;

		// Token: 0x040016CB RID: 5835
		public const short TEXT__IDOFNEXTSHAPE = 138;

		// Token: 0x040016CC RID: 5836
		public const short TEXT__BIDIR = 139;

		// Token: 0x040016CD RID: 5837
		public const short TEXT__SINGLECLICKSELECTS = 187;

		// Token: 0x040016CE RID: 5838
		public const short TEXT__USEHOSTMARGINS = 188;

		// Token: 0x040016CF RID: 5839
		public const short TEXT__ROTATETEXTWITHSHAPE = 189;

		// Token: 0x040016D0 RID: 5840
		public const short TEXT__SIZESHAPETOFITTEXT = 190;

		// Token: 0x040016D1 RID: 5841
		public const short TEXT__SIZE_TEXT_TO_FIT_SHAPE = 191;

		// Token: 0x040016D2 RID: 5842
		public const short GEOTEXT__UNICODE = 192;

		// Token: 0x040016D3 RID: 5843
		public const short GEOTEXT__RTFTEXT = 193;

		// Token: 0x040016D4 RID: 5844
		public const short GEOTEXT__ALIGNMENTONCURVE = 194;

		// Token: 0x040016D5 RID: 5845
		public const short GEOTEXT__DEFAULTPOINTSIZE = 195;

		// Token: 0x040016D6 RID: 5846
		public const short GEOTEXT__TEXTSPACING = 196;

		// Token: 0x040016D7 RID: 5847
		public const short GEOTEXT__FONTFAMILYNAME = 197;

		// Token: 0x040016D8 RID: 5848
		public const short GEOTEXT__REVERSEROWORDER = 240;

		// Token: 0x040016D9 RID: 5849
		public const short GEOTEXT__HASTEXTEFFECT = 241;

		// Token: 0x040016DA RID: 5850
		public const short GEOTEXT__ROTATECHARACTERS = 242;

		// Token: 0x040016DB RID: 5851
		public const short GEOTEXT__KERNCHARACTERS = 243;

		// Token: 0x040016DC RID: 5852
		public const short GEOTEXT__TIGHTORTRACK = 244;

		// Token: 0x040016DD RID: 5853
		public const short GEOTEXT__STRETCHTOFITSHAPE = 245;

		// Token: 0x040016DE RID: 5854
		public const short GEOTEXT__CHARBOUNDINGBOX = 246;

		// Token: 0x040016DF RID: 5855
		public const short GEOTEXT__SCALETEXTONPATH = 247;

		// Token: 0x040016E0 RID: 5856
		public const short GEOTEXT__STRETCHCHARHEIGHT = 248;

		// Token: 0x040016E1 RID: 5857
		public const short GEOTEXT__NOMEASUREALONGPATH = 249;

		// Token: 0x040016E2 RID: 5858
		public const short GEOTEXT__BOLDFONT = 250;

		// Token: 0x040016E3 RID: 5859
		public const short GEOTEXT__ITALICFONT = 251;

		// Token: 0x040016E4 RID: 5860
		public const short GEOTEXT__UNDERLINEFONT = 252;

		// Token: 0x040016E5 RID: 5861
		public const short GEOTEXT__SHADOWFONT = 253;

		// Token: 0x040016E6 RID: 5862
		public const short GEOTEXT__SMALLCAPSFONT = 254;

		// Token: 0x040016E7 RID: 5863
		public const short GEOTEXT__STRIKETHROUGHFONT = 255;

		// Token: 0x040016E8 RID: 5864
		public const short BLIP__CROPFROMTOP = 256;

		// Token: 0x040016E9 RID: 5865
		public const short BLIP__CROPFROMBOTTOM = 257;

		// Token: 0x040016EA RID: 5866
		public const short BLIP__CROPFROMLEFT = 258;

		// Token: 0x040016EB RID: 5867
		public const short BLIP__CROPFROMRIGHT = 259;

		// Token: 0x040016EC RID: 5868
		public const short BLIP__BLIPTODISPLAY = 260;

		// Token: 0x040016ED RID: 5869
		public const short BLIP__BLIPFILENAME = 261;

		// Token: 0x040016EE RID: 5870
		public const short BLIP__BLIPFLAGS = 262;

		// Token: 0x040016EF RID: 5871
		public const short BLIP__TRANSPARENTCOLOR = 263;

		// Token: 0x040016F0 RID: 5872
		public const short BLIP__CONTRASTSetTING = 264;

		// Token: 0x040016F1 RID: 5873
		public const short BLIP__BRIGHTNESSSetTING = 265;

		// Token: 0x040016F2 RID: 5874
		public const short BLIP__GAMMA = 266;

		// Token: 0x040016F3 RID: 5875
		public const short BLIP__PICTUREID = 267;

		// Token: 0x040016F4 RID: 5876
		public const short BLIP__DOUBLEMOD = 268;

		// Token: 0x040016F5 RID: 5877
		public const short BLIP__PICTUREFillMOD = 269;

		// Token: 0x040016F6 RID: 5878
		public const short BLIP__PICTURELINE = 270;

		// Token: 0x040016F7 RID: 5879
		public const short BLIP__PRINTBLIP = 271;

		// Token: 0x040016F8 RID: 5880
		public const short BLIP__PRINTBLIPFILENAME = 272;

		// Token: 0x040016F9 RID: 5881
		public const short BLIP__PRINTFLAGS = 273;

		// Token: 0x040016FA RID: 5882
		public const short BLIP__NOHITTESTPICTURE = 316;

		// Token: 0x040016FB RID: 5883
		public const short BLIP__PICTUREGRAY = 317;

		// Token: 0x040016FC RID: 5884
		public const short BLIP__PICTUREBILEVEL = 318;

		// Token: 0x040016FD RID: 5885
		public const short BLIP__PICTUREACTIVE = 319;

		// Token: 0x040016FE RID: 5886
		public const short GEOMETRY__LEFT = 320;

		// Token: 0x040016FF RID: 5887
		public const short GEOMETRY__TOP = 321;

		// Token: 0x04001700 RID: 5888
		public const short GEOMETRY__RIGHT = 322;

		// Token: 0x04001701 RID: 5889
		public const short GEOMETRY__BOTTOM = 323;

		// Token: 0x04001702 RID: 5890
		public const short GEOMETRY__SHAPEPATH = 324;

		// Token: 0x04001703 RID: 5891
		public const short GEOMETRY__VERTICES = 325;

		// Token: 0x04001704 RID: 5892
		public const short GEOMETRY__SEGMENTINFO = 326;

		// Token: 0x04001705 RID: 5893
		public const short GEOMETRY__ADJUSTVALUE = 327;

		// Token: 0x04001706 RID: 5894
		public const short GEOMETRY__ADJUST2VALUE = 328;

		// Token: 0x04001707 RID: 5895
		public const short GEOMETRY__ADJUST3VALUE = 329;

		// Token: 0x04001708 RID: 5896
		public const short GEOMETRY__ADJUST4VALUE = 330;

		// Token: 0x04001709 RID: 5897
		public const short GEOMETRY__ADJUST5VALUE = 331;

		// Token: 0x0400170A RID: 5898
		public const short GEOMETRY__ADJUST6VALUE = 332;

		// Token: 0x0400170B RID: 5899
		public const short GEOMETRY__ADJUST7VALUE = 333;

		// Token: 0x0400170C RID: 5900
		public const short GEOMETRY__ADJUST8VALUE = 334;

		// Token: 0x0400170D RID: 5901
		public const short GEOMETRY__ADJUST9VALUE = 335;

		// Token: 0x0400170E RID: 5902
		public const short GEOMETRY__ADJUST10VALUE = 336;

		// Token: 0x0400170F RID: 5903
		public const short GEOMETRY__SHADOWok = 378;

		// Token: 0x04001710 RID: 5904
		public const short GEOMETRY__3DOK = 379;

		// Token: 0x04001711 RID: 5905
		public const short GEOMETRY__LINEOK = 380;

		// Token: 0x04001712 RID: 5906
		public const short GEOMETRY__GEOTEXTOK = 381;

		// Token: 0x04001713 RID: 5907
		public const short GEOMETRY__FILLSHADESHAPEOK = 382;

		// Token: 0x04001714 RID: 5908
		public const short GEOMETRY__FILLOK = 383;

		// Token: 0x04001715 RID: 5909
		public const short FILL__FILLTYPE = 384;

		// Token: 0x04001716 RID: 5910
		public const short FILL__FILLCOLOR = 385;

		// Token: 0x04001717 RID: 5911
		public const short FILL__FILLOPACITY = 386;

		// Token: 0x04001718 RID: 5912
		public const short FILL__FILLBACKCOLOR = 387;

		// Token: 0x04001719 RID: 5913
		public const short FILL__BACKOPACITY = 388;

		// Token: 0x0400171A RID: 5914
		public const short FILL__CRMOD = 389;

		// Token: 0x0400171B RID: 5915
		public const short FILL__PATTERNTEXTURE = 390;

		// Token: 0x0400171C RID: 5916
		public const short FILL__BLIPFILENAME = 391;

		// Token: 0x0400171D RID: 5917
		public const short FILL__BLIPFLAGS = 392;

		// Token: 0x0400171E RID: 5918
		public const short FILL__WIDTH = 393;

		// Token: 0x0400171F RID: 5919
		public const short FILL__HEIGHT = 394;

		// Token: 0x04001720 RID: 5920
		public const short FILL__ANGLE = 395;

		// Token: 0x04001721 RID: 5921
		public const short FILL__FOCUS = 396;

		// Token: 0x04001722 RID: 5922
		public const short FILL__TOLEFT = 397;

		// Token: 0x04001723 RID: 5923
		public const short FILL__TOTOP = 398;

		// Token: 0x04001724 RID: 5924
		public const short FILL__TORIGHT = 399;

		// Token: 0x04001725 RID: 5925
		public const short FILL__TOBOTTOM = 400;

		// Token: 0x04001726 RID: 5926
		public const short FILL__RECTLEFT = 401;

		// Token: 0x04001727 RID: 5927
		public const short FILL__RECTTOP = 402;

		// Token: 0x04001728 RID: 5928
		public const short FILL__RECTRIGHT = 403;

		// Token: 0x04001729 RID: 5929
		public const short FILL__RECTBOTTOM = 404;

		// Token: 0x0400172A RID: 5930
		public const short FILL__DZTYPE = 405;

		// Token: 0x0400172B RID: 5931
		public const short FILL__SHADEPRESet = 406;

		// Token: 0x0400172C RID: 5932
		public const short FILL__SHADECOLORS = 407;

		// Token: 0x0400172D RID: 5933
		public const short FILL__ORIGINX = 408;

		// Token: 0x0400172E RID: 5934
		public const short FILL__ORIGINY = 409;

		// Token: 0x0400172F RID: 5935
		public const short FILL__SHAPEORIGINX = 410;

		// Token: 0x04001730 RID: 5936
		public const short FILL__SHAPEORIGINY = 411;

		// Token: 0x04001731 RID: 5937
		public const short FILL__SHADETYPE = 412;

		// Token: 0x04001732 RID: 5938
		public const short FILL__FILLED = 443;

		// Token: 0x04001733 RID: 5939
		public const short FILL__HITTESTFILL = 444;

		// Token: 0x04001734 RID: 5940
		public const short FILL__SHAPE = 445;

		// Token: 0x04001735 RID: 5941
		public const short FILL__USERECT = 446;

		// Token: 0x04001736 RID: 5942
		public const short FILL__NOFILLHITTEST = 447;

		// Token: 0x04001737 RID: 5943
		public const short LINESTYLE__COLOR = 448;

		// Token: 0x04001738 RID: 5944
		public const short LINESTYLE__OPACITY = 449;

		// Token: 0x04001739 RID: 5945
		public const short LINESTYLE__BACKCOLOR = 450;

		// Token: 0x0400173A RID: 5946
		public const short LINESTYLE__CRMOD = 451;

		// Token: 0x0400173B RID: 5947
		public const short LINESTYLE__LINETYPE = 452;

		// Token: 0x0400173C RID: 5948
		public const short LINESTYLE__FILLBLIP = 453;

		// Token: 0x0400173D RID: 5949
		public const short LINESTYLE__FILLBLIPNAME = 454;

		// Token: 0x0400173E RID: 5950
		public const short LINESTYLE__FILLBLIPFLAGS = 455;

		// Token: 0x0400173F RID: 5951
		public const short LINESTYLE__FILLWIDTH = 456;

		// Token: 0x04001740 RID: 5952
		public const short LINESTYLE__FILLHEIGHT = 457;

		// Token: 0x04001741 RID: 5953
		public const short LINESTYLE__FILLDZTYPE = 458;

		// Token: 0x04001742 RID: 5954
		public const short LINESTYLE__LINEWIDTH = 459;

		// Token: 0x04001743 RID: 5955
		public const short LINESTYLE__LINEMITERLIMIT = 460;

		// Token: 0x04001744 RID: 5956
		public const short LINESTYLE__LINESTYLE = 461;

		// Token: 0x04001745 RID: 5957
		public const short LINESTYLE__LINEDASHING = 462;

		// Token: 0x04001746 RID: 5958
		public const short LINESTYLE__LINEDASHSTYLE = 463;

		// Token: 0x04001747 RID: 5959
		public const short LINESTYLE__LINESTARTARROWHEAD = 464;

		// Token: 0x04001748 RID: 5960
		public const short LINESTYLE__LINEENDARROWHEAD = 465;

		// Token: 0x04001749 RID: 5961
		public const short LINESTYLE__LINESTARTARROWWIDTH = 466;

		// Token: 0x0400174A RID: 5962
		public const short LINESTYLE__LINESTARTARROWLENGTH = 467;

		// Token: 0x0400174B RID: 5963
		public const short LINESTYLE__LINEENDARROWWIDTH = 468;

		// Token: 0x0400174C RID: 5964
		public const short LINESTYLE__LINEENDARROWLength = 469;

		// Token: 0x0400174D RID: 5965
		public const short LINESTYLE__LINEJOINSTYLE = 470;

		// Token: 0x0400174E RID: 5966
		public const short LINESTYLE__LINEENDCAPSTYLE = 471;

		// Token: 0x0400174F RID: 5967
		public const short LINESTYLE__ARROWHEADSOK = 507;

		// Token: 0x04001750 RID: 5968
		public const short LINESTYLE__ANYLINE = 508;

		// Token: 0x04001751 RID: 5969
		public const short LINESTYLE__HITLINETEST = 509;

		// Token: 0x04001752 RID: 5970
		public const short LINESTYLE__LINEFILLSHAPE = 510;

		// Token: 0x04001753 RID: 5971
		public const short LINESTYLE__NOLINEDRAWDASH = 511;

		// Token: 0x04001754 RID: 5972
		public const short LINESTYLE__NOLINEDRAWDASH_LEFT = 1407;

		// Token: 0x04001755 RID: 5973
		public const short LINESTYLE__NOLINEDRAWDASH_TOP = 1471;

		// Token: 0x04001756 RID: 5974
		public const short LINESTYLE__NOLINEDRAWDASH_BOTTOM = 1599;

		// Token: 0x04001757 RID: 5975
		public const short LINESTYLE__NOLINEDRAWDASH_RIGHT = 1535;

		// Token: 0x04001758 RID: 5976
		public const short SHADOWSTYLE__TYPE = 512;

		// Token: 0x04001759 RID: 5977
		public const short SHADOWSTYLE__COLOR = 513;

		// Token: 0x0400175A RID: 5978
		public const short SHADOWSTYLE__HIGHLIGHT = 514;

		// Token: 0x0400175B RID: 5979
		public const short SHADOWSTYLE__CRMOD = 515;

		// Token: 0x0400175C RID: 5980
		public const short SHADOWSTYLE__OPACITY = 516;

		// Token: 0x0400175D RID: 5981
		public const short SHADOWSTYLE__OFFSetX = 517;

		// Token: 0x0400175E RID: 5982
		public const short SHADOWSTYLE__OFFSetY = 518;

		// Token: 0x0400175F RID: 5983
		public const short SHADOWSTYLE__SECONDOFFSetX = 519;

		// Token: 0x04001760 RID: 5984
		public const short SHADOWSTYLE__SECONDOFFSetY = 520;

		// Token: 0x04001761 RID: 5985
		public const short SHADOWSTYLE__SCALEXTOX = 521;

		// Token: 0x04001762 RID: 5986
		public const short SHADOWSTYLE__SCALEYTOX = 522;

		// Token: 0x04001763 RID: 5987
		public const short SHADOWSTYLE__SCALEXTOY = 523;

		// Token: 0x04001764 RID: 5988
		public const short SHADOWSTYLE__SCALEYTOY = 524;

		// Token: 0x04001765 RID: 5989
		public const short SHADOWSTYLE__PERSPECTIVEX = 525;

		// Token: 0x04001766 RID: 5990
		public const short SHADOWSTYLE__PERSPECTIVEY = 526;

		// Token: 0x04001767 RID: 5991
		public const short SHADOWSTYLE__WEIGHT = 527;

		// Token: 0x04001768 RID: 5992
		public const short SHADOWSTYLE__ORIGINX = 528;

		// Token: 0x04001769 RID: 5993
		public const short SHADOWSTYLE__ORIGINY = 529;

		// Token: 0x0400176A RID: 5994
		public const short SHADOWSTYLE__SHADOW = 574;

		// Token: 0x0400176B RID: 5995
		public const short SHADOWSTYLE__SHADOWOBSURED = 575;

		// Token: 0x0400176C RID: 5996
		public const short PERSPECTIVE__TYPE = 576;

		// Token: 0x0400176D RID: 5997
		public const short PERSPECTIVE__OFFSetX = 577;

		// Token: 0x0400176E RID: 5998
		public const short PERSPECTIVE__OFFSetY = 578;

		// Token: 0x0400176F RID: 5999
		public const short PERSPECTIVE__SCALEXTOX = 579;

		// Token: 0x04001770 RID: 6000
		public const short PERSPECTIVE__SCALEYTOX = 580;

		// Token: 0x04001771 RID: 6001
		public const short PERSPECTIVE__SCALEXTOY = 581;

		// Token: 0x04001772 RID: 6002
		public const short PERSPECTIVE__SCALEYTOY = 582;

		// Token: 0x04001773 RID: 6003
		public const short PERSPECTIVE__PERSPECTIVEX = 583;

		// Token: 0x04001774 RID: 6004
		public const short PERSPECTIVE__PERSPECTIVEY = 584;

		// Token: 0x04001775 RID: 6005
		public const short PERSPECTIVE__WEIGHT = 585;

		// Token: 0x04001776 RID: 6006
		public const short PERSPECTIVE__ORIGINX = 586;

		// Token: 0x04001777 RID: 6007
		public const short PERSPECTIVE__ORIGINY = 587;

		// Token: 0x04001778 RID: 6008
		public const short PERSPECTIVE__PERSPECTIVEON = 639;

		// Token: 0x04001779 RID: 6009
		public const short THREED__SPECULARAMOUNT = 640;

		// Token: 0x0400177A RID: 6010
		public const short THREED__DIFFUSEAMOUNT = 661;

		// Token: 0x0400177B RID: 6011
		public const short THREED__SHININESS = 662;

		// Token: 0x0400177C RID: 6012
		public const short THREED__EDGetHICKNESS = 663;

		// Token: 0x0400177D RID: 6013
		public const short THREED__EXTRUDEFORWARD = 664;

		// Token: 0x0400177E RID: 6014
		public const short THREED__EXTRUDEBACKWARD = 665;

		// Token: 0x0400177F RID: 6015
		public const short THREED__EXTRUDEPLANE = 666;

		// Token: 0x04001780 RID: 6016
		public const short THREED__EXTRUSIONCOLOR = 667;

		// Token: 0x04001781 RID: 6017
		public const short THREED__CRMOD = 648;

		// Token: 0x04001782 RID: 6018
		public const short THREED__3DEFFECT = 700;

		// Token: 0x04001783 RID: 6019
		public const short THREED__METALLIC = 701;

		// Token: 0x04001784 RID: 6020
		public const short THREED__USEEXTRUSIONCOLOR = 702;

		// Token: 0x04001785 RID: 6021
		public const short THREED__LIGHTFACE = 703;

		// Token: 0x04001786 RID: 6022
		public const short THREEDSTYLE__YROTATIONANGLE = 704;

		// Token: 0x04001787 RID: 6023
		public const short THREEDSTYLE__XROTATIONANGLE = 705;

		// Token: 0x04001788 RID: 6024
		public const short THREEDSTYLE__ROTATIONAXISX = 706;

		// Token: 0x04001789 RID: 6025
		public const short THREEDSTYLE__ROTATIONAXISY = 707;

		// Token: 0x0400178A RID: 6026
		public const short THREEDSTYLE__ROTATIONAXISZ = 708;

		// Token: 0x0400178B RID: 6027
		public const short THREEDSTYLE__ROTATIONANGLE = 709;

		// Token: 0x0400178C RID: 6028
		public const short THREEDSTYLE__ROTATIONCENTERX = 710;

		// Token: 0x0400178D RID: 6029
		public const short THREEDSTYLE__ROTATIONCENTERY = 711;

		// Token: 0x0400178E RID: 6030
		public const short THREEDSTYLE__ROTATIONCENTERZ = 712;

		// Token: 0x0400178F RID: 6031
		public const short THREEDSTYLE__RENDERMODE = 713;

		// Token: 0x04001790 RID: 6032
		public const short THREEDSTYLE__TOLERANCE = 714;

		// Token: 0x04001791 RID: 6033
		public const short THREEDSTYLE__XVIEWPOINT = 715;

		// Token: 0x04001792 RID: 6034
		public const short THREEDSTYLE__YVIEWPOINT = 716;

		// Token: 0x04001793 RID: 6035
		public const short THREEDSTYLE__ZVIEWPOINT = 717;

		// Token: 0x04001794 RID: 6036
		public const short THREEDSTYLE__ORIGINX = 718;

		// Token: 0x04001795 RID: 6037
		public const short THREEDSTYLE__ORIGINY = 719;

		// Token: 0x04001796 RID: 6038
		public const short THREEDSTYLE__SKEWANGLE = 720;

		// Token: 0x04001797 RID: 6039
		public const short THREEDSTYLE__SKEWAMOUNT = 721;

		// Token: 0x04001798 RID: 6040
		public const short THREEDSTYLE__AMBIENTINTENSITY = 722;

		// Token: 0x04001799 RID: 6041
		public const short THREEDSTYLE__KEYX = 723;

		// Token: 0x0400179A RID: 6042
		public const short THREEDSTYLE__KEYY = 724;

		// Token: 0x0400179B RID: 6043
		public const short THREEDSTYLE__KEYZ = 725;

		// Token: 0x0400179C RID: 6044
		public const short THREEDSTYLE__KEYINTENSITY = 726;

		// Token: 0x0400179D RID: 6045
		public const short THREEDSTYLE__FillX = 727;

		// Token: 0x0400179E RID: 6046
		public const short THREEDSTYLE__FillY = 728;

		// Token: 0x0400179F RID: 6047
		public const short THREEDSTYLE__FillZ = 729;

		// Token: 0x040017A0 RID: 6048
		public const short THREEDSTYLE__FillINTENSITY = 730;

		// Token: 0x040017A1 RID: 6049
		public const short THREEDSTYLE__CONSTRAINROTATION = 763;

		// Token: 0x040017A2 RID: 6050
		public const short THREEDSTYLE__ROTATIONCENTERAUTO = 764;

		// Token: 0x040017A3 RID: 6051
		public const short THREEDSTYLE__PARALLEL = 765;

		// Token: 0x040017A4 RID: 6052
		public const short THREEDSTYLE__KEYHARSH = 766;

		// Token: 0x040017A5 RID: 6053
		public const short THREEDSTYLE__FillHARSH = 767;

		// Token: 0x040017A6 RID: 6054
		public const short SHAPE__MASTER = 769;

		// Token: 0x040017A7 RID: 6055
		public const short SHAPE__CONNECTORSTYLE = 771;

		// Token: 0x040017A8 RID: 6056
		public const short SHAPE__BLACKANDWHITESetTINGS = 772;

		// Token: 0x040017A9 RID: 6057
		public const short SHAPE__WMODEPUREBW = 773;

		// Token: 0x040017AA RID: 6058
		public const short SHAPE__WMODEBW = 774;

		// Token: 0x040017AB RID: 6059
		public const short SHAPE__OLEICON = 826;

		// Token: 0x040017AC RID: 6060
		public const short SHAPE__PREFERRELATIVERESIZE = 827;

		// Token: 0x040017AD RID: 6061
		public const short SHAPE__LOCKSHAPETYPE = 828;

		// Token: 0x040017AE RID: 6062
		public const short SHAPE__DELETEATTACHEDOBJECT = 830;

		// Token: 0x040017AF RID: 6063
		public const short SHAPE__BACKGROUNDSHAPE = 831;

		// Token: 0x040017B0 RID: 6064
		public const short CALLOUT__CALLOUTTYPE = 832;

		// Token: 0x040017B1 RID: 6065
		public const short CALLOUT__XYCALLOUTGAP = 833;

		// Token: 0x040017B2 RID: 6066
		public const short CALLOUT__CALLOUTANGLE = 834;

		// Token: 0x040017B3 RID: 6067
		public const short CALLOUT__CALLOUTDROPTYPE = 835;

		// Token: 0x040017B4 RID: 6068
		public const short CALLOUT__CALLOUTDROPSPECIFIED = 836;

		// Token: 0x040017B5 RID: 6069
		public const short CALLOUT__CALLOUTLENGTHSPECIFIED = 837;

		// Token: 0x040017B6 RID: 6070
		public const short CALLOUT__ISCALLOUT = 889;

		// Token: 0x040017B7 RID: 6071
		public const short CALLOUT__CALLOUTACCENTBAR = 890;

		// Token: 0x040017B8 RID: 6072
		public const short CALLOUT__CALLOUTTEXTBORDER = 891;

		// Token: 0x040017B9 RID: 6073
		public const short CALLOUT__CALLOUTMINUSX = 892;

		// Token: 0x040017BA RID: 6074
		public const short CALLOUT__CALLOUTMINUSY = 893;

		// Token: 0x040017BB RID: 6075
		public const short CALLOUT__DROPAUTO = 894;

		// Token: 0x040017BC RID: 6076
		public const short CALLOUT__LENGTHSPECIFIED = 895;

		// Token: 0x040017BD RID: 6077
		public const short GROUPSHAPE__SHAPENAME = 896;

		// Token: 0x040017BE RID: 6078
		public const short GROUPSHAPE__DESCRIPTION = 897;

		// Token: 0x040017BF RID: 6079
		public const short GROUPSHAPE__HYPERLINK = 898;

		// Token: 0x040017C0 RID: 6080
		public const short GROUPSHAPE__WRAPPOLYGONVERTICES = 899;

		// Token: 0x040017C1 RID: 6081
		public const short GROUPSHAPE__WRAPDISTLEFT = 900;

		// Token: 0x040017C2 RID: 6082
		public const short GROUPSHAPE__WRAPDISTTOP = 901;

		// Token: 0x040017C3 RID: 6083
		public const short GROUPSHAPE__WRAPDISTRIGHT = 902;

		// Token: 0x040017C4 RID: 6084
		public const short GROUPSHAPE__WRAPDISTBOTTOM = 903;

		// Token: 0x040017C5 RID: 6085
		public const short GROUPSHAPE__REGROUPID = 904;

		// Token: 0x040017C6 RID: 6086
		public const short GROUPSHAPE__UNUSED906 = 906;

		// Token: 0x040017C7 RID: 6087
		public const short GROUPSHAPE__TOOLTIP = 909;

		// Token: 0x040017C8 RID: 6088
		public const short GROUPSHAPE__SCRIPT = 910;

		// Token: 0x040017C9 RID: 6089
		public const short GROUPSHAPE__POSH = 911;

		// Token: 0x040017CA RID: 6090
		public const short GROUPSHAPE__POSRELH = 912;

		// Token: 0x040017CB RID: 6091
		public const short GROUPSHAPE__POSV = 913;

		// Token: 0x040017CC RID: 6092
		public const short GROUPSHAPE__POSRELV = 914;

		// Token: 0x040017CD RID: 6093
		public const short GROUPSHAPE__HR_PCT = 915;

		// Token: 0x040017CE RID: 6094
		public const short GROUPSHAPE__HR_ALIGN = 916;

		// Token: 0x040017CF RID: 6095
		public const short GROUPSHAPE__HR_HEIGHT = 917;

		// Token: 0x040017D0 RID: 6096
		public const short GROUPSHAPE__HR_WIDTH = 918;

		// Token: 0x040017D1 RID: 6097
		public const short GROUPSHAPE__SCRIPTEXT = 919;

		// Token: 0x040017D2 RID: 6098
		public const short GROUPSHAPE__SCRIPTLANG = 920;

		// Token: 0x040017D3 RID: 6099
		public const short GROUPSHAPE__BORDERTOPCOLOR = 923;

		// Token: 0x040017D4 RID: 6100
		public const short GROUPSHAPE__BORDERLEFTCOLOR = 924;

		// Token: 0x040017D5 RID: 6101
		public const short GROUPSHAPE__BORDERBOTTOMCOLOR = 925;

		// Token: 0x040017D6 RID: 6102
		public const short GROUPSHAPE__BORDERRIGHTCOLOR = 926;

		// Token: 0x040017D7 RID: 6103
		public const short GROUPSHAPE__TABLEPROPERTIES = 927;

		// Token: 0x040017D8 RID: 6104
		public const short GROUPSHAPE__TABLEROWPROPERTIES = 928;

		// Token: 0x040017D9 RID: 6105
		public const short GROUPSHAPE__WEBBOT = 933;

		// Token: 0x040017DA RID: 6106
		public const short GROUPSHAPE__METROBLOB = 937;

		// Token: 0x040017DB RID: 6107
		public const short GROUPSHAPE__ZORDER = 938;

		// Token: 0x040017DC RID: 6108
		public const short GROUPSHAPE__FLAGS = 959;

		// Token: 0x040017DD RID: 6109
		public const short GROUPSHAPE__EDITEDWRAP = 953;

		// Token: 0x040017DE RID: 6110
		public const short GROUPSHAPE__BEHINDDOCUMENT = 954;

		// Token: 0x040017DF RID: 6111
		public const short GROUPSHAPE__ONDBLCLICKNOTIFY = 955;

		// Token: 0x040017E0 RID: 6112
		public const short GROUPSHAPE__ISBUTTON = 956;

		// Token: 0x040017E1 RID: 6113
		public const short GROUPSHAPE__1DADJUSTMENT = 957;

		// Token: 0x040017E2 RID: 6114
		public const short GROUPSHAPE__HIDDEN = 958;

		// Token: 0x040017E3 RID: 6115
		public const short GROUPSHAPE__PRINT = 959;

		// Token: 0x040017E4 RID: 6116
		private static global::System.Collections.Hashtable properties;
	}
}
