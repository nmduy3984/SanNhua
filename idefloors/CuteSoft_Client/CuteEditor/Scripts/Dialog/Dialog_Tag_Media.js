var OxO444e=["outer","btnbrowse","inp_src","onclick","value","cssText","style","src","FileName"];var outer=Window_GetElement(window,OxO444e[0],true);var btnbrowse=Window_GetElement(window,OxO444e[1],true);var inp_src=Window_GetElement(window,OxO444e[2],true);btnbrowse[OxO444e[3]]=function btnbrowse_onclick(){function Ox35d(Ox13e){if(Ox13e){inp_src[OxO444e[4]]=Ox13e;} ;} ;editor.SetNextDialogWindow(window);editor.ShowSelectFileDialog(Ox35d,inp_src.value);} ;UpdateState=function UpdateState_Media(){outer[OxO444e[6]][OxO444e[5]]=element[OxO444e[6]][OxO444e[5]];outer.mergeAttributes(element);if(element[OxO444e[7]]){outer[OxO444e[8]]=element[OxO444e[8]];} else {outer.removeAttribute(OxO444e[8]);} ;} ;SyncToView=function SyncToView_Media(){inp_src[OxO444e[4]]=element[OxO444e[8]];} ;SyncTo=function SyncTo_Media(element){element[OxO444e[8]]=inp_src[OxO444e[4]];} ;