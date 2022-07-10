
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
            this.is_as_button = new System.Windows.Forms.Button();
            this.idispose_button = new System.Windows.Forms.Button();
            this.check_button = new System.Windows.Forms.Button();
            this.GetType_button = new System.Windows.Forms.Button();
            this.Generics_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            // is_as_button
            // 
            this.is_as_button.Location = new System.Drawing.Point(141, 68);
            this.is_as_button.Name = "is_as_button";
            this.is_as_button.Size = new System.Drawing.Size(94, 29);
            this.is_as_button.TabIndex = 2;
            this.is_as_button.Text = "is_as";
            this.is_as_button.UseVisualStyleBackColor = true;
            this.is_as_button.Click += new System.EventHandler(this.is_as_button_Click);
            // 
            // idispose_button
            // 
            this.idispose_button.Location = new System.Drawing.Point(255, 68);
            this.idispose_button.Name = "idispose_button";
            this.idispose_button.Size = new System.Drawing.Size(94, 29);
            this.idispose_button.TabIndex = 3;
            this.idispose_button.Text = "iDispose";
            this.idispose_button.UseVisualStyleBackColor = true;
            this.idispose_button.Click += new System.EventHandler(this.idispose_button_Click);
            // 
            // check_button
            // 
            this.check_button.Location = new System.Drawing.Point(27, 68);
            this.check_button.Name = "check_button";
            this.check_button.Size = new System.Drawing.Size(94, 29);
            this.check_button.TabIndex = 4;
            this.check_button.Text = "check";
            this.check_button.UseVisualStyleBackColor = true;
            this.check_button.Click += new System.EventHandler(this.check_button_Click);
            // 
            // GetType_button
            // 
            this.GetType_button.Location = new System.Drawing.Point(374, 68);
            this.GetType_button.Name = "GetType_button";
            this.GetType_button.Size = new System.Drawing.Size(94, 29);
            this.GetType_button.TabIndex = 5;
            this.GetType_button.Text = "GetType";
            this.GetType_button.UseVisualStyleBackColor = true;
            this.GetType_button.Click += new System.EventHandler(this.GetType_button_Click);
            // 
            // Generics_button
            // 
            this.Generics_button.Location = new System.Drawing.Point(494, 68);
            this.Generics_button.Name = "Generics_button";
            this.Generics_button.Size = new System.Drawing.Size(94, 29);
            this.Generics_button.TabIndex = 6;
            this.Generics_button.Text = "Generics";
            this.Generics_button.UseVisualStyleBackColor = true;
            this.Generics_button.Click += new System.EventHandler(this.Generics_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "JSON Ser - Deser";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Generics_button);
            this.Controls.Add(this.GetType_button);
            this.Controls.Add(this.check_button);
            this.Controls.Add(this.idispose_button);
            this.Controls.Add(this.is_as_button);
            this.Controls.Add(this.events);
            this.Controls.Add(this.delegate_button);
            this.Name = "Form1";
            this.Text = "CSharpGym";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delegate_button;
        private System.Windows.Forms.Button events;
        private System.Windows.Forms.Button is_as_button;
        private System.Windows.Forms.Button idispose_button;
        private System.Windows.Forms.Button check_button;
        private System.Windows.Forms.Button GetType_button;
        private System.Windows.Forms.Button Generics_button;
        private System.Windows.Forms.Button button1;
    }
}