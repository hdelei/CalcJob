using CalcJob.Properties;
using CalcJob.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcJob
{
    public partial class Form1 : Form
    {
        DateTime[,] dateTimeArray = new DateTime[5, 2];
        List<object> doubleValuesList = new List<object>();
        List<TimeSpan> dateResults = new List<TimeSpan>();
        int buttonClickWarning = 0;        

        public Form1()
        {
            InitializeComponent();                        
            gridMetro.Rows[0].Cells[0].Value = "total";
            labelTimeTip1.Text = "";            
        }

        string buttonStatus = Status.Start;
        int rowIndex = 0;

        /// <summary>
        /// Check if grid contais the maximum number of rows
        /// </summary>
        /// <returns></returns>
        private bool IsGriFull()
        {
            if (gridMetro.Rows.Count == 6)
            {
                if (gridMetro.Rows[4].Cells[3].Value != null)
                {
                    mAddTimeButton.Enabled = false;
                    labelTimeTip1.Text = "Click clear or press F5 to start over again!";
                    return true;
                }
            }
            return false;
        }

        DateTime BuildDate(string time)
        {
            var newTime = new DateTime(1980, 12, 29, int.Parse(timeBox.Text.Substring(0, 2)), int.Parse(timeBox.Text.Substring(3, 2)), 0);
            return newTime;
        }


        void CalcTime(int rowIndex)
        {
            var startDate = dateTimeArray[rowIndex, 0];
            var endDate = dateTimeArray[rowIndex, 1];
            if (endDate < startDate)
                endDate = endDate.AddDays(1);

            var timeDifference = endDate - startDate;

            CalcTotalTime(timeDifference);

            var timeIndecimalFormat = (float)timeDifference.Hours + ((float)timeDifference.Minutes / 60);

            gridMetro.Rows[rowIndex].Cells[2].Value = timeDifference.ToString(@"hh\:mm");
            gridMetro.Rows[rowIndex].Cells[3].Value = Math.Round(timeIndecimalFormat, 2);
        }
        
        /// <summary>
        /// TextBox validation in regex
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimeBox_KeyUp(object sender, KeyEventArgs e)
        {
            var regexString = new Regex(@"^([01]\d|2[0-3]):?([0-5]\d)$",
                RegexOptions.Compiled | RegexOptions.IgnoreCase);
            var isValid = regexString.IsMatch(timeBox.Text);
            mAddTimeButton.Enabled = isValid;

            //if (e.KeyData == Keys.Enter && isValid)
            //{
            //    mAddTimeButton_Click(sender, e);                            
            //}            
        }       
         
        /// <summary>
        /// Calculate decimal for Column 3
        /// </summary>
        /// <param name="rowIndex"></param>
        void CalcSubtotal(int rowIndex)
        {   
            foreach (DataGridViewRow row in gridMetro.Rows)
            {
                if (row.Index == (gridMetro.Rows.Count - 2))
                {
                    doubleValuesList.Add(row.Cells[3].Value);
                    gridMetro.Rows[gridMetro.Rows.Count - 1].Cells[3].Value = doubleValuesList.Sum(t => Convert.ToDouble(t));
                }
            }
        }
                
        /// <summary>
        /// Format time hh:mm to column 2
        /// </summary>
        /// <param name="tSpan"></param>
        void CalcTotalTime(TimeSpan tSpan)
        {
            var totalTime = new TimeSpan();            
            dateResults.Add(tSpan);
            
            foreach (TimeSpan time in dateResults)
            {                
                totalTime += time;               
            }

            var hourMinute = new List<string>
            {
                ((int)totalTime.TotalHours).ToString(),
                totalTime.Minutes.ToString()
            };

            if (hourMinute[0].Count() == 1)
                hourMinute[0] = "0" + hourMinute[0];

            if (hourMinute[1].Count() == 1)
                hourMinute[1] = "0" + hourMinute[1];
                        
            var timeFomated = hourMinute[0] + ":" + hourMinute[1];
            
            gridMetro.Rows[gridMetro.Rows.Count - 1].Cells[2].Value = timeFomated;
        }
        
        /// <summary>
        /// Add tooltip to cells
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridMetro_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == this.gridMetro.Columns["TotalTimeCol"].Index && e.Value != null) ||
                (e.ColumnIndex == this.gridMetro.Columns["DecimalCol"].Index && e.Value != null))
            {
                DataGridViewCell cell = gridMetro.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Click to Copy to Clipboard";                
            }
        }                

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Reload all variables
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void reloadGrid_Click(object sender, EventArgs e)
        {
            gridMetro.Rows.Clear();
            gridMetro.Update();
            gridMetro.Refresh();
            rowIndex = 0;
            gridMetro.Rows[0].Cells[0].Value = "total";
            buttonStatus = Status.Start;
            mAddTimeButton.Text = "Add start Time";
            mAddTimeButton.Enabled = true;
            labelTimeTip1.Text = "";
            timeBox.Text = "00:00";
            doubleValuesList.Clear();
            dateResults.Clear();
            timeBox.Focus();
            timeBox.SelectAll();
            buttonClickWarning = 0;
        }

        /// <summary>
        /// This routine is intended to make the form draggable due to 
        /// the lack of default bar
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        /// <summary>
        /// Watch drag event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void reloadGrid_MouseEnter(object sender, EventArgs e)
        {
            var customReloadLabel = new LabelCustomColors();
            customReloadLabel.MouseEnter(reloadGrid);            
        }
        private void reloadGrid_MouseLeave(object sender, EventArgs e)
        {
            var customReloadLabel = new LabelCustomColors();
            customReloadLabel.MouseLeave(reloadGrid);
        }
        private void closeForm_MouseEnter(object sender, EventArgs e)
        {
            var custom = new LabelCustomColors();
            custom.MouseEnter(closeForm);

        }        
        private void closeForm_MouseLeave(object sender, EventArgs e)
        {
            var custom = new LabelCustomColors();
            custom.MouseLeave(closeForm);
        }

        /// <summary>
        /// Main routine to add time to datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mAddTimeButton_Click(object sender, EventArgs e)
        {   
            if (IsGriFull())
                return;
            switch (buttonStatus)
            {
                case "Start":
                    rowIndex = gridMetro.Rows.Add(timeBox.Text);
                    dateTimeArray[rowIndex, 0] = BuildDate(timeBox.Text);
                    buttonStatus = Status.End;
                    timeBox.Focus();
                    timeBox.SelectAll();
                    mAddTimeButton.Text = "Add end Time";
                    break;
                case "End":
                    gridMetro.Rows[gridMetro.Rows.Count - 2].Cells[1].Value = timeBox.Text;
                    dateTimeArray[rowIndex, 1] = BuildDate(timeBox.Text);
                    CalcTime(rowIndex);
                    CalcSubtotal(rowIndex);
                    buttonStatus = Status.Start;
                    timeBox.Focus();
                    timeBox.SelectAll();
                    mAddTimeButton.Text = "Add start Time";

                    if (IsGriFull())
                        return;

                    break;
                default:
                    break;                    
            }
            foreach (DataGridViewRow row in gridMetro.Rows)
            {
                row.Selected = false;
            }
        }

        /// <summary>
        /// Always On Top functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void alwaysCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = UserSettings.AlwaysOnTop = alwaysCheckBox.Checked;            
        }

        /// <summary>
        /// Get cell content to clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridMetro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            
            var cellContent = gridMetro.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            if (cellContent is null || cellContent.ToString() == "total")
                return;
            try
            {
                Clipboard.SetText(cellContent.ToString());
                ShowClipboardIcon();                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(string.Format("Error Message: {0}", ex.Message));
            }            
        }

        private async Task ShowClipboardIcon()
        {
            pictureBox1.Image = new Bitmap(Resources.copy_icon);
            await Task.Delay(1000);
            pictureBox1.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = mAddTimeButton;
            mAddTimeButton.Click += watchClickWarning;

            ApplyAlarmClockFont(timeBox);            

            alwaysCheckBox.Checked = TopMost = UserSettings.AlwaysOnTop;

            if (Settings.Default.LatestPositon != null)
            {
                this.Location = Settings.Default.LatestPositon;
            }
        }
                
        private void ApplyAlarmClockFont(MaskedTextBox timeBox)
        {
            PrivateFontCollection privateFont = new PrivateFontCollection();
            Stream fontStream = new MemoryStream(Properties.Resources.alarmclock);
            //create an unsafe memory block for the data
            System.IntPtr data = Marshal.AllocCoTaskMem((int)fontStream.Length);
            //create a buffer to read in to
            Byte[] fontData = new Byte[fontStream.Length];
            //fetch the font program from the resource
            fontStream.Read(fontData, 0, (int)fontStream.Length);
            //copy the bytes to the unsafe memory block
            Marshal.Copy(fontData, 0, data, (int)fontStream.Length);

            // We HAVE to do this to register the font to the system (Weird .NET bug !)
            uint cFonts = 0;
            AddFontMemResourceEx(data, (uint)fontData.Length, IntPtr.Zero, ref cFonts);

            //pass the font to the font collection
            privateFont.AddMemoryFont(data, (int)fontStream.Length);
            //close the resource stream
            fontStream.Close();
            //free the unsafe memory
            Marshal.FreeCoTaskMem(data);

            if (privateFont.Families[0] != null)
            {
                timeBox.Font = new Font(privateFont.Families[0], 20, FontStyle.Bold);
            }            

            //InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            //FontFamily[] fontFamilies = installedFontCollection.Families;
            //var fontFamily = fontFamilies.FirstOrDefault(x => x.Name.Equals("alarm clock"));

            //if (fontFamily != null)
            //{
            //    timeBox.Font = new Font(fontFamily, 20, FontStyle.Bold);
            //}
            //else
            //{
            //    //install font from directory
            //}
        }

        /// <summary>
        /// Warn user he can use ENTER when adding time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void watchClickWarning(object sender, EventArgs e)
        {
            var eventType = e.GetType();
            var expectedType = typeof(MouseEventArgs);

            buttonClickWarning++;
            buttonClickWarning = eventType.Equals(expectedType) ? buttonClickWarning++ : 0;
            if (buttonClickWarning == 8)
                labelTimeTip1.Text = "Hey! You can use ENTER to add time.";
        }

        /// <summary>
        /// Captures F5 key to reload form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                reloadGrid_Click(sender, e);
            }
        }

        private void MinimizeLabel_MouseEnter(object sender, EventArgs e)
        {
            minimizeLabel.ForeColor = SystemColors.ButtonHighlight;
        }

        private void minimizeLabel_MouseLeave(object sender, EventArgs e)
        {
            minimizeLabel.ForeColor = Color.DodgerBlue;
        }

        private void minimizeLabel_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.LatestPositon = this.Location;
            Settings.Default.Save();
        }

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

    }
}
