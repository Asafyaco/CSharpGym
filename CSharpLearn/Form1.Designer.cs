
namespace CSharpGym
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
            this.delegate_button = new System.Windows.Forms.Button();
            this.events = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // delegate_button
            // 
            this.delegate_button.Location = new System.Drawing.Point(27, 21);
            this.delegate_button.Name = "delegate_button";
            this.delegate_button.Size = new System.Drawing.Size(94, 29);
            this.delegate_button.TabIndex = 0;
            this.delegate_button.Text = "delegate";
            this.delegate_button.UseVisualStyleBackColor = true;
            this.delegate_button.Click += new System.EventHandler(this.delegate_button_Click);
            // 
            // events
            // 
            this.events.Location = new System.Drawing.Point(141, 21);
            this.events.Name = "events";
            this.events.Size = new System.Drawing.Size(94, 29);
            this.events.TabIndex = 1;
            this.events.Text = "Events";
            this.events.UseVisualStyleBackColor = true;
            this.events.Click += new System.EventHandler(this.events_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.events);
            this.Controls.Add(this.delegate_button);
            this.Name = "Form1";
            this.Text = "CSharpGym";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delegate_button;
        private System.Windows.Forms.Button events;
    }
}