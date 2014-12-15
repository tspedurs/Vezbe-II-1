namespace Kamata
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label nazivLabel;
            System.Windows.Forms.Label adresaLabel;
            System.Windows.Forms.Label poverilacIDLabel;
            System.Windows.Forms.Label nazivLabel1;
            System.Windows.Forms.Label adresaLabel1;
            this.kamateDataSet1 = new Kamata.kamateDataSet();
            this.duzniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.duzniciTableAdapter = new Kamata.kamateDataSetTableAdapters.DuzniciTableAdapter();
            this.tableAdapterManager = new Kamata.kamateDataSetTableAdapters.TableAdapterManager();
            this.duzniciBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.duzniciBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nazivTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.kamateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kamateTableAdapter = new Kamata.kamateDataSetTableAdapters.KamateTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.poveriociBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poveriociTableAdapter = new Kamata.kamateDataSetTableAdapters.PoveriociTableAdapter();
            this.fKKamateToPoveriociBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adresaTextBox1 = new System.Windows.Forms.TextBox();
            nazivLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            poverilacIDLabel = new System.Windows.Forms.Label();
            nazivLabel1 = new System.Windows.Forms.Label();
            adresaLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kamateDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duzniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duzniciBindingNavigator)).BeginInit();
            this.duzniciBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kamateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poveriociBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKamateToPoveriociBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // kamateDataSet1
            // 
            this.kamateDataSet1.DataSetName = "kamateDataSet";
            this.kamateDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // duzniciBindingSource
            // 
            this.duzniciBindingSource.DataMember = "Duznici";
            this.duzniciBindingSource.DataSource = this.kamateDataSet1;
            // 
            // duzniciTableAdapter
            // 
            this.duzniciTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DuzniciTableAdapter = this.duzniciTableAdapter;
            this.tableAdapterManager.KamateTableAdapter = null;
            this.tableAdapterManager.PoveriociTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kamata.kamateDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // duzniciBindingNavigator
            // 
            this.duzniciBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.duzniciBindingNavigator.BindingSource = this.duzniciBindingSource;
            this.duzniciBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.duzniciBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.duzniciBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.duzniciBindingNavigatorSaveItem});
            this.duzniciBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.duzniciBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.duzniciBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.duzniciBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.duzniciBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.duzniciBindingNavigator.Name = "duzniciBindingNavigator";
            this.duzniciBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.duzniciBindingNavigator.Size = new System.Drawing.Size(645, 25);
            this.duzniciBindingNavigator.TabIndex = 0;
            this.duzniciBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // duzniciBindingNavigatorSaveItem
            // 
            this.duzniciBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.duzniciBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("duzniciBindingNavigatorSaveItem.Image")));
            this.duzniciBindingNavigatorSaveItem.Name = "duzniciBindingNavigatorSaveItem";
            this.duzniciBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.duzniciBindingNavigatorSaveItem.Text = "Save Data";
            this.duzniciBindingNavigatorSaveItem.Click += new System.EventHandler(this.duzniciBindingNavigatorSaveItem_Click);
            // 
            // nazivLabel
            // 
            nazivLabel.AutoSize = true;
            nazivLabel.Location = new System.Drawing.Point(23, 73);
            nazivLabel.Name = "nazivLabel";
            nazivLabel.Size = new System.Drawing.Size(37, 13);
            nazivLabel.TabIndex = 1;
            nazivLabel.Text = "Naziv:";
            // 
            // nazivTextBox
            // 
            this.nazivTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.duzniciBindingSource, "Naziv", true));
            this.nazivTextBox.Location = new System.Drawing.Point(66, 70);
            this.nazivTextBox.Name = "nazivTextBox";
            this.nazivTextBox.Size = new System.Drawing.Size(100, 20);
            this.nazivTextBox.TabIndex = 2;
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Location = new System.Drawing.Point(17, 102);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(43, 13);
            adresaLabel.TabIndex = 3;
            adresaLabel.Text = "Adresa:";
            adresaLabel.Click += new System.EventHandler(this.adresaLabel_Click);
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.duzniciBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(66, 99);
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(100, 20);
            this.adresaTextBox.TabIndex = 4;
            // 
            // kamateBindingSource
            // 
            this.kamateBindingSource.DataMember = "Kamate";
            this.kamateBindingSource.DataSource = this.kamateDataSet1;
            // 
            // kamateTableAdapter
            // 
            this.kamateTableAdapter.ClearBeforeFill = true;
            // 
            // poverilacIDLabel
            // 
            poverilacIDLabel.AutoSize = true;
            poverilacIDLabel.Location = new System.Drawing.Point(350, 45);
            poverilacIDLabel.Name = "poverilacIDLabel";
            poverilacIDLabel.Size = new System.Drawing.Size(68, 13);
            poverilacIDLabel.TabIndex = 5;
            poverilacIDLabel.Text = "Poverilac ID:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kamateBindingSource, "PoverilacID", true));
            this.comboBox1.DataSource = this.poveriociBindingSource;
            this.comboBox1.DisplayMember = "Naziv";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(385, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "Id";
            // 
            // poveriociBindingSource
            // 
            this.poveriociBindingSource.DataMember = "Poverioci";
            this.poveriociBindingSource.DataSource = this.kamateDataSet1;
            // 
            // poveriociTableAdapter
            // 
            this.poveriociTableAdapter.ClearBeforeFill = true;
            // 
            // nazivLabel1
            // 
            nazivLabel1.AutoSize = true;
            nazivLabel1.Location = new System.Drawing.Point(333, 76);
            nazivLabel1.Name = "nazivLabel1";
            nazivLabel1.Size = new System.Drawing.Size(37, 13);
            nazivLabel1.TabIndex = 7;
            nazivLabel1.Text = "Naziv:";
            // 
            // fKKamateToPoveriociBindingSource
            // 
            this.fKKamateToPoveriociBindingSource.DataMember = "FK_Kamate_ToPoverioci";
            this.fKKamateToPoveriociBindingSource.DataSource = this.poveriociBindingSource;
            // 
            // adresaLabel1
            // 
            adresaLabel1.AutoSize = true;
            adresaLabel1.Location = new System.Drawing.Point(327, 106);
            adresaLabel1.Name = "adresaLabel1";
            adresaLabel1.Size = new System.Drawing.Size(43, 13);
            adresaLabel1.TabIndex = 8;
            adresaLabel1.Text = "Adresa:";
            // 
            // adresaTextBox1
            // 
            this.adresaTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.poveriociBindingSource, "Adresa", true));
            this.adresaTextBox1.Location = new System.Drawing.Point(385, 100);
            this.adresaTextBox1.Name = "adresaTextBox1";
            this.adresaTextBox1.Size = new System.Drawing.Size(209, 20);
            this.adresaTextBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 317);
            this.Controls.Add(adresaLabel1);
            this.Controls.Add(this.adresaTextBox1);
            this.Controls.Add(nazivLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(poverilacIDLabel);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(nazivLabel);
            this.Controls.Add(this.nazivTextBox);
            this.Controls.Add(this.duzniciBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kamateDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duzniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duzniciBindingNavigator)).EndInit();
            this.duzniciBindingNavigator.ResumeLayout(false);
            this.duzniciBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kamateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poveriociBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKKamateToPoveriociBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private kamateDataSet kamateDataSet1;
        private System.Windows.Forms.BindingSource duzniciBindingSource;
        private kamateDataSetTableAdapters.DuzniciTableAdapter duzniciTableAdapter;
        private kamateDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator duzniciBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton duzniciBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nazivTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.BindingSource kamateBindingSource;
        private kamateDataSetTableAdapters.KamateTableAdapter kamateTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource poveriociBindingSource;
        private kamateDataSetTableAdapters.PoveriociTableAdapter poveriociTableAdapter;
        private System.Windows.Forms.BindingSource fKKamateToPoveriociBindingSource;
        private System.Windows.Forms.TextBox adresaTextBox1;
    }
}

