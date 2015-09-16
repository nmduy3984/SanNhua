<%@ Control Language="C#" AutoEventWireup="true" CodeFile="References.ascx.cs" Inherits="Control_References" %>

<%@ Register Src="ReferenceFrames/L_Frame_1.ascx" TagName="L_Frame_1" TagPrefix="uc1" %>

<%@ Register Src="ReferenceFrames/L_Frame_2.ascx" TagName="L_Frame_2" TagPrefix="uc2" %>
<%@ Register Src="ReferenceFrames/L_Frame_3.ascx" TagName="L_Frame_3" TagPrefix="uc3" %>
<%@ Register Src="ReferenceFrames/L_Frame_4.ascx" TagName="L_Frame_4" TagPrefix="uc4" %>
<%@ Register Src="ReferenceFrames/L_Frame_5.ascx" TagName="L_Frame_5" TagPrefix="uc5" %>

<%@ Register Src="ReferenceFrames/R_Frame.ascx" TagName="R_Frame" TagPrefix="uc6" %>

<div class="L_col">
    <div>
        <h2>Tham khảo:</h2>
    </div>
    <br />
    <br />
    <uc1:L_Frame_1 ID="L_Frame_11" runat="server" />
    <uc2:L_Frame_2 ID="L_Frame_21" runat="server" />
    <uc3:L_Frame_3 ID="L_Frame_31" runat="server" />
    <uc4:L_Frame_4 ID="L_Frame_41" runat="server" />
    <uc5:L_Frame_5 ID="L_Frame_51" runat="server" />
</div>

<div class="R_col">
    <div>
        <h2>Tham khảo:</h2>
    </div>
    <br />
    <br />
    <uc6:R_Frame ID="R_Frame1" runat="server" />
</div>
