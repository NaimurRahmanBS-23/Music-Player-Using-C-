namespace MusciPlayerApp
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.list = new System.Windows.Forms.ListBox();
            this.select = new System.Windows.Forms.Button();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.ItemHeight = 20;
            this.list.Location = new System.Drawing.Point(612, 41);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(176, 364);
            this.list.TabIndex = 0;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.SystemColors.ControlDark;
            this.select.Location = new System.Drawing.Point(612, 442);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(145, 59);
            this.select.TabIndex = 2;
            this.select.Text = "Select Song";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // player
            // 
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(35, 21);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(341, 300);
            this.player.TabIndex = 1;
            this.player.Enter += new System.EventHandler(this.player_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.select);
            this.Controls.Add(this.player);
            this.Controls.Add(this.list);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list;
        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Button select;
    }
}

