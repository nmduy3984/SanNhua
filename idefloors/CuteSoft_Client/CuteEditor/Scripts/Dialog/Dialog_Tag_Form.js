var OxO8221=["inp_action","sel_Method","inp_name","inp_id","inp_encode","sel_target","Name","value","name","id","action","method","encoding","application/x-www-form-urlencoded","","target"];var inp_action=Window_GetElement(window,OxO8221[0],true);var sel_Method=Window_GetElement(window,OxO8221[1],true);var inp_name=Window_GetElement(window,OxO8221[2],true);var inp_id=Window_GetElement(window,OxO8221[3],true);var inp_encode=Window_GetElement(window,OxO8221[4],true);var sel_target=Window_GetElement(window,OxO8221[5],true);UpdateState=function UpdateState_Form(){} ;SyncToView=function SyncToView_Form(){if(element[OxO8221[6]]){inp_name[OxO8221[7]]=element[OxO8221[6]];} ;if(element[OxO8221[8]]){inp_name[OxO8221[7]]=element[OxO8221[8]];} ;inp_id[OxO8221[7]]=element[OxO8221[9]];if(element[OxO8221[10]]){inp_action[OxO8221[7]]=element[OxO8221[10]];} ;if(element[OxO8221[11]]){sel_Method[OxO8221[7]]=element[OxO8221[11]];} ;if(element[OxO8221[12]]==OxO8221[13]){inp_encode[OxO8221[7]]=OxO8221[14];} else {inp_encode[OxO8221[7]]=element[OxO8221[12]];} ;if(element[OxO8221[15]]){sel_target[OxO8221[7]]=element[OxO8221[15]];} ;} ;SyncTo=function SyncTo_Form(element){element[OxO8221[8]]=inp_name[OxO8221[7]];if(element[OxO8221[6]]){element[OxO8221[6]]=inp_name[OxO8221[7]];} else {if(element[OxO8221[8]]){element.removeAttribute(OxO8221[8],0);element[OxO8221[6]]=inp_name[OxO8221[7]];} else {element[OxO8221[6]]=inp_name[OxO8221[7]];} ;} ;element[OxO8221[9]]=inp_id[OxO8221[7]];element[OxO8221[10]]=inp_action[OxO8221[7]];element[OxO8221[11]]=sel_Method[OxO8221[7]];try{element[OxO8221[12]]=inp_encode[OxO8221[7]];} catch(e){} ;element[OxO8221[15]]=sel_target[OxO8221[7]];if(element[OxO8221[15]]==OxO8221[14]){element.removeAttribute(OxO8221[15]);} ;if(element[OxO8221[6]]==OxO8221[14]){element.removeAttribute(OxO8221[6]);} ;if(element[OxO8221[10]]==OxO8221[14]){element.removeAttribute(OxO8221[10]);} ;} ;