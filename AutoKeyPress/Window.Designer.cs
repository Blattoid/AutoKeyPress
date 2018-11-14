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
            this.Tab1_commandinput = new System.Windows.Forms.TextBox();
            this.Tab1_executebtn = new System.Windows.Forms.Button();
            this.StatusBar = new System.Windows.Forms.Label();
            this.ABORTAREA = new System.Windows.Forms.TextBox();
            this.TabHolder = new System.Windows.Forms.TabControl();
            this.Tab1 = new System.Windows.Forms.TabPage();
            this.Tab2 = new System.Windows.Forms.TabPage();
            this.Tab2_LoopGroup = new System.Windows.Forms.GroupBox();
            this.Tab2_Loop_sleepinputlabel = new System.Windows.Forms.Label();
            this.Tab2_Loop_sleepinput = new System.Windows.Forms.NumericUpDown();
            this.Tab2_Loop_limitinput = new System.Windows.Forms.NumericUpDown();
            this.Tab2_Loop_runonce = new System.Windows.Forms.RadioButton();
            this.Tab2_Loop_limited = new System.Windows.Forms.RadioButton();
            this.Tab2_Loop_forever = new System.Windows.Forms.RadioButton();
            this.Tab2_StartDelay_input = new System.Windows.Forms.NumericUpDown();
            this.Tab2_StartDelay_inputlabel = new System.Windows.Forms.Label();
            this.TabHolder.SuspendLayout();
            this.Tab1.SuspendLayout();
            this.Tab2.SuspendLayout();
            this.Tab2_LoopGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab2_Loop_sleepinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab2_Loop_limitinput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab2_StartDelay_input)).BeginInit();
            this.SuspendLayout();
            // 
            // Tab1_commandinput
            // 
            this.Tab1_commandinput.Dock = System.Windows.Forms.DockStyle.Top;
            this.Tab1_commandinput.Location = new System.Drawing.Point(3, 3);
            this.Tab1_commandinput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab1_commandinput.Multiline = true;
            this.Tab1_commandinput.Name = "Tab1_commandinput";
            this.Tab1_commandinput.Size = new System.Drawing.Size(589, 328);
            this.Tab1_commandinput.TabIndex = 0;
            // 
            // Tab1_executebtn
            // 
            this.Tab1_executebtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Tab1_executebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tab1_executebtn.Location = new System.Drawing.Point(3, 341);
            this.Tab1_executebtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab1_executebtn.Name = "Tab1_executebtn";
            this.Tab1_executebtn.Size = new System.Drawing.Size(589, 82);
            this.Tab1_executebtn.TabIndex = 1;
            this.Tab1_executebtn.Text = "Start";
            this.Tab1_executebtn.UseVisualStyleBackColor = true;
            this.Tab1_executebtn.Click += new System.EventHandler(this.Tab1_executebtn_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.AutoSize = true;
            this.StatusBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusBar.Location = new System.Drawing.Point(13, 462);
            this.StatusBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(43, 25);
            this.StatusBar.TabIndex = 2;
            this.StatusBar.Text = "Idle";
            // 
            // ABORTAREA
            // 
            this.ABORTAREA.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ABORTAREA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ABORTAREA.Location = new System.Drawing.Point(0, 490);
            this.ABORTAREA.Multiline = true;
            this.ABORTAREA.Name = "ABORTAREA";
            this.ABORTAREA.ReadOnly = true;
            this.ABORTAREA.Size = new System.Drawing.Size(603, 72);
            this.ABORTAREA.TabIndex = 3;
            this.ABORTAREA.Text = "\r\nPut mouse in here to abort!";
            this.ABORTAREA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ABORTAREA.MouseEnter += new System.EventHandler(this.ABORTAREA_MouseEnter);
            // 
            // TabHolder
            // 
            this.TabHolder.Controls.Add(this.Tab1);
            this.TabHolder.Controls.Add(this.Tab2);
            this.TabHolder.Dock = System.Windows.Forms.DockStyle.Top;
            this.TabHolder.Location = new System.Drawing.Point(0, 0);
            this.TabHolder.Name = "TabHolder";
            this.TabHolder.SelectedIndex = 0;
            this.TabHolder.Size = new System.Drawing.Size(603, 459);
            this.TabHolder.TabIndex = 4;
            // 
            // Tab1
            // 
            this.Tab1.BackColor = System.Drawing.SystemColors.Control;
            this.Tab1.Controls.Add(this.Tab1_commandinput);
            this.Tab1.Controls.Add(this.Tab1_executebtn);
            this.Tab1.Location = new System.Drawing.Point(4, 29);
            this.Tab1.Name = "Tab1";
            this.Tab1.Padding = new System.Windows.Forms.Padding(3);
            this.Tab1.Size = new System.Drawing.Size(595, 426);
            this.Tab1.TabIndex = 0;
            this.Tab1.Text = "Main";
            // 
            // Tab2
            // 
            this.Tab2.BackColor = System.Drawing.SystemColors.Control;
            this.Tab2.Controls.Add(this.Tab2_StartDelay_inputlabel);
            this.Tab2.Controls.Add(this.Tab2_StartDelay_input);
            this.Tab2.Controls.Add(this.Tab2_LoopGroup);
            this.Tab2.Location = new System.Drawing.Point(4, 29);
            this.Tab2.Name = "Tab2";
            this.Tab2.Padding = new System.Windows.Forms.Padding(3);
            this.Tab2.Size = new System.Drawing.Size(595, 426);
            this.Tab2.TabIndex = 1;
            this.Tab2.Text = "Settings";
            // 
            // Tab2_LoopGroup
            // 
            this.Tab2_LoopGroup.Controls.Add(this.Tab2_Loop_sleepinputlabel);
            this.Tab2_LoopGroup.Controls.Add(this.Tab2_Loop_sleepinput);
            this.Tab2_LoopGroup.Controls.Add(this.Tab2_Loop_limitinput);
            this.Tab2_LoopGroup.Controls.Add(this.Tab2_Loop_runonce);
            this.Tab2_LoopGroup.Controls.Add(this.Tab2_Loop_limited);
            this.Tab2_LoopGroup.Controls.Add(this.Tab2_Loop_forever);
            this.Tab2_LoopGroup.Location = new System.Drawing.Point(8, 6);
            this.Tab2_LoopGroup.Name = "Tab2_LoopGroup";
            this.Tab2_LoopGroup.Size = new System.Drawing.Size(171, 274);
            this.Tab2_LoopGroup.TabIndex = 3;
            this.Tab2_LoopGroup.TabStop = false;
            this.Tab2_LoopGroup.Text = "Looping Options";
            // 
            // Tab2_Loop_sleepinputlabel
            // 
            this.Tab2_Loop_sleepinputlabel.AutoSize = true;
            this.Tab2_Loop_sleepinputlabel.Location = new System.Drawing.Point(6, 192);
            this.Tab2_Loop_sleepinputlabel.Name = "Tab2_Loop_sleepinputlabel";
            this.Tab2_Loop_sleepinputlabel.Size = new System.Drawing.Size(156, 40);
            this.Tab2_Loop_sleepinputlabel.TabIndex = 5;
            this.Tab2_Loop_sleepinputlabel.Text = "Delay between loops\r\n(in milliseconds)\r\n";
            // 
            // Tab2_Loop_sleepinput
            // 
            this.Tab2_Loop_sleepinput.Location = new System.Drawing.Point(6, 235);
            this.Tab2_Loop_sleepinput.Maximum = new decimal(new int[] {
            2147483645,
            0,
            0,
            0});
            this.Tab2_Loop_sleepinput.Name = "Tab2_Loop_sleepinput";
            this.Tab2_Loop_sleepinput.Size = new System.Drawing.Size(159, 26);
            this.Tab2_Loop_sleepinput.TabIndex = 4;
            // 
            // Tab2_Loop_limitinput
            // 
            this.Tab2_Loop_limitinput.Location = new System.Drawing.Point(6, 121);
            this.Tab2_Loop_limitinput.Maximum = new decimal(new int[] {
            2147483645,
            0,
            0,
            0});
            this.Tab2_Loop_limitinput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Tab2_Loop_limitinput.Name = "Tab2_Loop_limitinput";
            this.Tab2_Loop_limitinput.Size = new System.Drawing.Size(159, 26);
            this.Tab2_Loop_limitinput.TabIndex = 3;
            this.Tab2_Loop_limitinput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Tab2_Loop_runonce
            // 
            this.Tab2_Loop_runonce.AutoSize = true;
            this.Tab2_Loop_runonce.Checked = true;
            this.Tab2_Loop_runonce.Location = new System.Drawing.Point(6, 25);
            this.Tab2_Loop_runonce.Name = "Tab2_Loop_runonce";
            this.Tab2_Loop_runonce.Size = new System.Drawing.Size(103, 24);
            this.Tab2_Loop_runonce.TabIndex = 2;
            this.Tab2_Loop_runonce.TabStop = true;
            this.Tab2_Loop_runonce.Text = "Run once";
            this.Tab2_Loop_runonce.UseVisualStyleBackColor = true;
            // 
            // Tab2_Loop_limited
            // 
            this.Tab2_Loop_limited.AutoSize = true;
            this.Tab2_Loop_limited.Location = new System.Drawing.Point(6, 91);
            this.Tab2_Loop_limited.Name = "Tab2_Loop_limited";
            this.Tab2_Loop_limited.Size = new System.Drawing.Size(128, 24);
            this.Tab2_Loop_limited.TabIndex = 1;
            this.Tab2_Loop_limited.Text = "Run __ times";
            this.Tab2_Loop_limited.UseVisualStyleBackColor = true;
            // 
            // Tab2_Loop_forever
            // 
            this.Tab2_Loop_forever.AutoSize = true;
            this.Tab2_Loop_forever.Location = new System.Drawing.Point(6, 49);
            this.Tab2_Loop_forever.Name = "Tab2_Loop_forever";
            this.Tab2_Loop_forever.Size = new System.Drawing.Size(117, 24);
            this.Tab2_Loop_forever.TabIndex = 0;
            this.Tab2_Loop_forever.Text = "Run forever";
            this.Tab2_Loop_forever.UseVisualStyleBackColor = true;
            // 
            // Tab2_StartDelay_input
            // 
            this.Tab2_StartDelay_input.DecimalPlaces = 1;
            this.Tab2_StartDelay_input.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Tab2_StartDelay_input.Location = new System.Drawing.Point(189, 29);
            this.Tab2_StartDelay_input.Maximum = new decimal(new int[] {
            2147483645,
            0,
            0,
            0});
            this.Tab2_StartDelay_input.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Tab2_StartDelay_input.Name = "Tab2_StartDelay_input";
            this.Tab2_StartDelay_input.Size = new System.Drawing.Size(159, 26);
            this.Tab2_StartDelay_input.TabIndex = 6;
            this.Tab2_StartDelay_input.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Tab2_StartDelay_inputlabel
            // 
            this.Tab2_StartDelay_inputlabel.AutoSize = true;
            this.Tab2_StartDelay_inputlabel.Location = new System.Drawing.Point(185, 6);
            this.Tab2_StartDelay_inputlabel.Name = "Tab2_StartDelay_inputlabel";
            this.Tab2_StartDelay_inputlabel.Size = new System.Drawing.Size(216, 20);
            this.Tab2_StartDelay_inputlabel.TabIndex = 6;
            this.Tab2_StartDelay_inputlabel.Text = "Delay once started (seconds)";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 562);
            this.Controls.Add(this.TabHolder);
            this.Controls.Add(this.ABORTAREA);
            this.Controls.Add(this.StatusBar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Window";
            this.Text = "Auto Key Presser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_FormClosing);
            this.TabHolder.ResumeLayout(false);
            this.Tab1.ResumeLayout(false);
            this.Tab1.PerformLayout();
            this.Tab2.ResumeLayout(false);
            this.Tab2.PerformLayout();
            this.Tab2_LoopGroup.ResumeLayout(false);
            this.Tab2_LoopGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab2_Loop_sleepinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab2_Loop_limitinput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab2_StartDelay_input)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tab1_commandinput;
        private System.Windows.Forms.Button Tab1_executebtn;
        private System.Windows.Forms.Label StatusBar;
        private System.Windows.Forms.TextBox ABORTAREA;
        private System.Windows.Forms.TabControl TabHolder;
        private System.Windows.Forms.TabPage Tab1;
        private System.Windows.Forms.TabPage Tab2;
        private System.Windows.Forms.GroupBox Tab2_LoopGroup;
        private System.Windows.Forms.NumericUpDown Tab2_Loop_limitinput;
        private System.Windows.Forms.RadioButton Tab2_Loop_runonce;
        private System.Windows.Forms.RadioButton Tab2_Loop_limited;
        private System.Windows.Forms.RadioButton Tab2_Loop_forever;
        private System.Windows.Forms.NumericUpDown Tab2_Loop_sleepinput;
        private System.Windows.Forms.Label Tab2_Loop_sleepinputlabel;
        private System.Windows.Forms.Label Tab2_StartDelay_inputlabel;
        private System.Windows.Forms.NumericUpDown Tab2_StartDelay_input;
    }
}

