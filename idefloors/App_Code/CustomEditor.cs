using AjaxControlToolkit.HTMLEditor;
using System.Collections.ObjectModel;

namespace CustomEditor
{
    public class CustomEditor : Editor
    {
        protected override void FillTopToolbar()
        {

            //TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.PasteText()); 
            //TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.PasteWord());
            //TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Paste());            
            //TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Undo());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.OrderedList());

            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());

            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Bold());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Underline());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.Italic());

            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());

            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.JustifyLeft());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.JustifyCenter());
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.JustifyRight());

            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());


            //Font Size
            Collection<AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption> options;
            AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption option;

            AjaxControlToolkit.HTMLEditor.ToolbarButton.FontName fontName = new AjaxControlToolkit.HTMLEditor.ToolbarButton.FontName();
            TopToolbar.Buttons.Add(fontName);

            options = fontName.Options;
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            //option.Value = "";
            //option.Text = "";
            //options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "arial,helvetica,sans-serif";
            option.Text = "Arial";
            options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "courier new,courier,monospace";
            option.Text = "Courier New";
            options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "georgia,times new roman,times,serif";
            option.Text = "Georgia";
            options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "tahoma,arial,helvetica,sans-serif";
            option.Text = "Tahoma";
            options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "times new roman,times,serif";
            option.Text = "Times New Roman";
            options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "verdana,arial,helvetica,sans-serif";
            option.Text = "Verdana";
            options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "impact";
            option.Text = "Impact";
            options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "wingdings";
            option.Text = "WingDings";
            options.Add(option);

            AjaxControlToolkit.HTMLEditor.ToolbarButton.FontSize fontSize = new AjaxControlToolkit.HTMLEditor.ToolbarButton.FontSize();
            TopToolbar.Buttons.Add(fontSize);

            options = fontSize.Options;
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            //option.Value = "";
            //option.Text = "";
            //options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "8pt";
            option.Text = "1 ( 8 pt)";
            options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "10pt";
            option.Text = "2 (10 pt)";
            options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "12pt";
            option.Text = "3 (12 pt)";
            options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "14pt";
            option.Text = "4 (14 pt)";
            options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "18pt";
            option.Text = "5 (18 pt)";
            options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "24pt";
            option.Text = "6 (24 pt)";
            options.Add(option);
            option = new AjaxControlToolkit.HTMLEditor.ToolbarButton.SelectOption();
            option.Value = "36pt";
            option.Text = "7 (36 pt)";
            options.Add(option);

            /////////////////////////////////
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HorizontalSeparator());

            AjaxControlToolkit.HTMLEditor.ToolbarButton.FixedForeColor FixedForeColor = new AjaxControlToolkit.HTMLEditor.ToolbarButton.FixedForeColor();
            TopToolbar.Buttons.Add(FixedForeColor);
            AjaxControlToolkit.HTMLEditor.ToolbarButton.ForeColorSelector ForeColorSelector = new AjaxControlToolkit.HTMLEditor.ToolbarButton.ForeColorSelector();
            ForeColorSelector.FixedColorButtonId = FixedForeColor.ID = "FixedForeColor";
            TopToolbar.Buttons.Add(ForeColorSelector);
            TopToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.ForeColorClear());



        }

        protected override void FillBottomToolbar()
        {
            BottomToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.DesignMode());
            BottomToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.HtmlMode());
            BottomToolbar.Buttons.Add(new AjaxControlToolkit.HTMLEditor.ToolbarButton.PreviewMode());
        }
    }

}
