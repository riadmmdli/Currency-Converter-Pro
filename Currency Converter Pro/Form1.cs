using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using MetroFramework.Controls;
using System.Globalization;

namespace Currency_Converter_Pro
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        

        private Dictionary<string, double> _currencies = new Dictionary<string, double>();
        public Form1()
        {
            InitializeComponent();
            var currencies = ApiCurrencies();
            dynamic responseObject = JsonConvert.DeserializeObject(currencies);
            foreach(var item in responseObject.data)
            {
                fromCombo.Items.Add(item.First.code.ToString());
                toCombo.Items.Add(item.First.code.ToString());
                _currencies.Add(item.First.code.ToString(), item.First.value.Value);
            }
            amountTxt.KeyPress += amountTxt_KeyPress;
            clearButton.Click += clearButton_Click;
            changeBtn.Click += changeBtn_Click;
            // Make the form non-resizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Disable the maximize button
            this.MaximizeBox = false;

            // Optionally, set up a timer to update the time every second
            Timer timer = new Timer();
            timer.Interval = 1000; // Update every second
            timer.Tick += (sender, e) => UpdateTimeLabel();
            timer.Start();
            timeLabel.AutoSize = true; // Enable auto-sizing
            timeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }
       
        

        private void Form1_Load(object sender, EventArgs e)
        {
            metroButton1.Text = "Convert";
            metroButton1.BackColor = Color.Teal;
            metroButton1.ForeColor = Color.White;
            metroButton1.FlatStyle = FlatStyle.Flat;
            metroButton1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            dateLabel.AutoSize = true;
            resultLbl.AutoSize = true;

            // Get the current date in English format and language
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("MMMM dd, yyyy", CultureInfo.CreateSpecificCulture("en-US"));
            dateLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            

            // Set the date label to the formatted date
            dateLabel.Text = formattedDate;
            fromCombo.AutoSize = false;
            toCombo.AutoSize = false;

            // Set the Anchor property to keep the ComboBoxes fixed relative to the top
            fromCombo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            toCombo.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // Optionally, set the maximum height of the dropdown list
            fromCombo.DropDownHeight = 200; // Adjust the height as needed
            toCombo.DropDownHeight = 200;   // Adjust the height as needed

            // Ensure the ComboBoxes do not move up or down
            fromCombo.Location = new Point(fromCombo.Location.X, 155); // Use the actual Y position
            toCombo.Location = new Point(toCombo.Location.X, 200);     // Use the actual Y position

            
        }
        
        

        //Here we get currency api key
        private string ApiCurrencies()
        {
            var client = new RestClient("https://api.currencyapi.com/v3/latest?base_currency=USD");

            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("apikey", "cur_live_TXiKyM8T2Wo5taYrbvNLvGHVQlYD0MhrniTmPuvh");
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        
        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (fromCombo.SelectedItem != null && toCombo.SelectedItem != null && !string.IsNullOrEmpty(amountTxt.Text))
            {
                var selectedFromCurrency = fromCombo.SelectedItem.ToString();
                var selectedToCurrency = toCombo.SelectedItem.ToString();
                var amount = double.Parse(amountTxt.Text);

                var fromCurrentExRt = _currencies[selectedFromCurrency];
                var toCurrentExRt = _currencies[selectedToCurrency];

                // Calculate the converted amount
                var calculatedAmount = (amount / fromCurrentExRt) * toCurrentExRt;

                resultLbl.Text = $"{calculatedAmount:F2} {selectedToCurrency}";
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toLabel_Click(object sender, EventArgs e)
        {

        }

        
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Clear the selected items in the combo boxes and the text in the amount textbox
            fromCombo.SelectedItem = null;
            toCombo.SelectedItem = null;
            amountTxt.Text = string.Empty;
            resultLbl.Text = string.Empty;  // Optionally clear the result label
        }

        private void amountTxt_Click(object sender, EventArgs e)
        {
            
            
        }
        private void amountTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, control characters (like backspace), and a single decimal point
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true; // Stop the character from being entered into the control
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as MetroTextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if (char.IsDigit(e.KeyChar) && (sender as MetroTextBox).Text.Replace(".", "").Length >= 7)
            {
                e.Handled = true; // Prevent more than 7 digits
            }
        }

        private void resultLbl_Click(object sender, EventArgs e)
        {

        }
        private void changeBtn_Click(object sender, EventArgs e)
        {
            // Store the selected value of fromCombo in a temporary variable
            var temp = fromCombo.SelectedItem;

            // Swap the selected values
            fromCombo.SelectedItem = toCombo.SelectedItem;
            toCombo.SelectedItem = temp;
        }

        private void dateLabel_Click(object sender, EventArgs e)
        {
            
        }
        private void UpdateTimeLabel()
        {
            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Format the time in 24-hour format
            string formattedTime = currentTime.ToString("HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US"));

            // Set the formatted time to the label
            timeLabel.Text = formattedTime;
        }
        

        private void timeLabel_Click(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a black pen
            using (Pen blackPen = new Pen(Color.Black, 1))
            {
                // Calculate the Y-coordinate for the line
                int lineY = this.ClientSize.Height - 5; // 5 pixels margin from bottom


                // Draw a line at the bottom of the form
                e.Graphics.DrawLine(blackPen, 0, lineY, this.ClientSize.Width, lineY);
            }
        }
    }
}
