using System;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DatabaseAccess
{
    public partial class ContactList : Form
    {
        private int _nSelectedRow;

        private string _sPathtoDB;
        private string _sConnectionString;
        private bool _bColumnsSet = false;

        DataTable _tbl;

        BindingList<string> _blstContactList;

        Mitarbeiter _ma = new Mitarbeiter();


        /// <summary>
        /// CONSTRUCTOR
        /// </summary>
        public ContactList()
        {
            InitializeComponent();
            _sPathtoDB = @"C:\Users\b.wood\Desktop\Mitarbeiter.accdb";
            _sConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + _sPathtoDB + ";Persist Security Info=False;";
            _blstContactList = new BindingList<string>();
            listBox1.DataSource = _blstContactList;
            _tbl = new DataTable();

            _nSelectedRow = 0;

            //GRIDVIEW 
            fillGridView();

            //LISTVIEW
            fillListView();

            //LISTBOX
            fillListBox();
        }

        /// <summary>
        /// Fill the list box
        /// </summary>
        private void fillListBox()
        {
            //Step 1 - Open connection
            using (OleDbConnection conn = new OleDbConnection(_sConnectionString))
            {
                conn.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "Select * from Mitarbeiter";
                command.Prepare();
                OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        _ma.Name = (reader.GetValue(2).ToString());
                        _ma.Vorname = (reader.GetValue(1).ToString());
                        _ma.Hausnummer = (reader.GetValue(4).ToString());
                        _ma.Strasse = (reader.GetValue(3).ToString());
                        _ma.Postleitzahl = (reader.GetValue(5).ToString());
                        _ma.Ort = (reader.GetValue(6).ToString());

                        _blstContactList.Add(_ma.concatToString());
                    }
                    conn.Close();
            }

        }

        /// <summary>
        /// Fill the gridview
        /// </summary>
        private void fillGridView()
        {
            //Step 1 - Open connection
            using (OleDbConnection conn = new OleDbConnection(_sConnectionString))
            {
                conn.Open();

                //Step 2 - Create new DataAdapter
                using (OleDbDataAdapter adptr = new OleDbDataAdapter("SELECT * FROM Mitarbeiter", conn))
                {
                    //Step 3 - Use DataAdapter to fill a new DataTable
                    adptr.Fill(_tbl);

                    //Step 4 - Render data onto the screen
                    
                    dataGridView1.DataSource = _tbl;
                    dataGridView1.Columns[0].Visible = false;
                }
                conn.Close();
            }
        }

        /// <summary>
        /// Fill the Listview
        /// </summary>
        private void fillListView()
        {


            using (OleDbConnection conn = new OleDbConnection(_sConnectionString))
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = conn;
                command.CommandText = "Select * from Mitarbeiter";
                command.Prepare();
                OleDbDataReader reader = command.ExecuteReader();

                /*
                 *Create an ArrayList to hold the results
                 *
                 *First we create an array of objects. Each object in the array represents a column in the DataReader.
                 * We know how many columns are in the DataReader by using the FieldCount property. 
                 * Now we have the array of objects we need to get some values. If we wanted, we could get each value 
                 *individually and add it to the array; another way is to use the GetValues method. This method will populate. 
                 */

                ArrayList rowList = new ArrayList();

                while (reader.Read())
                {
                    object[] values = new object[reader.FieldCount];
                    reader.GetValues(values);
                    rowList.Add(values);
                }

                // Have the columns already being added to the list view?
                if (_bColumnsSet == false)
                {
                    // No, so get the schema for this result set
                    DataTable schema = reader.GetSchemaTable();

                    // And set the list view to reflect the
                    // contents of the schema
                    SetColumnHeaders(schema);
                    listView1.Columns.RemoveAt(0);
                }

                /*
                 * Populate a List View with the Values from an Array List
                 * The first thing we have to do is to clear the ListView. Now we need to add the column
                 * values for each row into the ListView. We will do this by creating a ListViewItem object and 
                 * adding that to the Items collection of the ListView. In order to create a ListViewItem we want to
                 * create an array of strings, where each string in the array corresponds to a column in the ListView.
                 * Using the Length property of the "row" in the ArrayList we are able to allocate enough strings 
                 * in the string array to hold each column that exits in the row. Once we have built the string array, 
                 * we create a new ListViewItem and add it to the ListView.
                 */

                listView1.Items.Clear();
                
                foreach (object[] row in rowList)
                {
                    string[] rowDetails = new string[row.Length - 1];
                    int columnIndex = 0;
                    bool pastFrst = false;
                    
                    foreach (object column in row)
                    {
                        // I added an 'if' statement and boolean, to skip the ID column during the iteration
                        if (pastFrst)
                        {
                            rowDetails[columnIndex++] = Convert.ToString(column);
                        }
                        pastFrst = true;
                    }

                    ListViewItem newItem = new ListViewItem(rowDetails);

                    listView1.Items.Add(newItem);
                }

                conn.Close();
            }
        }

        /// <summary>
        /// Sets column headers for the fillListView method
        /// </summary>
        /// <param name="schema"></param>
        private void SetColumnHeaders(DataTable schema)
            {
                foreach (DataRow row in schema.Rows)
                {
                   listView1.Columns.Add((string)row["ColumnName"], 100, HorizontalAlignment.Left);
                }

                // Set this flag to stop the method being called again
                _bColumnsSet = true;
            }

        /// <summary>
        /// Fills the text boxes every time from the selected row in one of the 
        /// 3 display boxes
        /// </summary>
        private void fillTxtBoxes()
        {
                    m_sNameTxtbx.Text = _tbl.Rows[_nSelectedRow].ItemArray[1].ToString();
                    m_sVornameTxtbx.Text =  _tbl.Rows[_nSelectedRow].ItemArray[2].ToString();
                    m_nHausnummerTxtbx.Text =  _tbl.Rows[_nSelectedRow].ItemArray[3].ToString();
                    m_sStrasseTxtbx.Text =  _tbl.Rows[_nSelectedRow].ItemArray[4].ToString();
                    m_nPostleitzahlTxtbx.Text =  _tbl.Rows[_nSelectedRow].ItemArray[5].ToString();
                    m_sOrtTxtbx.Text = _tbl.Rows[_nSelectedRow].ItemArray[6].ToString();
        }

        /// <summary>
        /// Tests for empty input text boxes, and calls checkForMatches()
        /// </summary>
        /// <returns></returns>
        private bool testValidity() 
        {

            if (m_sVornameTxtbx.Text == "")
            {
                MessageBox.Show("Vorname darf nicht leer lassen");
                return false;
            }
            if (m_sNameTxtbx.Text == "")
            {
                MessageBox.Show("Name darf nicht leer lassen");
                return false;
            }
            if (m_sStrasseTxtbx.Text == "")
            {
                MessageBox.Show("Strasse darf nicht leer lassen");
                return false;
            }
            if (m_nHausnummerTxtbx.Text == "")
            {
                MessageBox.Show("Hausnummer darf nicht leer lassen");
                return false;
            }
            if (m_nPostleitzahlTxtbx.Text == "")
            {
                MessageBox.Show("Postleitzahl darf nicht leer lassen");
                return false;
            }
            if (m_sOrtTxtbx.Text == "")
            {
                MessageBox.Show("Ort darf nicht leer lassen");
                return false;
            }
            if (checkForMatches())
            {
                MessageBox.Show("Diese Adresse ist schon eingestellt");
                return false;                
            }

                return true;

        }

        /// <summary>
        /// Tests for records that are already in the database
        /// </summary>
        /// <returns></returns>
        private bool checkForMatches()
        {

                DataRow newRow = _tbl.NewRow();
                newRow["Vorname"] = m_sVornameTxtbx.Text;
                newRow["Name"] = m_sNameTxtbx.Text;
                newRow["Hausnummer"] = m_nHausnummerTxtbx.Text;
                newRow["Strasse"] = m_sStrasseTxtbx.Text;
                newRow["PLZ"] = m_nPostleitzahlTxtbx.Text;
                newRow["Ort"] = m_sOrtTxtbx.Text;
            
            foreach (DataRow row in _tbl.Rows)
            {
                int i = 0;
                newRow["ID"] = row["ID"];

                if (row["Name"].Equals(newRow["Name"]))
                {
                    i++;
                }
                if (row["Vorname"].Equals(newRow["Vorname"]))
                {
                    i++;
                }
                if (row["Hausnummer"].Equals(newRow["Hausnummer"]))
                {
                    i++;
                }
                if (row["Strasse"].Equals(newRow["Strasse"]))
                {
                    i++;
                }
                if (row["PLZ"].Equals(newRow["PLZ"]))
                {
                    i++;
                }
                if (row["Ort"].Equals(newRow["Ort"]))
                {
                    i++;
                }
                if (i == 6)
                {
                    return true;
                }
            }
            return false;
        }

        #region Form Events
        private void ContactList_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Submit button, it first tests if any input boxes are empty and if record is already in database
        /// then loads all text boxes into the Mitarbeiter class, opens a connection to database, creates new row,
        /// updates database, closes connection, and clears text boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _SubmitBtn_Click(object sender, EventArgs e)
        {
            if (testValidity())
            {
                _blstContactList.Add(m_sVornameTxtbx.Text + ", " + m_sNameTxtbx.Text + "\t" + m_sStrasseTxtbx.Text + "  " + m_nHausnummerTxtbx.Text + "\t\t" + m_nPostleitzahlTxtbx.Text + "\t" + m_sOrtTxtbx.Text);
                _ma.Vorname = m_sVornameTxtbx.Text;
                _ma.Name = m_sNameTxtbx.Text;
                _ma.Hausnummer = m_nHausnummerTxtbx.Text;
                _ma.Strasse = m_sStrasseTxtbx.Text;
                _ma.Postleitzahl = m_nPostleitzahlTxtbx.Text;
                _ma.Ort = m_sOrtTxtbx.Text;

                using (OleDbConnection conn = new OleDbConnection(_sConnectionString))
                {
                    conn.Open();

                    OleDbDataAdapter da = new OleDbDataAdapter();
                    OleDbCommand command = new OleDbCommand("Select * from Mitarbeiter", conn);
                    OleDbCommandBuilder cmdb = new OleDbCommandBuilder(da);
                    da.SelectCommand = command;
                    _tbl.Clear();
                    da.Fill(_tbl);

                    DataRow newRow = _tbl.NewRow();
                    newRow["Name"] = _ma.Name;
                    newRow["Vorname"] = _ma.Vorname;
                    newRow["Hausnummer"] = _ma.Hausnummer;
                    newRow["Strasse"] = _ma.Strasse;
                    newRow["PLZ"] = _ma.Postleitzahl;
                    newRow["Ort"] = _ma.Ort;
                    _tbl.Rows.Add(newRow);


                    da.Update(_tbl);
                    conn.Close();
                }

                fillListView();
                m_sNameTxtbx.Clear();
                m_sVornameTxtbx.Clear();
                m_nHausnummerTxtbx.Clear();
                m_sStrasseTxtbx.Clear();
                m_nPostleitzahlTxtbx.Clear();
                m_sOrtTxtbx.Clear();
            }
        }

        /// <summary>
        /// First sends out a message box to inquire for deletion confirmation. If yes, then opens up a connection and
        /// deletes row from datatable and then updates the database. Afterwards, it closes the connection, empties 
        /// input text boxes, and repaints the listbox and listview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _deleteBtn_Click(object sender, EventArgs e)
        {            
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "Delete?", MessageBoxButtons.YesNo);     
            if (dialogResult == DialogResult.Yes)
                {
                    using (OleDbConnection conn = new OleDbConnection(_sConnectionString))
                    {
                        conn.Open();

                        OleDbDataAdapter da = new OleDbDataAdapter();
                        OleDbCommand command = new OleDbCommand("Select * From Mitarbeiter", conn);
                        /*OleDbCommand command = new OleDbCommand("Delete * From Mitarbeiter where Name = ? and Vorname = ?; ", conn);
                        command.Parameters.Add("Name", OleDbType.LongVarWChar, 255);
                        command.Parameters.Add("Vorname", OleDbType.LongVarWChar, 255);
                        command.Parameters[0].Value = m_sNameTxtbx.Text;
                        command.Parameters[1].Value = m_sVornameTxtbx.Text;
                        command.Prepare();
                        command.ExecuteNonQuery();
                        */
                        OleDbCommandBuilder cmdb = new OleDbCommandBuilder(da);
                        da.SelectCommand = command;
                        try
                        {
                            _tbl.Rows[_nSelectedRow].Delete();
                        }
                        catch { Exception exc; }
                        da.UpdateCommand = cmdb.GetUpdateCommand();
                        da.Update(_tbl);
                        conn.Close();
                    }
                    

                    m_sNameTxtbx.Clear();
                    m_sVornameTxtbx.Clear();
                    m_nHausnummerTxtbx.Clear();
                    m_sStrasseTxtbx.Clear();
                    m_nPostleitzahlTxtbx.Clear();
                    m_sOrtTxtbx.Clear();


                    _blstContactList.RemoveAt(_nSelectedRow);
                    listView1.Items.Clear();
                    fillListView();
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                }
        }

        /// <summary>
        /// If a record in Listview is clicked, then the record's index is saved and the text boxes are filled with the 
        /// the record's content.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            _nSelectedRow = listView1.FocusedItem.Index;
            fillTxtBoxes();
        }

        /// <summary>
        /// If a record in Gridview is clicked, then the record's index is saved and the text boxes are filled with the 
        /// record's content. It captures the ID column value, so when the columns are sorted, the row can still be 
        /// identified by the ID number.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string dgcr = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            foreach (DataRow row in _tbl.Rows)
            {

                if (row[0].ToString() == dgcr)
                {
                    _nSelectedRow = _tbl.Rows.IndexOf(row);
                    //MessageBox.Show("Does " + row[0].ToString() + " = " + dgcr);
                }
            }


            //_selectedRow = dataGridView1.CurrentCell.RowIndex;
            fillTxtBoxes();
        }

        /// <summary>
        /// If a record is clicked in the listbox, then the record's index is saved and the text boxes are filled with 
        /// the record's content.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_Click(object sender, EventArgs e)
        {
            _nSelectedRow = listBox1.SelectedIndex;
            fillTxtBoxes();
        }
        #endregion
    }
}
