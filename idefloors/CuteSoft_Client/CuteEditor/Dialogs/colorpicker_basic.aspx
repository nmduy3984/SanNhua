<%@ Page Language="C#" Inherits="CuteEditor.EditorUtilityPage" %>
<script runat="server">
string GetDialogQueryString;
override protected void OnInit(EventArgs args)
{
	if(Context.Request.QueryString["Dialog"]=="Standard")
	{	
	if(Context.Request.QueryString["IsFrame"]==null)
	{
		string FrameSrc="colorpicker_basic.aspx?IsFrame=1&"+Request.ServerVariables["QUERY_STRING"];
		CuteEditor.CEU.WriteDialogOuterFrame(Context,"[[MoreColors]]",FrameSrc);
		Context.Response.End();
	}
	}
	string s="";
	if(Context.Request.QueryString["Dialog"]=="Standard")	
		s="&Dialog=Standard";
	
	GetDialogQueryString="Theme="+Context.Request.QueryString["Theme"]+s;	
	base.OnInit(args);
}
</script>
<html xmlns="http://www.w3.org/1999/xhtml">
	<head runat="server">
		<meta http-equiv="Page-Enter" content="blendTrans(Duration=0.1)" />
		<meta http-equiv="Page-Exit" content="blendTrans(Duration=0.1)" />
		<script type="text/javascript" src="Load.ashx?type=dialogscript&verfix=1006&file=DialogHead.js"></script>
		<script type="text/javascript" src="Load.ashx?type=dialogscript&verfix=1006&file=Dialog_ColorPicker.js"></script>
		<link href='Load.ashx?type=themecss&file=dialog.css&theme=[[_Theme_]]' type="text/css"
			rel="stylesheet" />
		<style type="text/css">
			.colorcell
			{
				width:16px;
				height:17px;
				cursor:hand;
			}
			.colordiv,.customdiv
			{
				border:solid 1px #808080;
				width:16px;
				height:17px;
				font-size:1px;
			}
			#ajaxdiv{padding:10px;margin:0;text-align:center; background:#eeeeee;}
		</style>
		<title>[[NamedColors]]</title>
		<script>
								
		var OxO1f1a=["Green","#008000","Lime","#00FF00","Teal","#008080","Aqua","#00FFFF","Navy","#000080","Blue","#0000FF","Purple","#800080","Fuchsia","#FF00FF","Maroon","#800000","Red","#FF0000","Olive","#808000","Yellow","#FFFF00","White","#FFFFFF","Silver","#C0C0C0","Gray","#808080","Black","#000000","DarkOliveGreen","#556B2F","DarkGreen","#006400","DarkSlateGray","#2F4F4F","SlateGray","#708090","DarkBlue","#00008B","MidnightBlue","#191970","Indigo","#4B0082","DarkMagenta","#8B008B","Brown","#A52A2A","DarkRed","#8B0000","Sienna","#A0522D","SaddleBrown","#8B4513","DarkGoldenrod","#B8860B","Beige","#F5F5DC","HoneyDew","#F0FFF0","DimGray","#696969","OliveDrab","#6B8E23","ForestGreen","#228B22","DarkCyan","#008B8B","LightSlateGray","#778899","MediumBlue","#0000CD","DarkSlateBlue","#483D8B","DarkViolet","#9400D3","MediumVioletRed","#C71585","IndianRed","#CD5C5C","Firebrick","#B22222","Chocolate","#D2691E","Peru","#CD853F","Goldenrod","#DAA520","LightGoldenrodYellow","#FAFAD2","MintCream","#F5FFFA","DarkGray","#A9A9A9","YellowGreen","#9ACD32","SeaGreen","#2E8B57","CadetBlue","#5F9EA0","SteelBlue","#4682B4","RoyalBlue","#4169E1","BlueViolet","#8A2BE2","DarkOrchid","#9932CC","DeepPink","#FF1493","RosyBrown","#BC8F8F","Crimson","#DC143C","DarkOrange","#FF8C00","BurlyWood","#DEB887","DarkKhaki","#BDB76B","LightYellow","#FFFFE0","Azure","#F0FFFF","LightGray","#D3D3D3","LawnGreen","#7CFC00","MediumSeaGreen","#3CB371","LightSeaGreen","#20B2AA","DeepSkyBlue","#00BFFF","DodgerBlue","#1E90FF","SlateBlue","#6A5ACD","MediumOrchid","#BA55D3","PaleVioletRed","#DB7093","Salmon","#FA8072","OrangeRed","#FF4500","SandyBrown","#F4A460","Tan","#D2B48C","Gold","#FFD700","Ivory","#FFFFF0","GhostWhite","#F8F8FF","Gainsboro","#DCDCDC","Chartreuse","#7FFF00","LimeGreen","#32CD32","MediumAquamarine","#66CDAA","DarkTurquoise","#00CED1","CornflowerBlue","#6495ED","MediumSlateBlue","#7B68EE","Orchid","#DA70D6","HotPink","#FF69B4","LightCoral","#F08080","Tomato","#FF6347","Orange","#FFA500","Bisque","#FFE4C4","Khaki","#F0E68C","Cornsilk","#FFF8DC","Linen","#FAF0E6","WhiteSmoke","#F5F5F5","GreenYellow","#ADFF2F","DarkSeaGreen","#8FBC8B","Turquoise","#40E0D0","MediumTurquoise","#48D1CC","SkyBlue","#87CEEB","MediumPurple","#9370DB","Violet","#EE82EE","LightPink","#FFB6C1","DarkSalmon","#E9967A","Coral","#FF7F50","NavajoWhite","#FFDEAD","BlanchedAlmond","#FFEBCD","PaleGoldenrod","#EEE8AA","Oldlace","#FDF5E6","Seashell","#FFF5EE","PaleGreen","#98FB98","SpringGreen","#00FF7F","Aquamarine","#7FFFD4","PowderBlue","#B0E0E6","LightSkyBlue","#87CEFA","LightSteelBlue","#B0C4DE","Plum","#DDA0DD","Pink","#FFC0CB","LightSalmon","#FFA07A","Wheat","#F5DEB3","Moccasin","#FFE4B5","AntiqueWhite","#FAEBD7","LemonChiffon","#FFFACD","FloralWhite","#FFFAF0","Snow","#FFFAFA","AliceBlue","#F0F8FF","LightGreen","#90EE90","MediumSpringGreen","#00FA9A","PaleTurquoise","#AFEEEE","LightCyan","#E0FFFF","LightBlue","#ADD8E6","Lavender","#E6E6FA","Thistle","#D8BFD8","MistyRose","#FFE4E1","Peachpuff","#FFDAB9","PapayaWhip","#FFEFD5"];var colorlist=[{n:OxO1f1a[0],h:OxO1f1a[1]},{n:OxO1f1a[2],h:OxO1f1a[3]},{n:OxO1f1a[4],h:OxO1f1a[5]},{n:OxO1f1a[6],h:OxO1f1a[7]},{n:OxO1f1a[8],h:OxO1f1a[9]},{n:OxO1f1a[10],h:OxO1f1a[11]},{n:OxO1f1a[12],h:OxO1f1a[13]},{n:OxO1f1a[14],h:OxO1f1a[15]},{n:OxO1f1a[16],h:OxO1f1a[17]},{n:OxO1f1a[18],h:OxO1f1a[19]},{n:OxO1f1a[20],h:OxO1f1a[21]},{n:OxO1f1a[22],h:OxO1f1a[23]},{n:OxO1f1a[24],h:OxO1f1a[25]},{n:OxO1f1a[26],h:OxO1f1a[27]},{n:OxO1f1a[28],h:OxO1f1a[29]},{n:OxO1f1a[30],h:OxO1f1a[31]}];var colormore=[{n:OxO1f1a[32],h:OxO1f1a[33]},{n:OxO1f1a[34],h:OxO1f1a[35]},{n:OxO1f1a[36],h:OxO1f1a[37]},{n:OxO1f1a[38],h:OxO1f1a[39]},{n:OxO1f1a[40],h:OxO1f1a[41]},{n:OxO1f1a[42],h:OxO1f1a[43]},{n:OxO1f1a[44],h:OxO1f1a[45]},{n:OxO1f1a[46],h:OxO1f1a[47]},{n:OxO1f1a[48],h:OxO1f1a[49]},{n:OxO1f1a[50],h:OxO1f1a[51]},{n:OxO1f1a[52],h:OxO1f1a[53]},{n:OxO1f1a[54],h:OxO1f1a[55]},{n:OxO1f1a[56],h:OxO1f1a[57]},{n:OxO1f1a[58],h:OxO1f1a[59]},{n:OxO1f1a[60],h:OxO1f1a[61]},{n:OxO1f1a[62],h:OxO1f1a[63]},{n:OxO1f1a[64],h:OxO1f1a[65]},{n:OxO1f1a[66],h:OxO1f1a[67]},{n:OxO1f1a[68],h:OxO1f1a[69]},{n:OxO1f1a[70],h:OxO1f1a[71]},{n:OxO1f1a[72],h:OxO1f1a[73]},{n:OxO1f1a[74],h:OxO1f1a[75]},{n:OxO1f1a[76],h:OxO1f1a[77]},{n:OxO1f1a[78],h:OxO1f1a[79]},{n:OxO1f1a[80],h:OxO1f1a[81]},{n:OxO1f1a[82],h:OxO1f1a[83]},{n:OxO1f1a[84],h:OxO1f1a[85]},{n:OxO1f1a[86],h:OxO1f1a[87]},{n:OxO1f1a[88],h:OxO1f1a[89]},{n:OxO1f1a[90],h:OxO1f1a[91]},{n:OxO1f1a[92],h:OxO1f1a[93]},{n:OxO1f1a[94],h:OxO1f1a[95]},{n:OxO1f1a[96],h:OxO1f1a[97]},{n:OxO1f1a[98],h:OxO1f1a[99]},{n:OxO1f1a[100],h:OxO1f1a[101]},{n:OxO1f1a[102],h:OxO1f1a[103]},{n:OxO1f1a[104],h:OxO1f1a[105]},{n:OxO1f1a[106],h:OxO1f1a[107]},{n:OxO1f1a[108],h:OxO1f1a[109]},{n:OxO1f1a[110],h:OxO1f1a[111]},{n:OxO1f1a[112],h:OxO1f1a[113]},{n:OxO1f1a[114],h:OxO1f1a[115]},{n:OxO1f1a[116],h:OxO1f1a[117]},{n:OxO1f1a[118],h:OxO1f1a[119]},{n:OxO1f1a[120],h:OxO1f1a[121]},{n:OxO1f1a[122],h:OxO1f1a[123]},{n:OxO1f1a[124],h:OxO1f1a[125]},{n:OxO1f1a[126],h:OxO1f1a[127]},{n:OxO1f1a[128],h:OxO1f1a[129]},{n:OxO1f1a[130],h:OxO1f1a[131]},{n:OxO1f1a[132],h:OxO1f1a[133]},{n:OxO1f1a[134],h:OxO1f1a[135]},{n:OxO1f1a[136],h:OxO1f1a[137]},{n:OxO1f1a[138],h:OxO1f1a[139]},{n:OxO1f1a[140],h:OxO1f1a[141]},{n:OxO1f1a[142],h:OxO1f1a[143]},{n:OxO1f1a[144],h:OxO1f1a[145]},{n:OxO1f1a[146],h:OxO1f1a[147]},{n:OxO1f1a[148],h:OxO1f1a[149]},{n:OxO1f1a[150],h:OxO1f1a[151]},{n:OxO1f1a[152],h:OxO1f1a[153]},{n:OxO1f1a[154],h:OxO1f1a[155]},{n:OxO1f1a[156],h:OxO1f1a[157]},{n:OxO1f1a[158],h:OxO1f1a[159]},{n:OxO1f1a[160],h:OxO1f1a[161]},{n:OxO1f1a[162],h:OxO1f1a[163]},{n:OxO1f1a[164],h:OxO1f1a[165]},{n:OxO1f1a[166],h:OxO1f1a[167]},{n:OxO1f1a[168],h:OxO1f1a[169]},{n:OxO1f1a[170],h:OxO1f1a[171]},{n:OxO1f1a[172],h:OxO1f1a[173]},{n:OxO1f1a[174],h:OxO1f1a[175]},{n:OxO1f1a[176],h:OxO1f1a[177]},{n:OxO1f1a[178],h:OxO1f1a[179]},{n:OxO1f1a[180],h:OxO1f1a[181]},{n:OxO1f1a[182],h:OxO1f1a[183]},{n:OxO1f1a[184],h:OxO1f1a[185]},{n:OxO1f1a[186],h:OxO1f1a[187]},{n:OxO1f1a[188],h:OxO1f1a[189]},{n:OxO1f1a[190],h:OxO1f1a[191]},{n:OxO1f1a[192],h:OxO1f1a[193]},{n:OxO1f1a[194],h:OxO1f1a[195]},{n:OxO1f1a[196],h:OxO1f1a[197]},{n:OxO1f1a[198],h:OxO1f1a[199]},{n:OxO1f1a[200],h:OxO1f1a[201]},{n:OxO1f1a[202],h:OxO1f1a[203]},{n:OxO1f1a[204],h:OxO1f1a[205]},{n:OxO1f1a[206],h:OxO1f1a[207]},{n:OxO1f1a[208],h:OxO1f1a[209]},{n:OxO1f1a[210],h:OxO1f1a[211]},{n:OxO1f1a[212],h:OxO1f1a[213]},{n:OxO1f1a[214],h:OxO1f1a[215]},{n:OxO1f1a[216],h:OxO1f1a[217]},{n:OxO1f1a[218],h:OxO1f1a[219]},{n:OxO1f1a[220],h:OxO1f1a[221]},{n:OxO1f1a[156],h:OxO1f1a[157]},{n:OxO1f1a[222],h:OxO1f1a[223]},{n:OxO1f1a[224],h:OxO1f1a[225]},{n:OxO1f1a[226],h:OxO1f1a[227]},{n:OxO1f1a[228],h:OxO1f1a[229]},{n:OxO1f1a[230],h:OxO1f1a[231]},{n:OxO1f1a[232],h:OxO1f1a[233]},{n:OxO1f1a[234],h:OxO1f1a[235]},{n:OxO1f1a[236],h:OxO1f1a[237]},{n:OxO1f1a[238],h:OxO1f1a[239]},{n:OxO1f1a[240],h:OxO1f1a[241]},{n:OxO1f1a[242],h:OxO1f1a[243]},{n:OxO1f1a[244],h:OxO1f1a[245]},{n:OxO1f1a[246],h:OxO1f1a[247]},{n:OxO1f1a[248],h:OxO1f1a[249]},{n:OxO1f1a[250],h:OxO1f1a[251]},{n:OxO1f1a[252],h:OxO1f1a[253]},{n:OxO1f1a[254],h:OxO1f1a[255]},{n:OxO1f1a[256],h:OxO1f1a[257]},{n:OxO1f1a[258],h:OxO1f1a[259]},{n:OxO1f1a[260],h:OxO1f1a[261]},{n:OxO1f1a[262],h:OxO1f1a[263]},{n:OxO1f1a[264],h:OxO1f1a[265]},{n:OxO1f1a[266],h:OxO1f1a[267]},{n:OxO1f1a[268],h:OxO1f1a[269]},{n:OxO1f1a[270],h:OxO1f1a[271]},{n:OxO1f1a[272],h:OxO1f1a[273]}];
		
		</script>
	</head>
	<body>
		<div id="ajaxdiv">
			<div class="tab-pane-control tab-pane" id="tabPane1">
				<div class="tab-row">
					<h2 class="tab">
						<a tabindex="-1" href='colorpicker.aspx?<%=GetDialogQueryString%>'>
							<span style="white-space:nowrap;">
								[[WebPalette]]
							</span>
						</a>
					</h2>
					<h2 class="tab selected">
							<a tabindex="-1" href='colorpicker_basic.aspx?<%=GetDialogQueryString%>'>
								<span style="white-space:nowrap;">
									[[NamedColors]]
								</span>
							</a>
					</h2>
					<h2 class="tab">
							<a tabindex="-1" href='colorpicker_more.aspx?<%=GetDialogQueryString%>'>
								<span style="white-space:nowrap;">
									[[CustomColor]]
								</span>
							</a>
					</h2>
				</div>
				<div class="tab-page">			
					<table class="colortable" align="center">
						<tr>
							<td colspan="16" height="16"><p align="left">Basic:
								</p>
							</td>
						</tr>
						<tr>
							<script>
								var OxOe88e=["length","\x3Ctd class=\x27colorcell\x27\x3E\x3Cdiv class=\x27colordiv\x27 style=\x27background-color:","\x27 title=\x27"," ","\x27 cname=\x27","\x27 cvalue=\x27","\x27\x3E\x3C/div\x3E\x3C/td\x3E",""];var arr=[];for(var i=0;i<colorlist[OxOe88e[0]];i++){arr.push(OxOe88e[1]);arr.push(colorlist[i].n);arr.push(OxOe88e[2]);arr.push(colorlist[i].n);arr.push(OxOe88e[3]);arr.push(colorlist[i].h);arr.push(OxOe88e[4]);arr.push(colorlist[i].n);arr.push(OxOe88e[5]);arr.push(colorlist[i].h);arr.push(OxOe88e[6]);} ;document.write(arr.join(OxOe88e[7]));
							</script>
						</tr>
						<tr>
							<td colspan="16" height="12"><p align="left"></p>
							</td>
						</tr>
						<tr>
							<td colspan="16"><p align="left">Additional:
								</p>
							</td>
						</tr>
						<script>
							var OxO7e45=["length","\x3Ctr\x3E","\x3Ctd class=\x27colorcell\x27\x3E\x3Cdiv class=\x27colordiv\x27 style=\x27background-color:","\x27 title=\x27"," ","\x27 cname=\x27","\x27 cvalue=\x27","\x27\x3E\x3C/div\x3E\x3C/td\x3E","\x3C/tr\x3E",""];var arr=[];for(var i=0;i<colormore[OxO7e45[0]];i++){if(i%16==0){arr.push(OxO7e45[1]);} ;arr.push(OxO7e45[2]);arr.push(colormore[i].n);arr.push(OxO7e45[3]);arr.push(colormore[i].n);arr.push(OxO7e45[4]);arr.push(colormore[i].h);arr.push(OxO7e45[5]);arr.push(colormore[i].n);arr.push(OxO7e45[6]);arr.push(colormore[i].h);arr.push(OxO7e45[7]);if(i%16==15){arr.push(OxO7e45[8]);} ;} ;if(colormore%16>0){arr.push(OxO7e45[8]);} ;document.write(arr.join(OxO7e45[9]));
						</script>
						<tr>
							<td colspan="16" height="8">
							</td>
						</tr>
						<tr>
							<td colspan="16" height="12">
								<input checked id="CheckboxColorNames" style="width: 16px; height: 20px" type="checkbox">
								<span style="width: 118px;">Use color names</span>
							</td>
						</tr>
						<tr>
							<td colspan="16" height="12">
							</td>
						</tr>
						<tr>
							<td colspan="16" valign="middle" height="24">
							<span style="height:24px;width:50px;vertical-align:middle;">Color : </span>&nbsp;
							<input type="text" id="divpreview" size="7" maxlength="7" style="width:180px;height:24px;border:#a0a0a0 1px solid; Padding:4;"/>
					
							</td>
						</tr>
				</table>
			</div>
		</div>
		<div id="container-bottom">
			<input type="button" id="buttonok" value="[[OK]]" class="formbutton" style="width:70px"	onclick="do_insert();" /> 
			&nbsp;&nbsp;&nbsp;&nbsp; 
			<input type="button" id="buttoncancel" value="[[Cancel]]" class="formbutton" style="width:70px"	onclick="do_Close();" />	
		</div>
	</div>
	</body>
</html>

