namespace WinFormsApp10EjmploDecido1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ObtenerClimaButton = new Button();
            Salida = new Button();
            TemperaturaIdaLabel = new Label();
            TemperaturaVueltaLabel = new Label();
            IconoIdaPictureBox = new PictureBox();
            IconoVueltaPictureBox = new PictureBox();
            FechaIdaDateTimePicker = new DateTimePicker();
            FechaVueltaDateTimePicker = new DateTimePicker();
            CiudadTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)IconoIdaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IconoVueltaPictureBox).BeginInit();
            SuspendLayout();
            // 
            // ObtenerClimaButton
            // 
            ObtenerClimaButton.Location = new Point(34, 368);
            ObtenerClimaButton.Name = "ObtenerClimaButton";
            ObtenerClimaButton.Size = new Size(75, 23);
            ObtenerClimaButton.TabIndex = 0;
            ObtenerClimaButton.Text = "Buscar clima";
            ObtenerClimaButton.UseVisualStyleBackColor = true;
            ObtenerClimaButton.Click += ObtenerClimaButton_Click;
            // 
            // Salida
            // 
            Salida.Location = new Point(690, 406);
            Salida.Name = "Salida";
            Salida.Size = new Size(75, 23);
            Salida.TabIndex = 1;
            Salida.Text = "Salida";
            Salida.UseVisualStyleBackColor = true;
            Salida.Click += Salida_Click;
            // 
            // TemperaturaIdaLabel
            // 
            TemperaturaIdaLabel.AutoSize = true;
            TemperaturaIdaLabel.Location = new Point(112, 200);
            TemperaturaIdaLabel.Name = "TemperaturaIdaLabel";
            TemperaturaIdaLabel.Size = new Size(95, 15);
            TemperaturaIdaLabel.TabIndex = 2;
            TemperaturaIdaLabel.Text = "Temperatura ida ";
            // 
            // TemperaturaVueltaLabel
            // 
            TemperaturaVueltaLabel.AutoSize = true;
            TemperaturaVueltaLabel.Location = new Point(387, 200);
            TemperaturaVueltaLabel.Name = "TemperaturaVueltaLabel";
            TemperaturaVueltaLabel.Size = new Size(108, 15);
            TemperaturaVueltaLabel.TabIndex = 3;
            TemperaturaVueltaLabel.Text = "Temperatura vuelta";
            // 
            // IconoIdaPictureBox
            // 
            IconoIdaPictureBox.Location = new Point(112, 252);
            IconoIdaPictureBox.Name = "IconoIdaPictureBox";
            IconoIdaPictureBox.Size = new Size(115, 73);
            IconoIdaPictureBox.TabIndex = 4;
            IconoIdaPictureBox.TabStop = false;
            // 
            // IconoVueltaPictureBox
            // 
            IconoVueltaPictureBox.Location = new Point(387, 252);
            IconoVueltaPictureBox.Name = "IconoVueltaPictureBox";
            IconoVueltaPictureBox.Size = new Size(128, 73);
            IconoVueltaPictureBox.TabIndex = 5;
            IconoVueltaPictureBox.TabStop = false;
            // 
            // FechaIdaDateTimePicker
            // 
            FechaIdaDateTimePicker.Location = new Point(112, 128);
            FechaIdaDateTimePicker.Name = "FechaIdaDateTimePicker";
            FechaIdaDateTimePicker.Size = new Size(200, 23);
            FechaIdaDateTimePicker.TabIndex = 6;
            // 
            // FechaVueltaDateTimePicker
            // 
            FechaVueltaDateTimePicker.Location = new Point(387, 128);
            FechaVueltaDateTimePicker.Name = "FechaVueltaDateTimePicker";
            FechaVueltaDateTimePicker.Size = new Size(200, 23);
            FechaVueltaDateTimePicker.TabIndex = 7;
            // 
            // CiudadTextBox
            // 
            CiudadTextBox.Location = new Point(112, 70);
            CiudadTextBox.Name = "CiudadTextBox";
            CiudadTextBox.Size = new Size(227, 23);
            CiudadTextBox.TabIndex = 8;
            CiudadTextBox.Text = "Escribe el nombre de la Ciudad";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CiudadTextBox);
            Controls.Add(FechaVueltaDateTimePicker);
            Controls.Add(FechaIdaDateTimePicker);
            Controls.Add(IconoVueltaPictureBox);
            Controls.Add(IconoIdaPictureBox);
            Controls.Add(TemperaturaVueltaLabel);
            Controls.Add(TemperaturaIdaLabel);
            Controls.Add(Salida);
            Controls.Add(ObtenerClimaButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)IconoIdaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)IconoVueltaPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ObtenerClimaButton;
        private Button Salida;
        private Label TemperaturaIdaLabel;
        private Label TemperaturaVueltaLabel;
        private PictureBox IconoIdaPictureBox;
        private PictureBox IconoVueltaPictureBox;
        private DateTimePicker FechaIdaDateTimePicker;
        private DateTimePicker FechaVueltaDateTimePicker;
        private TextBox CiudadTextBox;
    }
}