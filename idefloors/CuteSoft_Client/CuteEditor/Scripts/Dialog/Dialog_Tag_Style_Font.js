var OxO81c7=["SetStyle","length","","GetStyle","GetText",":",";","cssText","sel_font","div_font_detail","sel_fontfamily","cb_decoration_under","cb_decoration_over","cb_decoration_through","cb_style_bold","cb_style_italic","sel_fontTransform","sel_fontsize","inp_fontsize","sel_fontsize_unit","inp_color","inp_color_Preview","outer","div_demo","disabled","selectedIndex","style","value","font","fontFamily","color","backgroundColor","textDecoration","checked","overline","underline","line-through","fontWeight","bold","fontStyle","italic","fontSize","options","textTransform","font-family","overline ","underline ","line-through ","onclick"];function pause(Ox4a3){var Oxa8= new Date();var Ox4a4=Oxa8.getTime()+Ox4a3;while(true){Oxa8= new Date();if(Oxa8.getTime()>Ox4a4){return ;} ;} ;} ;function StyleClass(Ox201){var Ox4a6=[];var Ox4a7={};if(Ox201){Ox4ac();} ;this[OxO81c7[0]]=function SetStyle(name,Ox4f,Ox4a9){name=name.toLowerCase();for(var i=0;i<Ox4a6[OxO81c7[1]];i++){if(Ox4a6[i]==name){break ;} ;} ;Ox4a6[i]=name;Ox4a7[name]=Ox4f?(Ox4f+(Ox4a9||OxO81c7[2])):OxO81c7[2];} ;this[OxO81c7[3]]=function GetStyle(name){name=name.toLowerCase();return Ox4a7[name]||OxO81c7[2];} ;this[OxO81c7[4]]=function Ox4ab(){var Ox201=OxO81c7[2];for(var i=0;i<Ox4a6[OxO81c7[1]];i++){var Ox27=Ox4a6[i];var p=Ox4a7[Ox27];if(p){Ox201+=Ox27+OxO81c7[5]+p+OxO81c7[6];} ;} ;return Ox201;} ;function Ox4ac(){var arr=Ox201.split(OxO81c7[6]);for(var i=0;i<arr[OxO81c7[1]];i++){var p=arr[i].split(OxO81c7[5]);var Ox27=p[0].replace(/^\s+/g,OxO81c7[2]).replace(/\s+$/g,OxO81c7[2]).toLowerCase();Ox4a6[Ox4a6[OxO81c7[1]]]=Ox27;Ox4a7[Ox27]=p[1];} ;} ;} ;function GetStyle(Ox137,name){return  new StyleClass(Ox137.cssText).GetStyle(name);} ;function SetStyle(Ox137,name,Ox4f,Ox4ad){var Ox4ae= new StyleClass(Ox137.cssText);Ox4ae.SetStyle(name,Ox4f,Ox4ad);Ox137[OxO81c7[7]]=Ox4ae.GetText();} ;function ParseFloatToString(Ox24){var Ox8=parseFloat(Ox24);if(isNaN(Ox8)){return OxO81c7[2];} ;return Ox8+OxO81c7[2];} ;var sel_font=Window_GetElement(window,OxO81c7[8],true);var div_font_detail=Window_GetElement(window,OxO81c7[9],true);var sel_fontfamily=Window_GetElement(window,OxO81c7[10],true);var cb_decoration_under=Window_GetElement(window,OxO81c7[11],true);var cb_decoration_over=Window_GetElement(window,OxO81c7[12],true);var cb_decoration_through=Window_GetElement(window,OxO81c7[13],true);var cb_style_bold=Window_GetElement(window,OxO81c7[14],true);var cb_style_italic=Window_GetElement(window,OxO81c7[15],true);var sel_fontTransform=Window_GetElement(window,OxO81c7[16],true);var sel_fontsize=Window_GetElement(window,OxO81c7[17],true);var inp_fontsize=Window_GetElement(window,OxO81c7[18],true);var sel_fontsize_unit=Window_GetElement(window,OxO81c7[19],true);var inp_color=Window_GetElement(window,OxO81c7[20],true);var inp_color_Preview=Window_GetElement(window,OxO81c7[21],true);var outer=Window_GetElement(window,OxO81c7[22],true);var div_demo=Window_GetElement(window,OxO81c7[23],true);UpdateState=function UpdateState_Font(){inp_fontsize[OxO81c7[24]]=sel_fontsize_unit[OxO81c7[24]]=(sel_fontsize[OxO81c7[25]]>0);div_font_detail[OxO81c7[24]]=sel_font[OxO81c7[25]]>0;div_demo[OxO81c7[26]][OxO81c7[7]]=element[OxO81c7[26]][OxO81c7[7]];} ;SyncToView=function SyncToView_Font(){sel_font[OxO81c7[27]]=element[OxO81c7[26]][OxO81c7[28]].toLowerCase()||null;sel_fontfamily[OxO81c7[27]]=element[OxO81c7[26]][OxO81c7[29]];inp_color[OxO81c7[27]]=element[OxO81c7[26]][OxO81c7[30]];inp_color[OxO81c7[26]][OxO81c7[31]]=inp_color[OxO81c7[27]];var Ox5e4=element[OxO81c7[26]][OxO81c7[32]].toLowerCase();cb_decoration_over[OxO81c7[33]]=Ox5e4.indexOf(OxO81c7[34])!=-1;cb_decoration_under[OxO81c7[33]]=Ox5e4.indexOf(OxO81c7[35])!=-1;cb_decoration_through[OxO81c7[33]]=Ox5e4.indexOf(OxO81c7[36])!=-1;cb_style_bold[OxO81c7[33]]=element[OxO81c7[26]][OxO81c7[37]]==OxO81c7[38];cb_style_italic[OxO81c7[33]]=element[OxO81c7[26]][OxO81c7[39]]==OxO81c7[40];sel_fontsize[OxO81c7[27]]=element[OxO81c7[26]][OxO81c7[41]];sel_fontsize_unit[OxO81c7[25]]=0;if(sel_fontsize[OxO81c7[25]]==-1){if(ParseFloatToString(element[OxO81c7[26]].fontSize)){sel_fontsize[OxO81c7[27]]=ParseFloatToString(element[OxO81c7[26]].fontSize);for(var i=0;i<sel_fontsize_unit[OxO81c7[42]][OxO81c7[1]];i++){var Ox142=sel_fontsize_unit.options(i)[OxO81c7[27]];if(Ox142&&element[OxO81c7[26]][OxO81c7[41]].indexOf(Ox142)!=-1){sel_fontsize_unit[OxO81c7[25]]=i;break ;} ;} ;} ;} ;sel_fontTransform[OxO81c7[27]]=element[OxO81c7[26]][OxO81c7[43]];} ;SyncTo=function SyncTo_Font(element){SetStyle(element.style,OxO81c7[28],sel_font.value);if(sel_fontfamily[OxO81c7[27]]){element[OxO81c7[26]][OxO81c7[29]]=sel_fontfamily[OxO81c7[27]];} else {SetStyle(element.style,OxO81c7[44],OxO81c7[2]);} ;try{element[OxO81c7[26]][OxO81c7[30]]=inp_color[OxO81c7[27]]||OxO81c7[2];} catch(x){element[OxO81c7[26]][OxO81c7[30]]=OxO81c7[2];} ;var Ox5e6=cb_decoration_over[OxO81c7[33]];var Ox5e7=cb_decoration_under[OxO81c7[33]];var Ox5e8=cb_decoration_through[OxO81c7[33]];if(!Ox5e6&&!Ox5e7&&!Ox5e8){element[OxO81c7[26]][OxO81c7[32]]=OxO81c7[2];} else {var Ox58=OxO81c7[2];if(Ox5e6){Ox58+=OxO81c7[45];} ;if(Ox5e7){Ox58+=OxO81c7[46];} ;if(Ox5e8){Ox58+=OxO81c7[47];} ;element[OxO81c7[26]][OxO81c7[32]]=Ox58.substr(0,Ox58[OxO81c7[1]]-1);} ;element[OxO81c7[26]][OxO81c7[37]]=cb_style_bold[OxO81c7[33]]?OxO81c7[38]:OxO81c7[2];element[OxO81c7[26]][OxO81c7[39]]=cb_style_italic[OxO81c7[33]]?OxO81c7[40]:OxO81c7[2];element[OxO81c7[26]][OxO81c7[43]]=sel_fontTransform[OxO81c7[27]]||OxO81c7[2];if(sel_fontsize[OxO81c7[25]]>0){element[OxO81c7[26]][OxO81c7[41]]=sel_fontsize[OxO81c7[27]];} else {if(ParseFloatToString(inp_fontsize.value)){element[OxO81c7[26]][OxO81c7[41]]=ParseFloatToString(inp_fontsize.value)+sel_fontsize_unit[OxO81c7[27]];} else {element[OxO81c7[26]][OxO81c7[41]]=OxO81c7[2];} ;} ;} ;inp_color[OxO81c7[48]]=inp_color_Preview[OxO81c7[48]]=function inp_color_onclick(){SelectColor(inp_color,inp_color_Preview);} ;