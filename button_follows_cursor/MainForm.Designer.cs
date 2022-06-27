
namespace button_follows_cursor
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMoveMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMoveMe
            // 
            this.buttonMoveMe.Location = new System.Drawing.Point(287, 194);
            this.buttonMoveMe.Name = "buttonMoveMe";
            this.buttonMoveMe.Size = new System.Drawing.Size(112, 34);
            this.buttonMoveMe.TabIndex = 0;
            this.buttonMoveMe.Text = "Move Me";
            this.buttonMoveMe.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonMoveMe);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMoveMe;
    }
}

