namespace BusinessApp.Portal
{
    partial class MyDesktop
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new Wisej.Web.ListView();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
            this.listView1.BackColor = System.Drawing.Color.FromArgb(3, 255, 255, 255);
            this.listView1.BorderStyle = Wisej.Web.BorderStyle.None;
            this.listView1.GridLineStyle = Wisej.Web.GridLineStyle.Both;
            this.listView1.Location = new System.Drawing.Point(17, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1532, 749);
            this.listView1.TabIndex = 0;
            this.listView1.ItemDoubleClick += new Wisej.Web.ItemClickEventHandler(this.listView1_ItemDoubleClick);
            // 
            // MyDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.Controls.Add(this.listView1);
            this.Name = "MyDesktop";
            this.Size = new System.Drawing.Size(1814, 830);
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.ListView listView1;
    }
}
