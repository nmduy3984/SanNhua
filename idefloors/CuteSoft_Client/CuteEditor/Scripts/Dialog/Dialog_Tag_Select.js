var OxOf418=["inp_name","inp_access","inp_id","inp_index","inp_size","inp_Multiple","inp_Disabled","inp_item_text","inp_item_value","btnInsertItem","btnUpdateItem","btnDeleteItem","btnMoveUpItem","btnMoveDownItem","list_options","list_options2","inp_item_forecolor","inp_item_forecolor_Preview","inp_item_backcolor_Preview","text","value","color","style","backgroundColor","selectedIndex","options","Please select an item first","length","ondblclick","onclick","OPTION","document","id","cssText","Name","name","size","checked","disabled","multiple","tabIndex","","accessKey"];var inp_name=Window_GetElement(window,OxOf418[0],true);var inp_access=Window_GetElement(window,OxOf418[1],true);var inp_id=Window_GetElement(window,OxOf418[2],true);var inp_index=Window_GetElement(window,OxOf418[3],true);var inp_size=Window_GetElement(window,OxOf418[4],true);var inp_Multiple=Window_GetElement(window,OxOf418[5],true);var inp_Disabled=Window_GetElement(window,OxOf418[6],true);var inp_item_text=Window_GetElement(window,OxOf418[7],true);var inp_item_value=Window_GetElement(window,OxOf418[8],true);var btnInsertItem=Window_GetElement(window,OxOf418[9],true);var btnUpdateItem=Window_GetElement(window,OxOf418[10],true);var btnDeleteItem=Window_GetElement(window,OxOf418[11],true);var btnMoveUpItem=Window_GetElement(window,OxOf418[12],true);var btnMoveDownItem=Window_GetElement(window,OxOf418[13],true);var list_options=Window_GetElement(window,OxOf418[14],true);var list_options2=Window_GetElement(window,OxOf418[15],true);var inp_item_forecolor=Window_GetElement(window,OxOf418[16],true);var inp_item_forecolor=Window_GetElement(window,OxOf418[16],true);var inp_item_forecolor_Preview=Window_GetElement(window,OxOf418[17],true);var inp_item_backcolor_Preview=Window_GetElement(window,OxOf418[18],true);function SetOption(Ox1a6){Ox1a6[OxOf418[19]]=inp_item_text[OxOf418[20]];Ox1a6[OxOf418[20]]=inp_item_value[OxOf418[20]];Ox1a6[OxOf418[22]][OxOf418[21]]=inp_item_forecolor[OxOf418[20]];Ox1a6[OxOf418[22]][OxOf418[23]]=inp_item_backcolor[OxOf418[20]];} ;function SetOption2(Ox1a6){Ox1a6[OxOf418[19]]=inp_item_value[OxOf418[20]];Ox1a6[OxOf418[20]]=inp_item_text[OxOf418[20]];Ox1a6[OxOf418[22]][OxOf418[21]]=inp_item_forecolor[OxOf418[20]];Ox1a6[OxOf418[22]][OxOf418[23]]=inp_item_backcolor[OxOf418[20]];} ;function Select(Ox1a6){var Ox5a1=Ox1a6[OxOf418[24]];list_options[OxOf418[24]]=Ox5a1;list_options2[OxOf418[24]]=Ox5a1;inp_item_text[OxOf418[20]]=list_options2[OxOf418[20]];inp_item_value[OxOf418[20]]=list_options[OxOf418[20]];} ;function Insert(){var Ox1a6= new Option();SetOption(Ox1a6);list_options[OxOf418[25]].add(Ox1a6);var Ox5a3= new Option();SetOption2(Ox5a3);list_options2[OxOf418[25]].add(Ox5a3);FireUIChanged();} ;function Update(){if(list_options[OxOf418[24]]==-1){alert(OxOf418[26]);return ;} ;var Ox1a6=list_options.options(list_options.selectedIndex);SetOption(Ox1a6);var Ox5a3=list_options2.options(list_options2.selectedIndex);SetOption2(Ox5a3);FireUIChanged();} ;function Move(Ox142){var Ox5a1=list_options[OxOf418[24]];if(Ox5a1<0){return ;} ;var Ox5a5=Ox5a1-Ox142;if(Ox5a5<0){Ox5a5=0;} ;if(Ox5a5>(list_options[OxOf418[25]][OxOf418[27]]-1)){Ox5a5=list_options[OxOf418[25]][OxOf418[27]]-1;} ;if(Ox5a1==Ox5a5){return ;} ;var Ox1a6=list_options.options(list_options.selectedIndex);var Ox12=list_options2[OxOf418[20]];var Ox8=list_options[OxOf418[20]];Delete();inp_item_text[OxOf418[20]]=Ox12;inp_item_value[OxOf418[20]]=Ox8;var Ox1a6= new Option();SetOption(Ox1a6);list_options[OxOf418[25]].add(Ox1a6,Ox5a5);var Ox5a3= new Option();SetOption2(Ox5a3);list_options2[OxOf418[25]].add(Ox5a3,Ox5a5);list_options[OxOf418[24]]=Ox5a5;list_options2[OxOf418[24]]=Ox5a5;FireUIChanged();} ;function Delete(){if(list_options[OxOf418[24]]==-1||list_options[OxOf418[24]]==-1){alert(OxOf418[26]);return ;} ;var Ox5a6=list_options[OxOf418[24]];var Ox1a6=list_options.options(list_options.selectedIndex);Ox1a6.removeNode(true);Ox1a6=list_options2.options(list_options2.selectedIndex);Ox1a6.removeNode(true);if(list_options[OxOf418[25]][OxOf418[27]]>Ox5a6){list_options[OxOf418[24]]=Ox5a6;} else {if(list_options[OxOf418[25]][OxOf418[27]]){list_options[OxOf418[24]]=list_options[OxOf418[25]][OxOf418[27]]-1;} ;} ;list_options.ondblclick();if(list_options2[OxOf418[25]][OxOf418[27]]>Ox5a6){list_options2[OxOf418[24]]=Ox5a6;} else {if(list_options2[OxOf418[25]][OxOf418[27]]){list_options2[OxOf418[24]]=list_options2[OxOf418[25]][OxOf418[27]]-1;} ;} ;FireUIChanged();} ;list_options[OxOf418[28]]=function list_options_ondblclick(){if(list_options[OxOf418[24]]==-1){return ;} ;var Ox1a6=list_options.options(list_options.selectedIndex);inp_item_text[OxOf418[20]]=Ox1a6[OxOf418[19]];inp_item_value[OxOf418[20]]=Ox1a6[OxOf418[20]];inp_item_forecolor[OxOf418[20]]=inp_item_forecolor[OxOf418[22]][OxOf418[23]]=inp_item_forecolor_Preview[OxOf418[22]][OxOf418[23]]=Ox1a6[OxOf418[22]][OxOf418[21]];inp_item_backcolor[OxOf418[20]]=inp_item_backcolor[OxOf418[22]][OxOf418[23]]=inp_item_backcolor_Preview[OxOf418[22]][OxOf418[23]]=Ox1a6[OxOf418[22]][OxOf418[23]];} ;inp_item_forecolor[OxOf418[29]]=inp_item_forecolor_Preview[OxOf418[29]]=function inp_item_forecolor_onclick(){SelectColor(inp_item_forecolor,inp_item_forecolor_Preview);} ;inp_item_backcolor[OxOf418[29]]=inp_item_backcolor_Preview[OxOf418[29]]=function inp_item_backcolor_onclick(){SelectColor(inp_item_backcolor,inp_item_backcolor_Preview);} ;function CopySelect(Ox5ab,Ox5ac){Ox5ac[OxOf418[25]][OxOf418[27]]=0;for(var i=0;i<Ox5ab[OxOf418[25]][OxOf418[27]];i++){var Ox5ad=Ox5ab[OxOf418[25]][i];var Ox5a3;if(Browser_IsWinIE()){Ox5a3=Ox5ac[OxOf418[31]].createElement(OxOf418[30]);} else {Ox5a3=document.createElement(OxOf418[30]);} ;if(Ox5ac[OxOf418[32]]!=OxOf418[15]){Ox5a3[OxOf418[20]]=Ox5ad[OxOf418[20]];Ox5a3[OxOf418[19]]=Ox5ad[OxOf418[19]];} else {Ox5a3[OxOf418[20]]=Ox5ad[OxOf418[19]];Ox5a3[OxOf418[19]]=Ox5ad[OxOf418[20]];} ;Ox5a3[OxOf418[22]][OxOf418[33]]=Ox5ad[OxOf418[22]][OxOf418[33]];Ox5ac[OxOf418[25]].add(Ox5a3);} ;Ox5ac[OxOf418[24]]=Ox5ab[OxOf418[24]];} ;UpdateState=function UpdateState_Select(){} ;SyncToView=function SyncToView_Select(){if(element[OxOf418[34]]){inp_name[OxOf418[20]]=element[OxOf418[34]];} ;if(element[OxOf418[35]]){inp_name[OxOf418[20]]=element[OxOf418[35]];} ;inp_id[OxOf418[20]]=element[OxOf418[32]];inp_size[OxOf418[20]]=element[OxOf418[36]];CopySelect(element,list_options);CopySelect(element,list_options2);inp_Disabled[OxOf418[37]]=element[OxOf418[38]];inp_Multiple[OxOf418[37]]=element[OxOf418[39]];if(element[OxOf418[40]]==0){inp_index[OxOf418[20]]=OxOf418[41];} else {inp_index[OxOf418[20]]=element[OxOf418[40]];} ;if(element[OxOf418[42]]){inp_access[OxOf418[20]]=element[OxOf418[42]];} ;} ;SyncTo=function SyncTo_Select(element){element[OxOf418[35]]=inp_name[OxOf418[20]];if(element[OxOf418[34]]){element[OxOf418[34]]=inp_name[OxOf418[20]];} else {if(element[OxOf418[35]]){element.removeAttribute(OxOf418[35],0);element[OxOf418[34]]=inp_name[OxOf418[20]];} else {element[OxOf418[34]]=inp_name[OxOf418[20]];} ;} ;element[OxOf418[32]]=inp_id[OxOf418[20]];element[OxOf418[36]]=inp_size[OxOf418[20]];element[OxOf418[38]]=inp_Disabled[OxOf418[37]];element[OxOf418[39]]=inp_Multiple[OxOf418[37]];element[OxOf418[42]]=inp_access[OxOf418[20]];element[OxOf418[40]]=inp_index[OxOf418[20]];if(element[OxOf418[40]]==OxOf418[41]){element.removeAttribute(OxOf418[40]);} ;if(element[OxOf418[42]]==OxOf418[41]){element.removeAttribute(OxOf418[42]);} ;CopySelect(list_options,element);} ;