namespace HostsFileManager
{
    partial class HostsFileManager
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
            this.enabled = new System.Windows.Forms.ListBox();
            this.disabled = new System.Windows.Forms.ListBox();
            this.newEntryBox = new System.Windows.Forms.GroupBox();
            this.redirectingURI = new System.Windows.Forms.Label();
            this.destination = new System.Windows.Forms.Label();
            this.addEntry = new System.Windows.Forms.Button();
            this.redirectingText = new System.Windows.Forms.TextBox();
            this.destinationText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.disable = new System.Windows.Forms.Button();
            this.enable = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.newEntryBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // enabled
            // 
            this.enabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enabled.FormattingEnabled = true;
            this.enabled.ItemHeight = 29;
            this.enabled.Location = new System.Drawing.Point(16, 74);
            this.enabled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enabled.Name = "enabled";
            this.enabled.Size = new System.Drawing.Size(491, 381);
            this.enabled.TabIndex = 0;
            // 
            // disabled
            // 
            this.disabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disabled.FormattingEnabled = true;
            this.disabled.ItemHeight = 29;
            this.disabled.Location = new System.Drawing.Point(629, 74);
            this.disabled.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disabled.Name = "disabled";
            this.disabled.Size = new System.Drawing.Size(479, 381);
            this.disabled.TabIndex = 1;
            // 
            // newEntryBox
            // 
            this.newEntryBox.Controls.Add(this.redirectingURI);
            this.newEntryBox.Controls.Add(this.destination);
            this.newEntryBox.Controls.Add(this.addEntry);
            this.newEntryBox.Controls.Add(this.redirectingText);
            this.newEntryBox.Controls.Add(this.destinationText);
            this.newEntryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEntryBox.Location = new System.Drawing.Point(16, 507);
            this.newEntryBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newEntryBox.Name = "newEntryBox";
            this.newEntryBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.newEntryBox.Size = new System.Drawing.Size(1093, 146);
            this.newEntryBox.TabIndex = 2;
            this.newEntryBox.TabStop = false;
            this.newEntryBox.Text = "Add New Entry";
            // 
            // redirectingURI
            // 
            this.redirectingURI.AutoSize = true;
            this.redirectingURI.Location = new System.Drawing.Point(464, 49);
            this.redirectingURI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.redirectingURI.Name = "redirectingURI";
            this.redirectingURI.Size = new System.Drawing.Size(183, 29);
            this.redirectingURI.TabIndex = 4;
            this.redirectingURI.Text = "Redirecting URI";
            // 
            // destination
            // 
            this.destination.AutoSize = true;
            this.destination.Location = new System.Drawing.Point(12, 50);
            this.destination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.destination.Name = "destination";
            this.destination.Size = new System.Drawing.Size(228, 29);
            this.destination.TabIndex = 3;
            this.destination.Text = "Destination Address";
            // 
            // addEntry
            // 
            this.addEntry.Location = new System.Drawing.Point(899, 50);
            this.addEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addEntry.Name = "addEntry";
            this.addEntry.Size = new System.Drawing.Size(179, 79);
            this.addEntry.TabIndex = 2;
            this.addEntry.Text = "Add Entry";
            this.addEntry.UseVisualStyleBackColor = true;
            this.addEntry.Click += new System.EventHandler(this.add_Click);
            // 
            // redirectingText
            // 
            this.redirectingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redirectingText.Location = new System.Drawing.Point(467, 89);
            this.redirectingText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.redirectingText.Name = "redirectingText";
            this.redirectingText.Size = new System.Drawing.Size(400, 34);
            this.redirectingText.TabIndex = 1;
            // 
            // destinationText
            // 
            this.destinationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationText.Location = new System.Drawing.Point(19, 89);
            this.destinationText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.destinationText.Name = "destinationText";
            this.destinationText.Size = new System.Drawing.Size(400, 34);
            this.destinationText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enabled Entries";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(628, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Disabled Entries";
            // 
            // disable
            // 
            this.disable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disable.Location = new System.Drawing.Point(521, 174);
            this.disable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.disable.Name = "disable";
            this.disable.Size = new System.Drawing.Size(100, 50);
            this.disable.TabIndex = 7;
            this.disable.Text = ">>";
            this.disable.UseVisualStyleBackColor = true;
            this.disable.Click += new System.EventHandler(this.disable_Click);
            // 
            // enable
            // 
            this.enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable.Location = new System.Drawing.Point(521, 231);
            this.enable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(100, 50);
            this.enable.TabIndex = 8;
            this.enable.Text = "<<";
            this.enable.UseVisualStyleBackColor = true;
            this.enable.Click += new System.EventHandler(this.enable_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(521, 289);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 50);
            this.delete.TabIndex = 9;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // HostsFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 676);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.enable);
            this.Controls.Add(this.disable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newEntryBox);
            this.Controls.Add(this.disabled);
            this.Controls.Add(this.enabled);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HostsFileManager";
            this.Text = "Hosts File Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.newEntryBox.ResumeLayout(false);
            this.newEntryBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox enabled;
        private System.Windows.Forms.ListBox disabled;
        private System.Windows.Forms.GroupBox newEntryBox;
        private System.Windows.Forms.Label redirectingURI;
        private System.Windows.Forms.Label destination;
        private System.Windows.Forms.Button addEntry;
        private System.Windows.Forms.TextBox redirectingText;
        private System.Windows.Forms.TextBox destinationText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button disable;
        private System.Windows.Forms.Button enable;
        private System.Windows.Forms.Button delete;
    }
}

