
namespace RubberDuck
{
    partial class RubberDuck
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RubberDuck));
            this.textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel_header = new System.Windows.Forms.Panel();
            this.Info = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.duck_icon = new System.Windows.Forms.PictureBox();
            this.messages = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duck_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox.Font = new System.Drawing.Font("Consolas", 12F);
            this.textBox.Location = new System.Drawing.Point(0, 296);
            this.textBox.Margin = new System.Windows.Forms.Padding(0);
            this.textBox.MaxLength = 35;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(327, 31);
            this.textBox.TabIndex = 1;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(298, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 2;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "duck_debugging_icon.ico");
            this.imageList.Images.SetKeyName(1, "icons8-send-letter-96.png");
            this.imageList.Images.SetKeyName(2, "icons8-macos-close-96.png");
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_header.Controls.Add(this.Info);
            this.panel_header.Controls.Add(this.label1);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(327, 29);
            this.panel_header.TabIndex = 3;
            this.panel_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseDown);
            this.panel_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseMove);
            this.panel_header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_header_MouseUp);
            // 
            // Info
            // 
            this.Info.BackColor = System.Drawing.SystemColors.Control;
            this.Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Info.BackgroundImage")));
            this.Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Info.FlatAppearance.BorderSize = 0;
            this.Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info.ForeColor = System.Drawing.Color.Transparent;
            this.Info.Location = new System.Drawing.Point(269, 0);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(29, 29);
            this.Info.TabIndex = 3;
            this.Info.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Info.UseVisualStyleBackColor = false;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "RubberDuck";
            // 
            // duck_icon
            // 
            this.duck_icon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.duck_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("duck_icon.BackgroundImage")));
            this.duck_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.duck_icon.Enabled = false;
            this.duck_icon.Location = new System.Drawing.Point(0, 0);
            this.duck_icon.Name = "duck_icon";
            this.duck_icon.Size = new System.Drawing.Size(29, 29);
            this.duck_icon.TabIndex = 4;
            this.duck_icon.TabStop = false;
            // 
            // messages
            // 
            this.messages.AutoScroll = true;
            this.messages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.messages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messages.Location = new System.Drawing.Point(0, 29);
            this.messages.Name = "messages";
            this.messages.Size = new System.Drawing.Size(327, 267);
            this.messages.TabIndex = 5;
            this.messages.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.messages_ControlAdded);
            // 
            // RubberDuck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(327, 327);
            this.ControlBox = false;
            this.Controls.Add(this.messages);
            this.Controls.Add(this.duck_icon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panel_header);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RubberDuck";
            this.Text = "RubberDuck";
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duck_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox;
        public System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox duck_icon;
        private System.Windows.Forms.Panel messages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Info;
    }
}

