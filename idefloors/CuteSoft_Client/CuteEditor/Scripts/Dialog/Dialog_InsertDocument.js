var OxO84d5=["top","hiddenDirectory","hiddenFile","hiddenAlert","hiddenAction","hiddenActionData","This function is disabled in the demo mode.","disabled","[[Disabled]]","[[SpecifyNewFolderName]]","","value","createdir","[[CopyMoveto]]","/","move","copy","[[AreyouSureDelete]]","parentNode","text","isdir","true",".","[[SpecifyNewFileName]]","rename","True","False",":","path","FoldersAndFiles","TR","length","onmouseover","this.style.backgroundColor=\x27#eeeeee\x27;","onmouseout","this.style.backgroundColor=\x27\x27;","nodeName","INPUT","changedir","url","TargetUrl","htmlcode","onload","getElementsByTagName","table","sortable"," ","className","id","rows","cells","innerHTML","\x3Ca href=\x22#\x22 onclick=\x22ts_resortTable(this);return false;\x22\x3E","\x3Cspan class=\x22sortarrow\x22\x3E\x26nbsp;\x3C/span\x3E\x3C/a\x3E","string","undefined","innerText","childNodes","nodeValue","nodeType","span","cellIndex","TABLE","sortdir","down","\x26uarr;","up","\x26darr;","sortbottom","tBodies","sortarrow","\x26nbsp;","20","19","browse_Frame","Image1","FolderDescription","CreateDir","Copy","Move","Delete","DoRefresh","name_Cell","size_Cell","op_Cell","divpreview","sel_target","inp_color","inp_color_preview","inc_class","inp_id","inp_index","inp_access","Table8","inp_title","btn_zoom_in","btn_zoom_out","btn_Actualsize","a","editor","documentElement","documentMode","clientHeight","scrollHeight","width","style","255px","appName","Microsoft Internet Explorer","userAgent","MSIE ([0-9]{1,}[.0-9]{0,})","color","backgroundColor","class","title","target","tabIndex","accessKey","href","href_cetemp",".jpeg",".jpg",".gif",".png","\x3CIMG src=\x27","\x27\x3E",".bmp","\x26nbsp;\x3Cembed src=\x22","\x22 quality=\x22high\x22 width=\x22200\x22 height=\x22200\x22 type=\x22application/x-shockwave-flash\x22 pluginspage=\x22http://www.macromedia.com/go/getflashplayer\x22\x3E\x3C/embed\x3E\x0A",".swf",".avi",".mpg",".mp3","\x26nbsp;\x3Cembed name=\x22MediaPlayer1\x22 src=\x22","\x22 autostart=-1 showcontrols=-1  type=\x22application/x-mplayer2\x22 width=\x22240\x22 height=\x22200\x22 pluginspage=\x22http://www.microsoft.com/Windows/MediaPlayer\x22 \x3E\x3C/embed\x3E\x0A",".mpeg","\x3Cdiv\x3E\x3C/div\x3E","\x3Cdiv\x3E\x26nbsp;\x3C/div\x3E","\x3Cdiv\x3E\x26#160;\x3C/div\x3E","\x3Cp\x3E\x3C/p\x3E","\x3Cp\x3E\x26#160;\x3C/p\x3E","\x3Cp\x3E\x26nbsp;\x3C/p\x3E","name","zoom","onclick","display","none","align","absmiddle","wrapupPrompt","iepromptfield","body","div","IEPromptBox","promptBlackout","border","1px solid #b0bec7","#f0f0f0","position","absolute","330px","zIndex","100","\x3Cdiv style=\x22width: 100%; padding-top:3px;background-color: #DCE7EB; font-family: verdana; font-size: 10pt; font-weight: bold; height: 22px; text-align:center; background:url(Load.ashx?type=image\x26file=formbg2.gif) repeat-x left top;\x22\x3E[[InputRequired]]\x3C/div\x3E","\x3Cdiv style=\x22padding: 10px\x22\x3E","\x3CBR\x3E\x3CBR\x3E","\x3Cform action=\x22\x22 onsubmit=\x22return wrapupPrompt()\x22\x3E","\x3Cinput id=\x22iepromptfield\x22 name=\x22iepromptdata\x22 type=text size=46 value=\x22","\x22\x3E","\x3Cbr\x3E\x3Cbr\x3E\x3Ccenter\x3E","\x3Cinput type=\x22submit\x22 value=\x22\x26nbsp;\x26nbsp;\x26nbsp;[[OK]]\x26nbsp;\x26nbsp;\x26nbsp;\x22\x3E","\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;","\x3Cinput type=\x22button\x22 onclick=\x22wrapupPrompt(true)\x22 value=\x22\x26nbsp;[[Cancel]]\x26nbsp;\x22\x3E","\x3C/form\x3E\x3C/div\x3E","100px","left","offsetWidth","px","block","CuteEditor_ColorPicker_ButtonOver(this)"];function Window_GetDialogTop(Ox1a8){return Ox1a8[OxO84d5[0]];} ;var hiddenDirectory=Window_GetElement(window,OxO84d5[1],true);var hiddenFile=Window_GetElement(window,OxO84d5[2],true);var hiddenAlert=Window_GetElement(window,OxO84d5[3],true);var hiddenAction=Window_GetElement(window,OxO84d5[4],true);var hiddenActionData=Window_GetElement(window,OxO84d5[5],true);function CreateDir_click(){if(isDemoMode){alert(OxO84d5[6]);return false;} ;if(Event_GetSrcElement()[OxO84d5[7]]){alert(OxO84d5[8]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox221,OxO84d5[9],OxO84d5[10]);function Ox221(Ox382){if(Ox382){hiddenActionData[OxO84d5[11]]=Ox382;hiddenAction[OxO84d5[11]]=OxO84d5[12];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox382=prompt(OxO84d5[9],OxO84d5[10]);if(Ox382){hiddenActionData[OxO84d5[11]]=Ox382;return true;} else {return false;} ;return false;} ;} ;function Move_click(){if(isDemoMode){alert(OxO84d5[6]);return false;} ;if(Event_GetSrcElement()[OxO84d5[7]]){alert(OxO84d5[8]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox221,OxO84d5[13],OxO84d5[14]);function Ox221(Ox382){if(Ox382){hiddenActionData[OxO84d5[11]]=Ox382;hiddenAction[OxO84d5[11]]=OxO84d5[15];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox382=prompt(OxO84d5[13],OxO84d5[14]);if(Ox382){hiddenActionData[OxO84d5[11]]=Ox382;return true;} else {return false;} ;return false;} ;} ;function Copy_click(){if(isDemoMode){alert(OxO84d5[6]);return false;} ;if(Event_GetSrcElement()[OxO84d5[7]]){alert(OxO84d5[8]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox221,OxO84d5[13],OxO84d5[14]);function Ox221(Ox382){if(Ox382){hiddenActionData[OxO84d5[11]]=Ox382;hiddenAction[OxO84d5[11]]=OxO84d5[16];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox382=prompt(OxO84d5[13],OxO84d5[14]);if(Ox382){hiddenActionData[OxO84d5[11]]=Ox382;return true;} else {return false;} ;return false;} ;} ;function Delete_click(){if(isDemoMode){alert(OxO84d5[6]);return false;} ;if(Event_GetSrcElement()[OxO84d5[7]]){alert(OxO84d5[8]);return false;} ;return confirm(OxO84d5[17]);} ;function EditImg_click(img){if(isDemoMode){alert(OxO84d5[6]);return false;} ;if(img[OxO84d5[7]]){alert(OxO84d5[8]);return false;} ;var Ox387=img[OxO84d5[18]][OxO84d5[18]];var Ox388=Ox387.getAttribute(OxO84d5[19]);var name;var Ox389;Ox389=Ox387.getAttribute(OxO84d5[20])==OxO84d5[21];if(Browser_IsIE7()){var Oxca;if(Ox389){IEprompt(Ox221,OxO84d5[9],Ox388);} else {var i=Ox388.lastIndexOf(OxO84d5[22]);Oxca=Ox388.substr(i);var Ox12=Ox388.substr(0,Ox388.lastIndexOf(OxO84d5[22]));IEprompt(Ox221,OxO84d5[23],Ox12);} ;function Ox221(Ox382){if(Ox382&&Ox382!=Ox387.getAttribute(OxO84d5[19])){if(!Ox389){Ox382=Ox382+Oxca;} ;hiddenAction[OxO84d5[11]]=OxO84d5[24];hiddenActionData[OxO84d5[11]]=(Ox389?OxO84d5[25]:OxO84d5[26])+OxO84d5[27]+Ox387.getAttribute(OxO84d5[28])+OxO84d5[27]+Ox382;window.PostBackAction();} ;} ;} else {if(Ox389){name=prompt(OxO84d5[9],Ox388);} else {var i=Ox388.lastIndexOf(OxO84d5[22]);var Oxca=Ox388.substr(i);var Ox12=Ox388.substr(0,Ox388.lastIndexOf(OxO84d5[22]));name=prompt(OxO84d5[23],Ox12);if(name){name=name+Oxca;} ;} ;if(name&&name!=Ox387.getAttribute(OxO84d5[19])){hiddenAction[OxO84d5[11]]=OxO84d5[24];hiddenActionData[OxO84d5[11]]=(Ox389?OxO84d5[25]:OxO84d5[26])+OxO84d5[27]+Ox387.getAttribute(OxO84d5[28])+OxO84d5[27]+name;window.PostBackAction();} ;} ;return Event_CancelEvent();} ;setMouseOver();function setMouseOver(){var FoldersAndFiles=Window_GetElement(window,OxO84d5[29],true);var Ox38c=FoldersAndFiles.getElementsByTagName(OxO84d5[30]);for(var i=1;i<Ox38c[OxO84d5[31]];i++){var Ox387=Ox38c[i];Ox387[OxO84d5[32]]= new Function(OxO84d5[10],OxO84d5[33]);Ox387[OxO84d5[34]]= new Function(OxO84d5[10],OxO84d5[35]);} ;} ;function row_click(Ox387){var Ox389;Ox389=Ox387.getAttribute(OxO84d5[20])==OxO84d5[21];if(Ox389){if(Event_GetSrcElement()[OxO84d5[36]]==OxO84d5[37]){return ;} ;hiddenAction[OxO84d5[11]]=OxO84d5[38];hiddenActionData[OxO84d5[11]]=Ox387.getAttribute(OxO84d5[28]);window.PostBackAction();} else {var Ox109=Ox387.getAttribute(OxO84d5[28]);hiddenFile[OxO84d5[11]]=Ox109;var Ox288=Ox387.getAttribute(OxO84d5[39]);Window_GetElement(window,OxO84d5[40],true)[OxO84d5[11]]=Ox288;var htmlcode=Ox387.getAttribute(OxO84d5[41]);if(htmlcode!=OxO84d5[10]&&htmlcode!=null){do_preview(htmlcode);} else {try{Actualsize();} catch(x){do_preview();} ;} ;} ;} ;function do_preview(){} ;function reset_hiddens(){if(hiddenAlert[OxO84d5[11]]){alert(hiddenAlert.value);} ;if(TargetUrl[OxO84d5[11]]!=OxO84d5[10]&&TargetUrl[OxO84d5[11]]!=null){do_preview();} ;hiddenAlert[OxO84d5[11]]=OxO84d5[10];hiddenAction[OxO84d5[11]]=OxO84d5[10];hiddenActionData[OxO84d5[11]]=OxO84d5[10];} ;Event_Attach(window,OxO84d5[42],reset_hiddens);function RequireFileBrowseScript(){} ;Event_Attach(window,OxO84d5[42],sortables_init);var SORT_COLUMN_INDEX;function sortables_init(){if(!document[OxO84d5[43]]){return ;} ;var Ox391=document.getElementsByTagName(OxO84d5[44]);for(var Ox392=0;Ox392<Ox391[OxO84d5[31]];Ox392++){var Ox393=Ox391[Ox392];if(((OxO84d5[46]+Ox393[OxO84d5[47]]+OxO84d5[46]).indexOf(OxO84d5[45])!=-1)&&(Ox393[OxO84d5[48]])){ts_makeSortable(Ox393);} ;} ;} ;function ts_makeSortable(Ox395){if(Ox395[OxO84d5[49]]&&Ox395[OxO84d5[49]][OxO84d5[31]]>0){var Ox396=Ox395[OxO84d5[49]][0];} ;if(!Ox396){return ;} ;for(var i=2;i<4;i++){var Ox397=Ox396[OxO84d5[50]][i];var Ox219=ts_getInnerText(Ox397);Ox397[OxO84d5[51]]=OxO84d5[52]+Ox219+OxO84d5[53];} ;} ;function ts_getInnerText(Ox29){if( typeof Ox29==OxO84d5[54]){return Ox29;} ;if( typeof Ox29==OxO84d5[55]){return Ox29;} ;if(Ox29[OxO84d5[56]]){return Ox29[OxO84d5[56]];} ;var Ox24=OxO84d5[10];var Ox343=Ox29[OxO84d5[57]];var Ox11=Ox343[OxO84d5[31]];for(var i=0;i<Ox11;i++){switch(Ox343[i][OxO84d5[59]]){case 1:Ox24+=ts_getInnerText(Ox343[i]);break ;;case 3:Ox24+=Ox343[i][OxO84d5[58]];break ;;} ;} ;return Ox24;} ;function ts_resortTable(Ox39a){var Ox2a6;for(var Ox39b=0;Ox39b<Ox39a[OxO84d5[57]][OxO84d5[31]];Ox39b++){if(Ox39a[OxO84d5[57]][Ox39b][OxO84d5[36]]&&Ox39a[OxO84d5[57]][Ox39b][OxO84d5[36]].toLowerCase()==OxO84d5[60]){Ox2a6=Ox39a[OxO84d5[57]][Ox39b];} ;} ;var Ox39c=ts_getInnerText(Ox2a6);var Ox1e4=Ox39a[OxO84d5[18]];var Ox39d=Ox1e4[OxO84d5[61]];var Ox395=getParent(Ox1e4,OxO84d5[62]);if(Ox395[OxO84d5[49]][OxO84d5[31]]<=1){return ;} ;var Ox39e=ts_getInnerText(Ox395[OxO84d5[49]][1][OxO84d5[50]][Ox39d]);var Ox39f=ts_sort_caseinsensitive;if(Ox39e.match(/^\d\d[\/-]\d\d[\/-]\d\d\d\d$/)){Ox39f=ts_sort_date;} ;if(Ox39e.match(/^\d\d[\/-]\d\d[\/-]\d\d$/)){Ox39f=ts_sort_date;} ;if(Ox39e.match(/^[?]/)){Ox39f=ts_sort_currency;} ;if(Ox39e.match(/^[\d\.]+$/)){Ox39f=ts_sort_numeric;} ;SORT_COLUMN_INDEX=Ox39d;var Ox396= new Array();var Ox3a0= new Array();for(var i=0;i<Ox395[OxO84d5[49]][0][OxO84d5[31]];i++){Ox396[i]=Ox395[OxO84d5[49]][0][i];} ;for(var Ox25=1;Ox25<Ox395[OxO84d5[49]][OxO84d5[31]];Ox25++){Ox3a0[Ox25-1]=Ox395[OxO84d5[49]][Ox25];} ;Ox3a0.sort(Ox39f);if(Ox2a6.getAttribute(OxO84d5[63])==OxO84d5[64]){var Ox3a1=OxO84d5[65];Ox3a0.reverse();Ox2a6.setAttribute(OxO84d5[63],OxO84d5[66]);} else {Ox3a1=OxO84d5[67];Ox2a6.setAttribute(OxO84d5[63],OxO84d5[64]);} ;for(i=0;i<Ox3a0[OxO84d5[31]];i++){if(!Ox3a0[i][OxO84d5[47]]||(Ox3a0[i][OxO84d5[47]]&&(Ox3a0[i][OxO84d5[47]].indexOf(OxO84d5[68])==-1))){Ox395[OxO84d5[69]][0].appendChild(Ox3a0[i]);} ;} ;for(i=0;i<Ox3a0[OxO84d5[31]];i++){if(Ox3a0[i][OxO84d5[47]]&&(Ox3a0[i][OxO84d5[47]].indexOf(OxO84d5[68])!=-1)){Ox395[OxO84d5[69]][0].appendChild(Ox3a0[i]);} ;} ;var Ox3a2=document.getElementsByTagName(OxO84d5[60]);for(var Ox39b=0;Ox39b<Ox3a2[OxO84d5[31]];Ox39b++){if(Ox3a2[Ox39b][OxO84d5[47]]==OxO84d5[70]){if(getParent(Ox3a2[Ox39b],OxO84d5[44])==getParent(Ox39a,OxO84d5[44])){Ox3a2[Ox39b][OxO84d5[51]]=OxO84d5[71];} ;} ;} ;Ox2a6[OxO84d5[51]]=Ox3a1;} ;function getParent(Ox29,Ox3a4){if(Ox29==null){return null;} else {if(Ox29[OxO84d5[59]]==1&&Ox29[OxO84d5[36]].toLowerCase()==Ox3a4.toLowerCase()){return Ox29;} else {return getParent(Ox29.parentNode,Ox3a4);} ;} ;} ;function ts_sort_date(Oxee,b){var Ox3a6=ts_getInnerText(Oxee[OxO84d5[50]][SORT_COLUMN_INDEX]);var Ox3a7=ts_getInnerText(b[OxO84d5[50]][SORT_COLUMN_INDEX]);if(Ox3a6[OxO84d5[31]]==10){var Ox3a8=Ox3a6.substr(6,4)+Ox3a6.substr(3,2)+Ox3a6.substr(0,2);} else {var Ox3a9=Ox3a6.substr(6,2);if(parseInt(Ox3a9)<50){Ox3a9=OxO84d5[72]+Ox3a9;} else {Ox3a9=OxO84d5[73]+Ox3a9;} ;var Ox3a8=Ox3a9+Ox3a6.substr(3,2)+Ox3a6.substr(0,2);} ;if(Ox3a7[OxO84d5[31]]==10){var Ox3aa=Ox3a7.substr(6,4)+Ox3a7.substr(3,2)+Ox3a7.substr(0,2);} else {Ox3a9=Ox3a7.substr(6,2);if(parseInt(Ox3a9)<50){Ox3a9=OxO84d5[72]+Ox3a9;} else {Ox3a9=OxO84d5[73]+Ox3a9;} ;var Ox3aa=Ox3a9+Ox3a7.substr(3,2)+Ox3a7.substr(0,2);} ;if(Ox3a8==Ox3aa){return 0;} ;if(Ox3a8<Ox3aa){return -1;} ;return 1;} ;function ts_sort_currency(Oxee,b){var Ox3a6=ts_getInnerText(Oxee[OxO84d5[50]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxO84d5[10]);var Ox3a7=ts_getInnerText(b[OxO84d5[50]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxO84d5[10]);return parseFloat(Ox3a6)-parseFloat(Ox3a7);} ;function ts_sort_numeric(Oxee,b){var Ox3a6=parseFloat(ts_getInnerText(Oxee[OxO84d5[50]][SORT_COLUMN_INDEX]));if(isNaN(Ox3a6)){Ox3a6=0;} ;var Ox3a7=parseFloat(ts_getInnerText(b[OxO84d5[50]][SORT_COLUMN_INDEX]));if(isNaN(Ox3a7)){Ox3a7=0;} ;return Ox3a6-Ox3a7;} ;function ts_sort_caseinsensitive(Oxee,b){var Ox3a6=ts_getInnerText(Oxee[OxO84d5[50]][SORT_COLUMN_INDEX]).toLowerCase();var Ox3a7=ts_getInnerText(b[OxO84d5[50]][SORT_COLUMN_INDEX]).toLowerCase();if(Ox3a6==Ox3a7){return 0;} ;if(Ox3a6<Ox3a7){return -1;} ;return 1;} ;function ts_sort_default(Oxee,b){var Ox3a6=ts_getInnerText(Oxee[OxO84d5[50]][SORT_COLUMN_INDEX]);var Ox3a7=ts_getInnerText(b[OxO84d5[50]][SORT_COLUMN_INDEX]);if(Ox3a6==Ox3a7){return 0;} ;if(Ox3a6<Ox3a7){return -1;} ;return 1;} [sortables_init];RequireFileBrowseScript();var browse_Frame=Window_GetElement(window,OxO84d5[74],true);var hiddenDirectory=Window_GetElement(window,OxO84d5[1],true);var hiddenFile=Window_GetElement(window,OxO84d5[2],true);var hiddenAlert=Window_GetElement(window,OxO84d5[3],true);var hiddenAction=Window_GetElement(window,OxO84d5[4],true);var hiddenActionData=Window_GetElement(window,OxO84d5[5],true);var Image1=Window_GetElement(window,OxO84d5[75],true);var FolderDescription=Window_GetElement(window,OxO84d5[76],true);var CreateDir=Window_GetElement(window,OxO84d5[77],true);var Copy=Window_GetElement(window,OxO84d5[78],true);var Move=Window_GetElement(window,OxO84d5[79],true);var FoldersAndFiles=Window_GetElement(window,OxO84d5[29],true);var Delete=Window_GetElement(window,OxO84d5[80],true);var DoRefresh=Window_GetElement(window,OxO84d5[81],true);var name_Cell=Window_GetElement(window,OxO84d5[82],true);var size_Cell=Window_GetElement(window,OxO84d5[83],true);var op_Cell=Window_GetElement(window,OxO84d5[84],true);var divpreview=Window_GetElement(window,OxO84d5[85],true);var sel_target=Window_GetElement(window,OxO84d5[86],true);var inp_color=Window_GetElement(window,OxO84d5[87],true);var inp_color_preview=Window_GetElement(window,OxO84d5[88],true);var inc_class=Window_GetElement(window,OxO84d5[89],true);var inp_id=Window_GetElement(window,OxO84d5[90],true);var inp_index=Window_GetElement(window,OxO84d5[91],true);var inp_access=Window_GetElement(window,OxO84d5[92],true);var Table8=Window_GetElement(window,OxO84d5[93],true);var TargetUrl=Window_GetElement(window,OxO84d5[40],true);var inp_title=Window_GetElement(window,OxO84d5[94],true);var btn_zoom_in=Window_GetElement(window,OxO84d5[95],true);var btn_zoom_out=Window_GetElement(window,OxO84d5[96],true);var btn_Actualsize=Window_GetElement(window,OxO84d5[97],true);var obj=Window_GetDialogArguments(window);var element=null;if(obj){element=obj[OxO84d5[98]];} ;var editor=obj[OxO84d5[99]];var ver=getInternetExplorerVersion();if(ver>-1&&ver<=9.0){var needAdjust=true;if(ver>=8.0&&document[OxO84d5[100]]){if(document[OxO84d5[101]]>7){needAdjust=false;} ;} ;if(needAdjust&&(browse_Frame[OxO84d5[102]]<browse_Frame[OxO84d5[103]])){FoldersAndFiles[OxO84d5[105]][OxO84d5[104]]=OxO84d5[106];} ;} ;function getInternetExplorerVersion(){var Ox3ca=-1;if(navigator[OxO84d5[107]]==OxO84d5[108]){var Ox3cb=navigator[OxO84d5[109]];var Ox296= new RegExp(OxO84d5[110]);if(Ox296.exec(Ox3cb)!=null){Ox3ca=parseFloat(RegExp.$1);} ;} ;return Ox3ca;} ;var htmlcode=OxO84d5[10];if(element[OxO84d5[105]][OxO84d5[111]]){inp_color[OxO84d5[11]]=revertColor(element[OxO84d5[105]].color);inp_color[OxO84d5[105]][OxO84d5[112]]=inp_color[OxO84d5[11]];inp_color_preview[OxO84d5[105]][OxO84d5[112]]=inp_color[OxO84d5[11]];} ;if(element[OxO84d5[47]]==OxO84d5[10]){element.removeAttribute(OxO84d5[47]);} ;if(element[OxO84d5[47]]==OxO84d5[10]){element.removeAttribute(OxO84d5[113]);} ;if(element[OxO84d5[114]]){inp_title[OxO84d5[11]]=element[OxO84d5[114]];} ;if(element[OxO84d5[115]]){sel_target[OxO84d5[11]]=element[OxO84d5[115]];} ;if(element[OxO84d5[116]]){inp_index[OxO84d5[11]]=element[OxO84d5[116]];} ;if(element[OxO84d5[117]]){inp_access[OxO84d5[11]]=element[OxO84d5[117]];} ;var src=OxO84d5[10];if(element.getAttribute(OxO84d5[118])){src=element.getAttribute(OxO84d5[118]);} ;if(element.getAttribute(OxO84d5[119])){src=element.getAttribute(OxO84d5[119]);} ;if(TargetUrl[OxO84d5[11]]){Actualsize();} else {if(element&&src){TargetUrl[OxO84d5[11]]=src;} ;} ;inp_id[OxO84d5[11]]=element[OxO84d5[48]];var divpreview=Window_GetElement(window,OxO84d5[85],true);do_preview();function do_preview(Ox283){if(Ox283!=OxO84d5[10]&&Ox283!=null){htmlcode=Ox283;divpreview[OxO84d5[51]]=Ox283;return ;} ;divpreview[OxO84d5[51]]=OxO84d5[10];var Ox288=TargetUrl[OxO84d5[11]];if(Ox288==OxO84d5[10]){return ;} ;var Oxca=Ox288.substring(Ox288.lastIndexOf(OxO84d5[22])).toLowerCase();switch(Oxca){case OxO84d5[120]:;case OxO84d5[121]:;case OxO84d5[122]:;case OxO84d5[123]:;case OxO84d5[126]:divpreview[OxO84d5[51]]=OxO84d5[124]+Ox288+OxO84d5[125];break ;;case OxO84d5[129]:var Ox3cc=OxO84d5[127]+Ox288+OxO84d5[128];divpreview[OxO84d5[51]]=Ox3cc+OxO84d5[71];break ;;case OxO84d5[130]:;case OxO84d5[131]:;case OxO84d5[132]:;case OxO84d5[135]:var Ox3cd=OxO84d5[133]+Ox288+OxO84d5[134];divpreview[OxO84d5[51]]=Ox3cd+OxO84d5[71];break ;;} ;} ;function do_insert(){element[OxO84d5[47]]=inc_class[OxO84d5[11]];element[OxO84d5[115]]=sel_target[OxO84d5[11]];element[OxO84d5[114]]=inp_title[OxO84d5[11]];if(TargetUrl[OxO84d5[11]]){element[OxO84d5[118]]=TargetUrl[OxO84d5[11]];element.setAttribute(OxO84d5[119],TargetUrl.value);} ;element[OxO84d5[116]]=inp_index[OxO84d5[11]];element[OxO84d5[117]]=inp_access[OxO84d5[11]];element[OxO84d5[48]]=inp_id[OxO84d5[11]];if(element[OxO84d5[114]]==OxO84d5[10]){element.removeAttribute(OxO84d5[114]);} ;if(element[OxO84d5[115]]==OxO84d5[10]){element.removeAttribute(OxO84d5[115]);} ;if(element[OxO84d5[47]]==OxO84d5[10]){element.removeAttribute(OxO84d5[47]);} ;if(element[OxO84d5[47]]==OxO84d5[10]){element.removeAttribute(OxO84d5[113]);} ;if(element[OxO84d5[116]]==OxO84d5[10]){element.removeAttribute(OxO84d5[116]);} ;if(element[OxO84d5[117]]==OxO84d5[10]){element.removeAttribute(OxO84d5[117]);} ;if(element[OxO84d5[48]]==OxO84d5[10]){element.removeAttribute(OxO84d5[48]);} ;try{element[OxO84d5[105]][OxO84d5[111]]=inp_color[OxO84d5[11]];} catch(er){element[OxO84d5[105]][OxO84d5[111]]=OxO84d5[10];} ;var Ox283=element[OxO84d5[51]];switch(Ox283.toLowerCase()){case OxO84d5[136]:;case OxO84d5[137]:;case OxO84d5[138]:;case OxO84d5[139]:;case OxO84d5[140]:;case OxO84d5[141]:element[OxO84d5[51]]=OxO84d5[10];break ;;default:break ;;} ;if(element[OxO84d5[51]]==OxO84d5[10]){element[OxO84d5[51]]=element[OxO84d5[114]]||TargetUrl[OxO84d5[11]]||element[OxO84d5[142]]||OxO84d5[10];} ;Window_SetDialogReturnValue(window,element);Window_CloseDialog(window);} ;function do_Close(){Window_SetDialogReturnValue(window,null);Window_CloseDialog(window);} ;function Zoom_In(){if(divpreview[OxO84d5[105]][OxO84d5[143]]!=0){divpreview[OxO84d5[105]][OxO84d5[143]]*=1.2;} else {divpreview[OxO84d5[105]][OxO84d5[143]]=1.2;} ;} ;function Zoom_Out(){if(divpreview[OxO84d5[105]][OxO84d5[143]]!=0){divpreview[OxO84d5[105]][OxO84d5[143]]*=0.8;} else {divpreview[OxO84d5[105]][OxO84d5[143]]=0.8;} ;} ;function Actualsize(){divpreview[OxO84d5[105]][OxO84d5[143]]=1;do_preview();} ;inp_color[OxO84d5[144]]=inp_color_preview[OxO84d5[144]]=function inp_color_onclick(){SelectColor(inp_color,inp_color_preview);} ;if(!Browser_IsWinIE()){btn_zoom_in[OxO84d5[105]][OxO84d5[145]]=btn_zoom_out[OxO84d5[105]][OxO84d5[145]]=btn_Actualsize[OxO84d5[105]][OxO84d5[145]]=OxO84d5[146];inp_color_preview.setAttribute(OxO84d5[147],OxO84d5[148]);} ;if(Browser_IsIE7()){var _dialogPromptID=null;function IEprompt(Ox221,Ox222,Ox223){that=this;this[OxO84d5[149]]=function (Ox224){val=document.getElementById(OxO84d5[150])[OxO84d5[11]];_dialogPromptID[OxO84d5[105]][OxO84d5[145]]=OxO84d5[146];document.getElementById(OxO84d5[150])[OxO84d5[11]]=OxO84d5[10];if(Ox224){val=OxO84d5[10];} ;Ox221(val);return false;} ;if(Ox223==undefined){Ox223=OxO84d5[10];} ;if(_dialogPromptID==null){var Ox225=document.getElementsByTagName(OxO84d5[151])[0];tnode=document.createElement(OxO84d5[152]);tnode[OxO84d5[48]]=OxO84d5[153];Ox225.appendChild(tnode);_dialogPromptID=document.getElementById(OxO84d5[153]);tnode=document.createElement(OxO84d5[152]);tnode[OxO84d5[48]]=OxO84d5[154];Ox225.appendChild(tnode);_dialogPromptID[OxO84d5[105]][OxO84d5[155]]=OxO84d5[156];_dialogPromptID[OxO84d5[105]][OxO84d5[112]]=OxO84d5[157];_dialogPromptID[OxO84d5[105]][OxO84d5[158]]=OxO84d5[159];_dialogPromptID[OxO84d5[105]][OxO84d5[104]]=OxO84d5[160];_dialogPromptID[OxO84d5[105]][OxO84d5[161]]=OxO84d5[162];} ;var Ox226=OxO84d5[163];Ox226+=OxO84d5[164]+Ox222+OxO84d5[165];Ox226+=OxO84d5[166];Ox226+=OxO84d5[167]+Ox223+OxO84d5[168];Ox226+=OxO84d5[169];Ox226+=OxO84d5[170];Ox226+=OxO84d5[171];Ox226+=OxO84d5[172];Ox226+=OxO84d5[173];_dialogPromptID[OxO84d5[51]]=Ox226;_dialogPromptID[OxO84d5[105]][OxO84d5[0]]=OxO84d5[174];_dialogPromptID[OxO84d5[105]][OxO84d5[175]]=parseInt((document[OxO84d5[151]][OxO84d5[176]]-315)/2)+OxO84d5[177];_dialogPromptID[OxO84d5[105]][OxO84d5[145]]=OxO84d5[178];var Ox227=document.getElementById(OxO84d5[150]);try{var Ox228=Ox227.createTextRange();Ox228.collapse(false);Ox228.select();} catch(x){Ox227.focus();} ;} ;} ;if(CreateDir){CreateDir[OxO84d5[32]]= new Function(OxO84d5[179]);} ;if(Copy){Copy[OxO84d5[32]]= new Function(OxO84d5[179]);} ;if(Move){Move[OxO84d5[32]]= new Function(OxO84d5[179]);} ;if(Delete){Delete[OxO84d5[32]]= new Function(OxO84d5[179]);} ;if(DoRefresh){DoRefresh[OxO84d5[32]]= new Function(OxO84d5[179]);} ;if(btn_zoom_in){btn_zoom_in[OxO84d5[32]]= new Function(OxO84d5[179]);} ;if(btn_zoom_out){btn_zoom_out[OxO84d5[32]]= new Function(OxO84d5[179]);} ;if(btn_Actualsize){btn_Actualsize[OxO84d5[32]]= new Function(OxO84d5[179]);} ;