var OxO8c67=["inp_name","inp_cols","inp_rows","inp_value","sel_Wrap","inp_id","inp_access","inp_index","inp_Disabled","inp_Readonly","Name","value","name","id","cols","","rows","checked","disabled","readOnly","wrap","tabIndex","accessKey","textContent"];var inp_name=Window_GetElement(window,OxO8c67[0],true);var inp_cols=Window_GetElement(window,OxO8c67[1],true);var inp_rows=Window_GetElement(window,OxO8c67[2],true);var inp_value=Window_GetElement(window,OxO8c67[3],true);var sel_Wrap=Window_GetElement(window,OxO8c67[4],true);var inp_id=Window_GetElement(window,OxO8c67[5],true);var inp_access=Window_GetElement(window,OxO8c67[6],true);var inp_index=Window_GetElement(window,OxO8c67[7],true);var inp_Disabled=Window_GetElement(window,OxO8c67[8],true);var inp_Readonly=Window_GetElement(window,OxO8c67[9],true);UpdateState=function UpdateState_Textarea(){} ;SyncToView=function SyncToView_Textarea(){if(element[OxO8c67[10]]){inp_name[OxO8c67[11]]=element[OxO8c67[10]];} ;if(element[OxO8c67[12]]){inp_name[OxO8c67[11]]=element[OxO8c67[12]];} ;inp_id[OxO8c67[11]]=element[OxO8c67[13]];inp_value[OxO8c67[11]]=element[OxO8c67[11]];if(element[OxO8c67[14]]){if(element[OxO8c67[14]]==20){inp_cols[OxO8c67[11]]=OxO8c67[15];} else {inp_cols[OxO8c67[11]]=element[OxO8c67[14]];} ;} ;if(element[OxO8c67[16]]){if(element[OxO8c67[16]]==2){inp_rows[OxO8c67[11]]=OxO8c67[15];} else {inp_rows[OxO8c67[11]]=element[OxO8c67[16]];} ;} ;inp_Disabled[OxO8c67[17]]=element[OxO8c67[18]];inp_Readonly[OxO8c67[17]]=element[OxO8c67[19]];sel_Wrap[OxO8c67[11]]=element[OxO8c67[20]];if(element[OxO8c67[21]]==0){inp_index[OxO8c67[11]]=OxO8c67[15];} else {inp_index[OxO8c67[11]]=element[OxO8c67[21]];} ;if(element[OxO8c67[22]]){inp_access[OxO8c67[11]]=element[OxO8c67[22]];} ;} ;SyncTo=function SyncTo_Textarea(element){element[OxO8c67[12]]=inp_name[OxO8c67[11]];if(element[OxO8c67[10]]){element[OxO8c67[10]]=inp_name[OxO8c67[11]];} else {if(element[OxO8c67[12]]){element.removeAttribute(OxO8c67[12],0);element[OxO8c67[10]]=inp_name[OxO8c67[11]];} else {element[OxO8c67[10]]=inp_name[OxO8c67[11]];} ;} ;element[OxO8c67[13]]=inp_id[OxO8c67[11]];element[OxO8c67[11]]=inp_value[OxO8c67[11]];if(!Browser_IsWinIE()){try{element[OxO8c67[23]]=inp_value[OxO8c67[11]];} catch(x){} ;} ;element[OxO8c67[21]]=inp_index[OxO8c67[11]];element[OxO8c67[18]]=inp_Disabled[OxO8c67[17]];element[OxO8c67[19]]=inp_Readonly[OxO8c67[17]];element[OxO8c67[22]]=inp_access[OxO8c67[11]];if(inp_cols[OxO8c67[11]]==OxO8c67[15]){element[OxO8c67[14]]=20;} else {element[OxO8c67[14]]=inp_cols[OxO8c67[11]];} ;if(inp_rows[OxO8c67[11]]==OxO8c67[15]){element[OxO8c67[16]]=2;} else {element[OxO8c67[16]]=inp_rows[OxO8c67[11]];} ;try{element[OxO8c67[20]]=sel_Wrap[OxO8c67[11]];} catch(e){element.removeAttribute(OxO8c67[20]);} ;element[OxO8c67[21]]=inp_index[OxO8c67[11]];if(element[OxO8c67[21]]==OxO8c67[15]){element.removeAttribute(OxO8c67[21]);} ;if(element[OxO8c67[22]]==OxO8c67[15]){element.removeAttribute(OxO8c67[22]);} ;} ;