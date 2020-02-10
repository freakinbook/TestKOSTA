namespace TestKOSTA
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.mnemoLabel = new System.Windows.Forms.Label();
			this.deptNameLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.deptIdLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.surnameLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.patronymicLabel = new System.Windows.Forms.Label();
			this.employeeIdLabel = new System.Windows.Forms.Label();
			this.positionLabel = new System.Windows.Forms.Label();
			this.birthLabel = new System.Windows.Forms.Label();
			this.docSeriesLabel = new System.Windows.Forms.Label();
			this.docNumLabel = new System.Windows.Forms.Label();
			this.editButton = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.addEmpButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.18538F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.81462F));
			this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(15);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(561, 450);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.FullRowSelect = true;
			this.treeView1.Location = new System.Drawing.Point(10, 10);
			this.treeView1.Margin = new System.Windows.Forms.Padding(10);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(182, 430);
			this.treeView1.TabIndex = 0;
			this.treeView1.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView1_BeforeCollapse);
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tableLayoutPanel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(212, 10);
			this.panel1.Margin = new System.Windows.Forms.Padding(10);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(339, 430);
			this.panel1.TabIndex = 1;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.60317F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.39683F));
			this.tableLayoutPanel2.Controls.Add(this.addEmpButton, 0, 14);
			this.tableLayoutPanel2.Controls.Add(this.mnemoLabel, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.deptNameLabel, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.deptIdLabel, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.label5, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 9);
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 8);
			this.tableLayoutPanel2.Controls.Add(this.label9, 0, 10);
			this.tableLayoutPanel2.Controls.Add(this.label10, 0, 11);
			this.tableLayoutPanel2.Controls.Add(this.surnameLabel, 1, 4);
			this.tableLayoutPanel2.Controls.Add(this.nameLabel, 1, 5);
			this.tableLayoutPanel2.Controls.Add(this.patronymicLabel, 1, 6);
			this.tableLayoutPanel2.Controls.Add(this.employeeIdLabel, 1, 7);
			this.tableLayoutPanel2.Controls.Add(this.positionLabel, 1, 8);
			this.tableLayoutPanel2.Controls.Add(this.birthLabel, 1, 9);
			this.tableLayoutPanel2.Controls.Add(this.docSeriesLabel, 1, 10);
			this.tableLayoutPanel2.Controls.Add(this.docNumLabel, 1, 11);
			this.tableLayoutPanel2.Controls.Add(this.editButton, 1, 12);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 15;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(339, 430);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// mnemoLabel
			// 
			this.mnemoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.mnemoLabel.AutoSize = true;
			this.mnemoLabel.Location = new System.Drawing.Point(86, 73);
			this.mnemoLabel.Name = "mnemoLabel";
			this.mnemoLabel.Size = new System.Drawing.Size(250, 13);
			this.mnemoLabel.TabIndex = 4;
			this.mnemoLabel.Text = "label";
			this.mnemoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// deptNameLabel
			// 
			this.deptNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.deptNameLabel.AutoSize = true;
			this.tableLayoutPanel2.SetColumnSpan(this.deptNameLabel, 2);
			this.deptNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deptNameLabel.Location = new System.Drawing.Point(3, 16);
			this.deptNameLabel.Name = "deptNameLabel";
			this.deptNameLabel.Size = new System.Drawing.Size(333, 17);
			this.deptNameLabel.TabIndex = 0;
			this.deptNameLabel.Text = "label1";
			this.deptNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "ID:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Mnemocode:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// deptIdLabel
			// 
			this.deptIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.deptIdLabel.AutoSize = true;
			this.deptIdLabel.Location = new System.Drawing.Point(86, 53);
			this.deptIdLabel.Name = "deptIdLabel";
			this.deptIdLabel.Size = new System.Drawing.Size(250, 13);
			this.deptIdLabel.TabIndex = 3;
			this.deptIdLabel.Text = "label";
			this.deptIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Surname:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "First Name:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Patronymic:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 183);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "ID:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 223);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "Date of birth:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 203);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Position:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 243);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(77, 13);
			this.label9.TabIndex = 11;
			this.label9.Text = "Doc series:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 263);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(77, 13);
			this.label10.TabIndex = 12;
			this.label10.Text = "Doc number:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// surnameLabel
			// 
			this.surnameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.surnameLabel.AutoSize = true;
			this.surnameLabel.Location = new System.Drawing.Point(86, 123);
			this.surnameLabel.Name = "surnameLabel";
			this.surnameLabel.Size = new System.Drawing.Size(250, 13);
			this.surnameLabel.TabIndex = 13;
			this.surnameLabel.Text = "label";
			this.surnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// nameLabel
			// 
			this.nameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.nameLabel.AutoSize = true;
			this.nameLabel.Location = new System.Drawing.Point(86, 143);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(250, 13);
			this.nameLabel.TabIndex = 14;
			this.nameLabel.Text = "label";
			this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// patronymicLabel
			// 
			this.patronymicLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.patronymicLabel.AutoSize = true;
			this.patronymicLabel.Location = new System.Drawing.Point(86, 163);
			this.patronymicLabel.Name = "patronymicLabel";
			this.patronymicLabel.Size = new System.Drawing.Size(250, 13);
			this.patronymicLabel.TabIndex = 15;
			this.patronymicLabel.Text = "label";
			this.patronymicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// employeeIdLabel
			// 
			this.employeeIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.employeeIdLabel.AutoSize = true;
			this.employeeIdLabel.Location = new System.Drawing.Point(86, 183);
			this.employeeIdLabel.Name = "employeeIdLabel";
			this.employeeIdLabel.Size = new System.Drawing.Size(250, 13);
			this.employeeIdLabel.TabIndex = 16;
			this.employeeIdLabel.Text = "label";
			this.employeeIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// positionLabel
			// 
			this.positionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.positionLabel.AutoSize = true;
			this.positionLabel.Location = new System.Drawing.Point(86, 203);
			this.positionLabel.Name = "positionLabel";
			this.positionLabel.Size = new System.Drawing.Size(250, 13);
			this.positionLabel.TabIndex = 17;
			this.positionLabel.Text = "label";
			this.positionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// birthLabel
			// 
			this.birthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.birthLabel.AutoSize = true;
			this.birthLabel.Location = new System.Drawing.Point(86, 223);
			this.birthLabel.Name = "birthLabel";
			this.birthLabel.Size = new System.Drawing.Size(250, 13);
			this.birthLabel.TabIndex = 18;
			this.birthLabel.Text = "label";
			this.birthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// docSeriesLabel
			// 
			this.docSeriesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.docSeriesLabel.AutoSize = true;
			this.docSeriesLabel.Location = new System.Drawing.Point(86, 243);
			this.docSeriesLabel.Name = "docSeriesLabel";
			this.docSeriesLabel.Size = new System.Drawing.Size(250, 13);
			this.docSeriesLabel.TabIndex = 19;
			this.docSeriesLabel.Text = "label";
			this.docSeriesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// docNumLabel
			// 
			this.docNumLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.docNumLabel.AutoSize = true;
			this.docNumLabel.Location = new System.Drawing.Point(86, 263);
			this.docNumLabel.Name = "docNumLabel";
			this.docNumLabel.Size = new System.Drawing.Size(250, 13);
			this.docNumLabel.TabIndex = 20;
			this.docNumLabel.Text = "label";
			this.docNumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// editButton
			// 
			this.editButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.editButton.Location = new System.Drawing.Point(86, 283);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(86, 23);
			this.editButton.TabIndex = 21;
			this.editButton.Text = "Edit";
			this.editButton.UseVisualStyleBackColor = true;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "department.png");
			this.imageList1.Images.SetKeyName(1, "user.png");
			// 
			// addEmpButton
			// 
			this.addEmpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.addEmpButton.Location = new System.Drawing.Point(3, 402);
			this.addEmpButton.Name = "addEmpButton";
			this.addEmpButton.Size = new System.Drawing.Size(77, 23);
			this.addEmpButton.TabIndex = 23;
			this.addEmpButton.Text = "Add new";
			this.addEmpButton.UseVisualStyleBackColor = true;
			this.addEmpButton.Click += new System.EventHandler(this.addEmpButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(561, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Рога и копыта";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label mnemoLabel;
		private System.Windows.Forms.Label deptNameLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label deptIdLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label surnameLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label patronymicLabel;
		private System.Windows.Forms.Label employeeIdLabel;
		private System.Windows.Forms.Label positionLabel;
		private System.Windows.Forms.Label birthLabel;
		private System.Windows.Forms.Label docSeriesLabel;
		private System.Windows.Forms.Label docNumLabel;
		private System.Windows.Forms.Button editButton;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Button addEmpButton;
	}
}

