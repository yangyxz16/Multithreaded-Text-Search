using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg4_xxy180008
{
    /**
     * Class for the Form 1
     * which allows user find a text file to search for a keyword
     *
     * Written by Xizhen Yang for CS6326.001, Assignment 4, starting April 13, 2020
     * NetID: XXY180008
     */

    public partial class Form1 : Form
    {
        String fileName; // String variable for selected file name
        String keyword; // Variable for keyword user typed
        Boolean searching = false; // Boolean variable: true if searching / false if not
        Queue<Line> q; // A queue for store Line objects
        BackgroundWorker worker; // BackgroundWorker object for multi-threading

        public Form1() 
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) 
        {
            lb_warning.Visible = false; // Default: warning lable is invisible
            bt_search.Enabled = false; // Default: search botton disabled

            // Set up progress bar and make it invisible by default
            progressBar.Value = 0;
            progressBar.Maximum = 100;
            progressBar.Visible = false;
        }

        /// <summary>
        /// Function to handle action when browse botton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_browse_Click(object sender, EventArgs e)
        {
            // Reset UI
            tb_fileName.Clear();
            tb_search.Clear(); 
            listView.Items.Clear();
            lb_warning.Visible = false;
            progressBar.Visible = false;
            chooseFile(); // Call method to let user choose a file
        }

        /// <summary>
        /// Function to handle action when seach botton is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_search_Click(object sender, EventArgs e)
        {
            if (searching) // When it is searching, allow user to cancel to search
            {
                worker.CancelAsync();
                return;
            }

            fileName = tb_fileName.Text;
            // Check if the file exits
            if (File.Exists(fileName))
            {
                keyword = tb_search.Text.ToLower(); // Convert text to lower case

                if (keyword.Length == 0) // Check to make sure keyword is not empty
                {
                    // Warning
                    lb_warning.Visible = true;
                    lb_warning.Text = "INVAILD: search keyword empty";
                } 
                else // Ready to search
                {
                    searching = true;
                    bt_search.Text = "Cancel"; // Change the button text to "Cancel"
                    listView.Items.Clear(); // Empty the list view

                    // Disable UI
                    tb_fileName.Enabled = false;
                    tb_search.Enabled = false;
                    bt_browse.Enabled = false;
                    lb_warning.Visible = false;
                    progressBar.Value = 0; 

                    // Initialize the background worker
                    worker = new BackgroundWorker();

                    worker .WorkerSupportsCancellation = true;
                    worker.WorkerReportsProgress = true;
                    worker.DoWork += backgroundWorker_DoWork;
                    worker.ProgressChanged += backgroundWorker_ReportProcess;
                    worker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
                    
                    worker.RunWorkerAsync(); // Call backgroud worker to start searching
                }
            }
            else
            {
                // Warning
                lb_warning.Visible = true;
                lb_warning.Text = "FILE DOES NOT EXITS";
            }
        }

        /// <summary>
        /// Function to let user choose a file
        /// </summary>
        private void chooseFile()
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (!openFileDialog.FileName.EndsWith(".txt")) // Has to be a txt file
                {
                    // Display warning
                    lb_warning.Visible = true;
                    lb_warning.Text = "INVALID FILE TYPE";
                }  
                else // Read file successfully
                {
                    fileName = openFileDialog.FileName;
                    tb_fileName.Text = openFileDialog.FileName;
                    
                    lb_warning.Visible = true;
                    lb_warning.Text = "READ FILE SUCCESSFULLY";

                    // Enable analysis button, ready to analysis
                    bt_search.Enabled = true;
                }

            }
        }
           
        /// <summary>
        /// Display line number and text on list view
        /// </summary>
        /// <param name="lineNum"></param>
        /// <param name="text"></param>
        private void displayList(long lineNum, string text)
        {   
            // Create a new item for list view
            ListViewItem item = new ListViewItem("" + lineNum); 
            item.SubItems.Add(text);
            listView.Items.Add(item);
        }

        /// <summary>
        /// Function for backgroundWorker's work to do
        /// ----Search for the keyword from the file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            q = new Queue<Line>(); // Initializing the queue

            // Get total number of characters in the file
            FileInfo f = new FileInfo(fileName);
            long length = f.Length; 

            // Reader to read the file      
            System.IO.StreamReader file = new System.IO.StreamReader(fileName);
               
            long lineNum = 1; // Variable to count number of lines
            long charactersRead = 0; // Variable to count number of characters has read

            String l; // Let l be the entire line when read the file line by line

            while ((l = file.ReadLine()) != null)
            {
                if (worker.CancellationPending) // Work is canceled
                {
                   e.Cancel = true;
                    file.Close();
                    return;
                }

                if (l.ToLower().Contains(keyword)) // The current line contains the keyword
                {
                    q.Enqueue(new Line(lineNum, l)); // Add line number and content to the queue
                }
                charactersRead += l.Length; // Adding current line's characters
                int percentage = (int)(((double)charactersRead)  / length * 100.0); // Integer variable for the calculated percentage for progress

                worker.ReportProgress(percentage); // Report work progress with the percentage

                lineNum++; // Increase the line number
                System.Threading.Thread.Sleep(1);   // Pause one milisecond
            }

            file.Close(); // Complete file searching

        }

        /// <summary>
        /// Function for backgroundWorker when work progress changes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_ReportProcess(object sender, ProgressChangedEventArgs e)
        {
            while (q.Count != 0)
            {
                // Display message
                lb_warning.Visible = true;
                lb_warning.Text = e.ProgressPercentage + "% complete";
                // Display progress bar
                progressBar.Visible = true;
                progressBar.Value = e.ProgressPercentage;

                Line l = q.Dequeue(); //  Get the line number and content from the queue
                displayList(l.getNum(), l.getContent()); // Call displayList function to display at list view
            }
        }

        /// <summary>
        /// Function for backgroundWorker when work is completed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                    // Display message
                lb_warning.Visible = true;
                lb_warning.Text = "SEARCH CANCLED";
            } 
            else {
                // Display message
                lb_warning.Visible = true;
                lb_warning.Text = "SEARCH COMPLETED";

                progressBar.Value = 100;
            }

            // Enable all the text boxes and buttons
            tb_fileName.Enabled = true;
            tb_search.Enabled = true;
            bt_browse.Enabled = true;
            bt_search.Text = ("Search");

            searching = false;
        }
    }
}
