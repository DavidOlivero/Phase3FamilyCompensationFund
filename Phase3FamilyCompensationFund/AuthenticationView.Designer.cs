namespace Phase3FamilyCompensationFund;

partial class AuthenticationView
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthenticationView));
        pictureBox1 = new System.Windows.Forms.PictureBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        TbPassword = new System.Windows.Forms.TextBox();
        Btn1 = new System.Windows.Forms.Button();
        Btn3 = new System.Windows.Forms.Button();
        Btn2 = new System.Windows.Forms.Button();
        Btn4 = new System.Windows.Forms.Button();
        Btn5 = new System.Windows.Forms.Button();
        Btn6 = new System.Windows.Forms.Button();
        Btn7 = new System.Windows.Forms.Button();
        Btn8 = new System.Windows.Forms.Button();
        Btn9 = new System.Windows.Forms.Button();
        BtnLogin = new System.Windows.Forms.Button();
        BtnClear = new System.Windows.Forms.Button();
        BtnClose = new System.Windows.Forms.Button();
        menuStrip1 = new System.Windows.Forms.MenuStrip();
        acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        courseInfo = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.ErrorImage = null;
        pictureBox1.Image = ((System.Drawing.Image)resources.GetObject("pictureBox1.Image"));
        pictureBox1.InitialImage = null;
        pictureBox1.Location = new System.Drawing.Point(-493, 27);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(901, 496);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(434, 41);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(436, 56);
        label1.TabIndex = 1;
        label1.Text = "CAJA DE COMPENSACIÓN FAMILIAR";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(434, 85);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(439, 40);
        label2.TabIndex = 2;
        label2.Text = "Subsidiar S.A";
        label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(455, 125);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(388, 34);
        label3.TabIndex = 3;
        label3.Text = "Digite la contraseña para el ingreso:";
        label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // TbPassword
        // 
        TbPassword.Enabled = false;
        TbPassword.Location = new System.Drawing.Point(579, 186);
        TbPassword.Name = "TbPassword";
        TbPassword.PasswordChar = '*';
        TbPassword.Size = new System.Drawing.Size(136, 23);
        TbPassword.TabIndex = 4;
        // 
        // Btn1
        // 
        Btn1.Location = new System.Drawing.Point(545, 243);
        Btn1.Name = "Btn1";
        Btn1.Size = new System.Drawing.Size(48, 40);
        Btn1.TabIndex = 5;
        Btn1.Text = "1";
        Btn1.UseVisualStyleBackColor = true;
        Btn1.Click += WriteNumber;
        // 
        // Btn3
        // 
        Btn3.Location = new System.Drawing.Point(687, 243);
        Btn3.Name = "Btn3";
        Btn3.Size = new System.Drawing.Size(48, 40);
        Btn3.TabIndex = 5;
        Btn3.Text = "3";
        Btn3.UseVisualStyleBackColor = true;
        Btn3.Click += WriteNumber;
        // 
        // Btn2
        // 
        Btn2.Location = new System.Drawing.Point(618, 243);
        Btn2.Name = "Btn2";
        Btn2.Size = new System.Drawing.Size(48, 40);
        Btn2.TabIndex = 5;
        Btn2.Text = "2";
        Btn2.UseVisualStyleBackColor = true;
        Btn2.Click += WriteNumber;
        // 
        // Btn4
        // 
        Btn4.Location = new System.Drawing.Point(545, 307);
        Btn4.Name = "Btn4";
        Btn4.Size = new System.Drawing.Size(48, 40);
        Btn4.TabIndex = 5;
        Btn4.Text = "4";
        Btn4.UseVisualStyleBackColor = true;
        Btn4.Click += WriteNumber;
        // 
        // Btn5
        // 
        Btn5.Location = new System.Drawing.Point(618, 307);
        Btn5.Name = "Btn5";
        Btn5.Size = new System.Drawing.Size(48, 40);
        Btn5.TabIndex = 5;
        Btn5.Text = "5";
        Btn5.UseVisualStyleBackColor = true;
        Btn5.Click += WriteNumber;
        // 
        // Btn6
        // 
        Btn6.Location = new System.Drawing.Point(687, 307);
        Btn6.Name = "Btn6";
        Btn6.Size = new System.Drawing.Size(48, 40);
        Btn6.TabIndex = 5;
        Btn6.Text = "6";
        Btn6.UseVisualStyleBackColor = true;
        Btn6.Click += WriteNumber;
        // 
        // Btn7
        // 
        Btn7.Location = new System.Drawing.Point(545, 371);
        Btn7.Name = "Btn7";
        Btn7.Size = new System.Drawing.Size(48, 40);
        Btn7.TabIndex = 5;
        Btn7.Text = "7";
        Btn7.UseVisualStyleBackColor = true;
        Btn7.Click += WriteNumber;
        // 
        // Btn8
        // 
        Btn8.Location = new System.Drawing.Point(618, 371);
        Btn8.Name = "Btn8";
        Btn8.Size = new System.Drawing.Size(48, 40);
        Btn8.TabIndex = 5;
        Btn8.Text = "8";
        Btn8.UseVisualStyleBackColor = true;
        Btn8.Click += WriteNumber;
        // 
        // Btn9
        // 
        Btn9.Location = new System.Drawing.Point(687, 371);
        Btn9.Name = "Btn9";
        Btn9.Size = new System.Drawing.Size(48, 40);
        Btn9.TabIndex = 5;
        Btn9.Text = "9";
        Btn9.UseVisualStyleBackColor = true;
        Btn9.Click += WriteNumber;
        // 
        // BtnLogin
        // 
        BtnLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        BtnLogin.Location = new System.Drawing.Point(455, 442);
        BtnLogin.Name = "BtnLogin";
        BtnLogin.Size = new System.Drawing.Size(113, 26);
        BtnLogin.TabIndex = 5;
        BtnLogin.Text = "Ingresar";
        BtnLogin.UseVisualStyleBackColor = true;
        BtnLogin.Click += BtnLogin_Click;
        // 
        // BtnClear
        // 
        BtnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        BtnClear.Location = new System.Drawing.Point(592, 442);
        BtnClear.Name = "BtnClear";
        BtnClear.Size = new System.Drawing.Size(113, 26);
        BtnClear.TabIndex = 5;
        BtnClear.Text = "Limpiar";
        BtnClear.UseVisualStyleBackColor = true;
        BtnClear.Click += BtnClear_Click;
        // 
        // BtnClose
        // 
        BtnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        BtnClose.Location = new System.Drawing.Point(729, 442);
        BtnClose.Name = "BtnClose";
        BtnClose.Size = new System.Drawing.Size(113, 26);
        BtnClose.TabIndex = 5;
        BtnClose.Text = "Salir";
        BtnClose.UseVisualStyleBackColor = true;
        BtnClose.Click += BtnClose_Click;
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { acercaDeToolStripMenuItem });
        menuStrip1.Location = new System.Drawing.Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new System.Drawing.Size(887, 24);
        menuStrip1.TabIndex = 6;
        menuStrip1.Text = "menuStrip1";
        // 
        // acercaDeToolStripMenuItem
        // 
        acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
        acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
        acercaDeToolStripMenuItem.Text = "Acerca de";
        // 
        // courseInfo
        // 
        courseInfo.AutoSize = true;
        courseInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        courseInfo.ForeColor = System.Drawing.Color.Red;
        courseInfo.Location = new System.Drawing.Point(545, 503);
        courseInfo.Name = "courseInfo";
        courseInfo.Size = new System.Drawing.Size(0, 20);
        courseInfo.TabIndex = 7;
        // 
        // AuthenticationView
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.RosyBrown;
        ClientSize = new System.Drawing.Size(887, 528);
        Controls.Add(courseInfo);
        Controls.Add(menuStrip1);
        Controls.Add(Btn2);
        Controls.Add(Btn3);
        Controls.Add(Btn9);
        Controls.Add(Btn8);
        Controls.Add(BtnClose);
        Controls.Add(BtnClear);
        Controls.Add(BtnLogin);
        Controls.Add(Btn7);
        Controls.Add(Btn6);
        Controls.Add(Btn5);
        Controls.Add(Btn4);
        Controls.Add(Btn1);
        Controls.Add(TbPassword);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(pictureBox1);
        MainMenuStrip = menuStrip1;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.MenuStrip menuStrip1;

    private System.Windows.Forms.Button Btn3;
    private System.Windows.Forms.Button Btn2;
    private System.Windows.Forms.Button Btn4;
    private System.Windows.Forms.Button Btn5;
    private System.Windows.Forms.Button Btn6;
    private System.Windows.Forms.Button Btn7;
    private System.Windows.Forms.Button Btn8;
    private System.Windows.Forms.Button Btn9;

    private System.Windows.Forms.Button Btn1;

    private System.Windows.Forms.TextBox TbPassword;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.PictureBox pictureBox1;

    #endregion

    private Button BtnLogin;
    private Button BtnClear;
    private System.Windows.Forms.Button BtnClose;
    private ToolStripMenuItem acercaDeToolStripMenuItem;
    private Label courseInfo;
}