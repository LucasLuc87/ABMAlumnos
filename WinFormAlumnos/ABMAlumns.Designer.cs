namespace WinFormAlumnos
{
    partial class ABMAlumns
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSerach = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCoinside = new System.Windows.Forms.Label();
            this.btnLLenarContactos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 149);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.Size = new System.Drawing.Size(764, 259);
            this.dgvAlumnos.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(38, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Search";
            // 
            // txtSerach
            // 
            this.txtSerach.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerach.Location = new System.Drawing.Point(325, 57);
            this.txtSerach.Name = "txtSerach";
            this.txtSerach.Size = new System.Drawing.Size(230, 35);
            this.txtSerach.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(585, 57);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(69, 35);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(672, 57);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCoinside
            // 
            this.lblCoinside.AutoSize = true;
            this.lblCoinside.Location = new System.Drawing.Point(40, 23);
            this.lblCoinside.Name = "lblCoinside";
            this.lblCoinside.Size = new System.Drawing.Size(35, 13);
            this.lblCoinside.TabIndex = 4;
            this.lblCoinside.Text = "label1";
            // 
            // btnLLenarContactos
            // 
            this.btnLLenarContactos.Location = new System.Drawing.Point(12, 108);
            this.btnLLenarContactos.Name = "btnLLenarContactos";
            this.btnLLenarContactos.Size = new System.Drawing.Size(104, 35);
            this.btnLLenarContactos.TabIndex = 5;
            this.btnLLenarContactos.Text = "LLenar";
            this.btnLLenarContactos.UseVisualStyleBackColor = true;
            // 
            // ABMAlumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLLenarContactos);
            this.Controls.Add(this.lblCoinside);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSerach);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "ABMAlumns";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSerach;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCoinside;
        private System.Windows.Forms.Button btnLLenarContactos;
    }
}

