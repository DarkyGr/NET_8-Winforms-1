namespace Incidencias.Forms
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            btn_Reportes = new Button();
            btn_Add = new Button();
            SuspendLayout();
            // 
            // btn_Reportes
            // 
            btn_Reportes.Cursor = Cursors.Hand;
            btn_Reportes.ForeColor = SystemColors.Highlight;
            btn_Reportes.Image = (Image)resources.GetObject("btn_Reportes.Image");
            btn_Reportes.Location = new Point(93, 188);
            btn_Reportes.Name = "btn_Reportes";
            btn_Reportes.Size = new Size(108, 106);
            btn_Reportes.TabIndex = 0;
            btn_Reportes.Text = "Reportes";
            btn_Reportes.TextAlign = ContentAlignment.BottomCenter;
            btn_Reportes.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Reportes.UseVisualStyleBackColor = true;
            // 
            // btn_Add
            // 
            btn_Add.Cursor = Cursors.Hand;
            btn_Add.ForeColor = Color.MediumSeaGreen;
            btn_Add.Image = (Image)resources.GetObject("btn_Add.Image");
            btn_Add.Location = new Point(93, 39);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(108, 106);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "Agregar Incidencia";
            btn_Add.TextAlign = ContentAlignment.BottomCenter;
            btn_Add.TextImageRelation = TextImageRelation.ImageAboveText;
            btn_Add.UseVisualStyleBackColor = true;
            btn_Add.Click += btn_Add_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 344);
            Controls.Add(btn_Add);
            Controls.Add(btn_Reportes);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Home";
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Reportes;
        private Button btn_Add;
    }
}