namespace StudentRegistrationApplication
{
    partial class Form1
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
            System.Windows.Forms.Label label8;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastnamebox = new System.Windows.Forms.TextBox();
            this.firstnamebox = new System.Windows.Forms.TextBox();
            this.middlenamebox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.malebtn = new System.Windows.Forms.RadioButton();
            this.femalebtn = new System.Windows.Forms.RadioButton();
            this.daybox = new System.Windows.Forms.ComboBox();
            this.monthbox = new System.Windows.Forms.ComboBox();
            this.yearbox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Registration Form";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last name *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "First name *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Middle name *";
            // 
            // lastnamebox
            // 
            this.lastnamebox.Location = new System.Drawing.Point(8, 73);
            this.lastnamebox.Name = "lastnamebox";
            this.lastnamebox.Size = new System.Drawing.Size(282, 20);
            this.lastnamebox.TabIndex = 5;
            // 
            // firstnamebox
            // 
            this.firstnamebox.Location = new System.Drawing.Point(8, 117);
            this.firstnamebox.Name = "firstnamebox";
            this.firstnamebox.Size = new System.Drawing.Size(282, 20);
            this.firstnamebox.TabIndex = 6;
            // 
            // middlenamebox
            // 
            this.middlenamebox.Location = new System.Drawing.Point(8, 166);
            this.middlenamebox.Name = "middlenamebox";
            this.middlenamebox.Size = new System.Drawing.Size(282, 20);
            this.middlenamebox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Gender *";
            // 
            // malebtn
            // 
            this.malebtn.AutoSize = true;
            this.malebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.malebtn.Location = new System.Drawing.Point(93, 201);
            this.malebtn.Name = "malebtn";
            this.malebtn.Size = new System.Drawing.Size(62, 22);
            this.malebtn.TabIndex = 9;
            this.malebtn.TabStop = true;
            this.malebtn.Text = "Male";
            this.malebtn.UseVisualStyleBackColor = true;
            // 
            // femalebtn
            // 
            this.femalebtn.AutoSize = true;
            this.femalebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femalebtn.Location = new System.Drawing.Point(161, 201);
            this.femalebtn.Name = "femalebtn";
            this.femalebtn.Size = new System.Drawing.Size(86, 24);
            this.femalebtn.TabIndex = 10;
            this.femalebtn.TabStop = true;
            this.femalebtn.Text = "Female";
            this.femalebtn.UseVisualStyleBackColor = true;
            // 
            // daybox
            // 
            this.daybox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daybox.FormattingEnabled = true;
            this.daybox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.daybox.Location = new System.Drawing.Point(15, 256);
            this.daybox.Name = "daybox";
            this.daybox.Size = new System.Drawing.Size(72, 24);
            this.daybox.TabIndex = 11;
            this.daybox.Text = "-Day-";
            // 
            // monthbox
            // 
            this.monthbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthbox.FormattingEnabled = true;
            this.monthbox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthbox.Location = new System.Drawing.Point(106, 256);
            this.monthbox.Name = "monthbox";
            this.monthbox.Size = new System.Drawing.Size(72, 24);
            this.monthbox.TabIndex = 12;
            this.monthbox.Text = "-Month-";
            // 
            // yearbox
            // 
            this.yearbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearbox.FormattingEnabled = true;
            this.yearbox.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026"});
            this.yearbox.Location = new System.Drawing.Point(195, 256);
            this.yearbox.Name = "yearbox";
            this.yearbox.Size = new System.Drawing.Size(75, 24);
            this.yearbox.TabIndex = 13;
            this.yearbox.Text = "-Year-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date of birth *";
            // 
            // Registerbtn
            // 
            this.Registerbtn.BackColor = System.Drawing.Color.Firebrick;
            this.Registerbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Registerbtn.Location = new System.Drawing.Point(47, 372);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(202, 45);
            this.Registerbtn.TabIndex = 16;
            this.Registerbtn.Text = "Register Student";
            this.Registerbtn.UseVisualStyleBackColor = false;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 321);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(239, 28);
            this.comboBox1.TabIndex = 17;
            this.comboBox1.Text = "-Select program-";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(12, 298);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(156, 20);
            label8.TabIndex = 18;
            label8.Text = "Program to apply *";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 450);
            this.Controls.Add(label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.yearbox);
            this.Controls.Add(this.monthbox);
            this.Controls.Add(this.daybox);
            this.Controls.Add(this.femalebtn);
            this.Controls.Add(this.malebtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.middlenamebox);
            this.Controls.Add(this.firstnamebox);
            this.Controls.Add(this.lastnamebox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastnamebox;
        private System.Windows.Forms.TextBox firstnamebox;
        private System.Windows.Forms.TextBox middlenamebox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton malebtn;
        private System.Windows.Forms.RadioButton femalebtn;
        private System.Windows.Forms.ComboBox daybox;
        private System.Windows.Forms.ComboBox monthbox;
        private System.Windows.Forms.ComboBox yearbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

