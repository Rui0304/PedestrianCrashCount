using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        int cnt = 1;

        public Form1()
        {
            InitializeComponent();
            // StartPosition was set to FormStartPosition.Manual in the properties window.

            //Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            //int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            //int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            //this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            //this.Size = new Size(w, h);

            //this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // code to make sure all crash 1 area have comboBox checked

            // Hit and run
            if (comboBox1.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Hit and run is not selected.");
                return;
            }

            // Location kind
            if (comboBox14.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Location kind is not selected.");
                return;
            }

            // Location type
            if (comboBox15.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Location type is not selected.");
                return;
            }

            // Road type
            if (comboBox16.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Road type is not selected.");
                return;
            }

            // Highway type
            if (comboBox2.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Highway type is not selected.");
                return;
            }

            // Alignment
            if (comboBox3.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Alignment is not selected.");
                return;
            }

            // Functional class
            //if (comboBox4.SelectedIndex > -1)
            //{
            //}
            //else
            //{
                //MessageBox.Show("Functional class is not selected.");
                //return;
            //}

            // Highway class
            if (comboBox5.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Highway class is not selected.");
                return;
            }

            // Traffic control
            if (comboBox6.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Traffic control is not selected.");
                return;
            }

            // Traffic control condition
            if (comboBox7.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Traffic control condition is not selected.");
                return;
            }

            // Lighting
            if (comboBox17.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Lighting is not selected.");
                return;
            }

            // Surface condition
            if (comboBox18.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Surface condition is not selected.");
                return;
            }

            //Weather
            if (comboBox19.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Weather is not selected.");
                return;
            }

            //Crash type
            if (comboBox8.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Crash type is not selected.");
                return;
            }

            //Roadway relation
            if (comboBox9.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Roadway relation is not selected.");
                return;
            }

            //Collision manner
            if (comboBox10.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Collision manner is not selected.");
                return;
            }

            //Pedestrian gender
            if (comboBox11.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Pedestrian gender is not selected.");
                return;
            }

            //Pedestrian ingury
            if (comboBox12.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Pedestrian injury is not selected.");
                return;
            }

            //Pedestrian action
            if (comboBox13.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Pedestrian action is not selected.");
                return;
            }

            // Driver gender
            if (comboBox20.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Driver gender is not selected.");
                return;
            }

            //Driver Condition
            if (comboBox24.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Driver condition is not selected.");
                return;
            }

            // Driver distraction
            if (comboBox21.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Driver distraction is not selected.");
                return;
            }

            // Driver injury
            //if (comboBox22.SelectedIndex > -1)
            //{
            //}
            //else
            //{
             //   MessageBox.Show("Driver injury is not selected.");
            //    return;
            //}

            // Driver violation
            if (comboBox23.SelectedIndex > -1)
            {
            }
            else
            {
                MessageBox.Show("Driver violation is not selected.");
                return;
            }

            cnt = cnt + 1;  //we for sure are going to send one crash to db

            label35.Text = "Count " + Convert.ToString(cnt);

            //sql db users are setup based on windows login where the application is installed
            //windows login must be a user on this database in sql server
            SqlConnection db = new SqlConnection("Data Source=ITSLAB-SERVER;Initial Catalog=Non_Motorized_Users;Integrated Security=True");
            db.Open();

            // Set vriables' values by selectedItem in each Combobox
            String hitArun = null, lockind = null, loctype = null, rdtype = null, hywtype = null, alignment = null, hywclass = null, tracontrol = null, traControlCondition = null, lighting = null, surfcondition = null, weather = null, cratype = null, rdwrelation = null, colmanner = null, pedgender = null, pedinjury = null, pedaction = null, drigender = null, dricondition = null, dridistraction = null, driviolation = null, adt = null, speedlmt = null;

            hitArun = comboBox1.SelectedItem.ToString();

            lockind = comboBox14.SelectedItem.ToString();

            loctype = comboBox15.SelectedItem.ToString();

            rdtype = comboBox16.SelectedItem.ToString();

            hywtype = comboBox2.SelectedItem.ToString();

            alignment = comboBox3.SelectedItem.ToString();

            //funcclass = comboBox4.SelectedItem.ToString();

            hywclass = comboBox5.SelectedItem.ToString();

            tracontrol = comboBox6.SelectedItem.ToString();

            traControlCondition = comboBox7.SelectedItem.ToString();

            lighting = comboBox17.SelectedItem.ToString();

            surfcondition = comboBox18.SelectedItem.ToString();

            weather = comboBox19.SelectedItem.ToString();

            cratype = comboBox8.SelectedItem.ToString();

            rdwrelation = comboBox9.SelectedItem.ToString();

            colmanner = comboBox10.SelectedItem.ToString(); 

            pedgender = comboBox11.SelectedItem.ToString();

            pedinjury = comboBox12.SelectedItem.ToString();

            pedaction = comboBox13.SelectedItem.ToString();

            drigender = comboBox20.SelectedItem.ToString();

            dricondition = comboBox24.SelectedItem.ToString();

            dridistraction = comboBox21.SelectedItem.ToString();

            //driinjury = comboBox22.SelectedItem.ToString();

            driviolation = comboBox23.SelectedItem.ToString();

            //Set variables' values of each textbox

            //float f = float.Parse(TextBox1.Text);
            string cranum = textBox1.Text;

            string datecra = maskedTextBox1.Text;

            string timecra = maskedTextBox2.Text;

            float longitude = float.Parse(textBox4.Text);

            float latitude = float.Parse(textBox5.Text);

            // ADT
            if (textBox8.Text == "")
            {
                 adt = "Unknown";
            }
            else
            {
                adt = textBox8.Text;
            }

            //int adt = int.Parse(textBox8.Text);

            //Speedlimit

            //int speedlmt = int.Parse(textBox9.Text);
            if (textBox9.Text == "")
            {
                 speedlmt = "Unknown";
            }
            else
            {
                speedlmt = textBox9.Text;
            }



            int pedage = int.Parse(textBox6.Text);

            int driage = int.Parse(textBox7.Text);

            string date_entered = DateTime.Now.ToString("g");

            string user = Environment.UserName;

            SqlCommand cmd = new SqlCommand("", db);

            cmd.CommandText = String.Format("insert into pedestrians (CrashNumber, CrashDate, CrashTime, HitandRun, LocationKind, LocationType, RoadType, Longitude, Latitude, HighwayType, Alignment, HighwayClass, TrafficControl, TrafficControlCondition, ADT, SpeedLimit, Lighting, SurfaceCondition, Weather, CrashType, RoadRelation, CollisionManner, PedestrianAge, PedestrianGender, PedestrianInjury, PedestrianAction, DriverAge, DriverGender, DriverCondition, DriverDistraction, DriverViolation, username, DateEntered) values(\'{0}\',\'{1}\',\'{2}\',\'{3}\',\'{4}\',\'{5}\',\'{6}\',\'{7}\',\'{8}\',\'{9}\',\'{10}\',\'{11}\',\'{12}\',\'{13}\',\'{14}\',\'{15}\',\'{16}\',\'{17}\',\'{18}\',\'{19}\',\'{20}\',\'{21}\',\'{22}\',\'{23}\',\'{24}\',\'{25}\',\'{26}\',\'{27}\',\'{28}\',\'{29}\',\'{30}\',\'{31}\',\'{32}\')", cranum, datecra, timecra, hitArun, lockind, loctype, rdtype, longitude, latitude, hywtype, alignment, hywclass, tracontrol, traControlCondition, adt, speedlmt, lighting, surfcondition, weather, cratype, rdwrelation, colmanner, pedage, pedgender, pedinjury, pedaction, driage, drigender, dricondition, dridistraction, driviolation, user, date_entered);
            cmd.ExecuteScalar();
            db.Close();

            this.Controls.ClearControls();
            comboBox1.SelectedIndex = -1;
            comboBox14.SelectedIndex = -1;
            comboBox15.SelectedIndex = -1;
            comboBox16.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            //comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox17.SelectedIndex = -1;
            comboBox18.SelectedIndex = -1;
            comboBox19.SelectedIndex = -1;
            comboBox8.SelectedIndex = -1;
            comboBox9.SelectedIndex = -1;
            comboBox10.SelectedIndex = -1;
            comboBox11.SelectedIndex = -1;
            comboBox12.SelectedIndex = -1;
            comboBox13.SelectedIndex = -1;
            comboBox20.SelectedIndex = -1;
            comboBox21.SelectedIndex = -1;
            //comboBox22.SelectedIndex = -1;
            comboBox23.SelectedIndex = -1;
            comboBox24.SelectedIndex = -1;
            maskedTextBox1.Clear();
            maskedTextBox2.Clear();

        }


        

        

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            maskedTextBox1.SelectionStart = 0;
        }
    }

    public static class extenstions
    {
        private static Dictionary<Type, Action<Control>> controldefaults = new Dictionary<Type, Action<Control>>() {
            {typeof(TextBox), c => ((TextBox)c).Clear()},
            {typeof(CheckBox), c => ((CheckBox)c).Checked = false},
            {typeof(ListBox), c => ((ListBox)c).Items.Clear()},
            {typeof(RadioButton), c => ((RadioButton)c).Checked = false},
            {typeof(GroupBox), c => ((GroupBox)c).Controls.ClearControls()},
            {typeof(Panel), c => ((Panel)c).Controls.ClearControls()}
    };

        private static void FindAndInvoke(Type type, Control control)
        {
            if (controldefaults.ContainsKey(type))
            {
                controldefaults[type].Invoke(control);
            }
        }

        public static void ClearControls(this Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                FindAndInvoke(control.GetType(), control);
            }
        }

        public static void ClearControls<T>(this Control.ControlCollection controls) where T : class
        {
            if (!controldefaults.ContainsKey(typeof(T))) return;

            foreach (Control control in controls)
            {
                if (control.GetType().Equals(typeof(T)))
                {
                    FindAndInvoke(typeof(T), control);
                }
            }

        }

    }

}
