var OxO9e72=["ua","userAgent","isOpera","opera","isSafari","safari","isGecko","gecko","isWinIE","msie","compatMode","document","CSS1Compat","undefined","Microsoft.XMLHTTP","readyState","onreadystatechange","","length","all","childNodes","nodeType","\x0D\x0A","caller","onchange","oninitialized","command","commandui","commandvalue","returnValue","oncommand","string","_fireEventFunction","event","parentNode","_IsCuteEditor","True","value","arguments","target","nodeName","SELECT","OPTION","readOnly","_IsRichDropDown","null","selectedIndex","TR","cells","display","style","nextSibling","innerHTML","\x3Cimg src=\x22","/Load.ashx?type=image\x26file=t-minus.gif\x22\x3E","onclick","CuteEditor_CollapseTreeDropDownItem(this,\x22","\x22)","none","/Load.ashx?type=image\x26file=t-plus.gif\x22\x3E","CuteEditor_ExpandTreeDropDownItem(this,\x22","contains","UNSELECTABLE","on","tabIndex","-1","//TODO: event not found? throw error ?","contentWindow","contentDocument","parentWindow","id","frames","frameElement","//TODO:frame contentWindow not found?","preventDefault","parent","top","opener","head","script","language","javascript","type","text/javascript","src","srcElement","//TODO: srcElement not found? throw error ?","fromElement","relatedTarget","toElement","keyCode","clientX","clientY","offsetX","offsetY","button","ctrlKey","altKey","shiftKey","cancelBubble","stopPropagation","CuteEditor_GetEditor(this).ExecImageCommand(this.getAttribute(\x27Command\x27),this.getAttribute(\x27CommandUI\x27),this.getAttribute(\x27CommandArgument\x27),this)","CuteEditor_GetEditor(this).PostBack(this.getAttribute(\x27Command\x27))","this.onmouseout();CuteEditor_GetEditor(this).DropMenu(this.getAttribute(\x27Group\x27),this)","ResourceDir","Theme","/Load.ashx?type=theme\x26theme=","\x26file=all.png","/Images/blank2020.gif","IMG","alt","title","Command","Group","ThemeIndex","width","20px","height","backgroundImage","url(",")","backgroundPosition","0 -","px","onload","className","separator","CuteEditorButton","onmouseover","CuteEditor_ButtonCommandOver(this)","onmouseout","CuteEditor_ButtonCommandOut(this)","onmousedown","CuteEditor_ButtonCommandDown(this)","onmouseup","CuteEditor_ButtonCommandUp(this)","oncontextmenu","ondragstart","PostBack","ondblclick","_ToolBarID","_CodeViewToolBarID","_FrameID"," CuteEditorFrame"," CuteEditorToolbar","cursor","no-drop","ActiveTab","Edit","Code","View","buttonInitialized","isover","CuteEditorButtonOver","CuteEditorButtonDown","CuteEditorDown","border","solid 1px #0A246A","backgroundColor","#b6bdd2","padding","1px","solid 1px #f5f5f4","inset 1px","IsCommandDisabled","CuteEditorButtonDisabled","IsCommandActive","CuteEditorButtonActive","cmd_fromfullpage","(","href","location",",DanaInfo=",",","+","scriptProperties","initfuncbecalled","GetScriptProperty","/Load.ashx?type=scripts\x26file=Gecko_Implementation\x26culture=","Culture","CuteEditorImplementation","function","POST","\x26getModified=1\x26_temp=","status","responseText","GET","\x26modified=","body","block","contentEditable","InitializeCode","inittime","CuteEditorInitialize"];var _Browser_TypeInfo=null;function Browser__InitType(){if(_Browser_TypeInfo!=null){return ;} ;var Ox4={};Ox4[OxO9e72[0]]=navigator[OxO9e72[1]].toLowerCase();Ox4[OxO9e72[2]]=(Ox4[OxO9e72[0]].indexOf(OxO9e72[3])>-1);Ox4[OxO9e72[4]]=(Ox4[OxO9e72[0]].indexOf(OxO9e72[5])>-1);Ox4[OxO9e72[6]]=(!Ox4[OxO9e72[2]]&&Ox4[OxO9e72[0]].indexOf(OxO9e72[7])>-1);Ox4[OxO9e72[8]]=(!Ox4[OxO9e72[2]]&&Ox4[OxO9e72[0]].indexOf(OxO9e72[9])>-1);_Browser_TypeInfo=Ox4;} ;Browser__InitType();function Browser_IsWinIE(){return _Browser_TypeInfo[OxO9e72[8]];} ;function Browser_IsGecko(){return _Browser_TypeInfo[OxO9e72[6]];} ;function Browser_IsOpera(){return _Browser_TypeInfo[OxO9e72[2]];} ;function Browser_IsSafari(){return _Browser_TypeInfo[OxO9e72[4]];} ;function Browser_UseIESelection(){return _Browser_TypeInfo[OxO9e72[8]];} ;function Browser_IsCSS1Compat(){return window[OxO9e72[11]][OxO9e72[10]]==OxO9e72[12];} ;function CreateXMLHttpRequest(){try{if( typeof (XMLHttpRequest)!=OxO9e72[13]){return  new XMLHttpRequest();} ;if( typeof (ActiveXObject)!=OxO9e72[13]){return  new ActiveXObject(OxO9e72[14]);} ;} catch(x){return null;} ;} ;function LoadXMLAsync(Oxa5c,Ox288,Ox235,Oxa5d){var Oxe7=CreateXMLHttpRequest();function Oxa5e(){if(Oxe7[OxO9e72[15]]!=4){return ;} ;Oxe7[OxO9e72[16]]= new Function();var Ox290=Oxe7;Oxe7=null;if(Ox235){Ox235(Ox290);} ;} ;Oxe7[OxO9e72[16]]=Oxa5e;Oxe7.open(Oxa5c,Ox288,true);Oxe7.send(Oxa5d||OxO9e72[17]);} ;function Element_GetAllElements(p){var arr=[];if(Browser_IsWinIE()){for(var i=0;i<p[OxO9e72[19]][OxO9e72[18]];i++){arr.push(p[OxO9e72[19]].item(i));} ;return arr;} ;Ox242(p);function Ox242(Ox29){var Ox217=Ox29[OxO9e72[20]];var Ox11=Ox217[OxO9e72[18]];for(var i=0;i<Ox11;i++){var Ox27=Ox217.item(i);if(Ox27[OxO9e72[21]]!=1){continue ;} ;arr.push(Ox27);Ox242(Ox27);} ;} ;return arr;} ;var __ISDEBUG=false;function Debug_Todo(msg){if(!__ISDEBUG){return ;} ;throw ( new Error(msg+OxO9e72[22]+Debug_Todo[OxO9e72[23]]));} ;function Window_GetElement(Ox1a8,Ox9a,Ox240){var Ox29=Ox1a8[OxO9e72[11]].getElementById(Ox9a);if(Ox29){return Ox29;} ;var Ox31=Ox1a8[OxO9e72[11]].getElementsByName(Ox9a);if(Ox31[OxO9e72[18]]>0){return Ox31.item(0);} ;return null;} ;function CuteEditor_AddMainMenuItems(Ox66a){} ;function CuteEditor_AddDropMenuItems(Ox66a,Ox671){} ;function CuteEditor_AddTagMenuItems(Ox66a,Ox673){} ;function CuteEditor_AddVerbMenuItems(Ox66a,Ox673){} ;function CuteEditor_OnInitialized(editor){} ;function CuteEditor_OnCommand(editor,Ox4d,Ox4e,Ox4f){} ;function CuteEditor_OnChange(editor){} ;function CuteEditor_FilterCode(editor,Ox26b){return Ox26b;} ;function CuteEditor_FilterHTML(editor,Ox283){return Ox283;} ;function CuteEditor_FireChange(editor){window.CuteEditor_OnChange(editor);CuteEditor_FireEvent(editor,OxO9e72[24],null);} ;function CuteEditor_FireInitialized(editor){window.CuteEditor_OnInitialized(editor);CuteEditor_FireEvent(editor,OxO9e72[25],null);} ;function CuteEditor_FireCommand(editor,Ox4d,Ox4e,Ox4f){var Ox13e=window.CuteEditor_OnCommand(editor,Ox4d,Ox4e,Ox4f);if(Ox13e==true){return true;} ;var Ox67c={};Ox67c[OxO9e72[26]]=Ox4d;Ox67c[OxO9e72[27]]=Ox4e;Ox67c[OxO9e72[28]]=Ox4f;Ox67c[OxO9e72[29]]=true;CuteEditor_FireEvent(editor,OxO9e72[30],Ox67c);if(Ox67c[OxO9e72[29]]==false){return true;} ;} ;function CuteEditor_FireEvent(editor,Ox67e,Ox67f){if(Ox67f==null){Ox67f={};} ;var Ox680=editor.getAttribute(Ox67e);if(Ox680){if( typeof (Ox680)==OxO9e72[31]){editor[OxO9e72[32]]= new Function(OxO9e72[33],Ox680);} else {editor[OxO9e72[32]]=Ox680;} ;editor._fireEventFunction(Ox67f);} ;} ;function CuteEditor_GetEditor(element){for(var Ox43=element;Ox43!=null;Ox43=Ox43[OxO9e72[34]]){if(Ox43.getAttribute(OxO9e72[35])==OxO9e72[36]){return Ox43;} ;} ;return null;} ;function CuteEditor_DropDownCommand(element,Oxa60){var Ox142=element[OxO9e72[37]];if(CuteEditor_DropDownCommand[OxO9e72[23]]){var Ox43=CuteEditor_DropDownCommand[OxO9e72[23]][OxO9e72[38]][0];if(Ox43&&Ox43[OxO9e72[39]]){if(Ox43[OxO9e72[39]][OxO9e72[40]]==OxO9e72[41]){return ;} ;if(Ox43[OxO9e72[39]][OxO9e72[40]]==OxO9e72[42]){Ox142=Ox43[OxO9e72[39]][OxO9e72[37]];} ;} ;} ;var editor=CuteEditor_GetEditor(element);if(editor[OxO9e72[43]]){return ;} ;if(element.getAttribute(OxO9e72[44])==OxO9e72[36]){var Ox142=element.GetValue();if(Ox142==OxO9e72[45]){Ox142=OxO9e72[17];} ;var Ox201=element.GetText();if(Ox201==OxO9e72[45]){Ox201=OxO9e72[17];} ;element.SetSelectedIndex(0);editor.ExecCommand(Oxa60,false,Ox142,Ox201);} else {if(Ox142){if(Ox142==OxO9e72[45]){Ox142=OxO9e72[17];} ;element[OxO9e72[46]]=0;editor.ExecCommand(Oxa60,false,Ox142,Ox201);} else {element[OxO9e72[46]]=0;} ;} ;editor.FocusDocument();} ;function CuteEditor_ExpandTreeDropDownItem(src,Ox740){var Oxba=null;while(src!=null){if(src[OxO9e72[40]]==OxO9e72[47]){Oxba=src;break ;} ;src=src[OxO9e72[34]];} ;var Ox1e4=Oxba[OxO9e72[48]].item(0);Oxba[OxO9e72[51]][OxO9e72[50]][OxO9e72[49]]=OxO9e72[17];Ox1e4[OxO9e72[52]]=OxO9e72[53]+Ox740+OxO9e72[54];Oxba[OxO9e72[55]]= new Function(OxO9e72[56]+Ox740+OxO9e72[57]);} ;function CuteEditor_CollapseTreeDropDownItem(src,Ox740){var Oxba=null;while(src!=null){if(src[OxO9e72[40]]==OxO9e72[47]){Oxba=src;break ;} ;src=src[OxO9e72[34]];} ;var Ox1e4=Oxba[OxO9e72[48]].item(0);Oxba[OxO9e72[51]][OxO9e72[50]][OxO9e72[49]]=OxO9e72[58];Ox1e4[OxO9e72[52]]=OxO9e72[53]+Ox740+OxO9e72[59];Oxba[OxO9e72[55]]= new Function(OxO9e72[60]+Ox740+OxO9e72[57]);} ;function Element_Contains(element,Ox183){if(!Browser_IsOpera()){if(element[OxO9e72[61]]){return element.contains(Ox183);} ;} ;for(;Ox183!=null;Ox183=Ox183[OxO9e72[34]]){if(element==Ox183){return true;} ;} ;return false;} ;function Element_SetUnselectable(element){element.setAttribute(OxO9e72[62],OxO9e72[63]);element.setAttribute(OxO9e72[64],OxO9e72[65]);var arr=Element_GetAllElements(element);var len=arr[OxO9e72[18]];if(!len){return ;} ;for(var i=0;i<len;i++){arr[i].setAttribute(OxO9e72[62],OxO9e72[63]);arr[i].setAttribute(OxO9e72[64],OxO9e72[65]);} ;} ;function Event_GetEvent(Ox245){Ox245=Event_FindEvent(Ox245);if(Ox245==null){Debug_Todo(OxO9e72[66]);} ;return Ox245;} ;function Frame_GetContentWindow(Ox349){if(Ox349[OxO9e72[67]]){return Ox349[OxO9e72[67]];} ;if(Ox349[OxO9e72[68]]){if(Ox349[OxO9e72[68]][OxO9e72[69]]){return Ox349[OxO9e72[68]][OxO9e72[69]];} ;} ;var Ox1a8;if(Ox349[OxO9e72[70]]){Ox1a8=window[OxO9e72[71]][Ox349[OxO9e72[70]]];if(Ox1a8){return Ox1a8;} ;} ;var len=window[OxO9e72[71]][OxO9e72[18]];for(var i=0;i<len;i++){Ox1a8=window[OxO9e72[71]][i];if(Ox1a8[OxO9e72[72]]==Ox349){return Ox1a8;} ;if(Ox1a8[OxO9e72[11]]==Ox349[OxO9e72[68]]){return Ox1a8;} ;} ;Debug_Todo(OxO9e72[73]);} ;function Array_IndexOf(arr,Ox247){for(var i=0;i<arr[OxO9e72[18]];i++){if(arr[i]==Ox247){return i;} ;} ;return -1;} ;function Array_Contains(arr,Ox247){return Array_IndexOf(arr,Ox247)!=-1;} ;function Event_FindEvent(Ox245){if(Ox245&&Ox245[OxO9e72[74]]){return Ox245;} ;if(Browser_IsGecko()){return Event_FindEvent_FindEventFromCallers();} else {if(window[OxO9e72[33]]){return window[OxO9e72[33]];} ;return Event_FindEvent_FindEventFromWindows();} ;return null;} ;function Event_FindEvent_FindEventFromCallers(){var Ox18f=Event_GetEvent[OxO9e72[23]];for(var i=0;i<100;i++){if(!Ox18f){break ;} ;var Ox245=Ox18f[OxO9e72[38]][0];if(Ox245&&Ox245[OxO9e72[74]]){return Ox245;} ;Ox18f=Ox18f[OxO9e72[23]];} ;} ;function Event_FindEvent_FindEventFromWindows(){var arr=[];return Ox24e(window);function Ox24e(Ox1a8){if(Ox1a8==null){return null;} ;if(Ox1a8[OxO9e72[33]]){return Ox1a8[OxO9e72[33]];} ;if(Array_Contains(arr,Ox1a8)){return null;} ;arr.push(Ox1a8);var Ox24f=[];if(Ox1a8[OxO9e72[75]]!=Ox1a8){Ox24f.push(Ox1a8.parent);} ;if(Ox1a8[OxO9e72[76]]!=Ox1a8[OxO9e72[75]]){Ox24f.push(Ox1a8.top);} ;if(Ox1a8[OxO9e72[77]]){Ox24f.push(Ox1a8.opener);} ;for(var i=0;i<Ox1a8[OxO9e72[71]][OxO9e72[18]];i++){Ox24f.push(Ox1a8[OxO9e72[71]][i]);} ;for(var i=0;i<Ox24f[OxO9e72[18]];i++){try{var Ox245=Ox24e(Ox24f[i]);if(Ox245){return Ox245;} ;} catch(x){} ;} ;return null;} ;} ;function include(Oxc9,Ox288){var Ox289=document.getElementsByTagName(OxO9e72[78]).item(0);var Ox28a=document.getElementById(Oxc9);if(Ox28a){Ox289.removeChild(Ox28a);} ;var Ox28b=document.createElement(OxO9e72[79]);Ox28b.setAttribute(OxO9e72[80],OxO9e72[81]);Ox28b.setAttribute(OxO9e72[82],OxO9e72[83]);Ox28b.setAttribute(OxO9e72[84],Ox288);Ox28b.setAttribute(OxO9e72[70],Oxc9);Ox289.appendChild(Ox28b);} ;function Event_GetSrcElement(Ox245){Ox245=Event_GetEvent(Ox245);if(Ox245[OxO9e72[85]]){return Ox245[OxO9e72[85]];} ;if(Ox245[OxO9e72[39]]){return Ox245[OxO9e72[39]];} ;Debug_Todo(OxO9e72[86]);return null;} ;function Event_GetFromElement(Ox245){Ox245=Event_GetEvent(Ox245);if(Ox245[OxO9e72[87]]){return Ox245[OxO9e72[87]];} ;if(Ox245[OxO9e72[88]]){return Ox245[OxO9e72[88]];} ;return null;} ;function Event_GetToElement(Ox245){Ox245=Event_GetEvent(Ox245);if(Ox245[OxO9e72[89]]){return Ox245[OxO9e72[89]];} ;if(Ox245[OxO9e72[88]]){return Ox245[OxO9e72[88]];} ;return null;} ;function Event_GetKeyCode(Ox245){Ox245=Event_GetEvent(Ox245);return Ox245[OxO9e72[90]];} ;function Event_GetClientX(Ox245){Ox245=Event_GetEvent(Ox245);return Ox245[OxO9e72[91]];} ;function Event_GetClientY(Ox245){Ox245=Event_GetEvent(Ox245);return Ox245[OxO9e72[92]];} ;function Event_GetOffsetX(Ox245){Ox245=Event_GetEvent(Ox245);return Ox245[OxO9e72[93]];} ;function Event_GetOffsetY(Ox245){Ox245=Event_GetEvent(Ox245);return Ox245[OxO9e72[94]];} ;function Event_IsLeftButton(Ox245){Ox245=Event_GetEvent(Ox245);if(Browser_IsWinIE()){return Ox245[OxO9e72[95]]==1;} ;if(Browser_IsGecko()){return Ox245[OxO9e72[95]]==0;} ;return Ox245[OxO9e72[95]]==0;} ;function Event_IsCtrlKey(Ox245){Ox245=Event_GetEvent(Ox245);return Ox245[OxO9e72[96]];} ;function Event_IsAltKey(Ox245){Ox245=Event_GetEvent(Ox245);return Ox245[OxO9e72[97]];} ;function Event_IsShiftKey(Ox245){Ox245=Event_GetEvent(Ox245);return Ox245[OxO9e72[98]];} ;function Event_PreventDefault(Ox245){Ox245=Event_GetEvent(Ox245);Ox245[OxO9e72[29]]=false;if(Ox245[OxO9e72[74]]){Ox245.preventDefault();} ;} ;function Event_CancelBubble(Ox245){Ox245=Event_GetEvent(Ox245);Ox245[OxO9e72[99]]=true;if(Ox245[OxO9e72[100]]){Ox245.stopPropagation();} ;return false;} ;function Event_CancelEvent(Ox245){Ox245=Event_GetEvent(Ox245);Event_PreventDefault(Ox245);return Event_CancelBubble(Ox245);} ;function CuteEditor_BasicInitialize(editor){var Ox158=Browser_IsOpera();var Ox709= new Function(OxO9e72[101]);var Oxa64= new Function(OxO9e72[102]);var Oxa65= new Function(OxO9e72[103]);var Oxa66=editor.GetScriptProperty(OxO9e72[104]);var Oxa67=editor.GetScriptProperty(OxO9e72[105]);var Oxa68=Oxa66+OxO9e72[106]+Oxa67+OxO9e72[107];var Oxa69=Oxa66+OxO9e72[108];var images=editor.getElementsByTagName(OxO9e72[109]);var len=images[OxO9e72[18]];for(var i=0;i<len;i++){var img=images[i];if(img.getAttribute(OxO9e72[110])&&!img.getAttribute(OxO9e72[111])){img.setAttribute(OxO9e72[111],img.getAttribute(OxO9e72[110]));} ;var Ox135=img.getAttribute(OxO9e72[112]);var Ox671=img.getAttribute(OxO9e72[113]);if(!(Ox135||Ox671)){continue ;} ;var Oxa6a=img.getAttribute(OxO9e72[114]);if(parseInt(Oxa6a)>=0){img[OxO9e72[50]][OxO9e72[115]]=OxO9e72[116];img[OxO9e72[50]][OxO9e72[117]]=OxO9e72[116];img[OxO9e72[84]]=Oxa69;img[OxO9e72[50]][OxO9e72[118]]=OxO9e72[119]+Oxa68+OxO9e72[120];img[OxO9e72[50]][OxO9e72[121]]=OxO9e72[122]+(Oxa6a*20)+OxO9e72[123];img[OxO9e72[50]][OxO9e72[49]]=OxO9e72[17];} ;if(!Ox135&&!Ox671){if(Ox158){img[OxO9e72[124]]=CuteEditor_OperaHandleImageLoaded;} ;continue ;} ;if(img[OxO9e72[125]]!=OxO9e72[126]){img[OxO9e72[125]]=OxO9e72[127];img[OxO9e72[128]]= new Function(OxO9e72[129]);img[OxO9e72[130]]= new Function(OxO9e72[131]);img[OxO9e72[132]]= new Function(OxO9e72[133]);img[OxO9e72[134]]= new Function(OxO9e72[135]);} ;if(!img[OxO9e72[136]]){img[OxO9e72[136]]=Event_CancelEvent;} ;if(!img[OxO9e72[137]]){img[OxO9e72[137]]=Event_CancelEvent;} ;if(Ox135){var Ox18f=img.getAttribute(OxO9e72[138])==OxO9e72[36]?Oxa64:Ox709;if(img[OxO9e72[55]]==null){img[OxO9e72[55]]=Ox18f;} ;if(img[OxO9e72[139]]==null){img[OxO9e72[139]]=Ox18f;} ;} else {if(Ox671){if(img[OxO9e72[55]]==null){img[OxO9e72[55]]=Oxa65;} ;} ;} ;} ;var Ox776=Window_GetElement(window,editor.GetScriptProperty(OxO9e72[140]),true);var Ox777=Window_GetElement(window,editor.GetScriptProperty(OxO9e72[141]),true);var Ox772=Window_GetElement(window,editor.GetScriptProperty(OxO9e72[142]),true);Ox772[OxO9e72[125]]+=OxO9e72[143];Ox776[OxO9e72[125]]+=OxO9e72[144];Ox777[OxO9e72[125]]+=OxO9e72[144];Element_SetUnselectable(Ox776);Element_SetUnselectable(Ox777);try{editor[OxO9e72[50]][OxO9e72[145]]=OxO9e72[146];} catch(x){} ;var Ox7ff=editor.GetScriptProperty(OxO9e72[147]);switch(Ox7ff){case OxO9e72[148]:Ox776[OxO9e72[50]][OxO9e72[49]]=OxO9e72[17];break ;;case OxO9e72[149]:Ox777[OxO9e72[50]][OxO9e72[49]]=OxO9e72[17];break ;;case OxO9e72[150]:break ;;} ;} ;function CuteEditor_OperaHandleImageLoaded(){var img=this;if(img[OxO9e72[50]][OxO9e72[49]]){img[OxO9e72[50]][OxO9e72[49]]=OxO9e72[58];setTimeout(function Oxa6c(){img[OxO9e72[50]][OxO9e72[49]]=OxO9e72[17];} ,1);} ;} ;function CuteEditor_ButtonOver(element){if(!element[OxO9e72[151]]){element[OxO9e72[136]]=Event_CancelEvent;element[OxO9e72[130]]=CuteEditor_ButtonOut;element[OxO9e72[132]]=CuteEditor_ButtonDown;element[OxO9e72[134]]=CuteEditor_ButtonUp;Element_SetUnselectable(element);element[OxO9e72[151]]=true;} ;element[OxO9e72[152]]=true;element[OxO9e72[125]]=OxO9e72[153];} ;function CuteEditor_ButtonOut(){var element=this;element[OxO9e72[125]]=OxO9e72[127];element[OxO9e72[152]]=false;} ;function CuteEditor_ButtonDown(){if(!Event_IsLeftButton()){return ;} ;var element=this;element[OxO9e72[125]]=OxO9e72[154];} ;function CuteEditor_ButtonUp(){if(!Event_IsLeftButton()){return ;} ;var element=this;if(element[OxO9e72[152]]){element[OxO9e72[125]]=OxO9e72[153];} else {element[OxO9e72[125]]=OxO9e72[155];} ;} ;function CuteEditor_ColorPicker_ButtonOver(element){if(!element[OxO9e72[151]]){element[OxO9e72[136]]=Event_CancelEvent;element[OxO9e72[130]]=CuteEditor_ColorPicker_ButtonOut;element[OxO9e72[132]]=CuteEditor_ColorPicker_ButtonDown;Element_SetUnselectable(element);element[OxO9e72[151]]=true;} ;element[OxO9e72[152]]=true;element[OxO9e72[50]][OxO9e72[156]]=OxO9e72[157];element[OxO9e72[50]][OxO9e72[158]]=OxO9e72[159];element[OxO9e72[50]][OxO9e72[160]]=OxO9e72[161];} ;function CuteEditor_ColorPicker_ButtonOut(){var element=this;element[OxO9e72[152]]=false;element[OxO9e72[50]][OxO9e72[156]]=OxO9e72[162];element[OxO9e72[50]][OxO9e72[158]]=OxO9e72[17];element[OxO9e72[50]][OxO9e72[160]]=OxO9e72[161];} ;function CuteEditor_ColorPicker_ButtonDown(){var element=this;element[OxO9e72[50]][OxO9e72[156]]=OxO9e72[163];element[OxO9e72[50]][OxO9e72[158]]=OxO9e72[17];element[OxO9e72[50]][OxO9e72[160]]=OxO9e72[161];} ;function CuteEditor_ButtonCommandOver(element){element[OxO9e72[152]]=true;if(element[OxO9e72[164]]){element[OxO9e72[125]]=OxO9e72[165];} else {element[OxO9e72[125]]=OxO9e72[153];} ;} ;function CuteEditor_ButtonCommandOut(element){element[OxO9e72[152]]=false;if(element[OxO9e72[166]]){element[OxO9e72[125]]=OxO9e72[167];} else {if(element[OxO9e72[164]]){element[OxO9e72[125]]=OxO9e72[165];} else {if(element[OxO9e72[70]]!=OxO9e72[168]){element[OxO9e72[125]]=OxO9e72[127];} ;} ;} ;} ;function CuteEditor_ButtonCommandDown(element){if(!Event_IsLeftButton()){return ;} ;element[OxO9e72[125]]=OxO9e72[154];} ;function CuteEditor_ButtonCommandUp(element){if(!Event_IsLeftButton()){return ;} ;if(element[OxO9e72[164]]){element[OxO9e72[125]]=OxO9e72[165];return ;} ;if(element[OxO9e72[152]]){element[OxO9e72[125]]=OxO9e72[153];} else {if(element[OxO9e72[166]]){element[OxO9e72[125]]=OxO9e72[167];} else {element[OxO9e72[125]]=OxO9e72[127];} ;} ;} ;var CuteEditorGlobalFunctions=[CuteEditor_GetEditor,CuteEditor_ButtonOver,CuteEditor_ButtonOut,CuteEditor_ButtonDown,CuteEditor_ButtonUp,CuteEditor_ColorPicker_ButtonOver,CuteEditor_ColorPicker_ButtonOut,CuteEditor_ColorPicker_ButtonDown,CuteEditor_ButtonCommandOver,CuteEditor_ButtonCommandOut,CuteEditor_ButtonCommandDown,CuteEditor_ButtonCommandUp,CuteEditor_DropDownCommand,CuteEditor_ExpandTreeDropDownItem,CuteEditor_CollapseTreeDropDownItem,CuteEditor_OnInitialized,CuteEditor_OnCommand,CuteEditor_OnChange,CuteEditor_AddVerbMenuItems,CuteEditor_AddTagMenuItems,CuteEditor_AddMainMenuItems,CuteEditor_AddDropMenuItems,CuteEditor_FilterCode,CuteEditor_FilterHTML];function SetupCuteEditorGlobalFunctions(){for(var i=0;i<CuteEditorGlobalFunctions[OxO9e72[18]];i++){var Ox18f=CuteEditorGlobalFunctions[i];var name=Ox18f+OxO9e72[17];name=name.substr(8,name.indexOf(OxO9e72[169])-8).replace(/\s/g,OxO9e72[17]);if(!window[name]){window[name]=Ox18f;} ;} ;} ;SetupCuteEditorGlobalFunctions();var __danainfo=null;var danaurl=window[OxO9e72[171]][OxO9e72[170]];var danapos=danaurl.indexOf(OxO9e72[172]);if(danapos!=-1){var pluspos1=danaurl.indexOf(OxO9e72[173],danapos+10);var pluspos2=danaurl.indexOf(OxO9e72[174],danapos+10);if(pluspos1!=-1&&pluspos1<pluspos2){pluspos2=pluspos1;} ;__danainfo=danaurl.substring(danapos,pluspos2)+OxO9e72[174];} ;function CuteEditor_GetScriptProperty(name){var Ox142=this[OxO9e72[175]][name];if(Ox142&&__danainfo){if(name==OxO9e72[104]){return Ox142+__danainfo;} ;var Ox382=this[OxO9e72[175]][OxO9e72[104]];if(Ox142.substr(0,Ox382.length)==Ox382){return Ox382+__danainfo+Ox142.substring(Ox382.length);} ;} ;return Ox142;} ;function CuteEditor_SetScriptProperty(name,Ox142){if(Ox142==null){this[OxO9e72[175]][name]=null;} else {this[OxO9e72[175]][name]=String(Ox142);} ;} ;function CuteEditorInitialize(Oxa77,Oxa78){var editor=Window_GetElement(window,Oxa77,true);if(editor[OxO9e72[176]]){return ;} ;editor[OxO9e72[176]]=1;editor[OxO9e72[175]]=Oxa78;editor[OxO9e72[177]]=CuteEditor_GetScriptProperty;var Ox772=Window_GetElement(window,editor.GetScriptProperty(OxO9e72[142]),true);var editwin,editdoc;try{editwin=Frame_GetContentWindow(Ox772);editdoc=editwin[OxO9e72[11]];} catch(x){} ;var Oxa79=false;var Oxa7a;var Oxa7b=false;var Oxa7c=editor.GetScriptProperty(OxO9e72[104])+OxO9e72[178]+editor.GetScriptProperty(OxO9e72[179]);function Oxa7d(){if( typeof (window[OxO9e72[180]])==OxO9e72[181]){return ;} ;LoadXMLAsync(OxO9e72[182],Oxa7c+OxO9e72[183]+ new Date().getTime(),Oxa7e);} ;function Oxa7e(Ox290){var Ox889= new Date().getTime();if(Ox290[OxO9e72[184]]!=200){} else {Ox889=Ox290[OxO9e72[185]];} ;LoadXMLAsync(OxO9e72[186],Oxa7c+OxO9e72[187]+Ox889,Oxa7f);} ;function Oxa7f(Ox290){if(Ox290[OxO9e72[184]]!=200){return ;} ;CuteEditorInstallScriptCode(Ox290.responseText,OxO9e72[180]);if(Oxa79){Oxa80();} ;} ;function Oxa80(){if(Oxa7b){return ;} ;Oxa7b=true;try{editor[OxO9e72[50]][OxO9e72[145]]=OxO9e72[17];} catch(x){} ;try{editdoc[OxO9e72[188]][OxO9e72[50]][OxO9e72[145]]=OxO9e72[17];} catch(x){} ;Ox772[OxO9e72[50]][OxO9e72[49]]=OxO9e72[189];if(Browser_IsOpera()){editdoc[OxO9e72[188]][OxO9e72[190]]=true;} else {} ;window.CuteEditorImplementation(editor);var Oxa81=editor.GetScriptProperty(OxO9e72[191]);if(Oxa81){editor.Eval(Oxa81);} ;} ;function Oxa82(){if(!Element_Contains(window[OxO9e72[11]].body,editor)){return ;} ;try{Ox772=Window_GetElement(window,editor.GetScriptProperty(OxO9e72[142]),true);if(!Ox772.getAttribute(OxO9e72[192])){Ox772.setAttribute(OxO9e72[192], new Date().getTime());} ;editwin=Frame_GetContentWindow(Ox772);editdoc=editwin[OxO9e72[11]];var y=editdoc[OxO9e72[188]];} catch(x){if(Ox772!=null){Ox772.setAttribute(OxO9e72[84],Ox772.src);} ;setTimeout(Oxa82,100);return ;} ;if(!editdoc[OxO9e72[188]]){setTimeout(Oxa82,100);return ;} ;if(!Oxa79){Oxa79=true;setTimeout(Oxa82,50);return ;} ;if( typeof (window[OxO9e72[180]])==OxO9e72[181]){Oxa80();} else {try{editdoc[OxO9e72[188]][OxO9e72[50]][OxO9e72[145]]=OxO9e72[146];} catch(x){} ;} ;} ;var Oxa83=0;var Ox43=CuteEditor_Find_DisplayNone(editor);if(Ox43){function Oxa84(){if(Ox43[OxO9e72[50]][OxO9e72[49]]!=OxO9e72[58]){window.clearInterval(Oxa83);Oxa83=OxO9e72[17];editor[OxO9e72[176]]=false;CuteEditorInitialize(Oxa77,Oxa78);} ;} ;Oxa83=setInterval(Oxa84,1000);} else {CuteEditor_BasicInitialize(editor);Oxa7d();Oxa82();} ;function CuteEditor_Find_DisplayNone(element){var Oxa86;for(var Ox43=element;Ox43!=null;Ox43=Ox43[OxO9e72[34]]){if(Ox43[OxO9e72[50]]&&Ox43[OxO9e72[50]][OxO9e72[49]]==OxO9e72[58]){Oxa86=Ox43;break ;} ;} ;return Oxa86;} ;} ;function CuteEditorInstallScriptCode(Ox9c2,Ox9c3){eval(Ox9c2);window[Ox9c3]=eval(Ox9c3);} ;window[OxO9e72[193]]=CuteEditorInitialize;