namespace AutoKeyPress
{
    partial class Window
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
            this.command_input = new System.Windows.Forms.TextBox();
            this.execute_btn = new System.Windows.Forms.Button();
            this.timer_display = new System.Windows.Forms.Label();
            this.ABORTAREA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // command_input
            // 
            this.command_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.command_input.Location = new System.Drawing.Point(18, 18);
            this.command_input.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.command_input.Multiline = true;
            this.command_input.Name = "command_input";
            this.command_input.Size = new System.Drawing.Size(388, 164);
            this.command_input.TabIndex = 0;
            // 
            // execute_btn
            // 
            this.execute_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.execute_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.execute_btn.Location = new System.Drawing.Point(18, 194);
            this.execute_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.execute_btn.Name = "execute_btn";
            this.execute_btn.Size = new System.Drawing.Size(390, 52);
            this.execute_btn.TabIndex = 1;
            this.execute_btn.Text = "Start";
            this.execute_btn.UseVisualStyleBackColor = true;
            this.execute_btn.Click += new System.EventHandler(this.execute_btn_Click);
            // 
            // timer_display
            // 
            this.timer_display.AutoSize = true;
            this.timer_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_display.Location = new System.Drawing.Point(17, 251);
            this.timer_display.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timer_display.Name = "timer_display";
            this.timer_display.Size = new System.Drawing.Size(43, 25);
            this.timer_display.TabIndex = 2;
            this.timer_display.Text = "Idle";
            // 
            // ABORTAREA
            // 
            this.ABORTAREA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ABORTAREA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABORTAREA.Location = new System.Drawing.Point(22, 320);
            this.ABORTAREA.Multiline = true;
            this.ABORTAREA.Name = "ABORTAREA";
            this.ABORTAREA.ReadOnly = true;
            this.ABORTAREA.Size = new System.Drawing.Size(384, 70);
            this.ABORTAREA.TabIndex = 3;
            this.ABORTAREA.Text = "\r\nPut mouse in here to abort!";
            this.ABORTAREA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ABORTAREA.MouseEnter += new System.EventHandler(this.ABORTAREA_MouseEnter);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 402);
            this.Controls.Add(this.ABORTAREA);
            this.Controls.Add(this.timer_display);
            this.Controls.Add(this.execute_btn);
            this.Controls.Add(this.command_input);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Window";
            this.Text = "Auto Key Presser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox command_input;
        private System.Windows.Forms.Button execute_btn;
        private System.Windows.Forms.Label timer_display;
        private System.Windows.Forms.TextBox ABORTAREA;
    }
}

