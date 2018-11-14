using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeyPress
{
    public partial class Window : Form
    {
        bool is_running = false;
        Thread DoKeystrokes;

        public Window()
        {
            InitializeComponent();
             DoKeystrokes = new Thread(execute_keystrokes); 
        }

        private void execute_btn_Click(object sender, EventArgs e)
        {
            if (is_running)
            {
                DoKeystrokes.Abort();
                DoKeystrokes = new Thread(execute_keystrokes);
                execute_btn.Text = "Start";
            }
            else
            {
                DoKeystrokes.Start();
                execute_btn.Text = "Stop";
            }
        }

        void execute_keystrokes()
        {
            is_running = true;
            for (int i = 5; i > 0; i--)
            {
                Invoke(new Action(() => { timer_display.Text = i+" seconds remaining"; }));
                Thread.Sleep(1000);
            }
            Invoke(new Action(() =>
            {
                timer_display.Text = "0 seconds remaining";
            }));

            string data = command_input.Text.Replace(Environment.NewLine, "");
            Invoke(new Action(() => { SendKeys.Send(data); })); 
            
            is_running = false;
        }

        private void ABORTAREA_MouseEnter(object sender, EventArgs e)
        {
            if (is_running)
            {
                DoKeystrokes.Abort();
                DoKeystrokes = new Thread(execute_keystrokes);
                timer_display.Text = "ABORTED";
                execute_btn.Text = "Start";
            }
        }
    }
}
