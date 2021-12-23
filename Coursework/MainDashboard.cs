using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Microsoft.ML;
using Microsoft.ML.Data;


namespace Coursework
{
    public partial class MainDashboard : Form


    {
        //income connection and cmd
        private static string dbCommand = "";
        private static BindingSource bindingSrc;

        private static string dbPath = Application.StartupPath + "\\" + "IncomeDB.db;";
        private static SQLiteConnection connection = new SQLiteConnection(@"Data Source=F:\Computer Science\CS 2020-2021\MODULE (2020) 6COSC001W.1 Enterprise Application Development\Coursework\CWK2\Coursework\Coursework\IncomeDB.db; Version=3;New=False;Compress=True");
        private static SQLiteCommand command = new SQLiteCommand("", connection);

        private static string sql;

        //expenses db connection and cmd
        private static string dbCommand1 = "";
        private static BindingSource bindingSrc1;

        private static string dbPath1 = Application.StartupPath + "\\" + "ExpensesDB.db;";
        private static SQLiteConnection connection1 = new SQLiteConnection(@"Data Source=F:\Computer Science\CS 2020-2021\MODULE (2020) 6COSC001W.1 Enterprise Application Development\Coursework\CWK2\Coursework\Coursework\ExpensesDB.db; Version=3;New=False;Compress=True");
        private static SQLiteCommand command1 = new SQLiteCommand("", connection1);

        private static string sql1;
        static readonly string _trainDataPath = Path.Combine(Environment.CurrentDirectory, "Data", "IncomeData.csv");
        static readonly string _testDataPath = Path.Combine(Environment.CurrentDirectory, "Data", "IncomeDataTest-test.csv");
        static readonly string _modelPath = Path.Combine(Environment.CurrentDirectory, "Data", "Model.zip");

        public MainDashboard()
        {
            InitializeComponent();
            this.IDtextBox.Enabled = false;
            this.EIDtextBox.Enabled = false;
            lblOutput.Visible = false;
           
        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            UpdateDataBiding();
            EUpdateDataBiding();
            if (LoginAndRegisterForm.loginuser != null)
            {
                WelcomeLabel.Text = "Welcome... " + LoginAndRegisterForm.loginuser + "\n Email: " + LoginAndRegisterForm.emailuser;
            }
            if (LoginAndRegisterForm.loginuser != null)
            {
                AUsernametextBox.Text = LoginAndRegisterForm.loginuser;
            }
            if (LoginAndRegisterForm.passuser != null)
            {
                APasswordtextBox.Text = LoginAndRegisterForm.passuser;
            }
            if (LoginAndRegisterForm.fname != null)
            {
                AFirstNametextBox.Text = LoginAndRegisterForm.fname;
            }
            if (LoginAndRegisterForm.lname != null)
            {
                ALastnametextBox.Text = LoginAndRegisterForm.lname;
            }
            if (LoginAndRegisterForm.emailuser != null)
            {
                AEmailBox.Text = LoginAndRegisterForm.emailuser;
            }


        }
        private void displayPosition()
        {
            PositionLabel.Text = " Position:" + Convert.ToString(bindingSrc.Position + 1) +
                "/" + bindingSrc.Count.ToString();

        }
        private void EdisplayPosition()
    {
        PositionLabel1.Text = " Position:" + Convert.ToString(bindingSrc1.Position + 1) +
            "/" + bindingSrc1.Count.ToString();

    }
        ///Panel sidebar

    Color Select_colour = Color.FromArgb(22, 22, 22);
        private void ExpensesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_HomeSidebar_Click(object sender, EventArgs e)
        {
            HomePanel.BringToFront();
            button_HomeSidebar.BackColor = Select_colour;
            HomePanel.BackColor = Select_colour;
        }

        private void button_IncomeSidebar_Click(object sender, EventArgs e)
        {
            Incomepanel.BringToFront();
            button_IncomeSidebar.BackColor = Select_colour;
            Incomepanel.BackColor = Select_colour;
        }

