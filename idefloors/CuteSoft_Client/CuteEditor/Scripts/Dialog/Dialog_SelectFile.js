var OxO4436=["hiddenDirectory","hiddenFile","hiddenAlert","hiddenAction","hiddenActionData","This function is disabled in the demo mode.","disabled","[[Disabled]]","[[SpecifyNewFolderName]]","","value","createdir","[[CopyMoveto]]","/","move","copy","[[AreyouSureDelete]]","parentNode","isdir","true","text",".","[[SpecifyNewFileName]]","rename","True","False",":","path","FoldersAndFiles","TR","length","onmouseover","this.style.backgroundColor=\x27#eeeeee\x27;","onmouseout","this.style.backgroundColor=\x27\x27;","nodeName","INPUT","changedir","url","TargetUrl","htmlcode","onload","getElementsByTagName","table","sortable"," ","className","id","rows","cells","innerHTML","\x3Ca href=\x22#\x22 onclick=\x22ts_resortTable(this);return false;\x22\x3E","\x3Cspan class=\x22sortarrow\x22\x3E\x26nbsp;\x3C/span\x3E\x3C/a\x3E","string","undefined","innerText","childNodes","nodeValue","nodeType","span","cellIndex","TABLE","sortdir","down","\x26uarr;","up","\x26darr;","sortbottom","tBodies","sortarrow","\x26nbsp;","20","19","browse_Frame","Image1","FolderDescription","CreateDir","Copy","Move","Delete","DoRefresh","divpreview","Button1","Button2","btn_zoom_in","btn_zoom_out","btn_Actualsize","editor","window","document","documentElement","documentMode","clientHeight","scrollHeight","width","style","255px","appName","Microsoft Internet Explorer","userAgent","MSIE ([0-9]{1,}[.0-9]{0,})",".jpeg",".jpg",".gif",".png","\x3CIMG src=\x27","\x27\x3E",".bmp","\x26nbsp;\x3Cembed src=\x22","\x22 quality=\x22high\x22 width=\x22200\x22 height=\x22200\x22 type=\x22application/x-shockwave-flash\x22 pluginspage=\x22http://www.macromedia.com/go/getflashplayer\x22\x3E\x3C/embed\x3E\x0A",".swf",".avi",".mpg",".mp3","\x26nbsp;\x3Cembed name=\x22MediaPlayer1\x22 src=\x22","\x22 autostart=-1 showcontrols=-1  type=\x22application/x-mplayer2\x22 width=\x22240\x22 height=\x22200\x22 pluginspage=\x22http://www.microsoft.com/Windows/MediaPlayer\x22 \x3E\x3C/embed\x3E\x0A",".mpeg","inp","zoom","display","none","wrapupPrompt","iepromptfield","body","div","IEPromptBox","promptBlackout","border","1px solid #b0bec7","backgroundColor","#f0f0f0","position","absolute","330px","zIndex","100","\x3Cdiv style=\x22width: 100%; padding-top:3px;background-color: #DCE7EB; font-family: verdana; font-size: 10pt; font-weight: bold; height: 22px; text-align:center; background:url(Load.ashx?type=image\x26file=formbg2.gif) repeat-x left top;\x22\x3E[[InputRequired]]\x3C/div\x3E","\x3Cdiv style=\x22padding: 10px\x22\x3E","\x3CBR\x3E\x3CBR\x3E","\x3Cform action=\x22\x22 onsubmit=\x22return wrapupPrompt()\x22\x3E","\x3Cinput id=\x22iepromptfield\x22 name=\x22iepromptdata\x22 type=text size=46 value=\x22","\x22\x3E","\x3Cbr\x3E\x3Cbr\x3E\x3Ccenter\x3E","\x3Cinput type=\x22submit\x22 value=\x22\x26nbsp;\x26nbsp;\x26nbsp;[[OK]]\x26nbsp;\x26nbsp;\x26nbsp;\x22\x3E","\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;","\x3Cinput type=\x22button\x22 onclick=\x22wrapupPrompt(true)\x22 value=\x22\x26nbsp;[[Cancel]]\x26nbsp;\x22\x3E","\x3C/form\x3E\x3C/div\x3E","top","100px","left","offsetWidth","px","block","CuteEditor_ColorPicker_ButtonOver(this)"];var hiddenDirectory=Window_GetElement(window,OxO4436[0],true);var hiddenFile=Window_GetElement(window,OxO4436[1],true);var hiddenAlert=Window_GetElement(window,OxO4436[2],true);var hiddenAction=Window_GetElement(window,OxO4436[3],true);var hiddenActionData=Window_GetElement(window,OxO4436[4],true);function CreateDir_click(){if(isDemoMode){alert(OxO4436[5]);return false;} ;if(Event_GetSrcElement()[OxO4436[6]]){alert(OxO4436[7]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox221,OxO4436[8],OxO4436[9]);function Ox221(Ox381){if(Ox381){hiddenActionData[OxO4436[10]]=Ox381;hiddenAction[OxO4436[10]]=OxO4436[11];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox381=prompt(OxO4436[8],OxO4436[9]);if(Ox381){hiddenActionData[OxO4436[10]]=Ox381;return true;} else {return false;} ;return false;} ;} ;function Move_click(){if(isDemoMode){alert(OxO4436[5]);return false;} ;if(Event_GetSrcElement()[OxO4436[6]]){alert(OxO4436[7]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox221,OxO4436[12],OxO4436[13]);function Ox221(Ox381){if(Ox381){hiddenActionData[OxO4436[10]]=Ox381;hiddenAction[OxO4436[10]]=OxO4436[14];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox381=prompt(OxO4436[12],OxO4436[13]);if(Ox381){hiddenActionData[OxO4436[10]]=Ox381;return true;} else {return false;} ;return false;} ;} ;function Copy_click(){if(isDemoMode){alert(OxO4436[5]);return false;} ;if(Event_GetSrcElement()[OxO4436[6]]){alert(OxO4436[7]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox221,OxO4436[12],OxO4436[13]);function Ox221(Ox381){if(Ox381){hiddenActionData[OxO4436[10]]=Ox381;hiddenAction[OxO4436[10]]=OxO4436[15];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox381=prompt(OxO4436[12],OxO4436[13]);if(Ox381){hiddenActionData[OxO4436[10]]=Ox381;return true;} else {return false;} ;return false;} ;} ;function Delete_click(){if(isDemoMode){alert(OxO4436[5]);return false;} ;if(Event_GetSrcElement()[OxO4436[6]]){alert(OxO4436[7]);return false;} ;return confirm(OxO4436[16]);} ;function EditImg_click(img){if(isDemoMode){alert(OxO4436[5]);return false;} ;if(img[OxO4436[6]]){alert(OxO4436[7]);return false;} ;var Ox386=img[OxO4436[17]][OxO4436[17]];var Ox388;Ox388=Ox386.getAttribute(OxO4436[18])==OxO4436[19];var Ox387=Ox386.getAttribute(OxO4436[20]);var name;if(Ox388){name=prompt(OxO4436[8],Ox387);} else {var i=Ox387.lastIndexOf(OxO4436[21]);var Oxca=Ox387.substr(i);var Ox12=Ox387.substr(0,Ox387.lastIndexOf(OxO4436[21]));name=prompt(OxO4436[22],Ox12);if(name){name=name+Oxca;} ;} ;if(name&&name!=Ox386.getAttribute(OxO4436[20])){hiddenAction[OxO4436[10]]=OxO4436[23];hiddenActionData[OxO4436[10]]=(Ox388?OxO4436[24]:OxO4436[25])+OxO4436[26]+Ox386.getAttribute(OxO4436[27])+OxO4436[26]+name;window.PostBackAction();} ;return Event_CancelEvent();} ;setMouseOver();function setMouseOver(){var FoldersAndFiles=Window_GetElement(window,OxO4436[28],true);var Ox38b=FoldersAndFiles.getElementsByTagName(OxO4436[29]);for(var i=1;i<Ox38b[OxO4436[30]];i++){var Ox386=Ox38b[i];Ox386[OxO4436[31]]= new Function(OxO4436[9],OxO4436[32]);Ox386[OxO4436[33]]= new Function(OxO4436[9],OxO4436[34]);} ;} ;function row_click(Ox386){var Ox388;Ox388=Ox386.getAttribute(OxO4436[18])==OxO4436[19];if(Ox388){if(Event_GetSrcElement()[OxO4436[35]]==OxO4436[36]){return ;} ;hiddenAction[OxO4436[10]]=OxO4436[37];hiddenActionData[OxO4436[10]]=Ox386.getAttribute(OxO4436[27]);window.PostBackAction();} else {var Ox109=Ox386.getAttribute(OxO4436[27]);hiddenFile[OxO4436[10]]=Ox109;var Ox287=Ox386.getAttribute(OxO4436[38]);Window_GetElement(window,OxO4436[39],true)[OxO4436[10]]=Ox287;var htmlcode=Ox386.getAttribute(OxO4436[40]);if(htmlcode!=OxO4436[9]&&htmlcode!=null){do_preview(htmlcode);} else {try{Actualsize();} catch(x){do_preview();} ;} ;} ;} ;function do_preview(){} ;function reset_hiddens(){if(hiddenAlert[OxO4436[10]]){alert(hiddenAlert.value);} ;hiddenAlert[OxO4436[10]]=OxO4436[9];hiddenAction[OxO4436[10]]=OxO4436[9];hiddenActionData[OxO4436[10]]=OxO4436[9];} ;Event_Attach(window,OxO4436[41],reset_hiddens);Event_Attach(window,OxO4436[41],sortables_init);var SORT_COLUMN_INDEX;function sortables_init(){if(!document[OxO4436[42]]){return ;} ;var Ox390=document.getElementsByTagName(OxO4436[43]);for(var Ox391=0;Ox391<Ox390[OxO4436[30]];Ox391++){var Ox392=Ox390[Ox391];if(((OxO4436[45]+Ox392[OxO4436[46]]+OxO4436[45]).indexOf(OxO4436[44])!=-1)&&(Ox392[OxO4436[47]])){ts_makeSortable(Ox392);} ;} ;} ;function ts_makeSortable(Ox394){if(Ox394[OxO4436[48]]&&Ox394[OxO4436[48]][OxO4436[30]]>0){var Ox395=Ox394[OxO4436[48]][0];} ;if(!Ox395){return ;} ;for(var i=2;i<4;i++){var Ox396=Ox395[OxO4436[49]][i];var Ox219=ts_getInnerText(Ox396);Ox396[OxO4436[50]]=OxO4436[51]+Ox219+OxO4436[52];} ;} ;function ts_getInnerText(Ox29){if( typeof Ox29==OxO4436[53]){return Ox29;} ;if( typeof Ox29==OxO4436[54]){return Ox29;} ;if(Ox29[OxO4436[55]]){return Ox29[OxO4436[55]];} ;var Ox24=OxO4436[9];var Ox342=Ox29[OxO4436[56]];var Ox11=Ox342[OxO4436[30]];for(var i=0;i<Ox11;i++){switch(Ox342[i][OxO4436[58]]){case 1:Ox24+=ts_getInnerText(Ox342[i]);break ;;case 3:Ox24+=Ox342[i][OxO4436[57]];break ;;} ;} ;return Ox24;} ;function ts_resortTable(Ox399){var Ox2a5;for(var Ox39a=0;Ox39a<Ox399[OxO4436[56]][OxO4436[30]];Ox39a++){if(Ox399[OxO4436[56]][Ox39a][OxO4436[35]]&&Ox399[OxO4436[56]][Ox39a][OxO4436[35]].toLowerCase()==OxO4436[59]){Ox2a5=Ox399[OxO4436[56]][Ox39a];} ;} ;var Ox39b=ts_getInnerText(Ox2a5);var Ox1e4=Ox399[OxO4436[17]];var Ox39c=Ox1e4[OxO4436[60]];var Ox394=getParent(Ox1e4,OxO4436[61]);if(Ox394[OxO4436[48]][OxO4436[30]]<=1){return ;} ;var Ox39d=ts_getInnerText(Ox394[OxO4436[48]][1][OxO4436[49]][Ox39c]);var Ox39e=ts_sort_caseinsensitive;if(Ox39d.match(/^\d\d[\/-]\d\d[\/-]\d\d\d\d$/)){Ox39e=ts_sort_date;} ;if(Ox39d.match(/^\d\d[\/-]\d\d[\/-]\d\d$/)){Ox39e=ts_sort_date;} ;if(Ox39d.match(/^[?]/)){Ox39e=ts_sort_currency;} ;if(Ox39d.match(/^[\d\.]+$/)){Ox39e=ts_sort_numeric;} ;SORT_COLUMN_INDEX=Ox39c;var Ox395= new Array();var Ox39f= new Array();for(var i=0;i<Ox394[OxO4436[48]][0][OxO4436[30]];i++){Ox395[i]=Ox394[OxO4436[48]][0][i];} ;for(var Ox25=1;Ox25<Ox394[OxO4436[48]][OxO4436[30]];Ox25++){Ox39f[Ox25-1]=Ox394[OxO4436[48]][Ox25];} ;Ox39f.sort(Ox39e);if(Ox2a5.getAttribute(OxO4436[62])==OxO4436[63]){var Ox3a0=OxO4436[64];Ox39f.reverse();Ox2a5.setAttribute(OxO4436[62],OxO4436[65]);} else {Ox3a0=OxO4436[66];Ox2a5.setAttribute(OxO4436[62],OxO4436[63]);} ;for(i=0;i<Ox39f[OxO4436[30]];i++){if(!Ox39f[i][OxO4436[46]]||(Ox39f[i][OxO4436[46]]&&(Ox39f[i][OxO4436[46]].indexOf(OxO4436[67])==-1))){Ox394[OxO4436[68]][0].appendChild(Ox39f[i]);} ;} ;for(i=0;i<Ox39f[OxO4436[30]];i++){if(Ox39f[i][OxO4436[46]]&&(Ox39f[i][OxO4436[46]].indexOf(OxO4436[67])!=-1)){Ox394[OxO4436[68]][0].appendChild(Ox39f[i]);} ;} ;var Ox3a1=document.getElementsByTagName(OxO4436[59]);for(var Ox39a=0;Ox39a<Ox3a1[OxO4436[30]];Ox39a++){if(Ox3a1[Ox39a][OxO4436[46]]==OxO4436[69]){if(getParent(Ox3a1[Ox39a],OxO4436[43])==getParent(Ox399,OxO4436[43])){Ox3a1[Ox39a][OxO4436[50]]=OxO4436[70];} ;} ;} ;Ox2a5[OxO4436[50]]=Ox3a0;} ;function getParent(Ox29,Ox3a3){if(Ox29==null){return null;} else {if(Ox29[OxO4436[58]]==1&&Ox29[OxO4436[35]].toLowerCase()==Ox3a3.toLowerCase()){return Ox29;} else {return getParent(Ox29.parentNode,Ox3a3);} ;} ;} ;function ts_sort_date(Oxee,b){var Ox3a5=ts_getInnerText(Oxee[OxO4436[49]][SORT_COLUMN_INDEX]);var Ox3a6=ts_getInnerText(b[OxO4436[49]][SORT_COLUMN_INDEX]);if(Ox3a5[OxO4436[30]]==10){var Ox3a7=Ox3a5.substr(6,4)+Ox3a5.substr(3,2)+Ox3a5.substr(0,2);} else {var Ox3a8=Ox3a5.substr(6,2);if(parseInt(Ox3a8)<50){Ox3a8=OxO4436[71]+Ox3a8;} else {Ox3a8=OxO4436[72]+Ox3a8;} ;var Ox3a7=Ox3a8+Ox3a5.substr(3,2)+Ox3a5.substr(0,2);} ;if(Ox3a6[OxO4436[30]]==10){var Ox3a9=Ox3a6.substr(6,4)+Ox3a6.substr(3,2)+Ox3a6.substr(0,2);} else {Ox3a8=Ox3a6.substr(6,2);if(parseInt(Ox3a8)<50){Ox3a8=OxO4436[71]+Ox3a8;} else {Ox3a8=OxO4436[72]+Ox3a8;} ;var Ox3a9=Ox3a8+Ox3a6.substr(3,2)+Ox3a6.substr(0,2);} ;if(Ox3a7==Ox3a9){return 0;} ;if(Ox3a7<Ox3a9){return -1;} ;return 1;} ;function ts_sort_currency(Oxee,b){var Ox3a5=ts_getInnerText(Oxee[OxO4436[49]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxO4436[9]);var Ox3a6=ts_getInnerText(b[OxO4436[49]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxO4436[9]);return parseFloat(Ox3a5)-parseFloat(Ox3a6);} ;function ts_sort_numeric(Oxee,b){var Ox3a5=parseFloat(ts_getInnerText(Oxee[OxO4436[49]][SORT_COLUMN_INDEX]));if(isNaN(Ox3a5)){Ox3a5=0;} ;var Ox3a6=parseFloat(ts_getInnerText(b[OxO4436[49]][SORT_COLUMN_INDEX]));if(isNaN(Ox3a6)){Ox3a6=0;} ;return Ox3a5-Ox3a6;} ;function ts_sort_caseinsensitive(Oxee,b){var Ox3a5=ts_getInnerText(Oxee[OxO4436[49]][SORT_COLUMN_INDEX]).toLowerCase();var Ox3a6=ts_getInnerText(b[OxO4436[49]][SORT_COLUMN_INDEX]).toLowerCase();if(Ox3a5==Ox3a6){return 0;} ;if(Ox3a5<Ox3a6){return -1;} ;return 1;} ;function ts_sort_default(Oxee,b){var Ox3a5=ts_getInnerText(Oxee[OxO4436[49]][SORT_COLUMN_INDEX]);var Ox3a6=ts_getInnerText(b[OxO4436[49]][SORT_COLUMN_INDEX]);if(Ox3a5==Ox3a6){return 0;} ;if(Ox3a5<Ox3a6){return -1;} ;return 1;} ;function RequireFileBrowseScript(){} ;function Actualsize(){} ;RequireFileBrowseScript();var browse_Frame=Window_GetElement(window,OxO4436[73],true);var hiddenDirectory=Window_GetElement(window,OxO4436[0],true);var hiddenFile=Window_GetElement(window,OxO4436[1],true);var hiddenAlert=Window_GetElement(window,OxO4436[2],true);var hiddenAction=Window_GetElement(window,OxO4436[3],true);var hiddenActionData=Window_GetElement(window,OxO4436[4],true);var Image1=Window_GetElement(window,OxO4436[74],true);var FolderDescription=Window_GetElement(window,OxO4436[75],true);var CreateDir=Window_GetElement(window,OxO4436[76],true);var Copy=Window_GetElement(window,OxO4436[77],true);var Move=Window_GetElement(window,OxO4436[78],true);var FoldersAndFiles=Window_GetElement(window,OxO4436[28],true);var Delete=Window_GetElement(window,OxO4436[79],true);var DoRefresh=Window_GetElement(window,OxO4436[80],true);var divpreview=Window_GetElement(window,OxO4436[81],true);var TargetUrl=Window_GetElement(window,OxO4436[39],true);var Button1=Window_GetElement(window,OxO4436[82],true);var Button2=Window_GetElement(window,OxO4436[83],true);var btn_zoom_in=Window_GetElement(window,OxO4436[84],true);var btn_zoom_out=Window_GetElement(window,OxO4436[85],true);var btn_Actualsize=Window_GetElement(window,OxO4436[86],true);var arg=Window_GetDialogArguments(window);var editor=arg[OxO4436[87]];var editwin=arg[OxO4436[88]];var editdoc=arg[OxO4436[89]];var ver=getInternetExplorerVersion();if(ver>-1&&ver<=9.0){var needAdjust=true;if(ver>=8.0&&document[OxO4436[90]]){if(document[OxO4436[91]]>7){needAdjust=false;} ;} ;if(needAdjust&&(browse_Frame[OxO4436[92]]<browse_Frame[OxO4436[93]])){FoldersAndFiles[OxO4436[95]][OxO4436[94]]=OxO4436[96];} ;} ;function getInternetExplorerVersion(){var Ox3c9=-1;if(navigator[OxO4436[97]]==OxO4436[98]){var Ox3ca=navigator[OxO4436[99]];var Ox295= new RegExp(OxO4436[100]);if(Ox295.exec(Ox3ca)!=null){Ox3c9=parseFloat(RegExp.$1);} ;} ;return Ox3c9;} ;do_preview();function do_preview(Ox282){if(Ox282!=OxO4436[9]&&Ox282!=null){htmlcode=Ox282;divpreview[OxO4436[50]]=Ox282;return ;} ;divpreview[OxO4436[50]]=OxO4436[9];var Ox287=TargetUrl[OxO4436[10]];if(Ox287==OxO4436[9]){return ;} ;var Oxca=Ox287.substring(Ox287.lastIndexOf(OxO4436[21])).toLowerCase();switch(Oxca){case OxO4436[101]:;case OxO4436[102]:;case OxO4436[103]:;case OxO4436[104]:;case OxO4436[107]:divpreview[OxO4436[50]]=OxO4436[105]+Ox287+OxO4436[106];break ;;case OxO4436[110]:var Ox3cb=OxO4436[108]+Ox287+OxO4436[109];divpreview[OxO4436[50]]=Ox3cb+OxO4436[70];break ;;case OxO4436[111]:;case OxO4436[112]:;case OxO4436[113]:;case OxO4436[116]:var Ox3cc=OxO4436[114]+Ox287+OxO4436[115];divpreview[OxO4436[50]]=Ox3cc+OxO4436[70];break ;;} ;} ;function do_insert(){var Ox471=arg[OxO4436[117]];if(Ox471){try{Ox471[OxO4436[10]]=TargetUrl[OxO4436[10]];} catch(x){} ;} ;Window_SetDialogReturnValue(window,TargetUrl.value);Window_CloseDialog(window);} ;function do_Close(){Window_SetDialogReturnValue(window,null);Window_CloseDialog(window);} ;function Zoom_In(){if(divpreview[OxO4436[95]][OxO4436[118]]!=0){divpreview[OxO4436[95]][OxO4436[118]]*=1.2;} else {divpreview[OxO4436[95]][OxO4436[118]]=1.2;} ;} ;function Zoom_Out(){if(divpreview[OxO4436[95]][OxO4436[118]]!=0){divpreview[OxO4436[95]][OxO4436[118]]*=0.8;} else {divpreview[OxO4436[95]][OxO4436[118]]=0.8;} ;} ;function Actualsize(){divpreview[OxO4436[95]][OxO4436[118]]=1;do_preview();} ;if(!Browser_IsWinIE()){btn_zoom_in[OxO4436[95]][OxO4436[119]]=btn_zoom_out[OxO4436[95]][OxO4436[119]]=btn_Actualsize[OxO4436[95]][OxO4436[119]]=OxO4436[120];} else {} ;if(Browser_IsIE7()){var _dialogPromptID=null;function IEprompt(Ox221,Ox222,Ox223){that=this;this[OxO4436[121]]=function (Ox224){val=document.getElementById(OxO4436[122])[OxO4436[10]];_dialogPromptID[OxO4436[95]][OxO4436[119]]=OxO4436[120];document.getElementById(OxO4436[122])[OxO4436[10]]=OxO4436[9];if(Ox224){val=OxO4436[9];} ;Ox221(val);return false;} ;if(Ox223==undefined){Ox223=OxO4436[9];} ;if(_dialogPromptID==null){var Ox225=document.getElementsByTagName(OxO4436[123])[0];tnode=document.createElement(OxO4436[124]);tnode[OxO4436[47]]=OxO4436[125];Ox225.appendChild(tnode);_dialogPromptID=document.getElementById(OxO4436[125]);tnode=document.createElement(OxO4436[124]);tnode[OxO4436[47]]=OxO4436[126];Ox225.appendChild(tnode);_dialogPromptID[OxO4436[95]][OxO4436[127]]=OxO4436[128];_dialogPromptID[OxO4436[95]][OxO4436[129]]=OxO4436[130];_dialogPromptID[OxO4436[95]][OxO4436[131]]=OxO4436[132];_dialogPromptID[OxO4436[95]][OxO4436[94]]=OxO4436[133];_dialogPromptID[OxO4436[95]][OxO4436[134]]=OxO4436[135];} ;var Ox226=OxO4436[136];Ox226+=OxO4436[137]+Ox222+OxO4436[138];Ox226+=OxO4436[139];Ox226+=OxO4436[140]+Ox223+OxO4436[141];Ox226+=OxO4436[142];Ox226+=OxO4436[143];Ox226+=OxO4436[144];Ox226+=OxO4436[145];Ox226+=OxO4436[146];_dialogPromptID[OxO4436[50]]=Ox226;_dialogPromptID[OxO4436[95]][OxO4436[147]]=OxO4436[148];_dialogPromptID[OxO4436[95]][OxO4436[149]]=parseInt((document[OxO4436[123]][OxO4436[150]]-315)/2)+OxO4436[151];_dialogPromptID[OxO4436[95]][OxO4436[119]]=OxO4436[152];var Ox227=document.getElementById(OxO4436[122]);try{var Ox228=Ox227.createTextRange();Ox228.collapse(false);Ox228.select();} catch(x){Ox227.focus();} ;} ;} ;if(CreateDir){CreateDir[OxO4436[31]]= new Function(OxO4436[153]);} ;if(Copy){Copy[OxO4436[31]]= new Function(OxO4436[153]);} ;if(Move){Move[OxO4436[31]]= new Function(OxO4436[153]);} ;if(Delete){Delete[OxO4436[31]]= new Function(OxO4436[153]);} ;if(DoRefresh){DoRefresh[OxO4436[31]]= new Function(OxO4436[153]);} ;if(btn_zoom_in){btn_zoom_in[OxO4436[31]]= new Function(OxO4436[153]);} ;if(btn_zoom_out){btn_zoom_out[OxO4436[31]]= new Function(OxO4436[153]);} ;if(btn_Actualsize){btn_Actualsize[OxO4436[31]]= new Function(OxO4436[153]);} ;