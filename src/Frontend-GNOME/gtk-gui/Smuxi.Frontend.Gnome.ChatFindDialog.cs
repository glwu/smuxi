// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace Smuxi.Frontend.Gnome {
    
    
    public partial class ChatFindDialog {
        
        private Gtk.VBox vbox2;
        
        private Gtk.HBox hbox1;
        
        private Gtk.Label label1;
        
        private Gtk.Entry f_SearchForEntry;
        
        private Gtk.VBox vbox3;
        
        private Gtk.CheckButton f_MatchCaseCheckButton;
        
        private Gtk.CheckButton f_SearchBackwardsCheckButton;
        
        private Gtk.CheckButton f_WrapAroundCheckButton;
        
        private Gtk.CheckButton f_UseRegularExpressionsCheckButton;
        
        private Gtk.Button f_CloseButton;
        
        private Gtk.Button f_FindButton;
        
        protected virtual void Build() {
            Stetic.Gui.Initialize(this);
            // Widget Smuxi.Frontend.Gnome.ChatFindDialog
            this.Name = "Smuxi.Frontend.Gnome.ChatFindDialog";
            this.Title = Mono.Unix.Catalog.GetString("Find");
            this.WindowPosition = ((Gtk.WindowPosition)(4));
            this.Resizable = false;
            this.AllowGrow = false;
            // Internal child Smuxi.Frontend.Gnome.ChatFindDialog.VBox
            Gtk.VBox w1 = this.VBox;
            w1.Name = "dialog1_VBox";
            w1.BorderWidth = ((uint)(2));
            // Container child dialog1_VBox.Gtk.Box+BoxChild
            this.vbox2 = new Gtk.VBox();
            this.vbox2.Name = "vbox2";
            this.vbox2.Spacing = 6;
            this.vbox2.BorderWidth = ((uint)(10));
            // Container child vbox2.Gtk.Box+BoxChild
            this.hbox1 = new Gtk.HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.label1 = new Gtk.Label();
            this.label1.Name = "label1";
            this.label1.LabelProp = Mono.Unix.Catalog.GetString("_Search for:");
            this.label1.UseUnderline = true;
            this.hbox1.Add(this.label1);
            Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.hbox1[this.label1]));
            w2.Position = 0;
            w2.Expand = false;
            w2.Fill = false;
            // Container child hbox1.Gtk.Box+BoxChild
            this.f_SearchForEntry = new Gtk.Entry();
            this.f_SearchForEntry.CanFocus = true;
            this.f_SearchForEntry.Name = "f_SearchForEntry";
            this.f_SearchForEntry.IsEditable = true;
            this.f_SearchForEntry.InvisibleChar = '●';
            this.hbox1.Add(this.f_SearchForEntry);
            Gtk.Box.BoxChild w3 = ((Gtk.Box.BoxChild)(this.hbox1[this.f_SearchForEntry]));
            w3.Position = 1;
            this.vbox2.Add(this.hbox1);
            Gtk.Box.BoxChild w4 = ((Gtk.Box.BoxChild)(this.vbox2[this.hbox1]));
            w4.Position = 0;
            w4.Expand = false;
            w4.Fill = false;
            // Container child vbox2.Gtk.Box+BoxChild
            this.vbox3 = new Gtk.VBox();
            this.vbox3.Name = "vbox3";
            this.vbox3.Spacing = 6;
            // Container child vbox3.Gtk.Box+BoxChild
            this.f_MatchCaseCheckButton = new Gtk.CheckButton();
            this.f_MatchCaseCheckButton.CanFocus = true;
            this.f_MatchCaseCheckButton.Name = "f_MatchCaseCheckButton";
            this.f_MatchCaseCheckButton.Label = Mono.Unix.Catalog.GetString("_Match case");
            this.f_MatchCaseCheckButton.DrawIndicator = true;
            this.f_MatchCaseCheckButton.UseUnderline = true;
            this.vbox3.Add(this.f_MatchCaseCheckButton);
            Gtk.Box.BoxChild w5 = ((Gtk.Box.BoxChild)(this.vbox3[this.f_MatchCaseCheckButton]));
            w5.Position = 0;
            w5.Expand = false;
            w5.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.f_SearchBackwardsCheckButton = new Gtk.CheckButton();
            this.f_SearchBackwardsCheckButton.CanFocus = true;
            this.f_SearchBackwardsCheckButton.Name = "f_SearchBackwardsCheckButton";
            this.f_SearchBackwardsCheckButton.Label = Mono.Unix.Catalog.GetString("Search _backwards");
            this.f_SearchBackwardsCheckButton.DrawIndicator = true;
            this.f_SearchBackwardsCheckButton.UseUnderline = true;
            this.vbox3.Add(this.f_SearchBackwardsCheckButton);
            Gtk.Box.BoxChild w6 = ((Gtk.Box.BoxChild)(this.vbox3[this.f_SearchBackwardsCheckButton]));
            w6.Position = 1;
            w6.Expand = false;
            w6.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.f_WrapAroundCheckButton = new Gtk.CheckButton();
            this.f_WrapAroundCheckButton.CanFocus = true;
            this.f_WrapAroundCheckButton.Name = "f_WrapAroundCheckButton";
            this.f_WrapAroundCheckButton.Label = Mono.Unix.Catalog.GetString("_Wrap around");
            this.f_WrapAroundCheckButton.Active = true;
            this.f_WrapAroundCheckButton.DrawIndicator = true;
            this.f_WrapAroundCheckButton.UseUnderline = true;
            this.vbox3.Add(this.f_WrapAroundCheckButton);
            Gtk.Box.BoxChild w7 = ((Gtk.Box.BoxChild)(this.vbox3[this.f_WrapAroundCheckButton]));
            w7.Position = 2;
            w7.Expand = false;
            w7.Fill = false;
            // Container child vbox3.Gtk.Box+BoxChild
            this.f_UseRegularExpressionsCheckButton = new Gtk.CheckButton();
            this.f_UseRegularExpressionsCheckButton.CanFocus = true;
            this.f_UseRegularExpressionsCheckButton.Name = "f_UseRegularExpressionsCheckButton";
            this.f_UseRegularExpressionsCheckButton.Label = Mono.Unix.Catalog.GetString("Use _Regular Expressions");
            this.f_UseRegularExpressionsCheckButton.DrawIndicator = true;
            this.f_UseRegularExpressionsCheckButton.UseUnderline = true;
            this.vbox3.Add(this.f_UseRegularExpressionsCheckButton);
            Gtk.Box.BoxChild w8 = ((Gtk.Box.BoxChild)(this.vbox3[this.f_UseRegularExpressionsCheckButton]));
            w8.PackType = ((Gtk.PackType)(1));
            w8.Position = 3;
            w8.Expand = false;
            w8.Fill = false;
            this.vbox2.Add(this.vbox3);
            Gtk.Box.BoxChild w9 = ((Gtk.Box.BoxChild)(this.vbox2[this.vbox3]));
            w9.Position = 1;
            w9.Expand = false;
            w9.Fill = false;
            w1.Add(this.vbox2);
            Gtk.Box.BoxChild w10 = ((Gtk.Box.BoxChild)(w1[this.vbox2]));
            w10.Position = 0;
            w10.Expand = false;
            w10.Fill = false;
            // Internal child Smuxi.Frontend.Gnome.ChatFindDialog.ActionArea
            Gtk.HButtonBox w11 = this.ActionArea;
            w11.Name = "dialog1_ActionArea";
            w11.Spacing = 6;
            w11.BorderWidth = ((uint)(5));
            w11.LayoutStyle = ((Gtk.ButtonBoxStyle)(4));
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.f_CloseButton = new Gtk.Button();
            this.f_CloseButton.CanDefault = true;
            this.f_CloseButton.CanFocus = true;
            this.f_CloseButton.Name = "f_CloseButton";
            this.f_CloseButton.UseStock = true;
            this.f_CloseButton.UseUnderline = true;
            this.f_CloseButton.Label = "gtk-close";
            this.AddActionWidget(this.f_CloseButton, -7);
            Gtk.ButtonBox.ButtonBoxChild w12 = ((Gtk.ButtonBox.ButtonBoxChild)(w11[this.f_CloseButton]));
            w12.Expand = false;
            w12.Fill = false;
            // Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
            this.f_FindButton = new Gtk.Button();
            this.f_FindButton.CanDefault = true;
            this.f_FindButton.CanFocus = true;
            this.f_FindButton.Name = "f_FindButton";
            this.f_FindButton.UseStock = true;
            this.f_FindButton.UseUnderline = true;
            this.f_FindButton.Label = "gtk-find";
            this.AddActionWidget(this.f_FindButton, 0);
            Gtk.ButtonBox.ButtonBoxChild w13 = ((Gtk.ButtonBox.ButtonBoxChild)(w11[this.f_FindButton]));
            w13.Position = 1;
            w13.Expand = false;
            w13.Fill = false;
            if ((this.Child != null)) {
                this.Child.ShowAll();
            }
            this.DefaultWidth = 400;
            this.DefaultHeight = 300;
            this.label1.MnemonicWidget = this.f_SearchForEntry;
            this.Show();
        }
    }
}