        private void button_ExpensesSidebar_Click(object sender, EventArgs e)
        {
            Expensepanel.BringToFront();
            button_ExpensesSidebar.BackColor = Select_colour;
            Expensepanel.BackColor = Select_colour;
        }

        private void button_PredictionsSidebar_Click(object sender, EventArgs e)
        {
            Predictionspanel.BringToFront();
            button_PredictionsSidebar.BackColor = Select_colour;
            Predictionspanel.BackColor = Select_colour;
        }

        private void button_ReportSidebar_Click(object sender, EventArgs e)
        {
            Reportpanel.BringToFront();
            button_ReportSidebar.BackColor = Select_colour;
            Reportpanel.BackColor = Select_colour;
        }

        private void button_AccountSidebar_Click(object sender, EventArgs e)
        {
            AccountPanel.BringToFront();
            button_AccountSidebar.BackColor = Select_colour;
           AccountPanel.BackColor = Select_colour;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //INCOME Panel

        private void UpdateDataBiding(SQLiteCommand cmd = null)
        {
            try
            {
                TextBox tb;

                foreach (Control c in groupBox1.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        tb = (TextBox)c;
                        tb.DataBindings.Clear();
                        tb.Text = "";

                    }
                }
                dbCommand = "SELECT";
                sql = "SELECT * FROM Income ORDER BY ID ASC;";
                if (cmd == null)
                {
                    command.CommandText = sql;
                }
                else
                {
                    command = cmd;
                }

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataSet dataSet1 = new DataSet();
                adapter.Fill(dataSet1, "Income");

                bindingSrc = new BindingSource();
                bindingSrc.DataSource = dataSet1.Tables["Income"];


                IDtextBox.DataBindings.Add("Text", bindingSrc, "ID");
                CattextBox.DataBindings.Add("Text", bindingSrc, "Category");
                AmounttextBox.DataBindings.Add("Text", bindingSrc, "Amount");
                DesctextBox.DataBindings.Add("Text", bindingSrc, "Description");
                PaidFtextBox.DataBindings.Add("Text", bindingSrc, "PaidFrom");
                SubTotaltextBox.DataBindings.Add("Text", bindingSrc, "SubTotal");
                DatetextBox.DataBindings.Add("Text", bindingSrc, "Date1");
                dataGridView.Enabled = true;
                dataGridView.DataSource = bindingSrc;

                dataGridView.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnsMode.AllCells);
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView.Columns[0].Width = 70;

                displayPosition();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data Building Error: " + ex.Message.ToString(),
                    "Error Message: ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("The connection is:" + connection.State.ToString());
            }
        }

