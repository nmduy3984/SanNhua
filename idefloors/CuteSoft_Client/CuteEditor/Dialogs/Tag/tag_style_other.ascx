<%@ Control Inherits="CuteEditor.EditorUtilityCtrl" Language="c#" AutoEventWireup="false" TargetSchema="http://schemas.microsoft.com/intellisense/ie5" %>
<fieldset style="padding:4px;">
	<legend>
	[[Cursor]]
	</legend>
	<select id="sel_cursor">
		<option value="">[[NotSet]]</option>
		<option value="Default">[[Default]]</option>
		<option value="Move">[[Move]]</option>
		<option value="Text">Text</option>
		<option value="Wait">Wait</option>
		<option value="Help">Help</option>
		<option value="Pointer">Pointer</option>
		<option value="Hand">Hand</option>
		<option value="Progress">Progress </option>
		<option value="not-allowed">Not-Allowed</option>
		<!-- x-resize -->
	</select>
</fieldset>

<fieldset style="padding:4px;">
	<legend>
	[[Filter]]
	</legend>
	<input type="text" id="inp_filter" style="width:240px" /> <!--button filter builder-->
</fieldset>
<div id="outer" style="height:100px; margin-bottom:10px; padding:5px;"><div id="div_demo">[[DemoText]]</div></div><br />

<script type="text/javascript">

var OxOcaa7=["sel_cursor","inp_filter","outer","div_demo","cssText","style","value","cursor","filter"];var sel_cursor=Window_GetElement(window,OxOcaa7[0],true);var inp_filter=Window_GetElement(window,OxOcaa7[1],true);var outer=Window_GetElement(window,OxOcaa7[2],true);var div_demo=Window_GetElement(window,OxOcaa7[3],true);function UpdateState(){div_demo[OxOcaa7[5]][OxOcaa7[4]]=element[OxOcaa7[5]][OxOcaa7[4]];} ;function SyncToView(){sel_cursor[OxOcaa7[6]]=element[OxOcaa7[5]][OxOcaa7[7]];if(Browser_IsWinIE()){inp_filter[OxOcaa7[6]]=element[OxOcaa7[5]][OxOcaa7[8]];} ;} ;function SyncTo(element){element[OxOcaa7[5]][OxOcaa7[7]]=sel_cursor[OxOcaa7[6]];if(Browser_IsWinIE()){element[OxOcaa7[5]][OxOcaa7[8]]=inp_filter[OxOcaa7[6]];} ;} ;

</script>
