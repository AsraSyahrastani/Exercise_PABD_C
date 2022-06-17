
namespace Exercise_PABD_C
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.No_Telp = new System.Windows.Forms.TextBox();
            this.Teks_Data_Karyawan = new System.Windows.Forms.TextBox();
            this.Stok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataSet3 = new Exercise_PABD_C.DataSet3();
            this.pemilikTokoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pemilik_TokoTableAdapter = new Exercise_PABD_C.DataSet3TableAdapters.Pemilik_TokoTableAdapter();
            this.Nik = new System.Windows.Forms.TextBox();
            this.Nama_Pemilik = new System.Windows.Forms.TextBox();
            this.Karyawan = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Nama = new System.Windows.Forms.TextBox();
            this.Harga = new System.Windows.Forms.TextBox();
            this.pemilikTokoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pemilikTokoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet4 = new Exercise_PABD_C.DataSet4();
            this.namaKaryawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nama_KaryawanTableAdapter = new Exercise_PABD_C.DataSet4TableAdapters.Nama_KaryawanTableAdapter();
            this.namaKaryawanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.namaKaryawanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet5 = new Exercise_PABD_C.DataSet5();
            this.sembakoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sembakoTableAdapter = new Exercise_PABD_C.DataSet5TableAdapters.SembakoTableAdapter();
            this.sembakoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sembakoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem2 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem2 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem2 = new System.Windows.Forms.ToolStripButton();
            this.Update = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikTokoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikTokoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikTokoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaKaryawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaKaryawanBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaKaryawanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "DataPemilik";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DataKaryawan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(610, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "HargaSembako";
            // 
            // No_Telp
            // 
            this.No_Telp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pemilikTokoBindingSource, "No_Telpon", true));
            this.No_Telp.Location = new System.Drawing.Point(68, 298);
            this.No_Telp.Name = "No_Telp";
            this.No_Telp.Size = new System.Drawing.Size(100, 22);
            this.No_Telp.TabIndex = 3;
            this.No_Telp.TextChanged += new System.EventHandler(this.Teks_Data_Pemilik_TextChanged);
            // 
            // Teks_Data_Karyawan
            // 
            this.Teks_Data_Karyawan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.namaKaryawanBindingSource2, "No_Telp", true));
            this.Teks_Data_Karyawan.Location = new System.Drawing.Point(335, 298);
            this.Teks_Data_Karyawan.Name = "Teks_Data_Karyawan";
            this.Teks_Data_Karyawan.Size = new System.Drawing.Size(100, 22);
            this.Teks_Data_Karyawan.TabIndex = 4;
            // 
            // Stok
            // 
            this.Stok.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sembakoBindingSource2, "Jumlah_Stok", true));
            this.Stok.Location = new System.Drawing.Point(613, 298);
            this.Stok.Name = "Stok";
            this.Stok.Size = new System.Drawing.Size(100, 22);
            this.Stok.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Toko Sejahtera Umat";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dataSet3
            // 
            this.dataSet3.DataSetName = "DataSet3";
            this.dataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pemilikTokoBindingSource
            // 
            this.pemilikTokoBindingSource.DataMember = "Pemilik_Toko";
            this.pemilikTokoBindingSource.DataSource = this.dataSet3;
            // 
            // pemilik_TokoTableAdapter
            // 
            this.pemilik_TokoTableAdapter.ClearBeforeFill = true;
            // 
            // Nik
            // 
            this.Nik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pemilikTokoBindingSource2, "Nik", true));
            this.Nik.Location = new System.Drawing.Point(68, 240);
            this.Nik.Name = "Nik";
            this.Nik.Size = new System.Drawing.Size(100, 22);
            this.Nik.TabIndex = 7;
            // 
            // Nama_Pemilik
            // 
            this.Nama_Pemilik.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pemilikTokoBindingSource1, "Nama_Pemilik", true));
            this.Nama_Pemilik.Location = new System.Drawing.Point(68, 176);
            this.Nama_Pemilik.Name = "Nama_Pemilik";
            this.Nama_Pemilik.Size = new System.Drawing.Size(100, 22);
            this.Nama_Pemilik.TabIndex = 8;
            // 
            // Karyawan
            // 
            this.Karyawan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.namaKaryawanBindingSource, "Nama_Karyawan", true));
            this.Karyawan.Location = new System.Drawing.Point(335, 176);
            this.Karyawan.Name = "Karyawan";
            this.Karyawan.Size = new System.Drawing.Size(100, 22);
            this.Karyawan.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.namaKaryawanBindingSource1, "Nik", true));
            this.textBox4.Location = new System.Drawing.Point(332, 240);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 10;
            // 
            // Nama
            // 
            this.Nama.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sembakoBindingSource, "Nama_Sembako", true));
            this.Nama.Location = new System.Drawing.Point(613, 176);
            this.Nama.Name = "Nama";
            this.Nama.Size = new System.Drawing.Size(100, 22);
            this.Nama.TabIndex = 11;
            // 
            // Harga
            // 
            this.Harga.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sembakoBindingSource1, "Harga_Sembako", true));
            this.Harga.Location = new System.Drawing.Point(615, 239);
            this.Harga.Name = "Harga";
            this.Harga.Size = new System.Drawing.Size(100, 22);
            this.Harga.TabIndex = 12;
            // 
            // pemilikTokoBindingSource1
            // 
            this.pemilikTokoBindingSource1.DataMember = "Pemilik_Toko";
            this.pemilikTokoBindingSource1.DataSource = this.dataSet3;
            // 
            // pemilikTokoBindingSource2
            // 
            this.pemilikTokoBindingSource2.DataMember = "Pemilik_Toko";
            this.pemilikTokoBindingSource2.DataSource = this.dataSet3;
            // 
            // dataSet4
            // 
            this.dataSet4.DataSetName = "DataSet4";
            this.dataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // namaKaryawanBindingSource
            // 
            this.namaKaryawanBindingSource.DataMember = "Nama_Karyawan";
            this.namaKaryawanBindingSource.DataSource = this.dataSet4;
            // 
            // nama_KaryawanTableAdapter
            // 
            this.nama_KaryawanTableAdapter.ClearBeforeFill = true;
            // 
            // namaKaryawanBindingSource1
            // 
            this.namaKaryawanBindingSource1.DataMember = "Nama_Karyawan";
            this.namaKaryawanBindingSource1.DataSource = this.dataSet4;
            // 
            // namaKaryawanBindingSource2
            // 
            this.namaKaryawanBindingSource2.DataMember = "Nama_Karyawan";
            this.namaKaryawanBindingSource2.DataSource = this.dataSet4;
            // 
            // dataSet5
            // 
            this.dataSet5.DataSetName = "DataSet5";
            this.dataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sembakoBindingSource
            // 
            this.sembakoBindingSource.DataMember = "Sembako";
            this.sembakoBindingSource.DataSource = this.dataSet5;
            // 
            // sembakoTableAdapter
            // 
            this.sembakoTableAdapter.ClearBeforeFill = true;
            // 
            // sembakoBindingSource1
            // 
            this.sembakoBindingSource1.DataMember = "Sembako";
            this.sembakoBindingSource1.DataSource = this.dataSet5;
            // 
            // sembakoBindingSource2
            // 
            this.sembakoBindingSource2.DataMember = "Sembako";
            this.sembakoBindingSource2.DataSource = this.dataSet5;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem2;
            this.bindingNavigator3.BindingSource = this.sembakoBindingSource1;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem2;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem2;
            this.bindingNavigator3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem2,
            this.bindingNavigatorMovePreviousItem2,
            this.bindingNavigatorSeparator6,
            this.bindingNavigatorPositionItem2,
            this.bindingNavigatorCountItem2,
            this.bindingNavigatorSeparator7,
            this.bindingNavigatorMoveNextItem2,
            this.bindingNavigatorMoveLastItem2,
            this.bindingNavigatorSeparator8,
            this.bindingNavigatorAddNewItem2,
            this.bindingNavigatorDeleteItem2});
            this.bindingNavigator3.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem2;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem2;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem2;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem2;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem2;
            this.bindingNavigator3.Size = new System.Drawing.Size(800, 31);
            this.bindingNavigator3.TabIndex = 15;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorMoveFirstItem2
            // 
            this.bindingNavigatorMoveFirstItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem2.Image")));
            this.bindingNavigatorMoveFirstItem2.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem2.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem2.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem2
            // 
            this.bindingNavigatorMovePreviousItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem2.Image")));
            this.bindingNavigatorMovePreviousItem2.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem2.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem2.Text = "Move previous";
            // 
            // bindingNavigatorSeparator6
            // 
            this.bindingNavigatorSeparator6.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator6.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem2
            // 
            this.bindingNavigatorPositionItem2.AccessibleName = "Position";
            this.bindingNavigatorPositionItem2.AutoSize = false;
            this.bindingNavigatorPositionItem2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem2.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem2.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem2.Text = "0";
            this.bindingNavigatorPositionItem2.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem2
            // 
            this.bindingNavigatorCountItem2.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem2.Size = new System.Drawing.Size(45, 28);
            this.bindingNavigatorCountItem2.Text = "of {0}";
            this.bindingNavigatorCountItem2.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator7
            // 
            this.bindingNavigatorSeparator7.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator7.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem2
            // 
            this.bindingNavigatorMoveNextItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem2.Image")));
            this.bindingNavigatorMoveNextItem2.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem2.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem2.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem2
            // 
            this.bindingNavigatorMoveLastItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem2.Image")));
            this.bindingNavigatorMoveLastItem2.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem2.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem2.Text = "Move last";
            // 
            // bindingNavigatorSeparator8
            // 
            this.bindingNavigatorSeparator8.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator8.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorAddNewItem2
            // 
            this.bindingNavigatorAddNewItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem2.Image")));
            this.bindingNavigatorAddNewItem2.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem2.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem2.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem2
            // 
            this.bindingNavigatorDeleteItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem2.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem2.Image")));
            this.bindingNavigatorDeleteItem2.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem2.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem2.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem2.Text = "Delete";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(68, 393);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 16;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(345, 393);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 17;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(615, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.bindingNavigator3);
            this.Controls.Add(this.Harga);
            this.Controls.Add(this.Nama);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Karyawan);
            this.Controls.Add(this.Nama_Pemilik);
            this.Controls.Add(this.Nik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Stok);
            this.Controls.Add(this.Teks_Data_Karyawan);
            this.Controls.Add(this.No_Telp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikTokoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikTokoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemilikTokoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaKaryawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaKaryawanBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namaKaryawanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sembakoBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox No_Telp;
        private System.Windows.Forms.TextBox Teks_Data_Karyawan;
        private System.Windows.Forms.TextBox Stok;
        private System.Windows.Forms.Label label4;
        private DataSet3 dataSet3;
        private System.Windows.Forms.BindingSource pemilikTokoBindingSource;
        private DataSet3TableAdapters.Pemilik_TokoTableAdapter pemilik_TokoTableAdapter;
        private System.Windows.Forms.TextBox Nik;
        private System.Windows.Forms.TextBox Nama_Pemilik;
        private System.Windows.Forms.TextBox Karyawan;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox Nama;
        private System.Windows.Forms.TextBox Harga;
        private System.Windows.Forms.BindingSource pemilikTokoBindingSource2;
        private System.Windows.Forms.BindingSource pemilikTokoBindingSource1;
        private DataSet4 dataSet4;
        private System.Windows.Forms.BindingSource namaKaryawanBindingSource;
        private DataSet4TableAdapters.Nama_KaryawanTableAdapter nama_KaryawanTableAdapter;
        private System.Windows.Forms.BindingSource namaKaryawanBindingSource2;
        private System.Windows.Forms.BindingSource namaKaryawanBindingSource1;
        private DataSet5 dataSet5;
        private System.Windows.Forms.BindingSource sembakoBindingSource;
        private DataSet5TableAdapters.SembakoTableAdapter sembakoTableAdapter;
        private System.Windows.Forms.BindingSource sembakoBindingSource2;
        private System.Windows.Forms.BindingSource sembakoBindingSource1;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem2;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator6;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator7;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem2;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator8;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button button3;
    }
}