        private void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
                MessageBox.Show("The connection is:" + connection.State.ToString());
            }
        }

        private void MoveFirstButton_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveFirst();
            displayPosition();

        }

        private void MovePreviousButton_Click(object sender, EventArgs e)
        {
            bindingSrc.MovePrevious();
            displayPosition();
        }

        private void MoveNextButton_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveNext();
            displayPosition();
        }

        private void MoveLastButton_Click(object sender, EventArgs e)
        {
            bindingSrc.MoveLast();
            displayPosition();
        }

        private void DeleteDataButton_Click(object sender, EventArgs e)
        {
            if (AddDataButton.Text == "Cancel")
            {
                return;
            }
            if (IDtextBox.Text.Trim() == "" ||
                        string.IsNullOrEmpty(IDtextBox.Text.Trim()))
            {
                MessageBox.Show("Please select an item from the list", "Delete Data: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            openConnection();

            try
            {
                if (MessageBox.Show("ID: " + IDtextBox.Text.Trim() + "do you want to delete the slected record?", "VS + database", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                dbCommand = "DELETE";
                sql = "DELETE FROM Income where ID = @ID";
                command.Parameters.Clear();
                command.CommandText = sql;
                command.Parameters.AddWithValue("ID", IDtextBox.Text.Trim());

                int executeResult = command.ExecuteNonQuery();
                if (executeResult == 1)
                {
                    MessageBox.Show("Your SQL " + dbCommand + "QUERY has been executed sucessfully.", "VS + Database SQL DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataBiding();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString(), "Error Message: ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                dbCommand = "";
                closeConnection();
            }
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                displayPosition();
            }
            catch (Exception)
            {

            }
        }
        private void RefreshDataButton_Click(object sender, EventArgs e)
        {
            if (AddDataButton.Text.Equals("Cancel"))
            {
                return;

            }
            UpdateDataBiding();
        }

        private void AddDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddDataButton.Text == "Add Data")
                {
                    AddDataButton.Text = "Cancel";
                    PositionLabel.Text = "Position: 0/0";
                    dataGridView.ClearSelection();
                    dataGridView.Enabled = false;
                }
                else
                {
                    AddDataButton.Text = "Add Data";
                    UpdateDataBiding();
                    return;
                }
                TextBox txt;
                foreach (Control c in groupBox1.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        txt = (TextBox)c;
                        txt.DataBindings.Clear();
                        txt.Text = "";
                        if (txt.Name.Equals("CattextBox"))
                        {
                            if (txt.CanFocus)
                            {
                                txt.Focus();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {


            }
        }
        private void addCmdParameters()
        {
            command.Parameters.Clear();
            command.CommandText = sql;
            command.Parameters.AddWithValue("Category", CattextBox.Text.Trim());
            command.Parameters.AddWithValue("Date1", DatetextBox.Text.Trim());
            command.Parameters.AddWithValue("Description", DesctextBox.Text.Trim());
            command.Parameters.AddWithValue("PaidFrom", PaidFtextBox.Text.Trim());
            command.Parameters.AddWithValue("Amount", AmounttextBox.Text.Trim());
            command.Parameters.AddWithValue("SubTotal", SubTotaltextBox.Text.Trim());

            if (dbCommand.ToUpper() == "UPDATE")
            {
                command.Parameters.AddWithValue("ID", IDtextBox.Text.Trim());
            }

        }
        private void SaveDataButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(CattextBox.Text.Trim()) ||
                string.IsNullOrEmpty(DatetextBox.Text.Trim()) ||
                string.IsNullOrEmpty(DesctextBox.Text.Trim()) ||
                string.IsNullOrEmpty(PaidFtextBox.Text.Trim()) ||
                string.IsNullOrEmpty(AmounttextBox.Text.Trim()) ||
                string.IsNullOrEmpty(SubTotaltextBox.Text.Trim()))
            {
                MessageBox.Show("please filll in all the fields", "Add data record:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            openConnection();
            try
            {
                if (AddDataButton.Text == "Add Data")
                {
                    if (IDtextBox.Text.Trim() == "" || string.IsNullOrEmpty(IDtextBox.Text.Trim()))
                    {
                        MessageBox.Show("Please select an item");
                        return;
                    }
                    if (MessageBox.Show("ID:" + IDtextBox.Text.Trim() + "Do you want to update the selected record?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }
                    dbCommand = "UPDATE";

                    sql = "UPDATE Income SET Category = @Category, Amount = @Amount, Description = @Description, PaidFrom = @PaidFrom, SubTotal = @SubTotal, Date1 = @Date1 WHERE ID = @ID";
                    addCmdParameters();
                }
                else if (AddDataButton.Text.Equals("Cancel"))
                {
                    DialogResult result;
                    result = MessageBox.Show("(do you want to add new data record? (Y/N)?", "INSERT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dbCommand = "INSERT";
                        sql = "INSERT INTO Income (Category, Amount, Description, PaidFrom, SubTotal, Date1)" +
                            "VALUES(@Category, @Amount, @Description, @PaidFrom, @SubTotal, @Date1)";


                        addCmdParameters();
                    }

                    else
                    {
                        return;
                    }
                }

                int executeResult = command.ExecuteNonQuery();
                if (executeResult == -1)
                {
                    MessageBox.Show("Data was not saved!", "failed save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("" + dbCommand + "", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateDataBiding();
                    AddDataButton.Text = "Add Data";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                dbCommand = "";
                closeConnection();
            }
        }
        private void ISearchbutn_Click(object sender, EventArgs e)
        {
            if (AddDataButton.Text == "Cancel")
            {
                return;
            }

            openConnection();
            try
            {
                if (string.IsNullOrEmpty(searchtextBox.Text.Trim()))
                {
                    UpdateDataBiding();
                    return;
                }
                sql = "SELECT * FROM Income ";
                sql += "WHERE Category LIKE @search2 ";
                sql += "OR Amount LIKE @search2 ";
                sql += "OR Description LIKE @search2 ";
                sql += "OR PaidFrom = @search1 ";
                sql += "OR SubTotal LIKE @search2 ";
                sql += "OR Date1 LIKE @search2 ";
                sql += "ORDER BY ID ASC ";
                command.CommandType = CommandType.Text;
                command.CommandText = sql;
                command.Parameters.Clear();
                string search= string.Format("%{0}%", searchtextBox.Text);
                command.Parameters.AddWithValue("search1", searchtextBox.Text);
                command.Parameters.AddWithValue("search2", search);
                UpdateDataBiding(command);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Search Error: " + ex.Message.ToString(), " Error Message: ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally {
                closeConnection();
                searchtextBox.Focus();
            }
        }




        /// <summary>
        /// ///////
        /// </summary>
        /// <param name="cmd1"></param>

        //ExpensesPanel

        private void EUpdateDataBiding(SQLiteCommand cmd1 = null)
        {
            try
            {
                TextBox tb1;

                foreach (Control c1 in groupBox3.Controls)
                {
                    if (c1.GetType() == typeof(TextBox))
                    {
                        tb1 = (TextBox)c1;
                        tb1.DataBindings.Clear();
                        tb1.Text = "";

                    }
                }
                dbCommand1 = "SELECT";
                sql1 = "SELECT * FROM Expenses ORDER BY E_ID ASC;";
                if (cmd1 == null)
                {
                    command1.CommandText = sql1;
                }
                else
                {
                    command1 = cmd1;
                }

                SQLiteDataAdapter adapter1 = new SQLiteDataAdapter(command1);
                DataSet dataSet2 = new DataSet();
                adapter1.Fill(dataSet2, "Expenses");

                bindingSrc1 = new BindingSource();
                bindingSrc1.DataSource = dataSet2.Tables["Expenses"];


                EIDtextBox.DataBindings.Add("Text", bindingSrc1, "E_ID");
                ECattextBox.DataBindings.Add("Text", bindingSrc1, "E_Category");
                EAmounttextBox.DataBindings.Add("Text", bindingSrc1, "E_Amount");
                EDesctextBox.DataBindings.Add("Text", bindingSrc1, "E_Description");
                EPaidTtextBox.DataBindings.Add("Text", bindingSrc1, "E_PaidTo");
                ESubTtextBox.DataBindings.Add("Text", bindingSrc1, "E_SubTotal");
                EDatetextBox.DataBindings.Add("Text", bindingSrc1, "E_Date");
                EdataGridView.Enabled = true;
                EdataGridView.DataSource = bindingSrc1;

                EdataGridView.AutoResizeColumns((DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnsMode.AllCells);
                EdataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                EdataGridView.Columns[0].Width = 70;

                EdisplayPosition();
            }
            catch (Exception ex1)
            {
                MessageBox.Show("Data Building Error: " + ex1.Message.ToString(),
                    "Error Message: ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void EcloseConnection()
        {
            if (connection1.State == ConnectionState.Open)
            {
                connection1.Close();
                MessageBox.Show("The connection is:" + connection1.State.ToString());
            }
        }

        private void EopenConnection()
        {
            if (connection1.State == ConnectionState.Closed)
            {
                connection1.Open();
                MessageBox.Show("The connection is:" + connection1.State.ToString());
            }
        }

        private void EMoveFirstButton_Click(object sender, EventArgs e)
        {
            bindingSrc1.MoveFirst();
            EdisplayPosition();

        }

        private void EMovePreviousButton_Click(object sender, EventArgs e)
        {
            bindingSrc1.MovePrevious();
            EdisplayPosition();
        }

        private void EMoveNextButton_Click(object sender, EventArgs e)
        {
            bindingSrc1.MoveNext();
            EdisplayPosition();
        }

        private void EMoveLastButton_Click(object sender, EventArgs e)
        {
            bindingSrc1.MoveLast();
            EdisplayPosition();
        }
        private void EDeletebutton_Click(object sender, EventArgs e)
        {
            if (EAddbutton.Text == "Cancel")
            {
                return;
            }
            if (EIDtextBox.Text.Trim() == "" ||
                        string.IsNullOrEmpty(EIDtextBox.Text.Trim()))
            {
                MessageBox.Show("Please select an item from the list", "Delete Data: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            EopenConnection();

            try
            {
                if (MessageBox.Show("E_ID: " + EIDtextBox.Text.Trim() + "do you want to delete the slected record?", "VS + database", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                {
                    return;
                }
                dbCommand1 = "DELETE";
                sql1 = "DELETE FROM Expenses WHERE E_ID = @E_ID";
                command1.Parameters.Clear();
                command1.CommandText = sql1;
                command1.Parameters.AddWithValue("E_ID", EIDtextBox.Text.Trim());

                int executeResult = command1.ExecuteNonQuery();
                if (executeResult == 1)
                {
                    MessageBox.Show("Your SQL " + dbCommand1 + "QUERY has been executed sucessfully.", "VS + Database SQL DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EUpdateDataBiding();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message.ToString(), "Error Message: ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                dbCommand1 = "";
                EcloseConnection();
            }
        }

        private void EAddbutton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (EAddbutton.Text == "Add New")
                    {
                        EAddbutton.Text = "Cancel";
                        PositionLabel1.Text = "Position: 0/0";
                        EdataGridView.ClearSelection();
                        EdataGridView.Enabled = false;
                    }
                    else
                    {
                        EAddbutton.Text = "Add New";
                        EUpdateDataBiding();
                        return;
                    }
                    TextBox txt1;
                    foreach (Control c1 in groupBox1.Controls)
                    {
                        if (c1.GetType() == typeof(TextBox))
                        {
                            txt1 = (TextBox)c1;
                            txt1.DataBindings.Clear();
                            txt1.Text = "";
                            if (txt1.Name.Equals("ECattextBox"))
                            {
                                if (txt1.CanFocus)
                                {
                                    txt1.Focus();
                                }
                            }
                        }
                    }
                }
                catch (Exception)
                {


                }
            }
        }

        private void EdataGridView_CellMouseClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EdisplayPosition();
            }
            catch (Exception)
            {

            }
        }
        private void ERefreshbutton_Click(object sender, EventArgs e)
        {
            if (EAddbutton.Text.Equals("Cancel"))
            {
                return;

            }
            EUpdateDataBiding();
        }
        private void EaddCmdParameters()
        {
            command1.Parameters.Clear();
            command1.CommandText = sql1;
            command1.Parameters.AddWithValue("E_Category", ECattextBox.Text.Trim());
            command1.Parameters.AddWithValue("E_Date", EDatetextBox.Text.Trim());
            command1.Parameters.AddWithValue("E_Description", EDesctextBox.Text.Trim());
            command1.Parameters.AddWithValue("E_PaidTo", EPaidTtextBox.Text.Trim());
            command1.Parameters.AddWithValue("E_Amount", EAmounttextBox.Text.Trim());
            command1.Parameters.AddWithValue("E_SubTotal", ESubTtextBox.Text.Trim());

            if (dbCommand1.ToUpper() == "UPDATE")
            {
                command1.Parameters.AddWithValue("E_ID", EIDtextBox.Text.Trim());
            }

        }
        private void ESavebutton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(ECattextBox.Text.Trim()) ||
                string.IsNullOrEmpty(EDatetextBox.Text.Trim()) ||
                string.IsNullOrEmpty(EDesctextBox.Text.Trim()) ||
                string.IsNullOrEmpty(EPaidTtextBox.Text.Trim()) ||
                string.IsNullOrEmpty(EAmounttextBox.Text.Trim()) ||
                string.IsNullOrEmpty(ESubTtextBox.Text.Trim()))
            {
                MessageBox.Show("please fill in all the fields", "Add data record:", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            EopenConnection();
            try
            {
                if (EAddbutton.Text == "Add New")
                {
                    if (EIDtextBox.Text.Trim() == "" || string.IsNullOrEmpty(EIDtextBox.Text.Trim()))
                    {
                        MessageBox.Show("Please select an item");
                        return;
                    }
                    if (MessageBox.Show("E_ID:" + EIDtextBox.Text.Trim() + "Do you want to update the selected record?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
                    {
                        return;
                    }
                    dbCommand1 = "UPDATE";

                    sql1 = "UPDATE Expeneses SET E_Category = @E_Category, E_Amount = @E_Amount, E_Description = @E_Description, E_PaidTo = @E_PaidTo, E_SubTotal = @E_SubTotal, E_Date = @E_Date WHERE E_ID = @E_ID";
                    EaddCmdParameters();
                }
                else if (EAddbutton.Text.Equals("Cancel"))
                {
                    DialogResult Eresult;
                    Eresult = MessageBox.Show("(do you want to add new data record? (Y/N)?", "INSERT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Eresult == DialogResult.Yes)
                    {
                        dbCommand1 = "INSERT";
                        sql1 = "INSERT INTO Expenses (E_Category, E_Amount, E_Description, E_PaidTo, E_SubTotal, E_Date)" +
                            "VALUES(@E_Category, @E_Amount, @E_Description, @E_PaidTo, @E_SubTotal, @E_Date)";

                        EaddCmdParameters();
                    }

                    else
                    {
                        return;
                    }
                }

                int executeResult1 = command1.ExecuteNonQuery();
                if (executeResult1 == -1)
                {
                    MessageBox.Show("Data was not saved!", "failed save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("" + dbCommand1 + "", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    EUpdateDataBiding();
                    EAddbutton.Text = "Add New";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                dbCommand1 = "";
                EcloseConnection();
            }
        }




        //Prediction
        private void Predictionspanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
          //  float year;
           // float month;
           // float day;

            //if (!isYearValid(txtYear.Text))
            //{
            //    MessageBox.Show("");
            //}
            //if (!isMonthValid(txtMonth.Text))
            //{
            //    MessageBox.Show("");
            //}
            //else if (!isDayValid(txtDay.Text))
            //{
            //    MessageBox.Show("");
            //}
            //else
            //{
            //    year = Convert.ToSingle(YearEncoded.Text);
            //    month = Convert.ToSingle(MonthEncoded.Text);
            //    day = Convert.ToSingle(DayEncoded.Text);
            //    lblOutput.Text = .IncomeAmount;
            //    lblOutput.Visible = true;
           // }




        }

        public static ITransformer Train(MLContext mlContext, string dataPath)
        {

            IDataView dataView = mlContext.Data.LoadFromTextFile<IncomeData>(dataPath, hasHeader: true, separatorChar: ',');
            var pipeline = mlContext.Transforms.CopyColumns(outputColumnName: "Label", inputColumnName: "IncomeAmount")

                .Append(mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "YearEncoded", inputColumnName: "Year"))
                .Append(mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "MonthEncoded", inputColumnName: "Month"))
                .Append(mlContext.Transforms.Categorical.OneHotEncoding(outputColumnName: "DayEncoded", inputColumnName: "Day"))
                .Append(mlContext.Transforms.Concatenate("Features", "YearEncoded", "MonthEncoded", "DayEncoded"))
                .Append(mlContext.Regression.Trainers.FastTree());

            var model = pipeline.Fit(dataView);

            return model;


        }

        private static void Evaluate(MLContext mlContext, ITransformer model)
        {
            IDataView dataView = mlContext.Data.LoadFromTextFile<IncomeData>(_testDataPath, hasHeader: true, separatorChar: ',');

            var predictions = model.Transform(dataView);
            var metrics = mlContext.Regression.Evaluate(predictions, "Label", "Score");






            Console.WriteLine();
            Console.WriteLine($"*************************************************");
            Console.WriteLine($"*       Model quality metrics evaluation         ");
            Console.WriteLine($"*------------------------------------------------");

            Console.WriteLine($"*       RSquared Score:      {metrics.RSquared:0.##}");
            Console.WriteLine($"*       Root Mean Squared Error:      {metrics.RootMeanSquaredError:#.##}");
            Console.WriteLine("Press Enter to Continue....");
            Console.ReadLine();





        }

        private static void TestSinglePrediction(MLContext mlContext, ITransformer model)
        {

            var predictionFunction = mlContext.Model.CreatePredictionEngine<IncomeData, IncomePredictions>(model);


            var IncomeDataSample = new IncomeData()
            {
                Label = "1654564",
                Year = 2012,
                Month = 1,
                Day = 14,
                IncomeAmount = 0 // To predict. Actual/Observed = 
            };

            var prediction = predictionFunction.Predict(IncomeDataSample);

            Console.WriteLine($"**********************************************************************");
            Console.WriteLine($"Predicted fare: {prediction.IncomeAmount:0.####}, actual fare: 15.5");
            Console.WriteLine($"**********************************************************************");
            Console.ReadLine();

        }
        //Topbar
        private void UserLabel(string username, string Email)
        {
            //this.WelcomeLabel.Text = "Welcome..."+getUserName "\n Email: " + getEmail;
        }

        private void ESearchtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ESearchButn_Click(object sender, EventArgs e)
        {

            if (EAddbutton.Text == "Cancel")
            {
                return;
            }

            EopenConnection();
            try
            {
                if (string.IsNullOrEmpty(ESearchtextBox.Text.Trim()))
                {
                    EUpdateDataBiding();
                    return;
                }
                sql1 = "SELECT * FROM Expenses ";
                sql1 += "WHERE ECategory LIKE @Esearch2 ";
                sql1 += "OR EAmount LIKE @Esearch2 ";
                sql1 += "OR EDescription LIKE @sEearch2 ";
                sql1 += "OR EPaidFrom = @Esearch1 ";
                sql1 += "OR ESubTotal LIKE @Esearch2 ";
                sql1 += "OR EDate LIKE @Esearch2 ";
                sql1 += "ORDER BY EID ASC ";
                command1.CommandType = CommandType.Text;
                command1.CommandText = sql1;
                command.Parameters.Clear();
                string Esearch = string.Format("%{0}%", ESearchtextBox.Text);
                command.Parameters.AddWithValue("search1", ESearchtextBox.Text);
                command.Parameters.AddWithValue("search2", Esearch);
                UpdateDataBiding(command);

            }
            catch (Exception ex)
            {

                MessageBox.Show("Search Error: " + ex.Message.ToString(), " Error Message: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                EcloseConnection();
                searchtextBox.Focus();
            }
        }

        



        //Report

        //TopBar

        //AccountView


    }
}
