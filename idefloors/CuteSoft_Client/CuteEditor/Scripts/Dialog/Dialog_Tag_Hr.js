var OxOd80d=["inp_width","eenheid","alignment","hrcolor","hrcolorpreview","shade","sel_size","width","style","value","px","%","size","align","color","backgroundColor","noShade","noshade","","onclick"];var inp_width=Window_GetElement(window,OxOd80d[0],true);var eenheid=Window_GetElement(window,OxOd80d[1],true);var alignment=Window_GetElement(window,OxOd80d[2],true);var hrcolor=Window_GetElement(window,OxOd80d[3],true);var hrcolorpreview=Window_GetElement(window,OxOd80d[4],true);var shade=Window_GetElement(window,OxOd80d[5],true);var sel_size=Window_GetElement(window,OxOd80d[6],true);UpdateState=function UpdateState_Hr(){} ;SyncToView=function SyncToView_Hr(){if(element[OxOd80d[8]][OxOd80d[7]]){if(element[OxOd80d[8]][OxOd80d[7]].search(/%/)<0){eenheid[OxOd80d[9]]=OxOd80d[10];inp_width[OxOd80d[9]]=element[OxOd80d[8]][OxOd80d[7]].split(OxOd80d[10])[0];} else {eenheid[OxOd80d[9]]=OxOd80d[11];inp_width[OxOd80d[9]]=element[OxOd80d[8]][OxOd80d[7]].split(OxOd80d[11])[0];} ;} ;sel_size[OxOd80d[9]]=element[OxOd80d[12]];alignment[OxOd80d[9]]=element[OxOd80d[13]];hrcolor[OxOd80d[9]]=element[OxOd80d[14]];if(element[OxOd80d[14]]){hrcolor[OxOd80d[8]][OxOd80d[15]]=element[OxOd80d[14]];} ;if(element[OxOd80d[16]]){shade[OxOd80d[9]]=OxOd80d[17];} else {shade[OxOd80d[9]]=OxOd80d[18];} ;} ;SyncTo=function SyncTo_Hr(element){if(sel_size[OxOd80d[9]]){element[OxOd80d[12]]=sel_size[OxOd80d[9]];} ;if(hrcolor[OxOd80d[9]]){element[OxOd80d[14]]=hrcolor[OxOd80d[9]];} ;if(alignment[OxOd80d[9]]){element[OxOd80d[13]]=alignment[OxOd80d[9]];} ;if(shade[OxOd80d[9]]==OxOd80d[17]){element[OxOd80d[16]]=true;} else {element[OxOd80d[16]]=false;} ;if(inp_width[OxOd80d[9]]){element[OxOd80d[8]][OxOd80d[7]]=inp_width[OxOd80d[9]]+eenheid[OxOd80d[9]];} ;} ;hrcolor[OxOd80d[19]]=hrcolorpreview[OxOd80d[19]]=function hrcolor_onclick(){SelectColor(hrcolor,hrcolorpreview);} ;