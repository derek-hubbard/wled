using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WLED_Controller
{

    public partial class Form1 : Form
    {
        string url;
        string html;
        int fx;
        bool checkIP;
        string source;
        string data;
        string data1;
        string html1;
        string path;

        //color picker
        byte R;
        byte G;
        byte B;

        public Form1()
        {
            InitializeComponent();

            path = Directory.GetCurrentDirectory() + "\\ControllerList.config";
            log.AppendText(Environment.NewLine + path);
            if (File.Exists(path))
            {
                string[] controllerList = null;
                controllerList = System.IO.File.ReadAllLines(path);
                foreach (string service in controllerList)
                {
                    listBox1.Items.Add(service);
                    comboBox2.Items.Add(service);
                }
            }
            else
            {

            }

            log.Text = Environment.NewLine + DateTime.Now + ": ****App Started Version 1.0****";

            if (listBox1.Items.Count != 0)
            {
                comboBox2.SelectedIndex = 0;
            }
            presetList.SelectedIndex = 0;
        }

        private void poweron_Click(object sender, EventArgs e)
        {
            Sender(comboBox2.Text, "&T=1");
            GetInfo();
        }

        private void poweroff_Click(object sender, EventArgs e)
        {
            Sender(comboBox2.Text, "&T=0");
            bightness.Value = 0;
            label1.Text = "0";
            Speed.Value = 0;
            speedValue.Text = "0";
            Intensity.Value = 0;
            intensityValue.Text = "0";
            comboBox1.SelectedIndex = 0;
            pictureBox1.Image = null;
        }

        private void bightness_Scroll(object sender, EventArgs e)
        {
            Sender(comboBox2.Text, "&A=" + bightness.Value);
            label1.Text = bightness.Value.ToString();
            Refresh();
        }

        private void Effect()
        {
            Sender(comboBox2.Text, "&FX=" + fx);

            try
            {
                pictureBox1.Load(@"https://github.com/photocromax/WLED-live-visualizations/raw/master/GIF/FX_" + fx + ".gif");
            }
            catch
            {
                pictureBox1.Image = null;
            }
        }

        private void Color()
        {
            Sender(comboBox2.Text, "&R=" + R + "&G=" + G + "&B=" + B);
        }

        private void colorpicker_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();

            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                Color color = colorPicker.Color;
                R = color.R;
                G = color.G;
                B = color.B;
                rgbText.Text = "R= " + R + " G= " + G + " B= " + B;

                colorBox.BackColor = colorPicker.Color;
                Color();
            }

        }

        public static string getBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }

            return "";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listBox1.Items.Count != 0)
            {
                List<string> MyList = listBox1.Items.Cast<string>().ToList();
                File.WriteAllLines(path, MyList);
            }

        }

        private void ValidateIP()
        {
            checkIP = IPAddress.TryParse(ipAddress.Text, out System.Net.IPAddress address);
        }

        private void ipAdd_Click(object sender, EventArgs e)
        {
            ValidateIP();
            if (checkIP)
            {
                listBox1.Items.Add(ipAddress.Text);
                comboBox2.Items.Add(ipAddress.Text);
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Please Enter Vaild IP", "IP Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ipRemove_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Remove(listBox1.SelectedItem);
            try
            {
                comboBox2.SelectedIndex = 0;
            }
            catch
            {
                comboBox2.Text = "";
            }
            listBox1.Items.Remove(listBox1.SelectedItem);
            comboBox2.Refresh();
        }

        private void Sender(string ipa, string command)
        {
            if (syncEnable.Checked)
            {
                foreach (string ip in listBox1.Items)
                {

                    html = string.Empty;
                    url = @"http://" + ip + "/win" + command;
                    log.AppendText(Environment.NewLine + DateTime.Now + ": " + url);
                    try
                    {
                        HttpWebRequest syncrequest = (HttpWebRequest)WebRequest.Create(url);
                        syncrequest.AutomaticDecompression = DecompressionMethods.GZip;

                        using (HttpWebResponse response = (HttpWebResponse)syncrequest.GetResponse())
                        using (Stream stream = response.GetResponseStream())
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            html = reader.ReadToEnd();
                        }
                    }
                    catch (Exception error)
                    {
                        log.AppendText(Environment.NewLine + DateTime.Now + ": " + error.ToString());
                    }
                }
            }
            else
            {
                html = string.Empty;
                url = @"http://" + comboBox2.Text + "/win" + command;
                log.AppendText(Environment.NewLine + DateTime.Now + ": " + url);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            log.Clear();
        }

        private void Speed_Scroll(object sender, EventArgs e)
        {
            Sender(comboBox2.Text, "&SX=" + Speed.Value);
            speedValue.Text = Speed.Value.ToString();
            Refresh();
        }

        private void Intensity_Scroll(object sender, EventArgs e)
        {
            Sender(comboBox2.Text, "&IX=" + Intensity.Value);
            intensityValue.Text = Intensity.Value.ToString();
            Refresh();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void syncEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(syncEnable.Checked)
            {

            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Items.Count != 0)
            {
                GetInfo();
               
            }
            else
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            path = Directory.GetCurrentDirectory() + "\\ControllerList.config";
            log.AppendText(Environment.NewLine + path);
            if (File.Exists(path))
            {
                string[] controllerList = null;
                controllerList = System.IO.File.ReadAllLines(path);
                foreach (string service in controllerList)
                {
                    // Use a tab to indent each line of the file.
                    log.AppendText(Environment.NewLine + service);
                }
            }
            else
            {
               
            }

            List<string> MyList = listBox1.Items.Cast<string>().ToList();
            File.WriteAllLines(path, MyList);
        }

        private void GetInfo()
        {
            log.AppendText(Environment.NewLine + DateTime.Now + "#####Get Info Started#####");
            try
            {


                html = string.Empty;
                url = @"http://" + comboBox2.Text + "/json";
                log.AppendText(Environment.NewLine + "URL: " + url);

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }

                source = html;
                data = getBetween(source, "\"on\":", ",");
                if (data == "true")
                {
                    pwrstate.Text = "On";
                    pwrstate.ForeColor = System.Drawing.Color.Green;
                    log.AppendText(Environment.NewLine + "Power Status: On");
                }
                else
                {
                    pwrstate.Text = "Off";
                    pwrstate.ForeColor = System.Drawing.Color.Red;
                    log.AppendText(Environment.NewLine + "Power Status: Off");
                }

                data = getBetween(source, "\"ver\":\"", "\",");
                log.AppendText(Environment.NewLine + "Version: " + data);
                version.Text = "WLED " + data;

                data = getBetween(source, "\"bri\":", ",\"t");
                log.AppendText(Environment.NewLine + "Brightness: " + data);
                bightness.Value = Int16.Parse(data);
                label1.Text = data;

                data = getBetween(source, "\"sx\":", ",");
                log.AppendText(Environment.NewLine + "Speed: " + data);
                Speed.Value = Int16.Parse(data);
                speedValue.Text = data;

                data = getBetween(source, "\"ix\":", ",");
                log.AppendText(Environment.NewLine + "Intensity: " + data);
                Intensity.Value = Int16.Parse(data);
                intensityValue.Text = data;

                data1 = getBetween(source, "\"effects\":[", "],");
                data1 = data1.Replace("\"", "");
                log.AppendText(Environment.NewLine + "****Effects Start****");
                List<string> fxNames = data1.Split(',').ToList<string>();
                comboBox1.Items.Clear();
                foreach (var fx in fxNames)
                {
                    comboBox1.Items.Add(fx);
                    log.AppendText(Environment.NewLine + fx);
                }
                log.AppendText(Environment.NewLine + "****Effects End****");
                comboBox1.SelectedIndex = 0;

                data = getBetween(source, "\"fx\":", ",");
                comboBox1.SelectedIndex = Int16.Parse(data);
                fx = comboBox1.SelectedIndex;
                log.AppendText(Environment.NewLine + DateTime.Now + "#####Get Info End#####");
                Effect();
            }
            catch
            {
                MessageBox.Show("Unable to Connect to WLED Controller. Please Check Connection", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                log.AppendText(Environment.NewLine + "Unable to connect to " + comboBox2.Text);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fx = comboBox1.SelectedIndex;
            Effect();
        }
    }
}