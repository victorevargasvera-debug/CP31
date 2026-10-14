<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="/">
        <Os xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
          <xsl:for-each select="OptionsCollection/OptionsList/OptionDesItem">
            <O t="{OptionTag}" s="{OptionStatus}" v="{Visible}" f="{OptionProductFamily}">
                <xsl:for-each select="OptionID">
                  <ID>
                      <xsl:attribute name="xsi:type">
                        <xsl:if test="@xsi:type='PCR_OptionIDDefinition'">
                          <xsl:text>PO</xsl:text>
                        </xsl:if>
                        <xsl:if test="@xsi:type='ASTRO_OptionIDDefinition'">
                          <xsl:text>AO</xsl:text>
                        </xsl:if>
                      </xsl:attribute>
                      <xsl:attribute name="v">
                        <xsl:value-of select="@OptionID"/>
                      </xsl:attribute>
                  </ID>
                </xsl:for-each>
            </O>
          </xsl:for-each>
        </Os>
    </xsl:template>
</xsl:stylesheet>
