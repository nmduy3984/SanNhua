var OxOc68b=["Verdana","innerHTML","Unicode","innerText","\x3Cspan style=\x27font-family:","\x27\x3E","\x3C/span\x3E","selfont","length","checked","value","charstable1","charstable2","fontFamily","style","display","block","none"];var editor=Window_GetDialogArguments(window);function getchar(obj){var Ox2d;var Ox2e=getFontValue()||OxOc68b[0];if(!obj[OxOc68b[1]]){return ;} ;Ox2d=obj[OxOc68b[1]];if(Ox2e==OxOc68b[2]){Ox2d=obj[OxOc68b[3]];} else {if(Ox2e!=OxOc68b[0]){Ox2d=OxOc68b[4]+Ox2e+OxOc68b[5]+obj[OxOc68b[1]]+OxOc68b[6];} ;} ;editor.PasteHTML(Ox2d);Window_CloseDialog(window);} ;function cancel(){Window_CloseDialog(window);} ;function getFontValue(){var Ox31=document.getElementsByName(OxOc68b[7]);for(var i=0;i<Ox31[OxOc68b[8]];i++){if(Ox31.item(i)[OxOc68b[9]]){return Ox31.item(i)[OxOc68b[10]];} ;} ;} ;function sel_font_change(){var Ox33=getFontValue()||OxOc68b[0];var Ox37c=Window_GetElement(window,OxOc68b[11],true);var Ox37d=Window_GetElement(window,OxOc68b[12],true);Ox37c[OxOc68b[14]][OxOc68b[13]]=Ox33;Ox37c[OxOc68b[14]][OxOc68b[15]]=(Ox33!=OxOc68b[2]?OxOc68b[16]:OxOc68b[17]);Ox37d[OxOc68b[14]][OxOc68b[15]]=(Ox33==OxOc68b[2]?OxOc68b[16]:OxOc68b[17]);} ;