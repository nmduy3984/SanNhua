var OxO8074=["hiddenDirectory","hiddenFile","hiddenAlert","hiddenAction","hiddenActionData","This function is disabled in the demo mode.","disabled","[[Disabled]]","[[SpecifyNewFolderName]]","","value","createdir","[[CopyMoveto]]","/","move","copy","[[AreyouSureDelete]]","parentNode","text","isdir","true",".","[[SpecifyNewFileName]]","rename","True","False",":","path","FoldersAndFiles","TR","length","onmouseover","this.style.backgroundColor=\x27#eeeeee\x27;","onmouseout","this.style.backgroundColor=\x27\x27;","nodeName","INPUT","changedir","url","TargetUrl","onload","getElementsByTagName","table","sortable"," ","className","id","rows","cells","innerHTML","\x3Ca href=\x22#\x22 onclick=\x22ts_resortTable(this);return false;\x22\x3E","\x3Cspan class=\x22sortarrow\x22\x3E\x26nbsp;\x3C/span\x3E\x3C/a\x3E","string","undefined","innerText","childNodes","nodeValue","nodeType","span","cellIndex","TABLE","sortdir","down","\x26uarr;","up","\x26darr;","sortbottom","tBodies","sortarrow","\x26nbsp;","20","19","browse_Frame","Image1","FolderDescription","CreateDir","Copy","Move","Delete","DoRefresh","name_Cell","size_Cell","op_Cell","row0","row0_cb","divpreview","Width","Height","bgColortext","bgColortext_Preview","Quality","Scale","Align","HSpace","VSpace","chk_Loop","chk_Autoplay","chk_Transparency","chk_FlashMenu","chk_Fullscreen","btn_zoom_in","btn_zoom_out","btn_Actualsize","documentElement","documentMode","clientHeight","scrollHeight","width","style","235px","appName","Microsoft Internet Explorer","userAgent","MSIE ([0-9]{1,}[.0-9]{0,})","Please choose a Flash movie to insert",".flv","checked","\x26autoPlay=true","[[_CuteEditorResource_]]flashplayer.swf?videoUrl=http://","hostname","location","\x26playerMode=simple","scale=\x27noborder\x27","Noborder","scale=\x27exactfit\x27","Exactfit","hspace=\x22","\x22 ","vspace=\x22","align=\x22","wmode=\x22transparent\x22","allowfullscreen=\x22true\x22","allowfullscreen=\x22false\x22","menu=\x22false\x22","loop=\x22false\x22","play=\x22false\x22","bgcolor=\x22","\x22","\x3Cembed src=\x22","\x22 width=\x22","\x22 height=\x22"," quality=\x22"," type=\x22application/x-shockwave-flash\x22 pluginspage=\x22http://www.macromedia.com/go/getflashplayer\x22 \x3E\x3C/embed\x3E\x0A","\x3Cobject xcodebase=","\x22http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab\x22"," height=\x22"," classid=","\x22clsid:D27CDB6E-AE6D-11cf-96B8-444553540000\x22 \x3E"," \x3Cparam name=\x22Movie\x22 value=\x22","\x22 /\x3E"," \x3Cparam name=\x22Quality\x22 value=\x22","\x22/\x3E","\x3Cparam name=\x22wmode\x22 value=\x22transparent\x22/\x3E","\x3Cparam name=\x22allowFullScreen\x22 value=\x22true\x22/\x3E","\x3Cparam name=\x22allowFullScreen\x22 value=\x22false\x22/\x3E","\x3Cparam name=\x22menu\x22 value=\x22false\x22/\x3E","\x3Cparam name=\x22loop\x22 value=\x22false\x22/\x3E","\x3Cparam name=\x22play\x22 value=\x22false\x22/\x3E","\x3Cparam name=\x22scale\x22 value=\x22","\x3Cparam name=\x22bgcolor\x22 value=\x22","\x3C/object\x3E","zoom","onclick","display","none","wrapupPrompt","iepromptfield","body","div","IEPromptBox","promptBlackout","border","1px solid #b0bec7","backgroundColor","#f0f0f0","position","absolute","330px","zIndex","100","\x3Cdiv style=\x22width: 100%; padding-top:3px;background-color: #DCE7EB; font-family: verdana; font-size: 10pt; font-weight: bold; height: 22px; text-align:center; background:url(Load.ashx?type=image\x26file=formbg2.gif) repeat-x left top;\x22\x3E[[InputRequired]]\x3C/div\x3E","\x3Cdiv style=\x22padding: 10px\x22\x3E","\x3CBR\x3E\x3CBR\x3E","\x3Cform action=\x22\x22 onsubmit=\x22return wrapupPrompt()\x22\x3E","\x3Cinput id=\x22iepromptfield\x22 name=\x22iepromptdata\x22 type=text size=46 value=\x22","\x22\x3E","\x3Cbr\x3E\x3Cbr\x3E\x3Ccenter\x3E","\x3Cinput type=\x22submit\x22 value=\x22\x26nbsp;\x26nbsp;\x26nbsp;[[OK]]\x26nbsp;\x26nbsp;\x26nbsp;\x22\x3E","\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;\x26nbsp;","\x3Cinput type=\x22button\x22 onclick=\x22wrapupPrompt(true)\x22 value=\x22\x26nbsp;[[Cancel]]\x26nbsp;\x22\x3E","\x3C/form\x3E\x3C/div\x3E","top","100px","left","offsetWidth","px","block","CuteEditor_ColorPicker_ButtonOver(this)"];var hiddenDirectory=Window_GetElement(window,OxO8074[0],true);var hiddenFile=Window_GetElement(window,OxO8074[1],true);var hiddenAlert=Window_GetElement(window,OxO8074[2],true);var hiddenAction=Window_GetElement(window,OxO8074[3],true);var hiddenActionData=Window_GetElement(window,OxO8074[4],true);function CreateDir_click(){if(isDemoMode){alert(OxO8074[5]);return false;} ;if(Event_GetSrcElement()[OxO8074[6]]){alert(OxO8074[7]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox221,OxO8074[8],OxO8074[9]);function Ox221(Ox381){if(Ox381){hiddenActionData[OxO8074[10]]=Ox381;hiddenAction[OxO8074[10]]=OxO8074[11];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox381=prompt(OxO8074[8],OxO8074[9]);if(Ox381){hiddenActionData[OxO8074[10]]=Ox381;return true;} else {return false;} ;return false;} ;} ;function Move_click(){if(isDemoMode){alert(OxO8074[5]);return false;} ;if(Event_GetSrcElement()[OxO8074[6]]){alert(OxO8074[7]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox221,OxO8074[12],OxO8074[13]);function Ox221(Ox381){if(Ox381){hiddenActionData[OxO8074[10]]=Ox381;hiddenAction[OxO8074[10]]=OxO8074[14];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox381=prompt(OxO8074[12],OxO8074[13]);if(Ox381){hiddenActionData[OxO8074[10]]=Ox381;return true;} else {return false;} ;return false;} ;} ;function Copy_click(){if(isDemoMode){alert(OxO8074[5]);return false;} ;if(Event_GetSrcElement()[OxO8074[6]]){alert(OxO8074[7]);return false;} ;if(Browser_IsIE7()){IEprompt(Ox221,OxO8074[12],OxO8074[13]);function Ox221(Ox381){if(Ox381){hiddenActionData[OxO8074[10]]=Ox381;hiddenAction[OxO8074[10]]=OxO8074[15];window.PostBackAction();return true;} else {return false;} ;} ;return Event_CancelEvent();} else {var Ox381=prompt(OxO8074[12],OxO8074[13]);if(Ox381){hiddenActionData[OxO8074[10]]=Ox381;return true;} else {return false;} ;return false;} ;} ;function Delete_click(){if(isDemoMode){alert(OxO8074[5]);return false;} ;if(Event_GetSrcElement()[OxO8074[6]]){alert(OxO8074[7]);return false;} ;return confirm(OxO8074[16]);} ;function EditImg_click(img){if(isDemoMode){alert(OxO8074[5]);return false;} ;if(img[OxO8074[6]]){alert(OxO8074[7]);return false;} ;var Ox386=img[OxO8074[17]][OxO8074[17]];var Ox387=Ox386.getAttribute(OxO8074[18]);var name;var Ox388;Ox388=Ox386.getAttribute(OxO8074[19])==OxO8074[20];if(Browser_IsIE7()){var Oxca;if(Ox388){IEprompt(Ox221,OxO8074[8],Ox387);} else {var i=Ox387.lastIndexOf(OxO8074[21]);Oxca=Ox387.substr(i);var Ox12=Ox387.substr(0,Ox387.lastIndexOf(OxO8074[21]));IEprompt(Ox221,OxO8074[22],Ox12);} ;function Ox221(Ox381){if(Ox381&&Ox381!=Ox386.getAttribute(OxO8074[18])){if(!Ox388){Ox381=Ox381+Oxca;} ;hiddenAction[OxO8074[10]]=OxO8074[23];hiddenActionData[OxO8074[10]]=(Ox388?OxO8074[24]:OxO8074[25])+OxO8074[26]+Ox386.getAttribute(OxO8074[27])+OxO8074[26]+Ox381;window.PostBackAction();} ;} ;} else {if(Ox388){name=prompt(OxO8074[8],Ox387);} else {var i=Ox387.lastIndexOf(OxO8074[21]);var Oxca=Ox387.substr(i);var Ox12=Ox387.substr(0,Ox387.lastIndexOf(OxO8074[21]));name=prompt(OxO8074[22],Ox12);if(name){name=name+Oxca;} ;} ;if(name&&name!=Ox386.getAttribute(OxO8074[18])){hiddenAction[OxO8074[10]]=OxO8074[23];hiddenActionData[OxO8074[10]]=(Ox388?OxO8074[24]:OxO8074[25])+OxO8074[26]+Ox386.getAttribute(OxO8074[27])+OxO8074[26]+name;window.PostBackAction();} ;} ;return Event_CancelEvent();} ;setMouseOver();function setMouseOver(){var FoldersAndFiles=Window_GetElement(window,OxO8074[28],true);var Ox38b=FoldersAndFiles.getElementsByTagName(OxO8074[29]);for(var i=1;i<Ox38b[OxO8074[30]];i++){var Ox386=Ox38b[i];Ox386[OxO8074[31]]= new Function(OxO8074[9],OxO8074[32]);Ox386[OxO8074[33]]= new Function(OxO8074[9],OxO8074[34]);} ;} ;function row_click(Ox386){var Ox388;Ox388=Ox386.getAttribute(OxO8074[19])==OxO8074[20];if(Ox388){if(Event_GetSrcElement()[OxO8074[35]]==OxO8074[36]){return ;} ;hiddenAction[OxO8074[10]]=OxO8074[37];hiddenActionData[OxO8074[10]]=Ox386.getAttribute(OxO8074[27]);window.PostBackAction();} else {var Ox109=Ox386.getAttribute(OxO8074[27]);hiddenFile[OxO8074[10]]=Ox109;var Ox287=Ox386.getAttribute(OxO8074[38]);Window_GetElement(window,OxO8074[39],true)[OxO8074[10]]=Ox287;Actualsize();} ;} ;function reset_hiddens(){if(hiddenAlert[OxO8074[10]]){alert(hiddenAlert.value);} ;hiddenAlert[OxO8074[10]]=OxO8074[9];hiddenAction[OxO8074[10]]=OxO8074[9];hiddenActionData[OxO8074[10]]=OxO8074[9];} ;Event_Attach(window,OxO8074[40],reset_hiddens);function RequireFileBrowseScript(){} ;Event_Attach(window,OxO8074[40],sortables_init);var SORT_COLUMN_INDEX;function sortables_init(){if(!document[OxO8074[41]]){return ;} ;var Ox390=document.getElementsByTagName(OxO8074[42]);for(var Ox391=0;Ox391<Ox390[OxO8074[30]];Ox391++){var Ox392=Ox390[Ox391];if(((OxO8074[44]+Ox392[OxO8074[45]]+OxO8074[44]).indexOf(OxO8074[43])!=-1)&&(Ox392[OxO8074[46]])){ts_makeSortable(Ox392);} ;} ;} ;function ts_makeSortable(Ox394){if(Ox394[OxO8074[47]]&&Ox394[OxO8074[47]][OxO8074[30]]>0){var Ox395=Ox394[OxO8074[47]][0];} ;if(!Ox395){return ;} ;for(var i=2;i<4;i++){var Ox396=Ox395[OxO8074[48]][i];var Ox219=ts_getInnerText(Ox396);Ox396[OxO8074[49]]=OxO8074[50]+Ox219+OxO8074[51];} ;} ;function ts_getInnerText(Ox29){if( typeof Ox29==OxO8074[52]){return Ox29;} ;if( typeof Ox29==OxO8074[53]){return Ox29;} ;if(Ox29[OxO8074[54]]){return Ox29[OxO8074[54]];} ;var Ox24=OxO8074[9];var Ox342=Ox29[OxO8074[55]];var Ox11=Ox342[OxO8074[30]];for(var i=0;i<Ox11;i++){switch(Ox342[i][OxO8074[57]]){case 1:Ox24+=ts_getInnerText(Ox342[i]);break ;;case 3:Ox24+=Ox342[i][OxO8074[56]];break ;;} ;} ;return Ox24;} ;function ts_resortTable(Ox399){var Ox2a5;for(var Ox39a=0;Ox39a<Ox399[OxO8074[55]][OxO8074[30]];Ox39a++){if(Ox399[OxO8074[55]][Ox39a][OxO8074[35]]&&Ox399[OxO8074[55]][Ox39a][OxO8074[35]].toLowerCase()==OxO8074[58]){Ox2a5=Ox399[OxO8074[55]][Ox39a];} ;} ;var Ox39b=ts_getInnerText(Ox2a5);var Ox1e4=Ox399[OxO8074[17]];var Ox39c=Ox1e4[OxO8074[59]];var Ox394=getParent(Ox1e4,OxO8074[60]);if(Ox394[OxO8074[47]][OxO8074[30]]<=1){return ;} ;var Ox39d=ts_getInnerText(Ox394[OxO8074[47]][1][OxO8074[48]][Ox39c]);var Ox39e=ts_sort_caseinsensitive;if(Ox39d.match(/^\d\d[\/-]\d\d[\/-]\d\d\d\d$/)){Ox39e=ts_sort_date;} ;if(Ox39d.match(/^\d\d[\/-]\d\d[\/-]\d\d$/)){Ox39e=ts_sort_date;} ;if(Ox39d.match(/^[?]/)){Ox39e=ts_sort_currency;} ;if(Ox39d.match(/^[\d\.]+$/)){Ox39e=ts_sort_numeric;} ;SORT_COLUMN_INDEX=Ox39c;var Ox395= new Array();var Ox39f= new Array();for(var i=0;i<Ox394[OxO8074[47]][0][OxO8074[30]];i++){Ox395[i]=Ox394[OxO8074[47]][0][i];} ;for(var Ox25=1;Ox25<Ox394[OxO8074[47]][OxO8074[30]];Ox25++){Ox39f[Ox25-1]=Ox394[OxO8074[47]][Ox25];} ;Ox39f.sort(Ox39e);if(Ox2a5.getAttribute(OxO8074[61])==OxO8074[62]){var Ox3a0=OxO8074[63];Ox39f.reverse();Ox2a5.setAttribute(OxO8074[61],OxO8074[64]);} else {Ox3a0=OxO8074[65];Ox2a5.setAttribute(OxO8074[61],OxO8074[62]);} ;for(i=0;i<Ox39f[OxO8074[30]];i++){if(!Ox39f[i][OxO8074[45]]||(Ox39f[i][OxO8074[45]]&&(Ox39f[i][OxO8074[45]].indexOf(OxO8074[66])==-1))){Ox394[OxO8074[67]][0].appendChild(Ox39f[i]);} ;} ;for(i=0;i<Ox39f[OxO8074[30]];i++){if(Ox39f[i][OxO8074[45]]&&(Ox39f[i][OxO8074[45]].indexOf(OxO8074[66])!=-1)){Ox394[OxO8074[67]][0].appendChild(Ox39f[i]);} ;} ;var Ox3a1=document.getElementsByTagName(OxO8074[58]);for(var Ox39a=0;Ox39a<Ox3a1[OxO8074[30]];Ox39a++){if(Ox3a1[Ox39a][OxO8074[45]]==OxO8074[68]){if(getParent(Ox3a1[Ox39a],OxO8074[42])==getParent(Ox399,OxO8074[42])){Ox3a1[Ox39a][OxO8074[49]]=OxO8074[69];} ;} ;} ;Ox2a5[OxO8074[49]]=Ox3a0;} ;function getParent(Ox29,Ox3a3){if(Ox29==null){return null;} else {if(Ox29[OxO8074[57]]==1&&Ox29[OxO8074[35]].toLowerCase()==Ox3a3.toLowerCase()){return Ox29;} else {return getParent(Ox29.parentNode,Ox3a3);} ;} ;} ;function ts_sort_date(Oxee,b){var Ox3a5=ts_getInnerText(Oxee[OxO8074[48]][SORT_COLUMN_INDEX]);var Ox3a6=ts_getInnerText(b[OxO8074[48]][SORT_COLUMN_INDEX]);if(Ox3a5[OxO8074[30]]==10){var Ox3a7=Ox3a5.substr(6,4)+Ox3a5.substr(3,2)+Ox3a5.substr(0,2);} else {var Ox3a8=Ox3a5.substr(6,2);if(parseInt(Ox3a8)<50){Ox3a8=OxO8074[70]+Ox3a8;} else {Ox3a8=OxO8074[71]+Ox3a8;} ;var Ox3a7=Ox3a8+Ox3a5.substr(3,2)+Ox3a5.substr(0,2);} ;if(Ox3a6[OxO8074[30]]==10){var Ox3a9=Ox3a6.substr(6,4)+Ox3a6.substr(3,2)+Ox3a6.substr(0,2);} else {Ox3a8=Ox3a6.substr(6,2);if(parseInt(Ox3a8)<50){Ox3a8=OxO8074[70]+Ox3a8;} else {Ox3a8=OxO8074[71]+Ox3a8;} ;var Ox3a9=Ox3a8+Ox3a6.substr(3,2)+Ox3a6.substr(0,2);} ;if(Ox3a7==Ox3a9){return 0;} ;if(Ox3a7<Ox3a9){return -1;} ;return 1;} ;function ts_sort_currency(Oxee,b){var Ox3a5=ts_getInnerText(Oxee[OxO8074[48]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxO8074[9]);var Ox3a6=ts_getInnerText(b[OxO8074[48]][SORT_COLUMN_INDEX]).replace(/[^0-9.]/g,OxO8074[9]);return parseFloat(Ox3a5)-parseFloat(Ox3a6);} ;function ts_sort_numeric(Oxee,b){var Ox3a5=parseFloat(ts_getInnerText(Oxee[OxO8074[48]][SORT_COLUMN_INDEX]));if(isNaN(Ox3a5)){Ox3a5=0;} ;var Ox3a6=parseFloat(ts_getInnerText(b[OxO8074[48]][SORT_COLUMN_INDEX]));if(isNaN(Ox3a6)){Ox3a6=0;} ;return Ox3a5-Ox3a6;} ;function ts_sort_caseinsensitive(Oxee,b){var Ox3a5=ts_getInnerText(Oxee[OxO8074[48]][SORT_COLUMN_INDEX]).toLowerCase();var Ox3a6=ts_getInnerText(b[OxO8074[48]][SORT_COLUMN_INDEX]).toLowerCase();if(Ox3a5==Ox3a6){return 0;} ;if(Ox3a5<Ox3a6){return -1;} ;return 1;} ;function ts_sort_default(Oxee,b){var Ox3a5=ts_getInnerText(Oxee[OxO8074[48]][SORT_COLUMN_INDEX]);var Ox3a6=ts_getInnerText(b[OxO8074[48]][SORT_COLUMN_INDEX]);if(Ox3a5==Ox3a6){return 0;} ;if(Ox3a5<Ox3a6){return -1;} ;return 1;} [sortables_init];RequireFileBrowseScript();var browse_Frame=Window_GetElement(window,OxO8074[72],true);var hiddenDirectory=Window_GetElement(window,OxO8074[0],true);var hiddenFile=Window_GetElement(window,OxO8074[1],true);var hiddenAlert=Window_GetElement(window,OxO8074[2],true);var hiddenAction=Window_GetElement(window,OxO8074[3],true);var hiddenActionData=Window_GetElement(window,OxO8074[4],true);var Image1=Window_GetElement(window,OxO8074[73],true);var FolderDescription=Window_GetElement(window,OxO8074[74],true);var CreateDir=Window_GetElement(window,OxO8074[75],true);var Copy=Window_GetElement(window,OxO8074[76],true);var Move=Window_GetElement(window,OxO8074[77],true);var FoldersAndFiles=Window_GetElement(window,OxO8074[28],true);var Delete=Window_GetElement(window,OxO8074[78],true);var DoRefresh=Window_GetElement(window,OxO8074[79],true);var name_Cell=Window_GetElement(window,OxO8074[80],true);var size_Cell=Window_GetElement(window,OxO8074[81],true);var op_Cell=Window_GetElement(window,OxO8074[82],true);var row0=Window_GetElement(window,OxO8074[83],true);var row0_cb=Window_GetElement(window,OxO8074[84],true);var divpreview=Window_GetElement(window,OxO8074[85],true);var Width=Window_GetElement(window,OxO8074[86],true);var Height=Window_GetElement(window,OxO8074[87],true);var bgColortext=Window_GetElement(window,OxO8074[88],true);var bgColortext_Preview=Window_GetElement(window,OxO8074[89],true);var Quality=Window_GetElement(window,OxO8074[90],true);var Scale=Window_GetElement(window,OxO8074[91],true);var Align=Window_GetElement(window,OxO8074[92],true);var HSpace=Window_GetElement(window,OxO8074[93],true);var VSpace=Window_GetElement(window,OxO8074[94],true);var TargetUrl=Window_GetElement(window,OxO8074[39],true);var chk_Loop=Window_GetElement(window,OxO8074[95],true);var chk_Autoplay=Window_GetElement(window,OxO8074[96],true);var chk_Transparency=Window_GetElement(window,OxO8074[97],true);var chk_FlashMenu=Window_GetElement(window,OxO8074[98],true);var chk_Fullscreen=Window_GetElement(window,OxO8074[99],true);var btn_zoom_in=Window_GetElement(window,OxO8074[100],true);var btn_zoom_out=Window_GetElement(window,OxO8074[101],true);var btn_Actualsize=Window_GetElement(window,OxO8074[102],true);var editor=Window_GetDialogArguments(window);var ver=getInternetExplorerVersion();if(ver>-1&&ver<=9.0){var needAdjust=true;if(ver>=8.0&&document[OxO8074[103]]){if(document[OxO8074[104]]>7){needAdjust=false;} ;} ;if(needAdjust&&(browse_Frame[OxO8074[105]]<browse_Frame[OxO8074[106]])){FoldersAndFiles[OxO8074[108]][OxO8074[107]]=OxO8074[109];} ;} ;function getInternetExplorerVersion(){var Ox3c9=-1;if(navigator[OxO8074[110]]==OxO8074[111]){var Ox3ca=navigator[OxO8074[112]];var Ox295= new RegExp(OxO8074[113]);if(Ox295.exec(Ox3ca)!=null){Ox3c9=parseFloat(RegExp.$1);} ;} ;return Ox3c9;} ;do_preview();function do_preview(){var Ox120=GetEmbed();if(Ox120){divpreview[OxO8074[49]]=Ox120;} ;} ;function do_insert(){if(TargetUrl[OxO8074[10]]==OxO8074[9]){alert(OxO8074[114]);return false;} ;var Ox120=GetEmbed();if(Ox120){editor.PasteHTML(Ox120);} ;Window_CloseDialog(window);} ;function GetEmbed(){var Oxe1,Ox2d,Ox3e3,Ox3e4,Ox3e5,Ox287;Oxe1=Width[OxO8074[10]]+OxO8074[9];Ox2d=Height[OxO8074[10]]+OxO8074[9];Ox3e3=chk_Transparency[OxO8074[10]];Ox3e5=Quality[OxO8074[10]];Ox287=TargetUrl[OxO8074[10]];if(Ox287==OxO8074[9]){return OxO8074[9];} ;if(Ox287.indexOf(OxO8074[115])!=-1){var Ox3e6=chk_Autoplay[OxO8074[116]]?OxO8074[117]:OxO8074[9];Ox287=OxO8074[118]+window[OxO8074[120]][OxO8074[119]]+Ox287+OxO8074[121]+Ox3e6;} ;var Ox3e7,Ox3e8,Ox3e9,Ox3ea,Ox3eb,Ox3ec,Ox3ed,Ox3ee;switch(Scale[OxO8074[10]]){case OxO8074[123]:Ox3ed=OxO8074[122];break ;;case OxO8074[125]:Ox3ed=OxO8074[124];break ;;case OxO8074[9]:Ox3ed=OxO8074[9];break ;;} ;Ox3ee=OxO8074[9];if(HSpace[OxO8074[10]]){Ox3ee=Ox3ee+OxO8074[126]+HSpace[OxO8074[10]]+OxO8074[127];} ;if(VSpace[OxO8074[10]]){Ox3ee=Ox3ee+OxO8074[128]+VSpace[OxO8074[10]]+OxO8074[127];} ;if(Align[OxO8074[10]]){Ox3ee=Ox3ee+OxO8074[129]+Align[OxO8074[10]]+OxO8074[127];} ;Ox3e7=chk_Transparency[OxO8074[116]]?OxO8074[130]:OxO8074[9];Ox3e9=chk_Fullscreen[OxO8074[116]]?OxO8074[131]:OxO8074[132];Ox3e8=chk_FlashMenu[OxO8074[116]]?OxO8074[9]:OxO8074[133];Ox3ea=chk_Loop[OxO8074[116]]?OxO8074[9]:OxO8074[134];Ox3eb=chk_Autoplay[OxO8074[116]]?OxO8074[9]:OxO8074[135];Ox3ec=bgColortext[OxO8074[10]]==OxO8074[9]?OxO8074[9]:OxO8074[136]+bgColortext[OxO8074[10]]+OxO8074[137];var Ox3ef=OxO8074[138]+Ox287+OxO8074[139]+Oxe1+OxO8074[140]+Ox2d+OxO8074[127]+Ox3ee+OxO8074[141]+Ox3e5+OxO8074[127]+Ox3e7+OxO8074[44]+Ox3ea+OxO8074[44]+Ox3e8+OxO8074[44]+Ox3e9+OxO8074[44]+Ox3eb+OxO8074[44]+Ox3ec+OxO8074[44]+Ox3ed+OxO8074[142];var Ox3f0=OxO8074[143]+OxO8074[144]+OxO8074[145]+Ox2d+OxO8074[139]+Oxe1+OxO8074[127]+Ox3ee+OxO8074[146]+OxO8074[147]+OxO8074[148]+Ox287+OxO8074[149]+OxO8074[150]+Ox3e5+OxO8074[151];if(chk_Transparency[OxO8074[116]]){Ox3f0=Ox3f0+OxO8074[152];} ;if(chk_Fullscreen[OxO8074[116]]){Ox3f0=Ox3f0+OxO8074[153];} else {Ox3f0=Ox3f0+OxO8074[154];} ;if(!chk_FlashMenu[OxO8074[116]]){Ox3f0=Ox3f0+OxO8074[155];} ;if(!chk_Loop[OxO8074[116]]){Ox3f0=Ox3f0+OxO8074[156];} ;if(!chk_Autoplay[OxO8074[116]]){Ox3f0=Ox3f0+OxO8074[157];} ;if(Scale[OxO8074[10]]!=OxO8074[9]){Ox3f0=Ox3f0+OxO8074[158]+Scale[OxO8074[10]]+OxO8074[151];} ;if(bgColortext[OxO8074[10]]!=OxO8074[9]){Ox3f0=Ox3f0+OxO8074[159]+bgColortext[OxO8074[10]]+OxO8074[151];} ;Ox3f0=Ox3f0+Ox3ef+OxO8074[160];return Ox3f0;} ;function do_Close(){Window_CloseDialog(window);} ;divpreview[OxO8074[108]][OxO8074[161]]=1;function Zoom_In(){if(Browser_IsWinIE()){if(divpreview[OxO8074[108]][OxO8074[161]]!=0){divpreview[OxO8074[108]][OxO8074[161]]*=1.2;} else {divpreview[OxO8074[108]][OxO8074[161]]=1.2;} ;} ;} ;function Zoom_Out(){if(Browser_IsWinIE()){if(divpreview[OxO8074[108]][OxO8074[161]]!=0){divpreview[OxO8074[108]][OxO8074[161]]*=0.8;} else {divpreview[OxO8074[108]][OxO8074[161]]=0.8;} ;} ;} ;function Actualsize(){if(Browser_IsWinIE()){divpreview[OxO8074[108]][OxO8074[161]]=1;} ;do_preview();} ;bgColortext[OxO8074[162]]=bgColortext_Preview[OxO8074[162]]=function bgColortext_onclick(){SelectColor(bgColortext,bgColortext_Preview);} ;btn_zoom_in[OxO8074[108]][OxO8074[163]]=btn_zoom_out[OxO8074[108]][OxO8074[163]]=btn_Actualsize[OxO8074[108]][OxO8074[163]]=OxO8074[164];if(Browser_IsIE7()){var _dialogPromptID=null;function IEprompt(Ox221,Ox222,Ox223){that=this;this[OxO8074[165]]=function (Ox224){val=document.getElementById(OxO8074[166])[OxO8074[10]];_dialogPromptID[OxO8074[108]][OxO8074[163]]=OxO8074[164];document.getElementById(OxO8074[166])[OxO8074[10]]=OxO8074[9];if(Ox224){val=OxO8074[9];} ;Ox221(val);return false;} ;if(Ox223==undefined){Ox223=OxO8074[9];} ;if(_dialogPromptID==null){var Ox225=document.getElementsByTagName(OxO8074[167])[0];tnode=document.createElement(OxO8074[168]);tnode[OxO8074[46]]=OxO8074[169];Ox225.appendChild(tnode);_dialogPromptID=document.getElementById(OxO8074[169]);tnode=document.createElement(OxO8074[168]);tnode[OxO8074[46]]=OxO8074[170];Ox225.appendChild(tnode);_dialogPromptID[OxO8074[108]][OxO8074[171]]=OxO8074[172];_dialogPromptID[OxO8074[108]][OxO8074[173]]=OxO8074[174];_dialogPromptID[OxO8074[108]][OxO8074[175]]=OxO8074[176];_dialogPromptID[OxO8074[108]][OxO8074[107]]=OxO8074[177];_dialogPromptID[OxO8074[108]][OxO8074[178]]=OxO8074[179];} ;var Ox226=OxO8074[180];Ox226+=OxO8074[181]+Ox222+OxO8074[182];Ox226+=OxO8074[183];Ox226+=OxO8074[184]+Ox223+OxO8074[185];Ox226+=OxO8074[186];Ox226+=OxO8074[187];Ox226+=OxO8074[188];Ox226+=OxO8074[189];Ox226+=OxO8074[190];_dialogPromptID[OxO8074[49]]=Ox226;_dialogPromptID[OxO8074[108]][OxO8074[191]]=OxO8074[192];_dialogPromptID[OxO8074[108]][OxO8074[193]]=parseInt((document[OxO8074[167]][OxO8074[194]]-315)/2)+OxO8074[195];_dialogPromptID[OxO8074[108]][OxO8074[163]]=OxO8074[196];var Ox227=document.getElementById(OxO8074[166]);try{var Ox228=Ox227.createTextRange();Ox228.collapse(false);Ox228.select();} catch(x){Ox227.focus();} ;} ;} ;if(CreateDir){CreateDir[OxO8074[31]]= new Function(OxO8074[197]);} ;if(Copy){Copy[OxO8074[31]]= new Function(OxO8074[197]);} ;if(Move){Move[OxO8074[31]]= new Function(OxO8074[197]);} ;if(Delete){Delete[OxO8074[31]]= new Function(OxO8074[197]);} ;if(DoRefresh){DoRefresh[OxO8074[31]]= new Function(OxO8074[197]);} ;if(btn_zoom_in){btn_zoom_in[OxO8074[31]]= new Function(OxO8074[197]);} ;if(btn_zoom_out){btn_zoom_out[OxO8074[31]]= new Function(OxO8074[197]);} ;if(btn_Actualsize){btn_Actualsize[OxO8074[31]]= new Function(OxO8074[197]);} ;