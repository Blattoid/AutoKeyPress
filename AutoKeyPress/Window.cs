using System;
using System.Threading;
using System.Windows.Forms;

namespace AutoKeyPress
{
    public partial class Window : Form
    {
        Thread DoKeystrokes; //publically accessible DoKeystrokes thread object
        public Window()
        {
            InitializeComponent();

            //setup thread for first usage
            DoKeystrokes = new Thread(execute_keystrokes);

            //load settings into controls
            Tab1_commandinput.Text = Properties.Settings.Default.LastEnteredCommand;
            Tab2_Loop_runonce.Checked = Properties.Settings.Default.Loop_runonce;
            Tab2_Loop_forever.Checked = Properties.Settings.Default.Loop_forever;
            Tab2_Loop_limited.Checked = Properties.Settings.Default.Loop_limited;
            Tab2_Loop_limitinput.Value = Properties.Settings.Default.Loop_maxlimit;
            Tab2_Loop_sleepinput.Value = Properties.Settings.Default.Loop_sleepfor;
            Tab2_StartDelay_input.Value = Properties.Settings.Default.StartDelay;
        }

        //Thread stuff
        void execute_keystrokes()
        {
            //function for sending the keystrokes. this will be in a separate thread from the UI.

            //prevent the commandinput box from being changed while the thread is running
            Invoke(new Action(() => { Tab1_commandinput.Enabled = false; })); //This has to be done inside an invoke because threads cannot control the UI directly.
            //countdown timer
            for (double i = (double)Tab2_StartDelay_input.Value; i > 0.01; i=i-0.1)
            {
                string formattedseconds = i.ToString();
                try { formattedseconds = formattedseconds.Substring(0, 3); }
                catch { }

                Invoke(new Action(() => { StatusBar.Text = formattedseconds + " seconds remaining"; })); //This has to be done inside an invoke because threads cannot control the UI directly.
                Thread.Sleep(100);
            }
            
            //the main attraction
            string data = Tab1_commandinput.Text.Replace(Environment.NewLine, "{ENTER}"); //make newlines work as you would expect
            int loopcount = 1; //start at 1
            for (; ; ) //the "run forever" radio button actually does nothing. that is how i have set this up for simplicity
            {
                Invoke(new Action(() => 
                {
                    //These has to be done inside an invoke because threads cannot control the UI directly.
                    SendKeys.Send(data);  //send the text to the application in focus. This is the namesake of this program.
                    StatusBar.Text = "Running... Injected " + loopcount + " times."; //Update statusbar to show how many times we have looped
                }));
                
                //if we set to only run once, stop here
                if (Tab2_Loop_runonce.Checked) break;
                //check if we have reached the loop limit if we selected that. if so, stop.
                if (Tab2_Loop_limited.Checked && loopcount >= Tab2_Loop_limitinput.Value) break;

                loopcount++; //increment loop counter
                Thread.Sleep((int)Tab2_Loop_sleepinput.Value); //sleep for the amount of time selected
            }

            Invoke(new Action(() =>
            {
                //Stop the thread. This sets DoKeystrokes.isAlive to false and signals the thread is done.
                DoKeystrokes_ABORT(); //This has to be done inside an invoke because the function would exit before it finished if it wasn't.
            }));
        }
        private void ABORTAREA_MouseEnter(object sender, EventArgs e)
        {
            //abort thread in emergency stops.
            DoKeystrokes_ABORT(true);
        }
        void DoKeystrokes_ABORT(bool emergencystop = false)
        {
            //check if the thread is actually running. if so, stop the thread and set everything back up
            if (DoKeystrokes.IsAlive)
            {
                DoKeystrokes.Abort();
                DoKeystrokes = new Thread(execute_keystrokes); //create a new thread ready to go when the current one is done with

                if (emergencystop) StatusBar.Text = "Halted by emergency stop.";
                //else StatusBar.Text = "Idle";

                Tab1_executebtn.Text = "Start";
                Tab1_executebtn.Enabled = true;
                Tab1_commandinput.Enabled = true;
            }
        }

        //Tab 1
        private void Tab1_executebtn_Click(object sender, EventArgs e)
        {
            //triggered when the start button is pressed. it checks if it should stop/start then react accordingly.
            if (DoKeystrokes.IsAlive) { DoKeystrokes_ABORT(); /*run the stop helper function*/ }
            else
            {
                DoKeystrokes.Start();
                Tab1_executebtn.Text = "Stop";
            }
        }

        private void Window_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save setting on close
            Properties.Settings.Default.LastEnteredCommand = Tab1_commandinput.Text;
            Properties.Settings.Default.Loop_runonce = Tab2_Loop_runonce.Checked;
            Properties.Settings.Default.Loop_forever = Tab2_Loop_forever.Checked;
            Properties.Settings.Default.Loop_limited = Tab2_Loop_limited.Checked;
            Properties.Settings.Default.Loop_maxlimit = (int)Tab2_Loop_limitinput.Value;
            Properties.Settings.Default.Loop_sleepfor = (int)Tab2_Loop_sleepinput.Value;
            Properties.Settings.Default.StartDelay = Tab2_StartDelay_input.Value;

            //write changes
            Properties.Settings.Default.Save();
        }
    }
}